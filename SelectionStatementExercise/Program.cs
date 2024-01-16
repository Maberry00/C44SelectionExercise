using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //int userInput;

            //The Guessing Game

            //do
            //{
            //    Console.WriteLine("Pick a number between 1 - 1000.");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is Too Low!");
            //    }

            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is Too High!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Congratulations!!");
            //    }

            //} while (userInput != favNumber);


            //Switch Case
            Console.WriteLine("Your favorite class subject?");

            string subject = Console.ReadLine();

            switch(subject) 
            {
                case "math":
                    Console.WriteLine("math is cool!");
                    break;
                case "science":
                    Console.WriteLine("Science is fun");
                    break;
                case "pe":
                    Console.WriteLine("PE is where champions are born!!");
                    break;
                case "history":
                    Console.WriteLine("History is history.");
                    break;
                case "english":
                    Console.WriteLine("English makes me sleepy");
                    break;
                default:
                    Console.WriteLine("It don't matter.");
                    break;
            }
        }
    }
}
