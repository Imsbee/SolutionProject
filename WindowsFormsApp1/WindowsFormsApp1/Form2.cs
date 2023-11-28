using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool right, left;
        bool jump;
        bool double_jump;
        int gravity = 11;
        int force;
        int num;
        PictureBox[] PictureBoxes = new PictureBox[8];
        PictureBox[] one = new PictureBox[9];
        Point[] p = new Point[9];


        public Form2()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (right == true && Wall8.Left >= Ball.Right) { Ball.Left += 5; }
            if (left == true && Wall1.Right <= Ball.Left) { Ball.Left -= 5; }

            if (jump == true)
            {
                // 점프 
                Ball.Top -= force;
                force -= 1;

                // 플레이어가 땅과 충돌 했을 때
                for (int i = 0; i < 8; i++)
                {
                    if (Ball.Right > PictureBoxes[i].Left && Ball.Left < PictureBoxes[i].Right
                    && Ball.Bottom >= PictureBoxes[i].Top && Ball.Top < PictureBoxes[i].Top)
                    {
                        force = gravity;
                    }
                }

                // 한 번 밟으면 사라지는 블럭과 충돌 했을 때
                for (int i = 0; i < 9; i++)
                {
                    if (Ball.Right > one[i].Left && Ball.Left < one[i].Right
                    && Ball.Bottom >= one[i].Top && Ball.Top < one[i].Top)
                    {
                        force = gravity;
                        one[i].Location = new Point(10000, 10000);
                    }
                }

                // 점프 블럭과 충돌했을 때
                if (Ball.Right > UpKey.Left && Ball.Left < UpKey.Right
                    && Ball.Bottom >= UpKey.Top && Ball.Top < UpKey.Top)
                {
                    force = 16;
                }

                // 장매물과 부딪혔을 때 플레이어의 위치를 처음 위치로 초기화
                if (Ball.Right > Hurdle.Left && Ball.Left < Hurdle.Right
                    && Ball.Bottom >= Hurdle.Top && Ball.Top < Hurdle.Top)
                {
                    Ball.Location = new Point(47, 184);

                    one1.Location = new Point(p[0].X, p[0].Y);
                    one2.Location = new Point(p[1].X, p[1].Y);
                    one3.Location = new Point(p[2].X, p[2].Y);
                    one4.Location = new Point(p[3].X, p[3].Y);
                    one5.Location = new Point(p[4].X, p[4].Y);
                    one6.Location = new Point(p[5].X, p[5].Y);
                    one7.Location = new Point(p[6].X, p[6].Y);
                    one8.Location = new Point(p[7].X, p[7].Y);
                    one9.Location = new Point(p[8].X, p[8].Y);
                }
            }

            if (num == 1)
            {
                gameTimer.Stop();
                MessageBox.Show("게임 클리어!!!");
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            // 플레이어의 이동을 설정. 오른쪽 키를 누르면 오른쪽으로 이동, 왼쪽 키를 누르면 왼쪽으로 이동
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }

            if (Star1.Left <= Ball.Right)
            {
                Star1.Location = new Point(10000, 10000);
                num++;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            // (오른쪽/왼쪽)키에서 손을 땠을 때 이동을 비활성화
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            jump = true; // jump 상태를 true로 변경(계속 점프 하기 위해)
            double_jump = false; // double jump item을 먹기 전까지는 double_jump를 비활성화
            force = gravity; // 얼마나 뛸지 값을 int형으로 지정
            num = 0;

            // 벽을 picturebox배열에 넣기
            PictureBoxes[0] = Wall1;
            PictureBoxes[1] = Wall2;
            PictureBoxes[2] = Wall3;
            PictureBoxes[3] = Wall4;
            PictureBoxes[4] = Wall5;
            PictureBoxes[5] = Wall6;
            PictureBoxes[6] = Wall7;
            PictureBoxes[7] = Wall8;

            // 한 번 밟으면 사라지는 블럭 배열에 넣기
            one[0] = one1;
            one[1] = one2;
            one[2] = one3;
            one[3] = one4;
            one[4] = one5;
            one[5] = one6;
            one[6] = one7;
            one[7] = one8;
            one[8] = one9;

            for (int i = 0; i < one.Length; i++)
            {
                p[i].X = one[i].Left;
                p[i].Y = one[i].Top;
            }
        }
    }
}
