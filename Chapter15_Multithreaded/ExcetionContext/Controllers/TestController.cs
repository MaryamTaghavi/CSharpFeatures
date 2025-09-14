using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System;

namespace ExcetionContext.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Execution Context
        /// </summary>
        /// <remarks>
        /// Execution Context محیطی است که اطلاعات مرتبط با اجرای یک Thread را نگه می‌دارد.

        // شامل چیزهایی مثل:

//Security context(مجوزها)

//Culture info(تنظیمات زبانی و منطقه‌ای)

//Call context(اطلاعاتی که بین متدها منتقل می‌شود)

//به عبارتی، Execution Context مثل کیسه‌ای از اطلاعات اجرایی Thread است که.NET آن را مدیریت می‌کند.
        /// ## مراحل اعتبار سنجی
        /// ***
        /// * وارد کردن شماره موبایل یا ایمیل کاربر
        /// * وارد کردن کد ارسالی به موبایل یا ایمیل
        /// </remarks>
        /// 

        [HttpGet]
        public void Get()
        {
           
        }
    }
}
