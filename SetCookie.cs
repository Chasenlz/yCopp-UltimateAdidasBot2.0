using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class SetCookie : Form
{
    private Button button1;
    private Button button2;
    private IContainer icontainer_0;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox nameBox;
    public string string_0;
    public string string_1;
    private TextBox valBox;

    public SetCookie()
    {
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!this.nameBox.Equals(string.Empty) && !this.valBox.Equals(string.Empty))
        {
            this.string_0 = this.nameBox.Text;
            this.string_1 = this.valBox.Text;
            base.DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Please enter a name and a value.");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.Abort;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(SetCookie));
        this.label1 = new Label();
        this.label2 = new Label();
        this.nameBox = new TextBox();
        this.valBox = new TextBox();
        this.label3 = new Label();
        this.button1 = new Button();
        this.button2 = new Button();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 20);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x26, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Name:";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(12, 50);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x25, 13);
        this.label2.TabIndex = 1;
        this.label2.Text = "Value:";
        this.nameBox.Location = new Point(0x39, 20);
        this.nameBox.Name = "nameBox";
        this.nameBox.Size = new Size(0xc9, 20);
        this.nameBox.TabIndex = 2;
        this.valBox.Location = new Point(0x39, 50);
        this.valBox.Name = "valBox";
        this.valBox.Size = new Size(0xc9, 20);
        this.valBox.TabIndex = 3;
        this.label3.AutoSize = true;
        this.label3.Location = new Point(0x16, 20);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0, 13);
        this.label3.TabIndex = 4;
        this.button1.Location = new Point(0x39, 0x51);
        this.button1.Name = "button1";
        this.button1.Size = new Size(0x4b, 0x17);
        this.button1.TabIndex = 5;
        this.button1.Text = "Add Cookie";
        this.button1.Click += new EventHandler(this.button1_Click);
        this.button2.Location = new Point(0xb7, 0x51);
        this.button2.Name = "button2";
        this.button2.Size = new Size(0x4b, 0x17);
        this.button2.TabIndex = 6;
        this.button2.Text = "Cancel";
        this.button2.Click += new EventHandler(this.button2_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x116, 0x72);
        base.Controls.Add(this.button2);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.label3);
        base.Controls.Add(this.valBox);
        base.Controls.Add(this.nameBox);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.label1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "SetCookie";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Set a Cookie";
        base.Load += new EventHandler(this.SetCookie_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void SetCookie_Load(object sender, EventArgs e)
    {
    }
}

