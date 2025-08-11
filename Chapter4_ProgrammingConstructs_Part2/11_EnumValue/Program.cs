
var result = Enum.GetUnderlyingType(typeof(EmpTypeEnum));

Console.WriteLine(result);
Console.ReadLine();

enum EmpTypeEnum
{
    first = 1,
    second = 2,
    third = 3,
    fourth = 4,
    fifth = 5,
    sixth = 6,
}