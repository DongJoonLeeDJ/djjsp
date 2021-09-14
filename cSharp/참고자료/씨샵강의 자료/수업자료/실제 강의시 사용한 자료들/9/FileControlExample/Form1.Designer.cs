namespace FileControlExample
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
            this.button_fileWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_contents = new System.Windows.Forms.TextBox();
            this.textBox_directory = new System.Windows.Forms.TextBox();
            this.label_contents = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.button_writeStream = new System.Windows.Forms.Button();
            this.label_readStream = new System.Windows.Forms.Label();
            this.button_readStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_fileWrite
            // 
            this.button_fileWrite.Location = new System.Drawing.Point(13, 13);
            this.button_fileWrite.Name = "button_fileWrite";
            this.button_fileWrite.Size = new System.Drawing.Size(86, 23);
            this.button_fileWrite.TabIndex = 0;
            this.button_fileWrite.Text = "파일에적기";
            this.button_fileWrite.UseVisualStyleBackColor = true;
            this.button_fileWrite.Click += new System.EventHandler(this.button_fileWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "경로";
            // 
            // textBox_contents
            // 
            this.textBox_contents.Location = new System.Drawing.Point(118, 13);
            this.textBox_contents.Name = "textBox_contents";
            this.textBox_contents.Size = new System.Drawing.Size(100, 21);
            this.textBox_contents.TabIndex = 2;
            // 
            // textBox_directory
            // 
            this.textBox_directory.Location = new System.Drawing.Point(118, 43);
            this.textBox_directory.Name = "textBox_directory";
            this.textBox_directory.Size = new System.Drawing.Size(100, 21);
            this.textBox_directory.TabIndex = 3;
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(116, 73);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(11, 12);
            this.label_contents.TabIndex = 4;
            this.label_contents.Text = "-";
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(14, 68);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(85, 23);
            this.button_read.TabIndex = 5;
            this.button_read.Text = "파일에서읽기";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_writeStream
            // 
            this.button_writeStream.Location = new System.Drawing.Point(349, 13);
            this.button_writeStream.Name = "button_writeStream";
            this.button_writeStream.Size = new System.Drawing.Size(133, 23);
            this.button_writeStream.TabIndex = 6;
            this.button_writeStream.Text = "Stream으로쓰기";
            this.button_writeStream.UseVisualStyleBackColor = true;
            this.button_writeStream.Click += new System.EventHandler(this.button_writeStream_Click);
            // 
            // label_readStream
            // 
            this.label_readStream.AutoSize = true;
            this.label_readStream.Location = new System.Drawing.Point(349, 43);
            this.label_readStream.Name = "label_readStream";
            this.label_readStream.Size = new System.Drawing.Size(11, 12);
            this.label_readStream.TabIndex = 7;
            this.label_readStream.Text = "-";
            // 
            // button_readStream
            // 
            this.button_readStream.Location = new System.Drawing.Point(488, 13);
            this.button_readStream.Name = "button_readStream";
            this.button_readStream.Size = new System.Drawing.Size(133, 23);
            this.button_readStream.TabIndex = 8;
            this.button_readStream.Text = "Stream으로읽기";
            this.button_readStream.UseVisualStyleBackColor = true;
            this.button_readStream.Click += new System.EventHandler(this.button_readStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_readStream);
            this.Controls.Add(this.label_readStream);
            this.Controls.Add(this.button_writeStream);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.textBox_directory);
            this.Controls.Add(this.textBox_contents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fileWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_fileWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_contents;
        private System.Windows.Forms.TextBox textBox_directory;
        private System.Windows.Forms.Label label_contents;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_writeStream;
        private System.Windows.Forms.Label label_readStream;
        private System.Windows.Forms.Button button_readStream;
    }
}

