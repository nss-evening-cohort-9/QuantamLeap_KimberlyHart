using System;
using System.Collections.Generic;
using System.Text;

// * This class will allow us to get a random list of Hosts for every Event, and time we run the program.
// * The Constructor creates a list of years from 1900-2000 (we can change this if we want)
// * It adds these years to a List<int>, and names to another List<string>(200 in total as of now)
// * It then loops through each name in the list, adding both to the Dictionary<string, int> NamesWithYears
// * During each loop It makes the name it's on the KEY, and picks a random year as the VALUE
// * This makes it possible to loop over the instance of this class, and grab names by year.


// * There are 2 Methods to call
//    * JustAListOfTheYears - Returns a List<int> of just the years...
//    * GiveRandomYear - returns a random year as an int.


// I'm calling this in CreateHosts.cs to create a list of Host classes
namespace KimberlyHart.Classes.NamesYears
{
    class NameYear
    {
        public Dictionary<string, int> NamesWithYears = new Dictionary<string, int>();

        List<int> YearList = new List<int>();

        List<string> NameList = new List<string>
        {
            "Chasity Okeeffe",
            "Chester Bellant",
            "Erasmo Clinard",
            "Verdell Mastran",
            "Darell Simon",
            "Phylis Dreier",
            "Zulma Degennaro",
            "Lenna Pea",
            "Ronnie Goates",
            "Pinkie Kellerho",
            "Rebeca Winebarg",
            "MichelineRainv",
            "Caroyln Keef",
            "Melodee Boles",
            "Stephen Woodby",
            "Cleora Pinson",
            "Shona Schneller",
            "Kimber Dolin",
            "Lorri Doan",
            "Wilma Verona",
            "Velva Downs",
            "Trina Aguilar",
            "Lucretia Curiel",
            "Murray Dubose",
            "Reena Devenport",
            "Michell Larios",
            "Pedro Guevara",
            "Carmel Ackman",
            "Raylene Lebel",
            "Loura Zieman",
            "Kasandra Arnold",
            "Layla Packard",
            "Billye Almond",
            "Claud Borgia",
            "Emmanuel Ryce",
            "Brenna Croghan",
            "Anna Huffaker",
            "Kaylene Detamor",
            "Ling Paquette",
            "Rosia Jenner",
            "Stephan Martins",
            "Daysi Furness",
            "Jenny Carrion",
            "Heike Blauvelt",
            "Danna Rehkop",
            "Katherin Lahr",
            "Elisha Hollier",
            "Steven Rawls",
            "Olene Weckerly",
            "Ardith Fravel",
            "Juanita Mendiola",
            "Isidra Gillison",
            "Emmett Consolini",
            "Augustine Helbing",
            "Katherine Daniele",
            "Arvilla Farrelly",
            "Jessi Bergen",
            "Crista Belle",
            "Ivonne Meikle",
            "Daisey Pellegrino",
            "Napoleon Delange",
            "Orpha Cumbee",
            "Natalie Tomer",
            "Rey Oman",
            "Teofila Avent",
            "Cayla Soldner",
            "Demetrice Basaldua",
            "Lasonya Lammert",
            "Chere Edenfield",
            "Debbi Fessenden",
            "Edmond Umfleet",
            "Earl Plunkett",
            "Latasha Cregan",
            "Asha Pacheo",
            "Dia Muldoon",
            "Maye Given",
            "Jeane Sims",
            "Marketta Aybar",
            "Mui Pechacek",
            "Dorothy Rommel",
            "Carley Chun",
            "Isreal Turek",
            "Brianne Woodall",
            "Abe Villeda",
            "Jong Etter",
            "Rayna Bialek",
            "Delpha Dudgeon",
            "Tawanna Kilmer",
            "Mariel Gilchrest",
            "Cicely Haake",
            "Latesha Hansard",
            "Zulema Cecena",
            "Annetta Herrell",
            "Maddie Willbanks",
            "Donald Huie",
            "Kathe Tostado",
            "Mikaela Mccallon",
            "Kimbra Gittens",
            "Tonisha Melton",
            "Nydia Gagliano",
            "Julietta Bulow",
            "Vivian Jost",
            "Johna Feeney",
            "Graig Haddox",
            "Esmeralda Westergard",
            "Melba Todaro",
            "Vina Englert",
            "Patria Buckler",
            "Penni Zentz",
            "Deandrea Rebuck",
            "Virgen Eurich",
            "Kiera Draheim",
            "Cristine Cuen",
            "Laurence Barefoot",
            "Arica Babiarz",
            "Justine Cue",
            "Bernetta Franklin",
            "Antoinette Reneau",
            "Teri Meuser",
            "Vena Stringer",
            "Eva Devito",
            "Karlyn Miah",
            "Asuncion Azure",
            "Nelle Avina",
            "Kandis Flor",
            "Daphine Maddocks",
            "Hattie Mcdole",
            "Marquitta Hemmingway",
            "Griselda Maloney",
            "Ellan Bak",
            "Hedy Raine",
            "Wilma Mullis",
            "Agnes Satterwhite",
            "Alane Odea",
            "Alonso Crepeau",
            "Margorie Hugh",
            "Rolanda Francisco",
            "Geri Torrain",
            "Lavonda Matousek",
            "Madelyn Lonergan",
            "Trent Bryce",
            "Jacquelyne Shubert",
            "Catalina Odell",
            "Joella Ochsner",
            "Jessie Weir",
            "Charlott Vedder",
            "Lakenya Sylva",
            "Jule Unsworth",
            "Carol Mcdougall",
            "Margeret Jarosz",
            "Elfriede Turlington",
            "Caren Trudell",
            "Nydia Cordle",
            "Leta Lamorte",
            "Kena Burget",
            "Shonta Summy",
            "Marissa Kentner",
            "Justina Canas",
            "Elyse Deborde",
            "Elsie Goldstein",
            "Patrice Lamborn",
            "Sharlene Providence",
            "Rosaria Stribling",
            "Dalia Gensler",
            "Bethann Wasmund",
            "Daina Bourget",
            "Layla Malmberg",
            "Kenia Lugo",
            "Clifton Hecht",
            "Tracey Mendivil",
            "Greta Touchet",
            "Nicolle Reynolds",
            "Dee Ellzey",
            "Erik Secor",
            "Jacinta Hughley",
            "Sherise Schaub",
            "Susie Sliter",
            "Farrah Futrell",
            "Kathryn Abrahamson",
            "Florence Berg",
            "Jona Goode",
            "Freeda Tindle",
            "Bao Turman",
            "Mathilda Sester",
            "Jina Specht",
            "Samella Palau",
            "Ulysses Rizzo",
            "Latonya Larrick",
            "Karine Mickles",
            "Enid Holz",
            "Gretchen Natali",
            "Nicole Savino",
            "Crista Bartholow",
            "Aurelia Fairbairn",
            "Joslyn Whittier",
            "Lavern Mewborn",
            "Velma Michaelis",
            "Shantell Windley",
            "Lynna Cirilo",
            "Shantae Duty",
        };

        public int StartYear { get; set; }

        public int EndYear { get; set; }



        public NameYear()
        {
            var randomGen = new Random();
            var StartYear = 1900;
            var EndYear = 2000;
            for(var i = StartYear; i <= EndYear; i+= 1)
            {
                YearList.Add(i);
            }
            foreach(var name in NameList)
            {
                var index = randomGen.Next(StartYear, EndYear);
                NamesWithYears.Add(name, index);
            }
        }

        public List<int> JustAListOfTheYears()
        {
            return this.YearList;
        }



        public int GiveRandomYear()
        {
            var randomGen = new Random();
            var year = randomGen.Next(StartYear, EndYear);
            return Convert.ToInt32(year);
        }
    }
}
