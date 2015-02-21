using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Scenes {
    public class HouseScene : IScene {
        public void Run(Game game) {
            while (true) {
                Player p = game.player;
                if (p.LookDir == LookDirection.Forward) {
                    Console.WriteLine("You can see a big white door");
                    string choise = Console.ReadLine();
                }

            }
        }
    }
}
