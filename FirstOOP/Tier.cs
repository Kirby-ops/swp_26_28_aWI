using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Tier
    {
        string _lebensraum;
        public string Lebensraum 
        { 
            get { return _lebensraum; } 
            set { _lebensraum = value; } 
        }

        public void Essen()
        {
            Console.WriteLine("Das Tier frisst.");
        }

    }
}
