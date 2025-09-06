using System.Collections;

public class Car
{
    public string PetName { get; set; }
    public int Speed { get; set; }

    public Car(string name, int speed)
    {
        PetName = name;
        Speed = speed;
    }
}

public class Garage : IEnumerable
{
    private Car[] carArray = new Car[4];

    public Garage()
    {
        carArray[0] = new Car("Rusty", 30);
        carArray[1] = new Car("Clunker", 55);
        carArray[2] = new Car("Zippy", 30);
        carArray[3] = new Car("Fred", 30);
    }

    public IEnumerator GetEnumerator()
    {
        foreach (Car c in carArray)
        {
            yield return c;
        }
    }
}