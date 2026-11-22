using System.Collections.Generic;

int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
int suma = 0;
int liczbaTurZDobrymWynikiem = 0;
// Wyświetlanie wyników i obliczanie sumy
for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");

    suma += zlotoWTurach[i];

    if (zlotoWTurach[i] >= 10)
    {
        liczbaTurZDobrymWynikiem++;
    }
}
Console.WriteLine("----------");
Console.WriteLine("Podsumowanie");
Console.WriteLine($"Łącznie: {suma} ");
Console.WriteLine($"Średnio na turę: {suma/5}");
Console.WriteLine("----------");
Console.Write("Podaj imię bohatera: ");
string imieBohatera = Console.ReadLine();
if (string.IsNullOrWhiteSpace(imieBohatera))
{
    imieBohatera = "Bezimienny";
}

int punktyZycia = 80;
int maksymalneZdrowie = 100;
int zloto = 10;
int numerTury = 1;
int liczbaEksploracji = 0;
bool graDziala = true;
string powodZakonczenia = "";

const int pojemnoscPlecaka = 6;
const int maksymalnaLiczbaTur = 20;

string[] znaleziska =
{
    "Mikstura",
    "Klucz",
    "Pochodnia",
    "Zwój"
};
List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura"
};

List<string> historia = new List<string>();
int[] zlotoZdobyteWTurach = new int[maksymalnaLiczbaTur];
Console.WriteLine();
    Console.WriteLine("=== HELLO ADVENTURER 5.0 ===");
    Console.WriteLine($"Tura: {numerTury}");
    Console.WriteLine($"Bohater: {imieBohatera}");
    Console.WriteLine($"Zdrowie: {punktyZycia}/{maksymalneZdrowie} | Złoto: {zloto} | Plecak: {plecak.Count}/{pojemnoscPlecaka}");
    Console.WriteLine();
    Console.WriteLine("1 - Eksploruj loch");
    Console.WriteLine("2 - Pokaż plecak");
    Console.WriteLine("3 - Użyj przedmiotu");
    Console.WriteLine("4 - Dodaj znalezisko");
    Console.WriteLine("5 - Wyrzuć przedmiot");
    Console.WriteLine("6 - Pokaż historię");
    Console.WriteLine("7 - Pokaż statystyki wyprawy");
    Console.WriteLine("8 - Zakończ grę");
    Console.Write("Wybór: ");

    string wybor = Console.ReadLine();
    bool zuzytoTure = false;

switch (wybor)
{
        case "1":
            punktyZycia -= 8;
            if (punktyZycia < 0)
            {
                punktyZycia = 0;
            }

            int zdobyteZloto = 10;
            zloto += zdobyteZloto;
            liczbaEksploracji++;

            int indeksTury = numerTury - 1;
            if (indeksTury >= 0 && indeksTury < zlotoZdobyteWTurach.Length)
            {
                zlotoZdobyteWTurach[indeksTury] = zdobyteZloto;
            }

            historia.Add($"Tura {numerTury}: Eksploracja lochu (-8 PZ, +{zdobyteZloto} złota).");
            Console.WriteLine($"Przeszukano loch! Tracisz 8 punktów życia, ale znajdujesz {zdobyteZloto} sztuk złota.");
            zuzytoTure = true;
            break;
}





