// Console.WriteLine("Hello,Warsztacie Programisty!");
// Console.WriteLine("Tymek");
// Console.WriteLine("Informatka");
// Console.Write("Chce sie nauczyc programowac");

using System.Runtime.CompilerServices;

// string imie ="Tymek";
// string wiek = "18";
// string gra = "Nba 2k";
// Console.WriteLine("\t\t\"WIZYTOWKA\"\t\t");
// Console.WriteLine($"imie:{imie}");
// Console.WriteLine($"wiek:{wiek}");
// Console.WriteLine($"gra:{gra}");Tymek

// Console.Write("Podaj swoj wiek:18 ");
// string wpisanyWiek = Console.ReadLine()!;

// Console.WriteLine("Jaka jest liczba kilometrow do celu?");
// int  liczbaKilometrow = int.Parse( Console.ReadLine()!);
// Console.WriteLine("Jaka jest liczba kilometrow pokonywana kazdego dnia?");
// int liczbaKilometrowNaDzien = int.Parse(Console.ReadLine()!);
// int liczbaDni = liczbaKilometrow / liczbaKilometrowNaDzien;
// Console.WriteLine($"Liczba dni potrzebna do pokonania {liczbaKilometrow} kilometrow wynosi: {liczbaDni} dni");30

// Console.WriteLine("Ile mam lacznie monet?");
// int zlotych = 5;
// int srebrnych = 10;
// int miedzianych = 20;
// int jednaZlota = 100*miedzianych;
// int jednaSrebrna = 10*miedzianych;
// Console.WriteLine("Ile mam lacznie monet zlotych?");
// int liczbaMonetWyrazonychWzlotych = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile mam lacznie monet srebrnych?");
// int liczbaMonetWyrazonychWsrebrnych = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile mam lacznie monet miedzianych?");
// int liczbaMonetWyrazonychWmiedzianych = int.Parse(Console.ReadLine());

// int wynik = liczbaMonetWyrazonychWzlotych * 100 + liczbaMonetWyrazonychWsrebrnych * 10 + liczbaMonetWyrazonychWmiedzianych;
// Console.WriteLine($"Wartosc wynosi: {wynik}");

Console.WriteLine("==Ekwipunek==");
Console.WriteLine("Podaj imie bohatera");
string imie =(Console.ReadLine());
Console.WriteLine("Podaj symbol bohatera");
char symbol =char.Parse(Console.ReadLine());
Console.WriteLine("Podaj poziom doswiadczenia");
int poziom =int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe sztuk zlota");
int zloto =int.Parse(Console.ReadLine());
Console.WriteLine("Podaj wage plecaka w kilogramach");
double waga =double.Parse(Console.ReadLine());
Console.WriteLine("Podaj informacje czy bohater ma mape");
bool mapa =bool.Parse(Console.ReadLine());
Console.WriteLine("==Ekwipunek==");
Console.WriteLine($"imie :{imie}");
Console.WriteLine($"symbol :{symbol}");
Console.WriteLine($"poziom :{poziom}");
Console.WriteLine($"zloto :{zloto}");
Console.WriteLine($"waga :{waga}");
 waga = waga +2;
Console.WriteLine($"waga :{waga}");
