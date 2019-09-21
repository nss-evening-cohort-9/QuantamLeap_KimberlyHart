using System;
using System.Collections.Generic;
using System.Text;
using KimberlyHart.Classes.Leapers;

namespace KimberlyHart.Classes.Hosts
{
    class Host
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Age { get; set; }
        public bool BeingUsed { get; set; }
        public Leaper UsedBy { get; set; }
        public List<Leaper> PastUsers = new List<Leaper>();
        public int CostPerDay { get; set; }
        public int MyId { get; }

        public Host(string name, int year, int age, int id)
        {
            Name = name;
            Year = year;
            Age = age;
            BeingUsed = false;
            CostPerDay = 10;
            MyId = id;
        }
    }
}
