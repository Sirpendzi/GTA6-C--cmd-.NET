Console.WriteLine("Chceš jít na PC nebo XBOX servery.");
string server = Console.ReadLine();
if (server == "XBOX")
{
    Console.WriteLine("Připojil jsi se na XBOX servery.");
}
else if (server == "PC")
{
    Console.WriteLine("jdeš cheatovat ty hajzle že.");
}
else
{
    Console.WriteLine("Na take servery nemame budget kamo");
    Console.WriteLine("Tvůj progress se nebude ukládat (nevim jak ti to mam vypnout tak proto)");
}

bool opakovani = true;

while (opakovani == true)
{
    Console.WriteLine("Kam chceš jít [W,A,S,D]");
    string vyber = Console.ReadLine();
    if (vyber == "W")
    {
        Random random = new Random();
        int nahodnePolda = random.Next(0, 7);
        if (nahodnePolda == 4)
        {
        Console.WriteLine("Našel si poldu, co uděláš? chceš ho zabít [A.N]");
        string vyberPolda = Console.ReadLine();
        if (vyberPolda == "A")
        {
            Console.WriteLine("Zabil si poldu");
        }
        else if (vyberPolda == "N")
        {
            Console.WriteLine("Nezabil si poldu");
        }
        else
        {
            Console.WriteLine("Polda tě zatkl");
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    } else
        {
        Console.WriteLine("Šel jsi dopředu");
        }
    }
    else if (vyber == "A")
    {
        Random random = new Random();
        int nahodneBanka = random.Next(0, 21);
        if (nahodneBanka == 18)
        {
            Console.WriteLine("Udělal si banku");
            Console.WriteLine("Co ted? A pro utek, B pro boj, C pro sebevraždu");
            string volbaBanka = Console.ReadLine();
            switch (volbaBanka)
            {
                case "A":
                    Console.WriteLine("Utekl si");
                    break;
                case "B":
                    Console.WriteLine("Bojoval si, ale umřel si");
                    break;
                case "C":
                    Console.WriteLine("To nejde, ale chytli tě");
                    break;
                default:
                    Console.WriteLine("Umřel si na dehydrataci");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WASTED");
                    Console.ResetColor();
                    break;
            }

        }
        else
        {
            Console.WriteLine("Šel jsi doleva");
        }
    }
    else if (vyber == "S")
    {
        Random random = new Random();
        int krokDozadu = random.Next(0, 40);
        if (krokDozadu == 36)
        {
            Console.WriteLine("Narazil jsi do Lamara, který se tě ptá jestli nechceš udělat nějakou težkou práci. Jdeš do toho? [ANO / NE]");
            string volbaCernoch = Console.ReadLine().ToLower();
            switch (volbaCernoch)
            {
                case "ano":
                    Console.WriteLine("Je rád, že nejsi děvka. Položil ti další otázku: Jakou prací si vybereš?");
                    Console.WriteLine("Chop, Fleeca, Prison, Auta, Vagos");
                    string volbaPracicky = Console.ReadLine().ToLower();
                    switch (volbaPracicky)
                    {
                        case "chop":
                            break;
                        case "fleeca":
                            break;
                        case "prison":
                            break;
                        case "auta":
                            break;
                        case "vagos":
                            break;
                    }
                    break;
                case "ne":
                    Console.WriteLine("Lamar se na tebe naštval a rozstřílel tě orbital kanonem");
                    break;
                default:
                    Console.WriteLine("Jsi kokot?");
                    break;
            }
        } 
        else
        {
        Console.WriteLine("Šel jsi dozadu");
        }
    }
    else if (vyber == "D")
    {
        Console.WriteLine("Šel jsi doprava");
    }
    else if (vyber == "04122007")
    {
        Console.WriteLine("Našel jsi secret a zabijíš Trevora");
        Console.ForegroundColor= ConsoleColor.DarkYellow;
        Console.WriteLine("Victory Royale");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("Trevor tě zabil");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Wasted");
        Console.ResetColor();
        opakovani = false;
    }
}
