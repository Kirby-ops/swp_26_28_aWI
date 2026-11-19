using FirstOOP;

Cow myKuh = new Cow("Kuh1", "Weiß");

myKuh.MakeSound();
myKuh.MakeSound(3);

Cat myCat = new Cat("Frieda", "orange");

myCat.MakeSound();
myCat.MakeSound(2);

var myAnimals = new List<Animal>();

myAnimals.Add(myKuh);
myAnimals.Add(myCat);


