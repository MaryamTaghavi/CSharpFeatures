/* 

Generation 0 : شامل object های جدید هست. 
اکثر objectها همین‌جا جمع‌آوری می‌شن.
جمع‌آوری توی Gen0 خیلی سریع انجام میشه.

*/

/* 

Generation 1 : واسطه بین short-lived و long-lived objects هست.
objectهایی که از Gen0 جان سالم به در می‌برن به Gen1 منتقل می‌شن.

*/

/* 

Generation 2 : شامل objectهایی هست که طول عمر زیادی دارن (مثلاً window اصلی برنامه).
جمع‌آوری Gen2 سنگین‌تره چون خیلی داده‌های مهم اینجا هست.

*/

using ObjectGenerations;

Console.WriteLine("***** Fun with System.GC *****");
// Print out estimated number of bytes on heap.
Console.WriteLine("Estimated bytes on heap: {0}",
GC.GetTotalMemory(false));
// MaxGeneration is zero based, so add 1 for display
// purposes.
Console.WriteLine("This OS has {0} object generations.\n",
(GC.MaxGeneration + 1));
Car refToMyCar = new Car("Zippy", 100);
Console.WriteLine(refToMyCar.ToString());

// Print out generation of refToMyCar object.
Console.WriteLine("Generation of refToMyCar is: {0}",
GC.GetGeneration(refToMyCar));
Console.ReadLine();