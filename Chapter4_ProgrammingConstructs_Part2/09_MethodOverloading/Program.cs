
Console.WriteLine(AddOperations.Add(10, 10));

Console.WriteLine(AddOperations.Add(10.4, 17.6));

Console.ReadLine();

public static class AddOperations
{
    // Overload Add() method.
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static long Long(long x, long y)
    {
        return x + y;
    }
}

