using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Frm2Level : Form
    {
        private Player player1;

        private List<Enemy> enemies = new List<Enemy>();
        public static Dictionary<Enemy, PictureBox> EnemyPictureDict = new Dictionary<Enemy, PictureBox>();

        private Character[] walls;
        private Character[] portals;

        private DateTime timeBegin;
        public FrmBattle frmBattle;


        private bool holdLeft, holdRight, holdUp, holdDown;


        public Frm2Level()
        {
            InitializeComponent();

        }


        
        private void Frm2Level_Load(object sender, EventArgs e)
        {

            const int PADDING = 7;
            const int NUM_WALLS = 24;
            const int NUM_portals = 1;

            // initialize player1
            player1 = Game.player; //new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            //Game.player = player1;

            // initialize enemies on this form
            Enemy bossKoolaid2 = new Enemy(CreatePosition(picBossKoolAid2), CreateCollider(picBossKoolAid2, PADDING), 100, 60)
            {
                Img = picBossKoolAid2.BackgroundImage,
                Color = Color.Red,
                IsBoss = true
            };
            enemies.Add(bossKoolaid2);
            EnemyPictureDict.Add(bossKoolaid2, picBossKoolAid2);

            Enemy enemyPoisonPacket = new Enemy(CreatePosition(picEnemyMario2), CreateCollider(picEnemyMario2, PADDING), 50)
            {
                Img = picEnemyMario2.BackgroundImage,
                Color = Color.Green,
                IsBoss = false
            };

            enemies.Add(enemyPoisonPacket);
            EnemyPictureDict.Add(enemyPoisonPacket, picEnemyMario2);

            Enemy enemyMario = new Enemy(CreatePosition(picEnemyMario), CreateCollider(picEnemyMario, PADDING), 50)
            {
                Img = picEnemyMario.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };

            enemies.Add(enemyMario);
            EnemyPictureDict.Add(enemyMario, picEnemyMario);

            Enemy enemyMario1 = new Enemy(CreatePosition(picEnemyMario1), CreateCollider(picEnemyMario1, PADDING), 50)
            {
                Img = picEnemyMario1.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };
            enemies.Add(enemyMario1);
            EnemyPictureDict.Add(enemyMario1, picEnemyMario1);

            Enemy enemyMario3 = new Enemy(CreatePosition(picEnemyMario3), CreateCollider(picEnemyMario3, PADDING), 50)
            {
                Img = picEnemyMario3.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };
            enemies.Add(enemyMario3);
            EnemyPictureDict.Add(enemyMario3, picEnemyMario3);

            Enemy enemyMario4 = new Enemy(CreatePosition(picEnemyMario4), CreateCollider(picEnemyMario4, PADDING), 50)
            {
                Img = picEnemyMario4.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };
            enemies.Add(enemyMario4);
            EnemyPictureDict.Add(enemyMario4, picEnemyMario4);


            Enemy enemyCheeto = new Enemy(CreatePosition(picEnemyMario), CreateCollider(picEnemyMario, PADDING), 50)
            {
                Img = picEnemyMario.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };
            enemies.Add(enemyCheeto);
            EnemyPictureDict.Add(enemyCheeto, picEnemyMario);


            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }


            portals = new Character[NUM_portals];
            for (int p = 0; p < NUM_portals; p++)
            {
                PictureBox port = Controls.Find("picPortal" + p.ToString(), true)[0] as PictureBox;
                portals[p] = new Character(CreatePosition(port), CreateCollider(port, PADDING));
            }

            timeBegin = DateTime.Now;
        }




        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            if (Globals.PlayerIsAlive == false)
            {
                //player1.ResetMoveSpeed();
                Thread.Sleep(100);
                Close();
            }

            // move player1
            player1.Move();

            // check collision with walls
            if (HitAWall(player1))
            {
                player1.MoveBack();
            }


            // check collision with enemies
            enemies.ForEach((enemy) =>
            {
                if (enemy.IsAlive && HitAChar(player1, enemy))
                    Fight(enemy);

            });

            // update player1's picture box
            picPlayer.Location = new Point((int)player1.Position.x, (int)player1.Position.y);

            if (HitAPortal(player1))
            {
                
                player1.MoveBack();
                Thread.Sleep(400);

                Globals.LevelNumber = 3;
                Close();

            }
        }

        private bool HitAPortal(Character c)
        {
            bool hitAPortal = false;
            for (int p = 0; p < portals.Length; p++)
            {
                if (c.Collider.Intersects(portals[p].Collider))
                {
                    hitAPortal = true;
                    break;
                }
            }
            return hitAPortal;
        }
    

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }


        private void Fight(Enemy enemy)
        {
            player1.ResetMoveSpeed();
            player1.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy.IsBoss)
            {
                frmBattle.SetupForBossBattle();
            }
        }

        protected override void OnDeactivate(EventArgs e)
        {
            // when form loses focus, stop movement
            holdLeft = false;
            holdRight = false;
            holdUp = false;
            holdDown = false;
            player1.ResetMoveSpeed();
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void portal_Click(object sender, EventArgs e)
        {

        }

        private void picBossKoolAid_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Frm2Level_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!holdLeft)
                    {
                        player1.UpdateMoveSpeed(Vector2.Left);
                        //MovePictureBoxes("Left");
                        holdLeft = true;
                    }
                    break;

                case Keys.Right:
                    if (!holdRight)
                    {
                        player1.UpdateMoveSpeed(Vector2.Right);
                        //MovePictureBoxes("Right");
                        holdRight = true;
                    }
                    break;

                case Keys.Up:
                    if (!holdUp)
                    {
                        player1.UpdateMoveSpeed(Vector2.Down);
                        //MovePictureBoxes("Down");
                        holdUp = true;
                    }
                    break;

                case Keys.Down:
                    if (!holdDown)
                    {
                        player1.UpdateMoveSpeed(Vector2.Up);
                        //MovePictureBoxes("Up");
                        holdDown = true;
                    }
                    break;

                case Keys.Tab:
                    FrmInventory inventory = new FrmInventory();
                    inventory.Setup();
                    inventory.Show();
                    break;

                default:
                    break;
            }
        }

        private void Frm2Level_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (holdLeft)
                        player1.UpdateMoveSpeed(-Vector2.Left);
                    holdLeft = false;
                    break;

                case Keys.Right:
                    if (holdRight)
                        player1.UpdateMoveSpeed(-Vector2.Right);
                    holdRight = false;
                    break;

                case Keys.Up:
                    if (holdUp)
                        player1.UpdateMoveSpeed(-Vector2.Down); // down is up because form is top-left origin coordinate system
                    holdUp = false;
                    break;

                case Keys.Down:
                    if (holdDown)
                        player1.UpdateMoveSpeed(-Vector2.Up); // up is down because form is top-left origin coordinate system
                    holdDown = false;
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
    }
}
