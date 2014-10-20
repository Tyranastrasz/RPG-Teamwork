namespace RpgGame
{
    using System;
    using System.Windows.Forms;
    using RpgGame.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Items;
    using RpgGame.Player;

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
            IItem boots = new Boots("Yellow boots", 200, 2, 5);
            IItem chainmail = new Chainmail("Dragonmail", 200, 2, 5);
            IItem secondChainmail = new Chainmail("Diablo's plate", 500, 5, 5);

            Type bootstype = boots.GetType();
            Type chainmailtype = chainmail.GetType();

            //if (secondChainmail.GetType() == chainmail.GetType())
            //{
            //    throw new Exception("You cannot have two items from the same type");
            //}

            //var hitpoints = player.DefencePoints;
            //Console.WriteLine();

            // start from the start screen

            GameEngine game = new GameEngine();
            game.Run();

            // start from the chae creation
            //Application.Run(new CharacterCreation());

            // start from the map
            //Application.Run(new Map());

            // start from the battle
            //Application.Run(new Battle());

            // start from the town
            //Application.Run(new Town());

            // start from the draw test
            //Application.Run(new BattleTest());

            // Application.Run(new StartScreen());
        }
    }
}
