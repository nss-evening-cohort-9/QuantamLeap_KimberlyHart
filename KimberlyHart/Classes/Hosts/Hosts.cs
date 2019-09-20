using System;
using System.Collections.Generic;
using System.Text;

namespace KimberlyHart.Classes.Hosts
{
    class Hosts
    {
        public string Name { get; set; }
        public int Date { get; set; }
        public bool BeingUsed { get; set; }
        public Leapers.Leapers UsedBy { get; set; }
        public List<Leapers.Leapers> PastUsers { get; set; }
        public int CostPerDay { get; set; }
        public Guid Id { get; set; }

        public Hosts(string name, int date)
        {
            Name = name;
            Date = date;
            BeingUsed = false;
            Id = new Guid();
        }
    }
}
