using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components;
using GameInConsole.Main.Components.Objects;
/// <summary>
/// I handle all console inputs here
/// </summary>
namespace GameInConsole.Main.Scenes {
    public class ConsoleHelper {
        public static bool ReadChoise(string choise) {
            List<GameObject> gameObjects = Game.instance.LoadedScene().GameObjects;

            if (choise.ToLower() == "y" || choise.ToLower() == "yes" || choise.ToLower() == "ye") {
                return true;
            } else if (choise.ToLower() == "n" || choise.ToLower() == "no" || choise.ToLower() == "nope" || choise.ToLower() == "nah") {
                return false;
            } else if (choise.ToLower().Contains("go north")) {
                foreach (NeighbourScene temp in Game.instance.LoadedScene().Neighbours) {
                    if (Game.instance.LoadedScene().Neighbours.Count > 0) {
                        if (temp.NeighbourRotation == NeighbourRot.North) {
                            Game.instance.LoadScene(temp.Scene);
                            Game.instance.LoadedScene().HasShownLocDescript = false;
                            continue;
                        }
                    }
                }
            } else if (choise.ToLower().Contains("go south")) {
                foreach (NeighbourScene temp in Game.instance.LoadedScene().Neighbours) {
                    if (Game.instance.LoadedScene().Neighbours.Count > 0) {
                        if (temp.NeighbourRotation == NeighbourRot.South) {
                            Game.instance.LoadScene(temp.Scene);
                            Game.instance.LoadedScene().HasShownLocDescript = false;
                            continue;
                        }
                    }
                }
            } else if (choise.ToLower().Contains("go west")) {
                foreach (NeighbourScene temp in Game.instance.LoadedScene().Neighbours) {
                    if (Game.instance.LoadedScene().Neighbours.Count > 0) {
                        if (temp.NeighbourRotation == NeighbourRot.West) {
                            Game.instance.LoadScene(temp.Scene);
                            Game.instance.LoadedScene().HasShownLocDescript = false;
                            continue;
                        }
                    }
                }
            } else if (choise.ToLower().Contains("go east")) { // does not work yet because it will be changed to go into scenes which does not require a pass like a door
                foreach (NeighbourScene temp in Game.instance.LoadedScene().Neighbours) {
                    if (Game.instance.LoadedScene().Neighbours.Count > 0) {
                        if (temp.NeighbourRotation == NeighbourRot.East) {
                            Game.instance.LoadScene(temp.Scene);
                            Game.instance.LoadedScene().HasShownLocDescript = false;
                            continue;
                        }
                    }
                }
            } else if (choise.ToLower().Contains("look")) {
                Game.instance.LoadedScene().HasShownLocDescript = false;
            } else if (choise.ToLower().Contains("open")) {
                for (int x = 0; x < gameObjects.Count; x++) {
                    if (choise.ToLower().Contains(gameObjects[x].Name.ToLower()) && gameObjects[x].Type.ToString().ToLower().Contains("door")) {
                        Door door = (Door)gameObjects[x].Type;
                        if (door.Open == false) {
                            door.Open = true;
                            Console.WriteLine("The door is now open");
                        } else {
                            Console.WriteLine("The door is already open");
                        }
                    }
                }
            } else if (choise.ToLower().Contains("enter")) {
                for (int x = 0; x < gameObjects.Count; x++) {
                    if (choise.ToLower().Contains(gameObjects[x].Name.ToLower()) && gameObjects[x].Type.ToString().ToLower().Contains("door")) {
                        gameObjects[x].Type.Action();
                    }
                }
            } else if (choise.ToLower().Contains("use")) {
                Console.WriteLine("Not implemented yet"); // this will be like use item on thing
                                                          // ex: use sword on goblin
            } else if (choise.ToLower().Contains("pickup") || choise.ToLower().Contains("take")) {   // pickup/take items
                for (int x = 0; x < gameObjects.Count; x++) {
                    if (choise.ToLower().Contains(gameObjects[x].Name.ToLower()) && gameObjects[x].Type.ToString().Contains("Item")) {
                        gameObjects[x].Type.Action();
                    }
                }
            } else if (choise.ToLower().Contains("clear")) {
                Console.Clear();
            } else if (choise.ToLower().Contains("inventory") || choise.ToLower().Contains("bag") || choise.ToLower().Contains("pouch")) {
                foreach (Item it in Game.playerInstance.Inventory) {
                    Console.WriteLine("Name: " + it.Name);
                    Console.WriteLine("Type: " + it.Type.ToString());
                    Console.WriteLine("_________________________________");
                }
            } else if (choise.ToLower().Contains("stats")) {
                Console.WriteLine(Game.playerInstance.PlayerInfo());
            } else if (choise.ToLower().Contains("debug")) {
                for (int x = 0; x < gameObjects.Count; x++) {
                    Console.WriteLine("[DEBUG]:" + gameObjects[x].Name);
                }
            } else {
                Console.WriteLine("I did not understand that");
            }

            return false;
        }
    }
}