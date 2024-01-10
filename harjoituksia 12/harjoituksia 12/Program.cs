Console.Write("Syötä luku 10 tai suurempi: ");
int inputNumber;

while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < 10)
{
    Console.WriteLine("Syötä luku 10 tai suurempi.");
    Console.Write("Syötä luku uudelleen: ");
}


for (int i = 0; i <= 10; i++)
{
    for (int j = 0; j < 13; j++)
    {
        Console.Write($"{inputNumber}");

        if (j == 12)
        {
            Console.WriteLine();
        }
        else if (i % 2 == 0)
        {
            Console.Write(" ");
        }
    }
}

Console.ReadLine();