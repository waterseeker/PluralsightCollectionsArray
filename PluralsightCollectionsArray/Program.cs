using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightCollectionsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string monday = "Monday";
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //finds an index in the array and writes it to the console. 
            string tuesday = daysOfWeek[1];
            Console.WriteLine(tuesday);

            //displays a message to the user and asks for an input
            //then uses that input as the index to look up in the array
            //then displays what's at that index.
            Console.WriteLine("Type in a number from 0-6 to display the day at that index.");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("You typed '" + day +"'." + " That index of the array contains '" + daysOfWeek[day] + "'.");

            //foreach loop through the array
            foreach (string IterationDay in daysOfWeek)
            {
                Console.WriteLine("This array contains " + IterationDay + ".");
            }

            //to replace an element in an array...
            daysOfWeek[5] = "PartyDay";
            Console.WriteLine("We changed Saturday to " + daysOfWeek[5] + "!");
            foreach (string ChangedDays in daysOfWeek)
            {
                Console.WriteLine("The changed array contains " + ChangedDays + ".");
            }
        }
    }
}
