/*
The System.IComparable interface specifies a behavior that allows an object to be sorted based on some specified key.
 */

using System.Collections;

Console.WriteLine("***** Fun with Object Sorting *****\n");
// Make an array of Car objects.
Car[] myAutos = new Car[5];
myAutos[0] = new Car("Rusty", 80, 1);
myAutos[1] = new Car("Mary", 40, 234);
myAutos[2] = new Car("Viper", 40, 34);
myAutos[3] = new Car("Mel", 40, 4);
myAutos[4] = new Car("Chucky", 40, 5);

Console.WriteLine("UnSorted List :");

foreach (var item in myAutos)
{
    Console.WriteLine("{0} {1}", item.CarID, item.PetName);
}

Array.Sort(myAutos);
Array.Sort(myAutos, Car.SortByPetName);

Console.WriteLine("\nSorted List :");

foreach (var item in myAutos)
{
    Console.WriteLine("{0} {1}", item.CarID, item.PetName);
}

Console.ReadLine();

public class Car : IComparable
{
    public int CarID { get; set; }
    public int CurrentSpeed { get; set; }
    public string PetName { get; set; }

    // Property to return the PetNameComparer.
    public static IComparer SortByPetName
        => (IComparer)new PetNameComparer();

    public Car(string name, int currSp, int id)
    {
        CurrentSpeed = currSp;
        PetName = name;
        CarID = id;
    }
    // IComparable implementation.
    public int CompareTo(object obj)
    {
        Car temp = (Car)obj;
        return this.PetName.CompareTo(temp.PetName);
    }
}

public class PetNameComparer : IComparer
{
    // Test the pet name of each object.
    public int Compare(object x, object y)
    {
        Car car1 = (Car)x;
        Car car2 = (Car)y;
        return string.Compare(car1.PetName, car2.PetName);
    }
}