
class Car
{
    public string petName;
    public int currSpeed;

    // Constructors as expression-bodied members
    public Car(string pn) => petName = pn;

    // Constructors with out parameters
    public Car(string pn, int cs, out bool inDanger)
    {
        petName = pn;
        currSpeed = cs;
        if (cs > 100)
        {
            inDanger = true;
        }
        else
        {
            inDanger = false;
        }
    }

    // this keyword
    public Car(string petName , int currSpeed)
    {
        this.petName = petName;
        this.currSpeed = currSpeed;
    }

}