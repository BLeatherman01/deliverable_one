using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                bool keepGoing = true;

                do
                {
                    Console.WriteLine("How many people are we making PB and J sandwiches for?");

                    string people = Console.ReadLine();

                    int result = Convert.ToInt32(people);



                    int bread = 2;
                    int pb = 2;
                    int jelly = 4;


                    Decimal tableSpoon = 0;
                    Decimal slices = 0;
                    Decimal teaSpoon = 0;

                    Decimal loaves = 0;
                    Decimal jarsPb = 0;
                    Decimal jarsJ = 0;

                    slices = result * bread;
                    tableSpoon = result * pb;
                    teaSpoon = result * jelly;


                    Console.WriteLine("You need:");
                    Console.WriteLine($"{slices} slices of bread");
                    Console.WriteLine($"{tableSpoon} tablespoons of peanut butter");
                    Console.WriteLine($"{teaSpoon} teaspoons of jelly");

                    loaves = slices / 28;
                    jarsPb = tableSpoon / 32;
                    jarsJ = teaSpoon / 48;

                    Console.WriteLine("Which is...");
                    Console.WriteLine(Math.Ceiling(loaves) + " loaves of bread");
                    Console.WriteLine(Math.Ceiling(jarsPb) + " jars of peanut butter");
                    Console.WriteLine(Math.Ceiling(jarsJ) + " jars of jelly");
                                           

                    Console.WriteLine("would you like to restart? Enter yes or y to continue, or enter any other key to exit.");

                    string restart = Console.ReadLine();

                    if (restart != "yes" && restart != "y")
                    {
                        Console.WriteLine("Goodbye");
                        keepGoing = false;
                    }
                }

                while (keepGoing);

            }
        }
    }   
}
