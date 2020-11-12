using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private List<Enemy> enemies = new List<Enemy>();
        public static Dictionary<Enemy, PictureBox> EnemyPictureDict = new Dictionary<Enemy, PictureBox>();
        // Tonebone
        private List<NPC> NPCs = new List<NPC>();
        public static Dictionary<NPC, PictureBox> NPCPictureDict = new Dictionary<NPC, PictureBox>();

        private Character[] walls;
        private Character[] portals;

        private DateTime timeBegin;
        private FrmBattle frmBattle;


        private bool holdLeft, holdRight, holdUp, holdDown;
        private FrmInteract frmInteract;

        public FrmLevel()
        {
            InitializeComponent();

        }


        //public void MovePictureBoxes(string direction)
        //{
        //    foreach (Control x in this.Controls)
        //    {

        //        if (x is PictureBox && (string)x.Tag == "background1" || x is PictureBox && (string)x.Tag == "enemyPic" || x is PictureBox && (string)x.Tag == "wallPic")
        //        {

        //            if (direction == "Left")
        //            {
        //                x.Left -= 3;
        //            }

        //            if (direction == "Right")
        //            {
        //                x.Left += 3;
        //            }

        //            if (direction == "Down")
        //            {
        //                x.Top -= 3;
        //            }

        //            if (direction == "Up")
        //            {
        //                x.Top += 3;
        //            }

        //        }
        //    }
        //}


        private void FrmLevel_Load(object sender, EventArgs e)
        {

            const int PADDING = 7;
            const int NUM_WALLS = 16;
            const int NUM_portals = 1;

            // initialize player
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            Game.player = player;

            // initialize enemies on this form
            Enemy bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 100, 60)
            {
                Img = picBossKoolAid.BackgroundImage,
                Color = Color.Red,
                IsBoss = true
            };
            enemies.Add(bossKoolaid);
            EnemyPictureDict.Add(bossKoolaid, picBossKoolAid);

            Enemy enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), 50)
            {
                Img = picEnemyPoisonPacket.BackgroundImage,
                Color = Color.Green,
                IsBoss = false
            };
            enemies.Add(enemyPoisonPacket);
            EnemyPictureDict.Add(enemyPoisonPacket, picEnemyPoisonPacket);

            Enemy enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 50)
            {
                Img = picEnemyCheeto.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };
            enemies.Add(enemyCheeto);
            EnemyPictureDict.Add(enemyCheeto, picEnemyCheeto);

            // Initialize NPC/Powerups
            NPC powerupBabypeaunt = new NPC(CreatePosition(picPowerupbabypeanut), CreateCollider(picPowerupbabypeanut, PADDING))
            {
                // Add what the powerup does here later
            };
            NPCs.Add(powerupBabypeaunt);
            NPCPictureDict.Add(powerupBabypeaunt, picPowerupbabypeanut); 

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
            labelPlayerStats.Text = "Level: " + player.Level + "\nHealth: " + player.Health + "/" + player.MaxHealth + "\nEXP: " + player.EXP;
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

            
            // Tone - testing npc interaction/collision
            NPCs.ForEach((npc) =>
            {
                if (HitAChar(player, npc))
                    Interact(npc);

            });
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
                player.ResetMoveSpeed();
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

        // Tone - Interact function
        private void Interact(NPC npc)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmInteract = FrmInteract.GetInstance(npc);
            frmInteract.Show();
            
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

        private void background_Click(object sender, EventArgs e) { }
        private void portal_Click(object sender, EventArgs e) { }
        private void picBossKoolAid_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }


        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.UpdateMoveSpeed(-Vector2.Left);
                    holdLeft = false;
                    break;

                case Keys.Right:
                    player.UpdateMoveSpeed(-Vector2.Right);
                    holdRight = false;
                    break;

                case Keys.Up:
                    player.UpdateMoveSpeed(-Vector2.Down); // down is up because form is top-left origin coordinate system
                    holdUp = false;
                    break;

                case Keys.Down:
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
