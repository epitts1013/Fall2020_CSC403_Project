using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
