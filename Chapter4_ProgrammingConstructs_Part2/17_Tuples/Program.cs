// Define Tuple

(string First, int Second, string Third) values1 = ("a", 5, "c");

var values2 = (First: "a", Second: 5, Third: "c");

Console.WriteLine(values1.Item1);

Console.WriteLine(values1.First);

Console.WriteLine(" => Nested Tuples");
var nt = (5, 4, ("a", "b"));


// Equality/Inequality

Console.WriteLine("=> Tuples Equality/Inequality");
// lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers); // Also true
// converted type of left is (long, long)
(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple); // Also true
// comparisons performed on (long, long) tuples
(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond); // Also true


//Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

//Deconstructing Tuples

(int X, int Y) myTuple = (4, 5);
int x = 0;
int y = 0;
(x, y) = myTuple;
Console.WriteLine($"X is: {x}");
Console.WriteLine($"Y is: {y}");

(int x1, int y1) = myTuple;
Console.WriteLine($"x1 is: {x}");
Console.WriteLine($"y1 is: {y}");

int x2 = 0;
(x2, int y2) = myTuple;
Console.WriteLine($"x2 is: {x}");
Console.WriteLine($"y2 is: {y}");