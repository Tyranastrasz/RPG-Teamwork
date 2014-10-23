namespace RpgGame.SaveAndLoad
{
    using System;
    using System.IO;
    using System.Web.Script.Serialization;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using RpgGame.Player;
    using RpgGame.Interfaces;
    using RpgGame.Items;

    public class Load
    {
        public static void LoadGame()
        {
            string playerClass = CheckPlayerClass();
            try
            {
                using (StreamReader firstFile = new StreamReader(
                    "..\\..\\SaveAndLoad\\" + playerClass + "savegame.txt"))
                using (StreamReader secondFile = new StreamReader(
                    "..\\..\\SaveAndLoad\\" + playerClass + "saveinventory.txt"))
                using (StreamReader thirdFile = new StreamReader(
                    "..\\..\\SaveAndLoad\\" + playerClass + "saveequipeditems.txt"))
                {
                    var saveGameContent = firstFile.ReadToEnd();
                    //var jsonSerializer = new JavaScriptSerializer();
                    CreatePlayerFromSavedGame(playerClass, saveGameContent);
                    List<IItem> loadedInventory = new List<IItem>();
                    List<IItem> loadedEquipedItems = new List<IItem>();

                    RecreateItems(secondFile, loadedInventory);
                    RecreateItems(thirdFile, loadedEquipedItems);

                    GameEngine.PlayerCharacter.Inventory = loadedInventory;
                    GameEngine.PlayerCharacter.Equiped = loadedEquipedItems;
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

        private static void RecreateItems(StreamReader file, List<IItem> items)
        {
            string currentLine;
            while ((currentLine = file.ReadLine()) != null)
            {
                // name, price, picture, def, attk, hit, str, dex, vit, int, lvl, desc
                string[] lineSplitted = currentLine.Split(' ');

                LoadItems(lineSplitted, items);
            }
        }

        private static void LoadItems(string[] lineSplitted, List<IItem> items)
        {
            string name;
            int price;
            Pictures picture;
            int def;
            int attk;
            int hit;
            int str;
            int dex;
            int vit;
            int intl;
            int lvl;
            string desc;

            switch (lineSplitted[0])
            {
                case "Helmet":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Helmet(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                case "Chainmail":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Chainmail(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                case "Gloves":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Gloves(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                case "Weapon":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Weapon(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                case "Boots":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Boots(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                case "Potion":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Potion(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                case "Scroll":
                    name = lineSplitted[1];
                    price = int.Parse(lineSplitted[2]);
                    picture = (Pictures) Enum.Parse(typeof (Pictures), lineSplitted[3]);
                    def = int.Parse(lineSplitted[4]);
                    attk = int.Parse(lineSplitted[5]);
                    hit = int.Parse(lineSplitted[6]);
                    str = int.Parse(lineSplitted[7]);
                    dex = int.Parse(lineSplitted[8]);
                    vit = int.Parse(lineSplitted[9]);
                    intl = int.Parse(lineSplitted[10]);
                    lvl = int.Parse(lineSplitted[11]);
                    desc = "Testing";

                    items.Add(new Scroll(name, price, picture, def, attk, hit, str, dex, vit, intl, lvl, desc));
                    break;
                default:
                    throw new Exception();
            }
        }

        private static void CreatePlayerFromSavedGame(string playerClass, 
            string saveGameContent)
        {
            if (playerClass == "Warrior")
            {
                SnapshotOfCharacter loadedCharacter = new JavaScriptSerializer().Deserialize<SnapshotOfCharacter>(saveGameContent);
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
                    loadedCharacter.Position);
            }
            else if (playerClass == "Mage")
            {
                SnapshotOfCharacter loadedCharacter = new JavaScriptSerializer().Deserialize<SnapshotOfCharacter>(saveGameContent);
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
                    loadedCharacter.Position);
            }
            else if (playerClass == "Mage")
            {
                SnapshotOfCharacter loadedCharacter = new JavaScriptSerializer().Deserialize<SnapshotOfCharacter>(saveGameContent);
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
                    loadedCharacter.Position);
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
