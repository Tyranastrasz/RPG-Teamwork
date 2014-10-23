using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGame.Interfaces;
using RpgGame.Items;

namespace RpgGame.Forms
{
    public partial class ShopInventory : Form
    {
        public List<IItem> inventory = GameEngine.PlayerCharacter.Inventory;
        public List<IItem> shopItems = new List<IItem>(); 
        
        public List<Position> shopItemsPossitions = new List<Position>();
        public List<Position> inventoryPossitions = new List<Position>();

        public List<PictureBox> shopItemsPics = new List<PictureBox>();
        public List<PictureBox> inventoryPics = new List<PictureBox>();

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

            this.shopItems.Add(new Weapon("Big Sword", 100, Pictures.Sword, 0, 40, 0, 0, 10, 0, 0, 8, "Big sword for heavy strikes."));
            this.shopItems.Add(new Weapon("Iron Sword", 5, Pictures.Sword, 0, 5, 0, 0, 0, 0, 0, 1, "Basic battle equipment."));
            this.shopItems.Add(new Helmet("Iron-horn Helm", 20, Pictures.Helmet, 2, 0, 3, 0, 0, 1, 0, 1, "Basic - but stylis."));
            this.shopItems.Add(new Gloves("Fighter Gloves", 15, Pictures.Gloves, 1, 0, 2, 0, 1, 0, 0, 1, "Good for melee characters."));
            this.shopItems.Add(new Boots("Armored Boots", 10, Pictures.Boots, 1, 1, 0, 0, 0, 1, 0, 1, "Heavy and slow."));
            this.shopItems.Add(new Chainmail("Chainmail", 25, Pictures.Chainmail, 2, 0, 0, 0, 1, 1, 0, 1, "Chainmail armor mekas you more agile."));
            this.shopItems.Add(new Potion("Small Health Potion", 20, Pictures.HealingPotion, 0, 0, 0, 0, 0, 0, 0, 1, "Return + 10hp"));
            this.shopItems.Add(new Scroll("Teleport Scroll", 0, Pictures.Scroll, 0, 0, 0, 0, 0, 0, 0, 1, "Use to teleport to location."));

            this.shopItems.Add(new Weapon("Big Sword", 100, Pictures.Sword, 0, 40, 0, 0, 10, 0, 0, 8, "Big sword for heavy strikes."));
            this.shopItems.Add(new Weapon("Iron Sword", 5, Pictures.Sword, 0, 5, 0, 0, 0, 0, 0, 1, "Basic battle equipment."));
            this.shopItems.Add(new Helmet("Iron-horn Helm", 20, Pictures.Helmet, 2, 0, 3, 0, 0, 1, 0, 1, "Basic - but stylis."));
            this.shopItems.Add(new Gloves("Fighter Gloves", 15, Pictures.Gloves, 1, 0, 2, 0, 1, 0, 0, 1, "Good for melee characters."));
            this.shopItems.Add(new Boots("Armored Boots", 10, Pictures.Boots, 1, 1, 0, 0, 0, 1, 0, 1, "Heavy and slow."));
            this.shopItems.Add(new Chainmail("Chainmail", 25, Pictures.Chainmail, 2, 0, 0, 0, 1, 1, 0, 1, "Chainmail armor mekas you more agile."));
            this.shopItems.Add(new Potion("Small Health Potion", 20, Pictures.HealingPotion, 0, 0, 0, 0, 0, 0, 0, 1, "Return + 10hp"));
            this.shopItems.Add(new Scroll("Teleport Scroll", 0, Pictures.Scroll, 0, 0, 0, 0, 0, 0, 0, 1, "Use to teleport to location."));

            this.shopItems.Add(new Weapon("Big Sword", 100, Pictures.Sword, 0, 40, 0, 0, 10, 0, 0, 8, "Big sword for heavy strikes."));
            this.shopItems.Add(new Weapon("Iron Sword", 5, Pictures.Sword, 0, 5, 0, 0, 0, 0, 0, 1, "Basic battle equipment."));
            this.shopItems.Add(new Helmet("Iron-horn Helm", 20, Pictures.Helmet, 2, 0, 3, 0, 0, 1, 0, 1, "Basic - but stylis."));
            this.shopItems.Add(new Gloves("Fighter Gloves", 15, Pictures.Gloves, 1, 0, 2, 0, 1, 0, 0, 1, "Good for melee characters."));
            this.shopItems.Add(new Boots("Armored Boots", 10, Pictures.Boots, 1, 1, 0, 0, 0, 1, 0, 1, "Heavy and slow."));
            this.shopItems.Add(new Chainmail("Chainmail", 25, Pictures.Chainmail, 2, 0, 0, 0, 1, 1, 0, 1, "Chainmail armor mekas you more agile."));
            this.shopItems.Add(new Potion("Small Health Potion", 20, Pictures.HealingPotion, 0, 0, 0, 0, 0, 0, 0, 1, "Return + 10hp"));
            this.shopItems.Add(new Scroll("Teleport Scroll", 0, Pictures.Scroll, 0, 0, 0, 0, 0, 0, 0, 1, "Use to teleport to location."));

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

            statsBox.Text = GetItemType(item)
                        + "\nStr: " + item.Strength
                        + "\nInt: " + item.Intelligence
                        + "\nDex: " + item.Dexterity
                        + "\nVit: " + item.Vitality
                        + "\nAttack: " + item.AttackPoints
                        + "\nDefence: " + item.DefencePoints
                        + "\nHP: " + item.HitPoints
                        + "\nProce: " + item.Price
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
                DrawImages(pic, item, getImage(item), inventoryPossitions[counter], "inventory-" + counter);
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
                DrawImages(pic, item, getImage(item), shopItemsPossitions[counter], "shop-" + counter);
                counter++;
            }
        }

        private void RefreshGold()
        {
            this.goldBox.Text = GameEngine.PlayerCharacter.Cash.ToString();
        }

        private Image getImage(IItem item)
        {
            switch (item.Picture)
            {
                case Pictures.HealingPotion:
                    return Properties.Resources.healing_potion;
                //case Pictures.Staff:
                //    return Properties.Resources.staff
                //case Pictures.Sword:
                //    return Properties.Resources.sword;
                //case Pictures.Helmet:
                //    return Properties.Resources.helmet;
                //case Pictures.Chainmail:
                //    return Properties.Resources.chainmail;
                //case Pictures.Gloves:
                //    return Properties.Resources.gloves;
                //case Pictures.Axe:
                //    return Properties.Resources.axe;
                //case Pictures.Scroll:
                //    return Properties.Resources.scroll;
                //case Pictures.Boots:
                //    return Properties.Resources.boots;
                case Pictures.TestItem1:
                    return Properties.Resources.head_mage;
                case Pictures.TestItem2:
                    return Properties.Resources.head_rogue;
                default:
                    return Properties.Resources.healing_potion;
                //throw new NoPictureException();
            }
        }

        private static string GetItemType(IItem item)
        {
            string[] itemMeta = item.ToString().Split('.');
            return itemMeta[itemMeta.Length - 1];
        }

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
            this.Close();
        }
    }
}
