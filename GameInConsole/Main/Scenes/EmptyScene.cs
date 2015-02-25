using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Components;
using GameInConsole.Main.Scenes;
/// <summary>
/// This is a empty scene or a blue print for a scene just copy this when making a new one to make sure you dont have any errors
/// </summary>
namespace GameInConsole.Main.Scenes {
    class EmptyScene : IScene {
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


                    hasShownLocDescript = true;
                }
                Console.WriteLine(text);
                ConsoleHelper.ReadChoise(Console.ReadLine());
            }
        }
    }
}
