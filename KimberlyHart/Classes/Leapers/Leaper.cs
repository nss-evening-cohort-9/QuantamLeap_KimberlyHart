using KimberlyHart.Classes.Events;
using KimberlyHart.Classes.Hosts;
using System;
using System.Collections.Generic;

using System.Text;

namespace KimberlyHart.Classes.Leapers
{
    public class Leaper
    {
        public string Name { get; set; }
        public Event CurrentEvent { get; set; }
        public int Wallet { get; set; }
        public Host HostUsing { get; set; }

        // public List<Event> PastEvents = new List<Event>();
        public List<Host> PastHosts = new List<Host>();

        public Leaper(string name, int budget)
        {
            Name = name;
            Wallet = budget;
        }

        //public void Jump(Host whatHost, Event whatEvent)
        //{
        // if (whatHost.Year == whatEvent.Year)
        // {
        // Console.WriteLine($"{Name} You are Jumping into {whatHost.Name}, The year is {whatEvent.Year}");
        // var budgetCheck = new Wallet.Wallet(this, whatEvent.Year).CheckMoneyToJump(5);

        //}
        public void GetHostInfo(Host hostToShare)
        {
            PastHosts.Add(hostToShare);
            Console.WriteLine($"{ hostToShare.Name} added to HostList in Leaper");
        }
    }
}


