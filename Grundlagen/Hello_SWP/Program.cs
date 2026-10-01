Console.WriteLine("Hello, SWP!");
string HelloSWP = Console.ReadLine();

if (bool.TryParse(eingabe, out _))
    Console.WriteLine("Bool");
else if (int.TryParse(eingabe, out _))
    Console.WriteLine("Integer");
else if (double.TryParse(eingabe, out _))
    Console.WriteLine("Double");
else
    Console.WriteLine("String");

Console.WriteLine("push any button to exit...");
Console.ReadKey();
