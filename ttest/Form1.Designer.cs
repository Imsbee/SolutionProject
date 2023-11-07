namespace ttest
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
            this.playerPB = new System.Windows.Forms.PictureBox();
            this.gameArea = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.ground5 = new System.Windows.Forms.PictureBox();
            this.ground6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPB
            // 
            this.playerPB.BackColor = System.Drawing.Color.Magenta;
            this.playerPB.Location = new System.Drawing.Point(47, 466);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(49, 42);
            this.playerPB.TabIndex = 0;
            this.playerPB.TabStop = false;
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.ground6);
            this.gameArea.Controls.Add(this.ground5);
            this.gameArea.Controls.Add(this.ground4);
            this.gameArea.Controls.Add(this.ground3);
            this.gameArea.Controls.Add(this.ground2);
            this.gameArea.Controls.Add(this.ground1);
            this.gameArea.Controls.Add(this.playerPB);
            this.gameArea.Location = new System.Drawing.Point(12, 12);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(950, 508);
            this.gameArea.TabIndex = 1;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Sienna;
            this.ground1.Location = new System.Drawing.Point(106, 444);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(95, 22);
            this.ground1.TabIndex = 1;
            this.ground1.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.BackColor = System.Drawing.Color.Sienna;
            this.ground2.Location = new System.Drawing.Point(210, 409);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(95, 22);
            this.ground2.TabIndex = 2;
            this.ground2.TabStop = false;
            // 
            // ground3
            // 
            this.ground3.BackColor = System.Drawing.Color.Sienna;
            this.ground3.Location = new System.Drawing.Point(311, 370);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(95, 22);
            this.ground3.TabIndex = 3;
            this.ground3.TabStop = false;
            // 
            // ground4
            // 
            this.ground4.BackColor = System.Drawing.Color.Sienna;
            this.ground4.Location = new System.Drawing.Point(407, 328);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(95, 22);
            this.ground4.TabIndex = 4;
            this.ground4.TabStop = false;
            // 
            // ground5
            // 
            this.ground5.BackColor = System.Drawing.Color.Sienna;
            this.ground5.Location = new System.Drawing.Point(501, 288);
            this.ground5.Name = "ground5";
            this.ground5.Size = new System.Drawing.Size(95, 22);
            this.ground5.TabIndex = 5;
            this.ground5.TabStop = false;
            // 
            // ground6
            // 
            this.ground6.BackColor = System.Drawing.Color.Sienna;
            this.ground6.Location = new System.Drawing.Point(615, 328);
            this.ground6.Name = "ground6";
            this.ground6.Size = new System.Drawing.Size(95, 22);
            this.ground6.TabIndex = 6;
            this.ground6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 532);
            this.Controls.Add(this.gameArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).EndInit();
            this.gameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPB;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground6;
        private System.Windows.Forms.PictureBox ground5;
        private System.Windows.Forms.PictureBox ground4;
        private System.Windows.Forms.PictureBox ground3;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox ground1;
    }
}

