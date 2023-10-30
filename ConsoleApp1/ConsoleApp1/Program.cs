// See https://aka.ms/new-console-template for more information

Console.WriteLine("welcome to this simple calculator, please enter two numbers");

//entrée 1
Console.Write("A:");
int numberA = Convert.ToInt32(Console.ReadLine());

//entrée 2
Console.Write("B:");
int numberB = Convert.ToInt32(Console.ReadLine());

//résultat
int result = numberA + numberB;
Console.WriteLine($"result:{result}");


ConsoleKey keypressed = Console.ReadKey().Key;

