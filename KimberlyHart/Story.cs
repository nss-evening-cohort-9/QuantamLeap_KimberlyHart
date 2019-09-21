using System;
using System.Collections.Generic;
using System.Text;

namespace KimberlyHart
{
    public class Story
    {
        public string Name { get; set; }
        public int YearBorn { get; set; }
        public int CurrentYear { get; set; }

        public Story()
        {
            CurrentYear = 2019;

            Console.WriteLine("Please Enter Your Name");
            var nameResp = Console.ReadLine();
            Name = nameResp;


            Console.WriteLine("Please Enter Your Birth year YYYY");
            var ageResp = Convert.ToInt32(Console.ReadLine());
            if (ageResp < 1900 || ageResp > 2019)
            {
                Console.WriteLine("You aren't Time Traveling yet, Please Enter your 4 digit birth year");
            }
            else
            {
                YearBorn = ageResp;
            }

        }

        public void GetIntro()
        {
            var lineOne = $"You, Doctor {Name} led a group of top scientists into the desert to research your theory that a person could time travel within their own lifetime.";
            var lineTwo = "Unfortunately, in order to save your funding, You were forced to enter the accelerator prematurely and vanished.";
            var lineThree = "You then found Yourself in someone else's body with partial amnesia.";
            var lineFour = $"Your only contact from home is Al, a holographic image only you can see and hear. ";
            var lineFive = $"Setting right things which once went wrong, You leap from life to life, hoping each time that this is the final leap home.";
            Console.WriteLine(lineOne);
            Console.WriteLine(lineTwo);
            Console.WriteLine(lineThree);
            Console.WriteLine(lineFour);
            Console.WriteLine(lineFive);
        }
    }
}
