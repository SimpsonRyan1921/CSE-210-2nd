using System;

class Program
{
    static void Main(string[] args)
    {
        int guesses = 1;

        int gameOn = 1;

        while( gameOn == 1)
        {
            Random randomGenerator = new Random();
            int magicNum =randomGenerator.Next(1, 50);
            
            int answer = 0;

            Console.WriteLine("This is a radnom number generator. Try and guess the number from 1-50.");
            Console.WriteLine("What is your guess? ");
            string userGuess = Console.ReadLine();
            answer = int.Parse(userGuess);

            while (answer != magicNum)
            {
                if (answer > magicNum)
                {
                    Console.WriteLine("Lower");
                }

                else if (answer < magicNum)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("Something went wrong");
                }

                guesses += 1;

                Console.WriteLine("Give it another shot! What's you're guess? ");
                userGuess = Console.ReadLine();
                answer = int.Parse(userGuess);             

            }

            Console.WriteLine($"You got the number! It took you {guesses} tries.");
            
            Console.WriteLine("Would you like to play again? ");
            string playOn = Console.ReadLine();
            if (playOn == "Yes")
            {
                gameOn = 1;
            }
            
            else if (playOn == "No" )
            {
                gameOn = 0;
                Console.WriteLine("Thank you for playing! Goodbye.");
            }
            else
            {
                gameOn = 0;
            }
        }
    }
}