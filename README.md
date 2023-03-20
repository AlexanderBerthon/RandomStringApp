# RandomStringApp
Random String Generator App

Length of the string can be adjusted to be between 8-20 characters

User can control what character sets are included in the string
 - lower case alphabetical characters
 - upper case alphabetical characters
 - numbers
 - symbols
 - whitespace

\**At least 1 character set must be selected (other than whitespace)

https://user-images.githubusercontent.com/71737894/226484702-00c35cae-3360-4a0b-b69e-89c20d387d58.mp4

__________________________________________________________________

Notes:

Whitespace is only 1 character in the array. The chance of it showing up in a random string
could be as low as.. 8.12% if all options are selected in an 8-character string (worse if longer). Is that a problem? not enough representation?

Chance at least 1 character from character set is represented in random 8 char string (all options selected)
 - symbol     = 96.26%
 - alphaLower = 92.26%
 - alphaUpper = 92.26%
 - numeric    = 58.93%
 - whitespace = 08.12%

Should all sets be equal in probability? 
There is a representation skew specifically around whitespace and numeric.
Could be solved by duplicating data within these pools until they are around the same size as the other pools but is that a good idea?

__________________________________________________________________

Updated probabilities:

Balanced each of the categories to be more or less even.
Fixed resulting issues due to the increased amount of whitespace. 
 - string cannot begin or end with whitespace
 - string cannot contain consecutive whitespaces

\**Whitespace representation is lower than the calculated probability due to these restrictions. New represented values below.

Chance at least 1 character from character set is represented in random 8 char string (all options selected)
 - symbol     = 96.26%
 - alphaLower = 92.26%
 - alphaUpper = 92.26%
 - numeric    = 95.20%
 - whitespace = 91.31% (~69.47%)
 
