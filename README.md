TP24 Api
Author: Ian Richards
Date: 22-08-2023
Version: 1

TP24 Api is an api processes payload as receivables and allows for statistics generation

Assumptions made
It was assumed that the PaidValue would be updated after a payload was fetched from the api and that this would reflect the current total paid by the user or system integrating with this api.

It was also assumed that the opening balance wouldn't change from the initial value and that any subsequent credit applications would be unique and therefore have no affect on any other receivable

To run this application you are required to have .net 7 runtime installed

I have used an in memory database but have not seeded this with any initial data as yet.

There are no unit tests surround the repositories as I did not want to spend time testing an in memory database as this wouldn't reflect a real world database test.

Total time spent on this was around 5 hours with minimal disruption
