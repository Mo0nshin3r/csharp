// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string cube00 = "VertRougeBleu";
string cube01 = "VertBlanc";
string cube02 = "RougeBlancBleu";
string cube03 = "BleuOrange";
string cube04 = "Blanc";
string cube05 = "VertOrange";
string cube06 = "RougeVertBlanc";
string cube07 = "RougeBleu";
string cube08 = "BlancOrangeVert";

//recup un nb aléatoire entre 0 et 8
Random random = new Random();
int randomCube = random.Next(9);

//Associe le cube avec le num aléatoire
string selectedCube = ;
if (randomCube == 0)
{
    selectedCube = cube00;
}
else if (randomCube == 1)
{
    selectedCube = cube01;
}
else if (randomCube == 2)
{
    selectedCube = cube02;
}
else if (randomCube == 3)
{
    selectedCube = cube03;
}
else if (randomCube == 4)
{
    selectedCube = cube04;
}
else if (randomCube == 5)
{
    selectedCube = cube05;
}
else if (randomCube == 6)
{
    selectedCube = cube06;
}
else if (randomCube == 7)
{
    selectedCube = cube07;
}
else if (randomCube == 8)
{
    selectedCube = cube08;
}

//ask user to guess color
Console.Write("A votre avis quelle est la couleur du cube " + randomCube + " :");
string answer = Console.ReadLine();
if (answer == selectedCube)
{
    Console.WriteLine("Bravo! Vous avez trouvé!");
}
else
{
    Console.WriteLine("Désolé, votre réponse est incorrecte.");

}