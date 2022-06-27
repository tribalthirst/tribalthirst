---
title: "Updating an Identity Seed Value"
date: "2015-08-17"
aliases:
  - /updatiing-an-identity-seed-value
categories: 
  - "technology"
---

I recently ran into an issue, where I had to mix environments while developing.  On top of the mixed environments, I was manipulating data. <!--more--> I had a few choices:

- Create an exact replica of the production data and an environment that I didn't manage or maintain.  (Approximately 6 hours)
- Do some mocking of the data that I was going to be updating.  (Didn't fully understand the black box well enough to know what happens to the data once it has been sent)
- Work on entirely new records that I could then later delete if needed from both systems.

In choosing the third option, I went to work.  I still wanted to be extra careful as I was manipulating a production environment as part of my testing (for those interested, I was passing data back and forth between a CRM system and a website).  I created my first record on the website and set forth to add it to the CRM.  I got an error message stating the record already exists!!!  How could this be possible.  It so happens that the production website had already added records where I was matching against the identity value.  It only took me about an hour to stare dumbfounded at the code, thinking I was doing something tragically wrong.

I didn't want to have a race condition between production and staging, so I remembered that you could set an Identity field to start at a certain number.  I asked myself if it was possible to do this after the initial table setup and it is.

[http://blog.sqlauthority.com/2007/03/15/sql-server-dbcc-reseed-table-identity-value-reset-table-identity/](http://blog.sqlauthority.com/2007/03/15/sql-server-dbcc-reseed-table-identity-value-reset-table-identity/)

DBCC CHECKIDENT (yourtable, reseed, 34)

I thought of a couple of other uses for this statement also:

- If you are changing to a major upgrade of certain tables, it might come in handy for just a numeric separation.
- Resetting the identity you were bulk deleting/adding/shuffling around information.

What would you use this for?  It was about 10 minutes of research and 5 seconds of execution.  I would say it was a timesaver for me.
