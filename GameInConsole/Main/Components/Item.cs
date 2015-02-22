using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInConsole.Main.Components {
    public class Item {
        string name;
        ItemType type;

        public Item() {
            name = "NoName";
            type = ItemType.Junk;
        }

        public Item(string name, ItemType type) {
            this.name = name;
            this.type = type;
        }


        public string Name { get { return name; } set { name = value; } }
        public ItemType Type { get { return type; } set { type = value; } }

    }
    public enum ItemType {
        Weapon,
        Armour,
        Junk,
    }
}
