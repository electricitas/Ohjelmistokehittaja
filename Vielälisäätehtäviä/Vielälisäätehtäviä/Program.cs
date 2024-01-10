// See https://aka.ms/new-console-template for more information
/*
//Annetaan ensimmäinen verrattava arvo
Console.Write("Syötä eka luku");
int luku = int.Parse(Console.ReadLine());
Console.Write("Syötä toinen luku");
int muku = int.Parse(Console.ReadLine());
//Verrataan lukuja keskenään
if (luku < muku)
{   //Ohjelma kääntää luvut oikeaan järjestykseen, jos toinen syötetty luku on suurempi
    Console.WriteLine("Toinen luku on suurempi " + muku + " " + luku);
}
else
{  // muutoin tämä on näytettävä tulos
    Console.WriteLine("Ensimmäinen luku on suurempi " + luku + " " + muku);
}


Console.Write("Syötä eka numero ");
int lukuu = int.Parse(Console.ReadLine());
Console.Write("Syötä toka numero ");
int luuku = int.Parse(Console.ReadLine());
Console.Write("Syötä kolmas numero ");
int lukku = int.Parse(Console.ReadLine());

int suurin;

if (lukuu > luuku)
{
    suurin = lukuu;
} else
{
    suurin = luuku;
}
if (lukku > suurin)
{
    suurin = lukku;
}
Console.WriteLine("Suurin numero on: " + suurin);


Console.Write("Syötä numero 0-9 väliltä");
string a = Console.ReadLine();

switch (a)
{
    case "0": Console.WriteLine("nolla"); break;
    case "1": Console.WriteLine("yksi"); break;
    case "2": Console.WriteLine("kaksi"); break;
    case "3": Console.WriteLine("kolme"); break;
    case "4": Console.WriteLine("neljä"); break;
    case "5": Console.WriteLine("viisi"); break;
    case "6": Console.WriteLine("kuusi"); break;
    case "7": Console.WriteLine("seitsemän"); break;
    case "8": Console.WriteLine("kahdeksan"); break;
    case "9": Console.WriteLine("yhdeksän"); break;
    default: Console.WriteLine("Syötä kelvollinen numero"); break;
}


Console.Write("Syötä eka numero ");
int nnumero = int.Parse(Console.ReadLine());
Console.Write("Syötä toka numero ");
int numeroo = int.Parse(Console.ReadLine());
Console.Write("Syötä kolmas numero ");
int nuumeroo = int.Parse(Console.ReadLine());
Console.Write("Syötä toka numero ");
int nummero = int.Parse(Console.ReadLine());
Console.Write("Syötä kolmas numero ");
int numerro = int.Parse(Console.ReadLine());

int isoin;

if (nnumero >= numeroo && nnumero >= nuumeroo && nnumero >= nummero && nnumero >= numerro)
{
    isoin = nnumero;
}
else if (numeroo >= nuumeroo && numeroo >= nummero && numeroo >= numerro)
{
    isoin = numeroo;
}
else if (nuumeroo >= nummero && nuumeroo >= numerro)
{
    isoin = nuumeroo;
}
else if (nummero >= numerro)
{
    isoin = nummero;
}
else
{
    isoin = numerro;
}

Console.WriteLine("Suurin numero on: " + isoin);


Console.WriteLine("Syötä valinta");
Console.WriteLine("1 Syötä kokonaisluku");
Console.WriteLine("2 Syötä liukuluku");
Console.WriteLine("3 Syötä merkkijonotaulukko");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Syötä kokonaisluku ");
        int apina = int.Parse(Console.ReadLine());
        Console.WriteLine("Tulos on : {0}", (apina + 1));
            break;

    case 2:
        Console.WriteLine("Syötä liukuluku ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Tulos on : {0}", (b+1));
        break;

    case 3:
        Console.WriteLine("Syötä merkkijonotaulukko ");
        string c = Console.ReadLine();
        Console.WriteLine("Tulos on : {0}", c + "*");
        break;

    default: Console.WriteLine("Ei kelvollinen");
        break;
}



Console.WriteLine("Syötä pisteet: ");
int pisteet = Int32.Parse(Console.ReadLine());

if (pisteet >= 1 && pisteet <= 3)
{
    Console.WriteLine(pisteet * 10);
}
else if (pisteet >= 4 && pisteet <= 6)
{
    Console.WriteLine(pisteet * 100);
}
else if (pisteet >= 7 && pisteet <= 9)
{
    Console.WriteLine(pisteet * 1000);
}
else
{
    Console.WriteLine("Syötä kelvollinen lukema");
}

*/


Console.Write("Enter a number between 0 and 999: ");
short number = Convert.ToInt16(Console.ReadLine());

byte hundreds = (byte)(number / 100 | 0);
byte tensAndOnes;

if (number > 99)
{
    tensAndOnes = (byte)(number % 100);
}
else tensAndOnes = (byte)(number * 1);

byte ones = (byte)(number % 10);

switch (hundreds)
{
    case 1: Console.Write("sata"); break;
    case 2: Console.Write("kaksisataa"); break;
    case 3: Console.Write("kolmesataa"); break;
    case 4: Console.Write("neljäsataa"); break;
    case 5: Console.Write("viisisataa"); break;
    case 6: Console.Write("kuusisataa"); break;
    case 7: Console.Write("seitsemänsataa"); break;
    case 8: Console.Write("kahdeksansataa"); break;
    case 9: Console.Write("yhdeksänsataa"); break;
}




if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("kaksikymmentä");
else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("kolmekymmentä");
else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("neljäkymmentä");
else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("viisikymmentä");
else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("kuusikymmentä");
else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("seitsemänkymmentä");
else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("kahdeksankymmentä");
else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("yhdeksänkymmentä");

switch (tensAndOnes)
{
    case 1: Console.Write("yksi"); break;
    case 2: Console.Write("kaksi"); break;
    case 3: Console.Write("kolme"); break;
    case 4: Console.Write("neljä"); break;
    case 5: Console.Write("viisi"); break;
    case 6: Console.Write("kuusi"); break;
    case 7: Console.Write("seitsemän"); break;
    case 8: Console.Write("kahdeksan"); break;
    case 9: Console.Write("yhdeksän"); break;
    case 10: Console.Write("kymmenen"); break;
    case 11: Console.Write("yksitoisat"); break;
    case 12: Console.Write("kaksitoista"); break;
    case 13: Console.Write("kolmetoisat"); break;
    case 14: Console.Write("neljätoista"); break;
    case 15: Console.Write("viisitoista"); break;
    case 16: Console.Write("kuusitoista"); break;
    case 17: Console.Write("seitsemäntoista"); break;
    case 18: Console.Write("kahdeksantoista"); break;
    case 19: Console.Write("yhdeksäntoista"); break;
}
if (tensAndOnes > 20)
{
    switch (ones)
    {
        case 1: Console.Write("yksi"); break;
        case 2: Console.Write("kaksi"); break;
        case 3: Console.Write("kolme"); break;
        case 4: Console.Write("neljä"); break;
        case 5: Console.Write("viisi"); break;
        case 6: Console.Write("kuusi"); break;
        case 7: Console.Write("seitsemän"); break;
        case 8: Console.Write("kahdeksan"); break;
        case 9: Console.Write("yhdeksän"); break;
    }
}
if (number == 0) Console.Write("nolla");
Console.ReadKey();
