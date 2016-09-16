# _WordCounter_

#### _the user can use the Word Counter to see how many instances of one particular word there are in a string _

#### By _**Ian Wilcox **_

## Description/Specs

| Behavior     | Input word | input string  |Output Example  |
| ------------- |:-------------:| :----------:| :----------: |
| if the user enters one letter as both the input and output they will result in a match | a | a | 1 match|
| if the user enters different letters as both the input and output they will not match | a | b | 0 matches |
| if the user enters one letter in the input and two for output they will result two matches | a | a a | 2 matches |
| if the user enters one letter in the input and two different  letters for output they will result one match | a | a b | 1 match |
| if the user enters one word as both the input and output they will result in a match | apple | apple | 1 match|
| if the user enters different words as both the input and output they will not match | apple | banana | 0 matches |
| if the user enters one word in the input and two for output they will result two matches | cat | cat cat | 2 matches |
| if the user enters a sentence the word will match with only exact matches not other words containing the word | the | the dog over there behind the fence is theirs | 2 matches |

## Support and contact details

Please contact the author if you have any questions or comments.

## Technologies Used

C#, Nancy, and cshtml.

### License

Copyright (c) 2016 **_Ian Wilcox_**

This software is licensed under the MIT license.
