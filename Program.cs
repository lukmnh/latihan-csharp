﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple while
            /*int counter = 0
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }*/

            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("please enter to increase amount by one " +
                    "+ enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("current people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus", counter);
            Console.Read();
        }
    }
}
