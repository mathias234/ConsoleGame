using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Components;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main.Scenes {
    class Outside : IScene {
        public List<GameObject> GameObjects {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public bool HasShownLocDescript {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public void Run() {
            Console.WriteLine("We are outside!");
        }
    }
}
