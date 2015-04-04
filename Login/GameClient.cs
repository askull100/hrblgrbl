using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GameClient : Form
    {
        public GameClient()
        {
            InitializeComponent();
        }

        private void SlotSelected(int slotNumber)
        {
            //Handle player input here
            //Check if its your turn and if you can even place your token there
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Ask player if he wants to forfeit the match
            //Do logout logic here
        }

        private void gameButton1_Click(object sender, EventArgs e)
        {
            SlotSelected(1);
        }

        private void gameButton2_Click(object sender, EventArgs e)
        {
            SlotSelected(2);
        }

        private void gameButton3_Click(object sender, EventArgs e)
        {
            SlotSelected(3);
        }

        private void gameButton4_Click(object sender, EventArgs e)
        {
            SlotSelected(4);
        }

        private void gameButton5_Click(object sender, EventArgs e)
        {
            SlotSelected(5);
        }

        private void gameButton6_Click(object sender, EventArgs e)
        {
            SlotSelected(6);
        }

        private void gameButton7_Click(object sender, EventArgs e)
        {
            SlotSelected(7);
        }

        private void gameButton8_Click(object sender, EventArgs e)
        {
            SlotSelected(8);
        }

        private void gameButton9_Click(object sender, EventArgs e)
        {
            SlotSelected(9);
        }
    }
}
