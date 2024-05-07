---
title: "The Anatomy of a Review in 5 Questions"
date: "2017-03-05"
aliases:
  - /5-questions-reviews
categories: 
  - "technology"
tags: 
  - "code-reviews"
---
In a few weeks I am going to give a presentation on doing great code reviews. Here is a piece that I wrote 5 years ago that captured the 5 W's. There are a few changes that I felt were appropriate to make as an update. Most importantly, the guidance below doesn't just apply to code reviews, but any review that you may do.<!--more-->

## Who

The review you are performing is for your colleague,  a teammate, possibly even your friend.  The review should be done with sensitivity for the hard work and effort by the contributor.  Keep in mind they may be reviewing something you have done in the future. You also have an external audience you are doing the review for.  There may be other reviewers.  Managers may take a look also, so be professional.  Don’t add commentary on policies, rules, or style that give the appearance of negativity.

## What

It is very difficult to determine what to put in a review.  I believe it is necessary to start with a checklist of some type for consistency.  Here are other tips around what to put into the review:

- Ensure that the scope of the review has been identified. Maybe the person is only looking for feedback of one area of the document or a specific method in a code review.
- Give your comments a priority. This may be a number based system such a priority 1, 2, 3 or text such as "Required Change", "Suggestion Revision", or "Nice to Have".
- Provide a potential solution suggestion if applicable. Everyone sees the world differently.  You may have experience that gives you a different context that should be shared.
- Highlight the good things about the review.  Share them with the whole team also.  This will provide encouragement to the user who did the original look.

Below is an example of how your comment could look in the code review:

* **Reviewed Item:** There is an unused parameter.  append is never used Location: XClass at line 45 in Method SaveFile(string x, bool append) 
  * **Priority:** 3 
  * **Observations:** It is obvious of the intent of Y in terms of append.  Great job in thinking about the upcoming features. 
  * **Suggestion:** Add the branches to determine whether to append or not and alert the user that the append feature is not implemented yet through an exception.

## When

Reviews should be an iterative process in themselves.  One of the fatal mistakes is to wait to review until the last days of the cycle.  A couple of core tips that I have seen work really well:

- Write an outline and get a quick buddy check. Are we missing any major items?
- Review at the 80% mark. By this time most of the thoughts are formulated so missing information should be at a minimum.
- Schedule specific time to review for other people.

## Where

If you don’t have a documentation system associated with the work you are doing get one.   It is everyone’s responsibility to provide the documentation necessary to make informed decisions.  At the very least have a central repository where reviews can be kept.  Will anyone read them?  I don’t know, but I have worked in one company that highly encouraged new employees to read the code reviews.  It had a profound effect on developer coding styles from that point on.

## Why

- There are so many research studies that have concluded that the best way to raise quality is through great reviews.  If that isn’t good enough for you here are a couple of other effects of an established review system:
- Consistency across teams and processes.
- Shared knowledge across the organization.
- Better maintainability when "code" reviews are done consistently.
- Great opportunities for growth and learning, more so for the reviewer then the person that did the work.
- You are contributing to the sanity of other contributors who might have to modify or update your work long after you are gone.

## Questions

Could you benefit from being more rigorous in your review processes?  What ways have you found to be most effective in performing reviews of work?
