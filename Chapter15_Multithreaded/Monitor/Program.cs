/*

 lock در C# یک شکل کوتاه و امن برای کار با Monitor است.

*/

private readonly object _threadLock = new object();

void PrintNumbers()
{
    Monitor.Enter(_threadLock);
    try
    {
        Console.WriteLine("-> {0} is executing PrintNumbers()",
            Thread.CurrentThread.Name);

        for (int i = 0; i < 10; i++)
        {
            Random r = new Random();
            Thread.Sleep(1000 * r.Next(5));
            Console.Write("{0}, ", i);
        }
        Console.WriteLine();
    }
    finally
    {
        Monitor.Exit(_threadLock);
    }
}
