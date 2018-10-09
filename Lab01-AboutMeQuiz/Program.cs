using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declare variable to keep score.
            int score = 0;
            Console.WriteLine("Let's Take A Quiz About Danul!");

            //Question 1
            score += GuessAge();

            //Question 2
            score += GuessHometown();

            //Question 3. Return type of bool.  If guessed right, return true and increment score.
            if (GuessColor())
            {
                score++;
            }

            //Question 4
            string guess = GuessDog();
            if (guess == "French Bulldog" || guess == "french bulldog" || guess == "Frenchie" || guess == "frenchie") 
            {
                Console.WriteLine("Correct!  His Frenchie's name is Manolo.");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.  Danul has a Frenchie named Manolo.");
            }

            //Question 5

            //Display overall score.
            Console.WriteLine($"You got {score} correct and {5 - score} incorrect.");

        }

        //method to ask question about age and increment score if correct.
        static int GuessAge()
        {
            Console.Write("Can you guess Danul's age? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == 30)
            {
                Console.WriteLine("Correct!  Danul is 30 years old.");
                return 1;
            }
            else
            {
                Console.WriteLine("Incorrect, Danul is actually 30 years old.");
                return 0;
            }
        }

        //method to ask question about hometown.
        static int GuessHometown()
        {
            Console.Write("Where is Danul's home state? ");
            string guess = Console.ReadLine();

            if(guess == "Texas" || guess == "TX")
            {
                Console.WriteLine("Correct!  Danul is from Houston, Texas.");
                return 1;            }
            else
            {
                Console.WriteLine("Incorrect.  Danul is from Houston, Texas.");
                return 0;
            }
        }

        //method to ask if my hair is brown or not.
        static bool GuessColor()
        {
            Console.Write("Is Danul's hair brown? [Y/N]");
            string guess = Console.ReadLine();

            if(guess != "Y" && guess != "N")
            {
                Console.WriteLine("You didn't input a valid guess!  No points for you!  Moving on!");
                return false;
            }else if(guess == "Y")
            {
                Console.WriteLine("Correct!  Danul's hair is the loveliest shade of brown.");
                return true;
            }
            else {
                Console.WriteLine("Incorrect.  Danul's hair is brown.");
                return false;

            }
        }

        //method for question 4
        static string GuessDog()
        {
            Console.Write("What kind of dog does Danul have?");
            string guess = Console.ReadLine();
            return guess;
        }
    }
}
