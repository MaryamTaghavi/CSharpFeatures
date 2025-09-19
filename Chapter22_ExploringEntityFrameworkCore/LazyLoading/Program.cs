/*

وقتی یک شیء اصلی (مثلاً Car) را از پایگاه داده می‌گیری، داده‌های مرتبط (مثل Make یا Drivers) هنوز بارگذاری نشده‌اند.
فقط وقتی که تو به آن داده‌ها نیاز داری و به property آن‌ها دسترسی پیدا می‌کنی، EF Core خودش یک query جداگانه می‌زند و داده‌ها را می‌آورد.

*/

var car = context.Cars.FirstOrDefault(c => c.Id == 1);
// فقط Car بارگذاری شده، Make و Drivers هنوز نیامده‌اند

var makeName = car.Make.Name;  // حالا EF Core query می‌زند و Make را می‌آورد
var driverCount = car.Drivers.Count; // حالا EF Core query جداگانه می‌زند و Drivers را می‌آورد 

// برای این کار property های مربوطه باید virtual باشند
// EF Core از Proxy استفاده کند.