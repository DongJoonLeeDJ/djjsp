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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_abs = new System.Windows.Forms.Label();
            this.label_ceiling = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_floor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ceiling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Round";
            // 
            // label_abs
            // 
            this.label_abs.AutoSize = true;
            this.label_abs.Location = new System.Drawing.Point(70, 9);
            this.label_abs.Name = "label_abs";
            this.label_abs.Size = new System.Drawing.Size(38, 12);
            this.label_abs.TabIndex = 5;
            this.label_abs.Text = "label6";
            // 
            // label_ceiling
            // 
            this.label_ceiling.AutoSize = true;
            this.label_ceiling.Location = new System.Drawing.Point(70, 38);
            this.label_ceiling.Name = "label_ceiling";
            this.label_ceiling.Size = new System.Drawing.Size(38, 12);
            this.label_ceiling.TabIndex = 9;
            this.label_ceiling.Text = "label7";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(70, 79);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(38, 12);
            this.label_max.TabIndex = 8;
            this.label_max.Text = "label8";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(70, 103);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(38, 12);
            this.label_min.TabIndex = 7;
            this.label_min.Text = "label9";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.Location = new System.Drawing.Point(70, 131);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(44, 12);
            this.label_round.TabIndex = 6;
            this.label_round.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Floor";
            // 
            // label_floor
            // 
            this.label_floor.AutoSize = true;
            this.label_floor.Location = new System.Drawing.Point(70, 59);
            this.label_floor.Name = "label_floor";
            this.label_floor.Size = new System.Drawing.Size(38, 12);
            this.label_floor.TabIndex = 11;
            this.label_floor.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_floor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_ceiling);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label_abs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_abs;
        private System.Windows.Forms.Label label_ceiling;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_floor;
    }
}

