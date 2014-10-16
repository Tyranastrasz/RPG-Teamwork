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

            Warrior player = new Warrior("Pesho");
            var hitpoints = player.DefensePoints;
            Console.WriteLine();
        }
    }
}
