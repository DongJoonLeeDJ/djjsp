namespace Power
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
            this.button_power = new System.Windows.Forms.Button();
            this.button2_multi = new System.Windows.Forms.Button();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_multi_num1 = new System.Windows.Forms.TextBox();
            this.textBox_multi_num2 = new System.Windows.Forms.TextBox();
            this.label_power = new System.Windows.Forms.Label();
            this.label_multi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_power
            // 
            this.button_power.Location = new System.Drawing.Point(227, 30);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(75, 23);
            this.button_power.TabIndex = 0;
            this.button_power.Text = "제곱";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // button2_multi
            // 
            this.button2_multi.Location = new System.Drawing.Point(227, 61);
            this.button2_multi.Name = "button2_multi";
            this.button2_multi.Size = new System.Drawing.Size(75, 23);
            this.button2_multi.TabIndex = 1;
            this.button2_multi.Text = "곱하기";
            this.button2_multi.UseVisualStyleBackColor = true;
            this.button2_multi.Click += new System.EventHandler(this.button2_multi_Click);
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(12, 32);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(100, 21);
            this.textBox_num1.TabIndex = 2;
            // 
            // textBox_multi_num1
            // 
            this.textBox_multi_num1.Location = new System.Drawing.Point(12, 61);
            this.textBox_multi_num1.Name = "textBox_multi_num1";
            this.textBox_multi_num1.Size = new System.Drawing.Size(100, 21);
            this.textBox_multi_num1.TabIndex = 3;
            // 
            // textBox_multi_num2
            // 
            this.textBox_multi_num2.Location = new System.Drawing.Point(121, 61);
            this.textBox_multi_num2.Name = "textBox_multi_num2";
            this.textBox_multi_num2.Size = new System.Drawing.Size(100, 21);
            this.textBox_multi_num2.TabIndex = 4;
            // 
            // label_power
            // 
            this.label_power.AutoSize = true;
            this.label_power.Location = new System.Drawing.Point(321, 30);
            this.label_power.Name = "label_power";
            this.label_power.Size = new System.Drawing.Size(38, 12);
            this.label_power.TabIndex = 5;
            this.label_power.Text = "label1";
            // 
            // label_multi
            // 
            this.label_multi.AutoSize = true;
            this.label_multi.Location = new System.Drawing.Point(323, 61);
            this.label_multi.Name = "label_multi";
            this.label_multi.Size = new System.Drawing.Size(38, 12);
            this.label_multi.TabIndex = 6;
            this.label_multi.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_multi);
            this.Controls.Add(this.label_power);
            this.Controls.Add(this.textBox_multi_num2);
            this.Controls.Add(this.textBox_multi_num1);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.button2_multi);
            this.Controls.Add(this.button_power);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button2_multi;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_multi_num1;
        private System.Windows.Forms.TextBox textBox_multi_num2;
        private System.Windows.Forms.Label label_power;
        private System.Windows.Forms.Label label_multi;
    }
}

