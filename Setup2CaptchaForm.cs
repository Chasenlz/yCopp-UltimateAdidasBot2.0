using Polenter.Serialization;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public sealed class Setup2CaptchaForm : Form
{
    private Button button1;
    private Button button2;
    private Button button3;
    private IContainer icontainer_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    private TextBox keyText;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    public string string_0;
    public string string_1;

    public Setup2CaptchaForm()
    {
        this.InitializeComponent();
    }

    public Setup2CaptchaForm(string string_2, int int_4, int int_5)
    {
        this.string_1 = string_2;
        this.int_0 = int_4 / 0x3e8;
        this.int_2 = int_5;
        this.int_3 = int_5;
        this.int_1 = int_4;
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (this.keyText.Text.Equals(string.Empty))
        {
            MessageBox.Show("Please enter a valid key.");
        }
        else
        {
            try
            {
                string[] textArray1 = new string[] { this.string_0, "#", this.int_1.ToString(), "#", this.int_2.ToString() };
                new SharpSerializer(true).Serialize(string.Concat(textArray1), "settings.bin");
            }
            catch (Exception)
            {
            }
            base.DialogResult = DialogResult.OK;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.Abort;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Process.Start("http://2captcha.com/?from=2874041");
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(Setup2CaptchaForm));
        this.label1 = new Label();
        this.keyText = new TextBox();
        this.button1 = new Button();
        this.button2 = new Button();
        this.button3 = new Button();
        this.label2 = new Label();
        this.numericUpDown1 = new NumericUpDown();
        this.label3 = new Label();
        this.label4 = new Label();
        this.numericUpDown2 = new NumericUpDown();
        this.label5 = new Label();
        this.numericUpDown1.BeginInit();
        this.numericUpDown2.BeginInit();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x19, 0x40);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x61, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "2Captcha API-Key:";
        this.keyText.Location = new Point(0xa2, 0x3f);
        this.keyText.Name = "keyText";
        this.keyText.Size = new Size(0xb3, 20);
        this.keyText.TabIndex = 1;
        this.keyText.TextChanged += new EventHandler(this.keyText_TextChanged);
        this.button1.Location = new Point(0x43, 0xb6);
        this.button1.Name = "button1";
        this.button1.Size = new Size(90, 30);
        this.button1.TabIndex = 2;
        this.button1.Text = "Save";
        this.button1.Click += new EventHandler(this.button1_Click);
        this.button2.Location = new Point(0xe8, 0xb6);
        this.button2.Name = "button2";
        this.button2.Size = new Size(90, 30);
        this.button2.TabIndex = 3;
        this.button2.Text = "Cancel";
        this.button2.Click += new EventHandler(this.button2_Click);
        this.button3.Location = new Point(0xf7, 0x13);
        this.button3.Name = "button3";
        this.button3.Size = new Size(0x5e, 0x17);
        this.button3.TabIndex = 4;
        this.button3.Text = "Create Account";
        this.button3.Click += new EventHandler(this.button3_Click);
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x19, 0x61);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x57, 13);
        this.label2.TabIndex = 5;
        this.label2.Text = "Request interval:";
        this.numericUpDown1.Location = new Point(0xa2, 0x61);
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new Size(120, 20);
        this.numericUpDown1.TabIndex = 6;
        int[] bits = new int[4];
        bits[0] = 10;
        this.numericUpDown1.Value = new decimal(bits);
        this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
        this.label3.AutoSize = true;
        this.label3.Location = new Point(0x120, 0x63);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x35, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "second(s)";
        this.label4.AutoSize = true;
        this.label4.Location = new Point(0x19, 0x85);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x6f, 13);
        this.label4.TabIndex = 8;
        this.label4.Text = "Captchas per request:";
        this.numericUpDown2.Location = new Point(0xa2, 0x85);
        this.numericUpDown2.Name = "numericUpDown2";
        this.numericUpDown2.Size = new Size(120, 20);
        this.numericUpDown2.TabIndex = 9;
        int[] numArray2 = new int[4];
        numArray2[0] = 1;
        this.numericUpDown2.Value = new decimal(numArray2);
        this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
        this.label5.AutoSize = true;
        this.label5.Location = new Point(0x19, 0x13);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0xb8, 13);
        this.label5.TabIndex = 10;
        this.label5.Text = "No 2Captcha account? Sign up here:";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x177, 0xe4);
        base.Controls.Add(this.label5);
        base.Controls.Add(this.numericUpDown2);
        base.Controls.Add(this.label4);
        base.Controls.Add(this.label3);
        base.Controls.Add(this.numericUpDown1);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.button3);
        base.Controls.Add(this.button2);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.keyText);
        base.Controls.Add(this.label1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "Setup2CaptchaForm";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Setup 2Captcha";
        base.Load += new EventHandler(this.Setup2CaptchaForm_Load);
        this.numericUpDown1.EndInit();
        this.numericUpDown2.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void keyText_TextChanged(object sender, EventArgs e)
    {
        this.string_0 = this.keyText.Text;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        if (this.numericUpDown1.Value == decimal.Zero)
        {
            this.numericUpDown1.Value = decimal.One;
        }
        if (this.numericUpDown1.Value == 121M)
        {
            this.numericUpDown1.Value = 120M;
        }
        this.int_1 = ((int) this.numericUpDown1.Value) * 0x3e8;
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
        if (this.numericUpDown2.Value == decimal.Zero)
        {
            this.numericUpDown2.Value = decimal.One;
        }
        if (this.numericUpDown2.Value == 21M)
        {
            this.numericUpDown2.Value = 20M;
        }
        this.int_2 = (int) this.numericUpDown2.Value;
    }

    private void Setup2CaptchaForm_Load(object sender, EventArgs e)
    {
        this.keyText.Text = this.string_1;
        this.numericUpDown1.Value = this.int_0;
        this.numericUpDown2.Value = this.int_3;
    }
}

