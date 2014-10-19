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
        private List<IEnemy> enemyList = new List<IEnemy>();

        private Label enemyHp;
        private Label enemyDmg;
        private Label enemyDef;
        private Label debug;

        public BattleTest()
        {
            InitializeComponent();

            debug = new Label();
            debug.Left = 10;
            debug.Top = 500;
            debug.Width = 600;
            debug.Height = 50;
            Controls.Add(debug);

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

            IEnemy enemy = new Golem("Dumb", 85, 35, 20);
            enemy.Position = new Position(25, 12);
            enemyList.Add(enemy);

            IEnemy enemy2 = new Ork("Orglem", 100, 40, 25);
            enemy2.Position = new Position(25, 200);
            enemyList.Add(enemy2);
        }

        private void BattleTest_Load(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (IEnemy enemy in enemyList)
            {
                PictureBox picBox = new PictureBox();
                DrawImages(picBox, enemy, Properties.Resources.golem, counter.ToString());
                counter++;
            }
        }

        void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int id = int.Parse(p.Name);

            enemyHp.Text = enemyList[id].HitPoints.ToString();
            enemyDef.Text = enemyList[id].DefensePoints.ToString();
            enemyDmg.Text = enemyList[id].AttackPoints.ToString();
        }

        private void DrawImages(PictureBox pictureBox, IEnemy enemy, Image image, string id)
        {

            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Left = enemy.Position.X;
            pictureBox.Top = enemy.Position.Y;
            pictureBox.Click += PictureBox_Click;
            pictureBox.Name = id;
            this.Controls.Add(pictureBox);
        }
    }
}
