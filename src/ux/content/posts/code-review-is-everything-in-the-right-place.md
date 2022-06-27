---
title: "Code Review - Is everything in the right place?"
date: "2021-08-01"
aliases:
  - /code-review-is-everything-in-the-right-place
categories: 
  - "technology"
featured_image: "/images/posts/St-Petersburg.jpg"
tags: 
  - "technology"
---

Is your foundation in good shape?

One of the often overlooked parts of a code review is checking out the structure of the underneath repository. I refer to this as the "bones" or skeleton of the program, application, or service. It is often very easy to overlook a file or folder out of place. The subtle organization of files and folders can be beneficial for software engineers in future work.

## Separation of concerns

There are many reviews I have done where I failed to open up a an explorer window to review the overall structure of the repository. This has led to documentation being in a code folder, tests in the main code path for production, or even misplaced project/solution files where references start to build spaghetti references.

This is opinionated, but here is an example repository, with what I think are core folders for the structure of any project. The key is to maintain some consistency. If the files aren't in the right place during the review they can get cluttered and create confusion.

[![](/images/posts/code-review-explorer.png)]

Sample repository structure for coding

For example, notice how Tests are in their own folder. It allows for easy visual queues when inspecting the file tree structure. Documentation is placed as a first class citizen at the same level as code. The same goes for all your DevOps artifacts, such as builds, pipeline, and release scripts.

## Consistency matters

When I do a code review, I now make this my first task. I start by pulling down the code that is under review and then examining the file structure. Sometimes, depending on the review, I might do a PR into that branch with fixes for files and folders out of place. One thing I would encourage, don't just limit your review to the changes only. If you see where cleanup can happen, make it happen either through a PR for the review or through requesting changes through comments.

One last suggestion, put checking the file/folder structure as one of your tasks to do every time as a reviewer. Each review should have the contents local anyways (you are running the code as part of the review right?).
