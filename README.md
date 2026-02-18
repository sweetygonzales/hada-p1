P1: Which branch exactly has been uploaded?
->The master branch (or main) is uploaded using:

git push -u origin master

P2: What happens when using Compare with the unmodified version?
->It shows no differences if the file hasn’t changed; otherwise, it shows changes between the working file and the last commit.

P3: Do you see changes in the remote repository? Why?
->No, local changes are not on GitHub until you push. Use: git push

P4: What does “Confirm all” mean? Equivalent command?
->Commits all local changes. Equivalent: git commit -a -m "message"

P5: What does “Confirm all and insert” mean? Equivalent command?
->Commits and pushes changes to remote. Equivalent:
      git commit -a -m "message"
      git push

P6: What does “Confirm all and synchronize” mean? Equivalent command?
  ->Commits, fetches, merges, and pushes in one step. Equivalent:

    git commit -a -m "message"
    git fetch origin
    git merge origin/master
    git push

P7: Difference between Sync and Extract? Equivalent commands?
->
    Sync: pull + push automatically →

    git pull --rebase origin master
    git push


    Extract: fetch only; merge manually →

    git fetch origin
    git merge origin/master
