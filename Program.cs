using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int randno = Newnum(1, 100);
            int count = 1;
            while (true)
            {
                Console.Write("Enter a number between 1 and 100(0 to quit):");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) {
                    Console.WriteLine("Game Exit");
                    return;

                }
                else if (input < randno)
                {
                    Console.WriteLine("Sorry,Too Low ! plz choose higher number.");
                    ++count;
                    continue;
                }
                else if (input > randno)
                {
                    Console.WriteLine("Sorry,Too High ! plz choose lower number.");
                    ++count;
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulation You guessed it! The number was {0}!",
                                       randno);
                    Console.WriteLine("It took you {0} {1}.\n", count,
                                       count == 1 ? "try" : "tries");
                    break;
                }
            }
        }

    }
    static int Newnum(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}
