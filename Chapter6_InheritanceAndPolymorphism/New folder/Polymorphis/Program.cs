Animal animal = new Dog();
animal.Speak(); // نتیجه: "Bark"

Animal1 animal1 = new Dog1();
animal1.Speak(); // نتیجه: "Animal sound"

/*
وقتی override و virtual را نذاریم رفتار کلاس پدر نتیجه کار است
اما وقتی میگذاریم رفتار کلاس فرزند نتیجه کار استو
 */
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }
}

public class Animal1
{
    public void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog1 : Animal1
{
    public void Speak()
    {
        Console.WriteLine("Bark");
    }
}
