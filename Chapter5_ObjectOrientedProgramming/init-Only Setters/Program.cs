/*
به هنگام ایجاد در کانستراکتور میتوانیم مقدار اولیه بدهیم ولی بعد از آن
فیلد به readonly تبدیل میشود که به آن
immutable هم میگویند.
 */


// Default Constructor
using System.Xml.Linq;

User user = new User() { Name = "Maryam", Family = "Taghavi" };

// If we have constructor
//User user1 = new User("Maryam", "Taghavi");

// compile error => init , readonly , immutable 
//user.Name = "Parsa";

class User
{
    // Automatic property syntax
    public int Id { get; set; }

    private int _age; // backing field

    public int Age   // Traditional property syntax
    {
        get { return _age; }   
        set { _age = value; }
    }
    public string Name { get; init; }
    public string Family { get; init; }

    //public User(string Name , string Family)
    //{
    //    this.Name = Name;
    //    this.Family = Family;
    //}
}