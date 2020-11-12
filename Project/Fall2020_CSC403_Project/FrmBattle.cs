using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Threading;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;

        private FrmBattle()
        {
            InitializeComponent();
            player = Game.player;
        }


        

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        public static FrmBattle GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-4 + (-1 * (player.Level - 1)));
            if (enemy.Health > 0)
            {
                // Will - Enemy "animation effect"
                if (enemy.Img == Resources.enemy_koolaid)
                {

                    if (enemy.IsAlive == true)
                    {
                        picEnemy.BackgroundImage = Resources.enemy_koolaid_hit;
                    }
                    else
                    {
                        picEnemy.BackgroundImage = Resources.enemy_koolaid_dead;
                    }
                }


                else if (enemy.Img == Resources.enemy_cheetos)
                {
                    if (enemy.IsAlive == true)
                    {
                        picEnemy.BackgroundImage = Resources.enemy_cheetos_fw_hit;
                    }
                    else
                    {
                        picEnemy.BackgroundImage = Resources.enemy_cheetos_fw_dead;
                    }
                }

                else // (enemy.Img == Resources.enemy_poisonpacket)
                {

                    if (enemy.IsAlive == true)
                    {
                        picEnemy.BackgroundImage = Resources.enemy_poisonpacket_fw_hit;
                    }
                    else
                    {
                        picEnemy.BackgroundImage = Resources.enemy_poisonpacket_fw_dead;
                    }
                }

                if (enemy.IsAlive == true)
                {
                    picEnemy.Refresh();
                }

                Thread.Sleep(100);
                
                picEnemy.BackgroundImage = enemy.Img;
                picEnemy.Refresh();


                enemy.OnAttack(-2);


                // Will - Player "animation effect"
                picPlayer.BackgroundImage = Resources.player_hit;
                picPlayer.Refresh();

                Thread.Sleep(100);

                picPlayer.BackgroundImage = Resources.player;
                picPlayer.Refresh();
            }

            UpdateHealthBars();
            if (player.Health <= 0)
            {
                picPlayer.BackgroundImage = Resources.player_dead;
                picPlayer.Refresh();

                // lblInfoPanel.Text = $"You have died, Mr. Peanut is very disappointed in you :(";
                Thread.Sleep(2000);

                instance = null;
                Close();
             
            }
            else if (enemy.Health <= 0)
            {
                lblInfoPanel.Text = $"Enemy was defeated. Mr. Peanut gained {enemy.ExpReward} experience points!";
                Application.DoEvents();
                Thread.Sleep(2000);

                if (player.AwardEXP(enemy.ExpReward))
                {
                    lblInfoPanel.Text = $"Mr. Peanut leveled up! Level is now {player.Level}!";
                    Application.DoEvents();
                    Thread.Sleep(2000);
                }
                enemy.IsAlive = false;
                FrmLevel.EnemyPictureDict[enemy].BackgroundImage = null;
                FrmLevel.EnemyPictureDict[enemy].SendToBack();

                instance = null;
                Close();
            }
        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

        private void infoPanel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }
    }
}
