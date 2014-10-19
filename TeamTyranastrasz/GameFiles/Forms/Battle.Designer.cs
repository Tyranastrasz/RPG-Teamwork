﻿namespace RpgGame.Forms
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.btnAttackSkillLow = new System.Windows.Forms.Button();
            this.btnAttackSkillMed = new System.Windows.Forms.Button();
            this.btnAttackSkillHigh = new System.Windows.Forms.Button();
            this.btnAttackBuff = new System.Windows.Forms.Button();
            this.btnDefenseBuff = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblDiceRollScore = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(80, 582);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(135, 45);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack(2dp)";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.Location = new System.Drawing.Point(272, 582);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(135, 45);
            this.btnDefend.TabIndex = 1;
            this.btnDefend.Text = "Defend(2dp)";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(464, 582);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(135, 45);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Location = new System.Drawing.Point(839, 629);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(135, 69);
            this.btnDiceRoll.TabIndex = 4;
            this.btnDiceRoll.Text = "Dice Roll";
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // btnAttackSkillLow
            // 
            this.btnAttackSkillLow.Location = new System.Drawing.Point(80, 653);
            this.btnAttackSkillLow.Name = "btnAttackSkillLow";
            this.btnAttackSkillLow.Size = new System.Drawing.Size(92, 45);
            this.btnAttackSkillLow.TabIndex = 5;
            this.btnAttackSkillLow.Text = "Attack Skill Low (2dp)";
            this.btnAttackSkillLow.UseVisualStyleBackColor = true;
            this.btnAttackSkillLow.Click += new System.EventHandler(this.btnAttackSkillLow_Click);
            // 
            // btnAttackSkillMed
            // 
            this.btnAttackSkillMed.Location = new System.Drawing.Point(201, 653);
            this.btnAttackSkillMed.Name = "btnAttackSkillMed";
            this.btnAttackSkillMed.Size = new System.Drawing.Size(92, 45);
            this.btnAttackSkillMed.TabIndex = 6;
            this.btnAttackSkillMed.Text = "Attack Skill Med (4dp)";
            this.btnAttackSkillMed.UseVisualStyleBackColor = true;
            this.btnAttackSkillMed.Click += new System.EventHandler(this.btnAttackSkillMed_Click);
            // 
            // btnAttackSkillHigh
            // 
            this.btnAttackSkillHigh.Location = new System.Drawing.Point(315, 653);
            this.btnAttackSkillHigh.Name = "btnAttackSkillHigh";
            this.btnAttackSkillHigh.Size = new System.Drawing.Size(92, 45);
            this.btnAttackSkillHigh.TabIndex = 7;
            this.btnAttackSkillHigh.Text = "Attack Skill Hign (6dp)";
            this.btnAttackSkillHigh.UseVisualStyleBackColor = true;
            this.btnAttackSkillHigh.Click += new System.EventHandler(this.btnAttackSkillHigh_Click);
            // 
            // btnAttackBuff
            // 
            this.btnAttackBuff.Location = new System.Drawing.Point(464, 653);
            this.btnAttackBuff.Name = "btnAttackBuff";
            this.btnAttackBuff.Size = new System.Drawing.Size(92, 45);
            this.btnAttackBuff.TabIndex = 8;
            this.btnAttackBuff.Text = "Attack Buff (3dp)";
            this.btnAttackBuff.UseVisualStyleBackColor = true;
            this.btnAttackBuff.Click += new System.EventHandler(this.btnAttackBuff_Click);
            // 
            // btnDefenseBuff
            // 
            this.btnDefenseBuff.Location = new System.Drawing.Point(580, 653);
            this.btnDefenseBuff.Name = "btnDefenseBuff";
            this.btnDefenseBuff.Size = new System.Drawing.Size(92, 45);
            this.btnDefenseBuff.TabIndex = 9;
            this.btnDefenseBuff.Text = "Defense Buff(3dp)";
            this.btnDefenseBuff.UseVisualStyleBackColor = true;
            this.btnDefenseBuff.Click += new System.EventHandler(this.btnDefenseBuff_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(693, 653);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(92, 45);
            this.btnHeal.TabIndex = 10;
            this.btnHeal.Text = "Heal (3dp)";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(656, 582);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(143, 45);
            this.btnEndTurn.TabIndex = 11;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblDiceRollScore
            // 
            this.lblDiceRollScore.AutoSize = true;
            this.lblDiceRollScore.Location = new System.Drawing.Point(879, 582);
            this.lblDiceRollScore.Name = "lblDiceRollScore";
            this.lblDiceRollScore.Size = new System.Drawing.Size(51, 13);
            this.lblDiceRollScore.TabIndex = 12;
            this.lblDiceRollScore.Text = "DIcePool";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(912, 21);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 37);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RpgGame.Properties.Resources.battle_temp_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblDiceRollScore);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnDefenseBuff);
            this.Controls.Add(this.btnAttackBuff);
            this.Controls.Add(this.btnAttackSkillHigh);
            this.Controls.Add(this.btnAttackSkillMed);
            this.Controls.Add(this.btnAttackSkillLow);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Battle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Button btnAttackSkillLow;
        private System.Windows.Forms.Button btnAttackSkillMed;
        private System.Windows.Forms.Button btnAttackSkillHigh;
        private System.Windows.Forms.Button btnAttackBuff;
        private System.Windows.Forms.Button btnDefenseBuff;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblDiceRollScore;
        private System.Windows.Forms.Button exit;
    }
}