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
                    if (p.LookDir == LookDirection.North) {
                        text = "You can see a white door infornt of you see a knife on the table and a Sword hangning on the wall";
                    }
                    if (p.LookDir == LookDirection.West) {
                        text = "You can see a trap door, which seems to be nailed shut.";
                    }
                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);

                ConsoleHelper.ReadChoise(Console.ReadLine());


            }
        }
    }
}
