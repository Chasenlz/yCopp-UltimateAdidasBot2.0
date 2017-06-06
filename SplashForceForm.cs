using BrightIdeasSoftware;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class SplashForceForm : Form
{
    private Button addProxyBtn;
    private ArrayList arrayList_0;
    private ArrayList arrayList_1;
    private ArrayList arrayList_2;
    private CheckBox autoRefreshBox;
    private BackgroundWorker backgroundWorker_0;
    private CheckBox blockImg;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    private Button button1;
    private Button buyProxyButton;
    private TextBox customLink;
    private Dictionary<int, string> dictionary_0;
    private RadioButton hmacRadio;
    private IContainer icontainer_0;
    private int int_0;
    public int int_1;
    private Label label1;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label15;
    private Label label16;
    private Label label2;
    private Label label22;
    private Label label25;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private ComboBox locationComboBox;
    public MainForm mainForm_0;
    private Button massButton;
    private Label metroLabel1;
    private OLVColumn olvcolumn_0;
    private OLVColumn olvcolumn_1;
    private OLVColumn olvcolumn_2;
    private OLVColumn olvcolumn_3;
    private Panel panel1;
    private TextBox proxyBox;
    private Button proxylessButton;
    private TextBox proxyPWBox;
    private TextBox proxyUsernameBox;
    private RadioButton recaptchaRadio;
    private Button removeSelectedBtn;
    private RadioButton smartBtn;
    public string string_0;
    public string string_1;
    public string string_2;
    public string string_3;
    public string string_4;
    public string string_5;
    public string string_6;
    private FastObjectListView taskOListView;
    private Button testProxyButton;
    public Thread thread_0;
    public Thread thread_1;
    public Thread thread_2;

    public SplashForceForm()
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = "<RSAKeyValue><Modulus>odT3NoYG8SzE8f9qRwX7THCi37b8OqoRrAQdpXWq1Yqm96DaBZSAaO19E1Ip3BTA8NJbn8ub09gO7JydXJQppaLSEFFpp9d9slvH8eiWzNUHsi3fWeW4XqWBnMoR947V46SR6bTw5sMtlAvGThljmjaiejfIjcHmlhoHt056aHdLLJjlz8F3FQiFfXhQk0ABTBrjYv/HvMvKGCc/R38UeCC3vm2A6BDPjUSwJh6TiEdNwP5MRUaxJbpIdJ1yf/RAoQx+v+Wb1UAmx/qLtCtFzMj2mFtuaenz4FXlCqVx8Wp3DIO7ASSeOJO2nEhu0q9oyxqUQGiTiXG1bIxJXdIPDQ==</Modulus><Exponent>AQAB</Exponent><P>7oJN2UtLMhIWADGIkaYOKuhqlpKve801ogXT5YFcw+74exZKKDlttny6eP8bKPdOCN8BvZl21qWSx75yTIf78hdWkqAl8K5dFURnlz7RM6/1RY8LaDub/vQUUJpxuxONhEwjtCYYZVXjhcyCr0fGFm8kR3Y3oYbl9oDBbhn9jCM=</P><Q>rbMmGJWprcCM+SrRzANug/l++FIzs+KMfUDpyyIuMUWoAYx/MFze2ccGJ98kjN5tbNUz5K3yXZ/LxvrlrZ/djSuJothdejqsIsGzANkFJL2IoxcRVlA6dCOGoxarYBhDUdUKOZ2qJ7IR+iZ09ln45gAuH0X9SyaoHeGU/KES0w8=</Q><DP>1n5E+JfoBh2Rv5bMVP/bWecuhD9ipZnFE/Ldv1Z5UJPGzxsakdYjvqupH0t853iQqxWzAQnUf/DjcdLqA71/bRZj+vUfabXFbGzaJICPr0Yc8/NStOh2v/BNnLdodG9/I2095rMj2W5GcXucQ3nuwRourD26hf9FLExaqGOjS7U=</DP><DQ>jwNsf1tiLAvYRiKKP+YnbQPUFZJgvV/u+gWjOLu4upq2XCgYZHJijX3/RH7F8jIEeFIF+ud5ILq7peXXix+P43aQSQLJ3CRIrAk9X5pPUNO4l0cb4CwIJK1HYin9Cg6QBuVYGN4GRc6oXISjUl37vyswzlDq3qBCVO/xohrgi+M=</DQ><InverseQ>C2AvkdxucD7YjXG2vh3Yz2b0pSAS6Q++74vKpdM2Jw3KB+RR7NBce/QNChAGZBnzBSZv3aOesSRBdBIJ7OOiyhOTOItV2oGYlSzkOm/F1SahPDRQbV3SBK1Zj6d0N4zKTwuvQysJuAFqxsh+vaO/+ka8lrnO3YFUn3XOadxpYYg=</InverseQ><D>H+dUNTOG+tTQnsSztvy+5fruoRv57bbJdRf6oDvqSd7ju73CPYdhKU5ocf6osfKFdvSBi6cgOUtG5e6aNz4eV8EZmI30PlqFNTxS1qX71LXKpp3Ugmx/RGlse/R6Rkuqbw5qlaBOPbAMtDr+BTeMI0LSFTYaG5g2VTEchE68YwuQSrjGPjWnPDe4wG6fDOaswLKo7ZPFhgx52H7u1/OwliYZgQGD0VrW/y9Bs/GD00cueJa2rI2VqMVsgDbZ2sSril1AtQnuiyLpPt9fr1ou0bKCNVeWZDmEEg6IthXixWHcD4kCxS8oJGWMcSS0BSngstdr4bwtEPx3KwQjuAJnIQ==</D></RSAKeyValue>";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/yeezy"
            },
            { 
                1,
                "http://www.adidas.nl/yeezy"
            },
            { 
                2,
                "http://www.adidas.fr/yeezy"
            },
            { 
                3,
                "http://www.adidas.es/yeezy"
            },
            { 
                4,
                "http://www.adidas.it/yeezy"
            },
            { 
                5,
                "http://www.adidas.co.uk/yeezy"
            },
            { 
                6,
                "http://www.adidas.com/yeezy"
            },
            { 
                7,
                "http://www.adidas.ca/yeezy"
            },
            { 
                8,
                "http://www.adidas.com.au/yeezy"
            },
            { 
                9,
                "http://www.adidas.at/yeezy"
            },
            { 
                10,
                "http://www.adidas.be/yeezy"
            },
            { 
                11,
                "http://www.adidas.se/yeezy"
            },
            { 
                12,
                "http://www.adidas.dk/yeezy"
            },
            { 
                13,
                "http://www.adidas.no/yeezy"
            },
            { 
                14,
                "http://www.adidas.pl/yeezy"
            },
            { 
                15,
                "http://www.adidas.cz/yeezy"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/yeezy"
            },
            { 
                0x11,
                "http://www.adidas.ru/yeezy"
            },
            { 
                0x12,
                "http://www.adidas.mx/yeezy"
            },
            { 
                0x13,
                "http://www.adidas.com/pt/yeezy"
            }
        };
        this.dictionary_0 = dictionary1;
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.InitializeComponent();
    }

    public SplashForceForm(MainForm mainForm_1, string string_7, string string_8, string string_9)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = "<RSAKeyValue><Modulus>odT3NoYG8SzE8f9qRwX7THCi37b8OqoRrAQdpXWq1Yqm96DaBZSAaO19E1Ip3BTA8NJbn8ub09gO7JydXJQppaLSEFFpp9d9slvH8eiWzNUHsi3fWeW4XqWBnMoR947V46SR6bTw5sMtlAvGThljmjaiejfIjcHmlhoHt056aHdLLJjlz8F3FQiFfXhQk0ABTBrjYv/HvMvKGCc/R38UeCC3vm2A6BDPjUSwJh6TiEdNwP5MRUaxJbpIdJ1yf/RAoQx+v+Wb1UAmx/qLtCtFzMj2mFtuaenz4FXlCqVx8Wp3DIO7ASSeOJO2nEhu0q9oyxqUQGiTiXG1bIxJXdIPDQ==</Modulus><Exponent>AQAB</Exponent><P>7oJN2UtLMhIWADGIkaYOKuhqlpKve801ogXT5YFcw+74exZKKDlttny6eP8bKPdOCN8BvZl21qWSx75yTIf78hdWkqAl8K5dFURnlz7RM6/1RY8LaDub/vQUUJpxuxONhEwjtCYYZVXjhcyCr0fGFm8kR3Y3oYbl9oDBbhn9jCM=</P><Q>rbMmGJWprcCM+SrRzANug/l++FIzs+KMfUDpyyIuMUWoAYx/MFze2ccGJ98kjN5tbNUz5K3yXZ/LxvrlrZ/djSuJothdejqsIsGzANkFJL2IoxcRVlA6dCOGoxarYBhDUdUKOZ2qJ7IR+iZ09ln45gAuH0X9SyaoHeGU/KES0w8=</Q><DP>1n5E+JfoBh2Rv5bMVP/bWecuhD9ipZnFE/Ldv1Z5UJPGzxsakdYjvqupH0t853iQqxWzAQnUf/DjcdLqA71/bRZj+vUfabXFbGzaJICPr0Yc8/NStOh2v/BNnLdodG9/I2095rMj2W5GcXucQ3nuwRourD26hf9FLExaqGOjS7U=</DP><DQ>jwNsf1tiLAvYRiKKP+YnbQPUFZJgvV/u+gWjOLu4upq2XCgYZHJijX3/RH7F8jIEeFIF+ud5ILq7peXXix+P43aQSQLJ3CRIrAk9X5pPUNO4l0cb4CwIJK1HYin9Cg6QBuVYGN4GRc6oXISjUl37vyswzlDq3qBCVO/xohrgi+M=</DQ><InverseQ>C2AvkdxucD7YjXG2vh3Yz2b0pSAS6Q++74vKpdM2Jw3KB+RR7NBce/QNChAGZBnzBSZv3aOesSRBdBIJ7OOiyhOTOItV2oGYlSzkOm/F1SahPDRQbV3SBK1Zj6d0N4zKTwuvQysJuAFqxsh+vaO/+ka8lrnO3YFUn3XOadxpYYg=</InverseQ><D>H+dUNTOG+tTQnsSztvy+5fruoRv57bbJdRf6oDvqSd7ju73CPYdhKU5ocf6osfKFdvSBi6cgOUtG5e6aNz4eV8EZmI30PlqFNTxS1qX71LXKpp3Ugmx/RGlse/R6Rkuqbw5qlaBOPbAMtDr+BTeMI0LSFTYaG5g2VTEchE68YwuQSrjGPjWnPDe4wG6fDOaswLKo7ZPFhgx52H7u1/OwliYZgQGD0VrW/y9Bs/GD00cueJa2rI2VqMVsgDbZ2sSril1AtQnuiyLpPt9fr1ou0bKCNVeWZDmEEg6IthXixWHcD4kCxS8oJGWMcSS0BSngstdr4bwtEPx3KwQjuAJnIQ==</D></RSAKeyValue>";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/yeezy"
            },
            { 
                1,
                "http://www.adidas.nl/yeezy"
            },
            { 
                2,
                "http://www.adidas.fr/yeezy"
            },
            { 
                3,
                "http://www.adidas.es/yeezy"
            },
            { 
                4,
                "http://www.adidas.it/yeezy"
            },
            { 
                5,
                "http://www.adidas.co.uk/yeezy"
            },
            { 
                6,
                "http://www.adidas.com/yeezy"
            },
            { 
                7,
                "http://www.adidas.ca/yeezy"
            },
            { 
                8,
                "http://www.adidas.com.au/yeezy"
            },
            { 
                9,
                "http://www.adidas.at/yeezy"
            },
            { 
                10,
                "http://www.adidas.be/yeezy"
            },
            { 
                11,
                "http://www.adidas.se/yeezy"
            },
            { 
                12,
                "http://www.adidas.dk/yeezy"
            },
            { 
                13,
                "http://www.adidas.no/yeezy"
            },
            { 
                14,
                "http://www.adidas.pl/yeezy"
            },
            { 
                15,
                "http://www.adidas.cz/yeezy"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/yeezy"
            },
            { 
                0x11,
                "http://www.adidas.ru/yeezy"
            },
            { 
                0x12,
                "http://www.adidas.mx/yeezy"
            },
            { 
                0x13,
                "http://www.adidas.com/pt/yeezy"
            }
        };
        this.dictionary_0 = dictionary1;
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        Class51 class2 = new Class51 {
            mainForm_0 = mainForm_1
        };
        class2.splashForceForm_0 = this;
        this.InitializeComponent();
        this.mainForm_0 = class2.mainForm_0;
        this.string_0 = string_8;
        this.string_1 = string_7;
        this.string_2 = string_9;
        this.locationComboBox.SelectedIndex = class2.mainForm_0.int_2;
        this.int_0 = class2.mainForm_0.int_2;
        this.taskOListView.GetColumn(0).GroupKeyGetter = Class49.groupKeyGetterDelegate_1 ?? (Class49.groupKeyGetterDelegate_1 = new GroupKeyGetterDelegate(Class49.class49_0.method_1));
        this.taskOListView.SetObjects(this.arrayList_0);
        this.taskOListView.FullRowSelect = true;
        this.taskOListView.ButtonClick += new EventHandler<CellClickEventArgs>(class2.method_0);
    }

    public SplashForceForm(MainForm mainForm_1, string string_7, string string_8, string string_9, bool bool_3)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.string_6 = "<RSAKeyValue><Modulus>odT3NoYG8SzE8f9qRwX7THCi37b8OqoRrAQdpXWq1Yqm96DaBZSAaO19E1Ip3BTA8NJbn8ub09gO7JydXJQppaLSEFFpp9d9slvH8eiWzNUHsi3fWeW4XqWBnMoR947V46SR6bTw5sMtlAvGThljmjaiejfIjcHmlhoHt056aHdLLJjlz8F3FQiFfXhQk0ABTBrjYv/HvMvKGCc/R38UeCC3vm2A6BDPjUSwJh6TiEdNwP5MRUaxJbpIdJ1yf/RAoQx+v+Wb1UAmx/qLtCtFzMj2mFtuaenz4FXlCqVx8Wp3DIO7ASSeOJO2nEhu0q9oyxqUQGiTiXG1bIxJXdIPDQ==</Modulus><Exponent>AQAB</Exponent><P>7oJN2UtLMhIWADGIkaYOKuhqlpKve801ogXT5YFcw+74exZKKDlttny6eP8bKPdOCN8BvZl21qWSx75yTIf78hdWkqAl8K5dFURnlz7RM6/1RY8LaDub/vQUUJpxuxONhEwjtCYYZVXjhcyCr0fGFm8kR3Y3oYbl9oDBbhn9jCM=</P><Q>rbMmGJWprcCM+SrRzANug/l++FIzs+KMfUDpyyIuMUWoAYx/MFze2ccGJ98kjN5tbNUz5K3yXZ/LxvrlrZ/djSuJothdejqsIsGzANkFJL2IoxcRVlA6dCOGoxarYBhDUdUKOZ2qJ7IR+iZ09ln45gAuH0X9SyaoHeGU/KES0w8=</Q><DP>1n5E+JfoBh2Rv5bMVP/bWecuhD9ipZnFE/Ldv1Z5UJPGzxsakdYjvqupH0t853iQqxWzAQnUf/DjcdLqA71/bRZj+vUfabXFbGzaJICPr0Yc8/NStOh2v/BNnLdodG9/I2095rMj2W5GcXucQ3nuwRourD26hf9FLExaqGOjS7U=</DP><DQ>jwNsf1tiLAvYRiKKP+YnbQPUFZJgvV/u+gWjOLu4upq2XCgYZHJijX3/RH7F8jIEeFIF+ud5ILq7peXXix+P43aQSQLJ3CRIrAk9X5pPUNO4l0cb4CwIJK1HYin9Cg6QBuVYGN4GRc6oXISjUl37vyswzlDq3qBCVO/xohrgi+M=</DQ><InverseQ>C2AvkdxucD7YjXG2vh3Yz2b0pSAS6Q++74vKpdM2Jw3KB+RR7NBce/QNChAGZBnzBSZv3aOesSRBdBIJ7OOiyhOTOItV2oGYlSzkOm/F1SahPDRQbV3SBK1Zj6d0N4zKTwuvQysJuAFqxsh+vaO/+ka8lrnO3YFUn3XOadxpYYg=</InverseQ><D>H+dUNTOG+tTQnsSztvy+5fruoRv57bbJdRf6oDvqSd7ju73CPYdhKU5ocf6osfKFdvSBi6cgOUtG5e6aNz4eV8EZmI30PlqFNTxS1qX71LXKpp3Ugmx/RGlse/R6Rkuqbw5qlaBOPbAMtDr+BTeMI0LSFTYaG5g2VTEchE68YwuQSrjGPjWnPDe4wG6fDOaswLKo7ZPFhgx52H7u1/OwliYZgQGD0VrW/y9Bs/GD00cueJa2rI2VqMVsgDbZ2sSril1AtQnuiyLpPt9fr1ou0bKCNVeWZDmEEg6IthXixWHcD4kCxS8oJGWMcSS0BSngstdr4bwtEPx3KwQjuAJnIQ==</D></RSAKeyValue>";
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            { 
                0,
                "http://www.adidas.de/yeezy"
            },
            { 
                1,
                "http://www.adidas.nl/yeezy"
            },
            { 
                2,
                "http://www.adidas.fr/yeezy"
            },
            { 
                3,
                "http://www.adidas.es/yeezy"
            },
            { 
                4,
                "http://www.adidas.it/yeezy"
            },
            { 
                5,
                "http://www.adidas.co.uk/yeezy"
            },
            { 
                6,
                "http://www.adidas.com/yeezy"
            },
            { 
                7,
                "http://www.adidas.ca/yeezy"
            },
            { 
                8,
                "http://www.adidas.com.au/yeezy"
            },
            { 
                9,
                "http://www.adidas.at/yeezy"
            },
            { 
                10,
                "http://www.adidas.be/yeezy"
            },
            { 
                11,
                "http://www.adidas.se/yeezy"
            },
            { 
                12,
                "http://www.adidas.dk/yeezy"
            },
            { 
                13,
                "http://www.adidas.no/yeezy"
            },
            { 
                14,
                "http://www.adidas.pl/yeezy"
            },
            { 
                15,
                "http://www.adidas.cz/yeezy"
            },
            { 
                0x10,
                "http://www.adidas.co.nz/yeezy"
            },
            { 
                0x11,
                "http://www.adidas.ru/yeezy"
            },
            { 
                0x12,
                "http://www.adidas.mx/yeezy"
            },
            { 
                0x13,
                "http://www.adidas.com/pt/yeezy"
            }
        };
        this.dictionary_0 = dictionary1;
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        Class50 class2 = new Class50 {
            mainForm_0 = mainForm_1
        };
        class2.splashForceForm_0 = this;
        this.InitializeComponent();
        this.mainForm_0 = class2.mainForm_0;
        this.string_0 = string_8;
        this.string_1 = string_7;
        this.string_2 = string_9;
        this.locationComboBox.SelectedIndex = class2.mainForm_0.int_2;
        this.int_0 = class2.mainForm_0.int_2;
        this.bool_2 = bool_3;
        if (bool_3)
        {
            this.hmacRadio.Enabled = false;
            this.recaptchaRadio.Enabled = false;
        }
        this.taskOListView.GetColumn(0).GroupKeyGetter = Class49.groupKeyGetterDelegate_0 ?? (Class49.groupKeyGetterDelegate_0 = new GroupKeyGetterDelegate(Class49.class49_0.method_0));
        this.taskOListView.SetObjects(this.arrayList_0);
        this.taskOListView.FullRowSelect = true;
        this.taskOListView.ButtonClick += new EventHandler<CellClickEventArgs>(class2.method_0);
    }

    private void addProxyBtn_Click(object sender, EventArgs e)
    {
        if (!this.proxyBox.Text.Equals(string.Empty))
        {
            while (this.bool_1)
            {
                Thread.Sleep(250);
            }
            int num = this.int_1 + 1;
            this.int_1 = num;
            this.arrayList_0.Add(new Class20(num, this.proxyBox.Text, this.proxyUsernameBox.Text, this.proxyPWBox.Text));
            this.taskOListView.SetObjects(this.arrayList_0);
            if (this.bool_0 && !this.thread_2.IsAlive)
            {
                this.thread_2 = new Thread(new ThreadStart(this.method_0));
                this.thread_2.Start();
                this.addProxyBtn.Enabled = false;
                this.removeSelectedBtn.Enabled = false;
            }
        }
        else
        {
            MessageBox.Show(this, "Please enter a proxy. If you want to use your own ip, please enter 'local'.");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (this.bool_0)
        {
            if (MessageBox.Show("Do you really want to cancel all Brute Forcer tasks?", "Stop Brute Forcer?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((this.thread_0 != null) && this.thread_0.IsAlive)
                {
                    this.thread_0.Abort();
                }
                if ((this.thread_1 != null) && this.thread_1.IsAlive)
                {
                    this.thread_1.Abort();
                }
                if ((this.thread_2 != null) && this.thread_2.IsAlive)
                {
                    this.thread_2.Abort();
                }
                this.bool_1 = false;
                foreach (Class20 class2 in this.arrayList_0)
                {
                    if (class2.panel_0 != null)
                    {
                        class2.panel_0.Dispose();
                    }
                    if (class2.chromiumWebBrowser_0 != null)
                    {
                        class2.chromiumWebBrowser_0.Dispose();
                    }
                    if (class2.httpWebRequest_0 != null)
                    {
                        class2.httpWebRequest_0 = null;
                    }
                    class2.cookieContainer_0 = null;
                    class2.state = 0;
                    class2.int_0 = 0;
                    class2.int_1 = 0;
                    class2.action = string.Empty;
                    class2.bool_0 = true;
                }
                this.taskOListView.SetObjects(this.arrayList_0);
                this.button1.Text = "Start Brute Forcer";
                this.bool_0 = false;
                this.customLink.Enabled = true;
                this.addProxyBtn.Enabled = true;
                this.massButton.Enabled = true;
                this.proxylessButton.Enabled = true;
                this.removeSelectedBtn.Enabled = true;
                this.autoRefreshBox.Enabled = true;
            }
        }
        else if (!this.customLink.Text.Equals(string.Empty) && !this.customLink.Text.ToLower().Contains("adidas."))
        {
            MessageBox.Show(this, "The custom url must be an adidas url.");
        }
        else
        {
            if (!this.customLink.Text.Equals(string.Empty))
            {
                try
                {
                    new Uri(this.customLink.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("The entered URL is invalid.");
                    return;
                }
            }
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/bfd2.php");
            string s = ((("name=" + this.mainForm_0.string_8.Trim()) + "&serial=" + this.mainForm_0.string_9.Trim()) + "&hid=" + Class21.smethod_4()) + "&app=yCoppCaptchaADBDB";
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;
            request.Timeout = 0x1388;
            HttpWebResponse response = null;
            try
            {
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (WebException)
            {
                MessageBox.Show("Please try again later.");
                return;
            }
            string str2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            if (str2.Contains("ConnectionError") || str2.Contains("ErrorActivating"))
            {
                MessageBox.Show("Please try again later.");
            }
            else if (!str2.Contains("ValidLicense"))
            {
                MessageBox.Show("Please try again later.");
            }
            else
            {
                if (Class21.smethod_5("ValidLicenseyCoppCaptchaADBDB" + this.mainForm_0.string_8.Trim() + this.mainForm_0.string_9.Trim(), str2.Substring(12)))
                {
                    if (response.Headers.Get("a") != null)
                    {
                        this.string_1 = Class21.smethod_6(response.Headers.Get("a"), this.string_6);
                    }
                    if (response.Headers.Get("b") != null)
                    {
                        this.string_0 = Class21.smethod_6(response.Headers.Get("b"), this.string_6);
                    }
                    if (response.Headers.Get("c") != null)
                    {
                        this.string_3 = Class21.smethod_6(response.Headers.Get("c"), this.string_6);
                    }
                    if (response.Headers.Get("d") != null)
                    {
                        this.string_4 = Class21.smethod_6(response.Headers.Get("d"), this.string_6);
                    }
                    if (response.Headers.Get("e") != null)
                    {
                        this.string_5 = Class21.smethod_6(response.Headers.Get("e"), this.string_6);
                    }
                }
                this.bool_0 = true;
                this.thread_0 = new Thread(new ThreadStart(this.method_5));
                this.thread_0.Start();
                if (this.bool_2)
                {
                    this.thread_1 = new Thread(new ThreadStart(this.method_2));
                    this.thread_1.Start();
                    this.thread_2 = new Thread(new ThreadStart(this.method_1));
                    this.thread_2.Start();
                }
                else
                {
                    this.thread_1 = new Thread(new ThreadStart(this.method_3));
                    this.thread_1.Start();
                    this.thread_2 = new Thread(new ThreadStart(this.method_0));
                    this.thread_2.Start();
                }
                this.button1.Text = "Stop Brute Forcer";
                this.addProxyBtn.Enabled = false;
                this.proxylessButton.Enabled = false;
                this.massButton.Enabled = false;
                this.removeSelectedBtn.Enabled = false;
                this.customLink.Enabled = false;
                this.autoRefreshBox.Enabled = false;
            }
        }
    }

    private void buyProxyButton_Click(object sender, EventArgs e)
    {
        Process.Start("http://ycopp.com/proxy-servers/");
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(SplashForceForm));
        this.button1 = new Button();
        this.backgroundWorker_0 = new BackgroundWorker();
        this.taskOListView = new FastObjectListView();
        this.olvcolumn_0 = new OLVColumn();
        this.olvcolumn_1 = new OLVColumn();
        this.olvcolumn_3 = new OLVColumn();
        this.olvcolumn_2 = new OLVColumn();
        this.label25 = new Label();
        this.testProxyButton = new Button();
        this.label22 = new Label();
        this.proxyPWBox = new TextBox();
        this.proxyUsernameBox = new TextBox();
        this.label15 = new Label();
        this.proxyBox = new TextBox();
        this.addProxyBtn = new Button();
        this.removeSelectedBtn = new Button();
        this.label16 = new Label();
        this.locationComboBox = new ComboBox();
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.customLink = new TextBox();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.label7 = new Label();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label10 = new Label();
        this.label11 = new Label();
        this.label12 = new Label();
        this.buyProxyButton = new Button();
        this.massButton = new Button();
        this.autoRefreshBox = new CheckBox();
        this.panel1 = new Panel();
        this.smartBtn = new RadioButton();
        this.hmacRadio = new RadioButton();
        this.recaptchaRadio = new RadioButton();
        this.metroLabel1 = new Label();
        this.proxylessButton = new Button();
        this.blockImg = new CheckBox();
        ((ISupportInitialize) this.taskOListView).BeginInit();
        this.panel1.SuspendLayout();
        base.SuspendLayout();
        this.button1.Location = new Point(0x3f, 0x1d7);
        this.button1.Name = "button1";
        this.button1.Size = new Size(0xb7, 0x39);
        this.button1.TabIndex = 0;
        this.button1.Text = "Start Brute Force";
        this.button1.Click += new EventHandler(this.button1_Click);
        this.taskOListView.AllColumns.Add(this.olvcolumn_0);
        this.taskOListView.AllColumns.Add(this.olvcolumn_1);
        this.taskOListView.AllColumns.Add(this.olvcolumn_3);
        this.taskOListView.AllColumns.Add(this.olvcolumn_2);
        this.taskOListView.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
        this.taskOListView.CausesValidation = false;
        this.taskOListView.CellEditActivation = ObjectListView.CellEditActivateMode.DoubleClick;
        this.taskOListView.CellEditUseWholeCell = false;
        ColumnHeader[] values = new ColumnHeader[] { this.olvcolumn_0, this.olvcolumn_1, this.olvcolumn_3, this.olvcolumn_2 };
        this.taskOListView.Columns.AddRange(values);
        this.taskOListView.Cursor = Cursors.Default;
        this.taskOListView.Location = new Point(0x12f, 12);
        this.taskOListView.Name = "taskOListView";
        this.taskOListView.RowHeight = 0x23;
        this.taskOListView.ShowGroups = false;
        this.taskOListView.Size = new Size(0x1c1, 0x2a5);
        this.taskOListView.TabIndex = 80;
        this.taskOListView.UseCompatibleStateImageBehavior = false;
        this.taskOListView.View = View.Details;
        this.taskOListView.VirtualMode = true;
        this.taskOListView.CellRightClick += new EventHandler<CellRightClickEventArgs>(this.method_6);
        this.taskOListView.FormatRow += new EventHandler<FormatRowEventArgs>(this.method_4);
        this.taskOListView.SelectedIndexChanged += new EventHandler(this.taskOListView_SelectedIndexChanged);
        this.olvcolumn_0.AspectName = "id";
        this.olvcolumn_0.Text = "ID";
        this.olvcolumn_0.Width = 40;
        this.olvcolumn_1.AspectName = "proxy";
        this.olvcolumn_1.Text = "Proxy";
        this.olvcolumn_1.Width = 100;
        this.olvcolumn_3.AspectName = "getStateString";
        this.olvcolumn_3.Text = "State";
        this.olvcolumn_3.Width = 140;
        this.olvcolumn_2.AspectName = "action";
        this.olvcolumn_2.IsButton = true;
        this.olvcolumn_2.Text = "Action";
        this.olvcolumn_2.Width = 0xa5;
        this.label25.AutoSize = true;
        this.label25.Location = new Point(0xcf, 0x76);
        this.label25.Name = "label25";
        this.label25.Size = new Size(10, 13);
        this.label25.TabIndex = 0x60;
        this.label25.Text = ":";
        this.testProxyButton.Location = new Point(9, 0x93);
        this.testProxyButton.Name = "testProxyButton";
        this.testProxyButton.Size = new Size(110, 0x23);
        this.testProxyButton.TabIndex = 0x5f;
        this.testProxyButton.Text = "Test Proxy";
        this.testProxyButton.Click += new EventHandler(this.testProxyButton_Click);
        this.label22.AutoSize = true;
        this.label22.Location = new Point(6, 0x73);
        this.label22.Name = "label22";
        this.label22.Size = new Size(0x41, 13);
        this.label22.TabIndex = 0x5e;
        this.label22.Text = "Proxy Login:";
        this.proxyPWBox.Location = new Point(0xe3, 0x75);
        this.proxyPWBox.Name = "proxyPWBox";
        this.proxyPWBox.Size = new Size(0x41, 20);
        this.proxyPWBox.TabIndex = 0x5d;
        this.proxyUsernameBox.Location = new Point(0x80, 0x75);
        this.proxyUsernameBox.Name = "proxyUsernameBox";
        this.proxyUsernameBox.Size = new Size(0x49, 20);
        this.proxyUsernameBox.TabIndex = 0x5c;
        this.label15.AutoSize = true;
        this.label15.Location = new Point(6, 0x5c);
        this.label15.Name = "label15";
        this.label15.Size = new Size(0x60, 13);
        this.label15.TabIndex = 0x5b;
        this.label15.Text = "Proxy (HTTP only):";
        this.proxyBox.Location = new Point(0x80, 0x5b);
        this.proxyBox.MaxLength = 100;
        this.proxyBox.Name = "proxyBox";
        this.proxyBox.Size = new Size(0xa4, 20);
        this.proxyBox.TabIndex = 90;
        this.addProxyBtn.Location = new Point(0xb6, 0x93);
        this.addProxyBtn.Name = "addProxyBtn";
        this.addProxyBtn.Size = new Size(110, 0x23);
        this.addProxyBtn.TabIndex = 0x61;
        this.addProxyBtn.Text = "Add Proxy";
        this.addProxyBtn.Click += new EventHandler(this.addProxyBtn_Click);
        this.removeSelectedBtn.Location = new Point(0x54, 0x28e);
        this.removeSelectedBtn.Name = "removeSelectedBtn";
        this.removeSelectedBtn.Size = new Size(0x85, 0x23);
        this.removeSelectedBtn.TabIndex = 0x62;
        this.removeSelectedBtn.Text = "Remove Selected Proxy";
        this.removeSelectedBtn.Click += new EventHandler(this.removeSelectedBtn_Click);
        this.label16.AutoSize = true;
        this.label16.Location = new Point(6, 0x110);
        this.label16.Name = "label16";
        this.label16.Size = new Size(0x33, 13);
        this.label16.TabIndex = 100;
        this.label16.Text = "Location:";
        this.locationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.locationComboBox.FormattingEnabled = true;
        object[] items = new object[] { 
            "Germany", "Netherlands", "France", "Spain", "Italy", "United Kingdom", "United States", "Canada", "Australia", "Austria", "Belgium", "Sweden", "Denmark", "Norway", "Poland", "Czech Republic",
            "New Zealand", "Russia", "Mexico", "Portugal"
        };
        this.locationComboBox.Items.AddRange(items);
        this.locationComboBox.Location = new Point(80, 0x110);
        this.locationComboBox.Name = "locationComboBox";
        this.locationComboBox.Size = new Size(0x79, 0x15);
        this.locationComboBox.TabIndex = 0x63;
        this.locationComboBox.SelectedIndexChanged += new EventHandler(this.locationComboBox_SelectedIndexChanged);
        this.label1.AutoSize = true;
        this.label1.Location = new Point(6, 0x3f);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0xd8, 13);
        this.label1.TabIndex = 0x65;
        this.label1.Text = "2. Test your Proxies and add them to the list:";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(6, 0xf1);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0xc6, 13);
        this.label2.TabIndex = 0x66;
        this.label2.Text = "3. Set your location for the Yeezy Splash";
        this.label3.AutoSize = true;
        this.label3.Location = new Point(6, 0x128);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0xb2, 13);
        this.label3.TabIndex = 0x67;
        this.label3.Text = "OR enter a custom splash page link:";
        this.customLink.Location = new Point(0x3f, 0x141);
        this.customLink.Name = "customLink";
        this.customLink.Size = new Size(0xce, 20);
        this.customLink.TabIndex = 0x68;
        this.label4.AutoSize = true;
        this.label4.Location = new Point(6, 0x141);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x20, 13);
        this.label4.TabIndex = 0x69;
        this.label4.Text = "URL:";
        this.label5.AutoSize = true;
        this.label5.Location = new Point(6, 0x1ab);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0xb2, 13);
        this.label5.TabIndex = 0x6a;
        this.label5.Text = "5. Start the Brute Forcer and wait for";
        this.label6.AutoSize = true;
        this.label6.Location = new Point(20, 0x1be);
        this.label6.Name = "label6";
        this.label6.Size = new Size(100, 13);
        this.label6.TabIndex = 0x6b;
        this.label6.Text = "a proxy to succeed:";
        this.label7.AutoSize = true;
        this.label7.Location = new Point(6, 0x223);
        this.label7.Name = "label7";
        this.label7.Size = new Size(0xd4, 13);
        this.label7.TabIndex = 0x6c;
        this.label7.Text = "6. Press 'Apply this proxy' to apply the hmac";
        this.label7.Click += new EventHandler(this.label7_Click);
        this.label8.AutoSize = true;
        this.label8.Location = new Point(20, 0x232);
        this.label8.Name = "label8";
        this.label8.Size = new Size(0xa2, 13);
        this.label8.TabIndex = 0x6d;
        this.label8.Text = "cookie and the proxy to all tasks.";
        this.label9.AutoSize = true;
        this.label9.Location = new Point(20, 0x241);
        this.label9.Name = "label9";
        this.label9.Size = new Size(0xd0, 13);
        this.label9.TabIndex = 110;
        this.label9.Text = "The captcha sitekey will also be extracted.";
        this.label10.AutoSize = true;
        this.label10.Location = new Point(20, 0x267);
        this.label10.Name = "label10";
        this.label10.Size = new Size(0xd6, 13);
        this.label10.TabIndex = 0x6f;
        this.label10.Text = "If a proxy repeatedly fails, select it and press";
        this.label11.AutoSize = true;
        this.label11.Location = new Point(20, 630);
        this.label11.Name = "label11";
        this.label11.Size = new Size(0xad, 13);
        this.label11.TabIndex = 0x70;
        this.label11.Text = "this button to remove it from the list:";
        this.label12.AutoSize = true;
        this.label12.Location = new Point(6, 0x15);
        this.label12.Name = "label12";
        this.label12.Size = new Size(0x68, 13);
        this.label12.TabIndex = 0x71;
        this.label12.Text = "1. Get some Proxies:";
        this.buyProxyButton.Location = new Point(0x8a, 12);
        this.buyProxyButton.Name = "buyProxyButton";
        this.buyProxyButton.Size = new Size(110, 0x23);
        this.buyProxyButton.TabIndex = 0x72;
        this.buyProxyButton.Text = "Buy Proxies";
        this.buyProxyButton.Click += new EventHandler(this.buyProxyButton_Click);
        this.massButton.Location = new Point(0xb6, 0xbc);
        this.massButton.Name = "massButton";
        this.massButton.Size = new Size(110, 0x23);
        this.massButton.TabIndex = 0x73;
        this.massButton.Text = "Mass Import";
        this.massButton.Click += new EventHandler(this.massButton_Click);
        this.autoRefreshBox.AutoSize = true;
        this.autoRefreshBox.Location = new Point(0x120, -2);
        this.autoRefreshBox.Name = "autoRefreshBox";
        this.autoRefreshBox.Size = new Size(0xd3, 0x11);
        this.autoRefreshBox.TabIndex = 0x74;
        this.autoRefreshBox.Text = "Use auto refresh mode (might not work)";
        this.autoRefreshBox.UseVisualStyleBackColor = true;
        this.autoRefreshBox.Visible = false;
        this.panel1.Controls.Add(this.smartBtn);
        this.panel1.Controls.Add(this.hmacRadio);
        this.panel1.Controls.Add(this.recaptchaRadio);
        this.panel1.Location = new Point(6, 0x17d);
        this.panel1.Margin = new Padding(1);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(0x11e, 0x1c);
        this.panel1.TabIndex = 0x75;
        this.smartBtn.AutoSize = true;
        this.smartBtn.Checked = true;
        this.smartBtn.Location = new Point(5, 7);
        this.smartBtn.Margin = new Padding(1);
        this.smartBtn.Name = "smartBtn";
        this.smartBtn.Size = new Size(0x63, 0x11);
        this.smartBtn.TabIndex = 4;
        this.smartBtn.TabStop = true;
        this.smartBtn.Text = "Smart detection";
        this.smartBtn.UseVisualStyleBackColor = true;
        this.hmacRadio.AutoSize = true;
        this.hmacRadio.Location = new Point(0xdd, 7);
        this.hmacRadio.Margin = new Padding(1);
        this.hmacRadio.Name = "hmacRadio";
        this.hmacRadio.Size = new Size(0x38, 0x11);
        this.hmacRadio.TabIndex = 3;
        this.hmacRadio.Text = "HMAC";
        this.hmacRadio.UseVisualStyleBackColor = true;
        this.recaptchaRadio.AutoSize = true;
        this.recaptchaRadio.Location = new Point(0x7f, 7);
        this.recaptchaRadio.Margin = new Padding(1);
        this.recaptchaRadio.Name = "recaptchaRadio";
        this.recaptchaRadio.Size = new Size(60, 0x11);
        this.recaptchaRadio.TabIndex = 2;
        this.recaptchaRadio.Text = "Sitekey";
        this.recaptchaRadio.UseVisualStyleBackColor = true;
        this.metroLabel1.AutoSize = true;
        this.metroLabel1.Location = new Point(6, 0x169);
        this.metroLabel1.Name = "metroLabel1";
        this.metroLabel1.Size = new Size(0x8f, 13);
        this.metroLabel1.TabIndex = 0x76;
        this.metroLabel1.Text = "4. Select a success criterion:";
        this.proxylessButton.Location = new Point(10, 0xbc);
        this.proxylessButton.Name = "proxylessButton";
        this.proxylessButton.Size = new Size(110, 0x23);
        this.proxylessButton.TabIndex = 0x77;
        this.proxylessButton.Text = "Add Proxyless Task";
        this.proxylessButton.Click += new EventHandler(this.proxylessButton_Click);
        this.blockImg.AutoSize = true;
        this.blockImg.Location = new Point(0x1f9, -2);
        this.blockImg.Name = "blockImg";
        this.blockImg.Size = new Size(0x59, 0x11);
        this.blockImg.TabIndex = 120;
        this.blockImg.Text = "Block images";
        this.blockImg.UseVisualStyleBackColor = true;
        this.blockImg.Visible = false;
        base.AutoScaleDimensions = new SizeF(96f, 96f);
        base.AutoScaleMode = AutoScaleMode.Dpi;
        base.ClientSize = new Size(0x2fc, 0x2bd);
        base.Controls.Add(this.blockImg);
        base.Controls.Add(this.proxylessButton);
        base.Controls.Add(this.metroLabel1);
        base.Controls.Add(this.panel1);
        base.Controls.Add(this.autoRefreshBox);
        base.Controls.Add(this.massButton);
        base.Controls.Add(this.buyProxyButton);
        base.Controls.Add(this.label12);
        base.Controls.Add(this.label11);
        base.Controls.Add(this.label10);
        base.Controls.Add(this.label9);
        base.Controls.Add(this.label8);
        base.Controls.Add(this.label7);
        base.Controls.Add(this.label6);
        base.Controls.Add(this.label5);
        base.Controls.Add(this.label4);
        base.Controls.Add(this.customLink);
        base.Controls.Add(this.label3);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.label16);
        base.Controls.Add(this.locationComboBox);
        base.Controls.Add(this.removeSelectedBtn);
        base.Controls.Add(this.addProxyBtn);
        base.Controls.Add(this.label25);
        base.Controls.Add(this.testProxyButton);
        base.Controls.Add(this.label22);
        base.Controls.Add(this.proxyPWBox);
        base.Controls.Add(this.proxyUsernameBox);
        base.Controls.Add(this.label15);
        base.Controls.Add(this.proxyBox);
        base.Controls.Add(this.taskOListView);
        base.Controls.Add(this.button1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        this.MaximumSize = new Size(780, 0x4e2);
        base.MinimizeBox = false;
        this.MinimumSize = new Size(780, 740);
        base.Name = "SplashForceForm";
        this.Text = "Splash Page Brute Forcer";
        base.FormClosing += new FormClosingEventHandler(this.SplashForceForm_FormClosing);
        base.Load += new EventHandler(this.SplashForceForm_Load);
        ((ISupportInitialize) this.taskOListView).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void label7_Click(object sender, EventArgs e)
    {
    }

    private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.int_0 = this.locationComboBox.SelectedIndex;
    }

    private void massButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(this, "Please select a txt file containing one proxy per line in the format ip:port:user:password. User and password are optional.");
        Stream stream = null;
        OpenFileDialog dialog = new OpenFileDialog {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                stream = dialog.OpenFile();
                if (stream != null)
                {
                    using (stream)
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, 0x200))
                        {
                            string str;
                            while ((str = reader.ReadLine()) != null)
                            {
                                int num;
                                char[] separator = new char[] { ':' };
                                string[] strArray = str.Split(separator);
                                if (((strArray.Length == 4) && (strArray[0].Trim().Length > 4)) && (strArray[1].Trim().Length <= 5))
                                {
                                    num = this.int_1 + 1;
                                    this.int_1 = num;
                                    this.arrayList_0.Add(new Class20(num, strArray[0].Trim() + ":" + strArray[1].Trim(), strArray[2].Trim(), strArray[3].Trim()));
                                }
                                else if (((strArray.Length == 2) && (strArray[0].Trim().Length > 4)) && (strArray[1].Trim().Length <= 5))
                                {
                                    num = this.int_1 + 1;
                                    this.int_1 = num;
                                    this.arrayList_0.Add(new Class20(num, strArray[0].Trim() + ":" + strArray[1].Trim()));
                                }
                            }
                        }
                        this.taskOListView.SetObjects(this.arrayList_0);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + exception.Message);
            }
        }
    }

    private void method_0()
    {
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int num;
                IEnumerator enumerator2;
                Class53 class3 = new Class53 {
                    splashForceForm_0 = this,
                    class20_0 = (Class20) enumerator.Current
                };
                Class52 class2 = new Class52 {
                    class53_0 = class3
                };
                if (class2.class53_0.class20_0.state != 0)
                {
                    continue;
                }
                goto Label_009D;
            Label_0054:
                try
                {
                    while (enumerator2.MoveNext())
                    {
                        if (((Class20) enumerator2.Current).state == 1)
                        {
                            num++;
                        }
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator2 as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                }
                if (num <= 4)
                {
                    goto Label_00AF;
                }
                Thread.Sleep(250);
            Label_009D:
                num = 0;
                enumerator2 = this.arrayList_0.GetEnumerator();
                goto Label_0054;
            Label_00AF:
                if (this.customLink.Text.Equals(string.Empty))
                {
                    class2.chromiumWebBrowser_0 = new ChromiumWebBrowser(this.dictionary_0[this.int_0]);
                }
                else
                {
                    class2.chromiumWebBrowser_0 = new ChromiumWebBrowser(this.customLink.Text);
                }
                class2.class53_0.class20_0.state = 1;
                class2.class53_0.class20_0.chromiumWebBrowser_0 = class2.chromiumWebBrowser_0;
                class2.requestContext_0 = new CefSharp.RequestContext();
                if (!class2.class53_0.class20_0.proxy.Equals(string.Empty) && !class2.class53_0.class20_0.proxy.ToLower().Equals("local"))
                {
                    Cef.UIThreadTaskFactory.StartNew(new Action(class2, (IntPtr) this.method_0));
                    if (!class2.class53_0.class20_0.username.Equals(string.Empty))
                    {
                        if (this.blockImg.Checked)
                        {
                            class2.chromiumWebBrowser_0.RequestHandler = new Class45(class2.class53_0.class20_0.username, class2.class53_0.class20_0.password);
                        }
                        else
                        {
                            class2.chromiumWebBrowser_0.RequestHandler = new Class48(class2.class53_0.class20_0.username, class2.class53_0.class20_0.password);
                        }
                    }
                    else if (this.blockImg.Checked)
                    {
                        class2.chromiumWebBrowser_0.RequestHandler = new Class45(string.Empty, string.Empty);
                    }
                }
                else if (this.blockImg.Checked)
                {
                    class2.chromiumWebBrowser_0.RequestHandler = new Class45(string.Empty, string.Empty);
                }
                class2.chromiumWebBrowser_0.RequestContext = class2.requestContext_0;
                class2.panel_0 = new Panel();
                class2.panel_0.Size = new Size(400, 400);
                class2.class53_0.class20_0.panel_0 = class2.panel_0;
                base.Invoke(new MethodInvoker(class2.method_1));
                class2.chromiumWebBrowser_0.Dock = DockStyle.Fill;
            }
        }
    }

    private void method_1()
    {
        foreach (Class20 class2 in this.arrayList_0)
        {
            if (class2.state == 0)
            {
                if (this.customLink.Text.Equals(string.Empty))
                {
                    class2.httpWebRequest_0 = (HttpWebRequest) WebRequest.Create(this.dictionary_0[this.int_0]);
                }
                else
                {
                    try
                    {
                        class2.httpWebRequest_0 = (HttpWebRequest) WebRequest.Create(this.customLink.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid URL!");
                        base.Invoke(new MethodInvoker(this.method_7));
                        if ((this.thread_0 != null) && this.thread_0.IsAlive)
                        {
                            this.thread_0.Abort();
                        }
                        break;
                    }
                }
                if (!class2.proxy.Equals(string.Empty) && !class2.proxy.ToLower().Equals("local"))
                {
                    class2.httpWebRequest_0.Proxy = new WebProxy(class2.proxy);
                    if (!class2.username.Equals(string.Empty))
                    {
                        class2.httpWebRequest_0.Proxy.Credentials = new NetworkCredential(class2.username, class2.password);
                    }
                }
                Class21.smethod_0(ref class2.httpWebRequest_0, false);
                HttpWebResponse response = null;
                class2.httpWebRequest_0.Timeout = 0xfa0;
                try
                {
                    response = (HttpWebResponse) class2.httpWebRequest_0.GetResponse();
                }
                catch (WebException exception)
                {
                    if (exception.Response == null)
                    {
                        class2.state = 11;
                    }
                    else if (((HttpWebResponse) exception.Response).StatusCode == HttpStatusCode.Forbidden)
                    {
                        class2.state = 12;
                    }
                    else
                    {
                        class2.state = 11;
                    }
                    continue;
                }
                foreach (System.Net.Cookie cookie2 in response.Cookies)
                {
                    class2.cookieContainer_0.Add(cookie2);
                }
                string str = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (class2.cookieContainer_0 == null)
                {
                    class2.cookieContainer_0 = new CookieContainer();
                }
                class2.cookieContainer_0.Add(response.Cookies);
                if (str.Contains("data-sitekey"))
                {
                    foreach (System.Net.Cookie cookie in response.Cookies)
                    {
                        if (cookie.Value.Contains("hmac"))
                        {
                            if (class2.dictionary_0.ContainsKey(cookie.Name))
                            {
                                class2.dictionary_0.Remove(cookie.Name);
                            }
                            class2.dictionary_0.Add(cookie.Name, cookie.Value);
                        }
                        if (cookie.Name.Equals("gceeqs"))
                        {
                            class2.string_1 = cookie.Value;
                        }
                    }
                    int startIndex = str.IndexOf("data-sitekey=") + 13;
                    int index = str.IndexOf('"', startIndex);
                    class2.string_0 = str.Substring(startIndex, index - startIndex);
                    class2.action = "Apply this proxy and hmac to all tasks";
                    TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                    class2.long_0 = (long) span.TotalMilliseconds;
                    class2.dateTime_0 = DateTime.Now;
                    class2.state = 15;
                    SoundPlayer player = new SoundPlayer(Class19.smethod_5());
                    if (this.mainForm_0.bool_14)
                    {
                        player.Play();
                    }
                }
                else
                {
                    class2.state = 14;
                }
            }
        }
    }

    private void method_10()
    {
        this.addProxyBtn.Enabled = true;
        this.proxylessButton.Enabled = true;
        this.removeSelectedBtn.Enabled = true;
    }

    private void method_11()
    {
        this.addProxyBtn.Enabled = true;
        this.proxylessButton.Enabled = true;
        this.removeSelectedBtn.Enabled = true;
    }

    private void method_2()
    {
        while (true)
        {
            this.bool_1 = true;
            base.Invoke(new MethodInvoker(this.method_8));
            foreach (Class20 class2 in this.arrayList_0)
            {
                TimeSpan span;
                if (class2.state == 15)
                {
                    span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                    if ((((long) span.TotalMilliseconds) - class2.long_0) > 0x927c0L)
                    {
                        class2.state = 10;
                        class2.action = string.Empty;
                    }
                }
                if ((class2.state != 15) && (class2.state != 0))
                {
                    if (this.customLink.Text.Equals(string.Empty))
                    {
                        class2.httpWebRequest_0 = (HttpWebRequest) WebRequest.Create(this.dictionary_0[this.int_0]);
                    }
                    else
                    {
                        try
                        {
                            class2.httpWebRequest_0 = (HttpWebRequest) WebRequest.Create(this.customLink.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid URL!");
                            base.Invoke(new MethodInvoker(this.method_9));
                            if ((this.thread_0 != null) && this.thread_0.IsAlive)
                            {
                                this.thread_0.Abort();
                            }
                            return;
                        }
                    }
                    class2.httpWebRequest_0.CookieContainer = class2.cookieContainer_0;
                    if (!class2.proxy.Equals(string.Empty) && !class2.proxy.ToLower().Equals("local"))
                    {
                        class2.httpWebRequest_0.Proxy = new WebProxy(class2.proxy);
                        if (!class2.username.Equals(string.Empty))
                        {
                            class2.httpWebRequest_0.Proxy.Credentials = new NetworkCredential(class2.username, class2.password);
                        }
                    }
                    Class21.smethod_0(ref class2.httpWebRequest_0, false);
                    HttpWebResponse response = null;
                    class2.httpWebRequest_0.Timeout = 0xfa0;
                    try
                    {
                        response = (HttpWebResponse) class2.httpWebRequest_0.GetResponse();
                    }
                    catch (WebException exception)
                    {
                        if (exception.Response == null)
                        {
                            class2.state = 11;
                        }
                        else if (((HttpWebResponse) exception.Response).StatusCode == HttpStatusCode.Forbidden)
                        {
                            class2.state = 12;
                        }
                        else
                        {
                            class2.state = 11;
                        }
                        continue;
                    }
                    foreach (System.Net.Cookie cookie2 in response.Cookies)
                    {
                        class2.cookieContainer_0.Add(cookie2);
                    }
                    string str = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    if (str.Contains("data-sitekey"))
                    {
                        foreach (System.Net.Cookie cookie in response.Cookies)
                        {
                            if (cookie.Value.Contains("hmac"))
                            {
                                if (class2.dictionary_0.ContainsKey(cookie.Name))
                                {
                                    class2.dictionary_0.Remove(cookie.Name);
                                }
                                class2.dictionary_0.Add(cookie.Name, cookie.Value);
                            }
                            if (cookie.Name.Equals("gceeqs"))
                            {
                                class2.string_1 = cookie.Value;
                            }
                        }
                        int startIndex = str.IndexOf("data-sitekey=") + 14;
                        int index = str.IndexOf('"', startIndex);
                        class2.string_0 = str.Substring(startIndex, index - startIndex);
                        class2.action = "Apply this proxy and hmac to all tasks";
                        span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                        class2.long_0 = (long) span.TotalMilliseconds;
                        class2.dateTime_0 = DateTime.Now;
                        class2.state = 15;
                        SoundPlayer player = new SoundPlayer(Class19.smethod_5());
                        if (this.mainForm_0.bool_14)
                        {
                            player.Play();
                        }
                    }
                    else
                    {
                        class2.state = 14;
                    }
                }
                if (class2.proxy.ToLower().Equals("local"))
                {
                    Thread.Sleep(0x7d0);
                }
                else
                {
                    Thread.Sleep(10);
                }
            }
            this.bool_1 = false;
            base.Invoke(new MethodInvoker(this.method_10));
            Thread.Sleep(0x1d4c);
        }
    }

    private void method_3()
    {
        int num = 0;
        while (true)
        {
            this.bool_1 = true;
            foreach (Class20 class2 in this.arrayList_0)
            {
                if ((class2.chromiumWebBrowser_0 != null) && (class2.state != 0))
                {
                    TimeSpan span;
                    if ((class2.state == int.Parse(this.string_3)) && !class2.string_1.Equals(string.Empty))
                    {
                        span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                        if ((((long) span.TotalMilliseconds) - class2.long_0) > 0x927c0L)
                        {
                            class2.chromiumWebBrowser_0.Reload();
                            class2.state = -3;
                            class2.action = string.Empty;
                        }
                    }
                    else
                    {
                        TimeSpan? nullable;
                        CookieContainer container = new CookieContainer();
                        bool flag = false;
                        bool flag2 = false;
                        if ((this.smartBtn.Checked && !this.string_5.Equals(string.Empty)) && !this.string_5.Equals("ignore"))
                        {
                            flag2 = true;
                            if (class2.chromiumWebBrowser_0.CanExecuteJavascriptInMainFrame)
                            {
                                nullable = null;
                                Task<JavascriptResponse> task1 = class2.chromiumWebBrowser_0.EvaluateScriptAsync(this.string_5, nullable);
                                task1.Wait();
                                JavascriptResponse response2 = task1.get_Result();
                                if ((response2.Result != null) && response2.Result.ToString().Equals("exists"))
                                {
                                    if (class2.state < 3)
                                    {
                                        class2.state = int.Parse(this.string_2.Substring(0x21, 1));
                                        class2.action = string.Empty;
                                    }
                                }
                                else if (class2.state < 3)
                                {
                                    class2.int_0++;
                                }
                                if (class2.int_0 > 5)
                                {
                                    class2.state = -1;
                                    class2.action = "Reload";
                                }
                            }
                        }
                        if (class2.chromiumWebBrowser_0.CanExecuteJavascriptInMainFrame)
                        {
                            if (this.smartBtn.Checked)
                            {
                                nullable = null;
                                Task<JavascriptResponse> task2 = class2.chromiumWebBrowser_0.EvaluateScriptAsync(this.string_4, nullable);
                                task2.Wait();
                                JavascriptResponse response3 = task2.get_Result();
                                if ((response3.Result != null) && response3.Result.ToString().Equals("exists"))
                                {
                                    class2.state = 6;
                                }
                            }
                            nullable = null;
                            Task<JavascriptResponse> task3 = class2.chromiumWebBrowser_0.EvaluateScriptAsync("document.getElementsByClassName('g-recaptcha')[0].getAttribute('data-sitekey');", nullable);
                            task3.Wait();
                            JavascriptResponse response = task3.get_Result();
                            if ((response.Result != null) && !response.Result.ToString().Equals(string.Empty))
                            {
                                class2.string_0 = response.Result.ToString();
                                if (this.recaptchaRadio.Checked)
                                {
                                    class2.state = 6;
                                }
                            }
                        }
                        Class56 visitor = new Class56();
                        if (class2.chromiumWebBrowser_0.RequestContext.GetDefaultCookieManager(new Class47()).VisitAllCookies(visitor))
                        {
                            visitor.method_0();
                        }
                        foreach (CefSharp.Cookie cookie in visitor.method_1())
                        {
                            if (!cookie.Value.Contains(","))
                            {
                                System.Net.Cookie cookie2 = new System.Net.Cookie {
                                    Name = cookie.Name
                                };
                                if (cookie.Name.Equals(this.string_0) && (class2.state == 6))
                                {
                                    class2.string_1 = cookie.Value;
                                    class2.action = "Apply this proxy and hmac to all tasks";
                                    span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                                    class2.long_0 = (long) span.TotalMilliseconds;
                                    class2.dateTime_0 = DateTime.Now;
                                    class2.state = 3;
                                    SoundPlayer player = new SoundPlayer(Class19.smethod_5());
                                    if (this.mainForm_0.bool_14)
                                    {
                                        player.Play();
                                    }
                                }
                                if (cookie.Name.Equals("gceeqs") && (class2.state == 6))
                                {
                                    class2.string_1 = cookie.Value;
                                    class2.action = "Apply this proxy and hmac to all tasks";
                                    span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                                    class2.long_0 = (long) span.TotalMilliseconds;
                                    class2.dateTime_0 = DateTime.Now;
                                    class2.state = 3;
                                    SoundPlayer player2 = new SoundPlayer(Class19.smethod_5());
                                    if (this.mainForm_0.bool_14)
                                    {
                                        player2.Play();
                                    }
                                }
                                if (cookie.Value.Contains("hmac"))
                                {
                                    if (class2.state == 6)
                                    {
                                        class2.action = "Apply this proxy and hmac to all tasks";
                                        span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                                        class2.long_0 = (long) span.TotalMilliseconds;
                                        class2.dateTime_0 = DateTime.Now;
                                        class2.state = 3;
                                        SoundPlayer player3 = new SoundPlayer(Class19.smethod_5());
                                        if (this.mainForm_0.bool_14)
                                        {
                                            player3.Play();
                                        }
                                    }
                                    if (!class2.dictionary_0.ContainsKey(cookie.Name))
                                    {
                                        class2.dictionary_0.Add(cookie.Name, cookie.Value);
                                    }
                                    else
                                    {
                                        class2.dictionary_0[cookie.Name] = cookie.Value;
                                    }
                                }
                                else if ((cookie.Name.Equals(this.string_0) && (class2.state != 6)) && this.recaptchaRadio.Checked)
                                {
                                    class2.string_1 = cookie.Value;
                                    class2.state = 5;
                                    span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                                    class2.long_0 = (long) span.TotalMilliseconds;
                                    class2.dateTime_0 = DateTime.Now;
                                }
                                else if (cookie.Name.Equals(this.string_0) && this.hmacRadio.Checked)
                                {
                                    class2.state = 3;
                                    class2.string_1 = cookie.Value;
                                    class2.action = "Apply this proxy and hmac to all tasks";
                                    span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                                    class2.long_0 = (long) span.TotalMilliseconds;
                                    class2.dateTime_0 = DateTime.Now;
                                    SoundPlayer player4 = new SoundPlayer(Class19.smethod_5());
                                    if (this.mainForm_0.bool_14)
                                    {
                                        player4.Play();
                                    }
                                }
                                else if (cookie.Name.Equals(this.string_0) && this.smartBtn.Checked)
                                {
                                    class2.string_1 = cookie.Value;
                                    span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                                    class2.long_0 = (long) span.TotalMilliseconds;
                                    class2.dateTime_0 = DateTime.Now;
                                }
                                if (cookie.Name.Contains(this.string_1))
                                {
                                    flag = true;
                                }
                                cookie2.Value = cookie.Value;
                                cookie2.Domain = cookie.Domain;
                                cookie2.Path = cookie.Path;
                                cookie2.Secure = cookie.Secure;
                                if (cookie.Expires.HasValue)
                                {
                                    cookie2.Expires = cookie.Expires.Value;
                                }
                                container.Add(cookie2);
                            }
                        }
                        class2.cookieContainer_0 = container;
                        if (!flag2)
                        {
                            if (!flag && (class2.state < 3))
                            {
                                class2.int_0++;
                            }
                            else if (class2.state < 3)
                            {
                                class2.state = int.Parse(this.string_2.Substring(0x21, 1));
                                class2.action = string.Empty;
                            }
                            if (class2.int_0 > 5)
                            {
                                class2.state = -1;
                                class2.action = "Reload";
                            }
                        }
                    }
                }
            }
            num++;
            this.bool_1 = false;
            Thread.Sleep(0x1388);
        }
    }

    private void method_4(object sender, FormatRowEventArgs e)
    {
        Class20 model = (Class20) e.Model;
        if (model.state != 0)
        {
            if (model.state == -1)
            {
                e.Item.BackColor = Color.Red;
            }
            if (model.state == 2)
            {
                e.Item.BackColor = Color.Yellow;
            }
            if (model.state == int.Parse(this.string_3))
            {
                e.Item.BackColor = Color.Green;
            }
            if (((model.state == 4) || (model.state == 5)) || (model.state == 6))
            {
                e.Item.BackColor = Color.LightGreen;
            }
            if ((model.state == 11) || (model.state == 12))
            {
                e.Item.BackColor = Color.Red;
            }
            if (model.state == 14)
            {
                e.Item.BackColor = Color.Yellow;
            }
            if (model.state == 15)
            {
                e.Item.BackColor = Color.Green;
            }
        }
    }

    public void method_5()
    {
        while (true)
        {
            this.taskOListView.SetObjects(this.arrayList_0);
            if (!this.thread_2.IsAlive && !this.bool_1)
            {
                base.Invoke(new MethodInvoker(this.method_11));
            }
            Thread.Sleep(500);
        }
    }

    private void method_6(object sender, CellRightClickEventArgs e)
    {
        Class54 class2 = new Class54 {
            splashForceForm_0 = this,
            class20_0 = (Class20) e.Model
        };
        if (class2.class20_0 != null)
        {
            e.MenuStrip = new ContextMenuStrip();
            e.MenuStrip.Items.Add("Test proxy");
            e.MenuStrip.Items[0].Click += new EventHandler(class2.method_0);
            if (!this.bool_2)
            {
                e.MenuStrip.Items.Add("View browser");
                e.MenuStrip.Items[e.MenuStrip.Items.Count - 1].Click += new EventHandler(class2.method_1);
            }
            if ((class2.class20_0.state != 0) && (class2.class20_0.state == int.Parse(this.string_3)))
            {
                e.MenuStrip.Items.Add("Copy HMAC to Clipboard");
                e.MenuStrip.Items[e.MenuStrip.Items.Count - 1].Click += new EventHandler(class2.method_2);
            }
            if (!class2.class20_0.string_1.Equals(string.Empty))
            {
                e.MenuStrip.Items.Add("Apply HMAC");
                e.MenuStrip.Items[e.MenuStrip.Items.Count - 1].Click += new EventHandler(class2.method_3);
            }
            if (!class2.class20_0.string_0.Equals(string.Empty))
            {
                e.MenuStrip.Items.Add("Apply Sitekey");
                e.MenuStrip.Items[e.MenuStrip.Items.Count - 1].Click += new EventHandler(class2.method_4);
            }
        }
    }

    private void method_7()
    {
        this.button1.Text = "Start Brute Forcer";
        this.bool_0 = false;
        this.customLink.Enabled = true;
        this.addProxyBtn.Enabled = true;
        this.massButton.Enabled = true;
        this.proxylessButton.Enabled = true;
        this.removeSelectedBtn.Enabled = true;
        this.autoRefreshBox.Enabled = true;
    }

    private void method_8()
    {
        this.addProxyBtn.Enabled = false;
        this.proxylessButton.Enabled = false;
        this.massButton.Enabled = false;
        this.removeSelectedBtn.Enabled = false;
    }

    private void method_9()
    {
        this.button1.Text = "Start Brute Forcer";
        this.bool_0 = false;
        this.customLink.Enabled = true;
        this.addProxyBtn.Enabled = true;
        this.massButton.Enabled = true;
        this.proxylessButton.Enabled = true;
        this.removeSelectedBtn.Enabled = true;
        this.autoRefreshBox.Enabled = true;
    }

    private void proxylessButton_Click(object sender, EventArgs e)
    {
        while (this.bool_1)
        {
            Thread.Sleep(250);
        }
        int num = this.int_1 + 1;
        this.int_1 = num;
        this.arrayList_0.Add(new Class20(num, "local"));
        this.taskOListView.SetObjects(this.arrayList_0);
        if (this.bool_0 && !this.thread_2.IsAlive)
        {
            this.thread_2 = new Thread(new ThreadStart(this.method_0));
            this.thread_2.Start();
            this.addProxyBtn.Enabled = false;
            this.proxylessButton.Enabled = false;
            this.removeSelectedBtn.Enabled = false;
        }
    }

    private void removeSelectedBtn_Click(object sender, EventArgs e)
    {
        while (this.bool_1)
        {
            Thread.Sleep(250);
        }
        for (int i = 0; i < this.taskOListView.SelectedObjects.Count; i++)
        {
            this.arrayList_0.Remove(this.taskOListView.SelectedObjects[i]);
        }
        this.taskOListView.SetObjects(this.arrayList_0);
    }

    private void SplashForceForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((this.thread_2 != null) && this.thread_2.IsAlive)
        {
            this.thread_2.Abort();
        }
        if ((this.thread_1 != null) && this.thread_1.IsAlive)
        {
            this.thread_1.Abort();
        }
        if ((this.thread_0 != null) && this.thread_0.IsAlive)
        {
            this.thread_0.Abort();
        }
    }

    private void SplashForceForm_Load(object sender, EventArgs e)
    {
    }

    private void taskOListView_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void testProxyButton_Click(object sender, EventArgs e)
    {
        if (this.proxyBox.Text.Equals(string.Empty))
        {
            MessageBox.Show("Please enter a proxy server to test it.");
        }
        else
        {
            HttpWebResponse response = null;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(new UriBuilder(this.dictionary_0[this.int_0]).Uri);
            Class21.smethod_0(ref request, true);
            request.Method = "GET";
            request.Timeout = 0x1d4c;
            request.CookieContainer = new CookieContainer();
            if (this.proxyBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("No Proxy entered!");
            }
            else
            {
                request.Proxy = new WebProxy(this.proxyBox.Text);
                if (!this.proxyUsernameBox.Text.Equals(string.Empty))
                {
                    request.Proxy.Credentials = new NetworkCredential(this.proxyUsernameBox.Text, this.proxyPWBox.Text);
                }
                try
                {
                    response = (HttpWebResponse) request.GetResponse();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Proxy server test failed with error: " + exception.Message);
                    if (response != null)
                    {
                        response.Close();
                    }
                    return;
                }
                response.Close();
                MessageBox.Show("Proxy server test successful!");
            }
        }
    }

    [Serializable]
    private sealed class Class49
    {
        public static readonly SplashForceForm.Class49 class49_0 = new SplashForceForm.Class49();
        public static GroupKeyGetterDelegate groupKeyGetterDelegate_0;
        public static GroupKeyGetterDelegate groupKeyGetterDelegate_1;

        internal object method_0(object object_0) => 
            "Idle";

        internal object method_1(object object_0) => 
            "Idle";
    }

    private sealed class Class50
    {
        public MainForm mainForm_0;
        public SplashForceForm splashForceForm_0;

        internal void method_0(object sender, CellClickEventArgs e)
        {
            Class20 model = (Class20) e.Model;
            if (model.state == -1)
            {
                if (this.splashForceForm_0.customLink.Text.Equals(string.Empty))
                {
                    model.chromiumWebBrowser_0.Load(this.splashForceForm_0.dictionary_0[this.splashForceForm_0.int_0]);
                }
                else
                {
                    model.chromiumWebBrowser_0.Load(this.splashForceForm_0.customLink.Text);
                }
                model.state = 1;
                model.action = string.Empty;
                model.bool_0 = true;
                model.int_0 = 0;
                model.int_1 = 0;
            }
            else if (model.state == int.Parse(this.splashForceForm_0.string_3))
            {
                this.mainForm_0.method_38(model.proxy, model.username, model.password);
                if (!model.string_0.Equals(string.Empty))
                {
                    this.mainForm_0.method_39(model.string_0);
                }
                if (!model.string_1.Equals(string.Empty))
                {
                    this.mainForm_0.method_40(model.string_1, model.dateTime_0);
                }
                if (model.dictionary_0.Count > 0)
                {
                    this.mainForm_0.method_41(model.dictionary_0);
                }
                model.action = "Apply this proxy again";
                MessageBox.Show("Successfully applied sitekey, hmac and proxy to all tasks!");
            }
            else if (model.state == 15)
            {
                this.mainForm_0.method_38(model.proxy, model.username, model.password);
                if (!model.string_0.Equals(string.Empty))
                {
                    this.mainForm_0.method_39(model.string_0);
                }
                if (!model.string_1.Equals(string.Empty))
                {
                    this.mainForm_0.method_40(model.string_1, model.dateTime_0);
                }
                if (model.dictionary_0.Count > 0)
                {
                    this.mainForm_0.method_41(model.dictionary_0);
                }
                model.action = "Apply this proxy again";
                MessageBox.Show("Successfully applied sitekey, hmac and proxy to all tasks!");
            }
        }
    }

    private sealed class Class51
    {
        public MainForm mainForm_0;
        public SplashForceForm splashForceForm_0;

        internal void method_0(object sender, CellClickEventArgs e)
        {
            Class20 model = (Class20) e.Model;
            if (model.state == -1)
            {
                if (this.splashForceForm_0.customLink.Text.Equals(string.Empty))
                {
                    model.chromiumWebBrowser_0.Load(this.splashForceForm_0.dictionary_0[this.splashForceForm_0.int_0]);
                }
                else
                {
                    model.chromiumWebBrowser_0.Load(this.splashForceForm_0.customLink.Text);
                }
                model.state = 1;
                model.action = string.Empty;
                model.bool_0 = true;
                model.int_0 = 0;
                model.int_1 = 0;
            }
            else if (model.state == int.Parse(this.splashForceForm_0.string_3))
            {
                this.mainForm_0.method_38(model.proxy, model.username, model.password);
                if (!model.string_0.Equals(string.Empty))
                {
                    this.mainForm_0.method_39(model.string_0);
                }
                if (!model.string_1.Equals(string.Empty))
                {
                    this.mainForm_0.method_40(model.string_1, model.dateTime_0);
                }
                if (model.dictionary_0.Count > 0)
                {
                    this.mainForm_0.method_41(model.dictionary_0);
                }
                model.action = "Apply this proxy again";
                MessageBox.Show("Successfully applied sitekey, hmac and proxy to all tasks!");
            }
            else if (model.state == 15)
            {
                this.mainForm_0.method_38(model.proxy, model.username, model.password);
                if (!model.string_0.Equals(string.Empty))
                {
                    this.mainForm_0.method_39(model.string_0);
                }
                if (!model.string_1.Equals(string.Empty))
                {
                    this.mainForm_0.method_40(model.string_1, model.dateTime_0);
                }
                if (model.dictionary_0.Count > 0)
                {
                    this.mainForm_0.method_41(model.dictionary_0);
                }
                model.action = "Apply this proxy again";
                MessageBox.Show("Successfully applied sitekey, hmac and proxy to all tasks!");
            }
        }
    }

    private sealed class Class52
    {
        public ChromiumWebBrowser chromiumWebBrowser_0;
        public SplashForceForm.Class53 class53_0;
        public Panel panel_0;
        public CefSharp.RequestContext requestContext_0;

        internal void method_0()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object> {
                ["mode"] = "fixed_servers",
                ["server"] = this.class53_0.class20_0.proxy
            };
            string error = string.Empty;
            this.requestContext_0.SetPreference("proxy", dictionary, out error);
            if (error != string.Empty)
            {
                MessageBox.Show(error);
            }
        }

        internal void method_1()
        {
            this.class53_0.splashForceForm_0.Controls.Add(this.panel_0);
            this.panel_0.Controls.Add(this.chromiumWebBrowser_0);
            this.panel_0.Visible = false;
        }
    }

    private sealed class Class53
    {
        public Class20 class20_0;
        public SplashForceForm splashForceForm_0;
    }

    private sealed class Class54
    {
        public Class20 class20_0;
        public SplashForceForm splashForceForm_0;

        internal void method_0(object sender, EventArgs e)
        {
            if (!this.class20_0.proxy.Equals("local"))
            {
                HttpWebResponse response = null;
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(new UriBuilder(this.splashForceForm_0.dictionary_0[this.splashForceForm_0.int_0]).Uri);
                Class21.smethod_0(ref request, true);
                request.Method = "GET";
                request.Timeout = 0x2710;
                request.CookieContainer = new CookieContainer();
                if (this.class20_0.proxy.Equals(string.Empty))
                {
                    MessageBox.Show("No proxy to test!");
                }
                else
                {
                    request.Proxy = new WebProxy(this.class20_0.proxy);
                    if (!this.class20_0.username.Equals(string.Empty))
                    {
                        request.Proxy.Credentials = new NetworkCredential(this.class20_0.username, this.class20_0.password);
                    }
                    try
                    {
                        response = (HttpWebResponse) request.GetResponse();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Proxy server test failed with error: " + exception.Message);
                        if (response != null)
                        {
                            response.Close();
                        }
                        return;
                    }
                    response.Close();
                    MessageBox.Show("Proxy server test successful!");
                }
            }
        }

        internal void method_1(object sender, EventArgs e)
        {
            if ((this.class20_0.chromiumWebBrowser_0 != null) && this.class20_0.chromiumWebBrowser_0.IsBrowserInitialized)
            {
                SpyBrowser browser = new SpyBrowser {
                    Text = "Splash Brute Forcer Task " + this.class20_0.id.ToString(),
                    panel_0 = this.class20_0.panel_0
                };
                browser.panel_0.Size = new Size(browser.Size.Width, browser.Size.Height);
                browser.chromiumWebBrowser_0 = this.class20_0.chromiumWebBrowser_0;
                browser.Controls.Add(browser.panel_0);
                browser.panel_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
                browser.mainForm_0 = this.splashForceForm_0.mainForm_0;
                this.class20_0.panel_0.Visible = true;
                browser.Show();
            }
        }

        internal void method_2(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.class20_0.string_1);
        }

        internal void method_3(object sender, EventArgs e)
        {
            this.splashForceForm_0.mainForm_0.method_38(this.class20_0.proxy, this.class20_0.username, this.class20_0.password);
            this.splashForceForm_0.mainForm_0.method_40(this.class20_0.string_1, this.class20_0.dateTime_0);
            if (this.class20_0.dictionary_0.Count > 0)
            {
                this.splashForceForm_0.mainForm_0.method_41(this.class20_0.dictionary_0);
            }
        }

        internal void method_4(object sender, EventArgs e)
        {
            this.splashForceForm_0.mainForm_0.method_39(this.class20_0.string_0);
        }
    }
}

