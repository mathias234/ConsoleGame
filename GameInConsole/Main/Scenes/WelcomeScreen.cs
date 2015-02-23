using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GameInConsole.Main.Components;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Scenes {
    class WelcomeScreen : IScene {
        public List<GameObject> gameObjects = new List<GameObject>();

        public bool HasShownLocDescript {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        List<GameObject> IScene.GameObjects {
            get { return gameObjects; }
            set { gameObjects = value; }
        }

        public void Run() {
            Welcome();


        }
        public void Welcome() {
            Console.WriteLine("Hello And welcome to a game\n");
            Thread.Sleep(900);

            Console.WriteLine("This is a short game made purly in C#\n");
            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("Please Tell me your name so we can begin\n");
            string name = Console.ReadLine();
            Game.playerInstance.Name = name;


            Console.WriteLine("\nYou will start with " + Game.playerInstance.MaxHealth + " Health, get ready for you biggest adventure yet" + ". Are you ready?");
            string choise = Console.ReadLine();

            if (ConsoleHelper.ReadChoise(choise)) {
                Console.Clear();
                Console.WriteLine("Good Luck!");
                Thread.Sleep(1000);
                Console.Clear();
                Tutorial();
            } else {
                System.Environment.Exit(0);
            }

        }
        void Tutorial() {
            Console.WriteLine("This is the tutorial and we will skips this for now nobody really cares anyway");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
