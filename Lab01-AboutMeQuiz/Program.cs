using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        //class to have a global variable for score.
        static class Count
        {
            public static int score;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's Take A Quiz About Danul!");
            GuessAge();
            GuessHometown();

        }

        //method to ask question about age and increment score if correct.
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

        //method to ask question about hometown.
        static void GuessHometown()
        {
            Console.Write("Where is Danul's home state? ");
            string guess = Console.ReadLine();

            if(guess == "Texas" || guess == "TX")
            {
                Console.WriteLine("Correct!  Danul is from Houston, Texas.");
                Count.score++;
            }
            else
            {
                Console.WriteLine("Incorrect.  Danul is from Houston, Texas.");
            }
            Console.WriteLine($"Current Score: {Count.score}");
        }
    }
}
