﻿bool opakovani = true;

while (opakovani == true)
{
    Console.WriteLine("Kam chceš jít [W,A,S,D]");
    string vyber = Console.ReadLine();
    if (vyber == "W")
    {
        Console.WriteLine("Šel jsi dopředu");
        Console.WriteLine("Našel si poldu, co uděláš? chceš ho zabít [A.N]");
        string vyberPolda = Console.ReadLine();
        if (vyberPolda == "A")
        {
            Console.WriteLine("Zabil si poldu");
        } else if (vyberPolda == "N")
        {
            Console.WriteLine("Nezabil si poldu");
        } else
        {
            Console.WriteLine("Polda tě zatkl");
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    } else if (vyber == "A")
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
                    break ;
                case "C":
                    Console.WriteLine("To nejde, ale chytli tě");
                    break;
                default:
                    Console.WriteLine("Umřel si na dehydrataci");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WASTED");
                    break;
            }
            
        }
        else
        {
            Console.WriteLine("Šel jsi doleva");
        }
    } else if (vyber == "S")
    {
        Console.WriteLine("Šel jsi dozadu");
    } else if (vyber == "D")
    {
        Console.WriteLine("Šel jsi doprava");
    } else
    {
        Console.WriteLine("Trevor tě zabil");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Wasted");
        opakovani = false;
    }
}
