using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Components.Objects {
    public class Door : IGameObject {
        IScene scene;
        public Door(IScene scene) {
            this.scene = scene;
        }
        public void Action() {
            Game.instance.LoadScene(scene);
        }
    }
}
