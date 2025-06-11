namespace Basic_Applications___Assignment
{
    internal class Program
    {
        //Assignment 2 Simple Quiz App
        static void Main(string[] args)
        {
            string[] correct_answers = { "A", "B", "C", "D", "A" };
                string[] user_answers = new string[5];
                int score = 0;
                string[] questions = { "Q1", "Q2", "Q3", "Q4", "Q5" };
                string[,] options = {
            { "A. Option1", "B. Option2", "C. Option3", "D. Option4" },
            { "A. Option1", "B. Option2", "C. Option3", "D. Option4" },
            { "A. Option1", "B. Option2", "C. Option3", "D. Option4" },
            { "A. Option1", "B. Option2", "C. Option3", "D. Option4" },
            { "A. Option1", "B. Option2", "C. Option3", "D. Option4" }
        };

                

               
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine(questions[i]);
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine(options[i, j]);
                    }

                    Console.Write("Enter your answer (A/B/C/D): ");
                    user_answers[i] = Console.ReadLine().ToUpper();

                    if (user_answers[i] == correct_answers[i])
                    {
                        Console.WriteLine("Correct \r\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, Correct answer: {correct_answers[i]}\r\n");
                    }
                }

                Console.WriteLine($"Your final score = {score}/5");

                switch (score)
                {
                    case 5:
                        Console.WriteLine("Excellent!");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Good Job!");
                        break;
                    default:
                        Console.WriteLine("Try Again.");
                        break;
                }
            }
        

    }
}

