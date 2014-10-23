namespace RpgGame
{
    using System;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameEngine game = new GameEngine();
            game.Run();
        }
    }
}
