class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World!") ;
  }
}

// Can changed into this : 

Console.WriteLine("Hello World!") ;

// Tips :
// 1) Only one file in the application can use top level statements.
// 2) When using top-level statements, the program cannot have a declared entry point. (دیگه اجازه تعریف متد main نداریم.)
// 3) Top-level statements can return an int or Task<int>.
// 4) Additional types can be declared after all top-level statements. Any Types declared before the end of the top-level statements will result in a compilation error.
// 5) The top-level statements cannot be enclosed in a namespace. (نمیتواند داخل یک namespace باشد.)
// 6) Both the class and Main() can be removed. (تعریف اصلی Top-level statements)
