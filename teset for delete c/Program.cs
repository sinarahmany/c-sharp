using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teset_for_delete_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello c#");
            Console.Write("123\n");
            Console.Write("no line break");

            byte byteVar = 1;
            Console.WriteLine($"the byteVar value is {byteVar}");
            Console.WriteLine($"the max value for byte is {byte.MaxValue}");
            Console.WriteLine($"the min ...{byte.MinValue}");
            Console.WriteLine($"the size of byte {sizeof(byte)}");

            char charVarUnhide = '\u01A9';
            Console.WriteLine($"the cahrvarunhide value is :{charVarUnhide}");
            Console.WriteLine("\n");


            decimal decival = 345345;
            Console.WriteLine($"the value is :{decival} ");
            Console.WriteLine($"teh value with new format string"+string.Format("{0:n0}",decival));

            decimal decival2 = 345_345;
            Console.WriteLine($"the value is :{decival2} ");

            //  _ make no changes between numbers 
            Console.WriteLine($"the max decimal is{string.Format("{0:n0}" ,decimal.MaxValue)}");

            Console.ReadLine();

        }
    }
}
