---
title: "Engineers:  the challenge of enough documentation"
date: "2022-01-15"
aliases:
  - /engineers-the-challenge-of-enough-documentation
featured_image: "/images/Documents-Enough-1024x576.png"
categories: 
  - "technology"
---
The question: In software engineering practices especially in the areas of Scrum, Agile, or XP, what documentation is necessary to build a quality product?

The debate on documentation feels political. Each side of the spectrum is moving farther away from the center and becoming extreme with documentation practices. Snippets and quotes out of context are not useful to justify whether to document or not. Each stance has created a quality gap in the delivery, maintenance, and innovation of systems today. The pendulum is nowhere in the practicality zone.

## Scoping to engineering documentation

Based upon experience and research there are essentially two main categories of documentation:

- Software product documentation - That documentation which is useful for the end user of the software.
- Engineering documentation - The documentation that facilitates the creation and upkeep of the software.

Most everyone would agree that great product documentation leads to a better customer experience. The argument for creating these artifacts is less controversial and more well defined depending on your product's primary audience. There has been significant degradation of the end user experience with documentation. Putting that aside, let's tackle engineering documentation.

## Why has engineering documentation quality declined?

Most agree that there has been a large shift in the approach of delivering software to more agile methodologies. Each area of software engineering practices is flexing, adjusting, and refining to meet the demands of faster time to market. Engineering documentation is no exception.

### Incorrect interpretation of the Agile Manifesto

I have worked with many engineers who believe any time spent documenting is a waste. Much is based upon a statement in the Agile Manifesto:

> We value ... Working software over comprehensive documentation ... That is, while there is value in the items on the right, we value the items on the left more.
> 
> [Manifesto for Agile Software Development (agilemanifesto.org)](https://agilemanifesto.org/)

People quote the manifesto consistently, but only the first part "working software over comprehensive documentation". In addition, the words "comprehensive documentation" translates to "no documentation" and then it is anarchy to suggest creating design documents to understand the system.

It isn't just engineers that have taken this approach. Requirement definitions are being "watered down" into user stories or single line requirement items by program managers and business analysts. Writing a coherent spec is replaced by a jumbled list of disconnected features, that aren't fully fleshed out.

### The transformation of the Software Engineering role

As businesses work to become lean and more efficient, decisions have been made to reduce or eliminated roles surrounding software engineering for the sake of "agility". The ratio gap between the number of software engineers to business resources is widening. The need is still there and needs to be filled. Testing roles are being diminished, therefore another role is being heaped on the engineer to be managed. And to top that off, Cloud deployment and CI/CD practices have led to the removal of service engineers, with software engineers picking up the slack.

> software is a complex machine, composed of moving parts, and it needs a manual. Working on software without guidance, without documentation is anxiety-producing; not having documentation makes it hard to deploy code with confidence. Complex code (read: all code) simply _is not production ready without documentation_
> 
> [No Flex Zone: Empathy Driven Development | by Duretti Hirpa | Medium](https://medium.com/@duretti/no-flex-zone-empathy-driven-development-aebf4d8cf7cf)

Software engineers can't do everything while building software, so what has to go?

- Architectural design and review: We just need to get feature X out the door and this is how we can do it quickly. Technical debt can be mitigated later.
- Regression testing: Who has time? Let's write some automated tests to cover some basics.
- Deployment documentation: We already know how it is configured. Six months from now, it will be a problem for someone else.
- Internal feature design. It is difficult to get engineers to write out tasks for the upcoming Sprint with the excuse "I don't have time".

## Getting to better documentation that is just enough

Consider investing additional time and resources into documentation for these benefits

- The next person coming on board the team will thank you (so will your organization). Ramp up time for new people on a team varies by the quality of the artifacts that are available:

> There is considerable merit in creating a persistent group memory in written form because human memories are incomplete, are inconsistent, and decay with time.
> 
> [Agile Requirements: What’s the Big Deal? (modernanalyst.com)](https://www.modernanalyst.com/Resources/Articles/tabid/115/ID/3573/Agile-Requirements-Whats-the-Big-Deal.aspx)

- Have validation for your tests and requirements. By having the right requirements, tests can become the self-documenting part of the code. However, just making up tests without requirements problematic.
- Add work items and allocate time for updating architectural and design documentation.

Just enough documentation will save you time, effort and resources. Most critically though, it will improve your quality.
