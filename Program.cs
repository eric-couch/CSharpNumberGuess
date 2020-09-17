using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            string msg = "";
            while (true)    // this loop is the game loop
            {
                hidden = rand.Next(100);
                Console.Write("Guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                while (guess != hidden)
                {
                    if (Math.Abs(guess - hidden) > 10)
                    {
                        msg = "... and you are cold!";
                    }
                    else
                    {
                        if (Math.Abs(guess - hidden) < 5)
                        {
                            msg = "... and you are hot!";
                        }
                        else
                        {
                            msg = "... and you are warm!";
                        }
                    }
                    if (guess<hidden)
                    {
                        Console.WriteLine("too low" + msg);
                        
                    }
                    if (guess>hidden)
                    {
                        Console.WriteLine("too high" + msg);
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
