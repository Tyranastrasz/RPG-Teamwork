namespace RpgGame.Forms
{
    partial class Town
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Town));
            this.exit = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.backToMap = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(921, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 37);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Location = new System.Drawing.Point(170, 384);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(190, 182);
            this.btnShop.TabIndex = 11;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            this.btnShop.MouseEnter += new System.EventHandler(this.btnShop_MouseEnter);
            this.btnShop.MouseLeave += new System.EventHandler(this.btnShop_MouseLeave);
            // 
            // backToMap
            // 
            this.backToMap.Location = new System.Drawing.Point(828, 13);
            this.backToMap.Name = "backToMap";
            this.backToMap.Size = new System.Drawing.Size(75, 36);
            this.backToMap.TabIndex = 12;
            this.backToMap.Text = "Map";
            this.backToMap.UseVisualStyleBackColor = true;
            this.backToMap.Click += new System.EventHandler(this.backToMap_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(350, 445);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(149, 121);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(475, 300);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(146, 139);
            this.loadBtn.TabIndex = 14;
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            this.loadBtn.MouseEnter += new System.EventHandler(this.loadBtn_MouseEnter);
            this.loadBtn.MouseLeave += new System.EventHandler(this.loadBtn_MouseLeave);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Location = new System.Drawing.Point(585, 218);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(50, 41);
            this.inventoryBtn.TabIndex = 15;
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            this.inventoryBtn.MouseEnter += new System.EventHandler(this.inventoryBtn_MouseEnter);
            this.inventoryBtn.MouseLeave += new System.EventHandler(this.inventoryBtn_MouseLeave);
            // 
            // Town
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.town_map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.ControlBox = false;
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.backToMap);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Town";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Town";
            this.Load += new System.EventHandler(this.Town_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button backToMap;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button inventoryBtn;
    }
}