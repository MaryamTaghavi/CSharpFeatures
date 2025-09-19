/*

Eager Loading به معنای بارگذاری فوری داده‌های مرتبط (related entities) از چند جدول در یک فراخوانی پایگاه داده است.

معادلش در SQL: یک query با JOIN بین دو یا چند جدول.

وقتی موجودیت‌ها (Entities) Navigation Property دارند و در LINQ query استفاده می‌شوند، EF Core از JOIN برای بارگذاری داده‌های مرتبط استفاده می‌کند.

مزیت: کارایی بالاتر، چون به جای اجرای چند query جداگانه (یک query برای هر جدول مرتبط)، همه داده‌ها در یک query دریافت می‌شوند. 

*/

// Eagerloading with filter

var context = new Object() ;

var makesWithYellowCars = context.Makes
.Include(x => x.Cars.Where(x => x.Color == "Yellow"))
.ToList();

// Eageloading with AsSplitQuery
// وقتی تعداد join ها , include و thenInclude زیاد باشد از این دستور استفاده میکنیم تا فشار و بار روی دیتابیس را کاهش دهد.

var splitMakes = context.Makes
    .AsSplitQuery() // فعال کردن Split Query
    .Include(x => x.Cars.Where(x => x.Color == "Yellow"))
    .ToList();