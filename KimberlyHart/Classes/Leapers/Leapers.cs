using System;
using System.Collections.Generic;

using System.Text;

namespace KimberlyHart.Classes.Leapers
{
    public class Leapers
    {
        public string Name { get; set; }
        public Events.Events CurrentEvent { get; set; }
        public int LeaperCash { get; set; }
        public Wallet.Wallet LeaperBudget { get; set; }

        public List<Events.Events> PastEvents { get; set; }

        public Leapers(string name)
        {
            Name = name;
            LeaperCash = 1000;
        }

        public void Jump(Hosts.Hosts whatHost, Events.Events whatEvent)
        {
            if (whatHost.Year == whatEvent.Year)
            {
                Console.WriteLine($"{Name} You are Jumping into {whatHost.Name}, The year is {whatEvent.Year}");
                var budgetCheck = new Wallet.Wallet(this, whatEvent.Year).CheckMoneyToJump(5);

            }
        }
    }

}
