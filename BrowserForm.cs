using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class BrowserForm : Form
{
    public bool bool_0;
    private Button cartButton;
    private Button ccButton;
    private ChromiumWebBrowser chromiumWebBrowser_0;
    private Button closeButton;
    private Dictionary<int, bool> dictionary_0;
    private IContainer icontainer_0;
    public int int_0;
    private MainForm mainForm_0;
    private Panel panel1;
    private Button ppButton;
    public string string_0;
    public string string_1;
    public string string_2;

    public BrowserForm()
    {
        Dictionary<int, bool> dictionary1 = new Dictionary<int, bool> {
            { 
                2,
                true
            },
            { 
                3,
                false
            },
            { 
                4,
                false
            },
            { 
                5,
                true
            },
            { 
                6,
                false
            },
            { 
                7,
                true
            },
            { 
                8,
                false
            },
            { 
                9,
                true
            },
            { 
                10,
                true
            },
            { 
                11,
                false
            },
            { 
                12,
                true
            },
            { 
                13,
                false
            },
            { 
                14,
                true
            }
        };
        this.dictionary_0 = dictionary1;
        this.int_0 = -1;
        this.InitializeComponent();
    }

    public BrowserForm(MainForm mainForm_1)
    {
        Dictionary<int, bool> dictionary1 = new Dictionary<int, bool> {
            { 
                2,
                true
            },
            { 
                3,
                false
            },
            { 
                4,
                false
            },
            { 
                5,
                true
            },
            { 
                6,
                false
            },
            { 
                7,
                true
            },
            { 
                8,
                false
            },
            { 
                9,
                true
            },
            { 
                10,
                true
            },
            { 
                11,
                false
            },
            { 
                12,
                true
            },
            { 
                13,
                false
            },
            { 
                14,
                true
            }
        };
        this.dictionary_0 = dictionary1;
        this.int_0 = -1;
        this.mainForm_0 = mainForm_1;
        this.InitializeComponent();
    }

    private void BrowserForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            if (this.chromiumWebBrowser_0 != null)
            {
                this.chromiumWebBrowser_0.Dispose();
            }
        }
        catch (Exception)
        {
        }
    }

    private void BrowserForm_Load(object sender, EventArgs e)
    {
    }

    private void cartButton_Click(object sender, EventArgs e)
    {
        if (this.chromiumWebBrowser_0 != null)
        {
            this.chromiumWebBrowser_0.Load(this.string_2);
        }
    }

    private void ccButton_Click(object sender, EventArgs e)
    {
        if (this.chromiumWebBrowser_0 != null)
        {
            this.chromiumWebBrowser_0.Load(this.string_1);
        }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        try
        {
            if ((this.chromiumWebBrowser_0 != null) && this.chromiumWebBrowser_0.IsBrowserInitialized)
            {
                this.chromiumWebBrowser_0.Dispose();
            }
        }
        catch (Exception)
        {
        }
        base.Close();
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(BrowserForm));
        this.panel1 = new Panel();
        this.closeButton = new Button();
        this.cartButton = new Button();
        this.ccButton = new Button();
        this.ppButton = new Button();
        base.SuspendLayout();
        this.panel1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.panel1.Location = new Point(12, 2);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(0x3f9, 0x201);
        this.panel1.TabIndex = 0;
        this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
        this.closeButton.Anchor = AnchorStyles.Bottom;
        this.closeButton.Location = new Point(0x25a, 0x20d);
        this.closeButton.Name = "closeButton";
        this.closeButton.Size = new Size(0x4b, 0x17);
        this.closeButton.TabIndex = 2;
        this.closeButton.Text = "Close";
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Click += new EventHandler(this.closeButton_Click);
        this.cartButton.Anchor = AnchorStyles.Bottom;
        this.cartButton.Location = new Point(0x209, 0x20d);
        this.cartButton.Name = "cartButton";
        this.cartButton.Size = new Size(0x4b, 0x17);
        this.cartButton.TabIndex = 3;
        this.cartButton.Text = "Cart";
        this.cartButton.UseVisualStyleBackColor = true;
        this.cartButton.Click += new EventHandler(this.cartButton_Click);
        this.ccButton.Anchor = AnchorStyles.Bottom;
        this.ccButton.Location = new Point(440, 0x20d);
        this.ccButton.Name = "ccButton";
        this.ccButton.Size = new Size(0x4b, 0x17);
        this.ccButton.TabIndex = 4;
        this.ccButton.Text = "CC";
        this.ccButton.UseVisualStyleBackColor = true;
        this.ccButton.Click += new EventHandler(this.ccButton_Click);
        this.ppButton.Anchor = AnchorStyles.Bottom;
        this.ppButton.Location = new Point(0x167, 0x20d);
        this.ppButton.Name = "ppButton";
        this.ppButton.Size = new Size(0x4b, 0x17);
        this.ppButton.TabIndex = 5;
        this.ppButton.Text = "PayPal";
        this.ppButton.UseVisualStyleBackColor = true;
        this.ppButton.Click += new EventHandler(this.ppButton_Click);
        base.AutoScaleDimensions = new SizeF(96f, 96f);
        base.AutoScaleMode = AutoScaleMode.Dpi;
        base.ClientSize = new Size(0x411, 560);
        base.Controls.Add(this.ppButton);
        base.Controls.Add(this.ccButton);
        base.Controls.Add(this.cartButton);
        base.Controls.Add(this.closeButton);
        base.Controls.Add(this.panel1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "BrowserForm";
        this.Text = "BrowserForm";
        base.FormClosing += new FormClosingEventHandler(this.BrowserForm_FormClosing);
        base.Load += new EventHandler(this.BrowserForm_Load);
        base.ResumeLayout(false);
    }

    public void method_0(ChromiumWebBrowser chromiumWebBrowser_1)
    {
        this.panel1.Controls.Add(chromiumWebBrowser_1);
        this.chromiumWebBrowser_0 = chromiumWebBrowser_1;
    }

    public bool method_1(GClass0 gclass0_0)
    {
        Class16 class2 = new Class16 {
            browserForm_0 = this,
            gclass0_0 = gclass0_0
        };
        class2.gclass4_0 = class2.gclass0_0.checkoutProfile;
        this.chromiumWebBrowser_0.LoadingStateChanged += new EventHandler<LoadingStateChangedEventArgs>(class2.method_0);
        return true;
    }

    private void method_10()
    {
        base.Opacity = 0.0;
        base.Visible = true;
        this.chromiumWebBrowser_0.Focus();
    }

    private void method_11()
    {
        base.Visible = false;
        base.Opacity = 100.0;
    }

    private void method_12()
    {
        this.ccButton.Visible = false;
        this.ppButton.Visible = false;
        this.cartButton.Visible = false;
    }

    private void method_13()
    {
        this.chromiumWebBrowser_0.Focus();
    }

    private void method_14()
    {
        this.ccButton.Visible = false;
        this.ppButton.Visible = false;
        this.cartButton.Visible = false;
    }

    private void method_2(GClass0 gclass0_0)
    {
        GClass4 checkoutProfile = gclass0_0.checkoutProfile;
        int num = 0;
        TimeSpan? timeout = null;
        Task<JavascriptResponse> task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_12, timeout);
        task.Wait();
        while ((task.get_Result().Result == null) || !((string) task.get_Result().Result).Equals("exists"))
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_12, timeout).Wait();
            Thread.Sleep(500);
            num++;
            if (num > 30)
            {
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                }
                return;
            }
        }
        Thread.Sleep(250);
        if (checkoutProfile.countryCode > 1)
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_5 + ".focus();"), timeout).Wait();
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_5 + ".select();"), timeout).Wait();
            this.method_6(checkoutProfile.name);
            this.method_7();
            this.method_6(checkoutProfile.lastName);
            this.method_7();
            this.method_6(checkoutProfile.address1);
            this.method_7();
            if (checkoutProfile.address2 != null)
            {
                this.method_6(checkoutProfile.address2);
            }
            this.method_7();
            if (this.dictionary_0[checkoutProfile.countryCode])
            {
                this.method_6(checkoutProfile.city);
                this.method_7();
                this.method_6(checkoutProfile.postalCode);
            }
            else
            {
                this.method_6(checkoutProfile.postalCode);
                this.method_7();
                this.method_6(checkoutProfile.city);
            }
            this.method_7();
            if (!checkoutProfile.phoneNumber.Equals(string.Empty))
            {
                this.method_6(checkoutProfile.phoneNumber);
            }
            this.method_7();
            this.method_6(checkoutProfile.email);
        }
        else if (checkoutProfile.countryCode == 0)
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_6 + ".focus();"), timeout).Wait();
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_6 + ".select();"), timeout).Wait();
            this.method_6(checkoutProfile.name);
            this.method_7();
            this.method_6(checkoutProfile.lastName);
            this.method_7();
            this.method_6(checkoutProfile.address1);
            this.method_7();
            if (checkoutProfile.address2 != null)
            {
                this.method_6(checkoutProfile.address2);
            }
            this.method_7();
            this.method_6(checkoutProfile.city);
            Thread.Sleep(500);
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByClassName('ffSelectButton')[0].click();", timeout).Wait();
            Thread.Sleep(500);
            this.method_9(checkoutProfile.stateCode + 1);
            this.method_8();
            this.method_7();
            this.method_7();
            this.method_7();
            this.method_6(checkoutProfile.postalCode);
            this.method_7();
            this.method_6(checkoutProfile.phoneNumber);
            this.method_7();
            this.method_7();
            this.method_6(checkoutProfile.email);
        }
        else if (checkoutProfile.countryCode == 1)
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_delivery_singleshipping_shippingAddress_addressFields_firstName').focus();", timeout).Wait();
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_delivery_singleshipping_shippingAddress_addressFields_firstName').select();", timeout).Wait();
            this.method_6(checkoutProfile.name);
            this.method_7();
            this.method_6(checkoutProfile.lastName);
            this.method_7();
            this.method_6(checkoutProfile.address1);
            this.method_7();
            if (checkoutProfile.address2 != null)
            {
                this.method_6(checkoutProfile.address2);
            }
            this.method_7();
            this.method_6(checkoutProfile.city);
            this.method_7();
            this.method_9(checkoutProfile.stateCode + 1);
            this.method_7();
            this.method_6(checkoutProfile.postalCode);
            this.method_7();
            if (!checkoutProfile.phoneNumber.Equals(string.Empty))
            {
                this.method_6(checkoutProfile.phoneNumber);
            }
            this.method_7();
            this.method_7();
            this.method_6(checkoutProfile.email);
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_delivery_singleshipping_shippingAddress_ageConfirmation').click();", timeout).Wait();
        }
        if (checkoutProfile.countryCode > 1)
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByName('dwfrm_shipping_submitshiptoaddress')[0].click();", timeout).Wait();
        }
        else
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_delivery_savedelivery').click();", timeout).Wait();
        }
        timeout = null;
        task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_7, timeout);
        task.Wait();
        while ((task.get_Result().Result == null) || !((string) task.get_Result().Result).Equals("exists"))
        {
            timeout = null;
            task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_7, timeout);
            task.Wait();
            Thread.Sleep(500);
            num++;
            if (num > 30)
            {
                task = this.chromiumWebBrowser_0.EvaluateScriptAsync("!document.getElementsByClassName('alert-box ab-warning')[0].className.includes('hidden');", (TimeSpan?) null);
                task.Wait();
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if ((task.get_Result().Result != null) && ((bool) task.get_Result().Result))
                {
                    if (this.mainForm_0 != null)
                    {
                        this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed! Either your shipping address is wrong or you have selected the wrong location.\n");
                        return;
                    }
                }
                else if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                }
                return;
            }
        }
        Thread.Sleep(0x7d0);
        if (checkoutProfile.countryCode > 0)
        {
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('creditcard').click();", timeout).Wait();
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_adyenencrypted_number').focus();", timeout).Wait();
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_adyenencrypted_number').select();", timeout).Wait();
            this.method_6(checkoutProfile.cardNumber);
            this.method_7();
            if (checkoutProfile.cardName != null)
            {
                this.method_6(checkoutProfile.cardName);
            }
        }
        else
        {
            base.Invoke(new MethodInvoker(this.method_10));
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_payment_creditCard_owner').focus();", timeout).Wait();
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('dwfrm_payment_creditCard_owner').select();", timeout).Wait();
            if (checkoutProfile.cardName != null)
            {
                this.method_6(checkoutProfile.cardName);
            }
            this.method_7();
            this.method_6(checkoutProfile.cardNumber);
        }
        this.method_7();
        this.method_9(checkoutProfile.expireMonth + 1);
        this.method_7();
        this.method_9(checkoutProfile.expireYear + 1);
        this.method_7();
        if (checkoutProfile.countryCode != 0)
        {
            this.method_7();
        }
        this.method_6(checkoutProfile.cvc);
        this.method_7();
        Thread.Sleep(100);
        if (checkoutProfile.countryCode > 0)
        {
            timeout = null;
            task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('co-btn_primary btn_showcart button-full-width button-ctn button-brd adi-gradient-blue button-forward')[0]) 'exists';", timeout);
            task.Wait();
            if ((task.get_Result().Result != null) && ((string) task.get_Result().Result).Equals("exists"))
            {
                timeout = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByClassName('co-btn_primary btn_showcart button-full-width button-ctn button-brd adi-gradient-blue button-forward')[0].click();", timeout).Wait();
            }
            else
            {
                timeout = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByClassName('co-btn_primary btn_showcart button-full-width button-ctn button-brd adi-gradient-blue button-forward disabled')[0].click();", timeout).Wait();
            }
        }
        else
        {
            base.Invoke(new MethodInvoker(this.method_11));
            timeout = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByClassName('co-btn_primary btn_showcart button-full-width button-ctn button-brd adi-gradient-blue button-forward')[2].click();", timeout).Wait();
        }
        Thread.Sleep(0x3e8);
        timeout = null;
        task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('thankyoumessage')[0]) 'exists';", timeout);
        task.Wait();
        num = 0;
        while ((task.get_Result().Result == null) || !((string) task.get_Result().Result).Equals("exists"))
        {
            timeout = null;
            task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('thankyoumessage')[0]) 'exists';", timeout);
            task.Wait();
            Thread.Sleep(500);
            num++;
            if (num > 30)
            {
                task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('alert-box ab-warning')[0]) 'exists';", (TimeSpan?) null);
                task.Wait();
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if ((task.get_Result().Result != null) && ((string) task.get_Result().Result).Equals("exists"))
                {
                    if (this.mainForm_0 != null)
                    {
                        this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed! Either your credit card data is wrong, you have selected the wrong location or adidas rejected your payment for security reasons.\n");
                        return;
                    }
                }
                else if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                }
                return;
            }
        }
        gclass0_0.autoCheckoutState = 2;
        gclass0_0.button0 = "View order confirmation";
        gclass0_0.button1 = string.Empty;
        gclass0_0.button2 = string.Empty;
        gclass0_0.button3 = string.Empty;
        base.Invoke(new MethodInvoker(this.method_12));
        if (this.mainForm_0 != null)
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout successfull!\n");
        }
    }

    private void method_3(GClass0 gclass0_0)
    {
        Task<JavascriptResponse> task;
        TimeSpan? nullable;
        Task<JavascriptResponse> task2;
        base.Invoke(new MethodInvoker(this.method_13));
        GClass4 checkoutProfile = gclass0_0.checkoutProfile;
        bool flag = false;
        bool flag2 = false;
        bool flag3 = false;
        int num = 0;
        while (true)
        {
            if (flag || (flag2 || flag3))
            {
                break;
            }
            nullable = null;
            task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_8, nullable);
            task.Wait();
            nullable = null;
            task2 = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementById('btnLogin')) 'exists';", nullable);
            task2.Wait();
            nullable = null;
            Task<JavascriptResponse> task3 = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('loginRedirect')[0]) 'exists';", nullable);
            task3.Wait();
            Thread.Sleep(500);
            flag = (task.get_Result().Result != null) && ((string) task.get_Result().Result).Equals("exists");
            flag2 = (task2.get_Result().Result != null) && ((string) task2.get_Result().Result).Equals("exists");
            flag3 = (task3.get_Result().Result != null) && ((string) task3.get_Result().Result).Equals("exists");
            if (num > 30)
            {
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                }
                return;
            }
            num++;
        }
        Thread.Sleep(0x3e8);
        if (flag)
        {
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_9 + ".getElementById('email').value = '" + checkoutProfile.ppLogin + "';"), nullable).Wait();
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_9 + ".getElementById('password').value = '" + checkoutProfile.ppPw + "';"), nullable).Wait();
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_9 + ".getElementById('btnLogin').click();"), nullable).Wait();
        }
        else if (flag2)
        {
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync(("document.getElementById('email').value = '" + checkoutProfile.ppLogin + "';"), nullable).Wait();
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync(("document.getElementById('password').value = '" + checkoutProfile.ppPw + "';"), nullable).Wait();
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('btnLogin').click();", nullable).Wait();
        }
        else if (flag3)
        {
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByClassName('btn full ng-binding')[0].click();", nullable).Wait();
            flag = false;
            flag2 = false;
            num = 0;
            while (true)
            {
                if (flag || flag2)
                {
                    break;
                }
                nullable = null;
                task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_8, nullable);
                task.Wait();
                nullable = null;
                task2 = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementById('btnLogin')) 'exists';", nullable);
                task2.Wait();
                Thread.Sleep(500);
                flag = (task.get_Result().Result != null) && ((string) task.get_Result().Result).Equals("exists");
                flag2 = (task2.get_Result().Result != null) && ((string) task2.get_Result().Result).Equals("exists");
                if (num > 30)
                {
                    gclass0_0.autoCheckoutState = -1;
                    gclass0_0.button0 = "Start auto checkout";
                    gclass0_0.button1 = "Checkout PP";
                    gclass0_0.button2 = "Checkout CC";
                    gclass0_0.button3 = "View Cart";
                    if (this.mainForm_0 != null)
                    {
                        this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                    }
                    return;
                }
                num++;
            }
            Thread.Sleep(0x3e8);
            if (flag)
            {
                nullable = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_9 + ".getElementById('email').value = '" + checkoutProfile.ppLogin + "';"), nullable).Wait();
                nullable = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_9 + ".getElementById('password').value = '" + checkoutProfile.ppPw + "';"), nullable).Wait();
                nullable = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync((Class21.string_9 + "contentDocument.getElementById('btnLogin').click();"), nullable).Wait();
            }
            else if (flag2)
            {
                nullable = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync(("document.getElementById('email').value = '" + checkoutProfile.ppLogin + "';"), nullable).Wait();
                nullable = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync(("document.getElementById('password').value = '" + checkoutProfile.ppPw + "';"), nullable).Wait();
                nullable = null;
                this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('btnLogin').click();", nullable).Wait();
            }
        }
        nullable = null;
        task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_10, nullable);
        task.Wait();
        num = 0;
        while ((task.get_Result().Result == null) || !((string) task.get_Result().Result).Equals("exists"))
        {
            nullable = null;
            task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_10, nullable);
            task.Wait();
            Thread.Sleep(500);
            num++;
            if (num > 30)
            {
                nullable = null;
                task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementById('pageLevelErrors')) 'exists';", nullable);
                task.Wait();
                task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('notification notification-critical')[0]) 'exists';", (TimeSpan?) null);
                task.Wait();
                bool flag4 = (task.get_Result().Result != null) && ((string) task.get_Result().Result).Equals("exists");
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if ((task.get_Result().Result != null) && ((string) task.get_Result().Result).Equals("exists"))
                {
                    if (this.mainForm_0 != null)
                    {
                        this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed! Either the login data is wrong or your shipping address is invalid. \n");
                    }
                }
                else if (flag4)
                {
                    if (this.mainForm_0 != null)
                    {
                        this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed! Wrong login data. \n");
                    }
                }
                else if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                }
                return;
            }
        }
        Thread.Sleep(0x3e8);
        nullable = null;
        this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementById('confirmButtonTop').click();", nullable).Wait();
        Thread.Sleep(0x3e8);
        nullable = null;
        task = this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_11, nullable);
        task.Wait();
        num = 0;
        while ((task.get_Result().Result == null) || !((string) task.get_Result().Result).Equals("exists"))
        {
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync(Class21.string_11, nullable).Wait();
            Thread.Sleep(500);
            num++;
            if (num > 30)
            {
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed!\n");
                }
                return;
            }
        }
        Thread.Sleep(0xbb8);
        nullable = null;
        this.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByName('dwfrm_payment_paypal')[0].click();", nullable).Wait();
        Thread.Sleep(0x7d0);
        nullable = null;
        task = this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('thankyoumessage')[0]) 'exists';", nullable);
        task.Wait();
        num = 0;
        while ((task.get_Result().Result == null) || !((string) task.get_Result().Result).Equals("exists"))
        {
            nullable = null;
            this.chromiumWebBrowser_0.EvaluateScriptAsync("if(!!document.getElementsByClassName('thankyoumessage')[0]) 'exists';", nullable).Wait();
            Thread.Sleep(500);
            num++;
            if (num > 30)
            {
                gclass0_0.autoCheckoutState = -1;
                gclass0_0.button0 = "Start auto checkout";
                gclass0_0.button1 = "Checkout PP";
                gclass0_0.button2 = "Checkout CC";
                gclass0_0.button3 = "View Cart";
                if (this.mainForm_0 != null)
                {
                    this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout failed during last step. Please check your email to see if the order was successful. \n");
                }
                return;
            }
        }
        gclass0_0.autoCheckoutState = 2;
        gclass0_0.button0 = "View order confirmation";
        gclass0_0.button1 = string.Empty;
        gclass0_0.button2 = string.Empty;
        gclass0_0.button3 = string.Empty;
        base.Invoke(new MethodInvoker(this.method_14));
        if (this.mainForm_0 != null)
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Auto Checkout successfull!\n");
        }
    }

    private void method_4(object sender, EventArgs e)
    {
        MessageBox.Show(this.int_0.ToString());
    }

    private int method_5(char char_0) => 
        char_0;

    private void method_6(string string_3)
    {
        KeyEvent keyEvent = new KeyEvent {
            Type = KeyEventType.Char
        };
        for (int i = 0; i < string_3.Length; i++)
        {
            keyEvent.WindowsKeyCode = string_3.ToCharArray()[i];
            this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
        }
        Thread.Sleep(10);
    }

    private void method_7()
    {
        KeyEvent keyEvent = new KeyEvent {
            WindowsKeyCode = 9,
            Type = KeyEventType.KeyDown
        };
        this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
        keyEvent.Type = KeyEventType.KeyUp;
        this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
        Thread.Sleep(10);
    }

    private void method_8()
    {
        KeyEvent keyEvent = new KeyEvent {
            WindowsKeyCode = 13,
            Type = KeyEventType.KeyDown
        };
        this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
        keyEvent.Type = KeyEventType.KeyUp;
        this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
        Thread.Sleep(10);
    }

    private void method_9(int int_1)
    {
        KeyEvent keyEvent = new KeyEvent {
            WindowsKeyCode = 40
        };
        for (int i = 0; i < int_1; i++)
        {
            keyEvent.Type = KeyEventType.KeyDown;
            this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
            keyEvent.Type = KeyEventType.KeyUp;
            this.chromiumWebBrowser_0.GetBrowser().GetHost().SendKeyEvent(keyEvent);
        }
        Thread.Sleep(10);
    }

    [DllImport("user32.dll", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Auto)]
    public static extern void mouse_event(long long_0, long long_1, long long_2, long long_3, long long_4);
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void ppButton_Click(object sender, EventArgs e)
    {
        if (this.chromiumWebBrowser_0 != null)
        {
            this.chromiumWebBrowser_0.Load(this.string_0);
        }
    }

    [DllImport("user32.dll")]
    private static extern bool SetCursorPos(int int_1, int int_2);
    public static void smethod_0()
    {
        mouse_event(6L, 0L, 0L, 0L, 0L);
    }

    public static void smethod_1(int int_1, int int_2)
    {
        SetCursorPos(int_1, int_2);
    }

    private sealed class Class16
    {
        public BrowserForm browserForm_0;
        public GClass0 gclass0_0;
        public GClass4 gclass4_0;
        public ThreadStart threadStart_0;
        public ThreadStart threadStart_1;

        internal void method_0(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading && (this.browserForm_0.int_0 == -1))
            {
                this.browserForm_0.int_0 = 0;
            }
            else if (!e.IsLoading && (this.browserForm_0.int_0 == 0))
            {
                if ((this.gclass4_0.paymentMethod == 0) && (this.browserForm_0.int_0 == 0))
                {
                    new Thread(this.threadStart_0 ?? (this.threadStart_0 = new ThreadStart(this.method_1))).Start();
                    this.browserForm_0.int_0 = 1;
                }
                else if ((this.gclass4_0.paymentMethod == 1) && (this.browserForm_0.int_0 == 0))
                {
                    new Thread(this.threadStart_1 ?? (this.threadStart_1 = new ThreadStart(this.method_2))).Start();
                    this.browserForm_0.int_0 = 1;
                }
            }
        }

        internal void method_1()
        {
            this.browserForm_0.method_2(this.gclass0_0);
        }

        internal void method_2()
        {
            this.browserForm_0.method_3(this.gclass0_0);
        }
    }
}

