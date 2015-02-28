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
        List<NeighbourScene> neighboors = new List<NeighbourScene>();

        List<NeighbourScene> IScene.Neighbours {
            get { return neighboors; }
            set { neighboors = value; }
        }

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
            gameObjects.Add(new GameObject("Door", new Door(false, new Outside()), true));
            gameObjects.Add(new GameObject("Knife", new ObjectItem("Knife", ItemType.Weapon, gameObjects.Count, 50), true));
            gameObjects.Add(new GameObject("Sword", new ObjectItem("Sword", ItemType.Weapon, gameObjects.Count, 120), true));
            gameObjects.Add(new GameObject("Trap Door", new Door(false, new Outside()), false));

            while (Game.instance.LoadedScene() == this) {
                string text = "";

                while (hasShownLocDescript == false) {
                    text = "You are now standing in a house. To the north you can see a white door infornt of you see a knife on the table and a Sword hangning on the wall. To the south you can see a trap door, which seems to be nailed shut.";
                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);
                ConsoleHelper.ReadChoise(Console.ReadLine());
                text = "";
            }
        }
    }
}
