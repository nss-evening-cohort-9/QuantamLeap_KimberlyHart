using System;
using System.Collections.Generic;
using System.Text;

namespace KimberlyHart.Classes.Leapers
{
    public class Leaper
    {
        public string Name { get; set; }
        public int Wallet { get; set; }

        public Leaper(string name, int wallet)
        {
            Name = name;
            Wallet = wallet;
        }

        public void LeapToHost()
        {

        }
    }
}
