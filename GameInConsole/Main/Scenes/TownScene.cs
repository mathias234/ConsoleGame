using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Components;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Scenes {
    class TownScene : IScene {
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
            while (Game.instance.LoadedScene() == this) {
                string text = "";

                while (hasShownLocDescript == false) {
                    Player p = Game.playerInstance;

                    text = "You are now standing in the town";
                    
                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);
                ConsoleHelper.ReadChoise(Console.ReadLine());
            }
        }
    }
}
