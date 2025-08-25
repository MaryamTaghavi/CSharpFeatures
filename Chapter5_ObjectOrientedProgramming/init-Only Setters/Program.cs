/*
به هنگام ایجاد در کانستراکتور میتوانیم مقدار اولیه بدهیم ولی بعد از آن
فیلد به readonly تبدیل میشود که به آن
immutable هم میگویند.
 */


User user = new User("Maryam", "Taghavi");
// compile error => init , readonly , immutable 
//user.Name = "Parsa";

class User
{
    public string Name { get; init; }
    public string Family { get; init; }

    public User(string Name , string Family)
    {
        this.Name = Name;
        this.Family = Family;
    }
}