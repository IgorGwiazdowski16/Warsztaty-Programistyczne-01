string imie = "Miruna";
char symbol = '@';
int poziom = 3;
int zloto = 40;
double waga = 8;
bool maMape = false;

Console.WriteLine("===EKWIPUNEK===");
Console.WriteLine($"Imie: {imie}");
Console.WriteLine($"Symbol: {symbol}");
Console.WriteLine($"Poziom: {poziom}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"Waga: {waga}");
Console.WriteLine($"Ma mape: {maMape}");

int punktyDoswiadczenia = 100;
int liczbaZlota = 50;
int poziomTreningowy = 1;

Console.WriteLine($"Punkty doświadczenia: {punktyDoswiadczenia + 25}");
Console.WriteLine($"Podwojone punky doświadczenia: {(punktyDoswiadczenia + 25) * 2}");
Console.WriteLine($"Liczba złota po wejściu na arenę: {liczbaZlota - 8}");
Console.WriteLine($"Złoto po nagrodzie: {liczbaZlota - 8 + 15}");
Console.WriteLine($"Numer treningu: {poziomTreningowy + 1}");

Console.Write("Liczba racji żywnościowych: ");
int iloscRacji = int.Parse(Console.ReadLine()!);
Console.Write("Liczba członków drużyny: ");
int liczbaCzlonkow = int.Parse(Console.ReadLine()!);
Console.Write("Liczba dni wyprawy: ");
int dniWyprawy = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Każdy członek otrzyma {iloscRacji / liczbaCzlonkow} racji żywnościowych.");
Console.WriteLine($"Po równym podziale zostanie {iloscRacji % liczbaCzlonkow} racji.");
Console.WriteLine($"Dziennie przypadną {iloscRacji / dniWyprawy} racje na całą drużynę.");
Console.WriteLine($"Dziennie średnio przypadnie {(iloscRacji / dniWyprawy) / liczbaCzlonkow} racji na jedną osobę.");


Console.Write("Punkty życia: ");
int zycie = int.Parse(Console.ReadLine()!);
Console.Write("Liczba mikstur: ");
int mikstury = int.Parse(Console.ReadLine()!);
Console.Write("Ma mapę: ");
bool haveMap = bool.Parse(Console.ReadLine()!);
bool maKlucz = false;
Console.Write("Ma klucz: ");
bool haveKlucz = bool.Parse(Console.ReadLine()!);
bool zyje = zycie > 0;
bool maPelneZdrowie = zycie == 100;
bool maZaopatrzenie = mikstury > 0;
bool maPrzedmiotNawigacyjny = maMape && maKlucz;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maMape && maKlucz;
Console.WriteLine($"Żyje: {zycie > 0}");
Console.WriteLine($"Ma pełne zdrowie: {zycie = 100}");
Console.WriteLine($"Wymaga leczenia:  {zycie = 100}");
Console.WriteLine($"Ma zaopatrzenie: {mikstury > 1}");
Console.WriteLine($"Ma klucz lub mapę: {}");
















