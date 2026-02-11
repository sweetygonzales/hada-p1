
# Assignment 1a - Using Git


Florian Schoner

P1. What do you think the -n option in the revert command means?
-> The option -n means --no-commit. Revert is but not commited automaticly

P2. Which changes have been made when executing the reset command?
-> git reset --hard resets: HEAD, index and Working dir. All changes after the commmit are lost

P3. What differences do you see between revert and reset?
-> revert creats a new commit which reverts the changes but the history stays the same
-> reset moves branch pointer to the last commit. It changes the history

