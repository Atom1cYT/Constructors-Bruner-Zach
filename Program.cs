    using System;

namespace Constructors_Bruner_Zach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Puts CS:GO is an FPS game into the system 
            Game myGame = new Game("CS:GO", "FPS");
            // Inputs MYfavortie game is my game title and it is a my game genre into the system to be replaced BY CS:GO and FPS
           Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");
            
            // inputs the other game and new game into the system 
            Game myOtherGame = new Game();
            // Inputs into system 
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
