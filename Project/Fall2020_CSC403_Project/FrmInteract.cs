﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInteract : Form
    {
        public static FrmInteract instance = null;
        private NPC npc;
        private Player player;
        public FrmInteract()
        {
            InitializeComponent();
        }

        public static FrmInteract GetInstance(NPC npc)
        {
            if (instance == null)
            {
                instance = new FrmInteract();
                instance.npc = npc;
                //instance.Setup();
            }
            return instance;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLevel.NPCPictureDict[npc].BackgroundImage = null;
            FrmLevel.NPCPictureDict[npc].SendToBack();
            Hide();
        }

        private void btnInteract1_Click(object sender, EventArgs e)
        {
            lblInteract.Text = "Come child, the Kool-Aid Demon shall pay for his crimes.";
        }

        private void btnInteract2_Click(object sender, EventArgs e)
        {
            lblInteract.Text = "You dishonor your father, BEGONE!";
            npc.IsBanished = true;
            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();
        }
    }
}
