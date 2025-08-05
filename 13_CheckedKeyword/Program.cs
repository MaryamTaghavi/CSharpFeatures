try
{
  checked 
  {
    byte sum = (byte)Add(b1,b2) ;
    Console.WriteLine("sum = {0}" , sum) ;
  }
}
catch
{
}

// If we write checked keyword, if result overflow we force C# to get an error to us.
