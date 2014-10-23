namespace RpgGame.SaveAndLoad
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
    using System.Windows.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Player;
    using RpgGame.Items;

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
                using (StreamWriter firstFile = new StreamWriter(
                "..\\..\\SaveAndLoad\\" + currentPlayerClass + "savegame.txt"))
                using (StreamWriter secondFile = new StreamWriter(
                "..\\..\\SaveAndLoad\\" + currentPlayerClass + "saveinventory.txt"))
                using (StreamWriter thirdFile = new StreamWriter(
                "..\\..\\SaveAndLoad\\" + currentPlayerClass + "saveequipeditems.txt"))
                {
                    firstFile.Write(savedData);

                    foreach (var item in currentPlayerState.Inventory)
                    {
                        WriteItemToFile(item, secondFile);
                    }

                    foreach (var item in currentPlayerState.Equiped)
                    {
                        WriteItemToFile(item, thirdFile);
                    }

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

        private static void WriteItemToFile(IItem item, StreamWriter file)
        {
            if (item.GetType() == typeof (Helmet))
            {
                file.Write("Helmet ");
                file.Write(item.ToString());
            }
            if (item.GetType() == typeof (Chainmail))
            {
                file.Write("Chainmail ");
                file.Write(item.ToString());
            }
            if (item.GetType() == typeof (Gloves))
            {
                file.Write("Gloves ");
                file.Write(item.ToString());
            }
            if (item.GetType() == typeof (Weapon))
            {
                file.Write("Weapon ");
                file.Write(item.ToString());
            }
            if (item.GetType() == typeof (Boots))
            {
                file.Write("Boots ");
                file.Write(item.ToString());
            }
            if (item.GetType() == typeof (Potion))
            {
                file.Write("Potion ");
                file.Write(item.ToString());
            }
            if (item.GetType() == typeof (Scroll))
            {
                file.Write("Scroll ");
                file.Write(item.ToString());
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
