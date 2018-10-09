using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Please enter First Name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter a number between 1 and 100:");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (number % 2 == 1)
                {
                    Console.WriteLine(firstName + " " + input + " Odd ");

                    if (number > 60)
                    {
                        //Console.WriteLine(input + " Odd ");
                    }
                }
                else if (number % 2 == 0)
                {
                    //Console.WriteLine(input + " Even ");

                    if (number >= 2 && number <= 25)
                    {
                        Console.WriteLine(firstName + " Even and less than 25 ");
                    }
                    else if (number >= 26 && number <= 60)
                    {
                        Console.WriteLine(firstName + " Even");
                    }
                    else if (number > 60)
                    {
                        Console.WriteLine(firstName + " " + input + " Even ");
                    }


                }

                Console.WriteLine("Continue?(y/n)");
            }
            while (Console.ReadLine() == "y");

            Console.WriteLine("Bye");
        }

    }
}
