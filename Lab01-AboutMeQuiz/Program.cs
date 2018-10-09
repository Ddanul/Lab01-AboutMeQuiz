using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static class Count
        {
            public static int score;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's Take A Quiz About Danul!");
            GuessAge();

        }

        static void GuessAge()
        {
            Console.Write("Can you guess Danul's age? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == 30)
            {
                Console.WriteLine("Correct!  Danul is 30 years old.");
                Count.score++;
            }
            else
            {
                Console.WriteLine("Incorrect, Danul is actually 30 years old.");
            }
            Console.WriteLine($"Current Score: {Count.score}");
        }
    }
}
