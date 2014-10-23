namespace RpgGame.Forms
{
    partial class Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAttackSkillLow = new System.Windows.Forms.Button();
            this.btnAttackSkillMed = new System.Windows.Forms.Button();
            this.btnAttackSkillHigh = new System.Windows.Forms.Button();
            this.btnAttackBuff = new System.Windows.Forms.Button();
            this.btnDefenseBuff = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.attackSkillLowPb = new System.Windows.Forms.ProgressBar();
            this.attackSkillMedPb = new System.Windows.Forms.ProgressBar();
            this.attackSkillHeavyPb = new System.Windows.Forms.ProgressBar();
            this.attackBuffPb = new System.Windows.Forms.ProgressBar();
            this.defenceBuffPb = new System.Windows.Forms.ProgressBar();
            this.healthBuffPb = new System.Windows.Forms.ProgressBar();
            this.attackPb = new System.Windows.Forms.ProgressBar();
            this.defendPb = new System.Windows.Forms.ProgressBar();
            this.Click += new System.EventHandler(this.empty_Click);
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatAppearance.BorderSize = 0;
            this.btnAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Image = global::RpgGame.Properties.Resources.attackbtn;
            this.btnAttack.Location = new System.Drawing.Point(100, 685);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(50, 78);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.Transparent;
            this.btnDefend.FlatAppearance.BorderSize = 0;
            this.btnDefend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDefend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDefend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefend.Image = global::RpgGame.Properties.Resources.defendbtn;
            this.btnDefend.Location = new System.Drawing.Point(165, 695);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(50, 70);
            this.btnDefend.TabIndex = 1;
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Image = global::RpgGame.Properties.Resources.inventorybtn;
            this.btnInventory.Location = new System.Drawing.Point(863, 659);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(150, 40);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnAttackSkillLow
            // 
            this.btnAttackSkillLow.BackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillLow.FlatAppearance.BorderSize = 0;
            this.btnAttackSkillLow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillLow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttackSkillLow.Image = global::RpgGame.Properties.Resources.attackskilllow;
            this.btnAttackSkillLow.Location = new System.Drawing.Point(295, 690);
            this.btnAttackSkillLow.Name = "btnAttackSkillLow";
            this.btnAttackSkillLow.Size = new System.Drawing.Size(45, 42);
            this.btnAttackSkillLow.TabIndex = 5;
            this.btnAttackSkillLow.UseVisualStyleBackColor = false;
            this.btnAttackSkillLow.Click += new System.EventHandler(this.btnAttackSkillLow_Click);
            // 
            // btnAttackSkillMed
            // 
            this.btnAttackSkillMed.BackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillMed.FlatAppearance.BorderSize = 0;
            this.btnAttackSkillMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttackSkillMed.Image = global::RpgGame.Properties.Resources.attackskillmed;
            this.btnAttackSkillMed.Location = new System.Drawing.Point(344, 690);
            this.btnAttackSkillMed.Name = "btnAttackSkillMed";
            this.btnAttackSkillMed.Size = new System.Drawing.Size(45, 42);
            this.btnAttackSkillMed.TabIndex = 6;
            this.btnAttackSkillMed.UseVisualStyleBackColor = false;
            this.btnAttackSkillMed.Click += new System.EventHandler(this.btnAttackSkillMed_Click);
            // 
            // btnAttackSkillHigh
            // 
            this.btnAttackSkillHigh.BackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillHigh.FlatAppearance.BorderSize = 0;
            this.btnAttackSkillHigh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillHigh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttackSkillHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttackSkillHigh.Image = global::RpgGame.Properties.Resources.attackskillheavy;
            this.btnAttackSkillHigh.Location = new System.Drawing.Point(394, 690);
            this.btnAttackSkillHigh.Name = "btnAttackSkillHigh";
            this.btnAttackSkillHigh.Size = new System.Drawing.Size(46, 42);
            this.btnAttackSkillHigh.TabIndex = 7;
            this.btnAttackSkillHigh.UseVisualStyleBackColor = false;
            this.btnAttackSkillHigh.Click += new System.EventHandler(this.btnAttackSkillHigh_Click);
            // 
            // btnAttackBuff
            // 
            this.btnAttackBuff.BackColor = System.Drawing.Color.Transparent;
            this.btnAttackBuff.FlatAppearance.BorderSize = 0;
            this.btnAttackBuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttackBuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttackBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttackBuff.Image = global::RpgGame.Properties.Resources.attackbuff;
            this.btnAttackBuff.Location = new System.Drawing.Point(446, 690);
            this.btnAttackBuff.Name = "btnAttackBuff";
            this.btnAttackBuff.Size = new System.Drawing.Size(46, 42);
            this.btnAttackBuff.TabIndex = 8;
            this.btnAttackBuff.UseVisualStyleBackColor = false;
            this.btnAttackBuff.Click += new System.EventHandler(this.btnAttackBuff_Click);
            // 
            // btnDefenseBuff
            // 
            this.btnDefenseBuff.BackColor = System.Drawing.Color.Transparent;
            this.btnDefenseBuff.FlatAppearance.BorderSize = 0;
            this.btnDefenseBuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDefenseBuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDefenseBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefenseBuff.Image = global::RpgGame.Properties.Resources.defencebuff;
            this.btnDefenseBuff.Location = new System.Drawing.Point(497, 690);
            this.btnDefenseBuff.Name = "btnDefenseBuff";
            this.btnDefenseBuff.Size = new System.Drawing.Size(41, 42);
            this.btnDefenseBuff.TabIndex = 9;
            this.btnDefenseBuff.UseVisualStyleBackColor = false;
            this.btnDefenseBuff.Click += new System.EventHandler(this.btnDefenseBuff_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.Transparent;
            this.btnHeal.FlatAppearance.BorderSize = 0;
            this.btnHeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeal.Image = global::RpgGame.Properties.Resources.healthbuff;
            this.btnHeal.Location = new System.Drawing.Point(544, 690);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(44, 42);
            this.btnHeal.TabIndex = 10;
            this.btnHeal.UseVisualStyleBackColor = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatAppearance.BorderSize = 0;
            this.btnEndTurn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Image = global::RpgGame.Properties.Resources.endturnbtn;
            this.btnEndTurn.Location = new System.Drawing.Point(865, 711);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(150, 40);
            this.btnEndTurn.TabIndex = 11;
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(949, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(73, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // attackSkillLowPb
            // 
            this.attackSkillLowPb.Location = new System.Drawing.Point(298, 680);
            this.attackSkillLowPb.Maximum = 6;
            this.attackSkillLowPb.Name = "attackSkillLowPb";
            this.attackSkillLowPb.Size = new System.Drawing.Size(39, 10);
            this.attackSkillLowPb.TabIndex = 14;
            // 
            // attackSkillMedPb
            // 
            this.attackSkillMedPb.Location = new System.Drawing.Point(347, 680);
            this.attackSkillMedPb.Maximum = 6;
            this.attackSkillMedPb.Name = "attackSkillMedPb";
            this.attackSkillMedPb.Size = new System.Drawing.Size(39, 10);
            this.attackSkillMedPb.TabIndex = 15;
            // 
            // attackSkillHeavyPb
            // 
            this.attackSkillHeavyPb.Location = new System.Drawing.Point(397, 680);
            this.attackSkillHeavyPb.Maximum = 6;
            this.attackSkillHeavyPb.Name = "attackSkillHeavyPb";
            this.attackSkillHeavyPb.Size = new System.Drawing.Size(39, 10);
            this.attackSkillHeavyPb.TabIndex = 16;
            // 
            // attackBuffPb
            // 
            this.attackBuffPb.Location = new System.Drawing.Point(450, 680);
            this.attackBuffPb.Maximum = 6;
            this.attackBuffPb.Name = "attackBuffPb";
            this.attackBuffPb.Size = new System.Drawing.Size(39, 10);
            this.attackBuffPb.TabIndex = 17;
            // 
            // defenceBuffPb
            // 
            this.defenceBuffPb.Location = new System.Drawing.Point(500, 680);
            this.defenceBuffPb.Maximum = 6;
            this.defenceBuffPb.Name = "defenceBuffPb";
            this.defenceBuffPb.Size = new System.Drawing.Size(39, 10);
            this.defenceBuffPb.TabIndex = 18;
            // 
            // healthBuffPb
            // 
            this.healthBuffPb.Location = new System.Drawing.Point(547, 680);
            this.healthBuffPb.Maximum = 6;
            this.healthBuffPb.Name = "healthBuffPb";
            this.healthBuffPb.Size = new System.Drawing.Size(39, 10);
            this.healthBuffPb.TabIndex = 19;
            // 
            // attackPb
            // 
            this.attackPb.Location = new System.Drawing.Point(100, 675);
            this.attackPb.Maximum = 6;
            this.attackPb.Name = "attackPb";
            this.attackPb.Size = new System.Drawing.Size(51, 13);
            this.attackPb.TabIndex = 20;
            // 
            // defendPb
            // 
            this.defendPb.Location = new System.Drawing.Point(165, 675);
            this.defendPb.Maximum = 6;
            this.defendPb.Name = "defendPb";
            this.defendPb.Size = new System.Drawing.Size(51, 13);
            this.defendPb.TabIndex = 21;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.BattleScreenBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.defendPb);
            this.Controls.Add(this.attackPb);
            this.Controls.Add(this.healthBuffPb);
            this.Controls.Add(this.defenceBuffPb);
            this.Controls.Add(this.attackBuffPb);
            this.Controls.Add(this.attackSkillHeavyPb);
            this.Controls.Add(this.attackSkillMedPb);
            this.Controls.Add(this.attackSkillLowPb);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnDefenseBuff);
            this.Controls.Add(this.btnAttackBuff);
            this.Controls.Add(this.btnAttackSkillHigh);
            this.Controls.Add(this.btnAttackSkillMed);
            this.Controls.Add(this.btnAttackSkillLow);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Battle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAttackSkillLow;
        private System.Windows.Forms.Button btnAttackSkillMed;
        private System.Windows.Forms.Button btnAttackSkillHigh;
        private System.Windows.Forms.Button btnAttackBuff;
        private System.Windows.Forms.Button btnDefenseBuff;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ProgressBar attackSkillLowPb;
        private System.Windows.Forms.ProgressBar attackSkillMedPb;
        private System.Windows.Forms.ProgressBar attackSkillHeavyPb;
        private System.Windows.Forms.ProgressBar attackBuffPb;
        private System.Windows.Forms.ProgressBar defenceBuffPb;
        private System.Windows.Forms.ProgressBar healthBuffPb;
        private System.Windows.Forms.ProgressBar attackPb;
        private System.Windows.Forms.ProgressBar defendPb;
    }
}