using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Components {
    public class ConsoleHelper {
        public static bool ReadChoise(string choise) {
            if (choise.ToLower() == "y" || choise.ToLower() == "yes" || choise.ToLower() == "ye") {
                return true;
            } else if (choise.ToLower() == "n" || choise.ToLower() == "no" || choise.ToLower() == "nope" || choise.ToLower() == "nah") {
                return false;
            } else if (choise.ToLower() == "forward") {
                Turn(LookDirection.Forward);
            } else if (choise.ToLower() == "backward") {
                Turn(LookDirection.Backward);
            } else if (choise.ToLower() == "left") {
                Turn(LookDirection.Left);
            } else if (choise.ToLower() == "right") {
                Turn(LookDirection.Right);
            }
            return false;
        }
        public static void Turn(LookDirection dir) {
            Game.instance.player.LookDir = dir;
        }
    }
}
