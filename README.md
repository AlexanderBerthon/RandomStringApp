# RandomStringApp
Random String Generator App

User can control the length of the string between 8-20 characters
User can control what character sets are included in the string
 - lower case alphabetical characters
 - upper case alphabetical characters
 - numbers
 - symbols
 - whitespace

at least 1 character set must be selected (other than whitespace)

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
