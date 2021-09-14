
namespace ATM
{
    partial class UCP_noaccount
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
            this.button_switch_panel1 = new System.Windows.Forms.Button();
            this.bankName = new System.Windows.Forms.ComboBox();
            this.transaction = new System.Windows.Forms.Button();
            this.money_text = new System.Windows.Forms.TextBox();
            this.accNum_text = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.Label();
            this.accNum = new System.Windows.Forms.Label();
            this.bank_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_switch_panel1
            // 
            this.button_switch_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_switch_panel1.FlatAppearance.BorderSize = 0;
            this.button_switch_panel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_switch_panel1.Font = new System.Drawing.Font("배달의민족 주아", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_switch_panel1.Location = new System.Drawing.Point(732, 434);
            this.button_switch_panel1.Name = "button_switch_panel1";
            this.button_switch_panel1.Size = new System.Drawing.Size(140, 90);
            this.button_switch_panel1.TabIndex = 0;
            this.button_switch_panel1.Text = "돌아가기";
            this.button_switch_panel1.UseVisualStyleBackColor = false;
            this.button_switch_panel1.Click += new System.EventHandler(this.button_switch_panel1_Click);
            // 
            // bankName
            // 
            this.bankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bankName.FormattingEnabled = true;
            this.bankName.Items.AddRange(new object[] {
            "국민",
            "농협",
            "신한",
            "우리",
            "카카오",
            "하나"});
            this.bankName.Location = new System.Drawing.Point(465, 172);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(173, 24);
            this.bankName.TabIndex = 17;
            // 
            // transaction
            // 
            this.transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.transaction.FlatAppearance.BorderSize = 0;
            this.transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction.Font = new System.Drawing.Font("배달의민족 주아", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.transaction.Location = new System.Drawing.Point(395, 344);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(140, 90);
            this.transaction.TabIndex = 16;
            this.transaction.Text = "송금";
            this.transaction.UseVisualStyleBackColor = false;
            this.transaction.Click += new System.EventHandler(this.transaction_Click);
            // 
            // money_text
            // 
            this.money_text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money_text.Location = new System.Drawing.Point(465, 280);
            this.money_text.Name = "money_text";
            this.money_text.Size = new System.Drawing.Size(173, 26);
            this.money_text.TabIndex = 15;
            // 
            // accNum_text
            // 
            this.accNum_text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accNum_text.Location = new System.Drawing.Point(465, 226);
            this.accNum_text.Name = "accNum_text";
            this.accNum_text.Size = new System.Drawing.Size(173, 26);
            this.accNum_text.TabIndex = 14;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("배달의민족 주아", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money.Location = new System.Drawing.Point(304, 279);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(56, 30);
            this.money.TabIndex = 13;
            this.money.Text = "금액";
            // 
            // accNum
            // 
            this.accNum.AutoSize = true;
            this.accNum.Font = new System.Drawing.Font("배달의민족 주아", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accNum.Location = new System.Drawing.Point(304, 225);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(102, 30);
            this.accNum.TabIndex = 12;
            this.accNum.Text = "계좌번호";
            // 
            // bank_name
            // 
            this.bank_name.AutoSize = true;
            this.bank_name.Font = new System.Drawing.Font("배달의민족 주아", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bank_name.Location = new System.Drawing.Point(304, 172);
            this.bank_name.Name = "bank_name";
            this.bank_name.Size = new System.Drawing.Size(56, 30);
            this.bank_name.TabIndex = 11;
            this.bank_name.Text = "은행";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(343, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "무통장 입금하기";
            // 
            // UCP_noaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.transaction);
            this.Controls.Add(this.money_text);
            this.Controls.Add(this.accNum_text);
            this.Controls.Add(this.money);
            this.Controls.Add(this.accNum);
            this.Controls.Add(this.bank_name);
            this.Controls.Add(this.button_switch_panel1);
            this.Name = "UCP_noaccount";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_switch_panel1;
        private System.Windows.Forms.ComboBox bankName;
        private System.Windows.Forms.Button transaction;
        private System.Windows.Forms.TextBox money_text;
        private System.Windows.Forms.TextBox accNum_text;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label accNum;
        private System.Windows.Forms.Label bank_name;
        private System.Windows.Forms.Label label1;
    }
}
