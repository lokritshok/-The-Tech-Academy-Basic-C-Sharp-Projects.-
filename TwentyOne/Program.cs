using System;
using Cassinnoh;
using Cassinnoh.TwentyOne;




namespace TwentyOne
{
    class Program
    {// This is the main entry point for the application.
        static void Main(string[] args)

        {
            //DateTime yearOfBirth = new DateTime(1970, 8, 2, 8, 32, 45);// This line creates a DateTime object representing the year of birth.
            //DateTime yearOfGraduation = new DateTime(1992, 5, 15, 10, 0, 0);// This line creates a DateTime object representing the year of graduation.
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // This line calculates the time span between two DateTime objects.


            //DateTime dateTime = new DateTime(2025, 7, 7, 01, 10, 0);// This line creates a DateTime object
            // This method initializes the game, prompts the user for their name and bank balance, and starts a game of 21 if the user agrees.
            // string text = "Here is some text that will be written to a file.";
            // File.WriteAllText(@"C:\Users\shokv\Documents\myRepository\mycodefiles\text.txt", text);//writing text to a file
            //   string text = File.ReadAllText(@"C:\Users\shokv\Documents\myRepository\mycodefiles\text.txt");// reading text from a file
            // Console.WriteLine(text);// printing the text read from the file

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling us your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {// If the user agrees to play, create a new player and a new game of 21.
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player; // Add player to the game   
                player.IsActivelyPlaying = true; // Set the player as actively playing  
                while (player.IsActivelyPlaying && player.Balance > 0)
                {// The game loop continues as long as the player is actively playing and has a positive balance.
                    
                    game.Play(); // Start the game

                }
                // The game continues until the player decides to stop or runs out of balance.
                game -= player; // Remove player from the game after they finish playing
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

        }
    }
}