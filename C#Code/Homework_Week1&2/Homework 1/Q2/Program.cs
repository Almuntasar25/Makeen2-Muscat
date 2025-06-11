namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q2 

            // Loop through numbers from 1 to 100
            for (int number = 1; number <= 100; number++)
            {
                int sum = 0;

                // Find all divisors of the number (excluding itself)
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i; // Add the divisor to the sum
                    }
                }

                // Check if the number is perfect
                if (sum == number)
                {
                    Console.WriteLine(number + " is a perfect number");
                }
            }
        }
        }


    }

