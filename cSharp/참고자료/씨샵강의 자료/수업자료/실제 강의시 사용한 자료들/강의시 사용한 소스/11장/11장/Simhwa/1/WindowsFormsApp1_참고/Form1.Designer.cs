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
            this.button_s = new System.Windows.Forms.Button();
            this.button_r = new System.Windows.Forms.Button();
            this.button_p = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_me = new System.Windows.Forms.Label();
            this.label_you = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_s
            // 
            this.button_s.Location = new System.Drawing.Point(13, 13);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(75, 23);
            this.button_s.TabIndex = 0;
            this.button_s.Text = "가위";
            this.button_s.UseVisualStyleBackColor = true;
            this.button_s.Click += new System.EventHandler(this.button_s_Click);
            // 
            // button_r
            // 
            this.button_r.Location = new System.Drawing.Point(95, 12);
            this.button_r.Name = "button_r";
            this.button_r.Size = new System.Drawing.Size(75, 23);
            this.button_r.TabIndex = 1;
            this.button_r.Text = "바위";
            this.button_r.UseVisualStyleBackColor = true;
            this.button_r.Click += new System.EventHandler(this.button_r_Click);
            // 
            // button_p
            // 
            this.button_p.Location = new System.Drawing.Point(177, 11);
            this.button_p.Name = "button_p";
            this.button_p.Size = new System.Drawing.Size(75, 23);
            this.button_p.TabIndex = 2;
            this.button_p.Text = "보";
            this.button_p.UseVisualStyleBackColor = true;
            this.button_p.Click += new System.EventHandler(this.button_p_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "나";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "컴퓨터";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "결과";
            // 
            // label_me
            // 
            this.label_me.AutoSize = true;
            this.label_me.Location = new System.Drawing.Point(65, 77);
            this.label_me.Name = "label_me";
            this.label_me.Size = new System.Drawing.Size(15, 15);
            this.label_me.TabIndex = 6;
            this.label_me.Text = "-";
            // 
            // label_you
            // 
            this.label_you.AutoSize = true;
            this.label_you.Location = new System.Drawing.Point(65, 107);
            this.label_you.Name = "label_you";
            this.label_you.Size = new System.Drawing.Size(45, 15);
            this.label_you.TabIndex = 7;
            this.label_you.Text = "label5";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(65, 141);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(45, 15);
            this.label_answer.TabIndex = 8;
            this.label_answer.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 232);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label_you);
            this.Controls.Add(this.label_me);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_p);
            this.Controls.Add(this.button_r);
            this.Controls.Add(this.button_s);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_s;
        private System.Windows.Forms.Button button_r;
        private System.Windows.Forms.Button button_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_me;
        private System.Windows.Forms.Label label_you;
        private System.Windows.Forms.Label label_answer;
    }
}

