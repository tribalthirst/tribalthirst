---
title: "Personal Git Configurations"
date: "2022-03-11"
categories: 
  - "technology"
---

Reminder for my basic git aliases in Powershell along with my modules for posh-git and oh-my-posh:

```powershell
function ga { & git add --all $args }
function gb { & git branch }
function gc { & git commit -ev $args }
function gco { & git checkout $args }
function gfcurrent { & git fetch --all; git rebase}
function gfiles { & git log --name-status}
function gfmain {& git fetch --all; git rebase origin/main}
function gfmaster {& git fetch --all; git rebase origin/master}
function gll { & git log --pretty=format:"%C(yellow)%h%Cred%d\\\\ %Creset%s%Cgreen\\\\ \[%cn\]" --decorate --numstat -n $args }
function glog { & git log --pretty=format:"%C(yellow)%h%Cred%d\\\\ %Creset%s%Cgreen\\\\ \[%cn\]" --decorate -n $args}
function gmain { & git checkout main}
function gmaster { & git checkout main}
function gnb { & git gm ; git pull ; git co --no-track -b $args}
function gpull { & git pull $args }
function gpush { & git push origin $(git rev-parse --abbrev-ref HEAD)}
function gs{ git status }
function gtree { & git log --graph --oneline --decorate -n $args }
function gunstage { & git reset HEAD}

Import-module posh-git
Import-module oh-my-posh
Set-Theme Paradox
```