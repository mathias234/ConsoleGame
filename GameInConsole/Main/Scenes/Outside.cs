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
            gameObjects.Add(new GameObject("door", new Door(false, new HouseScene()), true));

            neighboors.Add(new NeighbourScene(new TownScene(), NeighbourRot.North));
            

            while (Game.instance.LoadedScene() == this) {
                string text = "";

                while (hasShownLocDescript == false) {
                    Player p = Game.playerInstance;

                    text = "You are now standing outside of the house. to the north there is a spiraly road leading down to a town";

                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);

                ConsoleHelper.ReadChoise(Console.ReadLine());
            }
        }
    }
}
