using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {
        public static FrmInventory instance = null;
        private Player player;

        public FrmInventory()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            lblStatBlock.Text = $"Name: Mr. Peanut\nClass: Warrior\nHealth: {player.Health}/{player.MaxHealth}\nMP: {player.MP}/{player.MaxMP}";
            player.Inventory.ForEach(item => lstInventory.Items.Add(item));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUse_Click(object sender, EventArgs e)
        {
            switch (lstInventory.SelectedItem)
            {
                case "Health Potion":
                    player.AlterHealth(10);
                    break;

                case "Magic Potion":
                    player.AlterMP(10);
                    break;

                default:
                    break;
            }

            // update stat block
            lblStatBlock.Text = $"Name: Mr. Peanut\nClass: Warrior\nHealth: {player.Health}/{player.MaxHealth}\nMP: {player.MP}/{player.MaxMP}";

            // remove item from inventory
            player.Inventory.RemoveAt(lstInventory.SelectedIndex);
            lstInventory.Items.RemoveAt(lstInventory.SelectedIndex);
        }

        #region Methods Accidentally Created by Double-Clicking That We Can't Delete Without Windows Forms Throwing a Fit
        private void FrmInventory_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
