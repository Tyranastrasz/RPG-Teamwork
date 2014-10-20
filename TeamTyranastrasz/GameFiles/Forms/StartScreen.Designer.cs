namespace RpgGame.Forms
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.loadGame = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.DesignPanelUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DesignPanelBottom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.startNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DesignPanelUp.SuspendLayout();
            this.DesignPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.Transparent;
            this.loadGame.Font = new System.Drawing.Font("Impact", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadGame.ForeColor = System.Drawing.Color.Black;
            this.loadGame.Location = new System.Drawing.Point(67, 275);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(176, 37);
            this.loadGame.TabIndex = 1;
            this.loadGame.Text = "LOAD GAME";
            this.loadGame.UseVisualStyleBackColor = false;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.Location = new System.Drawing.Point(67, 402);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(176, 37);
            this.about.TabIndex = 2;
            this.about.Text = "ABOUT";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Location = new System.Drawing.Point(79, 35);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(176, 37);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // DesignPanelUp
            // 
            this.DesignPanelUp.BackColor = System.Drawing.Color.Transparent;
            this.DesignPanelUp.Controls.Add(this.panel1);
            this.DesignPanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.DesignPanelUp.Location = new System.Drawing.Point(0, 0);
            this.DesignPanelUp.Name = "DesignPanelUp";
            this.DesignPanelUp.Size = new System.Drawing.Size(984, 100);
            this.DesignPanelUp.TabIndex = 10;
            this.DesignPanelUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(8, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 93);
            this.panel1.TabIndex = 5;
            // 
            // DesignPanelBottom
            // 
            this.DesignPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.DesignPanelBottom.Controls.Add(this.panel3);
            this.DesignPanelBottom.Controls.Add(this.exit);
            this.DesignPanelBottom.Location = new System.Drawing.Point(-12, 622);
            this.DesignPanelBottom.Name = "DesignPanelBottom";
            this.DesignPanelBottom.Size = new System.Drawing.Size(1024, 100);
            this.DesignPanelBottom.TabIndex = 5;
            this.DesignPanelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.DesignPanelBottom_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(8, 641);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 93);
            this.panel3.TabIndex = 5;
            // 
            // startNewGame
            // 
            this.startNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startNewGame.BackColor = System.Drawing.Color.Transparent;
            this.startNewGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.startNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startNewGame.Font = new System.Drawing.Font("Impact", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startNewGame.ForeColor = System.Drawing.Color.Black;
            this.startNewGame.Location = new System.Drawing.Point(67, 163);
            this.startNewGame.Name = "startNewGame";
            this.startNewGame.Size = new System.Drawing.Size(176, 37);
            this.startNewGame.TabIndex = 0;
            this.startNewGame.Text = "NEW GAME";
            this.startNewGame.UseVisualStyleBackColor = false;
            this.startNewGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RpgGame.Properties.Resources.flying_dragon_animated_image_zpsa0010db9;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(755, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 163);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // StartScreen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_char_creat_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(984, 706);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DesignPanelBottom);
            this.Controls.Add(this.startNewGame);
            this.Controls.Add(this.about);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.DesignPanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.DesignPanelUp.ResumeLayout(false);
            this.DesignPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel DesignPanelUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DesignPanelBottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}