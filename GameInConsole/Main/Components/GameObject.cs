using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Components {
    public class GameObject {
        string name;
        IGameObject type;
        bool interactable;

        public GameObject() {
            this.name = "NoName";
            this.type = null;
            this.interactable = false;
        }

        public GameObject(string name, IGameObject type, bool interactable) {
            this.name = name;
            this.interactable = interactable;
            this.type = type;
        }

        public string Name { get { return name; } set { name = value; } }
        public IGameObject Type { get { return type; } set { type = value; } }
        public bool Interactable { get { return interactable; } set { interactable = value; } }
    }
}
