object[] myObjects = new object[4];

myObjects[0] = 10;
myObjects[1] = false;
myObjects[2] = "SeriLog";
myObjects[3] = new DateTime(1969,3,24);

foreach(var obj in myObjects)
{
    Console.WriteLine("Type: {0}, Value: {1}" , obj.GetType() , obj);
}

Console.WriteLine();