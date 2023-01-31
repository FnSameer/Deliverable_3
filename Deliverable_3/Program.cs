﻿namespace Deliverable_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int input = 0;
                string series = "";

                while (true)
                {
                    Console.WriteLine("Enter an integer number between 1 and 100");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }

                }

                while (true)
                {
                    Console.WriteLine("Specify the series type: 'Even' or 'Odd'");
                    series = Console.ReadLine();

                    if (series == "Odd" || series == "Even")
                    {
                        break;
                    }
                }




                if (series == "Odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 1 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100");
                

            }

            
        }
    }
}