// See https://aka.ms/new-console-template for more information
Console.Write("Syötä ikäsi: ");
int ika = int.Parse(Console.ReadLine());
if (ika <15)
{
    Console.Write("Saat ajaa polkupyörää");
}
else if (ika < 18)
{
    Console.Write("Saat ajaa mopolla");
}
else
{
    Console.Write("Saat ajaa autolla");
}

