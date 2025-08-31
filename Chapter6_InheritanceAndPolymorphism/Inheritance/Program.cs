class BaseClass
{
    protected int myValue = 123;
}

class DerivedClass : BaseClass
{
    static void Main()
    {
        var baseObject = new BaseClass();
        var derivedObject = new DerivedClass();

        // Error CS1540, because myValue can only be accessed through
        // the derived class type, not through the base class type.
        // baseObject.myValue = 10;
        // به علت اینکه protected است مستقیم نمیتوان از کلاس پدر از آن استفاده کرد و باید
        // از کلاس فرزند از آن استفاده کرد.
        // OK, because this class derives from BaseClass.
        derivedObject.myValue = 10;
    }
}

sealed class Example
{
    public string Name { get; set; }
}

// خطا میدهد چون sealed هست و این یعنی
// کسی نمیتواند از این کلاس ارث بری کند
class Example1 : Example
{

}