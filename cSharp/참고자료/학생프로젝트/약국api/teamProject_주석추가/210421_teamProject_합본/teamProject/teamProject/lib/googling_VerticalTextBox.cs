using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

public class VerticalTextBox : Control
{
    public VerticalTextBox()
    {
        //OnPaint의 e.Graphics.DrawRectangle 잔상 제거 -> ControlStyles.ResizeRedraw 필수
        base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);

        textBox = new CustomTextBox();
        textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.Controls.Add(textBox);

        //Init
        Text = "";
        BackColor = SystemColors.Window;
        LeftRightPadding = 10;
        BorderColor = Color.Gray;
    }

    private CustomTextBox textBox;
    public override string Text
    {
        get { return textBox.Text; }
        set { textBox.Text = value; }
    }
    public override Color ForeColor { get { return textBox.ForeColor; } set { textBox.ForeColor = value; } }
    public override Color BackColor
    {
        get { return base.BackColor; }
        set
        {
            textBox.BackColor = base.BackColor = value;
            Invalidate();
        }
    }
    public HorizontalAlignment TextAlign { get { return textBox.TextAlign; } set { textBox.TextAlign = value; } }

    private int leftRightPadding;
    public uint LeftRightPadding
    {
        get { return Convert.ToUInt32(leftRightPadding); }
        set
        {
            leftRightPadding = Convert.ToInt32(value);
            textBox.Location = new Point(leftRightPadding, textBox.Location.Y);
        }
    }
    private Color borderColor;
    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.DrawRectangle(new Pen(borderColor), 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        int textTop = (this.Height / 2) - (textBox.ClientSize.Height / 2);
        textBox.Location = new Point(leftRightPadding, textTop);
        textBox.Width = this.Width - (leftRightPadding * 2) - 2;
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        if (!textBox.Focused)
        {
            textBox.Focus();
        }
    }

    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            int textTop = (this.Parent.Height / 2) - ((this.ClientSize.Height + 2) / 2);
            this.Location = new Point(this.Location.X, textTop);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
