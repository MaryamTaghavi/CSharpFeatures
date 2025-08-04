// The length of current string
Length() ;

//Compares two strings
Compare() ;

//A string Contains a specific substring?
Contains() ;

//This method tests whether two string onjects contain identical character data.
Equals() ;

//This static method formats a string using other primitives (numerical data, other strings).
//This method works with objects (reference type), so if you pass a valueType into, value types are boxed.
Format() ;

string name = "Parsa";
int age = 9;
string result = string.Format("My name is {0} and I am {1} years old.", name, age);

double price = 12345.678;
string formatted = string.Format("Price: {0:C}", price);

//This method returns a string array containing the substrings in this instance that are delimited by elements of a specified char array or string array
Split() ;

//This method removes all specified characters from the beginning and end of the current string.
Trim() ;

//Create a copy of the current string in uppercase or lowercase format.
ToUpper() / ToLower() ;

//These methods are used to receive a copy of a string with modifications (characters removed or replaced).
Remove() / Replace() ;

//This methods inserts a string within a given string.
Insert();

string text = "Hello World";
string result = text.Insert(6, "Beautiful ");
"Hello Beautiful World" ;

//Those methods fix totalLength for string
PadLeft() / PadRight() ;

string name = "Ali";

Console.WriteLine(name.PadLeft(10));
Console.WriteLine(name.PadRight(10));

       Ali
Ali       
  
