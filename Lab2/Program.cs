//Derrick Mian
//CPS 3330 Section 1
//Unit 2 Lab 2 - Create and Test a Library App

using static System.Console;

Console.WriteLine("Enter value for 'a' and press enter: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value for 'b' and press enter: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Provided integers: {a} and {b}, the total is " + ClassLibrary1.Class1.MyProduct(a,b) + ".");

Console.WriteLine("Provide an additional value: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The product of {a}, {b}, and the additional value you provided, {c}, is: " + ClassLibrary1.Class1.MyProduct(a, b, c));

