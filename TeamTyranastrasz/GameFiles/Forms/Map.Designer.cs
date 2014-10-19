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
            this.battleStart = new System.Windows.Forms.Button();
            this.enterTown = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.quests = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battleStart
            // 
            this.battleStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.battleStart.Location = new System.Drawing.Point(700, 449);
            this.battleStart.Name = "battleStart";
            this.battleStart.Size = new System.Drawing.Size(75, 23);
            this.battleStart.TabIndex = 0;
            this.battleStart.Text = "Battle";
            this.battleStart.UseVisualStyleBackColor = true;
            this.battleStart.Click += new System.EventHandler(this.battleStart_Click);
            // 
            // enterTown
            // 
            this.enterTown.Cursor = System.Windows.Forms.Cursors.Default;
            this.enterTown.Location = new System.Drawing.Point(357, 167);
            this.enterTown.Name = "enterTown";
            this.enterTown.Size = new System.Drawing.Size(75, 23);
            this.enterTown.TabIndex = 1;
            this.enterTown.Text = "Town";
            this.enterTown.UseVisualStyleBackColor = true;
            this.enterTown.Click += new System.EventHandler(this.enterTown_Click);
            // 
            // inventory
            // 
            this.inventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.inventory.Location = new System.Drawing.Point(504, 12);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(75, 23);
            this.inventory.TabIndex = 2;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // quests
            // 
            this.quests.Cursor = System.Windows.Forms.Cursors.Default;
            this.quests.Location = new System.Drawing.Point(608, 12);
            this.quests.Name = "quests";
            this.quests.Size = new System.Drawing.Size(75, 23);
            this.quests.TabIndex = 3;
            this.quests.Text = "Quests";
            this.quests.UseVisualStyleBackColor = true;
            this.quests.Click += new System.EventHandler(this.quests_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Default;
            this.save.Location = new System.Drawing.Point(710, 12);
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
            this.load.Location = new System.Drawing.Point(811, 12);
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
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.quests);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.enterTown);
            this.Controls.Add(this.battleStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button battleStart;
        private System.Windows.Forms.Button enterTown;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button quests;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button quit;
    }
}

