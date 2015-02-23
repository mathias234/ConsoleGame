﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main;
using GameInConsole.Main.Components;

namespace GameInConsole.Main.Scenes {
    public interface IScene {
        void Run();
        List<GameObject> GameObjects { get; set; }
        bool HasShownLocDescript { get; set; }

    }
}
