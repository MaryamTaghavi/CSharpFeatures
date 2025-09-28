async Task ExampleWhenAll()
{
    var t1 = Task.Delay(2000);
    var t2 = Task.Delay(3000);
    var t3 = Task.Delay(1000);

    await Task.WhenAll(t1, t2, t3);

    Console.WriteLine("همه‌ی کارها تمام شدند!");
}
// زمان کل: 3 ثانیه(بیشترین زمان بین تسک‌ها).


async Task ExampleWhenAny()
{
    var t1 = Task.Delay(2000);
    var t2 = Task.Delay(3000);
    var t3 = Task.Delay(1000);

    var finishedTask = await Task.WhenAny(t1, t2, t3);

    Console.WriteLine("اولین کار تمام شد!");
}
// زمان کل: 1 ثانیه(چون t3 زودتر تموم می‌شه).



