using System;
//Nikolas Ball
namespace Exercise3_NBALL
{
    class Program
    {
        static void Main(string[] args)
        {
            double iterations;
            double denominator;
            string num;
            double pi = 4;
            Console.WriteLine("Console App: PI Calculator using Leibniz formula" + "\n" + "By: Nikolas Ball" + "\n");
            Console.WriteLine("Please enter the number of times the calculation will iterate." + "\n" + "Please enter a valid number that is greater than 1 million." + "\n");
            Console.Write("Number of iterations > 1 million: ");
            num = Console.ReadLine();
            while (!(Double.TryParse(num, out iterations) && Convert.ToDouble(num) > 1000000))      
            {
                Console.Write("Number of iterations > 1 million: ");
                num = Console.ReadLine();
            }
            {
                Console.Write("\n");
                Console.WriteLine("--------------------------------------------------------" + "\n");
                for (int i = 0; i <= iterations; i++)
                {
                    denominator = i * 2 + 3;
                    if (i % 2 == 0)
                    {
                        pi -= (4 / denominator);
                    }
                    if (i % 2 != 0)
                    {
                        pi += (4 / denominator);
                    }
                    if (i == 10 | i == 1000 | i == 100000 | i == 500000 | i == 1000000 | i == iterations)
                    {
                        Console.WriteLine("At " + (String.Format("{0:n0}", i)) + " iterations, the value of pi is: " + (String.Format("{0:n10}", pi)));
                    }
                }
                Console.Write("\n");
                Console.WriteLine("Please press any key to end" + "\n");
            }
        }
    }
}
