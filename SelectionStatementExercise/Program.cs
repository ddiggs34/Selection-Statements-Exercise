using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            //Create an else -if statement that if the number is higher than the initial value, print out “too high”.
            //Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.;

            Console.WriteLine("Lets play a game. you have to guess my favorite number");
            Console.WriteLine("What is your guess?");
            var userNum = int.Parse(Console.ReadLine());

            if (userNum == 34)
                Console.WriteLine("Great job. You guessed that my favorite number is 34");

            else if (userNum > 34)
            {
                Console.WriteLine($"Nope. {userNum} is too high");
            }

            else
            {
                Console.WriteLine($"No. {userNum} is too low");
            }

        }
    }
}
