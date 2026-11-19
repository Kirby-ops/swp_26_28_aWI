using FirstOOP;

Animal myAnimal = new Animal(
            "Tier1", "braun", new DateTime(2020, 5, 10)
        );

myAnimal.MakeSound();

Cow myKuh = new Cow(
    "Kuh1", "Weiß", new DateTime(2018, 3, 15)
);

myKuh.MakeSound();

Cow myKuh1 = new Cow(
    "Kuh2", "schwarz", new DateTime(2021, 7, 20)
);

Cow myKuh2 = myKuh;

Cat myCat = new Cat(
    "Frieda", "orange", new DateTime(2022, 1, 10)
);

myCat.MakeSound();

Console.WriteLine(myKuh2 == myKuh);

Console.WriteLine(myKuh.Name);

myKuh.Colour = "braun";

Console.WriteLine(myKuh2.Colour);

Console.WriteLine(myKuh1.BirthDate);

// Alter ausgeben
myKuh.GetAge();
myCat.GetAge();