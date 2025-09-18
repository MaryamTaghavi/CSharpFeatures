// SynchronizationContext  یک کلاس پایه در .Net است
// که سبب میشود به ترد مربوطه بگوییم که ادامه کار پس از پایان یافتن تسک روی چه تردی انجام شود
// بدون آن به انتخاب خود .Net این کار انجام میشود.
// تنظیمات آن معمولا به دست ما نیست و خود برنامه بر اساس نوع پروژه آن را تنظیم میکند.

using AsyncAwaitPattern;

static async Task Main()
{
    SynchronizationContext.SetSynchronizationContext(new LoggingSynchronizationContext());

    Console.WriteLine("قبل از await");

    await Task.Delay(1000);

    Console.WriteLine("بعد از await");
}