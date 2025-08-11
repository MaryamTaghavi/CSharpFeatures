// Bitwise
// 0110 & 0100 = 0100   And
// 0110 | 0100 = 0110   Or
// 0110 ^ 0100 = 0010   XOR
// 0110 << l = 1100   LeftShift
// 0110 >> l = 0011   RightShift


Days saturdayAndSunday = Days.Saturday & Days.Sunday;

Console.WriteLine(saturdayAndSunday);
Console.ReadLine();

[Flags]
public enum Days
{
    None = 0 ,
    Saturday = 1 ,
    Sunday = 2 ,
    Monday = 3 ,
    Tuesday = 4 ,
    Wednesday = 5 ,
    Thursday = 6 ,
    Friday = 7 ,
}