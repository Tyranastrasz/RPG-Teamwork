using RpgGame.Forms;
using RpgGame.Forms.TestDraw;
using RpgGame.Interfaces;
using RpgGame.Items;

namespace RpgGame
{
    using RpgGame.Player;
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //ICharacter player = new Warrior("Pesho");

            //IItem helm = new Helmet("Wizard hat", 200, 2, 5);

            //var hitpoints = player.DefencePoints;
            //Console.WriteLine();

            // start from the start screen
            Application.Run(new StartScreen());

            // start from the chae creation
            //Application.Run(new CharacterCreation());

            // start from the map
            //Application.Run(new Map());

            // start from the battle
            //Application.Run(new Battle());

            // start from the town
            //Application.Run(new Town());

            // start from the draw test
            // Application.Run(new BattleTest());
        }
    }
}
