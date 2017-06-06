using CefSharp;
using CefSharp.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class SpyBrowser : Form
{
    private Button backBtn;
    private Button button1;
    public ChromiumWebBrowser chromiumWebBrowser_0;
    private Button contBtn;
    private IContainer icontainer_0;
    private Button injectToken;
    public MainForm mainForm_0;
    public Panel panel_0;

    public SpyBrowser()
    {
        this.InitializeComponent();
    }

    private void backBtn_Click(object sender, EventArgs e)
    {
        if (((this.chromiumWebBrowser_0 != null) && (this.chromiumWebBrowser_0.GetBrowser() != null)) && this.chromiumWebBrowser_0.GetBrowser().CanGoBack)
        {
            this.chromiumWebBrowser_0.GetBrowser().GoBack();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.chromiumWebBrowser_0.GetBrowser().GetHost().ShowDevTools(null, 0, 0);
    }

    private void contBtn_Click(object sender, EventArgs e)
    {
        if (((this.chromiumWebBrowser_0 != null) && (this.chromiumWebBrowser_0.GetBrowser() != null)) && this.chromiumWebBrowser_0.GetBrowser().CanGoForward)
        {
            this.chromiumWebBrowser_0.GetBrowser().GoForward();
        }
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(SpyBrowser));
        this.backBtn = new Button();
        this.contBtn = new Button();
        this.button1 = new Button();
        this.injectToken = new Button();
        base.SuspendLayout();
        this.backBtn.Anchor = AnchorStyles.Bottom;
        this.backBtn.Location = new Point(0x12f, 0x1f3);
        this.backBtn.Name = "backBtn";
        this.backBtn.Size = new Size(0x4b, 0x17);
        this.backBtn.TabIndex = 0;
        this.backBtn.Text = "<- Page back";
        this.backBtn.UseVisualStyleBackColor = true;
        this.backBtn.Click += new EventHandler(this.backBtn_Click);
        this.contBtn.Anchor = AnchorStyles.Bottom;
        this.contBtn.Location = new Point(0x180, 0x1f3);
        this.contBtn.Name = "contBtn";
        this.contBtn.Size = new Size(0x4b, 0x17);
        this.contBtn.TabIndex = 1;
        this.contBtn.Text = "Page ->";
        this.contBtn.UseVisualStyleBackColor = true;
        this.contBtn.Click += new EventHandler(this.contBtn_Click);
        this.button1.Anchor = AnchorStyles.Bottom;
        this.button1.Location = new Point(0x1d1, 0x1f3);
        this.button1.Name = "button1";
        this.button1.Size = new Size(0x60, 0x17);
        this.button1.TabIndex = 2;
        this.button1.Text = "Open Dev-Tools";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new EventHandler(this.button1_Click);
        this.injectToken.Anchor = AnchorStyles.Bottom;
        this.injectToken.Location = new Point(0x237, 0x1f3);
        this.injectToken.Name = "injectToken";
        this.injectToken.Size = new Size(0x77, 0x17);
        this.injectToken.TabIndex = 3;
        this.injectToken.Text = "Inject Captcha Token";
        this.injectToken.UseVisualStyleBackColor = true;
        this.injectToken.Click += new EventHandler(this.injectToken_Click);
        base.AutoScaleDimensions = new SizeF(96f, 96f);
        base.AutoScaleMode = AutoScaleMode.Dpi;
        base.ClientSize = new Size(0x3cc, 0x20d);
        base.Controls.Add(this.injectToken);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.contBtn);
        base.Controls.Add(this.backBtn);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "SpyBrowser";
        base.SizeGripStyle = SizeGripStyle.Show;
        this.Text = "SpyBrowser";
        base.FormClosing += new FormClosingEventHandler(this.SpyBrowser_FormClosing);
        base.Load += new EventHandler(this.SpyBrowser_Load);
        base.ResumeLayout(false);
    }

    private void injectToken_Click(object sender, EventArgs e)
    {
        string str = this.mainForm_0.method_51();
        if (str.Equals("error"))
        {
            MessageBox.Show(this, "No token available, please harvest tokens first!");
        }
        else
        {
            TimeSpan? timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync(("document.getElementById('g-recaptcha-response').value = '" + str + "';"), timeout).Wait();
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByName('submit_captcha')[0].click();", ((TimeSpan?) null)).Wait();
            MessageBox.Show(this, "Success! If the shoes did not add to cart yet, please click 'Add to bag' manually. You do NOT need to solve the captcha, even though it looks like it is not solved yet.");
        }
    }

    private void SpyBrowser_FormClosing(object sender, FormClosingEventArgs e)
    {
        this.panel_0.Visible = false;
        base.Controls.Remove(this.panel_0);
        this.panel_0 = null;
        this.chromiumWebBrowser_0 = null;
    }

    private void SpyBrowser_Load(object sender, EventArgs e)
    {
    }
}

