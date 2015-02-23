using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components;

namespace GameInConsole.Main {
    public class Game {
        Player player;
        IScene currentScene;

        public static Game instance;
        public static Player playerInstance;

        public string gameTitle = "a game";

        public void Start() {
            Console.Title = gameTitle;
            InitializePlayer();
            playerInstance = player;
            instance = this;
           // LoadScene(new WelcomeScreen());
            LoadScene(new HouseScene());

            // so the console wont exit
            Console.ReadLine();
        }
        void InitializePlayer() {
            player = new Player();
            player.MaxHealth = 100;
            player.Health = player.MaxHealth;
            player.LookDir = LookDirection.North;
        }

        public void LoadScene(IScene scene) {
            Console.Clear();
            currentScene = scene;
            scene.Run();
        }
        public IScene LoadedScene() {
            return currentScene;
        }
    }
}
