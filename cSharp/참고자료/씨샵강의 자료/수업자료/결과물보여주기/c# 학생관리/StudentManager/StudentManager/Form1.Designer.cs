namespace StudentManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_student = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.textBox_grade = new System.Windows.Forms.TextBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.tabPage_major = new System.Windows.Forms.TabPage();
            this.textBox_major_code = new System.Windows.Forms.TextBox();
            this.textBox_major_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_select_major = new System.Windows.Forms.Button();
            this.button_del_major = new System.Windows.Forms.Button();
            this.button_modify_major = new System.Windows.Forms.Button();
            this.button_add_major = new System.Windows.Forms.Button();
            this.dataGridView_major = new System.Windows.Forms.DataGridView();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMajorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMajorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.tabPage_major.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_major)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_student);
            this.tabControl1.Controls.Add(this.tabPage_major);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_student
            // 
            this.tabPage_student.Controls.Add(this.label4);
            this.tabPage_student.Controls.Add(this.label3);
            this.tabPage_student.Controls.Add(this.label2);
            this.tabPage_student.Controls.Add(this.label1);
            this.tabPage_student.Controls.Add(this.button_select);
            this.tabPage_student.Controls.Add(this.textBox_grade);
            this.tabPage_student.Controls.Add(this.textBox_score);
            this.tabPage_student.Controls.Add(this.textBox_id);
            this.tabPage_student.Controls.Add(this.textBox_name);
            this.tabPage_student.Controls.Add(this.button_modify);
            this.tabPage_student.Controls.Add(this.button_del);
            this.tabPage_student.Controls.Add(this.button_add);
            this.tabPage_student.Controls.Add(this.dataGridView_Students);
            this.tabPage_student.Location = new System.Drawing.Point(4, 22);
            this.tabPage_student.Name = "tabPage_student";
            this.tabPage_student.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_student.Size = new System.Drawing.Size(742, 378);
            this.tabPage_student.TabIndex = 0;
            this.tabPage_student.Text = "학생";
            this.tabPage_student.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "학년";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "평점";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "학번";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "이름";
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(302, 201);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 23);
            this.button_select.TabIndex = 7;
            this.button_select.Text = "조회";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // textBox_grade
            // 
            this.textBox_grade.Location = new System.Drawing.Point(74, 313);
            this.textBox_grade.Name = "textBox_grade";
            this.textBox_grade.Size = new System.Drawing.Size(100, 21);
            this.textBox_grade.TabIndex = 6;
            // 
            // textBox_score
            // 
            this.textBox_score.Location = new System.Drawing.Point(74, 286);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(100, 21);
            this.textBox_score.TabIndex = 5;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(74, 258);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 21);
            this.textBox_id.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(74, 231);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 5;
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(206, 201);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(75, 23);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "수정";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(109, 201);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "삭제";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(9, 201);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.AutoGenerateColumns = false;
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNameDataGridViewTextBoxColumn,
            this.mIdDataGridViewTextBoxColumn,
            this.mScoreDataGridViewTextBoxColumn,
            this.mGradeDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn});
            this.dataGridView_Students.DataSource = this.studentBindingSource;
            this.dataGridView_Students.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.RowTemplate.Height = 23;
            this.dataGridView_Students.Size = new System.Drawing.Size(722, 188);
            this.dataGridView_Students.TabIndex = 0;
            this.dataGridView_Students.CurrentCellChanged += new System.EventHandler(this.dataGridView_Students_CurrentCellChanged);
            // 
            // tabPage_major
            // 
            this.tabPage_major.Controls.Add(this.textBox_major_code);
            this.tabPage_major.Controls.Add(this.textBox_major_name);
            this.tabPage_major.Controls.Add(this.label6);
            this.tabPage_major.Controls.Add(this.label5);
            this.tabPage_major.Controls.Add(this.button_select_major);
            this.tabPage_major.Controls.Add(this.button_del_major);
            this.tabPage_major.Controls.Add(this.button_modify_major);
            this.tabPage_major.Controls.Add(this.button_add_major);
            this.tabPage_major.Controls.Add(this.dataGridView_major);
            this.tabPage_major.Location = new System.Drawing.Point(4, 22);
            this.tabPage_major.Name = "tabPage_major";
            this.tabPage_major.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_major.Size = new System.Drawing.Size(742, 378);
            this.tabPage_major.TabIndex = 1;
            this.tabPage_major.Text = "학과";
            this.tabPage_major.UseVisualStyleBackColor = true;
            // 
            // textBox_major_code
            // 
            this.textBox_major_code.Location = new System.Drawing.Point(57, 254);
            this.textBox_major_code.Name = "textBox_major_code";
            this.textBox_major_code.Size = new System.Drawing.Size(100, 21);
            this.textBox_major_code.TabIndex = 5;
            // 
            // textBox_major_name
            // 
            this.textBox_major_name.Location = new System.Drawing.Point(57, 227);
            this.textBox_major_name.Name = "textBox_major_name";
            this.textBox_major_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_major_name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "과코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "학과명";
            // 
            // button_select_major
            // 
            this.button_select_major.Location = new System.Drawing.Point(252, 201);
            this.button_select_major.Name = "button_select_major";
            this.button_select_major.Size = new System.Drawing.Size(75, 23);
            this.button_select_major.TabIndex = 2;
            this.button_select_major.Text = "조회";
            this.button_select_major.UseVisualStyleBackColor = true;
            this.button_select_major.Click += new System.EventHandler(this.button_select_major_Click);
            // 
            // button_del_major
            // 
            this.button_del_major.Location = new System.Drawing.Point(171, 201);
            this.button_del_major.Name = "button_del_major";
            this.button_del_major.Size = new System.Drawing.Size(75, 23);
            this.button_del_major.TabIndex = 2;
            this.button_del_major.Text = "삭제";
            this.button_del_major.UseVisualStyleBackColor = true;
            this.button_del_major.Click += new System.EventHandler(this.button_del_major_Click);
            // 
            // button_modify_major
            // 
            this.button_modify_major.Location = new System.Drawing.Point(90, 201);
            this.button_modify_major.Name = "button_modify_major";
            this.button_modify_major.Size = new System.Drawing.Size(75, 23);
            this.button_modify_major.TabIndex = 2;
            this.button_modify_major.Text = "수정";
            this.button_modify_major.UseVisualStyleBackColor = true;
            this.button_modify_major.Click += new System.EventHandler(this.button_modify_major_Click);
            // 
            // button_add_major
            // 
            this.button_add_major.Location = new System.Drawing.Point(9, 201);
            this.button_add_major.Name = "button_add_major";
            this.button_add_major.Size = new System.Drawing.Size(75, 23);
            this.button_add_major.TabIndex = 2;
            this.button_add_major.Text = "추가";
            this.button_add_major.UseVisualStyleBackColor = true;
            this.button_add_major.Click += new System.EventHandler(this.button_add_major_Click);
            // 
            // dataGridView_major
            // 
            this.dataGridView_major.AutoGenerateColumns = false;
            this.dataGridView_major.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_major.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mMajorNameDataGridViewTextBoxColumn,
            this.mMajorCodeDataGridViewTextBoxColumn});
            this.dataGridView_major.DataSource = this.majorBindingSource;
            this.dataGridView_major.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_major.Name = "dataGridView_major";
            this.dataGridView_major.RowTemplate.Height = 23;
            this.dataGridView_major.Size = new System.Drawing.Size(364, 186);
            this.dataGridView_major.TabIndex = 1;
            this.dataGridView_major.CurrentCellChanged += new System.EventHandler(this.dataGridView_major_CurrentCellChanged);
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            // 
            // mIdDataGridViewTextBoxColumn
            // 
            this.mIdDataGridViewTextBoxColumn.DataPropertyName = "mId";
            this.mIdDataGridViewTextBoxColumn.HeaderText = "학번";
            this.mIdDataGridViewTextBoxColumn.Name = "mIdDataGridViewTextBoxColumn";
            // 
            // mScoreDataGridViewTextBoxColumn
            // 
            this.mScoreDataGridViewTextBoxColumn.DataPropertyName = "mScore";
            this.mScoreDataGridViewTextBoxColumn.HeaderText = "평점";
            this.mScoreDataGridViewTextBoxColumn.Name = "mScoreDataGridViewTextBoxColumn";
            // 
            // mGradeDataGridViewTextBoxColumn
            // 
            this.mGradeDataGridViewTextBoxColumn.DataPropertyName = "mGrade";
            this.mGradeDataGridViewTextBoxColumn.HeaderText = "학년";
            this.mGradeDataGridViewTextBoxColumn.Name = "mGradeDataGridViewTextBoxColumn";
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "등록일시";
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentManager.Student);
            // 
            // mMajorNameDataGridViewTextBoxColumn
            // 
            this.mMajorNameDataGridViewTextBoxColumn.DataPropertyName = "mMajorName";
            this.mMajorNameDataGridViewTextBoxColumn.HeaderText = "학과명";
            this.mMajorNameDataGridViewTextBoxColumn.Name = "mMajorNameDataGridViewTextBoxColumn";
            // 
            // mMajorCodeDataGridViewTextBoxColumn
            // 
            this.mMajorCodeDataGridViewTextBoxColumn.DataPropertyName = "mMajorCode";
            this.mMajorCodeDataGridViewTextBoxColumn.HeaderText = "과코드";
            this.mMajorCodeDataGridViewTextBoxColumn.Name = "mMajorCodeDataGridViewTextBoxColumn";
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(StudentManager.Major);
            // 
            // dataManagerBindingSource
            // 
            this.dataManagerBindingSource.DataSource = typeof(StudentManager.DataManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 402);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_student.ResumeLayout(false);
            this.tabPage_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            this.tabPage_major.ResumeLayout(false);
            this.tabPage_major.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_major)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_student;
        private System.Windows.Forms.TabPage tabPage_major;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.TextBox textBox_grade;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_major;
        private System.Windows.Forms.BindingSource dataManagerBindingSource;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private System.Windows.Forms.Button button_select_major;
        private System.Windows.Forms.Button button_del_major;
        private System.Windows.Forms.Button button_modify_major;
        private System.Windows.Forms.Button button_add_major;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMajorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMajorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_major_code;
        private System.Windows.Forms.TextBox textBox_major_name;
    }
}

