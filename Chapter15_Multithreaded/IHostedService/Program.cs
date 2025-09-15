/*

 IHostedService یک اینترفیس در ASP.NET Core است که برای ایجاد سرویس‌های پس‌زمینه (Background Services) استفاده می‌شود.

این سرویس‌ها هنگام شروع اپلیکیشن راه‌اندازی می‌شوند و هنگام خاموش شدن اپلیکیشن بسته می‌شوند.

*/

/*
 
IHostedService دو متد اصلی دارد:

StartAsync(CancellationToken cancellationToken)	این متد هنگام راه‌اندازی اپلیکیشن اجرا می‌شود. می‌توانید کارهای پس‌زمینه یا تایمرها را اینجا شروع کنید.

StopAsync(CancellationToken cancellationToken)	این متد هنگام خاموش شدن اپلیکیشن اجرا می‌شود. می‌توانید سرویس‌ها را به شکل امن متوقف کنید یا منابع را آزاد کنید.

*/

//builder.Services.AddHostedService<MyBackgroundService>();

using Microsoft.Extensions.Hosting;

public class MyBackgroundService : IHostedService
{
    private Timer _timer;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
        return Task.CompletedTask;
    }

    private void DoWork(object state)
    {
        Console.WriteLine("Background task is running...");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }
}