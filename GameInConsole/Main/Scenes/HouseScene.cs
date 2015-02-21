using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GameInConsole.Main.Scene;

namespace GameInConsole.Main.Scenes {
    public class HouseScene : IScene {
        public void Run(Game game) {
            while (game.LoadedScene() == this) {
                Player p = game.player;
                if (p.LookDir == LookDirection.Forward) {
                    Console.WriteLine("You can see a big white door");
                } else if (p.LookDir == LookDirection.Backward) {
                    Console.WriteLine("You see nothing interesting");
                } else if (p.LookDir == LookDirection.Right) {
                    Console.WriteLine("You see nothing interesting");
                } else if (p.LookDir == LookDirection.Left) {
                    Console.WriteLine("You see nothing interesting");
                }

                string choise = Console.ReadLine();

                if (p.LookDir == LookDirection.Forward && ConsoleHelper.ReadChoise(choise) == true) {
                    game.LoadScene(new Outdoor());
                }

                ConsoleHelper.ReadChoise(choise);

            }
        }
    }
}
