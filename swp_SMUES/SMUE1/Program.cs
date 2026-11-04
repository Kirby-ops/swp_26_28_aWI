using System.Numerics;

Console.WriteLine("Geben Sie eine ganze Zahl ein:");
string eingabe = Console.ReadLine();
int zahl;

if (int.TryParse(eingabe, out zahl))
{
    Console.WriteLine("Sie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?");
    Console.WriteLine(" (1)... Addition\n (2)... Multiplikation\n (3)... Division\n (4)... Fakultät\n (5)... Wurzelziehen");

    int operation;
    int.TryParse(Console.ReadLine(), out operation);

    int zweiteZahl = 0;

    if (operation >= 1 && operation <= 3)
    {
        Console.WriteLine("Geben Sie die zweite ganze Zahl ein:");
        int.TryParse(Console.ReadLine(), out zweiteZahl);
    }

    switch (operation)
    {
        case 1:
            Console.WriteLine("Die Summe ist: " + (zahl + zweiteZahl));
            break;

        case 2:
            Console.WriteLine("Das Produkt ist: " + (zahl * zweiteZahl));
            break;

        case 3:
                Console.WriteLine("Der Quotient ist: " + (double)zahl / zweiteZahl);
            break;

        case 4:
                Console.WriteLine("Die Fakultät ist: " + Fakultaet(zahl));
            break;

        case 5:
                Console.WriteLine("Die Wurzel ist: " + Wurzel(zahl));
            break;

        default:
            Console.WriteLine("Ungültige Eingabe");
            break;
    }
}

if(!int.TryParse(eingabe, out zahl))
{
    Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
    Console.WriteLine(" (1)... Alle Selbstlaute (a,e,i,o,u) entfernen\n (2)... Die Zeichenkette umdrehen\n (3)... Die Anzahl an Zeichen ausgeben");

    int operation;
    int.TryParse(Console.ReadLine(), out operation);

    switch (operation)
    {
        case 1:
            Console.WriteLine("Ohne Selbstlaute: " + OhneSelbstlaute(eingabe));
            break;

        case 2:
            Console.WriteLine("Umgedreht: " + Umdrehen(eingabe));
            break;

        case 3:
            Console.WriteLine("Anzahl der Zeichen: " + eingabe.Length);
            break;

        default:
            Console.WriteLine("Ungültige Eingabe");
            break;
    }
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

static string OhneSelbstlaute(string eingabe)
{
    string ergebnis = "";
    for (int i = 0; i < eingabe.Length; i++)
    {
        if ("aeiouAEIOU".IndexOf(eingabe[i]) < 0)
        {
            ergebnis += eingabe[i];
        }
    }
    return ergebnis;
}

static string Umdrehen(string eingabe)
{
    string ergebnis = "";
    for (int i = eingabe.Length - 1; i >= 0; i--)
    {
        ergebnis += eingabe[i];
    }
    return ergebnis;
}