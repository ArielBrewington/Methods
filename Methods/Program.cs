/* Ariel Brewington
  1/31/2019
 Demonstration of method
 */
 
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string userfirstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string userlastname = Console.ReadLine();
            {
                try
                {
                    
                    Console.WriteLine("Hello" + " " + userfirstname+ " " + userlastname +'!');
                    Console.WriteLine("Press any key to exit the program..");
                    Console.ReadKey(true);

                }

                catch// end of catch

                {
                    Console.WriteLine("Please enter a letter for your first name ");
                    Console.WriteLine("Please enter a letter for your last name ");
                    Console.ReadKey(true);
                }




            } }
    }    }
