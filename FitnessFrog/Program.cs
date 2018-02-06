using System;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("Enter how many minutes you excercised or type \"quit\" to exit: ");

                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        int minutes = int.Parse(entry);

                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                            continue;
                        }
                        if (minutes < 10)
                        {
                            Console.WriteLine("Better than nothing, amirite?");
                        }
                        else if (minutes < 30)
                        {
                            Console.WriteLine("Now you're cooking.");
                        }
                        else if (minutes < 60)
                        {
                            Console.WriteLine("Wow, you're like so fit");
                        }
                        else
                        {
                            Console.WriteLine("Okay just stop, okay.");
                        }

                        runningTotal += minutes;

                        Console.WriteLine("You've entered " + runningTotal + " minutes.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not valid input");
                    }

                }

            }

            Console.WriteLine("Goodbye");
        }
    }
}
