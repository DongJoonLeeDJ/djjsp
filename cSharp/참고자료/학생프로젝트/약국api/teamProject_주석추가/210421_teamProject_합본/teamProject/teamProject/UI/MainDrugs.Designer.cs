
namespace teamProject
{
    partial class MainDrugs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medCompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainIngrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 27);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "약품 정보 조회";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "품목명",
            "제조회사",
            "품목번호"});
            this.comboBox1.Location = new System.Drawing.Point(6, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "검색하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 24);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "재고적은순";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "재고많은순";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(501, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "정렬하기";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(645, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "약품 주문";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "담기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "주문하기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 27);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "주문 수량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "약품명";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medNameDataGridViewTextBoxColumn,
            this.medCompDataGridViewTextBoxColumn,
            this.medIdDataGridViewTextBoxColumn,
            this.chartDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.mainIngrDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(983, 552);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // medNameDataGridViewTextBoxColumn
            // 
            this.medNameDataGridViewTextBoxColumn.DataPropertyName = "MedName";
            this.medNameDataGridViewTextBoxColumn.HeaderText = "품목명";
            this.medNameDataGridViewTextBoxColumn.Name = "medNameDataGridViewTextBoxColumn";
            this.medNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medCompDataGridViewTextBoxColumn
            // 
            this.medCompDataGridViewTextBoxColumn.DataPropertyName = "MedComp";
            this.medCompDataGridViewTextBoxColumn.HeaderText = "제조회사";
            this.medCompDataGridViewTextBoxColumn.Name = "medCompDataGridViewTextBoxColumn";
            this.medCompDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medIdDataGridViewTextBoxColumn
            // 
            this.medIdDataGridViewTextBoxColumn.DataPropertyName = "MedId";
            this.medIdDataGridViewTextBoxColumn.HeaderText = "품목번호";
            this.medIdDataGridViewTextBoxColumn.Name = "medIdDataGridViewTextBoxColumn";
            this.medIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chartDataGridViewTextBoxColumn
            // 
            this.chartDataGridViewTextBoxColumn.DataPropertyName = "Chart";
            this.chartDataGridViewTextBoxColumn.HeaderText = "성상";
            this.chartDataGridViewTextBoxColumn.Name = "chartDataGridViewTextBoxColumn";
            this.chartDataGridViewTextBoxColumn.ReadOnly = true;
            this.chartDataGridViewTextBoxColumn.Width = 184;
            // 
            // formNameDataGridViewTextBoxColumn
            // 
            this.formNameDataGridViewTextBoxColumn.DataPropertyName = "FormName";
            this.formNameDataGridViewTextBoxColumn.HeaderText = "제형";
            this.formNameDataGridViewTextBoxColumn.Name = "formNameDataGridViewTextBoxColumn";
            this.formNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "약효분류";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainIngrDataGridViewTextBoxColumn
            // 
            this.mainIngrDataGridViewTextBoxColumn.DataPropertyName = "MainIngr";
            this.mainIngrDataGridViewTextBoxColumn.HeaderText = "주성분";
            this.mainIngrDataGridViewTextBoxColumn.Name = "mainIngrDataGridViewTextBoxColumn";
            this.mainIngrDataGridViewTextBoxColumn.ReadOnly = true;
            this.mainIngrDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "재고수량";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 95;
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataSource = typeof(teamProject.Drug);
            // 
            // MainDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "약품 정보";
            this.Load += new System.EventHandler(this.MainDrugs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn medNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medCompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainIngrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}