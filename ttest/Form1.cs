using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttest
{
    public partial class Form1 : Form
    {
        bool right, left;
        bool jump;
        int gravity = 20;
        int force;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = gravity;
                }
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (right == true) { playerPB.Left += 5; }
            if (left == true) { playerPB.Left -= 5; }

            if (jump == true)
            {
                playerPB.Top -= force;
                force -= 1;
            }

            if (playerPB.Top + playerPB.Height >= gameArea.Height)
            {
                playerPB.Top = gameArea.Height - playerPB.Height;
                jump = false;
            }
            else
            {
                playerPB.Top += 5;
            }

            
            
        }
    }
}
