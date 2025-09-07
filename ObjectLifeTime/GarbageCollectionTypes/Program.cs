/*

Workstation garbage collection : مناسب اپلیکیشن‌های دسکتاپ، سریع و کم‌توقف.
به دو صورت background و nonconcurrent انجام مشود.

background gc : از .net4 به بعد آمد که به معنای جمع آوری اشیا روی heap بدون توقف کردن تمامی thread ها
بعد از .Net 4  بهبود به این سمت بود که زمان توقف تردها پایین آورده شد .
Server garbage collection : طراحی شده برای سرور‌ها و برنامه‌های High Throughput (مثل وب سرورها، سرویس‌های backend).

*/