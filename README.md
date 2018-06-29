## By Derek Hammer
*_A Project set up, where a user inserts a word and paragraph of other words. It then checks to see if the word is repeated in the following paragraph, and how many times it is repeated.  Only an exact match is counted._*

## Specs
|Behavior|Input|Output|
|--------|-----|------|
|User can input an initial word|pizza|true|
|User can input a paragraph or multiple words|I really love pizza|true|
|Program will check to see if any words match|I really love pizza|true|
|Program will not account for capitalization|I really love Pizza|false|
|Program will count the number of times the word is matched|pizza pizza = 2|true|
