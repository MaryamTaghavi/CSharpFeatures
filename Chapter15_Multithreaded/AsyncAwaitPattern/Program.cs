// SynchronizationContext  یک کلاس پایه در .Net است
// که سبب میشود به ترد مربوطه بگوییم که ادامه کار پس از پایان یافتن تسک روی چه تردی انجام شود
// بدون آن به انتخاب خود .Net این کار انجام میشود.
// تنظیمات آن معمولا به دست ما نیست و خود برنامه بر اساس نوع پروژه آن را تنظیم میکند.

using AsyncAwaitPattern;

SynchronizationContext.SetSynchronizationContext(new LoggingSynchronizationContext());

Console.WriteLine("قبل از await");

await Task.Delay(1000);

Console.WriteLine("بعد از await");


#region ConfigureAwait

// ConfigureAwait = false است یعنی به
// SynchronizationContext میفهمانیم که نیازی نیست پس از اتمام کارت 
// به همان ترد برگردی این سبب سبک شدن context میشود.

Console.WriteLine("Fun With Async ===>");

string message = await DoWorkAsync();

Console.WriteLine($"0 - {message}");
string message1 = await DoWorkAsync().ConfigureAwait(false);
Console.WriteLine($"1 - {message1}");


static async Task<string> DoWorkAsync()
{
    return await Task.Run(() =>
    {
        Thread.Sleep(5_000);
        return "Done with work!";
    });
}

#endregion

#region

// Task.WhenAll() => یعنی اجرای چند تسک همزمان به صورت موازی

#endregion