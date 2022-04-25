 using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        private int _playsLeft = 6;

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {
            string correctWordGuessed = string.Empty;

            _renderer.Render(5, 5, _playsLeft);

            string[] wordList = new string[20] {"alpha","bravo","charlie","delta", "echo","foxtrot","golf","hotel","india","juliett",
            "killo", "lima","mike","november","oscar","papa","romeo","sierra","tango","uniform"};

            Random randWord = new Random();
            var index = randWord.Next(0, 19);
            string unknownWord = wordList[index];
            char[] guess = new char[unknownWord.Length];

            for (int w = 0; w < unknownWord.Length; w++)
                guess[w] = '-';

            while (_playsLeft > 0 && _playsLeft <= 6)
            {

                Console.SetCursorPosition(0, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Your current guess: ");
                Console.WriteLine(guess);
                Console.WriteLine("--------------");
                Console.SetCursorPosition(0, 15);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("What is your next guess: ");
                var nextGuess = char.Parse(Console.ReadLine());

                bool rightGuess = false;
                {
                    for (int l = 0; l < guess.Length; l++)
                    {
                        if (nextGuess == unknownWord[l])
                        {
                            guess[l] = nextGuess;
                            rightGuess = true;
                        }
                    }
                    if(!rightGuess)
                    {
                        _playsLeft--;
                        _renderer.Render(5, 5, _playsLeft);

                    }

                }
                correctWordGuessed = new string(guess);
                if (correctWordGuessed == unknownWord)
                {
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("Hooray!!! You survived");
                }


            }
            if (correctWordGuessed != unknownWord)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Sorry! You died");
                Console.WriteLine("The word was: " + unknownWord);
            }
        } 
       
    }
}

