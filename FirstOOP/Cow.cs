using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    

    class Cow : Animal // Abgeleitete Klasse
    {
        public Cow(string name, string colour, DateTime birthDate)
            : base(name, colour, birthDate)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Muuuuh");
        }
    }

    

}
