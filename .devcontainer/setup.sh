#!/usr/bin/env bash
set -euo pipefail

sudo apt-get update
sudo apt-get install -y sqlite3

if ! grep -Fq '# Repository shell prompt' "$HOME/.bashrc"; then
  cat >> "$HOME/.bashrc" <<'EOF'

# Repository shell prompt
PS1='\$ '
EOF
fi
