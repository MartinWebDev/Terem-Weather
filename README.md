# Assumptions
1. We can ignore the number of days data was recorded for (column 7) as there is only 1 record that is not blank or 1,
and including this would introduce a world of mental pain to factor in what I hereby dub "unaggregating" data 😜
2. We will also ignore column 8, quality of measurement, and assume all data to be accurate.

# Code design choices
No interfaces have been created for low level models, such as WeatherDataMonth. I believe this level of interfacing to be redundant and wasteful.
If you were ever to make changes to your underlying data structure then your interfaces would become outdated anyway and are therefore unnecessary.
\Interfaces have only been created for items which could in theory be swapped and replaced without affecting other areas of the code,
ie: the point of interfaces 👍