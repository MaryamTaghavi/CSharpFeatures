/*
فرض کن یه کلاس داری که می‌خوای زمان ایجاد هر آبجکت و تعداد کل آبجکت‌ها رو ذخیره کنی، ولی:

زمان ایجاد هر آبجکت باید فقط برای همون آبجکت ذخیره بشه و تغییرناپذیر باشه.

تعداد کل آبجکت‌ها باید بین همه‌ی آبجکت‌ها مشترک باشه و هر بار که یک آبجکت ساخته میشه افزایش پیدا کنه.
 */


class Person
{
    readonly DateTime Date;
    static int Count;
    Person()
    {
        Count++;
        Date = DateTime.Now ;
    }
}


/*
فرض کن می‌خوای یه کلاس بسازی برای تنظیمات برنامه:

یک مقدار نسخه نرم‌افزار که هیچ وقت تغییر نمی‌کنه و همه جای برنامه یکسانه.

یک مقدار تاریخ شروع برنامه که فقط یک بار وقتی برنامه شروع میشه تعیین میشه و بعد تغییر نکنه.

یک مقدار شناسه کاربری (GUID) که برای هر آبجکت متفاوت باشه و بعد از ساخت آبجکت تغییر نکنه.

یک مقدار شمارنده آبجکت‌ها که هر بار یک آبجکت ساخته میشه افزایش پیدا کنه و بین همه مشترک باشه.
 */


class ProgramConfig
{
    static readonly DateTime StartDate;
    const int Version = 2;
    static int Counter;
    readonly Guid Id;

    static ProgramConfig()
    {
        StartDate = DateTime.Now ;
    }

    ProgramConfig()
    {
        Counter++;
        Id = Guid.NewGuid();
    }
}

/*
فرض کن می‌خوای یه کلاس بسازی که ویژگی‌های زیر رو داشته باشه:

MaxUsers → حداکثر تعداد کاربران که هیچ وقت تغییر نمی‌کنه و همه جای برنامه یکسانه.

AppStartTime → زمان شروع برنامه که فقط یک بار وقتی برنامه load میشه مشخص میشه و بین همه instanceها مشترکه.

SessionId → شناسه هر session که برای هر object متفاوت باشه و بعد از ساختن object تغییر نکنه.

ActiveSessions → تعداد sessionهای فعال که با ایجاد هر session افزایش پیدا می‌کنه و با حذف session کاهش پیدا می‌کنه.

DefaultTimeout → مقدار پیشفرض timeout که compile-time مشخصه ولی برای همه instanceها یکسانه.
 */

class Session
{
    const int MaxUsers = 1000;
    static readonly DateTime AppStartTime ;
    readonly Guid SessionId;
    static DateTime DefaultTimeout = DateTime.Now;
    static int ActiveSessions;

    static Session()
    {
        AppStartTime = DateTime.Now ;
    }

    Session()
    {
        SessionId = Guid.NewGuid() ;
        ActiveSessions++;
    }

    public void EndSession()
    {
        ActiveSessions--;
    }
}