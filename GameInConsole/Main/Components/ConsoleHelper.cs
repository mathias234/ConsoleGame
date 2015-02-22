using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Scenes {
    public class ConsoleHelper {
        public static bool ReadChoise(string choise) {
            List<GameObject> gameObjects = Game.instance.LoadedScene().GameObjects;
            if (choise.ToLower() == "y" || choise.ToLower() == "yes" || choise.ToLower() == "ye") {
                return true;
            } else if (choise.ToLower() == "n" || choise.ToLower() == "no" || choise.ToLower() == "nope" || choise.ToLower() == "nah") {
                return false;
            } else if (choise.ToLower().Contains("forward")) {
                Turn(LookDirection.Forward);
            } else if (choise.ToLower().Contains("backward")) {
                Turn(LookDirection.Backward);
            } else if (choise.ToLower().Contains("left")) {
                Turn(LookDirection.Left);
            } else if (choise.ToLower().Contains("right")) {
                Turn(LookDirection.Right);
            } else if (choise.ToLower().Contains("use")) {  // use Objects doors etc
                for (int x = 0; x < gameObjects.Count; x++) {
                    if (choise.ToLower().Contains(gameObjects[x].Name.ToLower()) && !gameObjects[x].Type.ToString().Contains("Item")) {
                        gameObjects[x].Type.Action();
                    } 
                }
            } else if (choise.ToLower().Contains("pickup")) {   // pickup items
                for (int x = 0; x < gameObjects.Count; x++) {
                    if (choise.ToLower().Contains(gameObjects[x].Name.ToLower()) && gameObjects[x].Type.ToString().Contains("Item")) {
                        gameObjects[x].Type.Action();
                    }
                }
            } else if (choise.ToLower().Contains("clear")) {
                Console.Clear();
            } else if (choise.ToLower().Contains("inventory") || choise.ToLower().Contains("bag") || choise.ToLower().Contains("pouch")) {
                foreach (Item it in Game.instance.player.Inventory) {
                    Console.WriteLine("Name: " + it.Name);
                    Console.WriteLine("Type: " + it.Type.ToString());
                    Console.WriteLine("_________________________________");
                }
            } else if (choise.ToLower().Contains("debug")) {
                for (int x = 0; x < gameObjects.Count; x++) {
                    Console.WriteLine("[DEBUG]:" + gameObjects[x].Name);
                }
            } else {
                Console.WriteLine("I did not understand that");
            }
            
            return false;
        }
        public static void Turn(LookDirection dir) {
            Game.instance.player.LookDir = dir;
        }
    }
}
