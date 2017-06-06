using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class PreloadLink : Form
{
    private Button button1;
    private Button button2;
    private IContainer icontainer_0;
    private Label label1;
    public string string_0;
    public string string_1;
    private TextBox textBox1;

    public PreloadLink()
    {
        this.InitializeComponent();
    }

    public PreloadLink(string string_2)
    {
        this.string_1 = string_2;
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.string_0 = this.textBox1.Text;
        base.DialogResult = DialogResult.OK;
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(PreloadLink));
        this.label1 = new Label();
        this.textBox1 = new TextBox();
        this.button1 = new Button();
        this.button2 = new Button();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 0x18);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x20, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "URL:";
        this.label1.Click += new EventHandler(this.label1_Click);
        this.textBox1.Location = new Point(50, 0x15);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(0x139, 20);
        this.textBox1.TabIndex = 1;
        this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
        this.button1.Location = new Point(0x71, 0x31);
        this.button1.Name = "button1";
        this.button1.Size = new Size(0x4b, 0x17);
        this.button1.TabIndex = 2;
        this.button1.Text = "Save";
        this.button1.Click += new EventHandler(this.button1_Click);
        this.button2.Location = new Point(0xcd, 0x31);
        this.button2.Name = "button2";
        this.button2.Size = new Size(0x4b, 0x17);
        this.button2.TabIndex = 3;
        this.button2.Text = "Cancel";
        this.button2.Click += new EventHandler(this.button2_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x177, 0x55);
        base.Controls.Add(this.button2);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.textBox1);
        base.Controls.Add(this.label1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "PreloadLink";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Enter a custom preload link";
        base.Load += new EventHandler(this.PreloadLink_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void PreloadLink_Load(object sender, EventArgs e)
    {
        this.textBox1.Text = this.string_1;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }
}

