using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Scenes {
    class WelcomeScreen : IScene {
        public void Run(Game game) {
            Welcome(game);
        }
        public void Welcome(Game game) {
            Console.WriteLine("Hello And welcome to Origins of Stramon\n");
            Thread.Sleep(900);

            Console.WriteLine("This is a short game made purly in C#\n");
            Thread.Sleep(1200);
            Console.Clear();

            Console.WriteLine("Please Tell me your name so we can begin\n");
            string name = Console.ReadLine();
            game.player.Name = name;

            Console.Clear();
            Console.WriteLine(game.player.Name + " That is a fine name\n");
            Thread.Sleep(900);

            Console.WriteLine("\nYou will start with " + game.player.MaxHealth + " Health, get ready for you biggest adventure yet" + ". Are you ready?");
            string choise = Console.ReadLine();

            if (ConsoleHelper.ReadChoise(choise)) {
                Console.Clear();
                Console.WriteLine("Good Luck!");
                Thread.Sleep(1000);
                Console.Clear();
                Tutorial(game);
            } else {
                System.Environment.Exit(0);
            }

        }
        void Tutorial(Game game) {
            Console.WriteLine("This is the tutorial and we will skips this for now nobody really cares anyway");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
