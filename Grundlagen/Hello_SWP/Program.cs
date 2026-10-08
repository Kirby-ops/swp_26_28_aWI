Console.WriteLine("Hello, SWP!");
string input = Console.ReadLine();

string type = "String";

if (double.TryParse(input, out _))
    type = "Double";

if (int.TryParse(input, out _))
    type = "Integer";

if (bool.TryParse(input, out _))
    type = "Bool";

Console.WriteLine(type);

Console.WriteLine("Push any button to exit...");
Console.ReadKey();