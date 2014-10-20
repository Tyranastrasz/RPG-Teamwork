namespace RpgGame
{
    using System;
    using System.Windows.Forms;
    using RpgGame.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Player;

    public class GameEngine
    {
        public static ICharacter playerCharacter;

        public static ICharacter PlayerCharacter { get; set; }

        public void Run()
        {
            Application.Run(new StartScreen());
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

        private void GenerateEnemies()
        {
        }

        private void CalculateBattleOutcome()
        {
        }

        private void SaveGame()
        {
        }

        private void LoadGame()
        {
        }
    }
}
