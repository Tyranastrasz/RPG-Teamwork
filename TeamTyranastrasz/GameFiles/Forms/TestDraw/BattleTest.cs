using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGame.Enemies.MeleeType;

namespace RpgGame.Forms.TestDraw
{
    public partial class BattleTest : Form
    {
        private IEnemy golemEnemy1;
        private IEnemy golemEnemy2;

        private PictureBox picBoxBot1 = new PictureBox();
        private PictureBox picBoxMid = new PictureBox();
        private PictureBox picBoxTop1;
        private PictureBox picBoxBot2;
        private PictureBox picBoxTop2;

        private Label enemyHp;
        private Label enemyDmg;
        private Label enemyDef;
        
        public BattleTest()
        {
            InitializeComponent();

            InitializeComponent();

            enemyHp = new Label();
            enemyHp.Left = 250;
            enemyHp.Top = 30;
            enemyHp.Width = 20;
            Controls.Add(enemyHp);

            enemyDmg = new Label();
            enemyDmg.Left = 250;
            enemyDmg.Top = 60;
            enemyDmg.Width = 20;
            Controls.Add(enemyDmg);

            enemyDef = new Label();
            enemyDef.Left = 250;
            enemyDef.Top = 90;
            enemyDef.Width = 20;
            Controls.Add(enemyDef);

            golemEnemy1 = new Golem("Dumb", 85, 35, 20);
            golemEnemy1.Position = new Position(25, 12);

            golemEnemy2 = new Ork("Orglem", 100, 40, 25);
            golemEnemy2.Position = new Position(350, 20);
        }

        private void BattleTest_Load(object sender, EventArgs e)
        {
            DrawImages(picBoxMid, golemEnemy1, Properties.Resources.golem);
            DrawImages(picBoxBot1, golemEnemy2, Properties.Resources.golem);
        }

        void PictureBox_Click(object sender, EventArgs e)
        {
            enemyHp.Text = golemEnemy1.HitPoints.ToString();
            enemyDef.Text = golemEnemy1.DefensePoints.ToString();
            enemyDmg.Text = golemEnemy1.AttackPoints.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //golemEnemy1.PictureBox.Update();
            //golemEnemy1.PictureBox.Left += 10;
        }

        private void DrawImages(PictureBox pictureBox, IEnemy enemy, Image image)
        {
            //golemEnemy1.Position = new Position(25, 12);
            //golemEnemy1.PictureBox.Image = Properties.Resources.golem;
            //golemEnemy1.PictureBox.Width = Properties.Resources.golem.Width;
            //golemEnemy1.PictureBox.Height = Properties.Resources.golem.Height;
            //golemEnemy1.PictureBox.BackColor = Color.Transparent;
            //golemEnemy1.PictureBox.Left = golemEnemy1.Position.X;
            //golemEnemy1.PictureBox.Top = golemEnemy1.Position.Y;
            //golemEnemy1.PictureBox.Click += PictureBox_Click;
            //this.Controls.Add(golemEnemy1.PictureBox);

            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Left = enemy.Position.X;
            pictureBox.Top = enemy.Position.Y;
            pictureBox.Click += PictureBox_Click;
            this.Controls.Add(pictureBox);
        }
    }
}
