using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Components.Objects {
    public class ObjectItem : IGameObject {
        string name;
        ItemType type;
        int objPos;
        float score;

        public ObjectItem(string name, ItemType type, int objPos, float score) {
            this.name = name;
            this.type = type;
            this.objPos = objPos;
            this.score = score;
        }
        public void Action() {
            Game.playerInstance.AddItemToInventory(new Item(name, type));
            for (int x = 0; x < Game.instance.LoadedScene().GameObjects.Count; x++) {
                if (Game.instance.LoadedScene().GameObjects[x].Name == name) {
                    Game.instance.LoadedScene().GameObjects.Remove(Game.instance.LoadedScene().GameObjects[x]);
                    Console.WriteLine("You took: " + name);
                    Game.instance.AddScore(this.score);
                }
            }
        }
    }
}
