using System;
using System.Collections.Generic;
using System.Text;
using KimberlyHart.Classes.Hosts;

namespace KimberlyHart.Classes.Events
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Location { get; set; }
        public int CostToLeap { get; set; }
        public int Reward { get; set; }
        public bool IsPutRight { get; set; }

        public Event(string name, int year, string location, int reward)
        {
            Id = new Guid();
            Name = name;
            Year = year;
            Location = location;
            CostToLeap = 100;
            Reward = reward;
            IsPutRight = false;
        }
    }
}
