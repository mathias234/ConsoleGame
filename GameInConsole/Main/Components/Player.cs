using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Scenes {
    public class Player {
        string name;
        int health;
        int maxHealth;

        List<Item> inventory = new List<Item>();

        LookDirection lookDir;

        public bool AddItemToInventory(Item item) {
            if (inventory.Count < 10) {
                inventory.Add(item);
                return true;
            } else {
                Console.WriteLine("Inventory is full");
                return false;
            }
        }

        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
        public List<Item> Inventory { get { return inventory; } }
        public LookDirection LookDir { get { return lookDir; } set { lookDir = value; } }
        /// <summary>
        /// Returns the players stats in a nicely formated string
        /// </summary>
        /// <returns></returns>
        public string PlayerInfo() {
            return "My name is " + name + ", I have " + health + " health out of " + MaxHealth + ". I am currently look towards " + lookDir.ToString();
        }

    }

    public enum LookDirection {
        North,
        South,
        West,
        East,
    };
}
