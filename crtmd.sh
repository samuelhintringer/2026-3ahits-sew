#!/usr/bin/env bash

cd berichte

cat << EOF > $(date +"%Y%m%d").md
# Arbeitsbericht

- Name: Samuel Hintringer
- Fach: SEW
- Datum: $(date +"%d.%m.%Y")
- Klasse: 3AHITS
- Thema: $1
- Aufgaben: $2
- Source: $3
EOF

cd ..

./update.sh
