using System;

class Program
{

    
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = 0;
        string guess;
        int guessNum = 1;
        bool playAgain = true;


        while(playAgain){
            Console.WriteLine("Guess the number");
            guess = Console.ReadLine();
            guessNum = Int32.Parse(guess);
            number = randomGenerator.Next(1, 100);
            while(guessNum != number)
            {
                if(guessNum > number)
                {
                    Console.WriteLine("Lower");
                }
                if(guessNum < number)
                {
                    Console.WriteLine("Higher");
                }
                //Console.WriteLine("Guess Again");
                guess = Console.ReadLine();
                guessNum = Int32.Parse(guess);

            }
            Console.WriteLine("You got it");
            Console.WriteLine("Wanna Play again(y/n)");
            if (Console.ReadLine() == "y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
    }
}