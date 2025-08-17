// Define Tuple

(string First, int Second, string Third) values1 = ("a", 5, "c");

var values2 = (First: "a", Second: 5, Third: "c");

Console.WriteLine(values1.Item1);

Console.WriteLine(values1.First);

Console.WriteLine(" => Nested Tuples");
var nt = (5, 4, ("a", "b"));