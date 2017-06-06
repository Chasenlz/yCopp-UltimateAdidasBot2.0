using Polenter.Serialization;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public sealed class SetupAntiCaptchaForm : Form
{
    private Button button1;
    private Button button2;
    private Button button3;
    private IContainer icontainer_0;
    public int int_0;
    public int int_1;
    public int int_2;
    private TextBox ipText;
    private TextBox keyText;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label metroLabel1;
    private Label metroLabel2;
    private Label metroLabel3;
    private Label metroLabel4;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private TextBox portText;
    private TextBox pwText;
    public string string_0;
    public string string_1;
    public string string_2;
    public string string_3;
    private TextBox userText;

    public SetupAntiCaptchaForm()
    {
        this.InitializeComponent();
    }

    public SetupAntiCaptchaForm(string string_4, string string_5, int int_3, string string_6, string string_7, int int_4, int int_5)
    {
        this.InitializeComponent();
        this.string_0 = string_4;
        this.string_1 = string_5;
        this.int_0 = int_3;
        this.string_2 = string_6;
        this.string_3 = string_7;
        this.int_1 = int_4;
        this.int_2 = int_5;
        this.keyText.Text = string_4;
        this.ipText.Text = string_5;
        if (int_3 != 0)
        {
            this.portText.Text = int_3.ToString();
        }
        this.userText.Text = this.string_2;
        this.pwText.Text = string_7;
        this.numericUpDown1.Value = int_4 / 0x3e8;
        this.numericUpDown2.Value = int_5;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.string_0 = this.keyText.Text;
        this.string_1 = this.ipText.Text;
        this.string_2 = this.userText.Text;
        this.string_3 = this.pwText.Text;
        if (this.string_0.Equals(string.Empty))
        {
            MessageBox.Show("Please enter your API-key.");
        }
        else
        {
            try
            {
                string[] textArray1 = new string[] { this.string_0, "#", this.string_1, "#", this.int_0.ToString(), "#", this.string_2, "#", this.string_3, "#", this.int_1.ToString(), "#", this.int_2.ToString() };
                new SharpSerializer(true).Serialize(string.Concat(textArray1), "settings2.bin");
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
        Process.Start("http://getcaptchasolution.com/wco5ohcg0j");
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(SetupAntiCaptchaForm));
        this.label5 = new Label();
        this.numericUpDown2 = new NumericUpDown();
        this.label4 = new Label();
        this.label3 = new Label();
        this.numericUpDown1 = new NumericUpDown();
        this.label2 = new Label();
        this.button3 = new Button();
        this.button2 = new Button();
        this.button1 = new Button();
        this.keyText = new TextBox();
        this.label1 = new Label();
        this.metroLabel1 = new Label();
        this.metroLabel2 = new Label();
        this.metroLabel3 = new Label();
        this.metroLabel4 = new Label();
        this.ipText = new TextBox();
        this.portText = new TextBox();
        this.userText = new TextBox();
        this.pwText = new TextBox();
        this.numericUpDown2.BeginInit();
        this.numericUpDown1.BeginInit();
        base.SuspendLayout();
        this.label5.AutoSize = true;
        this.label5.Location = new Point(0x16, 20);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0xc7, 13);
        this.label5.TabIndex = 0x15;
        this.label5.Text = "No Anti-Captcha account? Sign up here:";
        this.numericUpDown2.Location = new Point(0xa2, 0x11f);
        this.numericUpDown2.Name = "numericUpDown2";
        this.numericUpDown2.Size = new Size(120, 20);
        this.numericUpDown2.TabIndex = 20;
        int[] bits = new int[4];
        bits[0] = 1;
        this.numericUpDown2.Value = new decimal(bits);
        this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
        this.label4.AutoSize = true;
        this.label4.Location = new Point(0x19, 0x11f);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x6f, 13);
        this.label4.TabIndex = 0x13;
        this.label4.Text = "Captchas per request:";
        this.label3.AutoSize = true;
        this.label3.Location = new Point(0x120, 0xfb);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x35, 13);
        this.label3.TabIndex = 0x12;
        this.label3.Text = "second(s)";
        this.numericUpDown1.Location = new Point(0xa2, 0xf9);
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new Size(120, 20);
        this.numericUpDown1.TabIndex = 0x11;
        int[] numArray2 = new int[4];
        numArray2[0] = 10;
        this.numericUpDown1.Value = new decimal(numArray2);
        this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x19, 0xf9);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x57, 13);
        this.label2.TabIndex = 0x10;
        this.label2.Text = "Request interval:";
        this.button3.Location = new Point(0x10f, 20);
        this.button3.Name = "button3";
        this.button3.Size = new Size(0x5e, 0x17);
        this.button3.TabIndex = 15;
        this.button3.Text = "Create Account";
        this.button3.Click += new EventHandler(this.button3_Click);
        this.button2.Location = new Point(0xeb, 0x14b);
        this.button2.Name = "button2";
        this.button2.Size = new Size(90, 30);
        this.button2.TabIndex = 14;
        this.button2.Text = "Cancel";
        this.button2.Click += new EventHandler(this.button2_Click);
        this.button1.Location = new Point(70, 0x14b);
        this.button1.Name = "button1";
        this.button1.Size = new Size(90, 30);
        this.button1.TabIndex = 13;
        this.button1.Text = "Save";
        this.button1.Click += new EventHandler(this.button1_Click);
        this.keyText.Location = new Point(0xa2, 60);
        this.keyText.Name = "keyText";
        this.keyText.Size = new Size(0xb3, 20);
        this.keyText.TabIndex = 12;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x19, 0x3d);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x70, 13);
        this.label1.TabIndex = 11;
        this.label1.Text = "Anti-Captcha API-Key:";
        this.metroLabel1.AutoSize = true;
        this.metroLabel1.Location = new Point(0x19, 0x60);
        this.metroLabel1.Name = "metroLabel1";
        this.metroLabel1.Size = new Size(0x31, 13);
        this.metroLabel1.TabIndex = 0x16;
        this.metroLabel1.Text = "Proxy IP:";
        this.metroLabel2.AutoSize = true;
        this.metroLabel2.Location = new Point(0x19, 0x81);
        this.metroLabel2.Name = "metroLabel2";
        this.metroLabel2.Size = new Size(0x3a, 13);
        this.metroLabel2.TabIndex = 0x17;
        this.metroLabel2.Text = "Proxy Port:";
        this.metroLabel3.AutoSize = true;
        this.metroLabel3.Location = new Point(0x19, 0xa5);
        this.metroLabel3.Name = "metroLabel3";
        this.metroLabel3.Size = new Size(0x57, 13);
        this.metroLabel3.TabIndex = 0x18;
        this.metroLabel3.Text = "Proxy Username:";
        this.metroLabel4.AutoSize = true;
        this.metroLabel4.Location = new Point(0x19, 0xcf);
        this.metroLabel4.Name = "metroLabel4";
        this.metroLabel4.Size = new Size(0x55, 13);
        this.metroLabel4.TabIndex = 0x19;
        this.metroLabel4.Text = "Proxy Password:";
        this.ipText.Location = new Point(0xa2, 0x60);
        this.ipText.Name = "ipText";
        this.ipText.Size = new Size(0xb3, 20);
        this.ipText.TabIndex = 0x1a;
        this.portText.Location = new Point(0xa2, 0x81);
        this.portText.Name = "portText";
        this.portText.Size = new Size(0x43, 20);
        this.portText.TabIndex = 0x1b;
        this.userText.Location = new Point(0xa2, 0xa5);
        this.userText.Name = "userText";
        this.userText.Size = new Size(0xb3, 20);
        this.userText.TabIndex = 0x1c;
        this.pwText.Location = new Point(0xa2, 0xce);
        this.pwText.Name = "pwText";
        this.pwText.Size = new Size(0xb3, 20);
        this.pwText.TabIndex = 0x1d;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x187, 0x176);
        base.Controls.Add(this.pwText);
        base.Controls.Add(this.userText);
        base.Controls.Add(this.portText);
        base.Controls.Add(this.ipText);
        base.Controls.Add(this.metroLabel4);
        base.Controls.Add(this.metroLabel3);
        base.Controls.Add(this.metroLabel2);
        base.Controls.Add(this.metroLabel1);
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
        base.Name = "SetupAntiCaptchaForm";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Setup Anti-Captcha";
        base.Load += new EventHandler(this.SetupAntiCaptchaForm_Load);
        this.numericUpDown2.EndInit();
        this.numericUpDown1.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
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

    private void SetupAntiCaptchaForm_Load(object sender, EventArgs e)
    {
    }
}

