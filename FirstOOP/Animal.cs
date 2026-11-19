using System;
using System.Collections.Generic;
using System.Text;


namespace FirstOOP
{
    public class Animal
    {
        string _name = "";
        string _colour = "";

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }

        // Überladung 1: Ohne Parameter
        public virtual void MakeSound(int duration)
        {
            Console.WriteLine("Animal sound for " + duration + " seconds");
        }

        public Animal(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }
    }
}
