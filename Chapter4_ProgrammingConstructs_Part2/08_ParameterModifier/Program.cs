// When a parameter doesn't have a modifier, the behavior for value types is to pass in the parameter by value
// and for reference types is to pass in the parameter by reference.

static int Add(int x , int y)
{
    int ans = x + y;
    x = 10000;
    y = 88888;
    return ans;
}

int x = 9; int y = 10;
Console.WriteLine("Before call: X:{0}, Y:{1}", x, y);
Console.WriteLine("Answer is: {0}" , Add(x,y));
Console.WriteLine("After call: X:{0}, Y:{1}", x, y);

// Using the out modifier
// Out allows a method to return an additional value to the caller.
static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}

AddUsingOutParam(90, 90, out int ans);
Console.WriteLine("Answer is :{0}", ans);

// Sometimes you call a method with an out parameter but you don’t need the output value.
// Instead of creating an unused variable, you can discard it with _.

if (int.TryParse("123", out _))
{
    Console.WriteLine("Parsing worked!");
}

// Using the ref modifier
static void SwapStrings(ref string s1 , ref string s2)
{
    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}

string str1 = "Flip";
string str2 = "Flop";

Console.WriteLine("Before call: {0}, {1}", str1,str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After call: {0}, {1}", str1, str2);

// Using the in modifier
// In is readonly
static int AddReadOnly(in int x, in int y)
{
    //Error cannot assign because x , y are readonly and we cann't change the value of them.
    //x = 10000;
    //y = 8888;
    int ans = x + y;
    return ans;
}

// Using the params Modifier
// A single params argument
static double CalculateAverage(params double[] values)
{
    double sum = 0;
    if (values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return sum / values.Length;
}

var result = CalculateAverage(2.6, 8.9, 2.8, 9.7);
Console.WriteLine("result: {0}", result);


// Using optional parametes
static void EnterLogData(string message , string owner = "Programmer" , DateTime timestamp = DateTime.Now)
{
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of error: {0}", owner);
}

EnterLogData("Hello");
Console.ReadLine();

