/*
وقتی نخواهیم کلاسی new شود از این keyword استفاده میکنیم
 */

abstract class Shape
{
    protected Shape(string name = "NoName")
    {
        PetName = name;
    }
    public string PetName { get; set; }
    public abstract void Draw();
}
class Circle : Shape
{
    public Circle()
    {

    }
    public Circle(string name) : base(name) { }
    public override void Draw()
    {
        Console.WriteLine("Drawing {0} the circle" , PetName);
    }
}
class ThirdCircle : Circle
{
    // وقتی امکان اورراید کردن متد نیست از کلید واژه new استفاده میکنیم
    // که به این معناست که رفتار کلاس فرزند را تبعید کن.
    public new void Draw()
    {
        Console.WriteLine("drawing a 3d circle");
    }
}

class Third3Circle
{
    public void Draw()
    {
        Console.WriteLine("drawing a 3d circle");
    }
}