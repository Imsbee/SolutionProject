namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Star1 = new System.Windows.Forms.PictureBox();
            this.Star2 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.Wall7 = new System.Windows.Forms.PictureBox();
            this.Wall6 = new System.Windows.Forms.PictureBox();
            this.Wall3 = new System.Windows.Forms.PictureBox();
            this.Wall5 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.Control;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(572, 263);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 5;
            this.Ball.TabStop = false;
            // 
            // Star1
            // 
            this.Star1.BackColor = System.Drawing.SystemColors.Control;
            this.Star1.Image = ((System.Drawing.Image)(resources.GetObject("Star1.Image")));
            this.Star1.Location = new System.Drawing.Point(37, 174);
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(40, 40);
            this.Star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star1.TabIndex = 6;
            this.Star1.TabStop = false;
            // 
            // Star2
            // 
            this.Star2.BackColor = System.Drawing.Color.Yellow;
            this.Star2.Location = new System.Drawing.Point(1106, 174);
            this.Star2.Name = "Star2";
            this.Star2.Size = new System.Drawing.Size(40, 40);
            this.Star2.TabIndex = 7;
            this.Star2.TabStop = false;
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.Gray;
            this.Wall2.Location = new System.Drawing.Point(0, 211);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(320, 40);
            this.Wall2.TabIndex = 8;
            this.Wall2.TabStop = false;
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.Gray;
            this.Wall4.Location = new System.Drawing.Point(417, 299);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(353, 40);
            this.Wall4.TabIndex = 9;
            this.Wall4.TabStop = false;
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.Gray;
            this.Wall1.Location = new System.Drawing.Point(0, 64);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(40, 150);
            this.Wall1.TabIndex = 10;
            this.Wall1.TabStop = false;
            // 
            // Wall7
            // 
            this.Wall7.BackColor = System.Drawing.Color.Gray;
            this.Wall7.Location = new System.Drawing.Point(1143, 64);
            this.Wall7.Name = "Wall7";
            this.Wall7.Size = new System.Drawing.Size(40, 150);
            this.Wall7.TabIndex = 11;
            this.Wall7.TabStop = false;
            // 
            // Wall6
            // 
            this.Wall6.BackColor = System.Drawing.Color.Gray;
            this.Wall6.Location = new System.Drawing.Point(863, 211);
            this.Wall6.Name = "Wall6";
            this.Wall6.Size = new System.Drawing.Size(320, 40);
            this.Wall6.TabIndex = 12;
            this.Wall6.TabStop = false;
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.Color.Gray;
            this.Wall3.Location = new System.Drawing.Point(331, 253);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(80, 40);
            this.Wall3.TabIndex = 13;
            this.Wall3.TabStop = false;
            // 
            // Wall5
            // 
            this.Wall5.BackColor = System.Drawing.Color.Gray;
            this.Wall5.Location = new System.Drawing.Point(778, 253);
            this.Wall5.Name = "Wall5";
            this.Wall5.Size = new System.Drawing.Size(80, 40);
            this.Wall5.TabIndex = 14;
            this.Wall5.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.Wall5);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.Wall6);
            this.Controls.Add(this.Wall7);
            this.Controls.Add(this.Wall1);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Star2);
            this.Controls.Add(this.Star1);
            this.Controls.Add(this.Ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Star1;
        private System.Windows.Forms.PictureBox Star2;
        private System.Windows.Forms.PictureBox Wall2;
        private System.Windows.Forms.PictureBox Wall4;
        private System.Windows.Forms.PictureBox Wall1;
        private System.Windows.Forms.PictureBox Wall7;
        private System.Windows.Forms.PictureBox Wall6;
        private System.Windows.Forms.PictureBox Wall3;
        private System.Windows.Forms.PictureBox Wall5;
        private System.Windows.Forms.Timer gameTimer;
    }
}

