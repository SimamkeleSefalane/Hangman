 using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {
            _renderer.Render(5, 5, 6);

            string[] wordList = new string[20] {"alpha","bravo","charlie","delta", "echo","foxtrot","golf","hotel","india","juliett",
            "killo", "lima","mike","november","oscar","papa","romeo","sierra","tango","uniform"};

            Random randWord = new Random();
            var index = randWord.Next(0, 19);
            string unknownWord = wordList[index];
            char[] guess = new char[unknownWord.Length];
            Console.WriteLine("Please enter your guess");

            for (int w = 0; w < unknownWord.Length; w++)
                guess[w] = '_';

            while (true)
            {

                char playerGuess = char.Parse(Console.ReadLine());
                for (int l = 0; l < unknownWord.Length; l++)
                    guess[l] = '_';






            }
            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();
        } 
       
    }
}

