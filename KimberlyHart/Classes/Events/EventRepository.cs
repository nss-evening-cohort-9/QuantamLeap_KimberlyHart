using KimberlyHart.Classes.Leapers;
using KimberlyHart.Classes.NamesYears;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace KimberlyHart.Classes.Events
{
    public class EventList
    {
        public List<Event> AllEvents = new List<Event>();

        public EventList()
        {
            var EventA = new Event("Halloween Party", 1975, "on Elm Street", 200);
            var EventB = new Event("Fight Night", 2000, "in Las Vegas", 150);
            var EventC = new Event("Elvis's Death", 1954, "in Memphis, TN", 225);
            var EventD = new Event("Cuban Missile Crisis", 1962, "in Homestead, FL", 150);
            var EventE = new Event("Earthquake", 1957, "in St. Louis, MO", 150);





            AllEvents.Add(EventA);
            AllEvents.Add(EventB);
            AllEvents.Add(EventC);
            AllEvents.Add(EventD);
            AllEvents.Add(EventE);
        }

        public void PrintNames()
        {
            var number = 1;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("CHOOSE FROM THE EVENTS BELOW:");
            foreach (var singleEvent in AllEvents)
            {
                Console.WriteLine("*****************");
                Console.WriteLine($"{number++}. {singleEvent.Name} {singleEvent.Location} happens in the year {singleEvent.Year} and it costs ${singleEvent.CostToLeap} to leap. The reward for setting this event right is ${singleEvent.Reward}!");
            }

        }

        public Event GetEvent(int index)
        {
            return AllEvents[index - 1];
        }

        public void Remove(Event eventToRemove)
        {
            AllEvents.Remove(eventToRemove);
        }
    }
}
