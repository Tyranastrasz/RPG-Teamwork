namespace RpgGame.SaveAndLoad
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Interfaces;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Save
    {
        private const string SaveDirectory = "../../SaveAndLoad/";
        private static string saveFileName;

        public static void SaveGame()
        {
            ICharacter currentPlayerState = GameEngine.PlayerCharacter;
            var jsObject = JsonConvert.SerializeObject(currentPlayerState);
            var result = JObject.Parse(jsObject);
            string playerName = currentPlayerState.Name;
            Save.saveFileName = playerName + "save.json";

            try
            {
                Directory.CreateDirectory(Save.SaveDirectory);
                File.WriteAllText(Save.SaveDirectory + Save.saveFileName, jsObject);
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permissions to write to the specific file location!");
                }
            catch (IOException)
            {
                throw new IOException("Cannot write to file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }

            //    try
            //    {
            //        Directory.CreateDirectory(Save.SaveDirectory);
            //        using (StreamWriter firstFile = new StreamWriter(
            //            Save.SaveDirectory + currentPlayerClass + "savegame.txt"))
            //        using (StreamWriter secondFile = new StreamWriter(
            //            Save.SaveDirectory + currentPlayerClass + "saveinventory.txt"))
            //        using (StreamWriter thirdFile = new StreamWriter(
            //            Save.SaveDirectory + currentPlayerClass + "saveequipeditems.txt"))
            //        {
            //            firstFile.Write(savedData);

            //            foreach (var item in currentPlayerState.Inventory)
            //            {
            //                Save.WriteItemToFile(item, secondFile);
            //            }

            //            foreach (var item in currentPlayerState.Equiped)
            //            {
            //                Save.WriteItemToFile(item, thirdFile);
            //            }

            //            MessageBox.Show("Your game progress was saved!");
            //        }
            //    }
            //    catch (DirectoryNotFoundException)
            //    {
            //        throw new DirectoryNotFoundException("The path to the file is incorrect!");
            //    }
            //    catch (IOException)
            //    {
            //        throw new IOException("Cannot write to file!");
            //    }
            //    catch (InvalidOperationException)
            //    {
            //        throw new InvalidOperationException();
            //    }
            //}

            //private static string CheckCurrentPlayerClass(ICharacter currentPlayerState)
            //{
            //    string currentPlayerClass = String.Empty;
            //    if (currentPlayerState.GetType() == typeof (Warrior))
            //    {
            //        currentPlayerClass = "warrior";
            //    }
            //    else if (currentPlayerState.GetType() == typeof (Mage))
            //    {
            //        currentPlayerClass = "mage";
            //    }
            //    else if (currentPlayerState.GetType() == typeof (Rogue))
            //    {
            //        currentPlayerClass = "rogue";
            //    }
            //    return currentPlayerClass;
            //}
        }
    }
}