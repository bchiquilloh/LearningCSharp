using System;

namespace LearningCSharp
{
    class GuessTheNumber
    {
         static void Main(string[] args)
        {
            int theNumber = new Random().Next(20);


            Console.WriteLine("Let's play 'Guess the number'");
            Console.WriteLine("I'm thinking a number between 1 and 20'");
            Console.WriteLine("Enter your guess or -1 to give up'");

            int counter = 0, newNumber;
            String str;


            do
            {
                str = Console.ReadLine();
                newNumber = int.Parse(str);

                if (newNumber == -1)
                {
                    break;
                }
                else if (newNumber < theNumber)
                {
                    Console.WriteLine("Higher than that");
                }
                else if (newNumber > theNumber)
                {
                    Console.Write("Lower than that");
                }
                counter++;
            } while (newNumber != theNumber);
            Console.WriteLine("You took " + counter + " times to guess the number");

            {

            }

        }
    }
}
