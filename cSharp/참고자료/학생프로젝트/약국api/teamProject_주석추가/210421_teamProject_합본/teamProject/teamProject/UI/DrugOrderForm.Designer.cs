
namespace teamProject
{
    partial class DrugOrderForm
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
            this.orderTitle = new System.Windows.Forms.Label();
            this.drugOrder_dtGridView = new System.Windows.Forms.DataGridView();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compSubTitle = new System.Windows.Forms.GroupBox();
            this.btn_DrugCntEdit = new System.Windows.Forms.Button();
            this.productName_txtBox = new VerticalTextBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.Label();
            this.btn_DrugOrder = new System.Windows.Forms.Button();
            this.ProductCnt_txtBox = new VerticalTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drugOrder_dtGridView)).BeginInit();
            this.compSubTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTitle
            // 
            this.orderTitle.AutoSize = true;
            this.orderTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.orderTitle.Location = new System.Drawing.Point(39, 26);
            this.orderTitle.Name = "orderTitle";
            this.orderTitle.Size = new System.Drawing.Size(90, 25);
            this.orderTitle.TabIndex = 16;
            this.orderTitle.Text = "약품 주문";
            // 
            // drugOrder_dtGridView
            // 
            this.drugOrder_dtGridView.BackgroundColor = System.Drawing.Color.White;
            this.drugOrder_dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugOrder_dtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrugName,
            this.EntpName,
            this.Count});
            this.drugOrder_dtGridView.Location = new System.Drawing.Point(44, 78);
            this.drugOrder_dtGridView.Name = "drugOrder_dtGridView";
            this.drugOrder_dtGridView.ReadOnly = true;
            this.drugOrder_dtGridView.RowTemplate.Height = 30;
            this.drugOrder_dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drugOrder_dtGridView.Size = new System.Drawing.Size(920, 465);
            this.drugOrder_dtGridView.TabIndex = 17;
            this.drugOrder_dtGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drugOrder_dtGridView_CellClick);
            // 
            // DrugName
            // 
            this.DrugName.HeaderText = "약품 이름";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            this.DrugName.Width = 250;
            // 
            // EntpName
            // 
            this.EntpName.HeaderText = "제조사";
            this.EntpName.Name = "EntpName";
            this.EntpName.ReadOnly = true;
            this.EntpName.Width = 400;
            // 
            // Count
            // 
            this.Count.HeaderText = "수량";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // compSubTitle
            // 
            this.compSubTitle.Controls.Add(this.btn_DrugCntEdit);
            this.compSubTitle.Controls.Add(this.productName_txtBox);
            this.compSubTitle.Controls.Add(this.ProductName);
            this.compSubTitle.Controls.Add(this.orderNum);
            this.compSubTitle.Controls.Add(this.btn_DrugOrder);
            this.compSubTitle.Controls.Add(this.ProductCnt_txtBox);
            this.compSubTitle.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.compSubTitle.Location = new System.Drawing.Point(44, 567);
            this.compSubTitle.Name = "compSubTitle";
            this.compSubTitle.Size = new System.Drawing.Size(920, 125);
            this.compSubTitle.TabIndex = 18;
            this.compSubTitle.TabStop = false;
            this.compSubTitle.Text = "제약사";
            // 
            // btn_DrugCntEdit
            // 
            this.btn_DrugCntEdit.FlatAppearance.BorderSize = 0;
            this.btn_DrugCntEdit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DrugCntEdit.Location = new System.Drawing.Point(735, 46);
            this.btn_DrugCntEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DrugCntEdit.Name = "btn_DrugCntEdit";
            this.btn_DrugCntEdit.Size = new System.Drawing.Size(70, 39);
            this.btn_DrugCntEdit.TabIndex = 10;
            this.btn_DrugCntEdit.Text = "수정";
            this.btn_DrugCntEdit.UseVisualStyleBackColor = true;
            this.btn_DrugCntEdit.Click += new System.EventHandler(this.btn_DrugCntEdit_Click);
            // 
            // productName_txtBox
            // 
            this.productName_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.productName_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.productName_txtBox.Font = new System.Drawing.Font("굴림", 11F);
            this.productName_txtBox.LeftRightPadding = ((uint)(10u));
            this.productName_txtBox.Location = new System.Drawing.Point(129, 55);
            this.productName_txtBox.Name = "productName_txtBox";
            this.productName_txtBox.Size = new System.Drawing.Size(200, 30);
            this.productName_txtBox.TabIndex = 5;
            this.productName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.ProductName.Location = new System.Drawing.Point(49, 60);
            this.ProductName.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(54, 20);
            this.ProductName.TabIndex = 4;
            this.ProductName.Text = "약이름";
            // 
            // orderNum
            // 
            this.orderNum.AutoSize = true;
            this.orderNum.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.orderNum.Location = new System.Drawing.Point(390, 60);
            this.orderNum.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(39, 20);
            this.orderNum.TabIndex = 8;
            this.orderNum.Text = "수량";
            // 
            // btn_DrugOrder
            // 
            this.btn_DrugOrder.FlatAppearance.BorderSize = 0;
            this.btn_DrugOrder.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DrugOrder.Location = new System.Drawing.Point(815, 46);
            this.btn_DrugOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DrugOrder.Name = "btn_DrugOrder";
            this.btn_DrugOrder.Size = new System.Drawing.Size(70, 39);
            this.btn_DrugOrder.TabIndex = 7;
            this.btn_DrugOrder.Text = "주문";
            this.btn_DrugOrder.UseVisualStyleBackColor = true;
            this.btn_DrugOrder.Click += new System.EventHandler(this.btn_DrugOrder_Click);
            // 
            // ProductCnt_txtBox
            // 
            this.ProductCnt_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProductCnt_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.ProductCnt_txtBox.Font = new System.Drawing.Font("굴림", 11F);
            this.ProductCnt_txtBox.LeftRightPadding = ((uint)(10u));
            this.ProductCnt_txtBox.Location = new System.Drawing.Point(440, 55);
            this.ProductCnt_txtBox.Name = "ProductCnt_txtBox";
            this.ProductCnt_txtBox.Size = new System.Drawing.Size(200, 30);
            this.ProductCnt_txtBox.TabIndex = 9;
            this.ProductCnt_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DrugOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.compSubTitle);
            this.Controls.Add(this.orderTitle);
            this.Controls.Add(this.drugOrder_dtGridView);
            this.Name = "DrugOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "약품 주문";
            this.Load += new System.EventHandler(this.DrugOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugOrder_dtGridView)).EndInit();
            this.compSubTitle.ResumeLayout(false);
            this.compSubTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderTitle;
        private System.Windows.Forms.DataGridView drugOrder_dtGridView;
        private System.Windows.Forms.GroupBox compSubTitle;
        private VerticalTextBox productName_txtBox;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label orderNum;
        private System.Windows.Forms.Button btn_DrugOrder;
        private VerticalTextBox ProductCnt_txtBox;
        private System.Windows.Forms.Button btn_DrugCntEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}