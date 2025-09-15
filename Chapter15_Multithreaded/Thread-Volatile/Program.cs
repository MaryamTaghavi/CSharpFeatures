/*
 
 به معنای دسترسی همزمان چند ترد به یک منبع داده مشترک است
 که میتواند خطرناک باشد
 راه حل آن استفاده از lock یا سمافور است

*/

/*

 وقتی روی چند Thread کار می‌کنیم، همیشه باید بدانیم:

 کدام متغیرها یا عملیات ممکن است همزمان دستکاری شوند → نیاز به lock یا Interlocked دارند.

 کدام عملیات atomic هستند → نیازی به محافظت اضافی ندارند.

 اگر ندانیم، ممکن است برنامه رفتار غیرمنتظره بدهد، کرش کند یا داده‌ها خراب شوند.

 */


async void CreateSamaphore(CancellationToken cancellationToken)
{
    // سمافور تعداد تردها را محدود میکند و با استفاده از آن میتوانیم مشخص کنیم چند ترد ران شوند.
     SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

    await _semaphore.WaitAsync(cancellationToken);
}

class Account
{
    private object balanceLock = new object();
    private int balance = 0;

    public void Deposit(int amount)
    {
        Monitor.Enter(balanceLock);
        try
        {
            balance += amount;
        }
        finally
        {
            Monitor.Exit(balanceLock);
        }
    }
}