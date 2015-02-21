using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInConsole.Main.Components {
    public class Player {
        string name;
        int health;
        int maxHealth;

        LookDirection lookDir;

        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
        public LookDirection LookDir { get { return lookDir; } set { lookDir = value; } }

    }

    public enum LookDirection {
        Forward,
        Backward,
        Left,
        Right,
    };
}
