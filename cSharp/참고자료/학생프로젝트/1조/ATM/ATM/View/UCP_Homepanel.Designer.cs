
namespace ATM
{
    partial class UCP_Homepanel
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCP_Homepanel));
            this.button_noaccount = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Test_Mysql = new System.Windows.Forms.Button();
            this.button_HwanYoul = new System.Windows.Forms.Button();
            this.button_trans = new System.Windows.Forms.Button();
            this.button_myinfo = new System.Windows.Forms.Button();
            this.button_upbit = new System.Windows.Forms.Button();
            this.button_mycoin = new System.Windows.Forms.Button();
            this.button_trans_hist = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_noaccount
            // 
            this.button_noaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_noaccount.FlatAppearance.BorderSize = 0;
            this.button_noaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_noaccount.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_noaccount.Image = ((System.Drawing.Image)(resources.GetObject("button_noaccount.Image")));
            this.button_noaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_noaccount.Location = new System.Drawing.Point(3, 10);
            this.button_noaccount.Name = "button_noaccount";
            this.button_noaccount.Size = new System.Drawing.Size(140, 90);
            this.button_noaccount.TabIndex = 0;
            this.button_noaccount.Text = "   무통장\r\n    입금";
            this.button_noaccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_noaccount.UseVisualStyleBackColor = false;
            this.button_noaccount.Click += new System.EventHandler(this.button_noaccount_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.LightCoral;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Exit.Location = new System.Drawing.Point(371, 430);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(155, 90);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "종료";
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Test_Mysql
            // 
            this.button_Test_Mysql.Location = new System.Drawing.Point(0, 0);
            this.button_Test_Mysql.Name = "button_Test_Mysql";
            this.button_Test_Mysql.Size = new System.Drawing.Size(75, 23);
            this.button_Test_Mysql.TabIndex = 0;
            // 
            // button_HwanYoul
            // 
            this.button_HwanYoul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_HwanYoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_HwanYoul.FlatAppearance.BorderSize = 0;
            this.button_HwanYoul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HwanYoul.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_HwanYoul.Image = ((System.Drawing.Image)(resources.GetObject("button_HwanYoul.Image")));
            this.button_HwanYoul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HwanYoul.Location = new System.Drawing.Point(757, 10);
            this.button_HwanYoul.Name = "button_HwanYoul";
            this.button_HwanYoul.Size = new System.Drawing.Size(140, 90);
            this.button_HwanYoul.TabIndex = 3;
            this.button_HwanYoul.Text = "외화거래";
            this.button_HwanYoul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_HwanYoul.UseVisualStyleBackColor = false;
            this.button_HwanYoul.Click += new System.EventHandler(this.button_HwanYoul_Click);
            // 
            // button_trans
            // 
            this.button_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_trans.FlatAppearance.BorderSize = 0;
            this.button_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trans.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_trans.Image = ((System.Drawing.Image)(resources.GetObject("button_trans.Image")));
            this.button_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_trans.Location = new System.Drawing.Point(3, 123);
            this.button_trans.Name = "button_trans";
            this.button_trans.Size = new System.Drawing.Size(140, 90);
            this.button_trans.TabIndex = 4;
            this.button_trans.Text = "계좌이체";
            this.button_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trans.UseVisualStyleBackColor = false;
            this.button_trans.Click += new System.EventHandler(this.button_trans_Click);
            // 
            // button_myinfo
            // 
            this.button_myinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_myinfo.FlatAppearance.BorderSize = 0;
            this.button_myinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_myinfo.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_myinfo.Image = ((System.Drawing.Image)(resources.GetObject("button_myinfo.Image")));
            this.button_myinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_myinfo.Location = new System.Drawing.Point(3, 353);
            this.button_myinfo.Name = "button_myinfo";
            this.button_myinfo.Size = new System.Drawing.Size(140, 90);
            this.button_myinfo.TabIndex = 6;
            this.button_myinfo.Text = "    내\r\n계좌조회";
            this.button_myinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_myinfo.UseVisualStyleBackColor = false;
            this.button_myinfo.Click += new System.EventHandler(this.button_myinfo_Click);
            // 
            // button_upbit
            // 
            this.button_upbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_upbit.FlatAppearance.BorderSize = 0;
            this.button_upbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upbit.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_upbit.Image = ((System.Drawing.Image)(resources.GetObject("button_upbit.Image")));
            this.button_upbit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_upbit.Location = new System.Drawing.Point(757, 123);
            this.button_upbit.Name = "button_upbit";
            this.button_upbit.Size = new System.Drawing.Size(140, 90);
            this.button_upbit.TabIndex = 7;
            this.button_upbit.Text = "Upbit";
            this.button_upbit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_upbit.UseVisualStyleBackColor = false;
            this.button_upbit.Click += new System.EventHandler(this.button_upbit_Click);
            // 
            // button_mycoin
            // 
            this.button_mycoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_mycoin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_mycoin.FlatAppearance.BorderSize = 0;
            this.button_mycoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mycoin.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_mycoin.Image = ((System.Drawing.Image)(resources.GetObject("button_mycoin.Image")));
            this.button_mycoin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mycoin.Location = new System.Drawing.Point(757, 237);
            this.button_mycoin.Name = "button_mycoin";
            this.button_mycoin.Size = new System.Drawing.Size(140, 90);
            this.button_mycoin.TabIndex = 9;
            this.button_mycoin.Text = "My Coin";
            this.button_mycoin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_mycoin.UseVisualStyleBackColor = false;
            this.button_mycoin.Click += new System.EventHandler(this.button_mycoin_Click);
            // 
            // button_trans_hist
            // 
            this.button_trans_hist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_trans_hist.FlatAppearance.BorderSize = 0;
            this.button_trans_hist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trans_hist.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_trans_hist.Image = ((System.Drawing.Image)(resources.GetObject("button_trans_hist.Image")));
            this.button_trans_hist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_trans_hist.Location = new System.Drawing.Point(3, 237);
            this.button_trans_hist.Name = "button_trans_hist";
            this.button_trans_hist.Size = new System.Drawing.Size(140, 90);
            this.button_trans_hist.TabIndex = 10;
            this.button_trans_hist.Text = "거래내역\r\n   조회";
            this.button_trans_hist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trans_hist.UseVisualStyleBackColor = false;
            this.button_trans_hist.Click += new System.EventHandler(this.button_trans_hist_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Tan;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("배달의민족 주아", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.Image = ((System.Drawing.Image)(resources.GetObject("button_login.Image")));
            this.button_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_login.Location = new System.Drawing.Point(757, 353);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(140, 90);
            this.button_login.TabIndex = 12;
            this.button_login.Text = "계좌인증\r\n(로그인)";
            this.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.piggy_bank;
            this.pictureBox1.Location = new System.Drawing.Point(292, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("배달의민족 도현", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(282, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "GDGDG BANK";
            // 
            // UCP_Homepanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_trans_hist);
            this.Controls.Add(this.button_mycoin);
            this.Controls.Add(this.button_upbit);
            this.Controls.Add(this.button_myinfo);
            this.Controls.Add(this.button_trans);
            this.Controls.Add(this.button_HwanYoul);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_noaccount);
            this.Name = "UCP_Homepanel";
            this.Size = new System.Drawing.Size(900, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_noaccount;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Test_Mysql;
        private System.Windows.Forms.Button button_HwanYoul;
        private System.Windows.Forms.Button button_trans;
        private System.Windows.Forms.Button button_myinfo;
        private System.Windows.Forms.Button button_upbit;
        private System.Windows.Forms.Button button_mycoin;
        private System.Windows.Forms.Button button_trans_hist;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
