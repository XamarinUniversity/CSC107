using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanManager hangManager = new HangmanManager("xamarin");

            do
            {
                Console.WriteLine(hangManager.DisplayString);
                Console.WriteLine("Enter a single character");
                char enteredCharacter = char.Parse(Console.ReadLine());
                hangManager.Guess(enteredCharacter);
            } while (!hangManager.IsGameOver);

            Console.WriteLine("Good Job! You have completed the puzzle.");
        }
    }
}
