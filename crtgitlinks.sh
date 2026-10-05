#!/usr/bin/env bash

reponame="$(git config --get remote.origin.url | rev | cut -d/ -f1 | rev | cut -d. -f1)"
link="https://samuelhintringer.github.io/$reponame/berichte/"

cd berichte

{
for b in $(ls 2*.md)
do
    echo -e $link${b/md/html}"\n"
done
} > gitlinks.md

cd ..

sleep 5

./update.sh

