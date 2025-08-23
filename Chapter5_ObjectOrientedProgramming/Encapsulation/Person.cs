namespace Encapsulation;


// گذاشتن محدودیت برای فیلدا با get; set;
// حالا یا به صئرت متد و یا property
public class Person
{
    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }
     
    private string _name ;
    private int _empId;

    public string GetName() => _name;
    public void SetName(string name)
    {
        if (name.Length > 15)
        {
            Console.WriteLine("Error! Name length exceeds 15 characters!");
        }
        else
        {
            _name = name;
        }
    }
}
