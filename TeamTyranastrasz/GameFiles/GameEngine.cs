namespace RpgGame
{
    using System;
    using System.Windows.Forms;
    using RpgGame.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Player;

    public class GameEngine
    {
        public static ICharacter PlayerCharacter { get; set; }
        public static Battle BattleScreen { get; set; }
        public static PlayerInventory Inventory { get; set; }
        public static Map Map { get; set; }

        public void Run()
        {
            Application.Run(new StartScreen());
            //CreateNewPlayer("warrior", "asd");
            //CreateBattleScreen();
            //Application.Run(new Map());
        }

        public static void CreateNewPlayer(string characterClass, string characterName)
        {
            switch (characterClass)
            {
                case "warrior":
                    PlayerCharacter = new Warrior(characterName);
                    break;
                case "mage":
                    PlayerCharacter = new Mage(characterName);
                    break;
                case "rogue":
                    PlayerCharacter = new Rogue(characterName);
                    break;
                default:
                    throw new InvalidOperationException("Something went terribly terribly wrong!");
            }
        }

        public static void CreateBattleScreen()
        {
            BattleScreen = new Battle();
            BattleScreen.Show();
            Sound.PlayBattleSound();
        }
    }
}
