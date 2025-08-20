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



