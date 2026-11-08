int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool ucieczka = false;

bool aktywne =  zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0;

while (aktywne)
{
        Console.WriteLine();
        Console.WriteLine($"=== TURA {numerTury} ===");
        Console.WriteLine($"Twoje zdrowie: {zdrowieBohatera} | Zdrowie przeciwnika: {zdrowiePrzeciwnika}");
        Console.WriteLine($"Mikstury: {liczbaMikstur}");
        Console.WriteLine("1 - Atak");
        Console.WriteLine("2 - Mikstura");
        Console.WriteLine("3 - ucieczka");
        Console.Write("Akcja: ");

        string akcja = Console.ReadLine()!;

switch (akcja)
        {
            case "1":
            if (!zdrowiePrzeciwnika < 11)
                        {
                                
                Console.WriteLine("Trafiłeś przeciwnika, zadając mu 12 punktów obrażeń.");
                Console.WriteLine("Przeciwnik trafia Cię, zadając 7 punktów obrażeń.");
                              zdrowieBohatera -= 7;
                                zdrowiePrzeciwnika -= 12;

                        } else
                        {
                                 zdrowiePrzeciwnika -= 12;
                        }
            
                Console.WriteLine("Trafiłeś przeciwnika, zadając mu 12 punktów obrażeń.");
                Console.WriteLine("Przeciwnik trafia Cię, zadając 7 punktów obrażeń.");
                numerTury++;

                break;
            case "2":
                if (liczbaMikstur <= 0)
                {
                Console.WriteLine("Nie masz już mikstur!");
                break;
                } else
                {
                        liczbaMikstur--;
                        Console.WriteLine("Zdobywasz 15 punktów życia, tracisz 1 miksturę.");
                        Console.WriteLine("Przeciwnik trafia Cię, zadając 7 punktów obrażeń.");
                        zdrowieBohatera += 15;
                        zdrowieBohatera -= 7;
                        numerTury++;

                }
                break;
            case "3":
                Console.WriteLine("Ucieczka.");
                aktywne = false;
                break;
            default:
                Console.WriteLine("Nieznana akcja.");
                break;
        }



        

    if (zdrowiePrzeciwnika <= 0)
    {
        Console.WriteLine("Wygrałeś walkę!");
        break;
    }
}