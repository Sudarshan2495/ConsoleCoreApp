using ConsoleCoreApp.Day4;
using ConsoleCoreApp.Assignment2;
using System.Collections.Concurrent;
using ConsoleCoreApp.OOPS;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int x = 20;
//Console.WriteLine("Value of x :{x}");
//ConsoleCoreApp.Day4.Test.Main();
//Test.Main();    

//ReadKey
//Console.WriteLine("Press any Key");
//ConsoleKeyInfo ck = Console.ReadKey();
//ConsoleKeyInfo ck = Console.ReadKey(true);
//Console.Write("*");
//ck.Key=>ConsoleKey
//ck.Key=>char
//Console.WriteLine($"\nPressed Key :{ck.Key}");
//Console.WriteLine($"Pressed Key keychar :{ck.KeyChar}");

//string pass ="";
//Console.WriteLine("Enter your Password");
//logic goes here
ConsoleKeyInfo ck= Console.ReadKey(true);
//while(ck.Key !=ConsoleKey.Enter)
//{
//    Console.Write("*");
//    //+= is for concatination
//    pass += ck.KeyChar;
//    ck = Console.ReadKey(true); 
//}
//Console.WriteLine($"Your Password is :{pass}");

//do
//{ 
//    Console.Write("*");
//    if(ck.Key !=ConsoleKey.Enter)
//            pass+= ck.KeyChar;
//    else
//        break;

//} while (true);

//Console.WriteLine($"Your Password is :{pass}");

//using foreach
/*int[] arr= new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine("Array elements are");*/

/*
 //forward only
 //readonly   
 foreach (Type identifier in Collection / array - name)
//{
//    //statements
}*/
/*foreach(int item in arr)
{
    //item = item +20; //invalid
    Console.WriteLine(item);
}
*/
//string pass = "";
//Console.WriteLine("Enter your 10 Digit Password");
//ConsoleKeyInfo ckf = Console.ReadKey(true);
//while(ckf.Key != ConsoleKey.Enter)
//{
//    Console.Write("#");
//    pass += ckf.KeyChar;
//    ckf = Console.ReadKey(true);
//    if(pass >= 6)
//    {
//        ckf.KeyChar;      
//    }

//} 
//Console.WriteLine($"Password last 4 digits are :{pass}");
//_____________________________________________________________________________________________________________________________
//12/01/2033 OOP's Concept C#
//_____________________________________________________________________________________________________________________________

//1)Object Creation
//Employee employee = new Employee();

//2)Member Calling
//employee.DisplayEmployeeDetails();

//employee.SetEmployeeDetails(101, "Sudarshan", 250546.5f);

//employee.DisplayEmployeeDetails(); //101,Sudarshan,250546.5


//3)Employee emp2 = employee;
//emp2.DisplayEmployeeDetails(); //101,Sudarshan,250546.5

//emp2.SetEmployeeDetails(102, "Sajid", 25462.0f);

//employee.DisplayEmployeeDetails(); //102,Sajid,25462.0

//emp2.DisplayEmployeeDetails(); //102,Sudarshan,25462.0


//4)var emp3 = new Employee();

//emp3.DisplayEmployeeDetails(); //0 ," ",0
//emp3.SetEmployeeDetails(103, "Gowtham", 25487.5f);
//emp3.DisplayEmployeeDetails(); //103,Gowtham,25487.5

//5)dynamic emp4 = new Employee();

//6)Employee emp5 = new(); //latest new type of object creation

//emp5.DisplayEmployeeDetails();

//new Employee().DisplayEmployeeDetails();

//7)Method Calling
//MethodCalling mt = new MethodCalling();

//int num1 = 30 , num2 = 50 ,sum ,mul ,div;
//Console.WriteLine($"Num1 : {num1} ,\tNum2 : {num2}"); //20,10
//mt.CallByValue( num1 , num2); //40,40
//Console.WriteLine($"Num1 : {num1} ,\tNum2 : {num2}"); //20,10

//8)Call By Reference                                                      
//For manipulation of values whereas method is a normal call
//mt.CallByReference(ref num1, ref num2);
//Console.WriteLine($"Num1: {num1}, \tNum2 : {num2}");

//mt.CallByOutput(num1, num2, out sum, out mul, out div);//method returning multiple values without return statement
//Console.WriteLine($"Sum: {sum}, \tMuliplication : {mul}, \tDivision: {div}");

//mt.CallByNamedOptional(101,"Munna","Gautre",25489.0f); //passed in sequence to get O/P

//mt.CallByNamedOptional(fname:"Munna" ,surname:"Gautre",id:101 ,salary:25489.0f); //use of named argument

//mt.CallByNamedOptional(fname: "Munna", id: 101, salary: 25489.0f);

//mt.CallByNamedOptional(fname: "Munna", surname: "Gautre", id: 101);


//_____________________________________________________________________________________________________________________________
//13/01/2033 Overloading & Constructor
//_____________________________________________________________________________________________________________________________

//Employee emp1 = new Employee();

//Employee emp2 = new();

//Employee emp3 = new(101, "Munna", 85000);
//Employee emp4 = new(102, "Gowtham", 75000);

//Employee emp5 = new(103, 85000);

//emp1.DisplayEmployeeDetails();
//emp2.DisplayEmployeeDetails();
//emp3.DisplayEmployeeDetails();
//emp4.DisplayEmployeeDetails();
//emp5.DisplayEmployeeDetails();

//GC.Collect(0);

//Point p1 = new Point(20 , 30);
//Point p2 = new Point(20 , 30);

//Point p3 = p1 + p2;
//Console.WriteLine(p1);
//Console.WriteLine(p2);
//Console.WriteLine(p3);

//Point p4 = p1 - p2;
//Console.WriteLine(p4);

//if (p1 == p2)
//{
//    Console.WriteLine("Both are Same");
//}
//else
//{
//    Console.WriteLine("Both are Different");
//}

//using static demo
//StaticDemo s1 = new StaticDemo();
//StaticDemo s2 = new StaticDemo();
//StaticDemo s3 = new StaticDemo();

//s3.DisplayId();
////s2.DisplayCount(); //invalid as it is static in C# static member can't be asscess outside class
//StaticDemo.DisplayCount();
//s1.DisplayId();

SingletonPattern sp = SingletonPattern.GetObject();
sp.Display();