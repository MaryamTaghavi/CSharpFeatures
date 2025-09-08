/*
 دو روش پاک سازی داریم : 
 1) Finalize() => ابتدا اشیا به finalization queue  منتقل میشوند و بعد از آن GC وارد عمل میشود و بعد از اجرای
    queue  دیتا را از حافظه پاک میکند یعنی
    درگیری GC دو بار است.

 Finalize بیشتر برای cleanup نهایی است و توسط runtime مدیریت می‌شود، اما هزینه بیشتری دارد.

 2) Dispose() => IDisposable()
اگر object منابع unmanaged دارد → از Dispose استفاده کن.
 */