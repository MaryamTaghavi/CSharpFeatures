// Prints : 20, 10, 30
Console.WriteLine("{1}, {0}, {2}" , 10 , 20 , 30) ;

// C or c : used to format currency, by default the flag will prefix the local cultural symbol.
// c format: $99,999.00
Console.WriteLine("c format: {0:c}" , 99999) ;

// D or d : used to format decimal numbers. This flag may also specify minimum number of digits used to pad the value.
// d9 format: 000099999
Console.WriteLine("d9 format: {0:d9}" , 99999) ;

// F or f : used for fixed-point formatting. This flag may also specify the minimum number of digits used to pad the value.
// f3 format: 99999.000
Console.WriteLine("f3 format: {0:f3}" , 99999) ;

// N or n : used for basic numerical formatting(with commas).
// n format: 99,999.00
Console.WriteLine("n format: {0:n}" , 99999) ;
