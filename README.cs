## By Derek Hammer
*_A Project set up, where a user inserts a word and a list of other words. It then checks to see if the word is repeated in the following list, and how many times it is repeated.  Only an exact match is counted._*

## Specs
|Behavior|Input|Output|
|--------|-----|------|
|User can input an initial word|pizza|true|
|User can input multiple words into a list|sandwich hamburger pizza|true|
|Program will check to see if any words match|sandwich hamburger pizza|true|
|Program will not account for capitalization|sandwich hamburger Pizza|false|
|Program will count the number of times the word is matched|pizza pizza = 2|true|
