namespace CarManager_Modified
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.listBox_logPrint = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_parkingRemove = new System.Windows.Forms.Button();
            this.button_parkingAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_parkingSpot_lookUp = new System.Windows.Forms.TextBox();
            this.button_SelectedLookUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_DisplayNowtime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Now = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_AllLookUp = new System.Windows.Forms.Button();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip_Now.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox2.Location = new System.Drawing.Point(13, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 현황";
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.AllowUserToAddRows = false;
            this.dataGridView_parkingManager.AllowUserToDeleteRows = false;
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(6, 18);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.ReadOnly = true;
            this.dataGridView_parkingManager.RowHeadersWidth = 51;
            this.dataGridView_parkingManager.RowTemplate.Height = 23;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(971, 294);
            this.dataGridView_parkingManager.TabIndex = 2;
            this.dataGridView_parkingManager.CurrentCellChanged += new System.EventHandler(this.dataGridView_parkingManager_CurrentCellChanged);
            // 
            // listBox_logPrint
            // 
            this.listBox_logPrint.FormattingEnabled = true;
            this.listBox_logPrint.HorizontalScrollbar = true;
            this.listBox_logPrint.ItemHeight = 12;
            this.listBox_logPrint.Location = new System.Drawing.Point(19, 501);
            this.listBox_logPrint.Name = "listBox_logPrint";
            this.listBox_logPrint.Size = new System.Drawing.Size(977, 88);
            this.listBox_logPrint.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_parkingSpot);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_phoneNumber);
            this.groupBox4.Controls.Add(this.textBox_driverName);
            this.groupBox4.Controls.Add(this.textBox_carNumber);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button_parkingRemove);
            this.groupBox4.Controls.Add(this.button_parkingAdd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(19, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 132);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "주차/출차";
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(73, 16);
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(100, 21);
            this.textBox_parkingSpot.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "공간번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "전화번호";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(73, 102);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_phoneNumber.TabIndex = 7;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(73, 75);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 21);
            this.textBox_driverName.TabIndex = 6;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(73, 48);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_carNumber.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "차주이름";
            // 
            // button_parkingRemove
            // 
            this.button_parkingRemove.Location = new System.Drawing.Point(205, 49);
            this.button_parkingRemove.Name = "button_parkingRemove";
            this.button_parkingRemove.Size = new System.Drawing.Size(75, 23);
            this.button_parkingRemove.TabIndex = 2;
            this.button_parkingRemove.Text = "출차";
            this.button_parkingRemove.UseVisualStyleBackColor = true;
            this.button_parkingRemove.Click += new System.EventHandler(this.button_parkingRemove_Click);
            // 
            // button_parkingAdd
            // 
            this.button_parkingAdd.Location = new System.Drawing.Point(205, 20);
            this.button_parkingAdd.Name = "button_parkingAdd";
            this.button_parkingAdd.Size = new System.Drawing.Size(75, 23);
            this.button_parkingAdd.TabIndex = 1;
            this.button_parkingAdd.Text = "주차";
            this.button_parkingAdd.UseVisualStyleBackColor = true;
            this.button_parkingAdd.Click += new System.EventHandler(this.button_parkingAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "차량번호";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AllLookUp);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_parkingSpot_lookUp);
            this.groupBox1.Controls.Add(this.button_SelectedLookUp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(355, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 123);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차 공간 현황 관리";
            // 
            // textBox_parkingSpot_lookUp
            // 
            this.textBox_parkingSpot_lookUp.Location = new System.Drawing.Point(73, 18);
            this.textBox_parkingSpot_lookUp.Name = "textBox_parkingSpot_lookUp";
            this.textBox_parkingSpot_lookUp.Size = new System.Drawing.Size(100, 21);
            this.textBox_parkingSpot_lookUp.TabIndex = 5;
            this.textBox_parkingSpot_lookUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_parkingSpot_lookUp_KeyPress);
            // 
            // button_SelectedLookUp
            // 
            this.button_SelectedLookUp.Location = new System.Drawing.Point(205, 16);
            this.button_SelectedLookUp.Name = "button_SelectedLookUp";
            this.button_SelectedLookUp.Size = new System.Drawing.Size(89, 23);
            this.button_SelectedLookUp.TabIndex = 1;
            this.button_SelectedLookUp.Text = "해당공간조회";
            this.button_SelectedLookUp.UseVisualStyleBackColor = true;
            this.button_SelectedLookUp.Click += new System.EventHandler(this.button_SelectedLookUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "공간번호";
            // 
            // timer_DisplayNowtime
            // 
            this.timer_DisplayNowtime.Enabled = true;
            this.timer_DisplayNowtime.Interval = 1000;
            this.timer_DisplayNowtime.Tick += new System.EventHandler(this.timer_DisplayNowtime_Tick);
            // 
            // statusStrip_Now
            // 
            this.statusStrip_Now.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Now});
            this.statusStrip_Now.Location = new System.Drawing.Point(0, 602);
            this.statusStrip_Now.Name = "statusStrip_Now";
            this.statusStrip_Now.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip_Now.TabIndex = 16;
            this.statusStrip_Now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Now
            // 
            this.toolStripStatusLabel_Now.Name = "toolStripStatusLabel_Now";
            this.toolStripStatusLabel_Now.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_Now.Text = "-";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(205, 67);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(89, 23);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "공간추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_AllLookUp
            // 
            this.button_AllLookUp.Location = new System.Drawing.Point(205, 41);
            this.button_AllLookUp.Name = "button_AllLookUp";
            this.button_AllLookUp.Size = new System.Drawing.Size(89, 23);
            this.button_AllLookUp.TabIndex = 7;
            this.button_AllLookUp.Text = "전체 조회";
            this.button_AllLookUp.UseVisualStyleBackColor = true;
            this.button_AllLookUp.Click += new System.EventHandler(this.button_AllLookUp_Click);
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(CarManager_Modified.ParkingCar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 624);
            this.Controls.Add(this.statusStrip_Now);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.listBox_logPrint);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip_Now.ResumeLayout(false);
            this.statusStrip_Now.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.ListBox listBox_logPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_parkingRemove;
        private System.Windows.Forms.Button button_parkingAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_parkingSpot_lookUp;
        private System.Windows.Forms.Button button_SelectedLookUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.Timer timer_DisplayNowtime;
        private System.Windows.Forms.StatusStrip statusStrip_Now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Now;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_AllLookUp;
    }
}

