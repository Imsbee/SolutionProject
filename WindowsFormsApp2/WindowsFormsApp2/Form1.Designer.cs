namespace WindowsFormsApp2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameArea = new System.Windows.Forms.Panel();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.playerPB = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.itemBox1 = new System.Windows.Forms.PictureBox();
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.itemBox1);
            this.gameArea.Controls.Add(this.ground4);
            this.gameArea.Controls.Add(this.ground3);
            this.gameArea.Controls.Add(this.ground2);
            this.gameArea.Controls.Add(this.ground1);
            this.gameArea.Controls.Add(this.playerPB);
            this.gameArea.Location = new System.Drawing.Point(12, 12);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(776, 426);
            this.gameArea.TabIndex = 0;
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Goldenrod;
            this.ground1.Location = new System.Drawing.Point(179, 361);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(100, 21);
            this.ground1.TabIndex = 1;
            this.ground1.TabStop = false;
            // 
            // playerPB
            // 
            this.playerPB.Image = ((System.Drawing.Image)(resources.GetObject("playerPB.Image")));
            this.playerPB.Location = new System.Drawing.Point(40, 361);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(61, 47);
            this.playerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPB.TabIndex = 0;
            this.playerPB.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.BackColor = System.Drawing.Color.Sienna;
            this.ground2.Location = new System.Drawing.Point(277, 304);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(100, 21);
            this.ground2.TabIndex = 2;
            this.ground2.TabStop = false;
            // 
            // ground3
            // 
            this.ground3.BackColor = System.Drawing.Color.Sienna;
            this.ground3.Location = new System.Drawing.Point(383, 257);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(100, 21);
            this.ground3.TabIndex = 3;
            this.ground3.TabStop = false;
            // 
            // ground4
            // 
            this.ground4.BackColor = System.Drawing.Color.Sienna;
            this.ground4.Location = new System.Drawing.Point(726, 166);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(24, 95);
            this.ground4.TabIndex = 4;
            this.ground4.TabStop = false;
            // 
            // itemBox1
            // 
            this.itemBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemBox1.Location = new System.Drawing.Point(484, 214);
            this.itemBox1.Name = "itemBox1";
            this.itemBox1.Size = new System.Drawing.Size(32, 26);
            this.itemBox1.TabIndex = 5;
            this.itemBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.gameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.PictureBox playerPB;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox ground4;
        private System.Windows.Forms.PictureBox ground3;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox itemBox1;
    }
}

