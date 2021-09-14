
namespace teamProject.UI
{
    partial class EmailForm
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
            this.sendbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toAddress_textBox = new System.Windows.Forms.TextBox();
            this.subject_textBox = new System.Windows.Forms.TextBox();
            this.body_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(287, 415);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 23);
            this.sendbutton.TabIndex = 0;
            this.sendbutton.Text = "send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "toAddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "subject";
            // 
            // toAddress_textBox
            // 
            this.toAddress_textBox.Location = new System.Drawing.Point(87, 19);
            this.toAddress_textBox.Name = "toAddress_textBox";
            this.toAddress_textBox.Size = new System.Drawing.Size(275, 21);
            this.toAddress_textBox.TabIndex = 3;
            // 
            // subject_textBox
            // 
            this.subject_textBox.Location = new System.Drawing.Point(87, 57);
            this.subject_textBox.Name = "subject_textBox";
            this.subject_textBox.Size = new System.Drawing.Size(275, 21);
            this.subject_textBox.TabIndex = 4;
            // 
            // body_textBox
            // 
            this.body_textBox.Location = new System.Drawing.Point(30, 102);
            this.body_textBox.Multiline = true;
            this.body_textBox.Name = "body_textBox";
            this.body_textBox.Size = new System.Drawing.Size(332, 291);
            this.body_textBox.TabIndex = 5;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.body_textBox);
            this.Controls.Add(this.subject_textBox);
            this.Controls.Add(this.toAddress_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendbutton);
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "발주 메일 전송";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toAddress_textBox;
        private System.Windows.Forms.TextBox subject_textBox;
        private System.Windows.Forms.TextBox body_textBox;
    }
}