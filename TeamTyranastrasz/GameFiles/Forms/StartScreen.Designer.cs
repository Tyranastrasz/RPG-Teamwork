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
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.DesignPanelBottom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadGame = new System.Windows.Forms.Button();
            this.startNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DesignPanelUp = new System.Windows.Forms.Panel();
            this.DesignPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DesignPanelUp.SuspendLayout();
            this.SuspendLayout();
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
            this.about.Location = new System.Drawing.Point(588, 16);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(165, 48);
            this.about.TabIndex = 2;
            this.about.Text = "ABOUT";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
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
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(796, 16);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(165, 48);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // DesignPanelBottom
            // 
            this.DesignPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.DesignPanelBottom.Controls.Add(this.panel3);
            this.DesignPanelBottom.Controls.Add(this.exit);
            this.DesignPanelBottom.Controls.Add(this.about);
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
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.Transparent;
            this.loadGame.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.loadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.loadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.loadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadGame.Font = new System.Drawing.Font("Impact", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadGame.ForeColor = System.Drawing.Color.Transparent;
            this.loadGame.Location = new System.Drawing.Point(246, 21);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(165, 48);
            this.loadGame.TabIndex = 1;
            this.loadGame.Text = "LOAD GAME";
            this.loadGame.UseVisualStyleBackColor = false;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(8, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 93);
            this.panel1.TabIndex = 5;
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
            this.DesignPanelUp.Size = new System.Drawing.Size(976, 95);
            this.DesignPanelUp.TabIndex = 10;
            this.DesignPanelUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StartScreen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.main_start_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(976, 698);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DesignPanelBottom);
            this.Controls.Add(this.DesignPanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.DesignPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DesignPanelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel DesignPanelBottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DesignPanelUp;
    }
}