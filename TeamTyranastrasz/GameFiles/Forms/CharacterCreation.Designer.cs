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
            this.createChar = new System.Windows.Forms.Button();
            this.CreateCharacter = new System.Windows.Forms.GroupBox();
            this.Btn_Rogue = new System.Windows.Forms.RadioButton();
            this.Btn_Mage = new System.Windows.Forms.RadioButton();
            this.Btn_Warrior = new System.Windows.Forms.RadioButton();
            this.startNewGame = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempReffBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CreateCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.BackColor = System.Drawing.Color.Transparent;
            this.lblCharName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCharName.Font = new System.Drawing.Font("Impact", 12.25F);
            this.lblCharName.Location = new System.Drawing.Point(211, 166);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(122, 21);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "character name";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // inputCharName
            // 
            this.inputCharName.BackColor = System.Drawing.Color.Silver;
            this.inputCharName.Location = new System.Drawing.Point(188, 190);
            this.inputCharName.Name = "inputCharName";
            this.inputCharName.Size = new System.Drawing.Size(170, 20);
            this.inputCharName.TabIndex = 1;
            this.inputCharName.TextChanged += new System.EventHandler(this.inputCharName_TextChanged);
            // 
            // createChar
            // 
            this.createChar.Font = new System.Drawing.Font("Impact", 12.25F);
            this.createChar.Location = new System.Drawing.Point(201, 569);
            this.createChar.Name = "createChar";
            this.createChar.Size = new System.Drawing.Size(148, 29);
            this.createChar.TabIndex = 8;
            this.createChar.Text = "Create Character";
            this.createChar.UseVisualStyleBackColor = true;
            this.createChar.Click += new System.EventHandler(this.createChar_Click);
            // 
            // CreateCharacter
            // 
            this.CreateCharacter.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateCharacter.Controls.Add(this.Btn_Rogue);
            this.CreateCharacter.Controls.Add(this.Btn_Mage);
            this.CreateCharacter.Controls.Add(this.Btn_Warrior);
            this.CreateCharacter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CreateCharacter.Location = new System.Drawing.Point(151, 504);
            this.CreateCharacter.Name = "CreateCharacter";
            this.CreateCharacter.Size = new System.Drawing.Size(262, 59);
            this.CreateCharacter.TabIndex = 10;
            this.CreateCharacter.TabStop = false;
            this.CreateCharacter.Text = "Choose your Hero!";
            this.CreateCharacter.Enter += new System.EventHandler(this.CreateCharacter_Enter);
            // 
            // Btn_Rogue
            // 
            this.Btn_Rogue.AutoSize = true;
            this.Btn_Rogue.Location = new System.Drawing.Point(191, 24);
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
            this.Btn_Mage.Location = new System.Drawing.Point(112, 24);
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
            this.Btn_Warrior.Location = new System.Drawing.Point(25, 24);
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
            this.startNewGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startNewGame.Location = new System.Drawing.Point(50, 20);
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
            this.loadGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loadGame.Location = new System.Drawing.Point(248, 20);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(165, 48);
            this.loadGame.TabIndex = 1;
            this.loadGame.Text = "LOAD GAME";
            this.loadGame.UseVisualStyleBackColor = false;
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
            this.exit.Location = new System.Drawing.Point(783, 663);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(165, 48);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.about.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.about.Location = new System.Drawing.Point(584, 662);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(165, 49);
            this.about.TabIndex = 2;
            this.about.Text = "ABOUT";
            this.about.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 282);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tempReffBox1
            // 
            this.tempReffBox1.BackColor = System.Drawing.Color.Transparent;
            this.tempReffBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempReffBox1.Location = new System.Drawing.Point(151, 231);
            this.tempReffBox1.Name = "tempReffBox1";
            this.tempReffBox1.Size = new System.Drawing.Size(262, 325);
            this.tempReffBox1.TabIndex = 5;
            this.tempReffBox1.TabStop = false;
            this.tempReffBox1.Click += new System.EventHandler(this.tempReffBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(151, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 340);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(176, 461);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_char_creat_img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(972, 730);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startNewGame);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.about);
            this.Controls.Add(this.inputCharName);
            this.Controls.Add(this.CreateCharacter);
            this.Controls.Add(this.tempReffBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.createChar);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            this.CreateCharacter.ResumeLayout(false);
            this.CreateCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox inputCharName;
        private System.Windows.Forms.PictureBox tempReffBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button createChar;
        private System.Windows.Forms.GroupBox CreateCharacter;
        private System.Windows.Forms.RadioButton Btn_Rogue;
        private System.Windows.Forms.RadioButton Btn_Mage;
        private System.Windows.Forms.RadioButton Btn_Warrior;
        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}