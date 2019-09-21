using KimberlyHart.Classes.Leapers;
using KimberlyHart.Classes.NamesYears;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// This is just a way to call a list of randomly generated Host classes, Assigning a Name, Year they reside in, and a random age 18-80
// If we need to refer to a "Host" in another class we can use the structure from Host.cs, and loop over an instance of this.

// In Program
// var hosts = new CreateHosts();
// foreach (var host in hosts.HostList) { host.name//host.year//host.age }
// Could use that to check if an event, and host reside in the same year, and make a list of hosts that do.
namespace KimberlyHart.Classes.Hosts
{
    class CreateHosts
    {
        public List<Host> HostList = new List<Host>();
        public int YearOfEvent { get; set; }

        public CreateHosts()
        {
            var randomNum = new Random();
            var hosts = new NameYear().NamesWithYears;
            foreach(var host in hosts)
            {
                var age = randomNum.Next(18, 80);
                var id = randomNum.Next(0, 200);
                var newHost = new Host(host.Key, host.Value, age, id);
                HostList.Add(newHost);
            }
        }

        public List<Host> GetAllHostsByYear(int year)
        {
            var hosts = HostList;
            List<Host> HostsAvalible = new List<Host>();

            foreach(var host in hosts)
            {
                var hostYear = host.Year;
                if(year == hostYear)
                {
                    HostsAvalible.Add(host);
                }
            }
            return HostsAvalible;
        }

        public List<Host> GetAllJumpableHosts(int year, int cashOnHand)
        {
            var checkYear = GetAllHostsByYear(year);
            var returningHosts = new List<Host>();
            foreach(var host in checkYear)
            {
                if(host.BeingUsed == false && cashOnHand >= host.CostPerDay)
                    {
                        returningHosts.Add(host);
                    }
            }
            return returningHosts;
        }

        public void JumpToHost(int year, int cashOnHand, int amountOfDays, int id, Leaper leaper)
        {
            var checkIfJumpable = GetAllJumpableHosts(year, cashOnHand);
            foreach(var host in checkIfJumpable)
            {
                var selectedHost = host;
                var name = selectedHost.Name;
                var age = selectedHost.Age;
                var time = selectedHost.Year;
                var price = selectedHost.CostPerDay * amountOfDays;
                if (cashOnHand < price)
                {
                    Console.WriteLine($"Sorry {leaper.Name} you only have {leaper.Wallet} in order to jump to {name} for {amountOfDays} days");
                    Console.WriteLine($"You would need {price}...");
                    break;
                }
                if (cashOnHand >= price && host.MyId == id)
                {
                    selectedHost.BeingUsed = true;
                    selectedHost.UsedBy = leaper;
                    selectedHost.PastUsers.Add(leaper);
                    leaper.Wallet -= price;
                    Console.WriteLine();
                    Console.WriteLine($"Congrats {leaper.Name}! You have Successfully Jumped to {name}!");
                    Console.WriteLine();
                    Console.WriteLine($"{name} is {age} years old, and lives in {time}");
                    Console.WriteLine();
                    Console.WriteLine($"This leap has cost you ${price}, you now have ${leaper.Wallet} left");
                    Console.WriteLine();
                }
            }

        }

        public void DisplayMenu(List<Host> hostList)
        {
            foreach (var host in hostList)
            {
                Console.WriteLine();
                Console.WriteLine();
                    Console.WriteLine($"HOST NAME:{host.Name}");
                Console.WriteLine();
                    Console.WriteLine($"HOST YEAR: {host.Year}");
                Console.WriteLine();
                    Console.WriteLine($"HOST AGE: {host.Age}");
                Console.WriteLine();
                    Console.WriteLine($"HOST COST PER DAY: {host.CostPerDay}");
                Console.WriteLine();
                    Console.WriteLine($"HOST ID: {host.MyId}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
