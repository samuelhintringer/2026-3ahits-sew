#!/usr/bin/env bash
set -euo pipefail

usage() {
  cat <<'EOF'
Verwendung:
  ./new.sh ["ProjektName"]             Neues Konsolenprojekt erstellen
  ./new.sh --delete ["ProjektName"]    Projekt aus der Lösung entfernen und löschen
  ./new.sh -h | --help                 Diese Hilfe anzeigen

Ohne ProjektName wird der Name interaktiv abgefragt.

Der ProjektName wird in einen gültigen Namen umgewandelt:
  - Pfadangaben werden auf den Ordnernamen reduziert (src/Uebung_2_1/ -> Uebung_2_1)
  - Umlaute werden umgeschrieben (Ä -> Ae, ö -> oe, ß -> ss, ...)
  - Leerzeichen, Punkte und Klammern werden zu Unterstrichen
  - Mehrfache Unterstriche werden zusammengefasst, Unterstriche am Ende entfernt
  Der Name muss danach mit einem Buchstaben beginnen und darf nur Buchstaben,
  Zahlen und Unterstriche enthalten.

Beim Erstellen:
  - Projekt wird in src/ProjektName angelegt und zu ConsoleApp.slnx hinzugefügt
  - Nullable-Prüfungen werden deaktiviert
  - Program.cs erhält einen Kommentar-Kopf mit dem Projektnamen

Namen mit Leerzeichen oder Klammern müssen in "..." stehen.

Beispiele:
  ./new.sh "Übung 2.1 (Schulklasse)"      -> src/Uebung_2_1_Schulklasse
  ./new.sh --delete "Übung 2.1 (Schulklasse)"
  ./new.sh --delete src/Uebung_2_1_Schulklasse/
EOF
}

if [[ $# -ge 1 && ( "$1" == "-h" || "$1" == "--help" ) ]]; then
  usage
  exit 0
fi

# reset chat.disableAIFeatures in .vscode/settings.json to true to avoid AI features in VSCode
sed -i 's/"chat.disableAIFeatures": false/"chat.disableAIFeatures": true/' .vscode/settings.json

action="create"
if [[ $# -eq 2 && "$1" == "--delete" ]]; then
  action="delete"
  project_name="$2"
elif [[ $# -eq 1 && "$1" == "--delete" ]]; then
  action="delete"
  read -r -p "Projektname zum Löschen: " project_name
elif [[ $# -eq 1 ]]; then
  project_name="$1"
elif [[ $# -eq 0 ]]; then
  read -r -p "Projektname: " project_name
else
  usage
  exit 1
fi

if [[ -z "$project_name" ]]; then
  echo "Kein Projektname angegeben."
  exit 1
fi

# Pfadangaben wie src/Uebung_2_1/ auf den Ordnernamen reduzieren
while [[ "$project_name" == */ ]]; do
  project_name="${project_name%/}"
done
project_name="${project_name##*/}"

# Umlaute umschreiben und Punkte und Leerzeichen durch Unterstriche ersetzen
project_name="${project_name//Ä/Ae}"
project_name="${project_name//Ö/Oe}"
project_name="${project_name//Ü/Ue}"
project_name="${project_name//ä/ae}"
project_name="${project_name//ö/oe}"
project_name="${project_name//ü/ue}"
project_name="${project_name//ß/ss}"
project_name="${project_name//(/_}"
project_name="${project_name//)/_}"
project_name="${project_name//./_}"
project_name="${project_name// /_}"
project_name=$(echo "$project_name" | sed -E 's/_+$//; s/_{2,}/_/g')

if [[ ! "$project_name" =~ ^[A-Za-z][A-Za-z0-9_]*$ ]]; then
  echo "Der Projektname muss mit einem Buchstaben beginnen und darf nur Buchstaben, Zahlen oder Unterstriche enthalten."
  exit 1
fi

# Farben nur verwenden, wenn die Ausgabe in ein Terminal geht
if [[ -t 1 ]]; then
  bold_blue=$'\e[1;34m'
  reset=$'\e[0m'
else
  bold_blue=""
  reset=""
fi

solution_file="ConsoleApp.slnx"
project_dir="src/$project_name"
project_file="$project_dir/$project_name.csproj"

if [[ ! -f "$solution_file" ]]; then
  echo "Lösungsdatei $solution_file wurde nicht gefunden. Starte das Skript im Repository-Hauptordner."
  exit 1
fi

if [[ "$action" == "delete" ]]; then
  if [[ ! -d "$project_dir" || ! -f "$project_file" ]]; then
    echo "Das Projekt $project_name wurde nicht gefunden."
    exit 1
  fi

  dotnet sln "$solution_file" remove "$project_file"
  rm -rf -- "$project_dir"

  echo "Projekt ${bold_blue}${project_name}${reset} wurde aus der Lösung entfernt und gelöscht."
  exit 0
fi

if [[ -e "$project_dir" ]]; then
  echo "Der Ordner $project_dir existiert bereits."
  exit 1
fi

dotnet new console --output "$project_dir" --name "$project_name" --use-program-main
sed -i 's|<Nullable>enable</Nullable>|<Nullable>disable</Nullable>|' "$project_file"
program_file="$project_dir/Program.cs"
{
  printf '// ------------------------------\n// %s\n// ------------------------------\n\n' "$project_name"
  sed '1s/^\xEF\xBB\xBF//' "$program_file"
} > "$program_file.tmp"
mv "$program_file.tmp" "$program_file"
dotnet sln "$solution_file" add "$project_file"

echo
echo "Projekt ${bold_blue}${project_name}${reset} wurde erstellt und zur Lösung hinzugefügt."
echo "Starten: dotnet run --project $project_dir"