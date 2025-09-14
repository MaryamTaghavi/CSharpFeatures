/*

Execution Context چیست؟

Execution Context محیطی است که اطلاعات مرتبط با اجرای یک Thread را نگه می‌دارد.

شامل چیزهایی مثل:

Security context (مجوزها)

Culture info (تنظیمات زبانی و منطقه‌ای)

Call context (اطلاعاتی که بین متدها منتقل می‌شود)

به عبارتی، Execution Context مثل کیسه‌ای از اطلاعات اجرایی Thread است که .NET آن را مدیریت می‌کند.

*/

/*
 
Execution Context محیطی است که اطلاعات مرتبط با اجرای یک Thread را نگه می‌دارد.

شامل چیزهایی مثل:

Security context (مجوزها)

Culture info (تنظیمات زبانی و منطقه‌ای)

Call context (اطلاعاتی که بین متدها منتقل می‌شود)

به عبارتی، Execution Context مثل کیسه‌ای از اطلاعات اجرایی Thread است که .NET آن را مدیریت می‌کند.

*/

/*

اگر از Async/Await یا Task استفاده کنید، Threadها ممکن است بین Contextهای مختلف جابه‌جا شوند و Execution Context اطمینان می‌دهد که اطلاعات مهم مثل Culture یا Security حفظ شوند.

*/