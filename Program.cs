class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Witaj kochanie w teście o tygryiu \n Test będzie składać się z pytań... część z nich będzie tak lub nie a w częsci będziesz musiałą podawać konkretną odpowiedz \n Wpisując odpowiedzi pisz TYLKO z malych literek i nie uzywaj polskich znakow... czyli slowo Żółw napisz jako zolw");
        Console.WriteLine("\nWspomnę tylko że na starcie masz 10 paskow a błędna odpowiedz odejmie ci 1 z nich. Zonbaczymy ile pasków uda ci się zachować");
        Console.WriteLine("\nGotowa?");

        string odpowiedz;

        odpowiedz = Console.ReadLine();

        if (odpowiedz == "tak")
        {
            Console.WriteLine("\nTo ruszamy! Powodzenia");
        }
        else
        {
            Console.WriteLine("\nTrudno i tak ruszamy");
        }

        int paski = 10;

        Console.WriteLine("Pytanie 1. \nGdzie urodzil się Michał (Podaj nazwę miasta np katowice)");
        string op1 = Console.ReadLine();

        if (op1 == "wroclaw")
        {
            Console.WriteLine("Brawo Ciapku. Nadal masz wszystkie paski");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Poprawna odpowiedz to \"wroclaw\" Ciapku. Tracisz pasek");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");

        }

        Console.WriteLine();

        Console.WriteLine("Pytanie 2. Jakiego koloru są oczy twojego tygryska?");
        string op2 = Console.ReadLine();

        if (op2 == "brazowe" && paski == 10)
        {
            Console.WriteLine("Brawo Ciapku. Nadal masz wszystkie paski ");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else if (op2 == "brazowe" && paski == 9)
        {
            Console.WriteLine("Brawo Ciapku. Tym razem zachowalas pasek");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Wstydz się. Tracisz pasek");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();

        Console.WriteLine("Pytanie 3. Jak nazywał się mój nieśmiertelny chomik?");
        string op3 = Console.ReadLine();

        if (op3 == "milka")
        {
            Console.WriteLine("Super Kochanie :*");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("To była MILKA. Wybacz ale zabieram pasek");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        Console.WriteLine();

        Console.WriteLine("Pytanie 4. na którym palcu twój narzeczony nosił sygnet? (odpowiedz powinna wygladać np \"l3\" co oznacza że mialem go na lewej rece na srodkowym palcu. kciuk to numer 1 a maly palec 5");
        string op4 = Console.ReadLine();

        if (op4 == "p4")
        {
            Console.WriteLine("Grzeczna dziewczynka.");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Bywa. Leci paseczek");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();

        Console.WriteLine("Ok czas na pytanie 5. Kto kogo pierwszy pocałował (odpowiedz \"ja\" lub \"ty\" pamietaj że odpowiedasz w swoim imieniu");
        string op5 = Console.ReadLine();

        if (op5 == "ja")
        {
            Console.WriteLine("HAHAHA Ciapek całował pierwszy ! Łap pasek w nagrode");
            ++paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Małą kłamczucha. I cyk pasek stracony");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();

        Console.WriteLine("Pytanie 6. Jak nazywa się ulubiona dziewczynka tatusia (chodzi o twoje dziewczynki :)");
        string op6 = Console.ReadLine();

        if (op6 == "braworka")
        {
            Console.WriteLine("Dokładnie tak");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Wszystkie kocham tak samo... ale najbardziej lubię braworkę. Szkoda tego paska");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();

        Console.WriteLine("Pytanie 7. Dobra czas na pytania tak lub nie. Czy kiedyś ukradłem coś ze sklepu?");
        string op7 = Console.ReadLine();

        if(op7 == "tak")
        {
            Console.WriteLine("Niestety tak :(. Jeśli zgadniesz co to bylo to wygrasz pasek. Podpowiem ci, że miałem wtedy 6 lat a rzecz kosztowala kilka groszy.");
            string op7d = Console.ReadLine();
                if (op7d == "cukierka")
            {
                Console.WriteLine("No niezle... Zasłużyłaś na ten pasek");
                ++paski;
                Console.WriteLine($"Pozostało pasków:{paski}");
            }
        }
        else
        {
            Console.WriteLine("Tak. Ale to był tylko 1 cukierek. RIP pasek");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();

        Console.WriteLine("Pytanie 8. Czy lubię pić rum?");
        string op8 = Console.ReadLine();    

        if(op8 == "tak")
        {
            Console.WriteLine("Lubię chociaż nie jest to coś co mogłbym pić często");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Lubię. Rzadko piję ale lubię. Tak jak ja opróżniam drineczka tak tobie odpada pasek");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();
        Console.WriteLine(" Trzymasz się jeszcze? Mam nadzieję że tak");
        Console.WriteLine();

        Console.WriteLine("Pytanie 9. Czy kiedykolwiek spróbowałem jakiegokolwiek narkotyku?");
        string op9 = Console.ReadLine();

        if(op9 == "nie")
        {
            Console.WriteLine("No jasne że nie. Pamiętaj dziecko że narkotyki to zło");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Serio? Tego się nie spodziewałem. Tracisz pasek za brak wiary");
            --paski;
            Console.WriteLine($"Pozostało pasków:{paski}");
        }

        Console.WriteLine();

        Console.WriteLine("Ostatnie pytanie. Kochasz mnie?");
        string op10 = Console.ReadLine();

        if(op10 == "Tak")
        {
            Console.WriteLine("To bardzo się cieszę. Wiedz że dla mnie jesteś całym swiatem i jestem z tobą niesamowicie szczęśliwy.\nJeśli podczasa testu straciłaś jakiś pasek to przyjdz do mnie z liściem a coś na to poradzimy");
            Console.WriteLine($"Pozostało pasków:{paski}");
        }
        else
        {
            Console.WriteLine("Nie kłam... Dam ci jeszcze 1 szanse. Kochasz mnie?");
            string op10d = Console.ReadLine();

            if(op10d == "tak")
            {
                Console.WriteLine("To bardzo się cieszę. Wiedz że dla mnie jesteś całym swiatem i jestem z tobą niesamowicie szczęśliwy.\nJeśli podczasa testu straciłaś jakiś pasek to przyjdz do mnie z liściem a coś na to poradzimy");
                Console.WriteLine($"Pozostało pasków:{paski}");
            }
        }

        Console.WriteLine();

        Console.WriteLine("To by było na tyle kotku. Mam nadzieję że czegoś się dowiedziałąś i że dobrze się bawiłaś. Wyslij mi screen wyniku");
        Console.WriteLine($"Pozostało pasków:{paski}");






















    }
}