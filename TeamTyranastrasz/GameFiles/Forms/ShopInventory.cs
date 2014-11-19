namespace RpgGame.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Items;

    public partial class ShopInventory : Form
    {
        public IList<IItem> inventory = GameEngine.PlayerCharacter.Inventory;
        public IList<IItem> shopItems = new List<IItem>(); 
        
        public IList<Position> shopItemsPossitions = new List<Position>();
        public IList<Position> inventoryPossitions = new List<Position>();

        public IList<PictureBox> shopItemsPics = new List<PictureBox>();
        public IList<PictureBox> inventoryPics = new List<PictureBox>();

        private Label statsBox;

        public ShopInventory()
        {
            InitializeComponent();

            this.shopItemsPossitions.Add(new Position(12, 40));
            this.shopItemsPossitions.Add(new Position(82, 40));
            this.shopItemsPossitions.Add(new Position(152, 40));
            this.shopItemsPossitions.Add(new Position(222, 40));
            this.shopItemsPossitions.Add(new Position(292, 40));
            this.shopItemsPossitions.Add(new Position(12, 110));
            this.shopItemsPossitions.Add(new Position(82, 110));
            this.shopItemsPossitions.Add(new Position(152, 110));
            this.shopItemsPossitions.Add(new Position(222, 110));
            this.shopItemsPossitions.Add(new Position(292, 110));
            this.shopItemsPossitions.Add(new Position(12, 180));
            this.shopItemsPossitions.Add(new Position(82, 180));
            this.shopItemsPossitions.Add(new Position(152, 180));
            this.shopItemsPossitions.Add(new Position(222, 180));
            this.shopItemsPossitions.Add(new Position(292, 180));
            this.shopItemsPossitions.Add(new Position(12, 250));
            this.shopItemsPossitions.Add(new Position(82, 250));
            this.shopItemsPossitions.Add(new Position(152, 250));
            this.shopItemsPossitions.Add(new Position(222, 250));
            this.shopItemsPossitions.Add(new Position(292, 250));
            this.shopItemsPossitions.Add(new Position(12, 320));
            this.shopItemsPossitions.Add(new Position(82, 320));
            this.shopItemsPossitions.Add(new Position(152, 320));
            this.shopItemsPossitions.Add(new Position(222, 320));
            this.shopItemsPossitions.Add(new Position(292, 320));

            this.inventoryPossitions.Add(new Position(378, 40));
            this.inventoryPossitions.Add(new Position(448, 40));
            this.inventoryPossitions.Add(new Position(378, 110));
            this.inventoryPossitions.Add(new Position(448, 110));
            this.inventoryPossitions.Add(new Position(378, 180));
            this.inventoryPossitions.Add(new Position(448, 180));
            this.inventoryPossitions.Add(new Position(378, 250));
            this.inventoryPossitions.Add(new Position(448, 250));
            this.inventoryPossitions.Add(new Position(378, 320));
            this.inventoryPossitions.Add(new Position(448, 320));

            //name, price, picture, def, attk, hit, str, dex, vit, int, lvl
            this.shopItems.Add(new Weapon("Lightnig Dagger", 45, Pictures.RareDager, 0, 5, 0, 0, 0, 0, 10, 4, "This dagger is created for mage users."));
            this.shopItems.Add(new Weapon("Big Sword", 100, Pictures.RareSword, 0, 22, 0, 0, 10, 0, 0, 8, "Big sword for heavy strikes."));
            this.shopItems.Add(new Weapon("Iron Sword", 5, Pictures.BasickSword, 0, 7, 0, 1, 0, 0, 0, 2, "Basic battle equipment."));
            this.shopItems.Add(new Helmet("Iron-horn Helm", 20, Pictures.WarriorHelmet, 2, 0, 3, 1, 0, 1, 0, 3, "Basic - but stylish."));
            this.shopItems.Add(new Gloves("Fighter Gloves", 15, Pictures.WarriorsGloves, 1, 2, 1, 0, 1, 0, 0, 1, "Good for melee characters."));
            this.shopItems.Add(new Boots("Armored Boots", 10, Pictures.WarriorBoots, 2, 2, 0, 0, 0, 1, 0, 2, "Heavy and slow."));
            this.shopItems.Add(new Chainmail("Chainmail", 25, Pictures.WarriorChainmail, 2, 0, 0, 0, 1, 1, 0, 1, "Chainmail armor makes you more agile."));
            this.shopItems.Add(new Potion("Small Health Potion", 20, Pictures.HealingPotion, 0, 0, 0, 0, 0, 0, 0, 1, "Return + 10hp"));
            this.shopItems.Add(new Scroll("Teleport Scroll", 0, Pictures.Scroll, 0, 0, 0, 0, 0, 0, 0, 1, "Use to teleport to location."));

            this.shopItems.Add(new Weapon("Stone Axe", 35, Pictures.BasickAxe, 0, 7, 0, 0, 3, 0, 0, 4, "Made from solid granit."));
            this.shopItems.Add(new Weapon("Golden Staff", 75, Pictures.RareStaff, 0, 1, 0, 0, 0, 2, 4, 5, "Powered by the sun."));
            this.shopItems.Add(new Helmet("Wizards Hat", 50, Pictures.MageHelmet, 2, 0, 1, 0, 0, 1, 2, 3, "No wizard go out without his hat."));
            this.shopItems.Add(new Gloves("Assassin Gloves", 15, Pictures.RogueGLoves, 1, 0, 3, 0, 1, 0, 1, 3, "Deadly in the right hands."));
            this.shopItems.Add(new Boots("Golden Sandals", 170, Pictures.RogueBoots, 1, 1, 1, 1, 1, 1, 1, 1, "One hell of a quality item."));
            this.shopItems.Add(new Chainmail("Wool Robe", 25, Pictures.MageChainmail, 2, 0, 0, 0, 2, 1, 0, 1, "Your best friend in cold winter nights."));

            this.shopItems.Add(new Weapon("Sacura Staff", 45, Pictures.MidStaff, 0, 7, 0, 0, 0, 1, 2, 4, "Eastern mistery."));
            this.shopItems.Add(new Weapon("Colibri", 55, Pictures.MidDager, 0, 8, 0, 1, 0, 0, 0, 2, "Dual strike - very fast"));

            statsBox = new Label();
            statsBox.Width = 104;
            statsBox.Height = 140;
            statsBox.BackColor = Color.Black;
            statsBox.ForeColor = Color.White;
            statsBox.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            statsBox.TextAlign = ContentAlignment.TopCenter;
            statsBox.BackColor = Color.FromArgb(150, 0, 0, 0);
            Controls.Add(statsBox);
            statsBox.Hide();
        }

        private void ShopInventory_Load(object sender, EventArgs e)
        {
            DrawShopItems();
            DrawInventoryItems();
            RefreshGold();
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            statsBox.Hide();
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            string[] picMeta = p.Name.Split('-');
            string type = picMeta[0];
            int id = int.Parse(picMeta[1]);

            if (type == "inventory")
            {
                RefreshStatsBox(inventory[id], inventoryPossitions[id]);
                if (id >= 6)
                {
                    statsBox.Top = inventoryPossitions[id].Y - statsBox.Height;
                }
                else
                {
                    statsBox.Top = inventoryPossitions[id].Y + 60;
                }
            }
            else if (type == "shop")
            {
                RefreshStatsBox(shopItems[id], shopItemsPossitions[id]);
                if (id >= 15)
                {
                    statsBox.Top = shopItemsPossitions[id].Y - statsBox.Height;
                }
                else
                {
                    statsBox.Top = shopItemsPossitions[id].Y + 60;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            string[] picMeta = p.Name.Split('-');
            string type = picMeta[0];
            int id = int.Parse(picMeta[1]);

            if (type == "inventory")
            {
                GameEngine.PlayerCharacter.Sell(inventory[id]);
            }
            else if (type == "shop")
            {
                GameEngine.PlayerCharacter.Buy(shopItems[id]);
            }

            inventory = GameEngine.PlayerCharacter.Inventory;

            ClearInventoryItems();
            DrawInventoryItems();
            RefreshGold();
        }

        private void RefreshStatsBox(IItem item, Position pos)
        {
            statsBox.Left = pos.X - 20;
            statsBox.Show();

            statsBox.Text = item.Name
                        + "\nStr: " + item.Strength
                        + "\nInt: " + item.Intelligence
                        + "\nDex: " + item.Dexterity
                        + "\nVit: " + item.Vitality
                        + "\nAttack: " + item.AttackPoints
                        + "\nDefence: " + item.DefencePoints
                        + "\nHP: " + item.HitPoints
                        + "\nPrice: " + item.Price
                        + "\nReq. Level: " + item.LevelRequirement;
        }

        private void DrawImages(PictureBox pictureBox, IItem item, Image image, Position position, string id)
        {
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Left = position.X;
            pictureBox.Top = position.Y;
            pictureBox.Click += PictureBox_Click;
            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseLeave += PictureBox_MouseLeave;
            pictureBox.Name = id;
            this.Controls.Add(pictureBox);
        }

        private void DrawInventoryItems()
        {
            int counter = 0;
            foreach (IItem item in GameEngine.PlayerCharacter.Inventory)
            {
                PictureBox pic = new PictureBox();
                inventoryPics.Add(pic);
                DrawImages(pic, item, GetImage(item), inventoryPossitions[counter], "inventory-" + counter);
                counter++;
            }
        }

        private void ClearInventoryItems()
        {
            foreach (PictureBox pic in inventoryPics)
            {
                this.Controls.Remove(pic);
            }

            inventoryPics = new List<PictureBox>();
        }

        private void DrawShopItems()
        {
            int counter = 0;
            foreach (IItem item in this.shopItems)
            {
                PictureBox pic = new PictureBox();
                shopItemsPics.Add(pic);
                DrawImages(pic, item, GetImage(item), shopItemsPossitions[counter], "shop-" + counter);
                counter++;
            }
        }

        private void RefreshGold()
        {
            this.goldBox.Text = GameEngine.PlayerCharacter.Cash.ToString();
        }

        private Image GetImage(IItem item)
        {
            switch (item.Picture)
            {
                case Pictures.HealingPotion:
                    return Properties.Resources.healing_potion;
                case Pictures.Scroll:
                    return Properties.Resources.teleport_scroll;
                case Pictures.WarriorHelmet:
                    return Properties.Resources.head_warrior;
                case Pictures.MageHelmet:
                    return Properties.Resources.head_mage;
                case Pictures.RogueHelmet:
                    return Properties.Resources.head_rogue;
                case Pictures.WarriorChainmail:
                    return Properties.Resources.chaimail_warrior;
                case Pictures.MageChainmail:
                    return Properties.Resources.chaimail_mage;
                case Pictures.RogueChainmail:
                    return Properties.Resources.chaimail_rogue;
                case Pictures.WarriorsGloves:
                    return Properties.Resources.gloves_warrior;
                case Pictures.MageGloves:
                    return Properties.Resources.gloves_mage;
                case Pictures.RogueGLoves:
                    return Properties.Resources.gloves_rogue;
                case Pictures.WarriorBoots:
                    return Properties.Resources.boots_warrior;
                case Pictures.MageBoots:
                    return Properties.Resources.boots_mage;
                case Pictures.RogueBoots:
                    return Properties.Resources.boots_rogue;
                case Pictures.BasickStaff:
                    return Properties.Resources.weapon_staff_basic;
                case Pictures.MidStaff:
                    return Properties.Resources.weapon_staff_mid;
                case Pictures.RareStaff:
                    return Properties.Resources.weapon_staff_rare;
                case Pictures.BasickSword:
                    return Properties.Resources.weapon_sword_basic;
                case Pictures.MidSword:
                    return Properties.Resources.weapon_sword_mid;
                case Pictures.RareSword:
                    return Properties.Resources.weapon_sword_rare;
                case Pictures.BasickAxe:
                    return Properties.Resources.weapon_axe_basic;
                case Pictures.MidAxe:
                    return Properties.Resources.weapon_axe_mid;
                case Pictures.RareAxe:
                    return Properties.Resources.weapon_axe_rare;
                case Pictures.BasickDager:
                    return Properties.Resources.weapon_dager_basic;
                case Pictures.MidDager:
                    return Properties.Resources.weapon_dager_mid;
                case Pictures.RareDager:
                    return Properties.Resources.weapon_dager_rare;
                default:
                    return Properties.Resources.healing_potion;
                //throw new NoPictureException();
            }
        }

        private static string GetItemType(IItem item)
        {
            string type = item.GetType().ToString();
            string[] itemMeta = type.Split('.');
            return itemMeta[itemMeta.Length - 1];
        }

        // This code reduces the flickering when loading the forms.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {

            GameEngine.Inventory = new PlayerInventory();

            GameEngine.Inventory.inventory = this.inventory;

            //PlayerInventory.inventory = this.inventory;
            //GameEngine.Inventory.inventory = this.inventory;
            //PlayerInventory.SynchronizeItems(this.inventory);
            this.Close();
        }
    }
}
