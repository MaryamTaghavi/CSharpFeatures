
EnterLogData("has bug");

static void EnterLogData(string message , string owner = "Programmer")
{
    ArgumentNullException.ThrowIfNull(message);
    Console.WriteLine("Error : {0}" , message ) ;
}