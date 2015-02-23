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
        bool hasShownLocDescript = false;

        List<GameObject> IScene.GameObjects {
            get { return gameObjects; }
            set { gameObjects = value; }
        }

        bool IScene.HasShownLocDescript {
            get { return hasShownLocDescript; }
            set { hasShownLocDescript = value; }
        }

        public void Run() {
            // If the game object is a object item then they should have the same name. this might be changed in the future

            gameObjects.Add(new GameObject("White Door", "a", LookDirection.North, new Door(new Outside()), true));
            gameObjects.Add(new GameObject("Knife", "a", LookDirection.North, new ObjectItem("Knife", ItemType.Weapon, gameObjects.Count), true));
            gameObjects.Add(new GameObject("Sword", "a", LookDirection.North, new ObjectItem("Sword", ItemType.Weapon, gameObjects.Count), true));
            gameObjects.Add(new GameObject("Trap Door", "a", LookDirection.West, new Door(new Outside()), false));

            while (Game.instance.LoadedScene() == this) {
                string text = "";

                while (hasShownLocDescript == false) {
                    Player p = Game.playerInstance;

                    int count = 0;
                    foreach (GameObject obj in gameObjects) {
                        if (p.LookDir == obj.LookDir) {
                            text = text + "You see " + obj.Text + " " + obj.Name + "\n";
                            continue;
                        }
                        if (count == gameObjects.Count - 1) {
                            text = text + "You see nothing";
                        }
                        count++;
                    }
                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);

                ConsoleHelper.ReadChoise(Console.ReadLine());


            }
        }
    }
}
