using System.Collections.Generic;

namespace RpgGame.SaveAndLoad
{
    using System;
    using System.IO;
    using System.Web.Script.Serialization;
    using System.Windows.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Player;

    public class Save
    {
        public static void SaveGame()
        {
            ICharacter currentPlayerState = GameEngine.PlayerCharacter;
            SnapshotOfCharacter saveSnapshotOfCharacter = new SnapshotOfCharacter(currentPlayerState);
            saveSnapshotOfCharacter.Inventory = new List<IItem>();
            saveSnapshotOfCharacter.Equiped = new List<IItem>();
            var jsonSerializer = new JavaScriptSerializer();
            var savedData = jsonSerializer.Serialize(saveSnapshotOfCharacter);
            string currentPlayerClass = CheckCurrentPlayerClass(currentPlayerState);

            try
            {
                using (StreamWriter file = new StreamWriter(
                "..\\..\\SaveAndLoad\\" + currentPlayerClass + "savegame.json"))
                {
                    file.Write(savedData);
                    MessageBox.Show("Your game progress was saved!");
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot write to file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        private static string CheckCurrentPlayerClass(ICharacter currentPlayerState)
        {
            string currentPlayerClass = String.Empty;
            if (currentPlayerState.GetType() == typeof(Warrior))
            {
                currentPlayerClass = "warrior";
            }
            else if (currentPlayerState.GetType() == typeof(Mage))
            {
                currentPlayerClass = "mage";
            }
            else if (currentPlayerState.GetType() == typeof(Rogue))
            {
                currentPlayerClass = "rogue";
            }
            return currentPlayerClass;
        }
    }
}
