// Struct is valueType but class is referenceType

using System.Drawing;

Point1 myPoint;
myPoint.X = 349;
myPoint.Y = 86;
myPoint.Display();

myPoint.Increment();
myPoint.Display();


// because struct is value type if change p4, p3 doesn't change
Point2 p1 = new Point2(5, 10);
Point2 p2 = p1;
p2.X = 99;

Console.WriteLine(p1.X);


// because class is referense type if change p4, p3 change
Point3 p3 = new Point3(5, 10);
Point3 p4 = p3;
p4.X = 99;

Console.WriteLine(p3.X);

Console.ReadLine();

struct Point1
{
    public int X;
    public int Y;

    public void Increment()
    {
        X++; Y++ ;
    }

    public void Decrement()
    {
        X--; Y-- ;
    }

    public void Display()
    {
        Console.WriteLine("X = {0} , Y = {1}", X, Y);
    }
}

public struct Point2
{
    public int X;
    public int Y;

    public Point2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point2: ({X}, {Y})");
    }
}

public class Point3
{
    public int X;
    public int Y;

    public Point3(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point3: ({X}, {Y})");
    }
}