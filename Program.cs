
using System;

namespace Deliverable_3_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                Console.WriteLine("Enter an integer value between 1 and 100");
                int input = int.Parse(Console.ReadLine());

                if ((input > 0) && (input <= 100)) 
                {
                    Console.WriteLine("Specify a series of integer numbers: even or odd");
                    string series_name = Console.ReadLine();

                    if (series_name == "even")
                    {
                        int i = 1;
                        int even = 0;
                        Console.WriteLine("You have selected the even series. The numbers between 0 and " + input.ToString() + " are: ");
                        do
                        {
                            Console.WriteLine(even.ToString());
                            even = 2 * i;
                            i++;
                        }
                        while (even < input);
                    }
                    else if (series_name == "odd")
                    {
                        int k = 1;
                        int odd = 1;
                        Console.WriteLine("You have selected the odd series. The numbers between 0 and " + input.ToString() + " are: ");
                        do
                        {
                            Console.WriteLine(odd.ToString());
                            odd = 2 * k + 1;
                            k++;
                        }
                        while (odd < input);
                    }
                    else
                    {
                        Console.WriteLine("Please select a correct series and try again");
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}