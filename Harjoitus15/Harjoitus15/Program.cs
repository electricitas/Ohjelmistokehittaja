Console.Write("Syötä lause");
string lause = Console.ReadLine();

string[] sanat = lause.Split(' ', StringSplitOptions.RemoveEmptyEntries);

string pisinSana = EtsiPisinSana(sanat);

if (pisinSana != null)
{
    Console.WriteLine($"Pisin sana: {pisinSana}");
}
else
{
    Console.WriteLine("Lauseessa ei ollut sanoja.");
}
Console.ReadLine();

static string EtsiPisinSana(string[] sanat)
{
    if (sanat.Length == 0)
    { return null; }
    string pisinSana = sanat[0];

    foreach (string sana in sanat)
    {
        if (sanat.Length > pisinSana.Length)
        {
            pisinSana = sana;

        }
    }
    return pisinSana;
}
