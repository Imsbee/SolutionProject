using System;
using System.Drawing;
using System.Threading;
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
        int num;
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
            num = 0;

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
            if (e.KeyCode == Keys.Right ) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }

            if (Star1.Right >= Ball.Left) 
            {
                Star1.Location = new Point(-10000, 10000);
                num++; 
            }

            if (Star2.Left <= Ball.Right)
            {
                Star2.Location = new Point(10000, 10000);
                num++;
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
            if (num == 2)
            {
                gameTimer.Stop();
                Form1 frm1 = new Form1();
                frm1.Hide();
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                //MessageBox.Show("게임 클리어!!!");
            }

            if (right == true && Wall7.Left >= Ball.Right) { Ball.Left += 5; }
            if (left == true && Wall1.Right <= Ball.Left) { Ball.Left -= 5; }

            if (jump == true)
            {
                // 점프 
                Ball.Top -= force;
                force -= 1;

                // 플레이어가 땅과 충돌 했을 때
                for (int i = 0; i < 6; i++)
                {
                    if (Ball.Right > PictureBoxes[i].Left && Ball.Left < PictureBoxes[i].Right
                    && Ball.Bottom >= PictureBoxes[i].Top && Ball.Top < PictureBoxes[i].Top)
                    {
                        force = gravity;   
                    }
                }
            }
        }
    }
}

