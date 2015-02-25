using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Scenes {
    public interface IScene {
        void Run();
        // The neighbouring scenes which does not require a door to open such as scenes that you can walk to by road
        List<NeighbourScene> Neighbours { get; set; }
        List<GameObject> GameObjects { get; set; }
        bool HasShownLocDescript { get; set; }
    }
}
