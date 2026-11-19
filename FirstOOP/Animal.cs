using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    class Animal // Basisklasse für Tiere
    {
        private string _name = "";
        private string _colour = "";
        private DateTime _birthDate;

        public string Name
        {
            get
            {
                string myLocalVar = "myLocalVar";
                return _name;
            }
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

        public DateTime BirthDate
        {
            get { return _birthDate; }
        }

        // Alter berechnen
        public void GetAge()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(
                today.Year - _birthDate.Year
            );
        }

        // Konstruktor
        public Animal(string name, string colour, DateTime birthDate)
        {
            string myLocalVar = "myLocalVar";

            _name = name;
            _colour = colour;
            _birthDate = birthDate;
        }
    }
}
