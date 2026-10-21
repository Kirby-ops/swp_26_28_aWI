
using System.Numerics;

Console.WriteLine("Geben sie eine Natürliche Zahl ein:");
int zahl;
int.TryParse(Console.ReadLine(), out zahl);

Console.WriteLine("Bitte wählen sie eine Operation aus:");
Console.WriteLine(" (1)... Quadrat\n (2)... Wurzel\n (3)... Fakultät");

int operation;
int.TryParse(Console.ReadLine(), out operation);

switch (operation)
{
    case 1:
        Console.WriteLine("Die Quadrat Fläche ist: " + Quadrat(zahl));
        break;

    case 2:
        Console.WriteLine("Die Wurzel ist: " + Wurzel(zahl));
        break;

    case 3:
        Console.WriteLine("Die Fakultät ist: " + Fakultaet(zahl));
        break;

    default:
        Console.WriteLine("Ungültige Eingabe");
        break;
}

static int Quadrat(int zahl)
{
    return zahl * zahl;
}

static double Wurzel(int zahl)
{
    return Math.Sqrt(zahl);
}

static BigInteger Fakultaet(int zahl)
{
    BigInteger ergebnis = 1;
    for (int i = 1; i <= zahl; i++)
    {
        ergebnis *= i;
    }
    return ergebnis;
}