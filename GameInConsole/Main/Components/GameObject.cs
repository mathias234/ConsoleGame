using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Components {
    public class GameObject {
        string name;
        string text;
        LookDirection lookDir;
        IGameObject type;
        bool interactable;

        public GameObject() {
            this.name = "NoName";
            this.lookDir = LookDirection.Forward;
            this.type = null;
            this.interactable = false;
            this.text = "a";
        }

        public GameObject(string name, string text, LookDirection lookDir, IGameObject type, bool interactable) {
            this.name = name;
            this.text = text;
            this.lookDir = lookDir;
            this.interactable = interactable;
            this.type = type;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Text { get { return text; } set { text = value; } }
        public LookDirection LookDir { get { return lookDir; } set { lookDir = value; } }
        public IGameObject Type { get { return type; } set { type = value; } }
        public bool Interactable { get { return interactable; } set { interactable = value; } }
    }
}
