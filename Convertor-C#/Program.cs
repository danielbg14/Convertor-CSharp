// KONVERTOR NA VALUTI
// BGN -> USD/EUR
// USD/EUR -> BGN

Console.WriteLine("Zdrasti 6matka");
Console.WriteLine("Toz chudo e konvertor na valuta");
Console.WriteLine("");
Console.WriteLine("Napishi valutata za convertirane:");
Console.WriteLine("1. BGN -> EUR");
Console.WriteLine("2. BGN -> USD");
Console.WriteLine("3. EUR -> BGN");
Console.WriteLine("4. USD -> BGN");
Console.WriteLine("Tvoqt izbor e: ");

int typed = int.Parse(Console.ReadLine());
Console.WriteLine($"Ti izbra {typed}");
Console.WriteLine("");
if (typed > 4)
{
    Console.WriteLine("Shmatka, kazah ti mejdu 1 i 4, tuuuuup!");
    return;
}
else if (typed < 1)
{
    Console.WriteLine("Shmatka, kazah ti mejdu 1 i 4, tuuuuup!");
    return;
}
Console.WriteLine("Napishi purvoto chislo: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

// SUMA NA VALUTI
double eurvalue1 = 0.51;
double eurvalue2 = 1.96;
double usdvalue1 = 0.55;
double usdvalue2 = 1.80;
double bgnvalue = 0.51;

double bgneur = number1 * eurvalue1;
double bgnusd = number1 * usdvalue1;
double eurbgn = number1 * eurvalue2;
double usdbgn = number1 * usdvalue2;

if (typed == 1)
{
    Console.WriteLine($"{number1} leva convertnati kum euro e ravno na {bgneur} euro");
}
else if (typed == 2)
{
    Console.WriteLine($"{number1} leva convertnati kum euro e ravno na {bgnusd} dolara");
}
else if (typed == 3)
{
    Console.WriteLine($"{number1} euro convertnati kum leva e ravno na {eurbgn} leva");
}
else if (typed == 4)
{
    Console.WriteLine($"{number1} dolara convertnati kum leva e ravno na {usdbgn} leva");
}