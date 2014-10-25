using System.Security.AccessControl;

namespace RpgGame.Forms
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.battleTower = new System.Windows.Forms.PictureBox();
            this.secretPlace = new System.Windows.Forms.PictureBox();
            this.townSelected = new System.Windows.Forms.PictureBox();
            this.inventory = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Button();
            this.theChoosenOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.battleTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theChoosenOne)).BeginInit();
            this.SuspendLayout();
            // 
            // battleTower
            // 
            this.battleTower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.battleTower.Image = global::RpgGame.Properties.Resources.battle;
            this.battleTower.Location = new System.Drawing.Point(597, 386);
            this.battleTower.Name = "battleTower";
            this.battleTower.Size = new System.Drawing.Size(199, 202);
            this.battleTower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.battleTower.TabIndex = 7;
            this.battleTower.TabStop = false;
            this.battleTower.Visible = false;
            this.battleTower.WaitOnLoad = true;
            this.battleTower.Click += new System.EventHandler(this.battleTower_Click);
            // 
            // secretPlace
            // 
            this.secretPlace.BackColor = System.Drawing.Color.Transparent;
            this.secretPlace.Image = global::RpgGame.Properties.Resources.Stonehenge__Decoration__SW;
            this.secretPlace.Location = new System.Drawing.Point(860, 57);
            this.secretPlace.Name = "secretPlace";
            this.secretPlace.Size = new System.Drawing.Size(100, 50);
            this.secretPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secretPlace.TabIndex = 8;
            this.secretPlace.TabStop = false;
            this.secretPlace.Click += new System.EventHandler(this.secretPlace_Click);
            // 
            // townSelected
            // 
            this.townSelected.Image = global::RpgGame.Properties.Resources.town;
            this.townSelected.Location = new System.Drawing.Point(299, 0);
            this.townSelected.Name = "townSelected";
            this.townSelected.Size = new System.Drawing.Size(316, 132);
            this.townSelected.TabIndex = 9;
            this.townSelected.TabStop = false;
            this.townSelected.Visible = false;
            this.townSelected.Click += new System.EventHandler(this.townSelected_Click);
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.Transparent;
            this.inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventory.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory.Location = new System.Drawing.Point(287, 674);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(134, 49);
            this.inventory.TabIndex = 10;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Location = new System.Drawing.Point(840, 674);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(134, 48);
            this.exit.TabIndex = 11;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Transparent;
            this.load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.load.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.load.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.load.Location = new System.Drawing.Point(662, 674);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(134, 48);
            this.load.TabIndex = 12;
            this.load.Text = "LOAD";
            this.load.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.save.Location = new System.Drawing.Point(481, 674);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 48);
            this.save.TabIndex = 13;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.welcome.FlatAppearance.BorderSize = 0;
            this.welcome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.welcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(24, 12);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(212, 65);
            this.welcome.TabIndex = 23;
            this.welcome.UseVisualStyleBackColor = false;
            // 
            // theChoosenOne
            // 
            this.theChoosenOne.BackColor = System.Drawing.Color.Transparent;
            this.theChoosenOne.Location = new System.Drawing.Point(12, 83);
            this.theChoosenOne.Name = "theChoosenOne";
            this.theChoosenOne.Size = new System.Drawing.Size(237, 263);
            this.theChoosenOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.theChoosenOne.TabIndex = 24;
            this.theChoosenOne.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RpgGame.Properties.Resources.map_background_cropped;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1022, 766);
            this.ControlBox = false;
            this.Controls.Add(this.theChoosenOne);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.townSelected);
            this.Controls.Add(this.secretPlace);
            this.Controls.Add(this.battleTower);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Map_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.battleTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theChoosenOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox battleTower;
        private System.Windows.Forms.PictureBox secretPlace;
        private System.Windows.Forms.PictureBox townSelected;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button welcome;
        private System.Windows.Forms.PictureBox theChoosenOne;
    }
}

