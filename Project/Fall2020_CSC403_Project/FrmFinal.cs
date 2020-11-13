using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmFinal : Form
    {
        private Player player;

        private List<Enemy> enemies = new List<Enemy>();
        public static Dictionary<Enemy, PictureBox> EnemyPictureDict = new Dictionary<Enemy, PictureBox>();

        private Character[] walls;
        private Character[] portals;

        private DateTime timeBegin;
        public FrmBattle frmBattle;


        private bool holdLeft, holdRight, holdUp, holdDown;


        public FrmFinal()
        {
            InitializeComponent();

        }


        
        private void Frm2Level_Load(object sender, EventArgs e)
        {

            const int PADDING = 7;
            const int NUM_WALLS = 18;
            const int NUM_portals = 1;

            // initialize player
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            Game.player = player;

            // initialize enemies on this form


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
            if (Globals.PlayerIsAlive == false)
            {
                //player.ResetMoveSpeed();
                Thread.Sleep(100);
                Close();
            }
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {


            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }


            // check collision with enemies
            enemies.ForEach((enemy) =>
            {
                if (enemy.IsAlive && HitAChar(player, enemy))
                    Fight(enemy);

            });

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            if (HitAPortal(player))
            {
                
                player.MoveBack();
                Thread.Sleep(200);
                player.ResetMoveSpeed();
                Thread.Sleep(1000);
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
            player.ResetMoveSpeed();
            player.MoveBack();
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
            player.ResetMoveSpeed();
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
                        player.UpdateMoveSpeed(Vector2.Left);
                        //MovePictureBoxes("Left");
                        holdLeft = true;
                    }
                    break;

                case Keys.Right:
                    if (!holdRight)
                    {
                        player.UpdateMoveSpeed(Vector2.Right);
                        //MovePictureBoxes("Right");
                        holdRight = true;
                    }
                    break;

                case Keys.Up:
                    if (!holdUp)
                    {
                        player.UpdateMoveSpeed(Vector2.Down);
                        //MovePictureBoxes("Down");
                        holdUp = true;
                    }
                    break;

                case Keys.Down:
                    if (!holdDown)
                    {
                        player.UpdateMoveSpeed(Vector2.Up);
                        //MovePictureBoxes("Up");
                        holdDown = true;
                    }
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
                        player.UpdateMoveSpeed(-Vector2.Left);
                    holdLeft = false;
                    break;

                case Keys.Right:
                    if (holdRight)
                        player.UpdateMoveSpeed(-Vector2.Right);
                    holdRight = false;
                    break;

                case Keys.Up:
                    if (holdUp)
                        player.UpdateMoveSpeed(-Vector2.Down); // down is up because form is top-left origin coordinate system
                    holdUp = false;
                    break;

                case Keys.Down:
                    if (holdDown)
                        player.UpdateMoveSpeed(-Vector2.Up); // up is down because form is top-left origin coordinate system
                    holdDown = false;
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
    }
}
