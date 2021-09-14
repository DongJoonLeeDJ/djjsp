namespace Practice1
{
    partial class MacForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_nowCdkey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cdkey = new System.Windows.Forms.TextBox();
            this.button_changecdkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 CdKey : ";
            // 
            // label_nowCdkey
            // 
            this.label_nowCdkey.AutoSize = true;
            this.label_nowCdkey.Location = new System.Drawing.Point(102, 13);
            this.label_nowCdkey.Name = "label_nowCdkey";
            this.label_nowCdkey.Size = new System.Drawing.Size(101, 12);
            this.label_nowCdkey.TabIndex = 1;
            this.label_nowCdkey.Text = "5555555555555555";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "변경 CdKey : ";
            // 
            // textBox_cdkey
            // 
            this.textBox_cdkey.Location = new System.Drawing.Point(104, 39);
            this.textBox_cdkey.Name = "textBox_cdkey";
            this.textBox_cdkey.Size = new System.Drawing.Size(100, 21);
            this.textBox_cdkey.TabIndex = 3;
            // 
            // button_changecdkey
            // 
            this.button_changecdkey.Location = new System.Drawing.Point(210, 39);
            this.button_changecdkey.Name = "button_changecdkey";
            this.button_changecdkey.Size = new System.Drawing.Size(75, 23);
            this.button_changecdkey.TabIndex = 4;
            this.button_changecdkey.Text = "변경";
            this.button_changecdkey.UseVisualStyleBackColor = true;
            this.button_changecdkey.Click += new System.EventHandler(this.button_changecdkey_Click);
            // 
            // MacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 329);
            this.Controls.Add(this.button_changecdkey);
            this.Controls.Add(this.textBox_cdkey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_nowCdkey);
            this.Controls.Add(this.label1);
            this.Name = "MacForm";
            this.Text = "Mac Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nowCdkey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cdkey;
        private System.Windows.Forms.Button button_changecdkey;
    }
}