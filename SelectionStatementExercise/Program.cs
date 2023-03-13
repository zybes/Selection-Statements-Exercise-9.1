namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
             //Number Guessing Game

            var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 5;
            int userInput;
            do
            {

           
                Console.WriteLine("Pick a number from 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (userInput != favNumber);

            /* Switch Case

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("Math is ok");
                    break;
                case "science":
                    Console.WriteLine("Science is ok");
                    break;
                case "p.e.":
                    Console.WriteLine("P.E. is ok");
                    break;
                case "history":
                    Console.WriteLine("History is ok");
                    break;
                case "english":
                    Console.WriteLine("English is ok");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break; 
            }*/

        }
    }
}
