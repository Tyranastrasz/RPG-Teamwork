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
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.battleTower = new System.Windows.Forms.PictureBox();
            this.secretPlace = new System.Windows.Forms.PictureBox();
            this.townSelected = new System.Windows.Forms.PictureBox();
            this.inventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.battleTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Default;
            this.save.Location = new System.Drawing.Point(284, 674);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Cursor = System.Windows.Forms.Cursors.Default;
            this.load.Location = new System.Drawing.Point(396, 674);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 5;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // quit
            // 
            this.quit.Cursor = System.Windows.Forms.Cursors.Default;
            this.quit.Location = new System.Drawing.Point(921, 12);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 6;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
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
            this.inventory.Location = new System.Drawing.Point(48, 57);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(165, 49);
            this.inventory.TabIndex = 10;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
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
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.townSelected);
            this.Controls.Add(this.secretPlace);
            this.Controls.Add(this.battleTower);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.PictureBox battleTower;
        private System.Windows.Forms.PictureBox secretPlace;
        private System.Windows.Forms.PictureBox townSelected;
        private System.Windows.Forms.Button inventory;
    }
}

