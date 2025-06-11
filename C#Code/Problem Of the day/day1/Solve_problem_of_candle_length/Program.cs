
//Birthday Cake Candles

//Task:
//Count how many candles are the tallest.

//Description:
//You are given a list of integers representing the height of each candle. You need to determine how many candles are the tallest.

//Example:
//If candles = [4, 1, 4, 3],
//the tallest candles are 4 units high,
//and there are 2 candles with this height.

//So, the function should return 2.


namespace Solve_problem_of_candle_length
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            static void Main()
            {
                Console.WriteLine("Enter candle heights separated by spaces:");

                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                int[] candles = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    candles[i] = int.Parse(parts[i]);
                }

                int max = candles[0];
                int count = 1;

                for (int i = 1; i < candles.Length; i++)
                {
                    if (candles[i] > max)
                    {
                        max = candles[i];
                        count = 1;
                    }
                    else if (candles[i] == max)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Number of tallest candles is: " + count);
            }
        }

    }
}

