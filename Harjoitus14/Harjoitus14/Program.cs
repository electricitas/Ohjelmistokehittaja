// See https://aka.ms/new-console-template for more information
Console.Write("Syötä ensimmäinen kokonaisluku: ");
int luku1;

while (!int.TryParse(Console.ReadLine(), out luku1))
{
    Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku uudelleen: ");
}

Console.Write("Syötä toinen kokonaisluku: ");
int luku2;

while (!int.TryParse(Console.ReadLine(), out luku2))
{
    Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku uudelleen: ");
}


if (luku1 > 0 && luku2 > 0)
{
    Console.WriteLine("Molemmat ovat positiivisia.");
}
else if (luku1 < 0 && luku2 < 0)
{
    Console.WriteLine("Molemmat ovat negatiivisia.");
}
else
{
    Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen.");
}

Console.ReadLine();