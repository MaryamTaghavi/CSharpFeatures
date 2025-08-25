// Constant fields of a class are implicity static

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