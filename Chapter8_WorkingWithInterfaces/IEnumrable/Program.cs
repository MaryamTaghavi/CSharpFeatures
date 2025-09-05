// IEnumerable در واقع میگه که من یک مجموعه قابل پیمایش هستم و میتونی روی من foreach را اجرا کنی.

// IEnumerator میگه: این Enumerator چطور حرکت کنه و آیتم فعلی چی باشه.

// IEnumerable و IEnumerator باعث میشن هر چیزی شبیه Array بشه و قابل پیمایش باشه.

public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}

public interface IEnumerable
{
    IEnumerator GetEnumerator();
}


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

    // اینجا به foreach میگیم که چطور روی Garage حرکت کنه
    public IEnumerator GetEnumerator()
    {
        return carArray.GetEnumerator();
    }
}