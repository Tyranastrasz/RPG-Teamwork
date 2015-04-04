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
            var characterAsJson = JsonConvert.SerializeObject(currentPlayerState);
            string playerName = currentPlayerState.Name;
            Save.saveFileName = playerName + "save.json";

            try
            {
                Directory.CreateDirectory(Save.SaveDirectory);
                File.WriteAllText(Save.SaveDirectory + Save.saveFileName, characterAsJson);
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
        }
    }
}