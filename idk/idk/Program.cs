Console.WriteLine("Chceš jít na PC nebo XBOX servery.");
string server = Console.ReadLine().ToLower();
if (server == "xbox")
{
    Console.WriteLine("Připojil jsi se na XBOX servery.");
}
else if (server == "pc")
{
    Console.WriteLine("jdeš cheatovat ty hajzle že.");
}
else
{
    Console.WriteLine("Na take servery nemame budget kamo");
    Console.WriteLine("Tvůj progress se nebude ukládat (nevim jak ti to mam vypnout tak proto)");
}

bool opakovani = false;

Random random1 = new Random();
int penize = random1.Next(5000, 40000);
Console.WriteLine();
Console.WriteLine("Vítej nováčku ve světě GTA, Máš na účtě " + penize + " dollaru");
Console.WriteLine("Chceš si jít hned koupit zbran na zacatek? jít do obchodu se zbraněmi [ANO / NE]");
string vyberZacatekZbrane = Console.ReadLine().ToLower();
int cenaGlock = 3000;
int cenaAr15 = 15000;
if (vyberZacatekZbrane == "ano")
{
    Console.WriteLine("šel jsi do obchodu se zbraněmi");
    Console.WriteLine();
    Console.WriteLine("Nabídka");
    Console.WriteLine("Glock 19 - 3000");
    Console.WriteLine("AR15 - 15000");
    Console.WriteLine("Chceš si něco koupit? [Glock, AR15]");
    string vyberNabidkaZbrane = Console.ReadLine().ToLower();
    if (vyberNabidkaZbrane == "glock")
    {
        Console.WriteLine();
        Console.WriteLine("Opravdu to chceš koupit? [ANO / NE]");
        string vyberGlock = Console.ReadLine().ToLower();
        if (vyberGlock == "ano" && penize >= cenaGlock)
        {
            Console.WriteLine();
            Console.WriteLine("Gratulace jsi tedka vlastnikem Glocku 19");
            penize = penize - cenaGlock;
            opakovani = true;
            Console.WriteLine("Tvůj učetní zůstatek je ted " + penize + " dolaru");
            Console.WriteLine();
        }
        else if (vyberGlock == "ano" && penize < cenaGlock)
        {
            Console.WriteLine();
            Console.WriteLine("Nemáš peníze na zakoupení této zbraně");
            Console.WriteLine();
            opakovani = true;
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("Odešel si z obchodu");
            opakovani = true;
        }
    }
    else if (vyberNabidkaZbrane == "ar15")
    {
        Console.WriteLine();
        Console.WriteLine("Opravdu to chceš koupit? [ANO / NE]");
        string vyberAR = Console.ReadLine().ToLower();
        if (vyberAR == "ano" && penize >= cenaAr15)
        {
            Console.WriteLine();
            Console.WriteLine("Gratulace jsi tedka vlastnikem AR15");
            penize = penize - cenaAr15;
            opakovani = true;
            Console.WriteLine("Tvůj učetní zůstatek je ted " + penize + " dolaru");
            Console.WriteLine();
        }
        else if (vyberAR == "ano" && penize < cenaAr15)
        {
            Console.WriteLine();
            Console.WriteLine("Nemáš peníze na zakoupení této zbraně");
            Console.WriteLine();
            opakovani = true;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Odešel si z obchodu");
            opakovani = true;
        }
    }
    // dodělat system když nechce jit do obchodu tak opakovani = true a nic se nestane

    while (opakovani == true)
    {
        Console.WriteLine("Kam chceš jít [W,A,S,D]                 Zobrazit penize [Love]");
        string vyber = Console.ReadLine().ToLower();
        if (vyber == "w")
        {
            Random random = new Random();
            int nahodnePolda = random.Next(0, 7);
            if (nahodnePolda == 4)
            {
                Console.WriteLine("Našel si poldu, co uděláš? chceš ho zabít [ANO / NE]");
                string vyberPolda = Console.ReadLine().ToLower();
                if (vyberPolda == "ano")
                {
                    Console.WriteLine("Zabil si poldu");
                }
                else if (vyberPolda == "ne")
                {
                    Console.WriteLine("Nezabil si poldu");
                }
                else
                {
                    Console.WriteLine("Polda tě zatkl");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            else
            {
                Console.WriteLine("Šel jsi dopředu");
            }
        }
        else if (vyber == "a")
        {
            Random random = new Random();
            int nahodneBanka = random.Next(0, 21);
            if (nahodneBanka == 18)
            {
                Console.WriteLine("Udělal si banku");
                Console.WriteLine("Co ted? A pro utek, B pro boj, C pro sebevraždu");
                string volbaBanka = Console.ReadLine().ToLower();
                switch (volbaBanka)
                {
                    case "a":
                        Console.WriteLine("Utekl si");
                        break;
                    case "b":
                        Console.WriteLine("Bojoval si, ale umřel si");
                        break;
                    case "c":
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
        else if (vyber == "s")
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
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Lamar: ");
                                Console.ResetColor();
                                Console.WriteLine("„Hele, kámo, potřebuju tvou pomoc. Můj pes, Chop, se dostal do průšvihu, brácho. Nějaký divný týpci ho unesli.");
                                Console.WriteLine("Říkají, že jestli se do toho vložíme, nebude to pěkný... Potřebuju někoho, kdo se nebojí, chápeš? Jsi ready? [ANO / NE]“");
                                string volbaChop1 = Console.ReadLine().ToLower();
                                bool opakovaniChop1 = true;
                                while (opakovaniChop1 == true)
                                {
                                    switch (volbaChop1)
                                    {
                                        case "ano":
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write("Lamar: ");
                                            Console.ResetColor();
                                            Console.WriteLine("„Dobrej kluk, věděl jsem, že na tebe se můžu spolehnout! Tady je plán – začneme tím, že prozkoumáme jejich doupě v South Los Santos.");
                                            Console.WriteLine("Slyšel jsem, že ti týpci kolem tohohle místa často krouží. Jdeme na to, jo?“ [ANO / NE]");
                                            string volbaChop2 = Console.ReadLine().ToLower();
                                            if (volbaChop2 == "ano")
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Lamar: ");
                                                Console.ResetColor();
                                                Console.WriteLine("„Fajn, počítal jsem s tebou! Počítej s tím, že to nebude procházka růžovým sadem. Ti týpci jsou ostří.");
                                                Console.WriteLine("Máme tři možnosti, jak na to jít. Můžeme to vzít opatrně a vplížit se zezadu.");
                                                Console.WriteLine("Nebo to můžeme vzít přímo – ale to už bude pořádná akce");
                                                Console.WriteLine("Taky můžeme zkusit odlákat pozornost a pak se k Chopovi dostat.“ [1 - Opatrný přístup (plížení) / 2 - Přímý útok (akce) / 3 - Odlákat pozornost (past)]");
                                                int volbaChop4 = Convert.ToInt32(Console.ReadLine());
                                                switch (volbaChop4)
                                                {
                                                    case 1:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.WriteLine("„Dobře, plížíme se! Ticho a klidně, jinak si nás všimnou. Vidím tam dva týpky.");
                                                        Console.WriteLine("Buď se můžeme připlížit a vyřadit je potichu, nebo je obejdeme. Co si myslíš?“");
                                                        Console.WriteLine("1 - Zabít je / 2 - Obejít je");
                                                        // POKRAČOVAT
                                                        break;
                                                    case 2:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        // POKRAČOVAT
                                                        break;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        // POKRAČOVAT
                                                        break;
                                                    default:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.WriteLine("To sis u mě posral kámo... To jsem od tebe nečekal.");
                                                        Console.WriteLine("Už si Lamara nasral a zastřelil tě!");
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Wasted");
                                                        Console.ResetColor();
                                                        opakovani = false;
                                                        opakovaniChop1 = false;
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Bohužel kámo, není cesty zpět, už jsi mi to odsouhlasil.");
                                            }
                                            break;
                                        case "ne":
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write("Lamar: ");
                                            Console.ResetColor();
                                            Console.WriteLine("„Cože, fakt? Hele, já chápu, jestli tě to děsí, ale teď nemáme čas váhat. Chop potřebuje pomoc.");
                                            Console.WriteLine("Jdeš, nebo tě mám někam odložit, dokud to nebude hotový?“ [ANO / NE]");
                                            string volbaChop3 = Console.ReadLine().ToLower();
                                            switch (volbaChop3)
                                            {
                                                case "ano":
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.Write("Lamar: ");
                                                    Console.ResetColor();
                                                    Console.WriteLine("Kámo, věděl jsem, že se na mě nevykašleš.");
                                                    break;
                                                case "ne":
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.Write("Lamar: ");
                                                    Console.ResetColor();
                                                    Console.WriteLine("To sis u mě posral kámo... To jsem od tebe nečekal.");
                                                    Console.WriteLine("Už si Lamara nasral a zastřelil tě!");
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Wasted");
                                                    Console.ResetColor();
                                                    opakovani = false;
                                                    opakovaniChop1 = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Je to ano nebo ne? [ANO / NE]");
                                                    string volbaChop4 = Console.ReadLine().ToLower();
                                                    switch (volbaChop4)
                                                    {
                                                        case "ano":
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.WriteLine("Kámo, věděl jsem, že se na mě nevykašleš.");
                                                            //POKRAČOVÁNÍ VLOŽIT Z ŘÁDKU 121
                                                            break;
                                                        case "ne":
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.WriteLine("To sis u mě posral kámo... To jsem od tebe nečekal.");
                                                            Console.WriteLine("Už si Lamara nasral a zastřelil tě!");
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.WriteLine("Wasted");
                                                            Console.ResetColor();
                                                            opakovani = false;
                                                            opakovaniChop1 = false;
                                                            break;
                                                        default:
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.WriteLine("To sis u mě posral kámo... To jsem od tebe nečekal.");
                                                            Console.WriteLine("Už si Lamara nasral a zastřelil tě!");
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.WriteLine("Wasted");
                                                            Console.ResetColor();
                                                            opakovani = false;
                                                            opakovaniChop1 = false;
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Nezvykej si na to, že ti to bude vycházet pokaždé. Jednou ti to Lamar vrátí");
                                            opakovaniChop1 = false;
                                            break;
                                    }

                                }
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
        else if (vyber == "d")
        {
            Console.WriteLine("Šel jsi doprava");
        }
        else if (vyber == "love")
        {
            Console.WriteLine("Tvůj zůstatek na účtě je " + penize + " dolaru");
        }
        else if (vyber == "04122007")
        {
            Console.WriteLine("Našel jsi secret a zabijíš Trevora");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Victory Royale");
            Console.WriteLine("Dostal si 1 000 000 000 dolaru jako odmenu");
            penize = penize + 1000000000;
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
}
