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
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_directory_save = new System.Windows.Forms.TextBox();
            this.textBox_contents = new System.Windows.Forms.TextBox();
            this.label_contents = new System.Windows.Forms.Label();
            this.textBox_directory_load = new System.Windows.Forms.TextBox();
            this.textBox_filename_save = new System.Windows.Forms.TextBox();
            this.textBox_filename_load = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 12);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(12, 212);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox_directory_save
            // 
            this.textBox_directory_save.Location = new System.Drawing.Point(93, 12);
            this.textBox_directory_save.Name = "textBox_directory_save";
            this.textBox_directory_save.Size = new System.Drawing.Size(267, 21);
            this.textBox_directory_save.TabIndex = 2;
            // 
            // textBox_contents
            // 
            this.textBox_contents.Location = new System.Drawing.Point(93, 66);
            this.textBox_contents.Multiline = true;
            this.textBox_contents.Name = "textBox_contents";
            this.textBox_contents.Size = new System.Drawing.Size(418, 127);
            this.textBox_contents.TabIndex = 2;
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(91, 263);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(11, 12);
            this.label_contents.TabIndex = 3;
            this.label_contents.Text = "-";
            // 
            // textBox_directory_load
            // 
            this.textBox_directory_load.Location = new System.Drawing.Point(93, 212);
            this.textBox_directory_load.Name = "textBox_directory_load";
            this.textBox_directory_load.Size = new System.Drawing.Size(418, 21);
            this.textBox_directory_load.TabIndex = 4;
            // 
            // textBox_filename_save
            // 
            this.textBox_filename_save.Location = new System.Drawing.Point(93, 39);
            this.textBox_filename_save.Name = "textBox_filename_save";
            this.textBox_filename_save.Size = new System.Drawing.Size(169, 21);
            this.textBox_filename_save.TabIndex = 5;
            // 
            // textBox_filename_load
            // 
            this.textBox_filename_load.Location = new System.Drawing.Point(93, 239);
            this.textBox_filename_load.Name = "textBox_filename_load";
            this.textBox_filename_load.Size = new System.Drawing.Size(169, 21);
            this.textBox_filename_load.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "디렉토리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "파일명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "디렉토리";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "파일명";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_filename_load);
            this.Controls.Add(this.textBox_filename_save);
            this.Controls.Add(this.textBox_directory_load);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.textBox_contents);
            this.Controls.Add(this.textBox_directory_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TextBox textBox_directory_save;
        private System.Windows.Forms.TextBox textBox_contents;
        private System.Windows.Forms.Label label_contents;
        private System.Windows.Forms.TextBox textBox_directory_load;
        private System.Windows.Forms.TextBox textBox_filename_save;
        private System.Windows.Forms.TextBox textBox_filename_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

