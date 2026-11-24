using System;
using System.Collections.Generic;
using System.Text;


namespace FirstOOP
{
    class Cat : Animal
    {
        public Cat(string name, string colour)
            : base(name, colour)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau");
        }

        public override void MakeSound(int duration)
        {
            for (int i = 0; i < duration; i++)
            {
                Console.WriteLine("Miau");
            }
        }
    }
}

