using System;
using System.Collections.Generic;
using System.Text;



namespace FirstOOP
{
    class Cow : Animal
    {
        public Cow(string name, string colour)
            : base(name, colour)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Muuuuh");
        }

        public override void MakeSound(int duration)
        {
            for (int i = 0; i < duration; i++)
            {
                Console.WriteLine("Muuuuh");
            }
        }
    }
}
