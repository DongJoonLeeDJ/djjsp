namespace MDITest
{
    partial class MainForm
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
            this.button_os1 = new System.Windows.Forms.Button();
            this.button_os2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_os1
            // 
            this.button_os1.Location = new System.Drawing.Point(14, 52);
            this.button_os1.Name = "button_os1";
            this.button_os1.Size = new System.Drawing.Size(75, 23);
            this.button_os1.TabIndex = 0;
            this.button_os1.Text = "OS1";
            this.button_os1.UseVisualStyleBackColor = true;
            this.button_os1.Click += new System.EventHandler(this.button_os1_Click);
            // 
            // button_os2
            // 
            this.button_os2.Location = new System.Drawing.Point(102, 52);
            this.button_os2.Name = "button_os2";
            this.button_os2.Size = new System.Drawing.Size(75, 23);
            this.button_os2.TabIndex = 1;
            this.button_os2.Text = "OS2";
            this.button_os2.UseVisualStyleBackColor = true;
            this.button_os2.Click += new System.EventHandler(this.button_os2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "당신 PC의 OS는 무엇입니까?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_os2);
            this.Controls.Add(this.button_os1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_os1;
        private System.Windows.Forms.Button button_os2;
        private System.Windows.Forms.Label label1;
    }
}

