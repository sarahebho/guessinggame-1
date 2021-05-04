using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter Name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!!! Welcome Caesar's Guess the Number Game");

            Random rd = new Random();

            int ran_num = rd.Next(1, 100);

           


            Console.Write("Guess the correct from 1 - 100: ");

            int numguessed = Convert.ToInt32(Console.ReadLine());

           

            int i = 0;
            for ( ; i < 3;) 
            { 

                while (numguessed != ran_num)
                {

                    if (numguessed < 1 || numguessed > 100)
                    {
                        Console.WriteLine("Invalid Number");
                        numguessed = Convert.ToInt32(Console.ReadLine());
                        i++;

                    }

                    else
                    {
                        Console.WriteLine("Wrong Guess!! Try Again");
                        numguessed = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }

                    if (i == 3)
                    {
                        Console.WriteLine("You Lose!!!");
                    }

                    break;


                }
                

                while (numguessed == ran_num)
                    {
                        Console.WriteLine(name + " You Won!!! You guessed the number");
                    break;

                    }
               
                
                
                

            }



            




           

        }

    }
        
}

