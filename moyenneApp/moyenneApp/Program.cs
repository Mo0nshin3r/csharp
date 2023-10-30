// See https://aka.ms/new-console-template for more information

Console.WriteLine("+--------------+");
Console.WriteLine("| Moyenne MSIG |");
Console.WriteLine("+--------------+");

Console.WriteLine("Veuillez saisir les 3 notes de la branche");
Console.WriteLine();
Console.Write("Note 1 : ");
double note1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Note 2 : ");
double note2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Note 3 : ");
double note3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double moyenne = Math.Round((note1 + note2 + note3) / 3.0,1);
double result = Math.Round(moyenne * 2) / 2;


Console.WriteLine($"Moyenne: {result}");


if (result >= 4)
    Console.WriteLine("nice !");
else Console.WriteLine("work harder");





ConsoleKey keypressed = Console.ReadKey().Key;

