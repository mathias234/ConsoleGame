using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Scenes {
    class Outside : IScene {
        public void Run(Game game) {
            Console.WriteLine("We are outside!");
        }
    }
}
