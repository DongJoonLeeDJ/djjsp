
namespace Book_re
{
    partial class BookInfoForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_discription = new Sunny.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DGV_bookinfo = new Sunny.UI.UIDataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.링크 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_booksearch = new Sunny.UI.UIButton();
            this.txt_booksearch = new Sunny.UI.UIRichTextBox();
            this.bt_exit = new Sunny.UI.UIImageButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_discription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_bookinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.DGV_discription);
            this.panel1.Controls.Add(this.DGV_bookinfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_booksearch);
            this.panel1.Controls.Add(this.txt_booksearch);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 532);
            this.panel1.TabIndex = 0;
            // 
            // DGV_discription
            // 
            this.DGV_discription.AllowUserToAddRows = false;
            this.DGV_discription.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MistyRose;
            this.DGV_discription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_discription.AutoGenerateColumns = false;
            this.DGV_discription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_discription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_discription.BackgroundColor = System.Drawing.Color.Maroon;
            this.DGV_discription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_discription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_discription.ColumnHeadersHeight = 32;
            this.DGV_discription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_discription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.DGV_discription.DataSource = this.nBookBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_discription.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_discription.EnableHeadersVisualStyles = false;
            this.DGV_discription.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DGV_discription.GridColor = System.Drawing.Color.White;
            this.DGV_discription.Location = new System.Drawing.Point(41, 356);
            this.DGV_discription.Name = "DGV_discription";
            this.DGV_discription.ReadOnly = true;
            this.DGV_discription.RectColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_discription.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_discription.RowHeadersVisible = false;
            this.DGV_discription.RowHeadersWidth = 82;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_discription.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_discription.RowTemplate.Height = 29;
            this.DGV_discription.SelectedIndex = -1;
            this.DGV_discription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_discription.ShowGridLine = true;
            this.DGV_discription.Size = new System.Drawing.Size(577, 158);
            this.DGV_discription.StripeEvenColor = System.Drawing.Color.MistyRose;
            this.DGV_discription.StripeOddColor = System.Drawing.Color.MistyRose;
            this.DGV_discription.Style = Sunny.UI.UIStyle.Custom;
            this.DGV_discription.StyleCustomMode = true;
            this.DGV_discription.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.FillWeight = 570F;
            this.dataGridViewTextBoxColumn4.HeaderText = "설명";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nBookBindingSource
            // 
//            this.nBookBindingSource.DataSource = typeof(Book_re.NBook);
            // 
            // DGV_bookinfo
            // 
            this.DGV_bookinfo.AllowUserToAddRows = false;
            this.DGV_bookinfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MistyRose;
            this.DGV_bookinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DGV_bookinfo.AutoGenerateColumns = false;
            this.DGV_bookinfo.BackgroundColor = System.Drawing.Color.Maroon;
            this.DGV_bookinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_bookinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGV_bookinfo.ColumnHeadersHeight = 32;
            this.DGV_bookinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_bookinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.링크});
            this.DGV_bookinfo.DataSource = this.nBookBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_bookinfo.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGV_bookinfo.EnableHeadersVisualStyles = false;
            this.DGV_bookinfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DGV_bookinfo.GridColor = System.Drawing.Color.White;
            this.DGV_bookinfo.Location = new System.Drawing.Point(213, 151);
            this.DGV_bookinfo.Name = "DGV_bookinfo";
            this.DGV_bookinfo.ReadOnly = true;
            this.DGV_bookinfo.RectColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_bookinfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGV_bookinfo.RowHeadersVisible = false;
            this.DGV_bookinfo.RowHeadersWidth = 82;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.MistyRose;
            this.DGV_bookinfo.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DGV_bookinfo.RowTemplate.Height = 29;
            this.DGV_bookinfo.SelectedIndex = -1;
            this.DGV_bookinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_bookinfo.ShowGridLine = true;
            this.DGV_bookinfo.Size = new System.Drawing.Size(405, 180);
            this.DGV_bookinfo.StripeEvenColor = System.Drawing.Color.MistyRose;
            this.DGV_bookinfo.StripeOddColor = System.Drawing.Color.MistyRose;
            this.DGV_bookinfo.Style = Sunny.UI.UIStyle.Custom;
            this.DGV_bookinfo.StyleCustomMode = true;
            this.DGV_bookinfo.TabIndex = 11;
            this.DGV_bookinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_bookinfo_CellClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 200F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "제목";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "저자";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 링크
            // 
            this.링크.DataPropertyName = "link";
            this.링크.HeaderText = "link";
            this.링크.Name = "링크";
            this.링크.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 180);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bt_booksearch
            // 
            this.bt_booksearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_booksearch.FillColor = System.Drawing.Color.Maroon;
            this.bt_booksearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_booksearch.Location = new System.Drawing.Point(518, 68);
            this.bt_booksearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_booksearch.Name = "bt_booksearch";
            this.bt_booksearch.Radius = 15;
            this.bt_booksearch.RectColor = System.Drawing.Color.Black;
            this.bt_booksearch.Size = new System.Drawing.Size(100, 35);
            this.bt_booksearch.Style = Sunny.UI.UIStyle.Custom;
            this.bt_booksearch.TabIndex = 6;
            this.bt_booksearch.Text = "Search";
            this.bt_booksearch.Click += new System.EventHandler(this.bt_booksearch_Click);
            // 
            // txt_booksearch
            // 
            this.txt_booksearch.AutoWordSelection = true;
            this.txt_booksearch.FillColor = System.Drawing.Color.White;
            this.txt_booksearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_booksearch.Location = new System.Drawing.Point(41, 68);
            this.txt_booksearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_booksearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_booksearch.Name = "txt_booksearch";
            this.txt_booksearch.Padding = new System.Windows.Forms.Padding(2);
            this.txt_booksearch.Radius = 20;
            this.txt_booksearch.RectColor = System.Drawing.Color.Silver;
            this.txt_booksearch.RectDisableColor = System.Drawing.Color.Maroon;
            this.txt_booksearch.Size = new System.Drawing.Size(456, 36);
            this.txt_booksearch.Style = Sunny.UI.UIStyle.Custom;
            this.txt_booksearch.TabIndex = 5;
            this.txt_booksearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_exit
            // 
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.Location = new System.Drawing.Point(606, 3);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(29, 28);
            this.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_exit.TabIndex = 4;
            this.bt_exit.TabStop = false;
            this.bt_exit.Text = null;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(75, 341);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 12);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "도서 구매 정보 이동";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(648, 542);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookInfoForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_discription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_bookinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIImageButton bt_exit;
        private Sunny.UI.UIButton bt_booksearch;
        private Sunny.UI.UIRichTextBox txt_booksearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIDataGridView DGV_bookinfo;
        private System.Windows.Forms.BindingSource nBookBindingSource;
        private Sunny.UI.UIDataGridView DGV_discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 링크;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}