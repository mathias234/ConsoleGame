using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;

namespace GameInConsole.Main {
    public class Game {
        public Player player;
        IScene currentScene;

        public static Game instance;


        public void Start() {
            InitializePlayer();
            instance = this;
            //LoadScene(new WelcomeScreen());

            // Now we are finished with the starting stuff

            // This is the initial scene
            LoadScene(new HouseScene());
             

            Console.ReadLine();
        }
        void InitializePlayer() {
            player = new Player();
            player.MaxHealth = 100;
            player.LookDir = LookDirection.Forward;
        }

        public void LoadScene(IScene scene) {
            Console.Clear();
            currentScene = scene;
            scene.Run(this);
        }
        public IScene LoadedScene() {
            return currentScene;
        }
    }
}
