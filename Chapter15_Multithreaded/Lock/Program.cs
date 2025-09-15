/*
 
 lock یک مکانیزم ساده برای جلوگیری از race condition است.

وقتی یک Thread وارد بلوک lock می‌شود، سایر Threadها باید منتظر بمانند تا آن Thread بلوک را ترک کند.

باعث می‌شود که بخش کد داخل بلوک Thread-safe شود.

*/

/*

وقتی می‌خوای یک متد static را Thread-safe کنی،
نمی‌توانی از this استفاده کنی چون متد instance نیست و شیء جاری وجود ندارد.
در این حالت، باید یک شیء static خصوصی برای Lock تعریف کنی.

*/
private static readonly object _lockObj = new object();

static void SomePrivateMethod()
{
    lock (_lockObj)
    {
        // Thread-safe code
    }
}