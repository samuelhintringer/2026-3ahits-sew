Basis Repository für C# Entwicklung in VSCode

HTL Coding Server: `coding.htl-braunau.at` (auch von Extern erreichbar)

# Neues Projekt anlegen

Verwende die Übungsbezeichnung als Projektnamen.

## Über VS Code

1. `Ctrl+Shift+P` (Mac: `Cmd+Shift+P`) → **Tasks: Run Task** → **Neues C# Projekt für coding.htl-braunau.at**
2. Projektname eingeben, z.B. `Übung 2.1 (Schulklasse)`, und mit Enter bestätigen

Umlaute, Leerzeichen, Punkte und Klammern werden automatisch umgewandelt, das Projekt landet in `src/Uebung_2_1_Schulklasse`.

## Neues Projekt im Terminal

Alternativ kann ein neues Projekt auch im Terminal angelegt werden:

```sh
./new.sh
```

# VS Code Extensions

```sh
code --install-extension ms-dotnettools.csdevkit
```

# git Einstellungen

```sh
git config --global user.name "John Doe"
git config --global user.email johndoe@example.com
```

# Diverses

```sh
# command prompt auf $ verkürzen
echo "export PS1='\$ '" >> ~/.bashrc
source ~/.bashrc
```