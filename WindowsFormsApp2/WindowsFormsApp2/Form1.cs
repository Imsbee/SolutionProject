using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool right, left;
        bool jump;
        bool double_jump;
        int gravity = 11;
        int force;
        PictureBox[] pictureBoxes = new PictureBox[4];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Left)
                left = true;
            if (double_jump == true &&  e.KeyCode == Keys.Space)
            {
                force = gravity; // 점프 뛰기
                double_jump = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jump = true; // 기본으로 튀는거
            double_jump = false;
            force = gravity;
            
            pictureBoxes[0] = ground1;
            pictureBoxes[1] = ground2;
            pictureBoxes[2] = ground3;
            pictureBoxes[3] = ground4;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true) { playerPB.Left += 5; }
            if (left == true) { playerPB.Left -= 5; }

            if (jump == true)
            {
                // 점프 
                playerPB.Top -= force;
                force -= 1;

                // 밑으로 떨어지지 않게 해주는 if문
                if (playerPB.Top + playerPB.Height >= gameArea.Height)
                {
                    playerPB.Top = gameArea.Height - playerPB.Height;
                    force = gravity;
                }

                // itembox에 닿았을 때
                if (playerPB.Right > itemBox1.Left && playerPB.Left < itemBox1.Right
                    && playerPB.Bottom >= itemBox1.Top && playerPB.Top < itemBox1.Top)
                {
                    double_jump = true;

                    while(true)
                    {
                        playerPB.Left += 5;
                        Thread.Sleep(1);

                        if (playerPB.Right >= ground4.Left)
                        {
                            break;
                        }
                    }
                    
                }

                if (playerPB.Right > ground3.Left && playerPB.Left < ground3.Right
                    && playerPB.Bottom >= ground3.Top && playerPB.Top < ground3.Top)
                {
                    ground3.Hide();
                    force = gravity;
                    ground3.Location = new Point(10000, 10000);
                }

                for (int i = 0; i < 4; i++)
                {
                    if (playerPB.Right > pictureBoxes[i].Left && playerPB.Left < pictureBoxes[i].Right
                    && playerPB.Bottom >= pictureBoxes[i].Top && playerPB.Top < pictureBoxes[i].Top) // 땅에 닿았을 때
                    {
                        force = gravity;
                    }
                }
                

            }
        }
    }
}
