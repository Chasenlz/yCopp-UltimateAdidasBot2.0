using System;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Class55 : TextBox
{
    private bool bool_0;
    private Color color_0 = Color.Gray;
    private Font font_0;
    private string string_0 = "Water Mark";

    public Class55()
    {
        this.method_4(true);
    }

    private void Class55_FontChanged(object sender, EventArgs e)
    {
        if (this.bool_0)
        {
            this.font_0 = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style, this.Font.Unit);
            this.Refresh();
        }
    }

    private void Class55_LostFocus(object sender, EventArgs e)
    {
        if (this.Text.Length <= 0)
        {
            this.method_5();
        }
        else
        {
            this.method_6();
        }
    }

    public Color method_0() => 
        this.color_0;

    public void method_1(Color color_1)
    {
        this.color_0 = color_1;
        base.Invalidate();
    }

    public string method_2() => 
        this.string_0;

    public void method_3(string string_1)
    {
        this.string_0 = string_1;
        base.Invalidate();
    }

    private void method_4(bool bool_1)
    {
        if (bool_1)
        {
            base.TextChanged += new EventHandler(this.Class55_LostFocus);
            base.LostFocus += new EventHandler(this.Class55_LostFocus);
            base.FontChanged += new EventHandler(this.Class55_FontChanged);
        }
    }

    private void method_5()
    {
        this.font_0 = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style, this.Font.Unit);
        base.SetStyle(ControlStyles.UserPaint, true);
        this.bool_0 = true;
        this.Refresh();
    }

    private void method_6()
    {
        this.bool_0 = false;
        base.SetStyle(ControlStyles.UserPaint, false);
        if (this.font_0 != null)
        {
            this.Font = new Font(this.font_0.FontFamily, this.font_0.Size, this.font_0.Style, this.font_0.Unit);
        }
    }

    private void method_7()
    {
        base.SuspendLayout();
        base.ResumeLayout(false);
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        this.Class55_LostFocus(null, null);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Font font = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style, this.Font.Unit);
        SolidBrush brush = new SolidBrush(this.method_0());
        e.Graphics.DrawString(this.bool_0 ? this.method_2() : this.Text, font, brush, new PointF(0f, 0f));
        base.OnPaint(e);
    }
}

