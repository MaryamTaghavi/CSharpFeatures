/* وقتی یک فیلد درون یک کلاس به صورت static تعریف میشود
نباید کلاس را new کرد و از آبجکت جدید برای استفاده از آن فیلد استفاده کرد
بلکه باید فیلد را به صورت مستقیم استفاده کرد
 */

/* Utility Class : کلاس هایی که static هستند و تمامی اعضای آنها هم static هستند
آنها را نمیتوان New کرد
*/

// 1) static field data

Console.WriteLine(SavingsAccount.CurrInterestRate);

Console.WriteLine(SavingsAccount1.GetInterestRate());

Console.ReadLine();
class SavingsAccount
{
    public static double CurrInterestRate = 0.04;
}

// 2) static methods

class SavingsAccount1
{
    public static double CurrInterestRate = 0.04;

    public static double GetInterestRate() => CurrInterestRate;

    public int X;
    // Compile Error
    //public static double GetInterestRate() => x;

    // Compile Error
    //public static double GetInterestRate() => this.x;
}

// 3) static constructor
// برای مواقعی که نیاز به محاسبه در لحظه runtime یا گرفتن دیتا از منابع بیرونی هستیم

/* ویژگی های static constructor :
 * 1) هر کلاس حتما یک static constructor دارد به عبارت دیگر static constructor نمیتواند overload شو
 * 2) نمیتواند access modifier و پارامتر ورودی داشته باشد.
 * 3)  فقط یک بار ایجاد میشود، هر چند بار که بخواهیم کلاس را ایجاد کنیم.
 * 4) در زمان runtime اجرا میشود قبل از صدا زدن static member ها.
 */

class Bank
{
    public static double InterestRate;

    static Bank()
    {
        // مثلا مقدار رو از فایل config یا یک منبع بیرونی بخونیم
        Console.WriteLine("Static constructor executed!");
        InterestRate = DateTime.Now.Second % 2 == 0 ? 0.04 : 0.05;
    }

    public static void ShowRate()
    {
        Console.WriteLine("Interest Rate = " + InterestRate);
    }
}

// نکته : اگر فیلد استاتیک را درون non-static constructor بگیریم با هر بار ایجاد شی این مقدار ریست شده و مقدار تکراری میگیرد

// 4) static class
// هیچ دفعه allocate in heap در آن اتفاق نمی افتد
// به آن utility class میگویند
// حتما باید تمامی اعضای آن static باشند
// نمیتوان آن را new کرد

static class Bank1
{
    public static double InterestRate;

    //compiler error
    //void Bank1()
    static Bank1()
    {
        // مثلا مقدار رو از فایل config یا یک منبع بیرونی بخونیم
        Console.WriteLine("Static constructor executed!");
        InterestRate = DateTime.Now.Second % 2 == 0 ? 0.04 : 0.05;
    }

    public static void ShowRate()
    {
        Console.WriteLine("Interest Rate = " + InterestRate);
    }
}

