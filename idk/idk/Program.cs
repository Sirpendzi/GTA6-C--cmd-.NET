using System;

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
            bool vlastnikGlock = true;
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
        Console.WriteLine("Opravdu to chceš koupit? [Ano / NE]");
        string vyberAR = Console.ReadLine().ToLower();
        if (vyberAR == "ano" && penize >= cenaAr15)
        {
            Console.WriteLine();
            Console.WriteLine("Gratulace jsi tedka vlastnikem AR15");
            penize = penize - cenaAr15;
            opakovani = true;
            Console.WriteLine("Tvůj učetní zůstatek je ted " + penize + " dolaru");
            Console.WriteLine();
            bool vlastnikAR15 = true;
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
                Console.WriteLine("Našel si poldu, co uděláš? chceš ho zabít [Ano / NE]");
                string vyberPolda = Console.ReadLine().ToLower();
                if (vyberPolda == "Ano")
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
                Console.WriteLine("Narazil jsi do Lamara, který se tě ptá jestli nechceš udělat nějakou težkou práci. Jdeš do toho? [Ano / NE]");
                string volbaCernoch = Console.ReadLine().ToLower();
                switch (volbaCernoch)
                {
                    case "Ano":
                        Console.WriteLine("Je rád, že nejsi děvka. Položil ti další otázku: Jakou prací si vybereš?");
                        Console.WriteLine("Chop, Fleeca, Prison, Auta, Vagos");
                        string volbaPracicky = Console.ReadLine().ToLower();
                        switch (volbaPracicky)
                        {
                            case "chop":
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Lamar: ");
                                Console.ResetColor();
                                Console.WriteLine("„Hele, kámo, potřebuju tvou pomoc. Můj pes, Chop, se dostal do průšvihu, negře. Nějaký divný týpci ho unesli.");
                                Console.WriteLine("Říkají, že jestli se do toho vložíme, nebude to pěkný... Potřebuju někoho, kdo se nebojí, chápeš? Jsi ready? [Ano / NE]“");
                                string volbaChop1 = Console.ReadLine().ToLower();
                                bool opakovaniChop1 = true;
                                while (opakovaniChop1 == true)
                                {
                                    switch (volbaChop1)
                                    {
                                        case "Ano":
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write("Lamar: ");
                                            Console.ResetColor();
                                            Console.WriteLine("„Dobrej kluk, věděl jsem, že na tebe se můžu spolehnout! Tady je plán – začneme tím, že prozkoumáme jejich doupě v South Los Santos.");
                                            Console.WriteLine("Slyšel jsem, že ti týpci kolem tohohle místa často krouží. Jdeme na to, jo?“ [Ano / NE]");
                                            string volbaChop2 = Console.ReadLine().ToLower();
                                            opakovaniChop1 = false;
                                            if (volbaChop2 == "Ano")
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
                                                        Console.WriteLine("1 - Zneškodnit je potichu / 2 - Obejít je");
                                                        int volbaChop5 = Convert.ToInt32(Console.ReadLine());
                                                        switch (volbaChop5)
                                                        {
                                                            case 1:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                int volbaChop6 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop6)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                        Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                        Thread.Sleep(1000);
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                        Console.ResetColor();
                                                                        int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop13)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                Console.ResetColor();
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                opakovaniChop1 = false;
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop14)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    default:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                        int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop8)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                            default:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case 2:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                Thread.Sleep(1000);
                                                                Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                int volbaChop12 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop12)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                        Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                        Thread.Sleep(1000);
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                        Console.ResetColor();
                                                                        int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop13)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                Console.ResetColor();
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                Console.ResetColor();
                                                                                opakovaniChop1 = false;
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop15)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    default:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                        int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop8)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            default:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("Kámo poslední dobou se na tebe nedá spolehnout... Rozhodnu za tebe a ty prostě půjdeš po mém, je ti to jasné?");
                                                                Random random3 = new Random();
                                                                int nahodneCernoch = random.Next(0, 2);
                                                                if (nahodneCernoch == 1)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                    Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                    Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                    Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                    Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                    int volbaChop17 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop17)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                            Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                            Console.ResetColor();
                                                                            int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop13)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                    Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                    Console.ResetColor();
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                    Console.ResetColor();
                                                                                    opakovaniChop1 = false;
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                                    int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop14)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                            int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop8)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                default:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                    Thread.Sleep(1000);
                                                                    Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                    Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                    Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                    Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                    int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop15)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                            Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                            Console.ResetColor();
                                                                            int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop13)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                    Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                    Console.ResetColor();
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                    Console.ResetColor();
                                                                                    opakovaniChop1 = false;
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                                    int volbaChop16 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop16)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                            int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop8)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case 2:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.WriteLine("„Haha, vidím, že máš rád rychlý řešení! OK, vytáhnem zbraně a jdeme rovnou dovnitř!");
                                                        Console.WriteLine("Chceš vzít první dávku, nebo si počkáš na signál ode mě?“");
                                                        Console.WriteLine("1 - Já začnu první / 2 - Počkám na tvůj signál");
                                                        int volbaChop7 = Convert.ToInt32(Console.ReadLine());
                                                        switch (volbaChop7)
                                                        {
                                                            case 1:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Dobře, máš koule! Jdi na ně, já se k tobě hned přidám.“");
                                                                Thread.Sleep(1000);
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Zamávej na mě, až nastane správná chvíle! Už se připravuju na akci!“");
                                                                for (int i = 3; i >= 0; i--)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("\r Lamar: " + i);
                                                                    Console.ResetColor();
                                                                    System.Threading.Thread.Sleep(1000);
                                                                }
                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                int volbaChop9 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop9)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                }
                                                                break;
                                                            case 2:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„OK, budu ti mávat, až nastane správná chvíle! Připrav se na akci!“");
                                                                for (int i = 3; i >= 0; i--)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("\r Lamar: " + i);
                                                                    Console.ResetColor();
                                                                    System.Threading.Thread.Sleep(1000);
                                                                }
                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop10)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.WriteLine("„Chytrý tah! Vytvoříme chaos, a jakmile se rozprchnou, proklouzneme.");
                                                        Console.WriteLine("Máme pár možností, jak je rozptýlit. Buď někam odpálíme autoalarm, nebo házíme flašku.");
                                                        Console.WriteLine("Co preferuješ?“ [1 - Autoalarm / 2 - Hodit flašku]");
                                                        int volbaChop11 = Convert.ToInt32(Console.ReadLine());
                                                        switch (volbaChop11)
                                                        {
                                                            case 1:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Fajn, trefný výběr! Tihle týpci se vrhnou jako blázni. Jdeme na to, já kryju!“");
                                                                Thread.Sleep(2000);
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop10)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                }
                                                                break;
                                                            case 2:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Super volba, kámo! Rozhodí je to, a my budeme mít volnou cestu k Chopovi.“");
                                                                Thread.Sleep(2000);
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                int volbaChop20 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop20)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                }
                                                                break;
                                                            default:
                                                                Console.WriteLine("Zadal jsi špatnou možnost, zkus to znova");
                                                                Console.WriteLine("");
                                                                break;
                                                        }
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
                                                opakovaniChop1 = false;
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
                                                        Console.WriteLine("1 - Zneškodnit je potichu / 2 - Obejít je");
                                                        int volbaChop5 = Convert.ToInt32(Console.ReadLine());
                                                        switch (volbaChop5)
                                                        {
                                                            case 1:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                int volbaChop6 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop6)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                        Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                        Thread.Sleep(1000);
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                        Console.ResetColor();
                                                                        int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop13)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                Console.ResetColor();
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                Console.ResetColor();
                                                                                opakovaniChop1 = false;
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop14)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    default:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                        int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop8)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                            default:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case 2:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                Thread.Sleep(1000);
                                                                Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                int volbaChop12 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop12)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                        Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                        Thread.Sleep(1000);
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                        Console.ResetColor();
                                                                        int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop13)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                Console.ResetColor();
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                Console.ResetColor();
                                                                                opakovaniChop1 = false;
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop15)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    default:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                        int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop8)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                break;
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            default:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("Kámo poslední dobou se na tebe nedá spolehnout... Rozhodnu za tebe a ty prostě půjdeš po mém, je ti to jasné?");
                                                                Random random3 = new Random();
                                                                int nahodneCernoch = random.Next(0, 2);
                                                                if (nahodneCernoch == 1)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                    Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                    Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                    Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                    Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                    int volbaChop17 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop17)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                            Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                            Console.ResetColor();
                                                                            int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop13)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                    Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                    Console.ResetColor();
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                    Console.ResetColor();
                                                                                    opakovaniChop1 = false;
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                    int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop14)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                            int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop8)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                default:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                    Thread.Sleep(1000);
                                                                    Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                    Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                    Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                    Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                    int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop15)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                            Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                            Console.ResetColor();
                                                                            int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop13)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                    Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                    Console.ResetColor();
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                    Console.ResetColor();
                                                                                    opakovaniChop1 = false;
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                    int volbaChop16 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop16)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                            int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop8)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case 2:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.WriteLine("„Haha, vidím, že máš rád rychlý řešení! OK, vytáhnem zbraně a jdeme rovnou dovnitř!");
                                                        Console.WriteLine("Chceš vzít první dávku, nebo si počkáš na signál ode mě?“");
                                                        Console.WriteLine("1 - Já začnu první / 2 - Počkám na tvůj signál");
                                                        int volbaChop7 = Convert.ToInt32(Console.ReadLine());
                                                        switch (volbaChop7)
                                                        {
                                                            case 1:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Dobře, máš koule! Jdi na ně, já se k tobě hned přidám.“");
                                                                Thread.Sleep(1000);
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Zamávej na mě, až nastane správná chvíle! Už se připravuju na akci!“");
                                                                for (int i = 3; i >= 0; i--)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("\r Lamar: " + i);
                                                                    Console.ResetColor();
                                                                    System.Threading.Thread.Sleep(1000);
                                                                }
                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                int volbaChop9 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop9)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                }
                                                                break;
                                                            case 2:
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„OK, budu ti mávat, až nastane správná chvíle! Připrav se na akci!“");
                                                                for (int i = 3; i >= 0; i--)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("\r Lamar: " + i);
                                                                    Console.ResetColor();
                                                                    System.Threading.Thread.Sleep(1000);
                                                                }
                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.Write("Lamar: ");
                                                                Console.ResetColor();
                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                switch (volbaChop10)
                                                                {
                                                                    case 1:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                    case 2:
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.Write("Lamar: ");
                                                        Console.ResetColor();
                                                        Console.WriteLine("„Chytrý tah! Vytvoříme chaos, a jakmile se rozprchnou, proklouzneme.");
                                                        Console.WriteLine("Máme pár možností, jak je rozptýlit. Buď někam odpálíme autoalarm, nebo házíme flašku.");
                                                        Console.WriteLine("Co preferuješ?“ [1 - Autoalarm / 2 - Hodit flašku]");
                                                        int volbaChop11 = Convert.ToInt32(Console.ReadLine());
                                                        switch (volbaChop11)
                                                        {
                                                            case 1:

                                                                break;
                                                            case 2:
                                                                break;
                                                            default:
                                                                Console.WriteLine("Zadal jsi špatnou možnost, zkus to znova");
                                                                Console.WriteLine("");
                                                                break;
                                                        }
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
                                            break;
                                        case "ne":
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write("Lamar: ");
                                            Console.ResetColor();
                                            Console.WriteLine("„Cože, fakt? Hele, já chápu, jestli tě to děsí, ale teď nemáme čas váhat. Chop potřebuje pomoc.");
                                            Console.WriteLine("Jdeš, nebo tě mám někam odložit, dokud to nebude hotový?“ [Ano / NE]");
                                            string volbaChop3 = Console.ReadLine().ToLower();
                                            switch (volbaChop3)
                                            {
                                                case "Ano":
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.Write("Lamar: ");
                                                    Console.ResetColor();
                                                    Console.WriteLine("Kámo, věděl jsem, že se na mě nevykašleš.");
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
                                                            Console.WriteLine("1 - Zneškodnit je potichu / 2 - Obejít je");
                                                            int volbaChop5 = Convert.ToInt32(Console.ReadLine());
                                                            switch (volbaChop5)
                                                            {
                                                                case 1:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                    Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                    Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                    Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                    Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                    int volbaChop6 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop6)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                            Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                            Console.ResetColor();
                                                                            int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop13)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                    Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                    Console.ResetColor();
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                    Console.ResetColor();
                                                                                    opakovaniChop1 = false;
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                    int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop14)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                            int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop8)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                default:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                    Thread.Sleep(1000);
                                                                    Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                    Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                    Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                    Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                    int volbaChop12 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop12)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                            Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                            Console.ResetColor();
                                                                            int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop13)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                    Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                    Console.ResetColor();
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                    Console.ResetColor();
                                                                                    opakovaniChop1 = false;
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                    int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop15)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                            int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop8)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                    break;
                                                                default:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("Kámo poslední dobou se na tebe nedá spolehnout... Rozhodnu za tebe a ty prostě půjdeš po mém, je ti to jasné?");
                                                                    Random random3 = new Random();
                                                                    int nahodneCernoch = random.Next(0, 2);
                                                                    if (nahodneCernoch == 1)
                                                                    {
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                        Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                        Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                        Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                        Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                        int volbaChop17 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop17)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                                Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                                Thread.Sleep(1000);
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                                Console.ResetColor();
                                                                                int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop13)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                        Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                        Console.ResetColor();
                                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                                        Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                        Console.ResetColor();
                                                                                        opakovaniChop1 = false;
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                        int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (volbaChop14)
                                                                                        {
                                                                                            case 1:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            case 2:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            default:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop8)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    default:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("Lamar: ");
                                                                        Console.ResetColor();
                                                                        Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                        Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                        Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                        Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                        int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                        switch (volbaChop15)
                                                                        {
                                                                            case 1:
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                                Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                                Thread.Sleep(1000);
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                                Console.ResetColor();
                                                                                int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop13)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                        Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                        Console.ResetColor();
                                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                                        Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                        Console.ResetColor();
                                                                                        opakovaniChop1 = false;
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                        int volbaChop16 = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (volbaChop16)
                                                                                        {
                                                                                            case 1:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            case 2:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            default:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                break;
                                                                            case 2:
                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop8)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case 2:
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.WriteLine("„Haha, vidím, že máš rád rychlý řešení! OK, vytáhnem zbraně a jdeme rovnou dovnitř!");
                                                            Console.WriteLine("Chceš vzít první dávku, nebo si počkáš na signál ode mě?“");
                                                            Console.WriteLine("1 - Já začnu první / 2 - Počkám na tvůj signál");
                                                            int volbaChop7 = Convert.ToInt32(Console.ReadLine());
                                                            switch (volbaChop7)
                                                            {
                                                                case 1:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Dobře, máš koule! Jdi na ně, já se k tobě hned přidám.“");
                                                                    Thread.Sleep(1000);
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Zamávej na mě, až nastane správná chvíle! Už se připravuju na akci!“");
                                                                    for (int i = 3; i >= 0; i--)
                                                                    {
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("\r Lamar: " + i);
                                                                        Console.ResetColor();
                                                                        System.Threading.Thread.Sleep(1000);
                                                                    }
                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                    int volbaChop9 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop9)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„OK, budu ti mávat, až nastane správná chvíle! Připrav se na akci!“");
                                                                    for (int i = 3; i >= 0; i--)
                                                                    {
                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                        Console.Write("\r Lamar: " + i);
                                                                        Console.ResetColor();
                                                                        System.Threading.Thread.Sleep(1000);
                                                                    }
                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                    int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop10)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case 3:
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.WriteLine("„Chytrý tah! Vytvoříme chaos, a jakmile se rozprchnou, proklouzneme.");
                                                            Console.WriteLine("Máme pár možností, jak je rozptýlit. Buď někam odpálíme autoalarm, nebo házíme flašku.");
                                                            Console.WriteLine("Co preferuješ?“ [1 - Autoalarm / 2 - Hodit flašku]");
                                                            int volbaChop11 = Convert.ToInt32(Console.ReadLine());
                                                            switch (volbaChop11)
                                                            {
                                                                case 1:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Fajn, trefný výběr! Tihle týpci se vrhnou jako blázni. Jdeme na to, já kryju!“");
                                                                    Thread.Sleep(2000);
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                    int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop10)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Fajn, trefný výběr! Tihle týpci se vrhnou jako blázni. Jdeme na to, já kryju!“");
                                                                    Thread.Sleep(2000);
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                    int volbaChop21 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop21)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                            break;
                                                                    }
                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Zadal jsi špatnou možnost, zkus to znova");
                                                                    Console.WriteLine("");
                                                                    break;
                                                            }
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
                                                    Console.WriteLine("Je to Ano nebo ne? [Ano / NE]");
                                                    string volbaChop18 = Console.ReadLine().ToLower();
                                                    switch (volbaChop18)
                                                    {
                                                        case "Ano":
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.Write("Lamar: ");
                                                            Console.ResetColor();
                                                            Console.WriteLine("Kámo, věděl jsem, že se na mě nevykašleš.");
                                                            Console.WriteLine("Máme tři možnosti, jak na to jít. Můžeme to vzít opatrně a vplížit se zezadu.");
                                                            Console.WriteLine("Nebo to můžeme vzít přímo – ale to už bude pořádná akce");
                                                            Console.WriteLine("Taky můžeme zkusit odlákat pozornost a pak se k Chopovi dostat.“ [1 - Opatrný přístup (plížení) / 2 - Přímý útok (akce) / 3 - Odlákat pozornost (past)]");
                                                            int volbaChop19 = Convert.ToInt32(Console.ReadLine());
                                                            switch (volbaChop19)
                                                            {
                                                                case 1:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Dobře, plížíme se! Ticho a klidně, jinak si nás všimnou. Vidím tam dva týpky.");
                                                                    Console.WriteLine("Buď se můžeme připlížit a vyřadit je potichu, nebo je obejdeme. Co si myslíš?“");
                                                                    Console.WriteLine("1 - Zneškodnit je potichu / 2 - Obejít je");
                                                                    int volbaChop5 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop5)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                            Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                            Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                            Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                            Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                            int volbaChop6 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop6)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                                    Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                                    Thread.Sleep(1000);
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                                    Console.ResetColor();
                                                                                    int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop13)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                            Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                            Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                            Console.ResetColor();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                            Console.ResetColor();
                                                                                            opakovaniChop1 = false;
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                            Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                            int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                            switch (volbaChop14)
                                                                                            {
                                                                                                case 1:
                                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                    Console.Write("Lamar: ");
                                                                                                    Console.ResetColor();
                                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                    break;
                                                                                                case 2:
                                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                    Console.Write("Lamar: ");
                                                                                                    Console.ResetColor();
                                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                    break;
                                                                                                default:
                                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                    Console.Write("Lamar: ");
                                                                                                    Console.ResetColor();
                                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                    break;
                                                                                            }
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                    int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop8)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        default:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                            Thread.Sleep(1000);
                                                                            Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                            Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                            Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                            Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                            int volbaChop12 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop12)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                                    Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                                    Thread.Sleep(1000);
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                                    Console.ResetColor();
                                                                                    int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop13)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                            Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                            Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                            Console.ResetColor();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                            Console.ResetColor();
                                                                                            opakovaniChop1 = false;
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                            Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                            int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                                            switch (volbaChop15)
                                                                                            {
                                                                                                case 1:
                                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                    Console.Write("Lamar: ");
                                                                                                    Console.ResetColor();
                                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                    break;
                                                                                                case 2:
                                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                    Console.Write("Lamar: ");
                                                                                                    Console.ResetColor();
                                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                    break;
                                                                                                default:
                                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                    Console.Write("Lamar: ");
                                                                                                    Console.ResetColor();
                                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                    break;
                                                                                            }
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                    Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                    Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                    int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (volbaChop8)
                                                                                    {
                                                                                        case 1:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                        case 2:
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.Write("Lamar: ");
                                                                                            Console.ResetColor();
                                                                                            Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        default:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("Kámo poslední dobou se na tebe nedá spolehnout... Rozhodnu za tebe a ty prostě půjdeš po mém, je ti to jasné?");
                                                                            Random random3 = new Random();
                                                                            int nahodneCernoch = random.Next(0, 2);
                                                                            if (nahodneCernoch == 1)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Tak to je ono! Hned vědí, že jim lezeme do rajónu!“ (Vytahuje zbraň a připravuje se na akci.)");
                                                                                Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                                Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                                Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                                Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                                int volbaChop17 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop17)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                                        Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                                        Thread.Sleep(1000);
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                                        Console.ResetColor();
                                                                                        int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (volbaChop13)
                                                                                        {
                                                                                            case 1:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                                Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                                Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                                Console.ResetColor();
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                                Console.ResetColor();
                                                                                                opakovaniChop1 = false;
                                                                                                break;
                                                                                            case 2:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                                Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                                int volbaChop14 = Convert.ToInt32(Console.ReadLine());
                                                                                                switch (volbaChop14)
                                                                                                {
                                                                                                    case 1:
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.Write("Lamar: ");
                                                                                                        Console.ResetColor();
                                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                        break;
                                                                                                    case 2:
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.Write("Lamar: ");
                                                                                                        Console.ResetColor();
                                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                        break;
                                                                                                    default:
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.Write("Lamar: ");
                                                                                                        Console.ResetColor();
                                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                        break;
                                                                                                }
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                        int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (volbaChop8)
                                                                                        {
                                                                                            case 1:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            case 2:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            default:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("Lamar: ");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("„Hm, dobrý nápad, ušetříme energii na další potíže. Jdeme dál!“");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("„OK, kámo, jsme tady kvůli Chopovi, takže žádný slitování.");
                                                                                Console.WriteLine("Další krok je čistka uvnitř, anebo rychlý průzkum.");
                                                                                Console.WriteLine("Radši chceš prozkoumat dům, nebo vzít Chopa a utéct?“");
                                                                                Console.WriteLine("1 - Prozkoumat dům / 2 - Rychle sebrat Chopa a utéct");
                                                                                int volbaChop15 = Convert.ToInt32(Console.ReadLine());
                                                                                switch (volbaChop15)
                                                                                {
                                                                                    case 1:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Chytrý tah!Možná narazíme na něco, co nám usnadní práci.");
                                                                                        Console.WriteLine("Dej si ale pozor, ať nás nenachytají!“");
                                                                                        Thread.Sleep(1000);
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("Našel jsi pozlacenou truhlu... Chceš ji otevřít [1 - Ano / 2 - Ne]");
                                                                                        Console.ResetColor();
                                                                                        int volbaChop13 = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (volbaChop13)
                                                                                        {
                                                                                            case 1:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("Co to děláš negře hloupej, nech to tak, ještě nás dostaneš do zbytečných problémů...");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                                Console.WriteLine("Truhla se otevřela a uvnitř byla skrytá past! V místnosti se začal šířit jedovatý plyn...");
                                                                                                Console.WriteLine("Chop, který stál poblíž, se nadýchal plynu a zhroutil se na zem.");
                                                                                                Console.ResetColor();
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("Lamar: To ne! Chop je pryč, kámo... To si pamatuj, už ti za takovou práci platit nebudu! A buď rád, že vůbec odcházíš živý.");
                                                                                                Console.ResetColor();
                                                                                                opakovaniChop1 = false;
                                                                                                break;
                                                                                            case 2:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                                Console.WriteLine("Udělal si správnou věc a jdeš od truhličky dále");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Okej kámo, jdeme si pro Chopa. Žádné hlouposti...");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                                Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                                Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                                int volbaChop16 = Convert.ToInt32(Console.ReadLine());
                                                                                                switch (volbaChop16)
                                                                                                {
                                                                                                    case 1:
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.Write("Lamar: ");
                                                                                                        Console.ResetColor();
                                                                                                        Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                        break;
                                                                                                    case 2:
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.Write("Lamar: ");
                                                                                                        Console.ResetColor();
                                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                        break;
                                                                                                    default:
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.Write("Lamar: ");
                                                                                                        Console.ResetColor();
                                                                                                        Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                        break;
                                                                                                }
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                    case 2:
                                                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                                        Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.Write("Lamar: ");
                                                                                        Console.ResetColor();
                                                                                        Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                                        Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                                        int volbaChop8 = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (volbaChop8)
                                                                                        {
                                                                                            case 1:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                            case 2:
                                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                Console.Write("Lamar: ");
                                                                                                Console.ResetColor();
                                                                                                Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                }
                                                                            }
                                                                            break;
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Haha, vidím, že máš rád rychlý řešení! OK, vytáhnem zbraně a jdeme rovnou dovnitř!");
                                                                    Console.WriteLine("Chceš vzít první dávku, nebo si počkáš na signál ode mě?“");
                                                                    Console.WriteLine("1 - Já začnu první / 2 - Počkám na tvůj signál");
                                                                    int volbaChop7 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop7)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Dobře, máš koule! Jdi na ně, já se k tobě hned přidám.“");
                                                                            Thread.Sleep(1000);
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Zamávej na mě, až nastane správná chvíle! Už se připravuju na akci!“");
                                                                            for (int i = 3; i >= 0; i--)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("\r Lamar: " + i);
                                                                                Console.ResetColor();
                                                                                System.Threading.Thread.Sleep(1000);
                                                                            }
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                            int volbaChop9 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop9)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, kamaráde! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„OK, budu ti mávat, až nastane správná chvíle! Připrav se na akci!“");
                                                                            for (int i = 3; i >= 0; i--)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.Write("\r Lamar: " + i);
                                                                                Console.ResetColor();
                                                                                System.Threading.Thread.Sleep(1000);
                                                                            }
                                                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                                            Console.WriteLine("( Vrháte se na hlídače a po krátkém boji dorazíte do místnosti, kde najdete Chopa spoutaného a vyděšeného.)");
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - NE]");
                                                                            int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop10)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                    }
                                                                    break;
                                                                case 3:
                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                    Console.Write("Lamar: ");
                                                                    Console.ResetColor();
                                                                    Console.WriteLine("„Chytrý tah! Vytvoříme chaos, a jakmile se rozprchnou, proklouzneme.");
                                                                    Console.WriteLine("Máme pár možností, jak je rozptýlit. Buď někam odpálíme autoalarm, nebo házíme flašku.");
                                                                    Console.WriteLine("Co preferuješ?“ [1 - Autoalarm / 2 - Hodit flašku]");
                                                                    int volbaChop11 = Convert.ToInt32(Console.ReadLine());
                                                                    switch (volbaChop11)
                                                                    {
                                                                        case 1:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Fajn, trefný výběr! Tihle týpci se vrhnou jako blázni. Jdeme na to, já kryju!“");
                                                                            Thread.Sleep(2000);
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                            int volbaChop10 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop10)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Fajn, trefný výběr! Tihle týpci se vrhnou jako blázni. Jdeme na to, já kryju!“");
                                                                            Thread.Sleep(2000);
                                                                            Console.Write("Lamar: ");
                                                                            Console.ResetColor();
                                                                            Console.WriteLine("„Chope! No vidíš, kámo, konečně jsme ho našli! ");
                                                                            Console.WriteLine("A teď rychle pryč, než si nás všimne víc poskoků. Utíkáme hned?“ [1 - Ano / 2 - Ne]");
                                                                            int volbaChop22 = Convert.ToInt32(Console.ReadLine());
                                                                            switch (volbaChop22)
                                                                            {
                                                                                case 1:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„To je ono, negře! Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                                case 2:
                                                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                    Console.Write("Lamar: ");
                                                                                    Console.ResetColor();
                                                                                    Console.WriteLine("„Kámo musíme utíkat, není čas na výmluvy. Chop je doma, díky tobě. Víš co? Dlužím ti službičku... a nějaký ty chechtáky.“");
                                                                                    break;
                                                                            }
                                                                            break;
                                                                        default:
                                                                            Console.WriteLine("Zadal jsi špatnou možnost, zkus to znova");
                                                                            Console.WriteLine("");
                                                                            break;
                                                                    }
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
