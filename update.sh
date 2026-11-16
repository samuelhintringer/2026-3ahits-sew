#!/bin/bash

name="2026-3ahits-sew"

git add ~/$name #der pfad muss direkt auf das geklonte Verzeichnis führen nicht darunter oder darüber

git stage ~/$name #hier gilt das Kommentar das darüber steht

git commit -m "update"

git push
