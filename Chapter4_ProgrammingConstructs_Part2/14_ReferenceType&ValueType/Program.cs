ValueTypeContainingRefType();

Console.WriteLine("**** Passing Person object by value ****");
Person fred = new Person("Fred", 12);
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

string i = "";
CheckType(i);

WriteChangeValue();
WriteChangeValueRef();

Exercise2();

Console.ReadLine();

#region Exercise 1
static void ChangeValue(int number)
{
    number = 100; // only changes local copy
}

static void WriteChangeValue()
{
    int x = 5;
    ChangeValue(x);
    Console.WriteLine(x); // What will print?
}

static void ChangeValueRef(ref int number)
{
    number = 100; // only changes local copy
}

void WriteChangeValueRef()
{
    int y = 5;
    ChangeValueRef(ref y);
    Console.WriteLine(y); // What will print?
}

#endregion

#region Exercise 2

static void MoveShape(ref Shape s, in Point offset, out int newX)
{
    // تغییر مرجع shape
    s = new Shape { Name = "Circle", Position = new Point { X = offset.X, Y = offset.Y } };

    // تغییر property داخل object جدید
    s.Position.X += 5;
    s.Position.Y += 10;

    // مقدار out
    newX = s.Position.X;
}

static void ChangeArray(int[] arr)
{
    arr[0] = 99; // تغییر آرایه اصلی
}

static void Exercise2()
{
    var shape1 = new Shape { Name = "Square", Position = new Point { X = 0, Y = 0 } };
    var offset = new Point { X = 2, Y = 3 };
    int resultX;

    int[] numbers = { 1, 2, 3 };
    ChangeArray(numbers);

    MoveShape(ref shape1, offset, out resultX);

    Console.WriteLine($"Shape Name: {shape1.Name}");
    Console.WriteLine($"Shape Position: {shape1.Position.X}, {shape1.Position.Y}");
    Console.WriteLine($"Result X from out: {resultX}");
    Console.WriteLine($"Array[0]: {numbers[0]}");
}

#endregion

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
    if (input.GetType().IsValueType)
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
    public Person(string name, int age)
    {
        personName = name;
        personAge = age;
    }

    public Person() { }

    #endregion

    public void Display()
    {
        Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
    }
}

struct Point
{
    public int X;
    public int Y;
}

class Shape
{
    public string Name;
    public Point Position;
}

