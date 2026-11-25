import { PKW, LKW, Fahrrad } from "./Fahrzeug.ts";
import { Reifen } from "./Reifen.ts";
import { Garage } from "./garage.ts";

var myBWMWith4Doors = new PKW("BMW", 4, "Benzin");
console.log(myBWMWith4Doors.Fahrzeugtyp);
console.log(myBWMWith4Doors.AnzahlTueren);
var myBWMWith2Doors = new PKW("BMW", 2, "Benzin");
console.log(myBWMWith2Doors.Fahrzeugtyp);
console.log(myBWMWith2Doors.AnzahlTueren);
var myMANWith2Doors = new LKW("MAN", 2, "Diesel");
console.log(myMANWith2Doors.Fahrzeugtyp);
console.log(myMANWith2Doors.AnzahlTueren);

var myFahrrad = new Fahrrad("Fahrrad", "Mountainbike", 21);
console.log(myFahrrad.Fahrzeugtyp);
console.log(myFahrrad.AnzahlGaenge);

var myGarage = new Garage();
myGarage.addFahrzeug(myBWMWith4Doors);
myGarage.addFahrzeug(myBWMWith2Doors);
myGarage.addFahrzeug(myMANWith2Doors);
myGarage.addFahrzeug(myFahrrad);
console.log(`Anzahl Fahrzeuge in der Garage: ${myGarage.anzahlFahrzeuge()} davon Autos: ${myGarage.anzahlAutos}`);

myGarage.addReifen(new Reifen("Michelin", 16, "Sommerreifen"));
myGarage.addReifen(new Reifen("Continental", 17, "Winterreifen"));

console.log(`Verkaufbare Dinge in der Garage: ${myGarage.verkaufbareDinge.length}`);