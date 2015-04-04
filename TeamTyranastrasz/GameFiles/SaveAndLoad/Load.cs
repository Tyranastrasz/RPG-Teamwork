namespace RpgGame.SaveAndLoad
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    using Forms;
    using Interfaces;
    using Items;
    using Newtonsoft.Json;
    using Player;

    public class Load
    {
        private const string FolderPath = "../../SaveAndLoad/";

        public static void LoadGame()
        {
            try
            {
                Directory.CreateDirectory(Load.FolderPath);

                // TODO: Make a window pop up and choose a savegame.
                string[] files = Directory.GetFiles(Load.FolderPath, "*.json");

                if (files.Length != 0)
                {
                    var loadedGame = File.ReadAllText(files[0]);
                    var charachterAsJson = JsonConvert.DeserializeObject(loadedGame);
                    var snapshot = JsonConvert.DeserializeObject<SnapshotOfCharacter>(loadedGame);
                    ICharacter loadedCharacter = Load.CreatePlayerFromSavedGame(snapshot);
                    loadedCharacter.Inventory = new List<IItem>();
                    loadedCharacter.Equiped = new List<IItem>();

                    Load.RecreateItems(loadedCharacter.Inventory, loadedCharacter.Equiped, charachterAsJson);

                    GameEngine.PlayerCharacter = loadedCharacter;
                    GameEngine.Inventory = new PlayerInventory();
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Cannot load the file!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The path to the file is incorrect!");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permissions to write to the specific file location!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
            catch (InvalidCharacterTypeException)
            {
                MessageBox.Show("Cannot identify character type!");
            }
            catch (InvalidItemTypeException)
            {
                MessageBox.Show("Cannot identify item type!");
            }
        }

        private static void RecreateItems(IList<IItem> inventory, IList<IItem> equiped, dynamic jsObject)
        {
            foreach (var item in jsObject["Inventory"])
            {
                LoadItems(inventory, item);
            }

            foreach (var item in jsObject["Equiped"])
            {
                LoadItems(equiped, item);
            }
        }

        private static void LoadItems(IList<IItem> items, dynamic item)
        {
            string name = item["Name"];
            int price = Convert.ToInt32((item["Price"]));
            Pictures picture = (Pictures) Convert.ToInt32(item["Picture"]);
            int defPoints = Convert.ToInt32(item["DefencePoints"]);
            int attackPoints = Convert.ToInt32(item["AttackPoints"]);
            int hitPoints = Convert.ToInt32(item["HitPoints"]);
            int strength = Convert.ToInt32(item["Strength"]);
            int dexterity = Convert.ToInt32(item["Dexterity"]);
            int vitality = Convert.ToInt32(item["Vitality"]);
            int intelligence = Convert.ToInt32(item["Intelligence"]);
            int lvlReq = Convert.ToInt32(item["levelRequirement"]);
            string descr = item["Description"];
            ItemType itemType = (ItemType) Convert.ToInt32(item["ItemType"]);

            switch (itemType)
            {
                case ItemType.Chainmail:
                    items.Add(new Chainmail(name, price, picture, defPoints, attackPoints, hitPoints, strength,
                        dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                case ItemType.Boots:
                    items.Add(new Boots(name, price, picture, defPoints, attackPoints, hitPoints, strength, dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                case ItemType.Gloves:
                    items.Add(new Gloves(name, price, picture, defPoints, attackPoints, hitPoints, strength, dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                case ItemType.Helmet:
                    items.Add(new Helmet(name, price, picture, defPoints, attackPoints, hitPoints, strength, dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                case ItemType.Potion:
                    items.Add(new Potion(name, price, picture, defPoints, attackPoints, hitPoints, strength, dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                case ItemType.Scroll:
                    items.Add(new Scroll(name, price, picture, defPoints, attackPoints, hitPoints, strength, dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                case ItemType.Weapon:
                    items.Add(new Weapon(name, price, picture, defPoints, attackPoints, hitPoints, strength, dexterity,
                        vitality, intelligence, lvlReq, descr));
                    break;
                default:
                    throw new InvalidItemTypeException();
            }

            if (item["ItemType"] == 0)
            {
            }
            else if (item["ItemType"] == 1)
            {
            }
            else if (item["ItemType"] == 2)
            {
            }
            else if (item["ItemType"] == 3)
            {
            }
            else if (item["ItemType"] == 4)
            {
            }
            else if (item["ItemType"] == 5)
            {
            }
            else if (item["ItemType"] == 6)
            {
            }
        }

        private static ICharacter CreatePlayerFromSavedGame(SnapshotOfCharacter snapshot)
        {
            ICharacter character;
            switch (snapshot.CharacterType)
            {
                case CharacterType.Mage:
                    return character = new Mage(
                        snapshot.Name,
                        snapshot.Strength,
                        snapshot.Dexterity,
                        snapshot.Vitality,
                        snapshot.Intelligence,
                        snapshot.MaxHitPoints,
                        snapshot.Experience,
                        snapshot.Cash,
                        snapshot.Level,
                        snapshot.Position);
                case CharacterType.Rogue:
                    return character = new Rogue(
                        snapshot.Name,
                        snapshot.Strength,
                        snapshot.Dexterity,
                        snapshot.Vitality,
                        snapshot.Intelligence,
                        snapshot.MaxHitPoints,
                        snapshot.Experience,
                        snapshot.Cash,
                        snapshot.Level,
                        snapshot.Position);
                case CharacterType.Warrior:
                    return character = new Warrior(
                        snapshot.Name,
                        snapshot.Strength,
                        snapshot.Dexterity,
                        snapshot.Vitality,
                        snapshot.Intelligence,
                        snapshot.MaxHitPoints,
                        snapshot.Experience,
                        snapshot.Cash,
                        snapshot.Level,
                        snapshot.Position);
                default:
                    throw new InvalidCharacterTypeException();
            }
        }
    }
}