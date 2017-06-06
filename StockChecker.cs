using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

public sealed class StockChecker : Form
{
    private Button autoButton;
    private CheckBox autoCartBox;
    private Label autoFailedLable;
    public bool bool_0;
    public bool bool_1;
    private CheckBox captchaBox;
    private Button checkButton;
    private CheckBox clothingBox;
    private ColorDialog colorDialog_0;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private Dictionary<int, string> dictionary_0;
    private Label forgotClothingLabel;
    public GClass1 gclass1_0;
    private IContainer icontainer_0;
    private CheckBox insaneBox;
    public int int_0;
    public int int_1;
    private NumericUpDown intervalSelector;
    private Label label1;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private NumericUpDown limit;
    private Label liveOrderableLabel;
    private Label liveStatusLabel;
    private ComboBox locationBox;
    public MainForm mainForm_0;
    private TextBox minBox;
    private Label orderLabel;
    private Panel panel1;
    private TextBox pidBox;
    private TextBox proxyBox;
    private TextBox proxyPWBox;
    private TextBox proxyUserBox;
    private CheckBox pushoverEnabledBox;
    private TextBox qtTxt;
    private NumericUpDown sizeLimit;
    private ListView sizeList;
    private TextBox slackUserBox;
    private Label slackUserLabel;
    private TextBox slackWebhookBox;
    private Label slackWebhookLabel;
    private Label statusLabel;
    public string string_0;
    public string string_1;
    public string string_10;
    public string string_2;
    public string string_3;
    public string string_4;
    public string string_5;
    public string string_6;
    public string string_7;
    public string string_8;
    public string string_9;
    private Button switchBtn;
    public Thread thread_0;

    public StockChecker()
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = string.Empty;
        this.string_7 = string.Empty;
        this.string_8 = string.Empty;
        this.string_10 = "Product-GetVariants?pid=";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/"
            },
            { 
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/nl_NL/"
            },
            { 
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/fr_FR/"
            },
            { 
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/es_ES/"
            },
            { 
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/it_IT/"
            },
            { 
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/"
            },
            { 
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/"
            },
            { 
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/"
            },
            { 
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/"
            },
            { 
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/"
            },
            { 
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/"
            },
            { 
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/"
            },
            { 
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/"
            },
            { 
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/"
            },
            { 
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/"
            },
            { 
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/"
            }
        };
        this.dictionary_0 = dictionary1;
        this.InitializeComponent();
    }

    public StockChecker(MainForm mainForm_1)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = string.Empty;
        this.string_7 = string.Empty;
        this.string_8 = string.Empty;
        this.string_10 = "Product-GetVariants?pid=";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/"
            },
            { 
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/nl_NL/"
            },
            { 
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/fr_FR/"
            },
            { 
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/es_ES/"
            },
            { 
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/it_IT/"
            },
            { 
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/"
            },
            { 
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/"
            },
            { 
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/"
            },
            { 
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/"
            },
            { 
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/"
            },
            { 
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/"
            },
            { 
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/"
            },
            { 
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/"
            },
            { 
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/"
            },
            { 
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/"
            },
            { 
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/"
            }
        };
        this.dictionary_0 = dictionary1;
        this.InitializeComponent();
        this.mainForm_0 = mainForm_1;
        this.locationBox.SelectedIndex = mainForm_1.int_2;
        this.bool_0 = true;
        this.panel1.Visible = false;
        this.statusLabel.Visible = false;
        this.liveStatusLabel.Visible = false;
        this.liveOrderableLabel.Visible = false;
        this.orderLabel.Visible = false;
    }

    public StockChecker(MainForm mainForm_1, int int_2, bool bool_2, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string string_17, string string_18, string string_19)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = string.Empty;
        this.string_7 = string.Empty;
        this.string_8 = string.Empty;
        this.string_10 = "Product-GetVariants?pid=";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/"
            },
            { 
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/nl_NL/"
            },
            { 
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/fr_FR/"
            },
            { 
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/es_ES/"
            },
            { 
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/it_IT/"
            },
            { 
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/"
            },
            { 
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/"
            },
            { 
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/"
            },
            { 
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/"
            },
            { 
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/"
            },
            { 
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/"
            },
            { 
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/"
            },
            { 
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/"
            },
            { 
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/"
            },
            { 
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/"
            },
            { 
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/"
            }
        };
        this.dictionary_0 = dictionary1;
        this.InitializeComponent();
        this.mainForm_0 = mainForm_1;
        this.string_9 = string_11.Replace(string_19, string.Empty);
        this.locationBox.SelectedIndex = int_2;
        this.switchBtn.Visible = true;
        if (!bool_2)
        {
            this.pushoverEnabledBox.Visible = false;
            this.autoCartBox.Visible = false;
            this.panel1.Visible = false;
        }
        this.string_0 = string_12.Replace(string_19, string.Empty);
        this.string_1 = string_13.Replace(string_19, string.Empty);
        this.string_2 = string_14.Replace(string_19, string.Empty);
        this.string_3 = string_15.Replace(string_19, string.Empty);
        this.string_4 = string_16.Replace(string_19, string.Empty);
        this.string_5 = string_17.Replace(string_19, string.Empty);
        this.string_6 = string_18.Replace(string_19, string.Empty);
        this.gclass1_0 = new GClass1(string_18.Replace(string_19, string.Empty));
    }

    public StockChecker(MainForm mainForm_1, int int_2, bool bool_2, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = string.Empty;
        this.string_7 = string.Empty;
        this.string_8 = string.Empty;
        this.string_10 = "Product-GetVariants?pid=";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/"
            },
            { 
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/nl_NL/"
            },
            { 
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/fr_FR/"
            },
            { 
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/es_ES/"
            },
            { 
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/it_IT/"
            },
            { 
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/"
            },
            { 
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/"
            },
            { 
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/"
            },
            { 
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/"
            },
            { 
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/"
            },
            { 
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/"
            },
            { 
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/"
            },
            { 
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/"
            },
            { 
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/"
            },
            { 
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/"
            },
            { 
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/"
            }
        };
        this.dictionary_0 = dictionary1;
        this.InitializeComponent();
        this.mainForm_0 = mainForm_1;
        this.string_9 = string_11.Replace(string_19, string.Empty);
        this.switchBtn.Visible = true;
        this.locationBox.SelectedIndex = int_2;
        if (!bool_2)
        {
            this.pushoverEnabledBox.Visible = false;
            this.autoCartBox.Visible = false;
            this.slackWebhookBox.Visible = true;
            this.slackWebhookLabel.Visible = true;
            this.panel1.Visible = false;
        }
        this.string_0 = string_12.Replace(string_19, string.Empty);
        this.string_1 = string_13.Replace(string_19, string.Empty);
        this.string_2 = string_14.Replace(string_19, string.Empty);
        this.string_3 = string_15.Replace(string_19, string.Empty);
        this.string_4 = string_16.Replace(string_19, string.Empty);
        this.string_5 = string_17.Replace(string_19, string.Empty);
        this.string_6 = string_18.Replace(string_19, string.Empty);
        this.string_7 = string_20.Replace(string_19, string.Empty);
        this.gclass1_0 = new GClass1(string_18.Replace(string_19, string.Empty));
    }

    private void autoButton_Click(object sender, EventArgs e)
    {
        if (this.bool_1)
        {
            this.bool_1 = false;
            this.autoButton.Text = "Enable Auto Update";
            this.checkButton.Enabled = true;
            this.pidBox.Enabled = true;
            this.locationBox.Enabled = true;
            this.clothingBox.Enabled = true;
            this.intervalSelector.Enabled = true;
            this.slackWebhookBox.Enabled = true;
            this.slackUserBox.Enabled = true;
            this.proxyUserBox.Enabled = true;
            this.proxyBox.Enabled = true;
            this.proxyPWBox.Enabled = true;
            this.limit.Enabled = true;
            this.sizeLimit.Enabled = true;
            this.captchaBox.Enabled = true;
            if ((this.thread_0 != null) && this.thread_0.IsAlive)
            {
                this.thread_0.Abort();
            }
        }
        else
        {
            Class63 class2 = new Class63 {
                stockChecker_0 = this
            };
            if (WebRequest.GetSystemWebProxy().GetProxy(new Uri("http://www.google.de")).Host.Equals("127.0.0.1"))
            {
                MessageBox.Show("yCopp detected a local proxy activated on your machine. This can lead to misbehaviour of the bot. Please open your internet options and deactivate your proxy and close any monitoring programs like Fiddler.");
                Application.Exit();
            }
            if (this.pidBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter a valid PID.");
            }
            else
            {
                if (this.pushoverEnabledBox.Checked)
                {
                    if (this.slackUserBox.Text.Equals(string.Empty))
                    {
                        MessageBox.Show("Please enter your Slack username.");
                        return;
                    }
                    this.string_8 = this.slackUserBox.Text;
                }
                this.bool_1 = true;
                this.autoButton.Text = "Disable Auto Update";
                this.checkButton.Enabled = false;
                this.pidBox.Enabled = false;
                this.locationBox.Enabled = false;
                this.clothingBox.Enabled = false;
                this.intervalSelector.Enabled = false;
                this.slackWebhookBox.Enabled = false;
                this.slackUserBox.Enabled = false;
                this.proxyUserBox.Enabled = false;
                this.proxyBox.Enabled = false;
                this.proxyPWBox.Enabled = false;
                this.limit.Enabled = false;
                this.sizeLimit.Enabled = false;
                this.captchaBox.Enabled = false;
                class2.string_0 = this.dictionary_0[this.locationBox.SelectedIndex] + this.string_9 + this.pidBox.Text;
                if (this.bool_0)
                {
                    class2.string_0 = this.dictionary_0[this.locationBox.SelectedIndex] + this.string_10 + this.pidBox.Text;
                }
                class2.int_0 = ((int) this.intervalSelector.Value) * 0x3e8;
                this.int_0 = (int) this.limit.Value;
                this.int_1 = (int) this.sizeLimit.Value;
                if (!this.slackWebhookBox.Text.Equals(string.Empty))
                {
                    this.gclass1_0 = new GClass1(this.slackWebhookBox.Text);
                }
                this.thread_0 = new Thread(new ThreadStart(class2.method_0));
                this.thread_0.IsBackground = true;
                this.thread_0.Start();
            }
        }
    }

    private void autoCartBox_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void checkButton_Click(object sender, EventArgs e)
    {
        if (WebRequest.GetSystemWebProxy().GetProxy(new Uri("http://www.google.de")).Host.Equals("127.0.0.1"))
        {
            MessageBox.Show("yCopp detected a local proxy activated on your machine. This can lead to misbehaviour of the bot. Please open your internet options and deactivate your proxy and close any monitoring programs like Fiddler.");
            Application.Exit();
        }
        if (this.pidBox.Equals(string.Empty))
        {
            MessageBox.Show("Please enter a valid PID.");
        }
        else if (this.bool_0)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(new UriBuilder(this.dictionary_0[this.locationBox.SelectedIndex] + this.string_10 + this.pidBox.Text).Uri);
            request.UnsafeAuthenticatedConnectionSharing = true;
            Class21.smethod_0(ref request, false);
            request.Method = "GET";
            request.Timeout = 0x1388;
            if (!this.proxyBox.Text.Equals(string.Empty))
            {
                request.Proxy = new WebProxy(this.proxyBox.Text);
            }
            if (!this.proxyUserBox.Text.Equals(string.Empty))
            {
                request.Proxy.Credentials = new NetworkCredential(this.proxyUserBox.Text, this.proxyPWBox.Text);
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
                string str2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                response.Close();
                if (str2.IndexOf("variations") == -1)
                {
                    MessageBox.Show("No stock loaded.");
                    this.sizeList.Items.Clear();
                }
                else
                {
                    this.sizeList.Items.Clear();
                    if (!this.clothingBox.Checked)
                    {
                        int result = 530;
                        if (!this.minBox.Text.Equals(string.Empty))
                        {
                            int.TryParse(this.minBox.Text, out result);
                        }
                        for (int i = result; i <= 730; i += 10)
                        {
                            int index = str2.IndexOf(this.pidBox.Text + "_" + i.ToString());
                            if (index != -1)
                            {
                                int num7 = str2.IndexOf("\"ATS\":", index);
                                int num22 = str2.IndexOf(',', num7 + 7);
                                string str3 = str2.Substring(num7 + 7, num22 - (num7 + 7));
                                int num8 = str2.IndexOf("\"size\":", index);
                                int num23 = str2.IndexOf('"', num8 + 10);
                                string str12 = str2.Substring(num8 + 10, num23 - (num8 + 10));
                                str3 = str3.Replace(".0", string.Empty);
                                if (str3.Equals("null"))
                                {
                                    str3 = "-";
                                }
                                string[] items = new string[] { str12, str3 };
                                this.sizeList.Items.Add(new ListViewItem(items));
                            }
                        }
                    }
                    else
                    {
                        for (int j = 290; j <= 390; j += 20)
                        {
                            int startIndex = str2.IndexOf(this.pidBox.Text + "_" + j.ToString());
                            if (startIndex != -1)
                            {
                                int num11 = str2.IndexOf("\"ATS\":", startIndex);
                                int num24 = str2.IndexOf(',', num11 + 7);
                                string str4 = str2.Substring(num11 + 7, num24 - (num11 + 7));
                                int num12 = str2.IndexOf("\"size\":", startIndex);
                                int num25 = str2.IndexOf('"', num12 + 10);
                                string str13 = str2.Substring(num12 + 10, num25 - (num12 + 10));
                                str4 = str4.Replace(".0", string.Empty);
                                if (str4.Equals("null"))
                                {
                                    str4 = "-";
                                }
                                string[] strArray2 = new string[] { str13, str4 };
                                this.sizeList.Items.Add(new ListViewItem(strArray2));
                            }
                        }
                    }
                    if (this.sizeList.Items.Count == 0)
                    {
                        MessageBox.Show("Stock loaded, but couldn't parse stock count. Did you forget to check / uncheck 'Is Clothing' ?");
                        this.orderLabel.Visible = false;
                        this.liveOrderableLabel.Visible = false;
                        this.liveStatusLabel.Visible = false;
                        this.statusLabel.Visible = false;
                    }
                }
            }
            catch (WebException)
            {
                this.orderLabel.Visible = false;
                this.liveOrderableLabel.Visible = false;
                this.liveStatusLabel.Visible = false;
                this.statusLabel.Visible = false;
                MessageBox.Show("Error while checking stock.");
                if (response != null)
                {
                    response.Close();
                }
            }
        }
        else
        {
            HttpWebRequest request2 = (HttpWebRequest) WebRequest.Create(new UriBuilder(this.dictionary_0[this.locationBox.SelectedIndex] + this.string_9 + this.pidBox.Text).Uri);
            request2.UnsafeAuthenticatedConnectionSharing = true;
            Class21.smethod_0(ref request2, false);
            request2.Method = "GET";
            request2.Timeout = 0x1388;
            if (!this.proxyBox.Text.Equals(string.Empty))
            {
                request2.Proxy = new WebProxy(this.proxyBox.Text);
            }
            if (!this.proxyUserBox.Text.Equals(string.Empty))
            {
                request2.Proxy.Credentials = new NetworkCredential(this.proxyUserBox.Text, this.proxyPWBox.Text);
            }
            HttpWebResponse response2 = null;
            try
            {
                response2 = (HttpWebResponse) request2.GetResponse();
                string str = new StreamReader(response2.GetResponseStream()).ReadToEnd();
                response2.Close();
                if (str.IndexOf("sku") == -1)
                {
                    MessageBox.Show("No stock loaded.");
                    this.sizeList.Items.Clear();
                }
                else
                {
                    this.sizeList.Items.Clear();
                    bool flag = false;
                    bool flag2 = false;
                    string str7 = string.Empty;
                    if (!this.clothingBox.Checked)
                    {
                        int num26 = 530;
                        if (!this.minBox.Text.Equals(string.Empty))
                        {
                            int.TryParse(this.minBox.Text, out num26);
                        }
                        for (int k = num26; k <= 730; k += 10)
                        {
                            int num = str.IndexOf(this.pidBox.Text + "_" + k.ToString());
                            if (num != -1)
                            {
                                int num13 = str.IndexOf(this.string_0, num);
                                int num27 = str.IndexOf('"', num13 + 0x16);
                                string str5 = str.Substring(num13 + 0x16, num27 - (num13 + 0x16));
                                int num14 = str.IndexOf(this.string_1, num);
                                int num28 = str.IndexOf('"', num14 + 0x10);
                                string str14 = str.Substring(num14 + 0x10, num28 - (num14 + 0x10));
                                int num15 = str.IndexOf(this.string_2, num);
                                int num29 = str.IndexOf('"', num15 + 14);
                                string str8 = str.Substring(num15 + 14, num29 - (num15 + 14));
                                if (str8.Equals("true"))
                                {
                                    flag = true;
                                }
                                int num16 = str.IndexOf(this.string_3, num);
                                int num30 = str.IndexOf('"', num16 + 11);
                                string str9 = str.Substring(num16 + 11, num30 - (num16 + 11));
                                if (str9.Equals(e))
                                {
                                    flag2 = true;
                                }
                                if (k == 640)
                                {
                                    str7 = str9;
                                }
                                if (str5.Replace(this.string_5, string.Empty).Equals("null"))
                                {
                                    str5 = "-";
                                }
                                string[] strArray3 = new string[] { str14, str8 };
                                this.sizeList.Items.Add(new ListViewItem(strArray3));
                            }
                        }
                    }
                    else
                    {
                        for (int m = 290; m <= 390; m += 20)
                        {
                            int num2 = str.IndexOf(this.pidBox.Text + "_" + m.ToString());
                            if (num2 != -1)
                            {
                                int num17 = str.IndexOf(this.string_0, num2);
                                int num31 = str.IndexOf('"', num17 + 0x16);
                                string str6 = str.Substring(num17 + 0x16, num31 - (num17 + 0x16));
                                int num18 = str.IndexOf(this.string_1, num2);
                                int num32 = str.IndexOf('"', num18 + 0x10);
                                string str15 = str.Substring(num18 + 0x10, num32 - (num18 + 0x10));
                                int num19 = str.IndexOf(this.string_2, num2);
                                int num33 = str.IndexOf('"', num19 + 14);
                                string str10 = str.Substring(num19 + 14, num33 - (num19 + 14));
                                if (str10.Equals("true"))
                                {
                                    flag = true;
                                }
                                int num20 = str.IndexOf(this.string_3, num2);
                                int num34 = str.IndexOf('"', num20 + 11);
                                string str11 = str.Substring(num20 + 11, num34 - (num20 + 11));
                                if (str11.Equals(e))
                                {
                                    flag2 = true;
                                }
                                if (m == 350)
                                {
                                    str7 = str11;
                                }
                                if (str6.Replace(this.string_5, string.Empty).Equals("null"))
                                {
                                    str6 = "-";
                                }
                                string[] strArray4 = new string[] { str15, str10 };
                                this.sizeList.Items.Add(new ListViewItem(strArray4));
                            }
                        }
                    }
                    if (flag)
                    {
                        this.orderLabel.Visible = true;
                        this.liveOrderableLabel.Visible = true;
                        this.liveOrderableLabel.Text = "TRUE";
                        this.liveOrderableLabel.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        this.orderLabel.Visible = true;
                        this.liveOrderableLabel.Visible = true;
                        this.liveOrderableLabel.Text = "FALSE";
                        this.liveOrderableLabel.ForeColor = Color.Red;
                    }
                    if (flag2)
                    {
                        this.statusLabel.Visible = true;
                        this.liveStatusLabel.Visible = true;
                        this.liveStatusLabel.Text = "IN STOCK";
                        this.liveStatusLabel.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        this.statusLabel.Visible = true;
                        this.liveStatusLabel.Visible = true;
                        this.liveStatusLabel.Text = str7;
                        this.liveStatusLabel.ForeColor = Color.Red;
                    }
                    if (this.sizeList.Items.Count == 0)
                    {
                        MessageBox.Show("Stock loaded, but couldn't parse stock count. Did you forget to check / uncheck 'Is Clothing' ?");
                        this.orderLabel.Visible = false;
                        this.liveOrderableLabel.Visible = false;
                        this.liveStatusLabel.Visible = false;
                        this.statusLabel.Visible = false;
                    }
                }
            }
            catch (WebException)
            {
                this.orderLabel.Visible = false;
                this.liveOrderableLabel.Visible = false;
                this.liveStatusLabel.Visible = false;
                this.statusLabel.Visible = false;
                MessageBox.Show("Error while checking stock.");
                if (response2 != null)
                {
                    response2.Close();
                }
            }
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(StockChecker));
        this.label1 = new Label();
        this.label2 = new Label();
        this.checkButton = new Button();
        this.pidBox = new TextBox();
        this.locationBox = new ComboBox();
        this.sizeList = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.clothingBox = new CheckBox();
        this.label3 = new Label();
        this.autoButton = new Button();
        this.label4 = new Label();
        this.intervalSelector = new NumericUpDown();
        this.label5 = new Label();
        this.orderLabel = new Label();
        this.statusLabel = new Label();
        this.liveStatusLabel = new Label();
        this.liveOrderableLabel = new Label();
        this.autoFailedLable = new Label();
        this.pushoverEnabledBox = new CheckBox();
        this.autoCartBox = new CheckBox();
        this.insaneBox = new CheckBox();
        this.forgotClothingLabel = new Label();
        this.slackUserBox = new TextBox();
        this.slackUserLabel = new Label();
        this.slackWebhookBox = new TextBox();
        this.slackWebhookLabel = new Label();
        this.label6 = new Label();
        this.proxyBox = new TextBox();
        this.label7 = new Label();
        this.proxyUserBox = new TextBox();
        this.label8 = new Label();
        this.proxyPWBox = new TextBox();
        this.colorDialog_0 = new ColorDialog();
        this.label9 = new Label();
        this.label10 = new Label();
        this.limit = new NumericUpDown();
        this.sizeLimit = new NumericUpDown();
        this.captchaBox = new CheckBox();
        this.panel1 = new Panel();
        this.label12 = new Label();
        this.qtTxt = new TextBox();
        this.label11 = new Label();
        this.minBox = new TextBox();
        this.switchBtn = new Button();
        this.intervalSelector.BeginInit();
        this.limit.BeginInit();
        this.sizeLimit.BeginInit();
        this.panel1.SuspendLayout();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x10, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x1c, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "PID:";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x10, 0x25);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x33, 13);
        this.label2.TabIndex = 1;
        this.label2.Text = "Location:";
        this.checkButton.Location = new Point(0xb6, 6);
        this.checkButton.Name = "checkButton";
        this.checkButton.Size = new Size(150, 40);
        this.checkButton.TabIndex = 2;
        this.checkButton.Text = "Check Stock";
        this.checkButton.UseVisualStyleBackColor = true;
        this.checkButton.Click += new EventHandler(this.checkButton_Click);
        this.pidBox.Location = new Point(0x51, 6);
        this.pidBox.Name = "pidBox";
        this.pidBox.Size = new Size(0x5f, 20);
        this.pidBox.TabIndex = 3;
        this.locationBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.locationBox.FormattingEnabled = true;
        object[] items = new object[] { 
            "Germany", "Netherlands", "France", "Spain", "Italy", "United Kingdom", "United States", "Canada", "Australia", "Austria", "Belgium", "Sweden", "Denmark", "Norway", "Poland", "Czech Republic",
            "New Zealand"
        };
        this.locationBox.Items.AddRange(items);
        this.locationBox.Location = new Point(0x51, 0x20);
        this.locationBox.Name = "locationBox";
        this.locationBox.Size = new Size(0x5f, 0x15);
        this.locationBox.TabIndex = 4;
        ColumnHeader[] values = new ColumnHeader[] { this.columnHeader_0, this.columnHeader_1 };
        this.sizeList.Columns.AddRange(values);
        this.sizeList.Location = new Point(0x13, 0x61);
        this.sizeList.Name = "sizeList";
        this.sizeList.Size = new Size(0x87, 0x162);
        this.sizeList.TabIndex = 5;
        this.sizeList.UseCompatibleStateImageBehavior = false;
        this.sizeList.SelectedIndexChanged += new EventHandler(this.sizeList_SelectedIndexChanged);
        this.columnHeader_0.Text = "Size";
        this.columnHeader_1.Text = "Quantity";
        this.clothingBox.AutoSize = true;
        this.clothingBox.Location = new Point(0x51, 0x45);
        this.clothingBox.Name = "clothingBox";
        this.clothingBox.RightToLeft = RightToLeft.Yes;
        this.clothingBox.Size = new Size(15, 14);
        this.clothingBox.TabIndex = 6;
        this.clothingBox.UseVisualStyleBackColor = true;
        this.label3.AutoSize = true;
        this.label3.Location = new Point(0x10, 0x45);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x3b, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Is Clothing:";
        this.autoButton.Location = new Point(0xb6, 0x34);
        this.autoButton.Name = "autoButton";
        this.autoButton.Size = new Size(150, 40);
        this.autoButton.TabIndex = 8;
        this.autoButton.Text = "Enable Auto Update";
        this.autoButton.UseVisualStyleBackColor = true;
        this.autoButton.Click += new EventHandler(this.autoButton_Click);
        this.label4.AutoSize = true;
        this.label4.Location = new Point(160, 0x6a);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x53, 13);
        this.label4.TabIndex = 9;
        this.label4.Text = "Update Interval:";
        this.intervalSelector.Location = new Point(0xf9, 0x68);
        this.intervalSelector.Name = "intervalSelector";
        this.intervalSelector.Size = new Size(0x26, 20);
        this.intervalSelector.TabIndex = 10;
        int[] bits = new int[4];
        bits[0] = 5;
        this.intervalSelector.Value = new decimal(bits);
        this.intervalSelector.ValueChanged += new EventHandler(this.intervalSelector_ValueChanged);
        this.label5.AutoSize = true;
        this.label5.Location = new Point(0x125, 0x6a);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0x35, 13);
        this.label5.TabIndex = 11;
        this.label5.Text = "second(s)";
        this.orderLabel.AutoSize = true;
        this.orderLabel.Location = new Point(0xa4, 0x175);
        this.orderLabel.Name = "orderLabel";
        this.orderLabel.Size = new Size(0x38, 13);
        this.orderLabel.TabIndex = 12;
        this.orderLabel.Text = "Orderable:";
        this.orderLabel.Visible = false;
        this.statusLabel.AutoSize = true;
        this.statusLabel.Location = new Point(0xa4, 0x15f);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(40, 13);
        this.statusLabel.TabIndex = 13;
        this.statusLabel.Text = "Status:";
        this.statusLabel.Visible = false;
        this.liveStatusLabel.AutoSize = true;
        this.liveStatusLabel.Location = new Point(0xe2, 0x15f);
        this.liveStatusLabel.Name = "liveStatusLabel";
        this.liveStatusLabel.Size = new Size(40, 13);
        this.liveStatusLabel.TabIndex = 14;
        this.liveStatusLabel.Text = "Status:";
        this.liveStatusLabel.Visible = false;
        this.liveOrderableLabel.AutoSize = true;
        this.liveOrderableLabel.Location = new Point(0xe2, 0x175);
        this.liveOrderableLabel.Name = "liveOrderableLabel";
        this.liveOrderableLabel.Size = new Size(0x38, 13);
        this.liveOrderableLabel.TabIndex = 15;
        this.liveOrderableLabel.Text = "Orderable:";
        this.liveOrderableLabel.Visible = false;
        this.autoFailedLable.AutoSize = true;
        this.autoFailedLable.ForeColor = Color.Red;
        this.autoFailedLable.Location = new Point(0xc0, 0x18e);
        this.autoFailedLable.Name = "autoFailedLable";
        this.autoFailedLable.Size = new Size(0x79, 13);
        this.autoFailedLable.TabIndex = 0x10;
        this.autoFailedLable.Text = "Last Auto Update failed!";
        this.autoFailedLable.Visible = false;
        this.pushoverEnabledBox.AutoSize = true;
        this.pushoverEnabledBox.Location = new Point(7, 0x54);
        this.pushoverEnabledBox.Name = "pushoverEnabledBox";
        this.pushoverEnabledBox.Size = new Size(0x6a, 0x11);
        this.pushoverEnabledBox.TabIndex = 0x13;
        this.pushoverEnabledBox.Text = "Notify on restock";
        this.pushoverEnabledBox.UseVisualStyleBackColor = true;
        this.autoCartBox.AutoSize = true;
        this.autoCartBox.Location = new Point(0x71, 0x3d);
        this.autoCartBox.Name = "autoCartBox";
        this.autoCartBox.Size = new Size(70, 0x11);
        this.autoCartBox.TabIndex = 20;
        this.autoCartBox.Text = "Auto Cart";
        this.autoCartBox.UseVisualStyleBackColor = true;
        this.autoCartBox.CheckedChanged += new EventHandler(this.autoCartBox_CheckedChanged);
        this.insaneBox.AutoSize = true;
        this.insaneBox.Location = new Point(7, 0x3d);
        this.insaneBox.Name = "insaneBox";
        this.insaneBox.Size = new Size(0x58, 0x11);
        this.insaneBox.TabIndex = 0x15;
        this.insaneBox.Text = "Insane Mode";
        this.insaneBox.UseVisualStyleBackColor = true;
        this.forgotClothingLabel.AutoSize = true;
        this.forgotClothingLabel.ForeColor = Color.Red;
        this.forgotClothingLabel.Location = new Point(0x9f, 0x19b);
        this.forgotClothingLabel.Name = "forgotClothingLabel";
        this.forgotClothingLabel.Size = new Size(0xc6, 13);
        this.forgotClothingLabel.TabIndex = 0x16;
        this.forgotClothingLabel.Text = "Did you forget to (un)check 'Is Clothing'?";
        this.forgotClothingLabel.Visible = false;
        this.slackUserBox.Location = new Point(0x5d, 0x6b);
        this.slackUserBox.Name = "slackUserBox";
        this.slackUserBox.Size = new Size(100, 20);
        this.slackUserBox.TabIndex = 0x17;
        this.slackUserLabel.AutoSize = true;
        this.slackUserLabel.Location = new Point(4, 110);
        this.slackUserLabel.Name = "slackUserLabel";
        this.slackUserLabel.Size = new Size(0x58, 13);
        this.slackUserLabel.TabIndex = 0x18;
        this.slackUserLabel.Text = "Slack Username:";
        this.slackWebhookBox.Location = new Point(0x5d, 0x84);
        this.slackWebhookBox.Name = "slackWebhookBox";
        this.slackWebhookBox.Size = new Size(100, 20);
        this.slackWebhookBox.TabIndex = 0x19;
        this.slackWebhookLabel.AutoSize = true;
        this.slackWebhookLabel.Location = new Point(5, 0x87);
        this.slackWebhookLabel.Name = "slackWebhookLabel";
        this.slackWebhookLabel.Size = new Size(0x57, 13);
        this.slackWebhookLabel.TabIndex = 0x1a;
        this.slackWebhookLabel.Text = "Slack Webhook:";
        this.label6.AutoSize = true;
        this.label6.Location = new Point(0xa2, 0x84);
        this.label6.Name = "label6";
        this.label6.Size = new Size(0x24, 13);
        this.label6.TabIndex = 0x1b;
        this.label6.Text = "Proxy:";
        this.proxyBox.Location = new Point(0xcc, 130);
        this.proxyBox.Name = "proxyBox";
        this.proxyBox.Size = new Size(0x92, 20);
        this.proxyBox.TabIndex = 0x1c;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(0xa2, 0x9b);
        this.label7.Name = "label7";
        this.label7.Size = new Size(0x24, 13);
        this.label7.TabIndex = 0x1d;
        this.label7.Text = "Login:";
        this.proxyUserBox.Location = new Point(0xcc, 0x98);
        this.proxyUserBox.Name = "proxyUserBox";
        this.proxyUserBox.Size = new Size(0x42, 20);
        this.proxyUserBox.TabIndex = 30;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(0x110, 0x9c);
        this.label8.Name = "label8";
        this.label8.Size = new Size(10, 13);
        this.label8.TabIndex = 0x1f;
        this.label8.Text = ":";
        this.proxyPWBox.Location = new Point(0x11b, 0x98);
        this.proxyPWBox.Name = "proxyPWBox";
        this.proxyPWBox.Size = new Size(0x43, 20);
        this.proxyPWBox.TabIndex = 0x20;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(0xad, 0x1b6);
        this.label9.Name = "label9";
        this.label9.Size = new Size(0x1f, 13);
        this.label9.TabIndex = 0x21;
        this.label9.Text = "Limit:";
        this.label9.Visible = false;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(0xae, 0x1cf);
        this.label10.Name = "label10";
        this.label10.Size = new Size(0x31, 13);
        this.label10.TabIndex = 0x22;
        this.label10.Text = "Per Size:";
        this.label10.Visible = false;
        this.limit.Location = new Point(0xe2, 0x1b2);
        this.limit.Name = "limit";
        this.limit.Size = new Size(50, 20);
        this.limit.TabIndex = 0x23;
        int[] numArray2 = new int[4];
        numArray2[0] = 15;
        this.limit.Value = new decimal(numArray2);
        this.limit.Visible = false;
        this.sizeLimit.Location = new Point(0xe2, 0x1cd);
        this.sizeLimit.Name = "sizeLimit";
        this.sizeLimit.Size = new Size(50, 20);
        this.sizeLimit.TabIndex = 0x24;
        int[] numArray3 = new int[4];
        numArray3[0] = 5;
        this.sizeLimit.Value = new decimal(numArray3);
        this.sizeLimit.Visible = false;
        this.captchaBox.AutoSize = true;
        this.captchaBox.Location = new Point(0x71, 0x54);
        this.captchaBox.Name = "captchaBox";
        this.captchaBox.Size = new Size(0x42, 0x11);
        this.captchaBox.TabIndex = 0x25;
        this.captchaBox.Text = "Captcha";
        this.captchaBox.UseVisualStyleBackColor = true;
        this.panel1.Controls.Add(this.label12);
        this.panel1.Controls.Add(this.qtTxt);
        this.panel1.Controls.Add(this.captchaBox);
        this.panel1.Controls.Add(this.pushoverEnabledBox);
        this.panel1.Controls.Add(this.autoCartBox);
        this.panel1.Controls.Add(this.insaneBox);
        this.panel1.Controls.Add(this.slackUserBox);
        this.panel1.Controls.Add(this.slackUserLabel);
        this.panel1.Controls.Add(this.slackWebhookBox);
        this.panel1.Controls.Add(this.slackWebhookLabel);
        this.panel1.Location = new Point(160, 0xb1);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(200, 0xab);
        this.panel1.TabIndex = 0x26;
        this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
        this.label12.AutoSize = true;
        this.label12.Location = new Point(8, 0x1a);
        this.label12.Name = "label12";
        this.label12.Size = new Size(0x44, 13);
        this.label12.TabIndex = 0x27;
        this.label12.Text = "Auto Cart Qt:";
        this.qtTxt.Location = new Point(0x53, 0x17);
        this.qtTxt.Name = "qtTxt";
        this.qtTxt.Size = new Size(100, 20);
        this.qtTxt.TabIndex = 0x26;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(0x120, 450);
        this.label11.Name = "label11";
        this.label11.Size = new Size(0x1b, 13);
        this.label11.TabIndex = 0x27;
        this.label11.Text = "Min:";
        this.label11.Visible = false;
        this.minBox.Location = new Point(0x141, 0x1bf);
        this.minBox.Name = "minBox";
        this.minBox.Size = new Size(0x26, 20);
        this.minBox.TabIndex = 0x26;
        this.minBox.Visible = false;
        this.switchBtn.Location = new Point(0xa3, 0x1af);
        this.switchBtn.Name = "switchBtn";
        this.switchBtn.Size = new Size(0xa9, 0x17);
        this.switchBtn.TabIndex = 40;
        this.switchBtn.Text = "Switch to normal";
        this.switchBtn.UseVisualStyleBackColor = true;
        this.switchBtn.Visible = false;
        this.switchBtn.Click += new EventHandler(this.switchBtn_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        base.ClientSize = new Size(0x166, 0x1cf);
        base.Controls.Add(this.switchBtn);
        base.Controls.Add(this.label11);
        base.Controls.Add(this.panel1);
        base.Controls.Add(this.minBox);
        base.Controls.Add(this.proxyPWBox);
        base.Controls.Add(this.label9);
        base.Controls.Add(this.label8);
        base.Controls.Add(this.proxyUserBox);
        base.Controls.Add(this.sizeLimit);
        base.Controls.Add(this.label7);
        base.Controls.Add(this.proxyBox);
        base.Controls.Add(this.limit);
        base.Controls.Add(this.label6);
        base.Controls.Add(this.forgotClothingLabel);
        base.Controls.Add(this.label10);
        base.Controls.Add(this.autoFailedLable);
        base.Controls.Add(this.liveOrderableLabel);
        base.Controls.Add(this.liveStatusLabel);
        base.Controls.Add(this.statusLabel);
        base.Controls.Add(this.orderLabel);
        base.Controls.Add(this.label5);
        base.Controls.Add(this.intervalSelector);
        base.Controls.Add(this.label4);
        base.Controls.Add(this.autoButton);
        base.Controls.Add(this.label3);
        base.Controls.Add(this.clothingBox);
        base.Controls.Add(this.sizeList);
        base.Controls.Add(this.locationBox);
        base.Controls.Add(this.pidBox);
        base.Controls.Add(this.checkButton);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.label1);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "StockChecker";
        this.Text = "Stock Checker";
        base.FormClosing += new FormClosingEventHandler(this.StockChecker_FormClosing);
        base.Load += new EventHandler(this.StockChecker_Load);
        this.intervalSelector.EndInit();
        this.limit.EndInit();
        this.sizeLimit.EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void intervalSelector_ValueChanged(object sender, EventArgs e)
    {
        if (this.intervalSelector.Value < decimal.One)
        {
            this.intervalSelector.Value = decimal.One;
        }
        if (this.intervalSelector.Value > 300M)
        {
            this.intervalSelector.Value = 300M;
        }
    }

    public void method_0(string string_11, int int_2)
    {
        Class62 class5 = new Class62 {
            stockChecker_0 = this,
            bool_0 = false
        };
        new Dictionary<int, int>();
        Dictionary<int, int> source = new Dictionary<int, int>();
    Label_0024:
        if (!this.mainForm_0.bool_0 && WebRequest.GetSystemWebProxy().GetProxy(new Uri("http://www.google.de")).Host.Equals("127.0.0.1"))
        {
            base.Invoke(new MethodInvoker(this.method_3));
        }
        if (this.bool_0)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(new UriBuilder(string_11).Uri);
            request.UnsafeAuthenticatedConnectionSharing = true;
            Class21.smethod_0(ref request, false);
            request.Method = "GET";
            request.Timeout = 0x1388;
            if (!this.proxyBox.Text.Equals(string.Empty))
            {
                request.Proxy = new WebProxy(this.proxyBox.Text);
            }
            if (!this.proxyUserBox.Text.Equals(string.Empty))
            {
                request.Proxy.Credentials = new NetworkCredential(this.proxyUserBox.Text, this.proxyPWBox.Text);
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
                string str2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                response.Close();
                if (str2.IndexOf("variations") == -1)
                {
                    MessageBox.Show("No stock loaded.");
                    base.Invoke(new MethodInvoker(this.method_4));
                    return;
                }
                base.Invoke(new MethodInvoker(this.method_5));
                if (!this.clothingBox.Checked)
                {
                    int result = 530;
                    if (!this.minBox.Text.Equals(string.Empty))
                    {
                        int.TryParse(this.minBox.Text, out result);
                    }
                    for (int i = result; i <= 730; i += 10)
                    {
                        Class65 class6 = new Class65 {
                            class62_0 = class5
                        };
                        int index = str2.IndexOf(this.pidBox.Text + "_" + i.ToString());
                        if (index != -1)
                        {
                            int num7 = str2.IndexOf("\"ATS\":", index);
                            int num22 = str2.IndexOf(',', num7 + 7);
                            string str5 = str2.Substring(num7 + 7, num22 - (num7 + 7));
                            int num8 = str2.IndexOf("\"size\":", index);
                            int num23 = str2.IndexOf('"', num8 + 10);
                            string str9 = str2.Substring(num8 + 10, num23 - (num8 + 10));
                            str5 = str5.Replace(".0", string.Empty);
                            if (str5.Equals("null"))
                            {
                                str5 = "-";
                            }
                            class6.string_0 = new string[] { str9, str5 };
                            base.Invoke(new MethodInvoker(class6.method_0));
                        }
                    }
                }
                else
                {
                    for (int j = 290; j <= 390; j += 20)
                    {
                        Class67 class7 = new Class67 {
                            class62_0 = class5
                        };
                        int startIndex = str2.IndexOf(this.pidBox.Text + "_" + j.ToString());
                        if (startIndex != -1)
                        {
                            int num11 = str2.IndexOf("\"ATS\":", startIndex);
                            int num24 = str2.IndexOf(',', num11 + 7);
                            string str6 = str2.Substring(num11 + 7, num24 - (num11 + 7));
                            int num12 = str2.IndexOf("\"size\":", startIndex);
                            int num25 = str2.IndexOf('"', num12 + 10);
                            string str10 = str2.Substring(num12 + 10, num25 - (num12 + 10));
                            str6 = str6.Replace(".0", string.Empty);
                            if (str6.Equals("null"))
                            {
                                str6 = "-";
                            }
                            class7.string_0 = new string[] { str10, str6 };
                            base.Invoke(new MethodInvoker(class7.method_0));
                        }
                    }
                }
                if (this.sizeList.Items.Count == 0)
                {
                    base.Invoke(new MethodInvoker(this.method_6));
                }
                goto Label_0AA1;
            }
            catch (WebException)
            {
                base.Invoke(new MethodInvoker(this.method_7));
                if (response != null)
                {
                    response.Close();
                }
                return;
            }
        }
        Class69 class2 = new Class69 {
            class62_0 = class5
        };
        HttpWebRequest request2 = (HttpWebRequest) WebRequest.Create(new UriBuilder(string_11).Uri);
        Class21.smethod_0(ref request2, false);
        request2.Method = "GET";
        request2.Timeout = 0xfa0;
        if (!this.proxyBox.Text.Equals(string.Empty))
        {
            request2.Proxy = new WebProxy(this.proxyBox.Text);
        }
        if (!this.proxyUserBox.Text.Equals(string.Empty))
        {
            request2.Proxy.Credentials = new NetworkCredential(this.proxyUserBox.Text, this.proxyPWBox.Text);
        }
        class2.bool_0 = false;
        class2.bool_1 = false;
        class2.string_0 = string.Empty;
        class2.int_0 = 0;
        HttpWebResponse response2 = null;
        try
        {
            response2 = (HttpWebResponse) request2.GetResponse();
            string str = new StreamReader(response2.GetResponseStream()).ReadToEnd();
            response2.Close();
            base.Invoke(new MethodInvoker(this.method_8));
            class2.bool_0 = false;
            class2.bool_1 = false;
            class2.string_0 = string.Empty;
            class2.int_0 = 0;
            source.ToDictionary<KeyValuePair<int, int>, int, int>(Class61.func_0 ?? (Class61.func_0 = new Func<KeyValuePair<int, int>, int>(Class61.class61_0, (IntPtr) this.method_0)), Class61.func_1 ?? (Class61.func_1 = new Func<KeyValuePair<int, int>, int>(Class61.class61_0, (IntPtr) this.method_1)));
            source.Clear();
            if (!this.clothingBox.Checked)
            {
                int num26 = 530;
                if (!this.minBox.Text.Equals(string.Empty))
                {
                    int.TryParse(this.minBox.Text, out num26);
                }
                for (int k = num26; k <= 730; k += 10)
                {
                    Class66 class3 = new Class66 {
                        class69_0 = class2
                    };
                    int num2 = str.IndexOf(this.pidBox.Text + "_" + k.ToString());
                    if (num2 != -1)
                    {
                        int num13 = str.IndexOf(this.string_0, num2);
                        int num27 = str.IndexOf('"', num13 + 0x16);
                        string s = str.Substring(num13 + 0x16, num27 - (num13 + 0x16)).Replace(this.string_5, string.Empty);
                        int num14 = str.IndexOf(this.string_1, num2);
                        int num28 = str.IndexOf('"', num14 + 0x10);
                        string str11 = str.Substring(num14 + 0x10, num28 - (num14 + 0x10));
                        int num15 = str.IndexOf(this.string_2, num2);
                        int num29 = str.IndexOf('"', num15 + 14);
                        if (str.Substring(num15 + 14, num29 - (num15 + 14)).Equals("true"))
                        {
                            class3.class69_0.bool_0 = true;
                            if (this.autoCartBox.Checked)
                            {
                                int num35;
                                source.Add(k, int.TryParse(this.qtTxt.Text, out num35) ? num35 : 0);
                            }
                        }
                        int num16 = str.IndexOf(this.string_3, num2);
                        int num30 = str.IndexOf('"', num16 + 11);
                        string str7 = str.Substring(num16 + 11, num30 - (num16 + 11));
                        if (str7.Equals(this.string_4))
                        {
                            class3.class69_0.bool_1 = true;
                        }
                        if (k == 640)
                        {
                            class3.class69_0.string_0 = str7;
                        }
                        if (s.Equals("null"))
                        {
                            s = "-";
                        }
                        else
                        {
                            class3.class69_0.int_0 += int.Parse(s);
                        }
                        class3.string_0 = new string[] { str11, s };
                        base.Invoke(new MethodInvoker(class3.method_0));
                    }
                }
            }
            else
            {
                for (int m = 290; m <= 390; m += 20)
                {
                    Class68 class4 = new Class68 {
                        class69_0 = class2
                    };
                    int num4 = str.IndexOf(this.pidBox.Text + "_" + m.ToString());
                    if (num4 != -1)
                    {
                        int num17 = str.IndexOf(this.string_0, num4);
                        int num31 = str.IndexOf('"', num17 + 0x16);
                        string str4 = str.Substring(num17 + 0x16, num31 - (num17 + 0x16)).Replace(this.string_5, string.Empty);
                        int num18 = str.IndexOf(this.string_1, num4);
                        int num32 = str.IndexOf('"', num18 + 0x10);
                        string str12 = str.Substring(num18 + 0x10, num32 - (num18 + 0x10));
                        int num19 = str.IndexOf(this.string_2, num4);
                        int num33 = str.IndexOf('"', num19 + 14);
                        if (str.Substring(num19 + 14, num33 - (num19 + 14)).Equals("true"))
                        {
                            class4.class69_0.bool_0 = true;
                            if (this.autoCartBox.Checked)
                            {
                                int num36;
                                source.Add(m, int.TryParse(this.qtTxt.Text, out num36) ? num36 : 0);
                            }
                        }
                        int num20 = str.IndexOf(this.string_3, num4);
                        int num34 = str.IndexOf('"', num20 + 11);
                        string str8 = str.Substring(num20 + 11, num34 - (num20 + 11));
                        if (str8.Equals(this.string_4))
                        {
                            class4.class69_0.bool_1 = true;
                        }
                        if (m == 350)
                        {
                            class4.class69_0.string_0 = str8;
                        }
                        if (str4.Equals("null"))
                        {
                            str4 = "-";
                        }
                        else
                        {
                            class4.class69_0.int_0 += int.Parse(str4);
                        }
                        class4.string_0 = new string[] { str12, str4 };
                        base.Invoke(new MethodInvoker(class4.method_0));
                    }
                }
            }
            if (this.autoCartBox.Checked && (source.Count > 0))
            {
                string[] strArray = this.mainForm_0.method_46();
                this.method_2(source, strArray);
            }
            base.Invoke(new MethodInvoker(class2.method_0));
        }
        catch (WebException)
        {
            base.Invoke(new MethodInvoker(this.method_9));
            if (response2 != null)
            {
                response2.Close();
            }
        }
    Label_0AA1:
        if (!this.insaneBox.Checked)
        {
            Thread.Sleep(int_2);
        }
        goto Label_0024;
    }

    private void method_1(int int_2)
    {
        this.gclass1_0.method_0("RESTOCK: " + this.pidBox.Text + ", Total pairs: " + int_2.ToString(), "yCopp Restock Bot", this.string_8);
    }

    private void method_2(Dictionary<int, int> dictionary_1, string[] string_11)
    {
        Class64 class2 = new Class64 {
            stockChecker_0 = this,
            dictionary_0 = dictionary_1,
            string_0 = string_11
        };
        base.Invoke(new MethodInvoker(class2.method_0));
    }

    private void method_3()
    {
        MessageBox.Show(this, "yCopp detected a local proxy activated on your machine. This can lead to misbehaviour of the bot. Please open your internet options and deactivate your proxy and close any monitoring programs like Fiddler.");
        base.Close();
    }

    private void method_4()
    {
        this.sizeList.Items.Clear();
    }

    private void method_5()
    {
        this.sizeList.Items.Clear();
    }

    private void method_6()
    {
        this.orderLabel.Visible = false;
        this.liveOrderableLabel.Visible = false;
        this.liveStatusLabel.Visible = false;
        this.statusLabel.Visible = false;
        MessageBox.Show("Stock loaded, but couldn't parse stock count. Did you forget to check / uncheck 'Is Clothing' ?");
    }

    private void method_7()
    {
        this.orderLabel.Visible = false;
        this.liveOrderableLabel.Visible = false;
        this.liveStatusLabel.Visible = false;
        this.statusLabel.Visible = false;
        MessageBox.Show("Error while checking stock.");
    }

    private void method_8()
    {
        this.sizeList.Items.Clear();
    }

    private void method_9()
    {
        this.orderLabel.Visible = false;
        this.liveOrderableLabel.Visible = false;
        this.liveStatusLabel.Visible = false;
        this.statusLabel.Visible = false;
        this.autoFailedLable.Visible = true;
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void sizeList_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void StockChecker_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((this.thread_0 != null) && this.thread_0.IsAlive)
        {
            this.thread_0.Abort();
        }
    }

    private void StockChecker_Load(object sender, EventArgs e)
    {
        this.sizeList.View = View.Details;
    }

    private void switchBtn_Click(object sender, EventArgs e)
    {
        if (!this.bool_0)
        {
            this.switchBtn.Text = "Switch to advanced";
            this.bool_0 = true;
        }
        else
        {
            this.switchBtn.Text = "Switch to normal";
            this.bool_0 = false;
        }
    }

    [Serializable]
    private sealed class Class61
    {
        public static readonly StockChecker.Class61 class61_0 = new StockChecker.Class61();
        public static Func<KeyValuePair<int, int>, int> func_0;
        public static Func<KeyValuePair<int, int>, int> func_1;

        internal int method_0(KeyValuePair<int, int> keyValuePair_0) => 
            keyValuePair_0.Key;

        internal int method_1(KeyValuePair<int, int> keyValuePair_0) => 
            keyValuePair_0.Value;
    }

    private sealed class Class62
    {
        public bool bool_0;
        public StockChecker stockChecker_0;
    }

    private sealed class Class63
    {
        public int int_0;
        public StockChecker stockChecker_0;
        public string string_0;

        internal void method_0()
        {
            this.stockChecker_0.method_0(this.string_0, this.int_0);
        }
    }

    private sealed class Class64
    {
        public Dictionary<int, int> dictionary_0;
        public StockChecker stockChecker_0;
        public string[] string_0;

        internal void method_0()
        {
            if ((this.stockChecker_0.captchaBox.Checked && !this.stockChecker_0.mainForm_0.bool_6) && (this.dictionary_0.Count > 0))
            {
                this.stockChecker_0.mainForm_0.method_28();
            }
            ArrayList list = new ArrayList();
            string str = this.string_0[0];
            string str2 = this.string_0[1];
            string str3 = this.string_0[2];
            int num = 0;
            foreach (KeyValuePair<int, int> pair in this.dictionary_0)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    if ((i == this.stockChecker_0.int_1) || (num == this.stockChecker_0.int_0))
                    {
                        break;
                    }
                    num++;
                    int num3 = this.stockChecker_0.mainForm_0.int_3 + 1;
                    this.stockChecker_0.mainForm_0.int_3 = num3;
                    GClass0 class2 = new GClass0(num3, this.stockChecker_0.pidBox.Text, pair.Key, this.stockChecker_0.captchaBox.Checked, string.Empty, string.Empty, str, str2, str3, false, string.Empty, true, true);
                    list.Add(class2);
                }
                if (num == this.stockChecker_0.int_0)
                {
                    break;
                }
            }
            this.stockChecker_0.mainForm_0.method_9(list);
        }
    }

    private sealed class Class65
    {
        public StockChecker.Class62 class62_0;
        public string[] string_0;

        internal void method_0()
        {
            this.class62_0.stockChecker_0.sizeList.Items.Add(new ListViewItem(this.string_0));
        }
    }

    private sealed class Class66
    {
        public StockChecker.Class69 class69_0;
        public string[] string_0;

        internal void method_0()
        {
            this.class69_0.class62_0.stockChecker_0.sizeList.Items.Add(new ListViewItem(this.string_0));
        }
    }

    private sealed class Class67
    {
        public StockChecker.Class62 class62_0;
        public string[] string_0;

        internal void method_0()
        {
            this.class62_0.stockChecker_0.sizeList.Items.Add(new ListViewItem(this.string_0));
        }
    }

    private sealed class Class68
    {
        public StockChecker.Class69 class69_0;
        public string[] string_0;

        internal void method_0()
        {
            this.class69_0.class62_0.stockChecker_0.sizeList.Items.Add(new ListViewItem(this.string_0));
        }
    }

    private sealed class Class69
    {
        public bool bool_0;
        public bool bool_1;
        public StockChecker.Class62 class62_0;
        public int int_0;
        public string string_0;

        internal void method_0()
        {
            if (this.class62_0.stockChecker_0.sizeList.Items.Count == 0)
            {
                this.class62_0.stockChecker_0.autoFailedLable.Visible = true;
                this.class62_0.stockChecker_0.forgotClothingLabel.Visible = true;
                this.class62_0.stockChecker_0.orderLabel.Visible = false;
                this.class62_0.stockChecker_0.liveOrderableLabel.Visible = false;
                this.class62_0.stockChecker_0.liveStatusLabel.Visible = false;
                this.class62_0.stockChecker_0.statusLabel.Visible = false;
            }
            this.class62_0.stockChecker_0.autoFailedLable.Visible = false;
            this.class62_0.stockChecker_0.forgotClothingLabel.Visible = false;
            if (this.bool_0)
            {
                if (!this.class62_0.bool_0)
                {
                    this.class62_0.bool_0 = true;
                    if (this.class62_0.stockChecker_0.pushoverEnabledBox.Checked)
                    {
                        this.class62_0.stockChecker_0.method_1(this.int_0);
                    }
                }
                this.class62_0.stockChecker_0.orderLabel.Visible = true;
                this.class62_0.stockChecker_0.liveOrderableLabel.Visible = true;
                this.class62_0.stockChecker_0.liveOrderableLabel.Text = "TRUE";
                this.class62_0.stockChecker_0.liveOrderableLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.class62_0.bool_0 = false;
                this.class62_0.stockChecker_0.orderLabel.Visible = true;
                this.class62_0.stockChecker_0.liveOrderableLabel.Visible = true;
                this.class62_0.stockChecker_0.liveOrderableLabel.Text = "FALSE";
                this.class62_0.stockChecker_0.liveOrderableLabel.ForeColor = Color.Red;
            }
            if (this.bool_1)
            {
                this.class62_0.stockChecker_0.statusLabel.Visible = true;
                this.class62_0.stockChecker_0.liveStatusLabel.Visible = true;
                this.class62_0.stockChecker_0.liveStatusLabel.Text = "IN STOCK";
                this.class62_0.stockChecker_0.liveStatusLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.class62_0.stockChecker_0.statusLabel.Visible = true;
                this.class62_0.stockChecker_0.liveStatusLabel.Visible = true;
                this.class62_0.stockChecker_0.liveStatusLabel.Text = this.string_0;
                this.class62_0.stockChecker_0.liveStatusLabel.ForeColor = Color.Red;
            }
        }
    }
}

