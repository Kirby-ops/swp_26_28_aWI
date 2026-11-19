using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    class Cat : Animal
    {
        public Cat(string name, string colour, DateTime birthDate)
            : base(name, colour, birthDate)
        {}

        public override void MakeSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
