using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Components.Objects {
    public class Door : IGameObject {
        bool open;
        IScene scene;
        public Door(bool open, IScene scene) {
            this.Scene = scene;
            this.Open = open;
        }

        public bool Open {
            get { return open; }
            set { open = value; }
        }

        public IScene Scene {
            get { return scene; }
            set { scene = value; }
        }

        public void Action() {
            if (Open == true)
                Game.instance.LoadScene(Scene);
            else
                Console.WriteLine("Door is closed");
        }
    }
}
