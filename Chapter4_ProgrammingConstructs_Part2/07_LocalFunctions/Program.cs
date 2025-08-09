// Local functions means a function defines into another function

using System.Diagnostics.CodeAnalysis;


string?[] lines = { "apple", null, "banana" };
Process(lines, "a");

var result = AddWrapperWithSideEffect(10 , 7);

var result2 = AddWrapperWithoutSideEffect(7 , 4);

Console.WriteLine(result);

static void Process(string?[] lines, string mark)
{
    foreach (var line in lines)
    {
        if (IsValid(line))
        {
            // Processing logic...
        }
    }

    bool IsValid([NotNullWhen(true)] string? line)
    {
        return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
    }
}

// New in C# 8 Local function can change the values of the variables.
// Local function can change the variable from the manin function directly.

static int AddWrapperWithSideEffect(int x, int y)
{
    return Add();

    int Add()
    {
        x += 1;
        return x + y;
    }
}

// If we want the local function cann't change the variables we must change that to static

static int AddWrapperWithoutSideEffect(int x, int y)
{
    return Add(x , y);

    static int Add(int x , int y)
    {
        x += 1;
        return x + y;
    }
}

