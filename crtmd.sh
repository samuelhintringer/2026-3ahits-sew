#!/usr/bin/env bash

cat << EOF > $(date +"%y%m%d").md
# Arbeitsbericht

- Name: Samuel Hintringer
- Fach: SEW-Übunugen
- Datum: $(date +"%d.%m.%Y")
- Klasse: 2AHITS
- Thema: $1
- Aufgaben: $2
- Source: $3
EOF

./update.sh
