using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInConsole.Main.Components {
    public class ConsoleHelper {
        public static bool ReadChoise(string choise) {
            if (choise.ToLower() == "y" || choise.ToLower() == "yes" || choise.ToLower() == "ye") {
                return true;
            } else if (choise.ToLower() == "n" || choise.ToLower() == "no" || choise.ToLower() == "nope" || choise.ToLower() ==  "nah" ) {
                return false;
            }
            return false;
        }
    }
}
