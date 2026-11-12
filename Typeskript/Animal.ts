
class animal { //Basisklasse für Tiere

    private _name: string = "";
    private _colour: string = "";
    private _birthDate: Date;

    public get Name(): string {
        let myLocalVar = "myLocalVar";
        return this._name
    }

    public get Colour() { return this._colour}
    public set Colour(value: string) {this._colour = value;}
    public makeSound() {console.log("Animal sound");}

    public get BirthDate(): Date {
    return this._birthDate;
    }

    // Advanced: Alter berechnen
    public getAge(){
        let today = new Date();
        console.log(today.getFullYear() - this._birthDate.getFullYear());
    }

    constructor(name: string, colour: string, birthDate: Date) {
        let myLocalVar = "myLocalVar";
        this._name = name;
        this._colour = colour;
        this._birthDate = birthDate;
    }
}

class Cow extends animal { // abgeleitete Klasse von animal

   public makeSound() {
       console.log("Muuuuh");
   }
}

class Cat extends animal {

    public makeSound() {
        console.log("Miau");
    }
}

let myAnimal = new animal("Tier1", "braun", new Date("2020-05-10"));
myAnimal.makeSound();

let myKuh = new Cow("Kuh1", "Weiß", new Date("2018-03-15"));
myKuh.makeSound();

let myKuh1 = new Cow("Kuh2", "schwarz", new Date("2021-07-20"));

let myKuh2 = myKuh;

let myCat = new Cat("Frieda", "orange", new Date("2022-01-10"));
myCat.makeSound();

console.log(myKuh2 == myKuh);
console.log(myKuh.Name);

myKuh.Colour = "braun";
console.log(myKuh2.Colour);

console.log(myKuh1.BirthDate);

// Alter ausgeben
myKuh.getAge();
myCat.getAge();
