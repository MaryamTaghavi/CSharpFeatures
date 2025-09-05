using Interface;

//Error
//InterfaceTest interface1 = new InterfaceTest();

InterfaceTest interface2 = new ClassTest();

Console.WriteLine(InterfaceTest.Test2);
InterfaceTest.Test2 = "test2";

Console.WriteLine(InterfaceTest.Test2);