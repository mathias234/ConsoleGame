using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInConsole.Main.Scenes {
    public class NeighbourScene {
        NeighbourRot neighbourRotation;
        IScene scene;

        public NeighbourScene(IScene scene, NeighbourRot neighbourRotation) {
            this.neighbourRotation = neighbourRotation;
            this.scene = scene;
        }
        

        public IScene Scene {
            get { return scene; }
            set { scene = value; }
        }

        public NeighbourRot NeighbourRotation {
            get { return neighbourRotation; }
            set { neighbourRotation = value; }
        }
    }
    public enum NeighbourRot {
        North,
        South,
        West,
        East,
    };
}
