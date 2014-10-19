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
            this.btnWarrSelect = new System.Windows.Forms.Button();
            this.btnMageSelect = new System.Windows.Forms.Button();
            this.btnRogueSelect = new System.Windows.Forms.Button();
            this.tempReffBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.createChar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempReffBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // btnWarrSelect
            // 
            this.btnWarrSelect.Location = new System.Drawing.Point(340, 318);
            this.btnWarrSelect.Name = "btnWarrSelect";
            this.btnWarrSelect.Size = new System.Drawing.Size(135, 38);
            this.btnWarrSelect.TabIndex = 2;
            this.btnWarrSelect.Text = "Warrior";
            this.btnWarrSelect.UseVisualStyleBackColor = true;
            this.btnWarrSelect.Click += new System.EventHandler(this.btnWarrSelect_Click);
            // 
            // btnMageSelect
            // 
            this.btnMageSelect.Location = new System.Drawing.Point(498, 318);
            this.btnMageSelect.Name = "btnMageSelect";
            this.btnMageSelect.Size = new System.Drawing.Size(135, 38);
            this.btnMageSelect.TabIndex = 3;
            this.btnMageSelect.Text = "Mage";
            this.btnMageSelect.UseVisualStyleBackColor = true;
            // 
            // btnRogueSelect
            // 
            this.btnRogueSelect.Location = new System.Drawing.Point(659, 318);
            this.btnRogueSelect.Name = "btnRogueSelect";
            this.btnRogueSelect.Size = new System.Drawing.Size(135, 38);
            this.btnRogueSelect.TabIndex = 4;
            this.btnRogueSelect.Text = "Rogue";
            this.btnRogueSelect.UseVisualStyleBackColor = true;
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
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_char_creat_img;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.createChar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tempReffBox1);
            this.Controls.Add(this.btnRogueSelect);
            this.Controls.Add(this.btnMageSelect);
            this.Controls.Add(this.btnWarrSelect);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox inputCharName;
        private System.Windows.Forms.Button btnWarrSelect;
        private System.Windows.Forms.Button btnMageSelect;
        private System.Windows.Forms.Button btnRogueSelect;
        private System.Windows.Forms.PictureBox tempReffBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button createChar;
        private System.Windows.Forms.Button exit;
    }
}