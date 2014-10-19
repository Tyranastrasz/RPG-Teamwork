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
            this.lblCharName = new System.Windows.Forms.Label();
            this.inputCharName = new System.Windows.Forms.TextBox();
            this.tempReffBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.createChar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.CreateCharacter = new System.Windows.Forms.GroupBox();
            this.Btn_Warrior = new System.Windows.Forms.RadioButton();
            this.Btn_Mage = new System.Windows.Forms.RadioButton();
            this.Btn_Rogue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CreateCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(505, 233);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(82, 13);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Character name";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // inputCharName
            // 
            this.inputCharName.Location = new System.Drawing.Point(498, 260);
            this.inputCharName.Name = "inputCharName";
            this.inputCharName.Size = new System.Drawing.Size(100, 20);
            this.inputCharName.TabIndex = 1;
            this.inputCharName.TextChanged += new System.EventHandler(this.inputCharName_TextChanged);
            // 
            // tempReffBox1
            // 
            this.tempReffBox1.BackgroundImage = global::RpgGame.Properties.Resources.golem;
            this.tempReffBox1.Location = new System.Drawing.Point(340, 388);
            this.tempReffBox1.Name = "tempReffBox1";
            this.tempReffBox1.Size = new System.Drawing.Size(135, 199);
            this.tempReffBox1.TabIndex = 5;
            this.tempReffBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RpgGame.Properties.Resources.golem;
            this.pictureBox1.Location = new System.Drawing.Point(498, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 199);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RpgGame.Properties.Resources.golem;
            this.pictureBox2.Location = new System.Drawing.Point(659, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 199);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // createChar
            // 
            this.createChar.Location = new System.Drawing.Point(508, 619);
            this.createChar.Name = "createChar";
            this.createChar.Size = new System.Drawing.Size(107, 48);
            this.createChar.TabIndex = 8;
            this.createChar.Text = "Create Character";
            this.createChar.UseVisualStyleBackColor = true;
            this.createChar.Click += new System.EventHandler(this.createChar_Click);
            // 
            // exit
            // 
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
            this.CreateCharacter.Location = new System.Drawing.Point(357, 308);
            this.CreateCharacter.Name = "CreateCharacter";
            this.CreateCharacter.Size = new System.Drawing.Size(398, 58);
            this.CreateCharacter.TabIndex = 10;
            this.CreateCharacter.TabStop = false;
            this.CreateCharacter.Text = "Choose your Hero!";
            this.CreateCharacter.Enter += new System.EventHandler(this.CreateCharacter_Enter);
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
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_char_creat_img;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.CreateCharacter);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.createChar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tempReffBox1);
            this.Controls.Add(this.inputCharName);
            this.Controls.Add(this.lblCharName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CharacterCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterCreation";
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CreateCharacter.ResumeLayout(false);
            this.CreateCharacter.PerformLayout();
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
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox CreateCharacter;
        private System.Windows.Forms.RadioButton Btn_Rogue;
        private System.Windows.Forms.RadioButton Btn_Mage;
        private System.Windows.Forms.RadioButton Btn_Warrior;
    }
}