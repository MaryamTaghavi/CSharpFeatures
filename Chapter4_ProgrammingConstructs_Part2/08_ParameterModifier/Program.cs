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
Console.ReadLine();
