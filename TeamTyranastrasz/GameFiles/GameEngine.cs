namespace RpgGame
{
    using RpgGame.Interfaces;
    using RpgGame.Player;
    using System;

    public class GameEngine
    {
        public static ICharacter player;
        public static void CreateNewPlayer(string characterClass, string characterName)
        {
            switch (characterClass)
            {
                case "warrior":
                    player = new Warrior(characterName);
                    break;
                case "mage":
                    player = new Mage(characterName);
                    break;
                case "rogue":
                    player = new Rogue(characterName);
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
