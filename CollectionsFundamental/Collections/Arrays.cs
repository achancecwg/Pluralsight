using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DemoArrayWeekdays
    {
        public static void printArray()
        {

            //there are many ways to declare an array in C#
            //Show multiple ways commented out 


            /*
             * implicit typing with var keyword
             * 
             var daysOfWeek =  new string[] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
             */

            /*
             *  intializing length explicitly.
             string[] daysOfWeek = new string[7]  {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
             */

            //implicit typing and sizing, no use of new keyword. 
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

            foreach(string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }   
        }
    }

    public class DemoArrayEnums
    {
        //This class will demo enumeration of Arrays in C# 

        //dummy properties
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }

        //overriding toString method to display properties easier
        public override string ToString()
        {
            return string.Format("{0}, prop2={1}", Prop1, Prop2);
        }

    }
}
