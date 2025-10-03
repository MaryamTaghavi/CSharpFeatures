 وقتی دو رشته یکسان داشته باشیم، هر دو به یک خانه از حافظه اشاره میکنند
 این ویژگی سبب میشود که حافظه کمتری مصرف شود و رشته ها سریعتر با هم مقایسه شوند.

string a = "hello";
string b = "hello";

به صورت داخلی خود .Net انجام میدهد.

Console.WriteLine(Object.ReferenceEquals(a, b)); // true → هر دو interned
