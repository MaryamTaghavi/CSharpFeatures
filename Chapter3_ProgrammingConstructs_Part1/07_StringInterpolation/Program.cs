int age = 4 ;
string name = "Maryam" ;

// Using curly-bracket syntax
string greeting = String.Format("Hello {0} you are {1} years old." , name , age) ;
Console.WriteLine(greeting) ;

//Using string interpolation
string greeting2 = $"Hello {name} you are {age} years old." ;
Console.WriteLine(greeting2) ;
