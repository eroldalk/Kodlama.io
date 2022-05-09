using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Value Types
            //Console.WriteLine("HELLO WORLD!");
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            double number5 = 10.4;
            decimal number6 = 10;
            var number7 = 10;
            //number7 = 10;
            char character = 'A';
            bool condition = false;
            //string Days = "friday";
                        

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }

        enum Days
        {
            Monday, Tuesday, Wednesday,Thursday,Friday,Saturday ,Sunday
                 
        }
    }
}
