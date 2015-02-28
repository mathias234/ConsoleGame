using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInConsole.Main.Scenes;
using GameInConsole.Main.Components;
using System.Timers;

namespace GameInConsole.Main {
    public class Game {
        Player player;

        IScene currentScene;

        float score;

        StartMode startMode;

        public static Game instance;

        public static Player playerInstance;

        public string gameTitle = "a game";

        public Game(string[] args) {
            if (args.Length > 0) {
                foreach (string arg in args) {
                    switch (arg) {
                        case "-debug":
                            startMode = StartMode.debug;
                            break;
                    }
                }
            }
            Start();
        }


        public void Start() {
            InitializePlayer();
            StartUpdater();
            playerInstance = player;
            instance = this;
            LoadScene(new WelcomeScreen());
            LoadScene(new HouseScene());

            // so the console wont exit
            Console.ReadLine();
        }

        void InitializePlayer() {
            player = new Player();
            player.MaxHealth = 100;
            player.Health = player.MaxHealth;
            player.Name = "Need Name";
        }

        void StartUpdater() {
            Timer timer = new Timer(15);
            timer.Start();
            timer.Elapsed += UpdateGameTitle;
        }


        // should never write to the Console it will spam it
        private void UpdateGameTitle(object source, ElapsedEventArgs e) {
            Console.Title = "Name: " + player.Name + " Health: " + player.Health + "            Score: " + GetScore().ToString() + "                    startmode = " + startMode.ToString();
        }

        public void LoadScene(IScene scene) {
            Console.Clear();
            currentScene = scene;
            scene.Run();
        }
        public IScene LoadedScene() {
            return currentScene;
        }
        public void AddScore(float value) {
            score += value;
        }
        public void RemoveScore(float value) {
            score -= value;
        }
        public float GetScore() {
            return score;
        }
    }
    enum StartMode {
        normal,
        debug
    }
}
