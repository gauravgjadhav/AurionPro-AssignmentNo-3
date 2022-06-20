using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        int trys;
        trys = 1;

        Console.WriteLine("Please Enter the name ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.WriteLine("Welcome In Game " + name + " Game Strat ");


        while (run == true) // Main While Schleife
        {

            Random rndnr = new Random();
            int rnd;
            rnd = rndnr.Next(1, 100);
            int guess;
            int score = 100;


            guess = 0;




            Console.WriteLine("you have only 5 chance");
            Console.WriteLine("You have Score " + score);
            Console.WriteLine("Can you guess number between 1 and 100!");
            
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(rnd);
            score = score - 20;
            Console.WriteLine("Now your score is " + score);

            Console.WriteLine("You loose " + trys + " chance!");

            while (guess != rnd)
            {


                if (trys > 4)
                {

                    Console.WriteLine("You only 5 Chance . You failed! \n");
                    run = false;
                    Console.WriteLine("Do you wann play again? Press Enter to play again!(y/n)");

                    string rerun = Console.ReadLine();
 
                    if (rerun == "y")
                    {
                        run = true;
                        trys = 1;
                        break;
                    }
                    else
                    {
                        run = false;
                        break;

                    }


                }
                //Console.WriteLine("you left "+trys);





                if (guess > rnd)
                {
                    Console.WriteLine("You choose Higher Number " + guess + "\n guess again >>");
                    guess = Convert.ToInt32(Console.ReadLine());




                }

                if (guess < rnd)
                {
                    Console.WriteLine("You Choose  Lower Number " + guess + "\n guess again >>");
                    guess = Convert.ToInt32(Console.ReadLine());


                }


                if (guess == rnd)
                {

                    Console.Write("Congratulation " + name + " You guessed right my number is " + rnd + " and you needed " + trys + " trys");
                    Console.WriteLine("Your Score " + score);
                    run = false;
                    Console.WriteLine("Do you wann play again? Press(y/n)"); // Converting null literal or possible null value to non-nullable type.
                    string rerun = Console.ReadLine();
                         // Converting null literal or possible null value to non-nullable type.
                    if (rerun == "y")
                    {
                        run = true;
                        trys = 1;
                        break;
                    }
                    else
                    {
                        run = false;
                        break;

                    }


                }


                trys++;
                Console.WriteLine("You loose " + trys + " chance!");
                score = score - 20;
                Console.WriteLine("Now your score is  "+ score);
            }




        }

        Console.WriteLine("Thanks for palying see you next time!");
        Console.ReadLine();
    }
}


