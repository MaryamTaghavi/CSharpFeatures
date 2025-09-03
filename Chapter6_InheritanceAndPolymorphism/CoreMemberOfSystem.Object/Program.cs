// Equals
/*
Override GetHashSet سبب میشود که اگر p1 را درون
HashSet یا Dictionary بریزیم
و قبلش p1 را از لحاظ مقایسه ای با p2 مساوی در نظر گرفته باشیم
بتواند p2 را هم پیدا کند اگر بازنویسی نکند p2 را نمیتواند پیدا کند
 */

var p1 = new Person { Name = "Ali", Age = 30 };
var p2 = new Person { Name = "Ali", Age = 30 };


var set = new HashSet<Person>();
set.Add(p1);

// اگر GetHashCode را Override نکنیم این false برمیگردد
// ولی اگر override کنیم یعنی یک hashcode برای هر دو ست میشود پس در نتیجه
// true برمیگردد

Console.WriteLine(set.Contains(p2));

Console.WriteLine(p1.Equals(p2));
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person p)
            return Name == p.Name && Age == p.Age;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}