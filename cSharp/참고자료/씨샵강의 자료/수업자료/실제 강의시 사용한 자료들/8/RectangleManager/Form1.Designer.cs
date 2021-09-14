namespace RectangleManager
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
            this.label_area = new System.Windows.Forms.Label();
            this.textBox_w = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.button_area = new System.Windows.Forms.Button();
            this.button_min_area = new System.Windows.Forms.Button();
            this.button_calcArea = new System.Windows.Forms.Button();
            this.button_max_area = new System.Windows.Forms.Button();
            this.label_max_area = new System.Windows.Forms.Label();
            this.label_min_area = new System.Windows.Forms.Label();
            this.label_area_2 = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.textBox_check_area = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "너비";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "높이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "넓이";
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(106, 121);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(11, 12);
            this.label_area.TabIndex = 3;
            this.label_area.Text = "-";
            // 
            // textBox_w
            // 
            this.textBox_w.Location = new System.Drawing.Point(108, 35);
            this.textBox_w.Name = "textBox_w";
            this.textBox_w.Size = new System.Drawing.Size(100, 21);
            this.textBox_w.TabIndex = 4;
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(108, 73);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 21);
            this.textBox_h.TabIndex = 5;
            // 
            // button_area
            // 
            this.button_area.Location = new System.Drawing.Point(232, 109);
            this.button_area.Name = "button_area";
            this.button_area.Size = new System.Drawing.Size(75, 23);
            this.button_area.TabIndex = 6;
            this.button_area.Text = "넓이";
            this.button_area.UseVisualStyleBackColor = true;
            this.button_area.Click += new System.EventHandler(this.button_area_Click);
            // 
            // button_min_area
            // 
            this.button_min_area.Location = new System.Drawing.Point(33, 196);
            this.button_min_area.Name = "button_min_area";
            this.button_min_area.Size = new System.Drawing.Size(75, 23);
            this.button_min_area.TabIndex = 7;
            this.button_min_area.Text = "최소넓이";
            this.button_min_area.UseVisualStyleBackColor = true;
            this.button_min_area.Click += new System.EventHandler(this.button_min_area_Click);
            // 
            // button_calcArea
            // 
            this.button_calcArea.Location = new System.Drawing.Point(426, 110);
            this.button_calcArea.Name = "button_calcArea";
            this.button_calcArea.Size = new System.Drawing.Size(75, 23);
            this.button_calcArea.TabIndex = 9;
            this.button_calcArea.Text = "-";
            this.button_calcArea.UseVisualStyleBackColor = true;
            this.button_calcArea.Click += new System.EventHandler(this.button_calcArea_Click);
            // 
            // button_max_area
            // 
            this.button_max_area.Location = new System.Drawing.Point(33, 158);
            this.button_max_area.Name = "button_max_area";
            this.button_max_area.Size = new System.Drawing.Size(75, 23);
            this.button_max_area.TabIndex = 10;
            this.button_max_area.Text = "최대넓이";
            this.button_max_area.UseVisualStyleBackColor = true;
            this.button_max_area.Click += new System.EventHandler(this.button_max_area_Click);
            // 
            // label_max_area
            // 
            this.label_max_area.AutoSize = true;
            this.label_max_area.Location = new System.Drawing.Point(117, 163);
            this.label_max_area.Name = "label_max_area";
            this.label_max_area.Size = new System.Drawing.Size(11, 12);
            this.label_max_area.TabIndex = 11;
            this.label_max_area.Text = "-";
            // 
            // label_min_area
            // 
            this.label_min_area.AutoSize = true;
            this.label_min_area.Location = new System.Drawing.Point(117, 201);
            this.label_min_area.Name = "label_min_area";
            this.label_min_area.Size = new System.Drawing.Size(11, 12);
            this.label_min_area.TabIndex = 12;
            this.label_min_area.Text = "-";
            // 
            // label_area_2
            // 
            this.label_area_2.AutoSize = true;
            this.label_area_2.Location = new System.Drawing.Point(364, 114);
            this.label_area_2.Name = "label_area_2";
            this.label_area_2.Size = new System.Drawing.Size(11, 12);
            this.label_area_2.TabIndex = 8;
            this.label_area_2.Text = "-";
            // 
            // button_check
            // 
            this.button_check.AutoSize = true;
            this.button_check.Location = new System.Drawing.Point(33, 239);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(111, 23);
            this.button_check.TabIndex = 13;
            this.button_check.Text = "적정넓이여부체크";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // textBox_check_area
            // 
            this.textBox_check_area.Location = new System.Drawing.Point(170, 241);
            this.textBox_check_area.Name = "textBox_check_area";
            this.textBox_check_area.Size = new System.Drawing.Size(100, 21);
            this.textBox_check_area.TabIndex = 14;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(293, 244);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(9, 12);
            this.label_result.TabIndex = 15;
            this.label_result.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_check_area);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.label_min_area);
            this.Controls.Add(this.label_max_area);
            this.Controls.Add(this.button_max_area);
            this.Controls.Add(this.button_calcArea);
            this.Controls.Add(this.label_area_2);
            this.Controls.Add(this.button_min_area);
            this.Controls.Add(this.button_area);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.textBox_w);
            this.Controls.Add(this.label_area);
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
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.TextBox textBox_w;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.Button button_area;
        private System.Windows.Forms.Button button_min_area;
        private System.Windows.Forms.Button button_calcArea;
        private System.Windows.Forms.Button button_max_area;
        private System.Windows.Forms.Label label_max_area;
        private System.Windows.Forms.Label label_min_area;
        private System.Windows.Forms.Label label_area_2;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.TextBox textBox_check_area;
        private System.Windows.Forms.Label label_result;
    }
}

