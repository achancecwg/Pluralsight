using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections;

namespace CollectionsFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoArrayWeekdays.printArray();

            DemoArrayEnums[] demoEnum = new DemoArrayEnums[]
            {
                new DemoArrayEnums {Prop1="Foo", Prop2=5 },
                new DemoArrayEnums {Prop1 = "Bar", Prop2=7 }
            };

            //Simple enumeration to print out each element
            //foreach(DemoArrayEnums demo in demoEnum)
            //{
            //    Console.WriteLine(demo);
            //}

            //What if we want to override values with foreach?

            //foreach (DemoArrayEnums demo in demoEnum)
            //{
            //    //The complier will not allow this, since demo is an iteration variable it is a readonly property.
            //    demo = new DemoArrayEnums { Prop1 = "NewFoo", Prop2 = 0 };
            //}

            //However, we can override properties within a foreach

            foreach (DemoArrayEnums demo in demoEnum)
            {
                //This code is perfectly legal and will execute fine
                demo.Prop2 = 5000;
                Console.WriteLine(demo);
            }


        }
    }
}
