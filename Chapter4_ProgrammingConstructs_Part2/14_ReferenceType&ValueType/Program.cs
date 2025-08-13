
using System;

ValueTypeContainingRefType();

Console.WriteLine("**** Passing Person object by value ****");
Person fred = new Person("Fred" , 12);
Console.WriteLine("Before by value call, Person is : ");
fred.Display();
SendAPersonByValue(fred);
Console.WriteLine("After by value call, Person is : ");
fred.Display();

Console.WriteLine("**** Passing Person object by reference ****");
Person mel = new Person("Mel", 23);
Console.WriteLine("Before by ref call, Person is : ");
mel.Display();
SendAPersonByReference(ref mel);
Console.WriteLine("After by ref call, Person is : ");
mel.Display();

string i = "" ;
CheckType(i);

Console.ReadLine();

// Passing Reference Types by Reference
static void SendAPersonByReference(ref Person p)
{
    p.personAge = 555;
    p = new Person("Nikki", 999);
}

static void SendAPersonByValue(Person p)
{
    p.personAge = 99;
    p = new Person("Nikki", 99);
}

// یک متد generic بنویس که تشخیص بده ورودی یک value type است یا reference type
static void CheckType<T>(T input)
{
    if(input.GetType().IsValueType)
    {
        Console.WriteLine("Input is valueType");
    }
    else
    {
        Console.WriteLine("Input is referenceType");
    }
}

static void ValueTypeContainingRefType()
{
    // Create the first Rectangle.
    Console.WriteLine("-> Creating r1");
    Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
    // Now assign a new Rectangle to r1.
    Console.WriteLine("-> Assigning r2 to r1");
    Rectangle r2 = r1;
    // Change some values of r2.
    Console.WriteLine("-> Changing values of r2");
    r2.RectInfo.InfoString = "This is new info!";
    r2.RectBottom = 4444;
    // Print values of both rectangles.
    r1.Display();
    r2.Display();
}

class ShapeInfo
{
    public string InfoString;
    public ShapeInfo(string info)
    {
        InfoString = info;
    }
}

struct Rectangle
{
    // The Rectangle structure contains a reference type member.
    public ShapeInfo RectInfo;
    public int RectTop, RectLeft, RectBottom, RectRight;
    public Rectangle(string info, int top, int left, int bottom, int right)
    {
        RectInfo = new ShapeInfo(info);
        RectTop = top; RectBottom = bottom;
        RectLeft = left; RectRight = right;
    }
    public void Display()
    {
        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
        "Left = {3}, Right = {4}",
        RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
    }
}


// Passing Reference Types by Value
class Person
{
    public string personName;
    public int personAge;

    #region Constructors
    public Person(string name , int age)
    {
        personName = name;
        personAge = age;
    }

    public Person() { }

    #endregion

    public void Display()
    {
        Console.WriteLine("Name: {0}, Age: {1}" , personName , personAge);
    }
}
