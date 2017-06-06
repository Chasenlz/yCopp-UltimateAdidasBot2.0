using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

public sealed class FetchApiWishlist : Form
{
    private Button button1;
    private Button button2;
    private IContainer icontainer_0;
    private TextBox keyBox;
    private Label label1;
    private MainForm mainForm_0;
    private TextBox pidBox;
    public string string_0;

    public FetchApiWishlist()
    {
        this.string_0 = string.Empty;
        this.InitializeComponent();
    }

    public FetchApiWishlist(MainForm mainForm_1)
    {
        this.string_0 = string.Empty;
        this.InitializeComponent();
        this.mainForm_0 = mainForm_1;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Uri requestUri = null;
        try
        {
            requestUri = new UriBuilder(this.mainForm_0.dictionary_8[this.mainForm_0.int_2] + "Wishlist-Show").Uri;
        }
        catch (Exception)
        {
            MessageBox.Show("Error Code EX_WL1.");
            return;
        }
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(requestUri);
        request.UnsafeAuthenticatedConnectionSharing = true;
        request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
        request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        request.Headers.Set("Upgrade-Insecure-Requests", "1");
        request.Headers.Set("Accept-Language", "de-DE,de;q=0.8,en-US;q=0.6,en;q=0.4");
        request.Method = "GET";
        request.Timeout = 0x2710;
        request.CookieContainer = new CookieContainer();
        Cookie cookie = new Cookie("wishlist", "%5B%22" + this.pidBox.Text + "%22%5D", "/", "." + this.mainForm_0.dictionary_9[this.mainForm_0.int_2]);
        request.CookieContainer.Add(cookie);
        object[] args = new object[] { "Connection", "keep-alive" };
        request.Headers.GetType().InvokeMember("ChangeInternal", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance, System.Type.DefaultBinder, request.Headers, args);
        HttpWebResponse response = null;
        try
        {
            response = (HttpWebResponse) request.GetResponse();
            string str = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            int index = str.IndexOf("data-sitekey=\"");
            if (index == -1)
            {
                MessageBox.Show("Can't find the API-Key. Either the PID is wrong, the product does not use a captcha or the product is not live yet.");
            }
            else
            {
                int num2 = str.IndexOf('"', index + 14);
                string str2 = str.Substring(index + 14, num2 - (index + 14));
                this.keyBox.Visible = true;
                this.button2.Visible = true;
                this.keyBox.Text = str2;
            }
        }
        catch (WebException)
        {
            MessageBox.Show("Error while requesting the product page.");
            if (response != null)
            {
                response.Close();
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.string_0 = this.keyBox.Text;
        base.DialogResult = DialogResult.OK;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FetchApiWishlist_Load(object sender, EventArgs e)
    {
    }

    private void InitializeComponent()
    {
        this.pidBox = new TextBox();
        this.keyBox = new TextBox();
        this.button1 = new Button();
        this.label1 = new Label();
        this.button2 = new Button();
        base.SuspendLayout();
        this.pidBox.Location = new Point(90, 0x19);
        this.pidBox.Name = "pidBox";
        this.pidBox.Size = new Size(100, 20);
        this.pidBox.TabIndex = 0;
        this.keyBox.Location = new Point(0x21, 0x61);
        this.keyBox.Name = "keyBox";
        this.keyBox.ReadOnly = true;
        this.keyBox.Size = new Size(0xd7, 20);
        this.keyBox.TabIndex = 1;
        this.keyBox.Visible = false;
        this.button1.Location = new Point(0x68, 60);
        this.button1.Name = "button1";
        this.button1.Size = new Size(0x4b, 0x17);
        this.button1.TabIndex = 2;
        this.button1.Text = "Fetch";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new EventHandler(this.button1_Click);
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x38, 0x1c);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x1c, 13);
        this.label1.TabIndex = 3;
        this.label1.Text = "PID:";
        this.button2.Location = new Point(0x68, 0x7b);
        this.button2.Name = "button2";
        this.button2.Size = new Size(0x4b, 0x17);
        this.button2.TabIndex = 5;
        this.button2.Text = "Apply";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Visible = false;
        this.button2.Click += new EventHandler(this.button2_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x114, 0x9f);
        base.Controls.Add(this.button2);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.keyBox);
        base.Controls.Add(this.pidBox);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Name = "FetchApiWishlist";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Fetch from Wishlist";
        base.Load += new EventHandler(this.FetchApiWishlist_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

