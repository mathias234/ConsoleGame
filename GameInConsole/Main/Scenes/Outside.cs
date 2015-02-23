using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Components;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components.Objects;

namespace GameInConsole.Main.Scenes {
    class Outside : IScene {
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
            gameObjects.Add(new GameObject("road", LookDirection.North, new Door(new Outside()), true));
            gameObjects.Add(new GameObject("door", LookDirection.South, new Door(new HouseScene()), true));

            while (Game.instance.LoadedScene() == this) {
                string text = "You are now standing outside of the house. ";

                while (hasShownLocDescript == false) {
                    Player p = Game.playerInstance;
                    if (p.LookDir == LookDirection.North) {
                        text = text + "You can see a spiraly road going towards a lake.";
                    } else if (p.LookDir == LookDirection.South) {
                        text = text + "You can see a white door which leads into the house.";
                    } else if (p.LookDir == LookDirection.West) {
                        text = text + "There is a great big forest here.";
                    } else if (p.LookDir == LookDirection.East) {
                        text = text + "A road going towards a town of some sort.";
                    }

                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);
                ConsoleHelper.ReadChoise(Console.ReadLine());
            }
        }
    }
}
