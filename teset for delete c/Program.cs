using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teset_for_delete_c
{
    class Program
    {
        enum weekdays
        {
            Monday = 1, tuesday, wednesday, Thursday, friday
        }

        struct dog
        {
            public int birthyear;
            public string name;
            public bool isFriendly;

        }
        static void Main(string[] args)
        {
            // Variables.body();
            Console.WriteLine($"the enum weekdays monday is :{weekdays.Monday.ToString()}");
            Console.WriteLine($"... value is :{(int)weekdays.Monday}");
            Console.WriteLine("\n\n");

            dog doggy;
            doggy.birthyear = 2019;
            doggy.name = "sparky";
            doggy.isFriendly = true;
            Console.WriteLine("printing doggy struct");
            Console.WriteLine($"hello my name is {doggy.name},"+$"i was born at{doggy.birthyear}"+$"people say i am friendly thats {doggy.isFriendly}.");


            Console.WriteLine("\n");
            Console.WriteLine("\t this is tab");
            Console.WriteLine("/\\ /\\");
            Console.WriteLine("shhe ssid \"yes\"");
            Console.WriteLine("helll\boo");
            Console.WriteLine("\a");
            Console.WriteLine("thiis is the symbol of PI \u03c0");
            Console.WriteLine("\n");


            Console.ReadLine();

        }
    }
}
