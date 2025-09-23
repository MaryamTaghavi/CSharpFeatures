Serialization یعنی یک شیء در حافظه (Object) رو به یک فرمت قابل ذخیره یا قابل انتقال تبدیل کنیم.

شیء در حافظه فقط برای برنامه قابل درک هست. اگه بخوای اون رو بفرستی به دیتابیس، فایل، یا شبکه، باید اول به یه قالب استاندارد مثل JSON، XML یا باینری تبدیل بشه. این تبدیل همون Serialization هست.

مثال :

فرض کن یه کلاس داری :

public class Shipment
{
    public int OrderId { get; set; }
    public string ShipmentNumber { get; set; }
    public string Status { get; set; }
}


و یه شیء ازش می‌سازی:

var shipment = new Shipment
{
    OrderId = 123,
    ShipmentNumber = "SHP-001",
    Status = "Created"
};


توی حافظه، این یه object از نوع Shipment هست.
ولی وقتی serialize بشه (مثلاً به JSON):

{
  "OrderId": 123,
  "ShipmentNumber": "SHP-001",
  "Status": "Created"
}


حالا این متن JSON قابل ذخیره توی فایل، ارسال توی API یا لاگ کردن هست.
