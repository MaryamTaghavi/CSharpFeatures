// Constant fields of a class are implicity static


string foo = "Foo";
string bar = "bar";
string foobar = $"{foo}{bar}";
Console.WriteLine(foobar);

Console.WriteLine(MyMathClass.PI);
class MyMathClass
{
    public const double PI = 3.14;

    public MyMathClass()
    {
        // Not-Possible must assign at time of declaration
        // PI = 3.6;
    }
}