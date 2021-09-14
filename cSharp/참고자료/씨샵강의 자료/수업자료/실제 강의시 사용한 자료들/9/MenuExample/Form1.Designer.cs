namespace MenuExample
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사운드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.속도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배속ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배속ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.배속ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사운드ToolStripMenuItem,
            this.속도ToolStripMenuItem,
            this.화면ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 사운드ToolStripMenuItem
            // 
            this.사운드ToolStripMenuItem.Name = "사운드ToolStripMenuItem";
            this.사운드ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.사운드ToolStripMenuItem.Text = "사운드";
            // 
            // 속도ToolStripMenuItem
            // 
            this.속도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배속ToolStripMenuItem,
            this.배속ToolStripMenuItem1,
            this.배속ToolStripMenuItem2});
            this.속도ToolStripMenuItem.Name = "속도ToolStripMenuItem";
            this.속도ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.속도ToolStripMenuItem.Text = "속도";
            // 
            // 배속ToolStripMenuItem
            // 
            this.배속ToolStripMenuItem.Name = "배속ToolStripMenuItem";
            this.배속ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.배속ToolStripMenuItem.Text = "0.5배속";
            // 
            // 배속ToolStripMenuItem1
            // 
            this.배속ToolStripMenuItem1.Name = "배속ToolStripMenuItem1";
            this.배속ToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.배속ToolStripMenuItem1.Text = "1배속";
            // 
            // 배속ToolStripMenuItem2
            // 
            this.배속ToolStripMenuItem2.Name = "배속ToolStripMenuItem2";
            this.배속ToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.배속ToolStripMenuItem2.Text = "2배속";
            // 
            // 화면ToolStripMenuItem
            // 
            this.화면ToolStripMenuItem.Name = "화면ToolStripMenuItem";
            this.화면ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.화면ToolStripMenuItem.Text = "화면";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 도움말보기ToolStripMenuItem
            // 
            this.도움말보기ToolStripMenuItem.Name = "도움말보기ToolStripMenuItem";
            this.도움말보기ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.도움말보기ToolStripMenuItem.Text = "도움말보기";
            this.도움말보기ToolStripMenuItem.Click += new System.EventHandler(this.도움말보기ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 155);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(295, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 177);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사운드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 속도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배속ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배속ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 배속ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 화면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

