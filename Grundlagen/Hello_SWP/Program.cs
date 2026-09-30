Console.WriteLine("Hello, SWP!");
string HelloSWP = Console.ReadLine();
Console.WriteLine(HelloSWP);
Console.WriteLine("push any button to exit...");
Console.ReadKey();
/*
==========================================================================
DATENTYPEN IN C#
==========================================================================
 
--------------------------------------------------------------------------
A) ELEMENTARE DATENTYPEN (einfache Wertetypen)
--------------------------------------------------------------------------
 
Ganzzahlen
----------
sbyte: 8 Bit, -128 bis 127
byte: 8 Bit, 0 bis 255
short: 16 Bit, -32.768 bis 32.767
ushort: 16 Bit, 0 bis 65.535
int: 32 Bit, ca. -2,1 Mrd. bis 2,1 Mrd.
uint: 32 Bit, 0 bis ca. 4,29 Mrd.
long: 64 Bit, ca. -9,2 * 10^18 bis 9,2 * 10^18
ulong: 64 Bit, 0 bis ca. 1,8 * 10^19
nint: 32/64 Bit (plattformabhaengig, mit Vorzeichen)
nuint: 32/64 Bit (plattformabhaengig, ohne Vorzeichen)

 
Gleitkomma- und Dezimalzahlen
-----------------------------
float: 32 Bit, ca. 6-9 Stellen     Suffix f (36.6f)
double: 64 Bit, ca. 15-17 Stellen   Standard fuer Kommazahlen
decimal: 128 Bit, 28-29 Stellen       Suffix m (19.99m), ideal fuer Geld

 
Sonstige elementare Typen
-------------------------
bool: true oder false
char: ein Unicode-Zeichen (16 Bit), z. B. 'A'

--------------------------------------------------------------------------
B) NICHT-ELEMENTARE DATENTYPEN (zusammengesetzte Typen)
--------------------------------------------------------------------------
 
Eingebaute Referenztypen
------------------------
string   Zeichenkette (unveraenderlich), z. B. "Hallo"
object   Basistyp aller Typen
dynamic  Typpruefung erst zur Laufzeit
Arrays   feste Anzahl gleicher Elemente: int[], string[,], int[][]
 
Selbst definierbare Typen
-------------------------
class          Referenztyp   Objekt mit Feldern, Eigenschaften, Methoden
record         Referenztyp   Klasse mit Wertvergleich (record class)
struct         Wertetyp      leichtgewichtiger Verbund von Feldern
record struct  Wertetyp      Struct mit Wertvergleich
enum           Wertetyp      Aufzaehlung benannter Konstanten
interface      Referenztyp   Vertrag ohne Implementierung
delegate       Referenztyp   typsicherer Verweis auf eine Methode
Tupel          Wertetyp      (int, string), ValueTuple
Nullable<T>    Wertetyp      T?, Wertetyp der auch null sein darf, z. B. int?
 
Typen aus der Standardbibliothek
--------------------------------
Datum/Zeit:   DateTime, DateOnly, TimeOnly, TimeSpan, DateTimeOffset
Strukturen:   Guid, Index, Range
Sammlungen:   List<T>              dynamische Liste
               Dictionary<K,V>      Schluessel-Wert-Paare
               HashSet<T>           Menge ohne Duplikate
               Queue<T>             Warteschlange (FIFO)
               Stack<T>             Stapel (LIFO)
               LinkedList<T>        doppelt verkettete Liste
               SortedList<K,V>      sortierte Liste
               SortedDictionary<K,V> sortiertes Dictionary
Weitere:      StringBuilder        veraenderbare Zeichenketten
               Action, Func<>, Predicate<>   vordefinierte Delegates
               Exception und Ableitungen
               Task, Task<T>        asynchrone Abloeufe
               Span<T>              speichereffizienter Ausschnitt
 
Zeigertypen (nur im unsafe-Kontext)
-----------------------------------
int*, char*, ...   selten gebraucht
 
 
--------------------------------------------------------------------------
C) MERKREGELN
--------------------------------------------------------------------------
- Wertetypen werden beim Zuweisen kopiert.
- Referenztypen teilen sich beim Zuweisen dasselbe Objekt.
- Standard: int (Ganzzahl), double (Kommazahl), decimal (Geld).
- string ist ein Referenztyp, verhaelt sich aber beim Vergleichen
   und Zuweisen wie ein Wertetyp.
- var laesst den Compiler den Typ ableiten; der Typ bleibt trotzdem fest.
*/