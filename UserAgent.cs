using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class UserAgent : Form
{
    private Button cancelButton;
    private IContainer icontainer_0;
    private Label label1;
    private Button setButton;
    public string string_0;
    private TextBox textBox1;

    public UserAgent()
    {
        this.InitializeComponent();
    }

    public UserAgent(string string_1)
    {
        this.InitializeComponent();
        this.textBox1.Text = string_1;
    }

    private void cancelButton_Click(object sender, EventArgs e)
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(UserAgent));
        this.label1 = new Label();
        this.textBox1 = new TextBox();
        this.setButton = new Button();
        this.cancelButton = new Button();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x16, 0x2a);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x3f, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "User-Agent:";
        this.textBox1.Location = new Point(0x6a, 0x2a);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(0x116, 20);
        this.textBox1.TabIndex = 1;
        this.setButton.Location = new Point(0x6a, 0x52);
        this.setButton.Name = "setButton";
        this.setButton.Size = new Size(0x4b, 0x17);
        this.setButton.TabIndex = 2;
        this.setButton.Text = "Set";
        this.setButton.Click += new EventHandler(this.setButton_Click);
        this.cancelButton.Location = new Point(0xda, 0x52);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(0x4b, 0x17);
        this.cancelButton.TabIndex = 3;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.Click += new EventHandler(this.cancelButton_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x198, 0x8d);
        base.Controls.Add(this.cancelButton);
        base.Controls.Add(this.setButton);
        base.Controls.Add(this.textBox1);
        base.Controls.Add(this.label1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "UserAgent";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Set user agent";
        base.Load += new EventHandler(this.UserAgent_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void setButton_Click(object sender, EventArgs e)
    {
        this.string_0 = this.textBox1.Text;
        base.DialogResult = DialogResult.OK;
    }

    private void UserAgent_Load(object sender, EventArgs e)
    {
    }
}

