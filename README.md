# Leetspeak Translator Web Application

#### _Translate regular text into an unreadable amalgamation of characters_

#### By _**Alexandra Holcombe && Caitlin Hines**_

## Description

This web application will take a string from a user and convert it into a simplified version of leetspeak using the following rules:
* The letter "e" should be replaced with "3".
* The letter "o" should be replaced with "0".
* The capital letter (not the lower case), "I", should be replaced with "1".
* All instances of "s" should be replaced with "z" UNLESS it is the first letter of the word.


## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The application will output a number if given a number.**
* Example Input: 65
* Example Output: 65

**The application will replace all instances of the letter "e" or "E" with the number 3.**
* Example Input: "bee", "BEE"
* Example Output: "b33", "B33"

**The application will replace all instances of the letter "o" or "O" with the number 0.**
* Example Input: "boo", "BOO"
* Example Output: "b00", "B00"

**The application will replace all instances of the capital letter "I" with the number 1.**
* Example Input: "input", "Input"
* Example Output: "input", "1nput"

**The application will replace all instances of the letter "s" with the letter "z" unless it is the first letter of the word.**
* Example Input: "Seesaw"
* Example Output: "S33zaw"

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Caitlin Hines at caitlinhines@me.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe && Caitlin Hines_**
