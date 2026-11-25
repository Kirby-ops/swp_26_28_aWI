import type { IVerkaufsartikel } from "./IVerkaufsartikel.ts";
import { Fahrzeug, Auto } from "./Fahrzeug.ts";
import { Reifen } from "./Reifen.ts";

export class Garage {
    public verkaufbareDinge: IVerkaufsartikel[] = [];

    public addFahrzeug(fahrzeug: Fahrzeug): void {
        this.verkaufbareDinge.push(fahrzeug);
    }

    public getFahrzeuge(): Fahrzeug[] {
        return this.verkaufbareDinge.filter(item => item instanceof Fahrzeug) as Fahrzeug[];
    }

    public addReifen(reifen: Reifen): void {
        this.verkaufbareDinge.push(reifen);
    }

    public getReifen(): Reifen[] {
        return this.verkaufbareDinge.filter(item => item instanceof Reifen) as Reifen[];
    }

    public anzahlFahrzeuge(): number {
        return this.verkaufbareDinge.filter(item => item instanceof Fahrzeug).length;
    }

    get anzahlAutos(): number {
        return this.verkaufbareDinge.filter(item => item instanceof Auto).length;
    }
}