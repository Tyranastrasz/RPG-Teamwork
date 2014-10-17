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

            ICharacter player = new Warrior("Pesho");

            IItem helm = new Helmet("Wizard hat", 200, 2, 5);

            var hitpoints = player.DefencePoints;
            Console.WriteLine();
        }
    }
}
