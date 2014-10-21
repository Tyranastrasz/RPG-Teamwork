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
            this.CreateCharacter = new System.Windows.Forms.GroupBox();
            this.Btn_Rogue = new System.Windows.Forms.RadioButton();
            this.Btn_Mage = new System.Windows.Forms.RadioButton();
            this.Btn_Warrior = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.warriorPic1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.arrowRight = new System.Windows.Forms.PictureBox();
            this.arrowLeft = new System.Windows.Forms.PictureBox();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intelligenceProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.vitalityProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dexterityProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.strengthProgressBar = new System.Windows.Forms.ProgressBar();
            this.HeroDescription = new System.Windows.Forms.TextBox();
            this.CreateCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warriorPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).BeginInit();
            this.DescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.BackColor = System.Drawing.Color.Transparent;
            this.lblCharName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCharName.Font = new System.Drawing.Font("Impact", 12.25F);
            this.lblCharName.ForeColor = System.Drawing.Color.Black;
            this.lblCharName.Location = new System.Drawing.Point(226, 144);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(50, 21);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Name";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // inputCharName
            // 
            this.inputCharName.BackColor = System.Drawing.Color.Silver;
            this.inputCharName.Location = new System.Drawing.Point(180, 173);
            this.inputCharName.Name = "inputCharName";
            this.inputCharName.Size = new System.Drawing.Size(148, 20);
            this.inputCharName.TabIndex = 1;
            this.inputCharName.TextChanged += new System.EventHandler(this.inputCharName_TextChanged);
            // 
            // CreateCharacter
            // 
            this.CreateCharacter.BackColor = System.Drawing.Color.Black;
            this.CreateCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateCharacter.Controls.Add(this.Btn_Rogue);
            this.CreateCharacter.Controls.Add(this.Btn_Mage);
            this.CreateCharacter.Controls.Add(this.Btn_Warrior);
            this.CreateCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCharacter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CreateCharacter.Location = new System.Drawing.Point(97, 649);
            this.CreateCharacter.Name = "CreateCharacter";
            this.CreateCharacter.Size = new System.Drawing.Size(355, 59);
            this.CreateCharacter.TabIndex = 10;
            this.CreateCharacter.TabStop = false;
            this.CreateCharacter.Text = "Choose your Hero!";
            this.CreateCharacter.Enter += new System.EventHandler(this.CreateCharacter_Enter);
            // 
            // Btn_Rogue
            // 
            this.Btn_Rogue.AutoSize = true;
            this.Btn_Rogue.Location = new System.Drawing.Point(281, 24);
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
            this.Btn_Mage.Location = new System.Drawing.Point(158, 24);
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
            this.exit.Location = new System.Drawing.Point(882, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(61, 48);
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
            this.about.Location = new System.Drawing.Point(780, 659);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(165, 49);
            this.about.TabIndex = 2;
            this.about.Text = "Create Character";
            this.about.UseVisualStyleBackColor = false;
            // 
            // warriorPic1
            // 
            this.warriorPic1.BackColor = System.Drawing.Color.Transparent;
            this.warriorPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.warriorPic1.Image = ((System.Drawing.Image)(resources.GetObject("warriorPic1.Image")));
            this.warriorPic1.Location = new System.Drawing.Point(74, 216);
            this.warriorPic1.Name = "warriorPic1";
            this.warriorPic1.Size = new System.Drawing.Size(361, 282);
            this.warriorPic1.TabIndex = 6;
            this.warriorPic1.TabStop = false;
            this.warriorPic1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // arrowRight
            // 
            this.arrowRight.BackColor = System.Drawing.Color.Transparent;
            this.arrowRight.BackgroundImage = global::RpgGame.Properties.Resources.arrow_right;
            this.arrowRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowRight.Location = new System.Drawing.Point(478, 334);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(38, 50);
            this.arrowRight.TabIndex = 14;
            this.arrowRight.TabStop = false;
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // arrowLeft
            // 
            this.arrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.arrowLeft.BackgroundImage = global::RpgGame.Properties.Resources.arrow_left;
            this.arrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowLeft.Location = new System.Drawing.Point(31, 334);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(38, 50);
            this.arrowLeft.TabIndex = 15;
            this.arrowLeft.TabStop = false;
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionPanel.Controls.Add(this.label7);
            this.DescriptionPanel.Controls.Add(this.label6);
            this.DescriptionPanel.Controls.Add(this.label4);
            this.DescriptionPanel.Controls.Add(this.intelligenceProgressBar);
            this.DescriptionPanel.Controls.Add(this.label3);
            this.DescriptionPanel.Controls.Add(this.vitalityProgressBar);
            this.DescriptionPanel.Controls.Add(this.label2);
            this.DescriptionPanel.Controls.Add(this.dexterityProgressBar);
            this.DescriptionPanel.Controls.Add(this.label1);
            this.DescriptionPanel.Controls.Add(this.strengthProgressBar);
            this.DescriptionPanel.Controls.Add(this.HeroDescription);
            this.DescriptionPanel.Location = new System.Drawing.Point(586, 138);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(335, 455);
            this.DescriptionPanel.TabIndex = 16;
            this.DescriptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Impact", 15.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Warrior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(245, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Intelligence";
            // 
            // intelligenceProgressBar
            // 
            this.intelligenceProgressBar.BackColor = System.Drawing.Color.Gainsboro;
            this.intelligenceProgressBar.Location = new System.Drawing.Point(18, 175);
            this.intelligenceProgressBar.Name = "intelligenceProgressBar";
            this.intelligenceProgressBar.Size = new System.Drawing.Size(208, 16);
            this.intelligenceProgressBar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(245, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vitality";
            // 
            // vitalityProgressBar
            // 
            this.vitalityProgressBar.BackColor = System.Drawing.Color.Gainsboro;
            this.vitalityProgressBar.Location = new System.Drawing.Point(18, 137);
            this.vitalityProgressBar.Name = "vitalityProgressBar";
            this.vitalityProgressBar.Size = new System.Drawing.Size(208, 16);
            this.vitalityProgressBar.TabIndex = 5;
            this.vitalityProgressBar.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(245, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dexterity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dexterityProgressBar
            // 
            this.dexterityProgressBar.BackColor = System.Drawing.Color.Gainsboro;
            this.dexterityProgressBar.Location = new System.Drawing.Point(18, 100);
            this.dexterityProgressBar.Name = "dexterityProgressBar";
            this.dexterityProgressBar.Size = new System.Drawing.Size(208, 16);
            this.dexterityProgressBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(245, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Strenght";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // strengthProgressBar
            // 
            this.strengthProgressBar.BackColor = System.Drawing.Color.Gainsboro;
            this.strengthProgressBar.Location = new System.Drawing.Point(18, 64);
            this.strengthProgressBar.Name = "strengthProgressBar";
            this.strengthProgressBar.Size = new System.Drawing.Size(208, 16);
            this.strengthProgressBar.TabIndex = 1;
            // 
            // HeroDescription
            // 
            this.HeroDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.HeroDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeroDescription.Location = new System.Drawing.Point(18, 276);
            this.HeroDescription.Multiline = true;
            this.HeroDescription.Name = "HeroDescription";
            this.HeroDescription.Size = new System.Drawing.Size(298, 166);
            this.HeroDescription.TabIndex = 0;
            this.HeroDescription.Text = resources.GetString("HeroDescription.Text");
            this.HeroDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_char_creat_img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(972, 730);
            this.ControlBox = false;
            this.Controls.Add(this.DescriptionPanel);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.warriorPic1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.about);
            this.Controls.Add(this.inputCharName);
            this.Controls.Add(this.CreateCharacter);
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
            ((System.ComponentModel.ISupportInitialize)(this.warriorPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).EndInit();
            this.DescriptionPanel.ResumeLayout(false);
            this.DescriptionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox inputCharName;
        private System.Windows.Forms.PictureBox warriorPic1;
        private System.Windows.Forms.GroupBox CreateCharacter;
        private System.Windows.Forms.RadioButton Btn_Rogue;
        private System.Windows.Forms.RadioButton Btn_Mage;
        private System.Windows.Forms.RadioButton Btn_Warrior;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox arrowRight;
        private System.Windows.Forms.PictureBox arrowLeft;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.TextBox HeroDescription;
        private System.Windows.Forms.ProgressBar strengthProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar intelligenceProgressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar vitalityProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar dexterityProgressBar;
    }
}