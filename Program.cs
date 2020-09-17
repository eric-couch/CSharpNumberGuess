using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            while (true)    // this loop is the game loop
            {
                hidden = rand.Next(100);
                Console.Write("Guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                while (guess != hidden)
                {
                    if (guess<hidden)
                    {
                        Console.WriteLine("too low");
                    }
                    if (guess>hidden)
                    {
                        Console.WriteLine("too high");
                    }
                    Console.Write("Guess again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("you win!!!");
                Console.Write("Play Again (Y/N): ");
                String response = Console.ReadLine();
                if (response != "Y")
                {
                    break;
                }
            }
        }
    }
}
