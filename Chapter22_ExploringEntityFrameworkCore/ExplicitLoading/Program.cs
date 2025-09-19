/*

 Explicit Loading یعنی بارگذاری داده‌های مرتبط (related entities) بعد از اینکه شیء اصلی (core entity) قبلاً در حافظه بارگذاری شده است.

*/

// بارگذاری شیء اصلی
var car = context.Cars.FirstOrDefault(c => c.Id == 1);

// بارگذاری یک Navigation Property تک‌تایی
context.Entry(car).Reference(c => c.Make).Load();

// بارگذاری یک Navigation Property مجموعه‌ای
context.Entry(car).Collection(c => c.Drivers)
    .Query() // می‌توان شروط اضافه کرد
    .Where(d => d.Age > 25)
    .Load();

// با reference یا collection دیتا را بدست می آورد و
// در صورت زدن .ToList()  و .Load()  کوئری اجرا میشود.