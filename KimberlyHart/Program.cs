using System;
using System.Collections.Generic;
using KimberlyHart.Classes.Events;
using KimberlyHart.Classes.Hosts;
using KimberlyHart.Classes.Leapers;
using KimberlyHart.Classes.NamesYears;

namespace KimberlyHart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stuff I did with leaper was just to test Only thing that should break anything in right now is..
            // re-naming the Leaper.Name or Leaper.Wallet
            // Anything in CreateHosts.cs // Host.cs // NameYear.cs is fragile.
            // Tried to give a decent example of what I put together here.
            // wallet/costs aren't completely functional right now, but you need > then cost per day * number of days
            var myLeaper = new Leaper("Keith", 500);
            var name = myLeaper.Name;
            var wallet = myLeaper.Wallet;
            var hostList = new CreateHosts();
            var year = 1999;

            Console.WriteLine($"NAME: {name}");
            Console.WriteLine($"YOUR YEAR {year}");
            Console.WriteLine($"YOUR WALLET {wallet}");

            // list // year + wallet conditional
            var getAllJumpable = hostList.GetAllJumpableHosts(year, wallet);
            Console.WriteLine($"HOSTS IN YOUR YEAR THAT YOU CAN AFFORD TO JUMP TO");
            hostList.DisplayMenu(getAllJumpable);


            Console.WriteLine("ENTER ID OF HOST TO JUMP TO");
            var resp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE AMOUNT OF DAYS TO STAY");
            var daysResp = Convert.ToInt32(Console.ReadLine());

            // void // Changes actual host // This is what we should use to jump to a host
            hostList.JumpToHost(year, wallet, daysResp, resp, myLeaper);
        }
    }
}
