
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
        int Quadrat = 0;
        Quadrat = zahl * zahl;
        Console.WriteLine("Die Quadrat Fläche ist: " + Quadrat);
        break;

    case 2:
        double Wurzel = Math.Sqrt(zahl);
        Console.WriteLine("Die Wurzel ist: " + Wurzel);
        break;

    case 3:
        double Fakultät = 1;
        for (int i = 1; i <= zahl; i++)
        {
            Fakultät *= i;
        }
        Console.WriteLine("Die Fakultät ist: " + Fakultät);
        break;

    default:
        Console.WriteLine("Ungültige Eingabe");
        break;
}
