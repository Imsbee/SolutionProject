using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool right, left;
        bool jump;
        bool double_jump;
        int gravity = 11;
        int force;
        PictureBox[] PictureBoxes = new PictureBox[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jump = true; // jump 상태를 true로 변경(계속 점프 하기 위해)
            double_jump = false; // double jump item을 먹기 전까지는 double_jump를 비활성화
            force = gravity; // 얼마나 뛸지 값을 int형으로 지정

            // 벽을 picturebox배열에 넣기
            PictureBoxes[0] = Wall1;
            PictureBoxes[1] = Wall2;
            PictureBoxes[2] = Wall3;
            PictureBoxes[3] = Wall4;
            PictureBoxes[4] = Wall5;
            PictureBoxes[5] = Wall6;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 플레이어의 이동을 설정. 오른쪽 키를 누르면 오른쪽으로 이동, 왼쪽 키를 누르면 왼쪽으로 이동
            if (e.KeyCode == Keys.Right ) 
            {
                if (Wall7.Left <= Ball.Right)
                {
                    Ball.Location = new Point(Wall7.Left, Ball.Location.Y);
                    right = false;
                }
                else if (Wall7.Left >= Ball.Right)
                {
                    right = true;
                }
            }
            if (e.KeyCode == Keys.Left) 
            {
                if (Wall1.Right >= Ball.Left)
                {
                    Ball.Location = new Point(Wall1.Right, Ball.Location.Y);
                    left = false;
                }
                else if (Wall1.Right <= Ball.Left)
                {
                    left = true;
                }
            }
            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // (오른쪽/왼쪽)키에서 손을 땠을 때 이동을 비활성화
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (right == true) { Ball.Left += 5; }
            if (left == true) { Ball.Left -= 5; }

            if (jump == true)
            {
                // 점프 
                Ball.Top -= force;
                force -= 1;
            }



            // 컴퓨터가 땅을 인식할 수 있게 해주는 코드
            for (int i = 0; i < 6; i++)
            {
                if (Ball.Right > PictureBoxes[i].Left && Ball.Left < PictureBoxes[i].Right
                && Ball.Bottom >= PictureBoxes[i].Top && Ball.Top < PictureBoxes[i].Top && force != 11) 
                {
                    force = gravity;

                }
            }
        }
    }
}

