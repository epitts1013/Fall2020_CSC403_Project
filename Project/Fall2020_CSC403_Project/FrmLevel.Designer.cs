namespace Fall2020_CSC403_Project
{
    partial class FrmLevel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picPowerupbabypeanut = new System.Windows.Forms.PictureBox();
            this.picWall15 = new System.Windows.Forms.PictureBox();
            this.picWall23 = new System.Windows.Forms.PictureBox();
            this.picWall22 = new System.Windows.Forms.PictureBox();
            this.picWall21 = new System.Windows.Forms.PictureBox();
            this.picWall20 = new System.Windows.Forms.PictureBox();
            this.picWall19 = new System.Windows.Forms.PictureBox();
            this.picWall18 = new System.Windows.Forms.PictureBox();
            this.picWall17 = new System.Windows.Forms.PictureBox();
            this.picWall16 = new System.Windows.Forms.PictureBox();
            this.picWall14 = new System.Windows.Forms.PictureBox();
            this.picWall13 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picPortal0 = new System.Windows.Forms.PictureBox();

            this.labelPlayerStats = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picPowerupbabypeanut)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.picWall15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortal0)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(31, 22);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // picPowerupbabypeanut
            // 
            this.picPowerupbabypeanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.powerup_babypeanut;
            this.picPowerupbabypeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPowerupbabypeanut.Location = new System.Drawing.Point(749, 536);
            this.picPowerupbabypeanut.Name = "picPowerupbabypeanut";
            this.picPowerupbabypeanut.Size = new System.Drawing.Size(69, 71);
            this.picPowerupbabypeanut.TabIndex = 31;
            this.picPowerupbabypeanut.TabStop = false;
            // 
            // picWall15
            // 
            this.picWall15.BackColor = System.Drawing.Color.Transparent;
            this.picWall15.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall15.Location = new System.Drawing.Point(1177, 65);
            this.picWall15.Name = "picWall15";
            this.picWall15.Size = new System.Drawing.Size(75, 479);
            this.picWall15.TabIndex = 30;
            this.picWall15.TabStop = false;
            this.picWall15.Tag = "wallPic";
            // 
            // picWall23
            // 
            this.picWall23.BackColor = System.Drawing.Color.Transparent;
            this.picWall23.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall23.Location = new System.Drawing.Point(2, 717);
            this.picWall23.Name = "picWall23";
            this.picWall23.Size = new System.Drawing.Size(76, 267);
            this.picWall23.TabIndex = 29;
            this.picWall23.TabStop = false;
            this.picWall23.Tag = "wallPic";
            // 
            // picWall22
            // 
            this.picWall22.BackColor = System.Drawing.Color.Transparent;
            this.picWall22.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall22.Location = new System.Drawing.Point(2, 976);
            this.picWall22.Name = "picWall22";
            this.picWall22.Size = new System.Drawing.Size(645, 67);
            this.picWall22.TabIndex = 28;
            this.picWall22.TabStop = false;
            this.picWall22.Tag = "wallPic";
            // 
            // picWall21
            // 
            this.picWall21.BackColor = System.Drawing.Color.Transparent;
            this.picWall21.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall21.Location = new System.Drawing.Point(618, 976);
            this.picWall21.Name = "picWall21";
            this.picWall21.Size = new System.Drawing.Size(645, 67);
            this.picWall21.TabIndex = 27;
            this.picWall21.TabStop = false;
            this.picWall21.Tag = "wallPic";
            // 
            // picWall20
            // 
            this.picWall20.BackColor = System.Drawing.Color.Transparent;
            this.picWall20.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall20.Location = new System.Drawing.Point(1259, 976);
            this.picWall20.Name = "picWall20";
            this.picWall20.Size = new System.Drawing.Size(645, 67);
            this.picWall20.TabIndex = 26;
            this.picWall20.TabStop = false;
            this.picWall20.Tag = "wallPic";
            // 
            // picWall19
            // 
            this.picWall19.BackColor = System.Drawing.Color.Transparent;
            this.picWall19.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall19.Location = new System.Drawing.Point(1828, 523);
            this.picWall19.Name = "picWall19";
            this.picWall19.Size = new System.Drawing.Size(76, 461);
            this.picWall19.TabIndex = 25;
            this.picWall19.TabStop = false;
            this.picWall19.Tag = "wallPic";
            // 
            // picWall18
            // 
            this.picWall18.BackColor = System.Drawing.Color.Transparent;
            this.picWall18.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall18.Location = new System.Drawing.Point(995, 65);
            this.picWall18.Name = "picWall18";
            this.picWall18.Size = new System.Drawing.Size(95, 583);
            this.picWall18.TabIndex = 24;
            this.picWall18.TabStop = false;
            this.picWall18.Tag = "wallPic";
            this.picWall18.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picWall17
            // 
            this.picWall17.BackColor = System.Drawing.Color.Transparent;
            this.picWall17.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall17.Location = new System.Drawing.Point(1828, 1);
            this.picWall17.Name = "picWall17";
            this.picWall17.Size = new System.Drawing.Size(76, 527);
            this.picWall17.TabIndex = 23;
            this.picWall17.TabStop = false;
            this.picWall17.Tag = "wallPic";
            // 
            // picWall16
            // 
            this.picWall16.BackColor = System.Drawing.Color.Transparent;
            this.picWall16.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall16.Location = new System.Drawing.Point(1186, 1);
            this.picWall16.Name = "picWall16";
            this.picWall16.Size = new System.Drawing.Size(645, 67);
            this.picWall16.TabIndex = 22;
            this.picWall16.TabStop = false;
            this.picWall16.Tag = "wallPic";
            this.picWall16.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picWall14
            // 
            this.picWall14.BackColor = System.Drawing.Color.Transparent;
            this.picWall14.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall14.Location = new System.Drawing.Point(83, 257);
            this.picWall14.Name = "picWall14";
            this.picWall14.Size = new System.Drawing.Size(147, 79);
            this.picWall14.TabIndex = 21;
            this.picWall14.TabStop = false;
            this.picWall14.Tag = "wallPic";
            // 
            // picWall13
            // 
            this.picWall13.BackColor = System.Drawing.Color.Transparent;
            this.picWall13.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall13.Location = new System.Drawing.Point(2, 274);
            this.picWall13.Name = "picWall13";
            this.picWall13.Size = new System.Drawing.Size(82, 374);
            this.picWall13.TabIndex = 20;
            this.picWall13.TabStop = false;
            this.picWall13.Tag = "wallPic";
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(1335, 145);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(416, 205);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            this.picWall11.Tag = "wallPic";
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(637, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            this.picWall2.Tag = "wallPic";
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(995, 813);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(95, 171);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            this.picWall8.Tag = "wallPic";
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(1335, 347);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(89, 301);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            this.picWall7.Tag = "wallPic";
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            this.picWall1.Tag = "wallPic";
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 282);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            this.picWall0.Tag = "wallPic";
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(300, 65);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(79, 391);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            this.picWall10.Tag = "wallPic";
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(1177, 717);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(238, 171);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            this.picWall9.Tag = "wallPic";
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 644);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 79);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            this.picWall6.Tag = "wallPic";
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(1503, 440);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(329, 88);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            this.picWall12.Tag = "wallPic";
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(1503, 813);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(235, 171);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            this.picWall4.Tag = "wallPic";
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 644);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 79);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            this.picWall5.Tag = "wallPic";
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(841, 551);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(43, 84);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            this.picEnemyCheeto.Tag = "enemyPic";
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(841, 717);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(41, 67);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            this.picEnemyPoisonPacket.Tag = "enemyPic";
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(995, 635);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(743, 88);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            this.picWall3.Tag = "wallPic";
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(432, 347);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(236, 235);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            this.picBossKoolAid.Tag = "enemyPic";
            this.picBossKoolAid.Click += new System.EventHandler(this.picBossKoolAid_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(133, 813);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(43, 76);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picPortal0
            // 
            this.picPortal0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.portalEnd;
            this.picPortal0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPortal0.Location = new System.Drawing.Point(83, 35);
            this.picPortal0.Name = "picPortal0";
            this.picPortal0.Size = new System.Drawing.Size(76, 266);
            this.picPortal0.TabIndex = 19;
            this.picPortal0.TabStop = false;
            this.picPortal0.Tag = "portal";
            this.picPortal0.Click += new System.EventHandler(this.portal_Click);
            // 
            // labelPlayerStats
            // 
            this.labelPlayerStats.AutoSize = true;
            this.labelPlayerStats.BackColor = System.Drawing.Color.Black;
            this.labelPlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerStats.ForeColor = System.Drawing.Color.White;
            this.labelPlayerStats.Location = new System.Drawing.Point(151, 9);
            this.labelPlayerStats.Name = "labelPlayerStats";
            this.labelPlayerStats.Size = new System.Drawing.Size(87, 18);
            this.labelPlayerStats.TabIndex = 2;
            this.labelPlayerStats.Text = "Player Stats";
            this.labelPlayerStats.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.ClientSize = new System.Drawing.Size(1904, 1041);
        
            this.Controls.Add(this.picPowerupbabypeanut);

            this.Controls.Add(this.picWall15);
            this.Controls.Add(this.picWall23);
            this.Controls.Add(this.picWall22);
            this.Controls.Add(this.picWall21);
            this.Controls.Add(this.picWall20);
            this.Controls.Add(this.picWall19);
            this.Controls.Add(this.picWall18);
            this.Controls.Add(this.picWall17);
            this.Controls.Add(this.picWall16);
            this.Controls.Add(this.picWall14);
            this.Controls.Add(this.picWall13);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.labelPlayerStats);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picPortal0);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr. Peanut\'s Nutty Adventure";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPowerupbabypeanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortal0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        private System.Windows.Forms.PictureBox picEnemyCheeto;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall12;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox picPortal0;
        private System.Windows.Forms.PictureBox picWall13;
        private System.Windows.Forms.PictureBox picWall14;
        private System.Windows.Forms.PictureBox picWall16;
        private System.Windows.Forms.PictureBox picWall17;
        private System.Windows.Forms.PictureBox picWall18;
        private System.Windows.Forms.PictureBox picWall19;
        private System.Windows.Forms.PictureBox picWall20;
        private System.Windows.Forms.PictureBox picWall21;
        private System.Windows.Forms.PictureBox picWall22;
        private System.Windows.Forms.PictureBox picWall23;
        private System.Windows.Forms.PictureBox picWall15;
        private System.Windows.Forms.Label labelPlayerStats;
        private System.Windows.Forms.PictureBox picPowerupbabypeanut;

    }
}

