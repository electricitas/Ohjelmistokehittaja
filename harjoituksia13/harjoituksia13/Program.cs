Console.Write("Syötä sana: ");
string sana = Console.ReadLine();

if (sana.Length >= 2)
{
    char[] merkit = sana.ToCharArray();

    char temp = merkit[0];
    merkit[0] = merkit[sana.Length - 1];
    merkit[sana.Length - 1] = temp;


    string uusiSana = new string(merkit);
    Console.WriteLine("Muutettu sana: " + uusiSana);
}
else
{
    Console.WriteLine("Syötä vähintään kaksi merkkiä pitkä sana.");
}

Console.ReadLine();