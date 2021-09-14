
namespace Lotto
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
            this.num1 = new Sunny.UI.UILabel();
            this.num2 = new Sunny.UI.UILabel();
            this.num3 = new Sunny.UI.UILabel();
            this.num4 = new Sunny.UI.UILabel();
            this.num5 = new Sunny.UI.UILabel();
            this.num6 = new Sunny.UI.UILabel();
            this.exit = new Sunny.UI.UISymbolButton();
            this.title1 = new Sunny.UI.UILabel();
            this.name = new Sunny.UI.UILabel();
            this.RandomButton = new CxFlatUI.Controls.CxFlatButton();
            this.title2 = new Sunny.UI.UILabel();
            this.resultRound = new CxFlatUI.CxFlatTextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.roundNum1 = new Sunny.UI.UILabel();
            this.roundNum2 = new Sunny.UI.UILabel();
            this.roundNum3 = new Sunny.UI.UILabel();
            this.roundNum4 = new Sunny.UI.UILabel();
            this.roundNum5 = new Sunny.UI.UILabel();
            this.roundNum6 = new Sunny.UI.UILabel();
            this.roundBonus = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.resultText = new Sunny.UI.UILabel();
            this.LottoInfo = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Silver;
            this.num1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.num1.Location = new System.Drawing.Point(78, 398);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 100);
            this.num1.TabIndex = 0;
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Silver;
            this.num2.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.num2.Location = new System.Drawing.Point(237, 398);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 100);
            this.num2.TabIndex = 0;
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Silver;
            this.num3.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.num3.Location = new System.Drawing.Point(396, 398);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 100);
            this.num3.TabIndex = 0;
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Silver;
            this.num4.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.num4.Location = new System.Drawing.Point(555, 398);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(100, 100);
            this.num4.TabIndex = 0;
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.Silver;
            this.num5.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.num5.Location = new System.Drawing.Point(714, 398);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(100, 100);
            this.num5.TabIndex = 0;
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.Silver;
            this.num6.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.num6.Location = new System.Drawing.Point(873, 398);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(100, 100);
            this.num6.TabIndex = 0;
            this.num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FillColor = System.Drawing.Color.Brown;
            this.exit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.FillPressColor = System.Drawing.Color.Maroon;
            this.exit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exit.IsCircle = true;
            this.exit.Location = new System.Drawing.Point(960, 12);
            this.exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.exit.Name = "exit";
            this.exit.RectColor = System.Drawing.Color.Brown;
            this.exit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.RectPressColor = System.Drawing.Color.Maroon;
            this.exit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Size = new System.Drawing.Size(100, 64);
            this.exit.Style = Sunny.UI.UIStyle.Custom;
            this.exit.Symbol = 61453;
            this.exit.SymbolSize = 45;
            this.exit.TabIndex = 2;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title1
            // 
            this.title1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.title1.Location = new System.Drawing.Point(62, 49);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(773, 67);
            this.title1.TabIndex = 3;
            this.title1.Text = "로또 번호 프로그램";
            this.title1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.name.Location = new System.Drawing.Point(546, 173);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 42);
            this.name.TabIndex = 4;
            this.name.Text = "Created by Yorgos";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomButton
            // 
            this.RandomButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.RandomButton.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.RandomButton.Location = new System.Drawing.Point(420, 545);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(215, 95);
            this.RandomButton.TabIndex = 5;
            this.RandomButton.Text = "행운 뽑기";
            this.RandomButton.TextColor = System.Drawing.Color.White;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // title2
            // 
            this.title2.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.title2.Location = new System.Drawing.Point(62, 106);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(773, 67);
            this.title2.TabIndex = 3;
            this.title2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultRound
            // 
            this.resultRound.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultRound.Hint = "";
            this.resultRound.Location = new System.Drawing.Point(154, 255);
            this.resultRound.MaxLength = 32767;
            this.resultRound.Multiline = false;
            this.resultRound.Name = "resultRound";
            this.resultRound.PasswordChar = '\0';
            this.resultRound.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultRound.SelectedText = "";
            this.resultRound.SelectionLength = 0;
            this.resultRound.SelectionStart = 0;
            this.resultRound.Size = new System.Drawing.Size(100, 38);
            this.resultRound.TabIndex = 6;
            this.resultRound.TabStop = false;
            this.resultRound.Text = "~957까지";
            this.resultRound.UseSystemPasswordChar = false;
            this.resultRound.Click += new System.EventHandler(this.resultRound_Click);
            this.resultRound.Leave += new System.EventHandler(this.resultRound_Leave);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.uiLabel1.Location = new System.Drawing.Point(52, 253);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(96, 42);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "회차 입력";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundNum1
            // 
            this.roundNum1.BackColor = System.Drawing.Color.Silver;
            this.roundNum1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundNum1.Location = new System.Drawing.Point(285, 249);
            this.roundNum1.Name = "roundNum1";
            this.roundNum1.Size = new System.Drawing.Size(50, 50);
            this.roundNum1.TabIndex = 0;
            this.roundNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundNum2
            // 
            this.roundNum2.BackColor = System.Drawing.Color.Silver;
            this.roundNum2.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundNum2.Location = new System.Drawing.Point(350, 249);
            this.roundNum2.Name = "roundNum2";
            this.roundNum2.Size = new System.Drawing.Size(50, 50);
            this.roundNum2.TabIndex = 0;
            this.roundNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundNum3
            // 
            this.roundNum3.BackColor = System.Drawing.Color.Silver;
            this.roundNum3.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundNum3.Location = new System.Drawing.Point(415, 249);
            this.roundNum3.Name = "roundNum3";
            this.roundNum3.Size = new System.Drawing.Size(50, 50);
            this.roundNum3.TabIndex = 0;
            this.roundNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundNum4
            // 
            this.roundNum4.BackColor = System.Drawing.Color.Silver;
            this.roundNum4.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundNum4.Location = new System.Drawing.Point(480, 249);
            this.roundNum4.Name = "roundNum4";
            this.roundNum4.Size = new System.Drawing.Size(50, 50);
            this.roundNum4.TabIndex = 0;
            this.roundNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundNum5
            // 
            this.roundNum5.BackColor = System.Drawing.Color.Silver;
            this.roundNum5.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundNum5.Location = new System.Drawing.Point(545, 249);
            this.roundNum5.Name = "roundNum5";
            this.roundNum5.Size = new System.Drawing.Size(50, 50);
            this.roundNum5.TabIndex = 0;
            this.roundNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundNum6
            // 
            this.roundNum6.BackColor = System.Drawing.Color.Silver;
            this.roundNum6.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundNum6.Location = new System.Drawing.Point(610, 249);
            this.roundNum6.Name = "roundNum6";
            this.roundNum6.Size = new System.Drawing.Size(50, 50);
            this.roundNum6.TabIndex = 0;
            this.roundNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundBonus
            // 
            this.roundBonus.BackColor = System.Drawing.Color.Silver;
            this.roundBonus.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.roundBonus.Location = new System.Drawing.Point(704, 249);
            this.roundBonus.Name = "roundBonus";
            this.roundBonus.Size = new System.Drawing.Size(50, 50);
            this.roundBonus.TabIndex = 0;
            this.roundBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.uiLabel10.Location = new System.Drawing.Point(662, 247);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(42, 54);
            this.uiLabel10.TabIndex = 4;
            this.uiLabel10.Text = "+";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Microsoft YaHei", 40F);
            this.resultText.Location = new System.Drawing.Point(789, 222);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(146, 95);
            this.resultText.TabIndex = 4;
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LottoInfo
            // 
            this.LottoInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.LottoInfo.Location = new System.Drawing.Point(67, 319);
            this.LottoInfo.Name = "LottoInfo";
            this.LottoInfo.Size = new System.Drawing.Size(917, 60);
            this.LottoInfo.TabIndex = 7;
            this.LottoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 706);
            this.Controls.Add(this.LottoInfo);
            this.Controls.Add(this.resultRound);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.name);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.roundBonus);
            this.Controls.Add(this.roundNum6);
            this.Controls.Add(this.roundNum5);
            this.Controls.Add(this.roundNum4);
            this.Controls.Add(this.roundNum3);
            this.Controls.Add(this.roundNum2);
            this.Controls.Add(this.roundNum1);
            this.Controls.Add(this.num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel num1;
        private Sunny.UI.UILabel num2;
        private Sunny.UI.UILabel num3;
        private Sunny.UI.UILabel num4;
        private Sunny.UI.UILabel num5;
        private Sunny.UI.UILabel num6;
        private Sunny.UI.UISymbolButton exit;
        private Sunny.UI.UILabel title1;
        private Sunny.UI.UILabel name;
        private CxFlatUI.Controls.CxFlatButton RandomButton;
        private Sunny.UI.UILabel title2;
        private CxFlatUI.CxFlatTextBox resultRound;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel roundNum1;
        private Sunny.UI.UILabel roundNum2;
        private Sunny.UI.UILabel roundNum3;
        private Sunny.UI.UILabel roundNum4;
        private Sunny.UI.UILabel roundNum5;
        private Sunny.UI.UILabel roundNum6;
        private Sunny.UI.UILabel roundBonus;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel resultText;
        private Sunny.UI.UILabel LottoInfo;
    }
}

