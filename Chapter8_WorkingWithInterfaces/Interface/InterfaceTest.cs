namespace Interface;

// از سی شارپ 8 به بعد اینترفیس میتواند هر جور دیتایی از قبیل متد با پیاده سازی، استاتیک، بدون پیاده سازی و ... را داشته باشد.

// static constructor فقط به عناصر static دسترسی دارد و باید بدون پارامتر باشد.

public interface InterfaceTest
{
    //Error!
    //public int numOfPoints;

    //Error!
    //public InterfaceTest()
    //{
    //    numOfPoints = 0;
    //}
    public string Test()
    {
        return "";
    }

    static InterfaceTest() => Test2 = "test1";

    public void Test1();

    public static string Test2 ;
}
