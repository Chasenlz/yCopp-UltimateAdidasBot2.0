using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

public sealed class FetchApiKey : Form
{
    private TextBox apiBox;
    private Button fetchButton;
    private IContainer icontainer_0;
    private Label label1;
    public string string_0;
    private TextBox urlText;
    private Button useButton;

    public FetchApiKey()
    {
        this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FetchApiKey_Load(object sender, EventArgs e)
    {
    }

    private void fetchButton_Click(object sender, EventArgs e)
    {
        Uri requestUri = null;
        try
        {
            requestUri = new UriBuilder(this.urlText.Text).Uri;
        }
        catch (Exception)
        {
            MessageBox.Show("Please enter an valid URL.");
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
                MessageBox.Show("Can't find an API-Key in this product page.");
            }
            else
            {
                int num2 = str.IndexOf('"', index + 14);
                string str2 = str.Substring(index + 14, num2 - (index + 14));
                this.apiBox.Visible = true;
                this.useButton.Visible = true;
                this.apiBox.Text = str2;
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

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(FetchApiKey));
        this.label1 = new Label();
        this.urlText = new TextBox();
        this.fetchButton = new Button();
        this.apiBox = new TextBox();
        this.useButton = new Button();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(20, 0x20);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x20, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "URL:";
        this.urlText.Location = new Point(0x3b, 0x20);
        this.urlText.Name = "urlText";
        this.urlText.Size = new Size(0x147, 20);
        this.urlText.TabIndex = 1;
        this.fetchButton.Location = new Point(0x188, 30);
        this.fetchButton.Name = "fetchButton";
        this.fetchButton.Size = new Size(0x4b, 0x17);
        this.fetchButton.TabIndex = 2;
        this.fetchButton.Text = "Fetch";
        this.fetchButton.Click += new EventHandler(this.fetchButton_Click);
        this.apiBox.Location = new Point(0x3b, 0x48);
        this.apiBox.Name = "apiBox";
        this.apiBox.ReadOnly = true;
        this.apiBox.Size = new Size(0x147, 20);
        this.apiBox.TabIndex = 3;
        this.apiBox.Visible = false;
        this.useButton.Location = new Point(0x188, 70);
        this.useButton.Name = "useButton";
        this.useButton.Size = new Size(0x4b, 0x17);
        this.useButton.TabIndex = 4;
        this.useButton.Text = "Use key";
        this.useButton.Visible = false;
        this.useButton.Click += new EventHandler(this.useButton_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x1f1, 0x70);
        base.Controls.Add(this.useButton);
        base.Controls.Add(this.apiBox);
        base.Controls.Add(this.fetchButton);
        base.Controls.Add(this.urlText);
        base.Controls.Add(this.label1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "FetchApiKey";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Fetch API-Key from product page";
        base.Load += new EventHandler(this.FetchApiKey_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void useButton_Click(object sender, EventArgs e)
    {
        this.string_0 = this.apiBox.Text;
        base.DialogResult = DialogResult.OK;
    }
}

