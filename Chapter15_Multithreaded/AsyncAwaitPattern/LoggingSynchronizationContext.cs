namespace AsyncAwaitPattern;

class LoggingSynchronizationContext : SynchronizationContext
{
    public override void Post(SendOrPostCallback d, object state)
    {
        Console.WriteLine("کار به صف اضافه شد!");
        ThreadPool.QueueUserWorkItem(_ => d(state));
    }
}
