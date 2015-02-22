using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components;
using GameInConsole.Main.Components.Objects;

namespace GameInConsole.Main.Scenes {
    public class HouseScene : IScene {

        public List<GameObject> gameObjects = new List<GameObject>();


        public void Run(Game game) {
            gameObjects.Add(new GameObject("White Door", "a", LookDirection.Forward, new Door(new Outside()), true));
            gameObjects.Add(new GameObject("Knife", "a", LookDirection.Forward, new Door(null), true));
            gameObjects.Add(new GameObject("Trap Door", "a", LookDirection.Left, new Door(new Outside()), false));

            while (game.LoadedScene() == this) {
                Player p = game.player;

                string text = "";
                int count = 0;
                foreach (GameObject obj in gameObjects) {
                    if (p.LookDir == obj.LookDir) {
                        text = text + "You see " + obj.Text + " " + obj.Name + "\n";
                        continue;
                    }
                    if (count == gameObjects.Count -1) {
                        text = text + "You see nothing";
                    }
                    count++;
                }

                Console.WriteLine(text);

                ConsoleHelper.ReadChoise(Console.ReadLine(), gameObjects);


            }
        }
    }
}
