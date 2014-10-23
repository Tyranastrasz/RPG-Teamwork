namespace RpgGame.Forms
{
    partial class PlayerInventory
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
            this.welcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.welcome.FlatAppearance.BorderSize = 0;
            this.welcome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.welcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome.ForeColor = System.Drawing.Color.DarkRed;
            this.welcome.Location = new System.Drawing.Point(4, 1);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(35, 40);
            this.welcome.TabIndex = 24;
            this.welcome.Text = "X";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.welcome.UseVisualStyleBackColor = false;
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // PlayerInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::RpgGame.Properties.Resources.player_inventory;
            this.ClientSize = new System.Drawing.Size(364, 362);
            this.ControlBox = false;
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(200, 170);
            this.Name = "PlayerInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PlayerInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button welcome;

    }
}