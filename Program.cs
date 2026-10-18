using System.IO.Compression;

Console.WriteLine("Hello, World!");
Console.WriteLine ("Nazywam się Igor");
Console.WriteLine("Studiuje w PJATK");
int a = 6;
float b = 6.5f;
double c = 3.3d;
string d = "artur";
char e = 'a';
string imie = "Igor";
int wiek = 22;
string miasto = "Gdańsk";

Console.WriteLine("Podaj swoje imię: ");
Console.WriteLine($"Imię: -{d}-");
Console.WriteLine("Jaki jest twój ulubiony kolor: ");
string x = Console.ReadLine();
Console.WriteLine($"Kolor: -{x}-");
Console.WriteLine("podaj wiek ");
string wiekString = Console.ReadLine()!;
int wiekInt = int.Parse(wiekString);
Console.WriteLine("Twój wiek za pięć lat: "+(wiekInt+5));
Console.WriteLine("Twój wiek: "+wiekInt);
Console.Write("Ile kilometrów łącznie ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Ile kilometrów dziennie: ");
int speed = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Podróż będzie trwać:{length/speed}dni");
Console.WriteLine("Podaj liczbę złotych monet: ");
int goldCoins = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbę srebrnych monet: ");
int silverCoins = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbę miedzianych monet: ");
int copperCoins = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Posiadasz {goldCoins * 100 + silverCoins * 10 + copperCoins} miedzianych monet.");
Console.WriteLine("Ile mikstur chcesz stworzyć: ");
int mikstury = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Potrzebujesz: {mikstury * 3} kryształów i {mikstury * 2} ziół");
Console.WriteLine("Podaj liczbę monet: ");
int monety = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbę bohaterów: ");
int bohaterowie = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Każdy dostanie {monety/bohaterowie} monet. ");
Console.WriteLine($"Po równym podziale zostanie {monety % bohaterowie} monet." );




