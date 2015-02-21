using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main;

namespace GameInConsole.Main.Scene {
    public interface IScene {
        void Run(Game game);
    }
}
