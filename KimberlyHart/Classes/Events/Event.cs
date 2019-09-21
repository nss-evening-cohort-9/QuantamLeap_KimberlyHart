using System;
using System.Collections.Generic;
using System.Text;
using KimberlyHart.Classes.Hosts;

namespace KimberlyHart.Classes.Events
{
    class Event
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Host> HostList { get; set; }


        public Event(string name, int year)
        {

        }
    }
}
