using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using RpgGame.Exceptions;
using RpgGame.Interfaces;
using RpgGame.Player;

namespace RpgGame.SaveAndLoad
{
    public class Load
    {
        public static void LoadGame()
        {
            string playerClass = CheckPlayerClass();
            try
            {
                using (StreamReader file = new StreamReader(
                    "..\\..\\SaveAndLoad\\" + playerClass + "savegame.xml"))
                {
                    var saveGameContent = file.ReadToEnd();
                    var jsonSerializer = new JavaScriptSerializer();

                    CreatePlayerFromSavedGame(playerClass, jsonSerializer, saveGameContent);
                }
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Cannot load the file!");
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
            catch (InvalidCharacterTypeException)
            {
                MessageBox.Show("Cannot identify character type!");
            }
        }

        private static void CreatePlayerFromSavedGame(string playerClass, JavaScriptSerializer jsonSerializer,
            string saveGameContent)
        {
            if (playerClass == "Warrior")
            {
                SnapshotOfCharacter loadedCharacter = jsonSerializer.Deserialize<SnapshotOfCharacter>(saveGameContent);
                GameEngine.PlayerCharacter = new Warrior(
                    loadedCharacter.Name,
                    loadedCharacter.Strength,
                    loadedCharacter.Dexterity,
                    loadedCharacter.Vitality,
                    loadedCharacter.Intelligence,
                    loadedCharacter.MaxHitPoints,
                    loadedCharacter.Experience,
                    loadedCharacter.Cash,
                    loadedCharacter.Level,
                    loadedCharacter.Inventory,
                    loadedCharacter.Equiped,
                    loadedCharacter.Position
                    );
            }
            else if (playerClass == "Mage")
            {
                SnapshotOfCharacter loadedCharacter = jsonSerializer.Deserialize<SnapshotOfCharacter>(saveGameContent);
                GameEngine.PlayerCharacter = new Mage(
                    loadedCharacter.Name,
                    loadedCharacter.Strength,
                    loadedCharacter.Dexterity,
                    loadedCharacter.Vitality,
                    loadedCharacter.Intelligence,
                    loadedCharacter.MaxHitPoints,
                    loadedCharacter.Experience,
                    loadedCharacter.Cash,
                    loadedCharacter.Level,
                    loadedCharacter.Inventory,
                    loadedCharacter.Equiped,
                    loadedCharacter.Position
                    );
            }
            else if (playerClass == "Mage")
            {
                SnapshotOfCharacter loadedCharacter = jsonSerializer.Deserialize<SnapshotOfCharacter>(saveGameContent);
                GameEngine.PlayerCharacter = new Rogue(
                    loadedCharacter.Name,
                    loadedCharacter.Strength,
                    loadedCharacter.Dexterity,
                    loadedCharacter.Vitality,
                    loadedCharacter.Intelligence,
                    loadedCharacter.MaxHitPoints,
                    loadedCharacter.Experience,
                    loadedCharacter.Cash,
                    loadedCharacter.Level,
                    loadedCharacter.Inventory,
                    loadedCharacter.Equiped,
                    loadedCharacter.Position
                    );
            }
        }

        private static string CheckPlayerClass()
        {
            try
            {
                string[] filesInDirectory = Directory.GetFiles("..\\..\\SaveAndLoad\\");
                string playerClass = string.Empty;
                foreach (var file in filesInDirectory)
                {
                    if (file.Contains("warrior"))
                    {
                        playerClass = "Warrior";
                        break;
                    }
                    if (file.Contains("mage"))
                    {
                        playerClass = "Mage";
                        break;
                    }
                    if (file.Contains("rogue"))
                    {
                        playerClass = "Rogue";
                        break;
                    }
                }

                if (playerClass != string.Empty)
                {
                    return playerClass;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {

                throw new IOException();
            }
        }
    }
}
