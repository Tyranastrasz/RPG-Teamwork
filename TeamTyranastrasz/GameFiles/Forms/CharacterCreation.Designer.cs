namespace RpgGame.Forms
{
    partial class CharacterCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreation));
            this.lblCharName = new System.Windows.Forms.Label();
            this.inputCharName = new System.Windows.Forms.TextBox();
            this.tempReffBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.createChar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.CreateCharacter = new System.Windows.Forms.GroupBox();
            this.Btn_Rogue = new System.Windows.Forms.RadioButton();
            this.Btn_Mage = new System.Windows.Forms.RadioButton();
            this.Btn_Warrior = new System.Windows.Forms.RadioButton();
            this.startNewGame = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            this.DesignPanelUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.DesignPanelBottom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CreateCharacter.SuspendLayout();
            this.DesignPanelUp.SuspendLayout();
            this.DesignPanelBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(167, 18);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(82, 13);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Character name";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // inputCharName
            // 
            this.inputCharName.Location = new System.Drawing.Point(128, 34);
            this.inputCharName.Name = "inputCharName";
            this.inputCharName.Size = new System.Drawing.Size(170, 20);
            this.inputCharName.TabIndex = 1;
            this.inputCharName.TextChanged += new System.EventHandler(this.inputCharName_TextChanged);
            // 
            // tempReffBox1
            // 
            this.tempReffBox1.BackColor = System.Drawing.Color.Transparent;
            this.tempReffBox1.BackgroundImage = global::RpgGame.Properties.Resources.golem;
            this.tempReffBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempReffBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempReffBox1.Location = new System.Drawing.Point(41, 302);
            this.tempReffBox1.Name = "tempReffBox1";
            this.tempReffBox1.Size = new System.Drawing.Size(135, 199);
            this.tempReffBox1.TabIndex = 5;
            this.tempReffBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RpgGame.Properties.Resources.golem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(185, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 199);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::RpgGame.Properties.Resources.golem;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(326, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 199);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // createChar
            // 
            this.createChar.Location = new System.Drawing.Point(185, 540);
            this.createChar.Name = "createChar";
            this.createChar.Size = new System.Drawing.Size(135, 48);
            this.createChar.TabIndex = 8;
            this.createChar.Text = "Create Character";
            this.createChar.UseVisualStyleBackColor = true;
            this.createChar.Click += new System.EventHandler(this.createChar_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(891, 659);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 37);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // CreateCharacter
            // 
            this.CreateCharacter.Controls.Add(this.Btn_Rogue);
            this.CreateCharacter.Controls.Add(this.Btn_Mage);
            this.CreateCharacter.Controls.Add(this.Btn_Warrior);
            this.CreateCharacter.Location = new System.Drawing.Point(29, 79);
            this.CreateCharacter.Name = "CreateCharacter";
            this.CreateCharacter.Size = new System.Drawing.Size(384, 78);
            this.CreateCharacter.TabIndex = 10;
            this.CreateCharacter.TabStop = false;
            this.CreateCharacter.Text = "Choose your Hero!";
            this.CreateCharacter.Enter += new System.EventHandler(this.CreateCharacter_Enter);
            // 
            // Btn_Rogue
            // 
            this.Btn_Rogue.AutoSize = true;
            this.Btn_Rogue.Location = new System.Drawing.Point(283, 26);
            this.Btn_Rogue.Name = "Btn_Rogue";
            this.Btn_Rogue.Size = new System.Drawing.Size(57, 17);
            this.Btn_Rogue.TabIndex = 2;
            this.Btn_Rogue.TabStop = true;
            this.Btn_Rogue.Text = "Rogue";
            this.Btn_Rogue.UseVisualStyleBackColor = true;
            // 
            // Btn_Mage
            // 
            this.Btn_Mage.AutoSize = true;
            this.Btn_Mage.Location = new System.Drawing.Point(141, 24);
            this.Btn_Mage.Name = "Btn_Mage";
            this.Btn_Mage.Size = new System.Drawing.Size(52, 17);
            this.Btn_Mage.TabIndex = 1;
            this.Btn_Mage.TabStop = true;
            this.Btn_Mage.Text = "Mage";
            this.Btn_Mage.UseVisualStyleBackColor = true;
            // 
            // Btn_Warrior
            // 
            this.Btn_Warrior.AutoSize = true;
            this.Btn_Warrior.Location = new System.Drawing.Point(16, 24);
            this.Btn_Warrior.Name = "Btn_Warrior";
            this.Btn_Warrior.Size = new System.Drawing.Size(59, 17);
            this.Btn_Warrior.TabIndex = 0;
            this.Btn_Warrior.TabStop = true;
            this.Btn_Warrior.Text = "Warrior";
            this.Btn_Warrior.UseVisualStyleBackColor = true;
            // 
            // startNewGame
            // 
            this.startNewGame.BackColor = System.Drawing.Color.Transparent;
            this.startNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startNewGame.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.startNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.startNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.startNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startNewGame.Font = new System.Drawing.Font("Impact", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startNewGame.ForeColor = System.Drawing.Color.Transparent;
            this.startNewGame.Location = new System.Drawing.Point(38, 21);
            this.startNewGame.Name = "startNewGame";
            this.startNewGame.Size = new System.Drawing.Size(165, 48);
            this.startNewGame.TabIndex = 0;
            this.startNewGame.Text = "NEW GAME";
            this.startNewGame.UseVisualStyleBackColor = false;
            // 
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.Transparent;
            this.loadGame.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.loadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.loadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.loadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadGame.Font = new System.Drawing.Font("Impact", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadGame.ForeColor = System.Drawing.Color.Transparent;
            this.loadGame.Location = new System.Drawing.Point(263, 21);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(165, 48);
            this.loadGame.TabIndex = 1;
            this.loadGame.Text = "LOAD GAME";
            this.loadGame.UseVisualStyleBackColor = false;
            // 
            // DesignPanelUp
            // 
            this.DesignPanelUp.BackColor = System.Drawing.Color.Transparent;
            this.DesignPanelUp.Controls.Add(this.panel1);
            this.DesignPanelUp.Controls.Add(this.startNewGame);
            this.DesignPanelUp.Controls.Add(this.loadGame);
            this.DesignPanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.DesignPanelUp.Location = new System.Drawing.Point(0, 0);
            this.DesignPanelUp.Name = "DesignPanelUp";
            this.DesignPanelUp.Size = new System.Drawing.Size(1008, 95);
            this.DesignPanelUp.TabIndex = 12;
            this.DesignPanelUp.Paint += new System.Windows.Forms.PaintEventHandler(this.DesignPanelUp_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(8, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 93);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(796, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.about.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.ForeColor = System.Drawing.Color.Transparent;
            this.about.Location = new System.Drawing.Point(574, 16);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(165, 48);
            this.about.TabIndex = 2;
            this.about.Text = "ABOUT";
            this.about.UseVisualStyleBackColor = false;
            // 
            // DesignPanelBottom
            // 
            this.DesignPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.DesignPanelBottom.Controls.Add(this.panel3);
            this.DesignPanelBottom.Controls.Add(this.button1);
            this.DesignPanelBottom.Controls.Add(this.about);
            this.DesignPanelBottom.Location = new System.Drawing.Point(-8, 626);
            this.DesignPanelBottom.Name = "DesignPanelBottom";
            this.DesignPanelBottom.Size = new System.Drawing.Size(1024, 100);
            this.DesignPanelBottom.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(8, 641);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 93);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CreateCharacter);
            this.panel2.Controls.Add(this.inputCharName);
            this.panel2.Controls.Add(this.lblCharName);
            this.panel2.Location = new System.Drawing.Point(38, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 172);
            this.panel2.TabIndex = 13;
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_char_creat_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DesignPanelUp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tempReffBox1);
            this.Controls.Add(this.DesignPanelBottom);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.createChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CreateCharacter.ResumeLayout(false);
            this.CreateCharacter.PerformLayout();
            this.DesignPanelUp.ResumeLayout(false);
            this.DesignPanelBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox inputCharName;
        private System.Windows.Forms.PictureBox tempReffBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button createChar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox CreateCharacter;
        private System.Windows.Forms.RadioButton Btn_Rogue;
        private System.Windows.Forms.RadioButton Btn_Mage;
        private System.Windows.Forms.RadioButton Btn_Warrior;
        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Panel DesignPanelUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel DesignPanelBottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}