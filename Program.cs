using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab73a
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Creates the members Stack
          Stack<string> games = new Stack<string>();
            // adding games
            games.Push("Zelda");
            games.Push("Supermario");
            games.Push("Madden");
            // adding more games
            Console.WriteLine("How many games would you like to add?");
            int num = int.Parse(Console.ReadLine());
            // adds data to the games Stack
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Game name: ");
                games.Push(Console.ReadLine()); 
            }
            // Check for item in stack
            Console.WriteLine("Would you like to search for a Game (yes or no)");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Enter the name of the game you would like to search for");
                string gameName = Console.ReadLine();
                if (games.Contains(gameName))
                {
                    Console.WriteLine("The game is part of the group.");
                }
                else
                {
                    Console.WriteLine("This game is not in the group.");
                }
                Console.WriteLine("Would you like to look for another game (yes or no?");
                answer = Console.ReadLine();
            }
            // counts the games in the stack
            Console.WriteLine($"Here are your {games.Count()} games");
            // displays the stack contents without removing anything
            foreach (var g in games)
            {
                Console.WriteLine(g);
            }

            string firstgame =games.Peek(); // retreives the Last item
            Console.WriteLine($"Would you like to remove {firstgame} from the end of the stack (yes or no)?");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                games.Pop(); // removes the last item
                firstgame = games.Peek();
                Console.WriteLine($"Wouls you like to remove {firstgame} from the end of the stack (yes or no)?");
                answer = Console.ReadLine();
            }

            if (games.Peek() == null)
                Console.WriteLine(("The stack is empty"));
            else
                Console.WriteLine($"You have {games.Count} left in the stack:");
            Console.WriteLine(); 

            foreach (var g in games)
            {
                Console.WriteLine(g);
            }


        }
    }
}
