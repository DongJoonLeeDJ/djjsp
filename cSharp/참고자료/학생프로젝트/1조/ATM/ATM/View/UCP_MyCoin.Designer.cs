namespace ATM.Panel
{
    partial class UCP_MyCoin
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_clock = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_invest = new System.Windows.Forms.Label();
            this.label_revenue = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.coinnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earningrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("배달의민족 주아", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_back.Location = new System.Drawing.Point(739, 431);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(140, 90);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "돌아가기";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coinnameDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.avgPriceDataGridViewTextBoxColumn,
            this.earningrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(775, 345);
            this.dataGridView1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(378, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "님 코인 정보 보기";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Location = new System.Drawing.Point(630, 33);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(0, 12);
            this.label_clock.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(92, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "투자금";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(457, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "수익금";
            // 
            // label_invest
            // 
            this.label_invest.AutoSize = true;
            this.label_invest.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_invest.Location = new System.Drawing.Point(182, 468);
            this.label_invest.Name = "label_invest";
            this.label_invest.Size = new System.Drawing.Size(0, 16);
            this.label_invest.TabIndex = 12;
            // 
            // label_revenue
            // 
            this.label_revenue.AutoSize = true;
            this.label_revenue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_revenue.Location = new System.Drawing.Point(561, 468);
            this.label_revenue.Name = "label_revenue";
            this.label_revenue.Size = new System.Drawing.Size(0, 16);
            this.label_revenue.TabIndex = 13;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("배달의민족 주아", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(289, 18);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 35);
            this.label_name.TabIndex = 8;
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // coinnameDataGridViewTextBoxColumn
            // 
            this.coinnameDataGridViewTextBoxColumn.DataPropertyName = "coin_name";
            this.coinnameDataGridViewTextBoxColumn.HeaderText = "코인명";
            this.coinnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.coinnameDataGridViewTextBoxColumn.Name = "coinnameDataGridViewTextBoxColumn";
            this.coinnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "수량";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.Width = 175;
            // 
            // avgPriceDataGridViewTextBoxColumn
            // 
            this.avgPriceDataGridViewTextBoxColumn.DataPropertyName = "AvgPrice";
            this.avgPriceDataGridViewTextBoxColumn.HeaderText = "구매 평균가";
            this.avgPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.avgPriceDataGridViewTextBoxColumn.Name = "avgPriceDataGridViewTextBoxColumn";
            this.avgPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // earningrateDataGridViewTextBoxColumn
            // 
            this.earningrateDataGridViewTextBoxColumn.DataPropertyName = "earning_rate";
            this.earningrateDataGridViewTextBoxColumn.HeaderText = "수익률";
            this.earningrateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.earningrateDataGridViewTextBoxColumn.Name = "earningrateDataGridViewTextBoxColumn";
            this.earningrateDataGridViewTextBoxColumn.Width = 175;
            // 
            // coinBindingSource
            // 
            this.coinBindingSource.DataSource = typeof(ATM.Model.Coin);
            // 
            // UCP_MyCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_revenue);
            this.Controls.Add(this.label_invest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Name = "UCP_MyCoin";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.UCP_MyCoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.BindingSource coinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earningrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_invest;
        private System.Windows.Forms.Label label_revenue;
        private System.Windows.Forms.Label label_name;
    }
}
