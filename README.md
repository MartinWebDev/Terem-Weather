# Slight variation on task description
The task itself describes simply a command line type project,
which would imply a csv file would be passed in, presumably as a command line argument,
and then "stuff" occur to give the required output.\
However, the initial conversation with Andrew suggested that the test would revolve more about API based stuff.

Now, this is obviously somewhat ambigious between whether the expectation is a WebAPI project, or a Service, or even just a Respository.\
And any of these is not a "cli" project anyway. After further chatting with Andrew, we decided that I would make a sort of "in between" project.\
Thus, I will be created a repository type system to handle all the actual magic, which can then be hooked up to either a cli,
or a webapi, or anything else we might like.

I feel this is a good compramise between the 2 ideas, and makes the project much easier to keep in line with good coding standards anyway,\
namely separation of concerns and dependency inversion.

# Assumptions
1. We can ignore the number of days data was recorded for (column 7) as there is only 1 record that is not blank or 1,
and including this would introduce a world of mental pain to factor in what I hereby dub "unaggregating" data 😜
2. We will also ignore column 8, quality of measurement, and assume all data to be accurate.

# Code design choices
No interfaces have been created for low level models, such as WeatherDataMonth. I believe this level of interfacing to be redundant and wasteful.
If you were ever to make changes to your underlying data structure then your interfaces would become outdated anyway and are therefore unnecessary.\
Interfaces have only been created for items which could in theory be swapped and replaced without affecting other areas of the code,
ie: the point of interfaces 👍