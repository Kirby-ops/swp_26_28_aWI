using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Kuh
    {
        string _name; // private field for the name of the Kuh
        string _colour; // private field for the colour of the Kuh

        public string Name // public property to get the name of the Kuh
        { 
            get { return _name; } // Getter for the name
            set { _name = value; } // Setter for the name
        } 
        public string Colour // public property to get the colour of the Kuh
        { 
            get { return _colour; } 
            set { _colour = value; }
        } 

        //Cionstructor for the class Kuh
        public Kuh(string name, string colour) //impliziter Rückgabewert ist ein Objekt der Klasse Kuh
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidDataException();
            _name = name;
            _colour = colour;
        }

    }
}
