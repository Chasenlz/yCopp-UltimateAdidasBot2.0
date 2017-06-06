using BrightIdeasSoftware;
using CefSharp;
using CefSharp.WinForms;
using HtmlAgilityPack;
using Polenter.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using wyDay.Controls;
using yCopp_UltimateAdidasBot;

public sealed class MainForm : Form
{
    private ToolStripMenuItem addAdidasAccountsToolStripMenuItem;
    private Button addAndStartButton;
    private Button addTaskButton;
    private Label adidasAccountLabel;
    private CheckBox adidasAccountsCheck;
    private ToolStripMenuItem advancedToolStripMenuItem;
    private RadioButton alternative2Radio;
    private RadioButton alternativeRadio;
    private Button anticaptchaButton;
    private ToolStripMenuItem antiCaptchaSetupToolStripMenuItem;
    public ArrayList arrayList_0;
    public ArrayList arrayList_1;
    public ArrayList arrayList_2;
    public ArrayList arrayList_3;
    public ArrayList arrayList_4;
    public ArrayList arrayList_5;
    private CheckBox autoCheckoutCheckBox;
    private CheckBox automaticKeyBox;
    private AutomaticUpdater automaticUpdater1;
    private CheckBox autoStart;
    private Button autoUpdateButton;
    private BackgroundWorker backgroundWorker_0;
    private BackgroundWorker backgroundWorker_1;
    private BackgroundWorker backgroundWorker_2;
    public bool bool_0;
    public bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_13;
    public bool bool_14;
    public bool bool_2;
    public volatile bool bool_3;
    public bool bool_4;
    public bool bool_5;
    public bool bool_6;
    public bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private BrowserForm browserForm_0;
    private Button browserHarvesterButton;
    private Button button1;
    private Button button2;
    private Button cancelTasksButton;
    private TextBox captchaDuplicateBox;
    private Panel captchaDupPanel;
    private ToolStripMenuItem checkForUpdateToolStripMenuItem;
    private ComboBox checkoutProfileBox;
    private ToolStripMenuItem checkProductStockToolStripMenuItem;
    public ChromiumWebBrowser chromiumWebBrowser_0;
    private FastObjectListView completedTaskOListView;
    private ToolStripMenuItem cookie10Interval;
    private CookieContainer cookieContainer_0;
    private Button copyButton;
    public DateTime dateTime_0;
    private CheckBox deleteCompletedBox;
    private ToolStripMenuItem devHideAutoCheckoutToolStripMenuItem;
    private Dictionary<int, string> dictionary_0;
    private Dictionary<int, string> dictionary_1;
    private Dictionary<int, string> dictionary_10;
    private Dictionary<int, string> dictionary_11;
    private Dictionary<int, string> dictionary_12;
    private Dictionary<int, string> dictionary_13;
    private Dictionary<int, string> dictionary_14;
    private Dictionary<int, string> dictionary_15;
    private Dictionary<int, string> dictionary_2;
    private Dictionary<int, string> dictionary_3;
    private Dictionary<int, string> dictionary_4;
    private Dictionary<int, string> dictionary_5;
    private Dictionary<int, string> dictionary_6;
    private Dictionary<int, string> dictionary_7;
    public Dictionary<int, string> dictionary_8;
    public Dictionary<int, string> dictionary_9;
    private ToolStripMenuItem disableCookiePreloadToolStripMenuItem;
    private ToolStripMenuItem enableSmallScreenModeToolStripMenuItem;
    private Label expiringLabel;
    private ToolStripMenuItem fetchAPIKeyFromProductPageToolStripMenuItem;
    private ToolStripMenuItem fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem;
    private GClass5 gclass5_0;
    private ToolStripMenuItem getNewsToolStripMenuItem;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem hideLicenseNameToolStripMenuItem;
    private CheckBox hmacBox;
    private Label hmacExpireLabel;
    private Label hmacLabel;
    private IContainer icontainer_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public int int_8;
    public int int_9;
    private Label label1;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label2;
    private Label label21;
    private Label label22;
    private Label label23;
    private Label label24;
    private Label label25;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    public ListViewGroup listViewGroup_0;
    public ListViewGroup listViewGroup_1;
    private ToolStripMenuItem loadSetupForNextReleaseToolStripMenuItem;
    private ComboBox locationComboBox;
    private ToolStripMenuItem manageAutoCheckoutProfilesToolStripMenuItem;
    private ToolStripMenuItem manuallySetToolStripMenuItem;
    private ManualResetEvent manualResetEvent_0;
    private TextBox manualTextBox;
    private MenuStrip menuStrip1;
    private Button metroButton1;
    private TabControl metroTabControl1;
    private TabPage metroTabPage1;
    private TabPage metroTabPage2;
    private CheckBox needsCaptcha;
    private Button nmdPreloadButton;
    private RadioButton normalRadio;
    private OLVColumn olvcolumn_0;
    private OLVColumn olvcolumn_1;
    private OLVColumn olvcolumn_10;
    private OLVColumn olvcolumn_11;
    private OLVColumn olvcolumn_12;
    private OLVColumn olvcolumn_13;
    private OLVColumn olvcolumn_14;
    private OLVColumn olvcolumn_15;
    private OLVColumn olvcolumn_16;
    private OLVColumn olvcolumn_17;
    private OLVColumn olvcolumn_18;
    private OLVColumn olvcolumn_19;
    private OLVColumn olvcolumn_2;
    private OLVColumn olvcolumn_3;
    private OLVColumn olvcolumn_4;
    private OLVColumn olvcolumn_5;
    private OLVColumn olvcolumn_6;
    private OLVColumn olvcolumn_7;
    private OLVColumn olvcolumn_8;
    private OLVColumn olvcolumn_9;
    private Panel panel1;
    private Panel panel2;
    private PictureBox pictureBox1;
    private TextBox pidBox;
    private TextBox proxyBox;
    private TextBox proxyPWBox;
    private TextBox proxyUsernameBox;
    private Queue<Class18> queue_0;
    private Button removeAllButton;
    private Button removeHmacBtn;
    private Button removeSelectedButton;
    private ToolStripMenuItem resetMachineBindingToolStripMenuItem;
    private CheckBox retryBox;
    private Button saveDefaultButton;
    private ToolStripMenuItem sendProductCountRequest;
    private ToolStripMenuItem setCustomPreloadLinkToolStripMenuItem;
    private ToolStripMenuItem setCustomUserAgentToolStripMenuItem;
    private ToolStripMenuItem setTaskDelayToolStripMenuItem;
    private ToolStripMenuItem settingsToolStripMenuItem;
    private ToolStripMenuItem setup2CaptchaToolStripMenuItem;
    private ComboBox sizeComboBox;
    private CheckBox soundBox;
    private ToolStripMenuItem splashBruteForcerToolStripMenuItem;
    private ToolStripMenuItem splashPageBruteForcerRequestsToolStripMenuItem;
    private RadioButton splashRadio;
    private Button startAllButton;
    private Button startSelectedButton;
    private TextBox statusBox;
    public string string_0;
    public string string_1;
    public string string_10;
    public string string_11;
    public string string_12;
    public string string_13;
    public string string_14;
    public string string_15;
    public string string_16;
    public string string_17;
    public string string_18;
    public string string_19;
    private string string_2;
    private string string_20;
    public string[] string_21;
    public string[] string_22;
    public string string_23;
    public string string_24;
    public string string_25;
    public string string_26;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    public string string_7;
    public string string_8;
    public string string_9;
    private Button swapSizeButton;
    private Panel taskButtonsPanel;
    private Label taskDelayLabel;
    private FastObjectListView taskOListView;
    private Button testProxyButton;
    private Thread thread_0;
    private Thread thread_1;
    private Thread thread_10;
    public Thread thread_11;
    private Thread thread_2;
    private Thread thread_3;
    private Thread thread_4;
    private Thread thread_5;
    private Thread thread_6;
    private Thread thread_7;
    private Thread thread_8;
    private Thread thread_9;
    private Label timeLabel;
    private DateTimePicker timePicker;
    private Label tokenCountLabel;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private Button twoCaptchaButton;
    private Button updateAllButton;
    private Button updateButton;
    private Button updateDuplicateManual;
    private Label updateNotifyLabel;
    private ToolStripMenuItem useDefaultMethod;

    public MainForm()
    {
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/default/Cart-MiniAddProduct"
            },
            {
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/default/Cart-MiniAddProduct"
            },
            {
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/default/Cart-MiniAddProduct"
            },
            {
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/default/Cart-MiniAddProduct"
            },
            {
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/default/Cart-MiniAddProduct"
            },
            {
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/default/Cart-MiniAddProduct"
            },
            {
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/default/Cart-MiniAddProduct"
            },
            {
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/default/Cart-MiniAddProduct"
            },
            {
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/default/Cart-MiniAddProduct"
            },
            {
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/default/Cart-MiniAddProduct"
            },
            {
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/default/Cart-MiniAddProduct"
            },
            {
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/default/Cart-MiniAddProduct"
            },
            {
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/default/Cart-MiniAddProduct"
            },
            {
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/default/Cart-MiniAddProduct"
            },
            {
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/default/Cart-MiniAddProduct"
            },
            {
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/default/Cart-MiniAddProduct"
            },
            {
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/default/Cart-MiniAddProduct"
            },
            {
                0x11,
                "http://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/default/Cart-MiniAddProduct"
            },
            {
                0x12,
                "http://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/default/Cart-MiniAddProduct"
            },
            {
                0x13,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/default/Cart-MiniAddProduct"
            }
        };
        this.dictionary_0 = dictionary1;
        Dictionary<int, string> dictionary2 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/Cart-MiniAddProduct"
            },
            {
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/nl_NL/Cart-MiniAddProduct"
            },
            {
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/fr_FR/Cart-MiniAddProduct"
            },
            {
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/es_ES/Cart-MiniAddProduct"
            },
            {
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/it_IT/Cart-MiniAddProduct"
            },
            {
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/Cart-MiniAddProduct"
            },
            {
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/Cart-MiniAddProduct"
            },
            {
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/Cart-MiniAddProduct"
            },
            {
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/Cart-MiniAddProduct"
            },
            {
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/Cart-MiniAddProduct"
            },
            {
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/Cart-MiniAddProduct"
            },
            {
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/Cart-MiniAddProduct"
            },
            {
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/Cart-MiniAddProduct"
            },
            {
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/Cart-MiniAddProduct"
            },
            {
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/Cart-MiniAddProduct"
            },
            {
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/Cart-MiniAddProduct"
            },
            {
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/Cart-MiniAddProduct"
            },
            {
                0x11,
                "http://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/Cart-MiniAddProduct"
            },
            {
                0x12,
                "http://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/Cart-MiniAddProduct"
            },
            {
                0x13,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/Cart-MiniAddProduct"
            }
        };
        this.dictionary_1 = dictionary2;
        Dictionary<int, string> dictionary3 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/CODelivery-RedirectToPaypal"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/CODelivery-RedirectToPaypal"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/CODelivery-RedirectToPaypal"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/CODelivery-RedirectToPaypal"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/CODelivery-RedirectToPaypal"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/CODelivery-RedirectToPaypal"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/CODelivery-RedirectToPaypal"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/CODelivery-RedirectToPaypal"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/CODelivery-RedirectToPaypal"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/CODelivery-RedirectToPaypal"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/CODelivery-RedirectToPaypal"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/CODelivery-RedirectToPaypal"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/CODelivery-RedirectToPaypal"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/CODelivery-RedirectToPaypal"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/CODelivery-RedirectToPaypal"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/CODelivery-RedirectToPaypal"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/CODelivery-RedirectToPaypal"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/CODelivery-RedirectToPaypal"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/CODelivery-RedirectToPaypal"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/CODelivery-RedirectToPaypal"
            }
        };
        this.dictionary_2 = dictionary3;
        Dictionary<int, string> dictionary4 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/COSummary-Start"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/COSummary-Start"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/COSummary-Start"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/COSummary-Start"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/COSummary-Start"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/COSummary-Start"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/COSummary-Start"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/COSummary-Start"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/COSummary-Start"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/COSummary-Start"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/COSummary-Start"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/COSummary-Start"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/COSummary-Start"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/COSummary-Start"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/COSummary-Start"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/COSummary-Start"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/COSummary-Start"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/COSummary-Start"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/COSummary-Start"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/COSummary-Start"
            }
        };
        this.dictionary_3 = dictionary4;
        Dictionary<int, string> dictionary5 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/Cart-Show"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/Cart-Show"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/Cart-Show"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/Cart-Show"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/Cart-Show"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/Cart-Show"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/Cart-Show"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/Cart-Show"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/Cart-Show"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/Cart-Show"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/Cart-Show"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/Cart-Show"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/Cart-Show"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/Cart-Show"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/Cart-Show"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/Cart-Show"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/Cart-Show"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/Cart-Show"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/Cart-Show"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/Cart-Show"
            }
        };
        this.dictionary_4 = dictionary5;
        Dictionary<int, string> dictionary6 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de"
            },
            {
                1,
                "http://www.adidas.nl"
            },
            {
                2,
                "http://www.adidas.fr"
            },
            {
                3,
                "http://www.adidas.es"
            },
            {
                4,
                "http://www.adidas.it"
            },
            {
                5,
                "http://www.adidas.co.uk"
            },
            {
                6,
                "http://www.adidas.com"
            },
            {
                7,
                "http://www.adidas.ca"
            },
            {
                8,
                "http://www.adidas.com.au"
            },
            {
                9,
                "http://www.adidas.at"
            },
            {
                10,
                "http://www.adidas.be"
            },
            {
                11,
                "http://www.adidas.se"
            },
            {
                12,
                "http://www.adidas.dk"
            },
            {
                13,
                "http://www.adidas.no"
            },
            {
                14,
                "http://www.adidas.pl"
            },
            {
                15,
                "http://www.adidas.cz"
            },
            {
                0x10,
                "http://www.adidas.co.nz"
            },
            {
                0x11,
                "http://www.adidas.ru"
            },
            {
                0x12,
                "http://www.adidas.mx"
            },
            {
                0x13,
                "http://www.adidas.com"
            }
        };
        this.dictionary_5 = dictionary6;
        Dictionary<int, string> dictionary7 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de"
            },
            {
                1,
                "http://www.adidas.nl"
            },
            {
                2,
                "http://www.adidas.fr"
            },
            {
                3,
                "http://www.adidas.es"
            },
            {
                4,
                "http://www.adidas.it"
            },
            {
                5,
                "http://www.adidas.co.uk"
            },
            {
                6,
                "http://www.adidas.com/us"
            },
            {
                7,
                "http://www.adidas.ca"
            },
            {
                8,
                "http://www.adidas.com.au"
            },
            {
                9,
                "http://www.adidas.at"
            },
            {
                10,
                "http://www.adidas.be"
            },
            {
                11,
                "http://www.adidas.se"
            },
            {
                12,
                "http://www.adidas.dk"
            },
            {
                13,
                "http://www.adidas.no"
            },
            {
                14,
                "http://www.adidas.pl"
            },
            {
                15,
                "http://www.adidas.cz"
            },
            {
                0x10,
                "http://www.adidas.co.nz"
            },
            {
                0x11,
                "http://www.adidas.ru"
            },
            {
                0x12,
                "http://www.adidas.mx"
            },
            {
                0x13,
                "http://www.adidas.com"
            }
        };
        this.dictionary_6 = dictionary7;
        Dictionary<int, string> dictionary8 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/Cart-ProductCount"
            },
            {
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/Cart-ProductCount"
            },
            {
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/Cart-ProductCount"
            },
            {
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/Cart-ProductCount"
            },
            {
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/Cart-ProductCount"
            },
            {
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/Cart-ProductCount"
            },
            {
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/Cart-ProductCount"
            },
            {
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/Cart-ProductCount"
            },
            {
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/Cart-ProductCount"
            },
            {
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/Cart-ProductCount"
            },
            {
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/Cart-ProductCount"
            },
            {
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/Cart-ProductCount"
            },
            {
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/Cart-ProductCount"
            },
            {
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/Cart-ProductCount"
            },
            {
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/Cart-ProductCount"
            },
            {
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/Cart-ProductCount"
            },
            {
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/Cart-ProductCount"
            },
            {
                0x11,
                "http://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/Cart-ProductCount"
            },
            {
                0x12,
                "http://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/Cart-ProductCount"
            },
            {
                0x13,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/Cart-ProductCount"
            }
        };
        this.dictionary_7 = dictionary8;
        Dictionary<int, string> dictionary9 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/"
            }
        };
        this.dictionary_8 = dictionary9;
        Dictionary<int, string> dictionary10 = new Dictionary<int, string> {
            {
                0,
                "adidas.de"
            },
            {
                1,
                "adidas.nl"
            },
            {
                2,
                "adidas.fr"
            },
            {
                3,
                "adidas.es"
            },
            {
                4,
                "adidas.it"
            },
            {
                5,
                "adidas.co.uk"
            },
            {
                6,
                "adidas.com"
            },
            {
                7,
                "adidas.ca"
            },
            {
                8,
                "adidas.com.au"
            },
            {
                9,
                "adidas.at"
            },
            {
                10,
                "adidas.be"
            },
            {
                11,
                "adidas.se"
            },
            {
                12,
                "adidas.dk"
            },
            {
                13,
                "adidas.no"
            },
            {
                14,
                "adidas.pl"
            },
            {
                15,
                "adidas.cz"
            },
            {
                0x10,
                "adidas.co.nz"
            },
            {
                0x11,
                "adidas.ru"
            },
            {
                0x12,
                "adidas.mx"
            },
            {
                0x13,
                "adidas.com"
            }
        };
        this.dictionary_9 = dictionary10;
        Dictionary<int, string> dictionary11 = new Dictionary<int, string> {
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
                "http://www.adidas.com/yeezy"
            }
        };
        this.dictionary_10 = dictionary11;
        Dictionary<int, string> dictionary12 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/nmd"
            },
            {
                1,
                "http://www.adidas.nl/nmd"
            },
            {
                2,
                "http://www.adidas.fr/nmd"
            },
            {
                3,
                "http://www.adidas.es/nmd"
            },
            {
                4,
                "http://www.adidas.it/nmd"
            },
            {
                5,
                "http://www.adidas.co.uk/nmd"
            },
            {
                6,
                "http://www.adidas.com/nmd"
            },
            {
                7,
                "http://www.adidas.ca/nmd"
            },
            {
                8,
                "http://www.adidas.com.au/nmd"
            },
            {
                9,
                "http://www.adidas.at/nmd"
            },
            {
                10,
                "http://www.adidas.be/nmd"
            },
            {
                11,
                "http://www.adidas.se/nmd"
            },
            {
                12,
                "http://www.adidas.dk/nmd"
            },
            {
                13,
                "http://www.adidas.no/nmd"
            },
            {
                14,
                "http://www.adidas.pl/nmd"
            },
            {
                15,
                "http://www.adidas.cz/nmd"
            },
            {
                0x10,
                "http://www.adidas.co.nz/nmd"
            },
            {
                0x11,
                "http://www.adidas.ru/nmd"
            },
            {
                0x12,
                "http://www.adidas.mx/nmd"
            },
            {
                0x13,
                "http://www.adidas.com/nmd"
            }
        };
        this.dictionary_11 = dictionary12;
        Dictionary<int, string> dictionary13 = new Dictionary<int, string> {
            {
                0,
                "https://cp.adidas.de/web/eCom/de_DE/loadsignin?target=account"
            },
            {
                1,
                "https://cp.adidas.nl/web/eCom/nl_NL/loadsignin?target=account"
            },
            {
                2,
                "https://cp.adidas.fr/web/eCom/fr_FR/loadsignin?target=account"
            },
            {
                3,
                "https://cp.adidas.es/web/eCom/es_ES/loadsignin?target=account"
            },
            {
                4,
                "https://cp.adidas.it/web/eCom/it_IT/loadsignin?target=account"
            },
            {
                5,
                "https://cp.adidas.co.uk/web/eCom/en_GB/loadsignin?target=account"
            },
            {
                6,
                "https://cp.adidas.com/web/eCom/en_US/loadsignin?target=account"
            },
            {
                7,
                "https://cp.adidas.ca/web/eCom/en_CA/loadsignin?target=account"
            },
            {
                8,
                "https://cp.adidas.com.au/web/eCom/en_AU/loadsignin?target=account"
            },
            {
                9,
                "https://cp.adidas.at/web/eCom/de_AT/loadsignin?target=account"
            },
            {
                10,
                "https://cp.adidas.be/web/eCom/fr_BE/loadsignin?target=account"
            },
            {
                11,
                "https://cp.adidas.se/web/eCom/sv_SE/loadsignin?target=account"
            },
            {
                12,
                "https://cp.adidas.dk/web/eCom/da_DK/loadsignin?target=account"
            },
            {
                13,
                "https://cp.adidas.no/web/eCom/en_NO/loadsignin?target=account"
            },
            {
                14,
                "https://cp.adidas.pl/web/eCom/pl_PL/loadsignin?target=account"
            },
            {
                15,
                "https://cp.adidas.cz/web/eCom/cs_CZ/loadsignin?target=account"
            },
            {
                0x10,
                "https://cp.adidas.co.nz/web/eCom/en_NZ/loadsignin?target=account"
            },
            {
                0x11,
                "https://cp.adidas.ru/web/eCom/ru_RU/loadsignin?target=account"
            },
            {
                0x12,
                "https://cp.adidas.mx/web/eCom/es_MX/loadsignin?target=account"
            },
            {
                0x13,
                "https://cp.adidas.com/web/eCom/en_PT/loadsignin?target=account"
            }
        };
        this.dictionary_12 = dictionary13;
        Dictionary<int, string> dictionary14 = new Dictionary<int, string> {
            {
                0,
                "https://cp.adidas.de/idp/startSSO.ping"
            },
            {
                1,
                "https://cp.adidas.nl/idp/startSSO.ping"
            },
            {
                2,
                "https://cp.adidas.fr/idp/startSSO.ping"
            },
            {
                3,
                "https://cp.adidas.es/idp/startSSO.ping"
            },
            {
                4,
                "https://cp.adidas.it/idp/startSSO.ping"
            },
            {
                5,
                "https://cp.adidas.co.uk/idp/startSSO.ping"
            },
            {
                6,
                "https://cp.adidas.com/idp/startSSO.ping"
            },
            {
                7,
                "https://cp.adidas.ca/idp/startSSO.ping"
            },
            {
                8,
                "https://cp.adidas.com.au/idp/startSSO.ping"
            },
            {
                9,
                "https://cp.adidas.at/idp/startSSO.ping"
            },
            {
                10,
                "https://cp.adidas.be/idp/startSSO.ping"
            },
            {
                11,
                "https://cp.adidas.se/idp/startSSO.ping"
            },
            {
                12,
                "https://cp.adidas.dk/idp/startSSO.ping"
            },
            {
                13,
                "https://cp.adidas.no/idp/startSSO.ping"
            },
            {
                14,
                "https://cp.adidas.pl/idp/startSSO.ping"
            },
            {
                15,
                "https://cp.adidas.cz/idp/startSSO.ping"
            },
            {
                0x10,
                "https://cp.adidas.co.nz/idp/startSSO.ping"
            },
            {
                0x11,
                "https://cp.adidas.ru/idp/startSSO.ping"
            },
            {
                0x12,
                "https://cp.adidas.mx/idp/startSSO.ping"
            },
            {
                0x13,
                "https://cp.adidas.com/idp/startSSO.ping"
            }
        };
        this.dictionary_13 = dictionary14;
        Dictionary<int, string> dictionary15 = new Dictionary<int, string> {
            {
                0,
                "https://cp.adidas.de"
            },
            {
                1,
                "https://cp.adidas.nl"
            },
            {
                2,
                "https://cp.adidas.fr"
            },
            {
                3,
                "https://cp.adidas.es"
            },
            {
                4,
                "https://cp.adidas.it"
            },
            {
                5,
                "https://cp.adidas.co.uk"
            },
            {
                6,
                "https://cp.adidas.com"
            },
            {
                7,
                "https://cp.adidas.ca"
            },
            {
                8,
                "https://cp.adidas.com.au"
            },
            {
                9,
                "https://cp.adidas.at"
            },
            {
                10,
                "https://cp.adidas.be"
            },
            {
                11,
                "https://cp.adidas.se"
            },
            {
                12,
                "https://cp.adidas.dk"
            },
            {
                13,
                "https://cp.adidas.no"
            },
            {
                14,
                "https://cp.adidas.pl"
            },
            {
                15,
                "https://cp.adidas.cz"
            },
            {
                0x10,
                "https://cp.adidas.co.nz"
            },
            {
                0x11,
                "https://cp.adidas.ru"
            },
            {
                0x12,
                "https://cp.adidas.mx"
            },
            {
                0x13,
                "https://cp.adidas.com"
            }
        };
        this.dictionary_14 = dictionary15;
        Dictionary<int, string> dictionary16 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/MyAccount-Show"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/MyAccount-Show"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/MyAccount-Show"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/MyAccount-Show"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/MyAccount-Show"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/MyAccount-Show"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/MyAccount-Show"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/MyAccount-Show"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/MyAccount-Show"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/MyAccount-Show"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/MyAccount-Show"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/MyAccount-Show"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/MyAccount-Show"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/MyAccount-Show"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/MyAccount-Show"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/MyAccount-Show"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/MyAccount-Show"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/MyAccount-Show"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/MyAccount-Show"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/MyAccount-Show"
            }
        };
        this.dictionary_15 = dictionary16;
        this.bool_1 = true;
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.int_0 = 0x3a98;
        this.int_2 = 6;
        this.int_3 = -1;
        this.listViewGroup_0 = new ListViewGroup("Manual Tasks");
        this.listViewGroup_1 = new ListViewGroup("Automatic Tasks");
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.arrayList_3 = new ArrayList();
        this.arrayList_4 = new ArrayList();
        this.arrayList_5 = new ArrayList();
        this.bool_4 = true;
        this.queue_0 = new Queue<Class18>();
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = "6Le4AQgUAAAAAABhHEq7RWQNJwGR_M-6Jni9tgtA";
        this.string_6 = "6Le4AQgUAAAAAABhHEq7RWQNJwGR_M-6Jni9tgtA";
        this.string_7 = "a0342e58-a7a3-47c3-8cff-9bf71fb7e13c";
        this.string_8 = string.Empty;
        this.string_9 = string.Empty;
        this.string_10 = "<RSAKeyValue><Modulus>r2jZx0jGL3WK8iGWYStJ2r81hDWzmdSQbKut09+0lmGCfTb08YzdqQnpyisOomD9xMJy62RKvv1U7LoDEXqvnsGsjdGKyWfSvYChSoBWwpkkVaVEUn0jXVt8qdyoR1Nayd+/3TSA/NI4RpmQJMxSHwNZRK/Dw2bRJXF0K6NSdOUZIEehre48b+qMCu/pdPRAX5PB8LjChvCXCn4DxzLBTFTEgxeo8CLKgh/rvQH4FhGtilTLF0DJErBpp/oyb50rWfNZwtr7yPGeXGrD+84vbsIMK4YbsPoqFUYkzin13hQSeutZpzXbqckS6qgqsZTxt267XRr89lMhcV4ZNY7F3Q==</Modulus><Exponent>AQAB</Exponent><P>/1MrIbZA98CWsgdRd5QhmtOmMSSQ57QPHxXRCR7N8EzaVVrfLIYkQ8Y3mZyn99PeHyYC/TafOpBqkbUn8+xUUh6FZgBxWjv0WJ5yhqaxtFO9MzJ/q16xC1NNsta6y/Etk+XEqhaNr15WXfs73zgHURBt3wCqw3kOJ//PPs8JgO0=</P><Q>r9+WPhl5Awk9REco+nHgTlvvctB9wgzD1IoqTg+EFiBYELX0siIgAl6moLCkf6JpHzxkcLeFNUxrxeXxGRG8coXAmF7KxPYr+5zDQ9N1rcjaU7tlLiWwONY5vm7539t7VzSDEEiZzrgBrj6CxP57LNmh+Zgy7CIJlusLBfA06rE=</Q><DP>5jhCuuoQGJUSDEKnBZCO4IEY6FTVR+dGfzv3uSaKgLN7Zt1CQG5PwsC3H45usfra3PE0XsdiubbAMNPMy5d7zHPyyq95hehrgYCVOa6Sq0uaXNCa55XBQ7oAZFJUKlI0S5gxRUCCzu7cJ2/CY5qslj6fIyYB07GSvyRc5YBfTF0=</DP><DQ>j9QuLoLucAkyTZBUdtyCMBMHc8IF1phR3pNPnZ8aym2RF7l2b+dwff+iDW/oV2kexyjAi13KVpg02xb9YR8cGhxAMVv0P7eCqLa/Ccz5RDIqOqfaSy8POqwXdSGUv/nimKKdPMfi4SeiWDlPAIONgFRLHq/VlT8Q0JdP4H9dB0E=</DQ><InverseQ>GktqmK/DLxfsR/LnzqO+jgjpK9E/EPJAMOSIAvBCMMrNFbbJNk40GTXrHQroe2QbpUzanBcJcAh5FYY+bVH6i4KdgUAQC6yacFgsSX1sL6j5B+QfKuakE76S8Ehc4dcNkohe+C6hpdQqATX9JiEOgN+PGdJoQ9uF9hl0LPkPPuE=</InverseQ><D>m7HKlBvhZeDEavUrIKam0FYmL2rnNuS5KOwdx9Fp3o1AoNn2Aq2RVmhpLryXKcRDm7EpBg0oV2xPRCw7avlmBtlLyzmyIeFY6kHRaGqQF/yMhsTB5yISENySw8cLSvwOut8y0yq2TzJdJzVI/5CoV8TGKLSGY9vQSpbwkYdPOldc/6rKrmvd1Yl4cSYm08ChaQT7IhWyFa/bDEBe6PeYh1RfVrcbRj2ZaZlU4J3PRIYPsfX7WfFCsg0VNn9ll+sSg7ITS1KH5Apy7RSzXsRqvMLnL3QCY8l3U5AalUXeb6WX9yxkxjWSE7wgP0mYx4byaNkPGTZ8gj0sz88V98qMwQ==</D></RSAKeyValue>";
        this.string_11 = "<RSAKeyValue><Modulus>ZiS9zLDIhDWG97PkY3cZl3PPC/DxWBmZv4PG0q9xXpCn/H0ECOtiQV/LlcCq68NK7c2hyjAdDF6vjqyON+LzxwSyyKSHGLxiAP39tSrCMvtUx+qYM/MfxTT2PCzVE7lcuUSmxKO1EnFHG+eiOvhLgq4TUgK76lBMteaIj60cDglGRuyTCUEQ8Qy/6Ug8jY8KQm4MvZTJOa17geL0ld5YR/aGnc7OlmOHxnn2AzlDRQIVXfYHYqKFyXhdxjIlswCJP+6FWb3wjVkrkMPhwIjBbyOPecXMyrgaQZFrR/CAnJbvUgnG48pit+u9dShKYtyh+Abw94eXez83TD8eTEdqfQ==</Modulus><Exponent>AQAB</Exponent><P>yWdAUR82s+sl6ee6hgsNdDVzL+xdYAL9SsJQxHtTRbFaqpFsacmTdLZanUZSP6V1dYMMZDuvYQOOJ2QsZvXOZc/PArySMdQCCBFbsEqx1DY8VAptt7Kj1T6jXEEKtWkll/uIQ6MbQQH3wvVwaOqbiwojuLHj9z+Co7ZZCFut26U=</P><Q>gdUtGZyPBgtNfbQeciadRZnXy5Eyl1BSj9W6YPqniukRHQzWBWPfI3dEzQW+J1JBz+qskcx0huxiMB3z1sHemxy1+6Nz+a8wNP45mT8En2fZjvx6n8O785sk/w0luNUK7dTH7TXcqtgXQEFqJxHPagmjnaEv6BdsfAs0okHq+/k=</Q><DP>QnJ0P89iht2P9qnjWhIPcEWqKSd8bw7NbnrJlulxQc8PsLKl6Aj/Q0RehQEMZb87D3gbAH7Ij+NSZSChnZ5/aAu1qpt4SERAH1VKwNED9pWmNbvzEuY3M0WlM+ypkcyNAKWWAWqwtTPnAEVlvteYVbkUq/zUz1/+w/CHU0CcDZk=</DP><DQ>am4ylng81puVXqK1Aqac7l17BSl164yw4bA3JSDVD46XtNS87ZY9aXlwMRGwG9PWl3atGKgeLizBIOis5zPuJAGZPTt06w2t2wM8fF+ojnQ3aHuYmjd+b+iSn3JLpgUe/HAdpFsvFe4mwUnel0CGY0qbkbB88SmiiN02vHyFASE=</DQ><InverseQ>PiyuWIq6DIOJ6Xvm4+j9cLcFt1kVBgQMycoQ90YqIPAQdoWB65VWwA1x07MROOz9E/wv6TtwAFOHPpAKRD7wwuLaMthxm/PsYsZFNu0C5SaMb/2FeiGWZh5r06uBje5LJzA4AvQ4URszqQ72kemyqGqzI0/TgOdwEXxcYgAmVVE=</InverseQ><D>I9eetnYOVr5FtyPr7686Trf3nnQU7FpHZjnCienAeXN/Tw07Xjnix5fq44ixMXvdDidLL5zEhLOxHPqWCSxdaKfQaLG7KkXoifqWjX0MmkExVdmPQSN+MYBNK3574qj3zZc2gegEQQ1462TTu6enL5sP8oY9FJLK6EWWA/y1zIKmZ9+I7+9o7RTkNH/n1+r9A/n5MqK+WPzf2068Qq9fy9jU/u1uCXAKU3PU9RekfobTArUbIsstbsjZkgdKhRmhy8tK7tO6k75nkPMdvJb9cW8/5Sqq4kb/gdC/B1+L0o5TVY8fBHsn9OBghj5WO16GUa20ASMOKcflCukL8+8UYQ==</D></RSAKeyValue>";
        this.string_12 = string.Empty;
        this.int_4 = 0x2710;
        this.int_5 = 1;
        this.string_13 = string.Empty;
        this.string_14 = string.Empty;
        this.string_15 = string.Empty;
        this.string_16 = string.Empty;
        this.int_7 = 0x2710;
        this.int_8 = 1;
        this.string_17 = string.Empty;
        this.string_18 = string.Empty;
        this.string_19 = string.Empty;
        this.string_20 = string.Empty;
        this.string_21 = new string[100];
        this.string_22 = new string[100];
        this.string_23 = "akav";
        this.string_24 = "gceeqs";
        this.string_25 = string.Empty;
        this.string_26 = string.Empty;
        this.manualResetEvent_0 = new ManualResetEvent(false);
        this.bool_14 = true;
        this.InitializeComponent();
    }

    public MainForm(string string_27, string string_28, string string_29, string string_30)
    {
        Dictionary<int, string> dictionary1 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/default/Cart-MiniAddProduct"
            },
            {
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/default/Cart-MiniAddProduct"
            },
            {
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/default/Cart-MiniAddProduct"
            },
            {
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/default/Cart-MiniAddProduct"
            },
            {
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/default/Cart-MiniAddProduct"
            },
            {
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/default/Cart-MiniAddProduct"
            },
            {
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/default/Cart-MiniAddProduct"
            },
            {
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/default/Cart-MiniAddProduct"
            },
            {
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/default/Cart-MiniAddProduct"
            },
            {
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/default/Cart-MiniAddProduct"
            },
            {
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/default/Cart-MiniAddProduct"
            },
            {
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/default/Cart-MiniAddProduct"
            },
            {
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/default/Cart-MiniAddProduct"
            },
            {
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/default/Cart-MiniAddProduct"
            },
            {
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/default/Cart-MiniAddProduct"
            },
            {
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/default/Cart-MiniAddProduct"
            },
            {
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/default/Cart-MiniAddProduct"
            },
            {
                0x11,
                "http://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/default/Cart-MiniAddProduct"
            },
            {
                0x12,
                "http://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/default/Cart-MiniAddProduct"
            },
            {
                0x13,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/default/Cart-MiniAddProduct"
            }
        };
        this.dictionary_0 = dictionary1;
        Dictionary<int, string> dictionary2 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/Cart-MiniAddProduct"
            },
            {
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/nl_NL/Cart-MiniAddProduct"
            },
            {
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/fr_FR/Cart-MiniAddProduct"
            },
            {
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/es_ES/Cart-MiniAddProduct"
            },
            {
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/it_IT/Cart-MiniAddProduct"
            },
            {
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/Cart-MiniAddProduct"
            },
            {
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/Cart-MiniAddProduct"
            },
            {
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/Cart-MiniAddProduct"
            },
            {
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/Cart-MiniAddProduct"
            },
            {
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/Cart-MiniAddProduct"
            },
            {
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/Cart-MiniAddProduct"
            },
            {
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/Cart-MiniAddProduct"
            },
            {
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/Cart-MiniAddProduct"
            },
            {
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/Cart-MiniAddProduct"
            },
            {
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/Cart-MiniAddProduct"
            },
            {
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/Cart-MiniAddProduct"
            },
            {
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/Cart-MiniAddProduct"
            },
            {
                0x11,
                "http://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/Cart-MiniAddProduct"
            },
            {
                0x12,
                "http://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/Cart-MiniAddProduct"
            },
            {
                0x13,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/Cart-MiniAddProduct"
            }
        };
        this.dictionary_1 = dictionary2;
        Dictionary<int, string> dictionary3 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/CODelivery-RedirectToPaypal"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/CODelivery-RedirectToPaypal"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/CODelivery-RedirectToPaypal"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/CODelivery-RedirectToPaypal"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/CODelivery-RedirectToPaypal"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/CODelivery-RedirectToPaypal"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/CODelivery-RedirectToPaypal"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/CODelivery-RedirectToPaypal"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/CODelivery-RedirectToPaypal"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/CODelivery-RedirectToPaypal"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/CODelivery-RedirectToPaypal"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/CODelivery-RedirectToPaypal"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/CODelivery-RedirectToPaypal"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/nb_NO/CODelivery-RedirectToPaypal"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/CODelivery-RedirectToPaypal"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/CODelivery-RedirectToPaypal"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/CODelivery-RedirectToPaypal"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/CODelivery-RedirectToPaypal"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/CODelivery-RedirectToPaypal"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/CODelivery-RedirectToPaypal"
            }
        };
        this.dictionary_2 = dictionary3;
        Dictionary<int, string> dictionary4 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/COSummary-Start"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/COSummary-Start"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/COSummary-Start"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/COSummary-Start"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/COSummary-Start"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/COSummary-Start"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/COSummary-Start"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/COSummary-Start"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/COSummary-Start"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/COSummary-Start"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/COSummary-Start"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/COSummary-Start"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/COSummary-Start"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/COSummary-Start"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/COSummary-Start"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/COSummary-Start"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/COSummary-Start"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/COSummary-Start"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/COSummary-Start"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/COSummary-Start"
            }
        };
        this.dictionary_3 = dictionary4;
        Dictionary<int, string> dictionary5 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/Cart-Show"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/Cart-Show"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/Cart-Show"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/Cart-Show"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/Cart-Show"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/Cart-Show"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/Cart-Show"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/Cart-Show"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/Cart-Show"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/Cart-Show"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/Cart-Show"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/Cart-Show"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/Cart-Show"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/Cart-Show"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/Cart-Show"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/Cart-Show"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/Cart-Show"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/Cart-Show"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/Cart-Show"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/Cart-Show"
            }
        };
        this.dictionary_4 = dictionary5;
        Dictionary<int, string> dictionary6 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de"
            },
            {
                1,
                "http://www.adidas.nl"
            },
            {
                2,
                "http://www.adidas.fr"
            },
            {
                3,
                "http://www.adidas.es"
            },
            {
                4,
                "http://www.adidas.it"
            },
            {
                5,
                "http://www.adidas.co.uk"
            },
            {
                6,
                "http://www.adidas.com"
            },
            {
                7,
                "http://www.adidas.ca"
            },
            {
                8,
                "http://www.adidas.com.au"
            },
            {
                9,
                "http://www.adidas.at"
            },
            {
                10,
                "http://www.adidas.be"
            },
            {
                11,
                "http://www.adidas.se"
            },
            {
                12,
                "http://www.adidas.dk"
            },
            {
                13,
                "http://www.adidas.no"
            },
            {
                14,
                "http://www.adidas.pl"
            },
            {
                15,
                "http://www.adidas.cz"
            },
            {
                0x10,
                "http://www.adidas.co.nz"
            },
            {
                0x11,
                "http://www.adidas.ru"
            },
            {
                0x12,
                "http://www.adidas.mx"
            },
            {
                0x13,
                "http://www.adidas.com"
            }
        };
        this.dictionary_5 = dictionary6;
        Dictionary<int, string> dictionary7 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de"
            },
            {
                1,
                "http://www.adidas.nl"
            },
            {
                2,
                "http://www.adidas.fr"
            },
            {
                3,
                "http://www.adidas.es"
            },
            {
                4,
                "http://www.adidas.it"
            },
            {
                5,
                "http://www.adidas.co.uk"
            },
            {
                6,
                "http://www.adidas.com/us"
            },
            {
                7,
                "http://www.adidas.ca"
            },
            {
                8,
                "http://www.adidas.com.au"
            },
            {
                9,
                "http://www.adidas.at"
            },
            {
                10,
                "http://www.adidas.be"
            },
            {
                11,
                "http://www.adidas.se"
            },
            {
                12,
                "http://www.adidas.dk"
            },
            {
                13,
                "http://www.adidas.no"
            },
            {
                14,
                "http://www.adidas.pl"
            },
            {
                15,
                "http://www.adidas.cz"
            },
            {
                0x10,
                "http://www.adidas.co.nz"
            },
            {
                0x11,
                "http://www.adidas.ru"
            },
            {
                0x12,
                "http://www.adidas.mx"
            },
            {
                0x13,
                "http://www.adidas.com"
            }
        };
        this.dictionary_6 = dictionary7;
        Dictionary<int, string> dictionary8 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/Cart-ProductCount"
            },
            {
                1,
                "http://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/Cart-ProductCount"
            },
            {
                2,
                "http://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/Cart-ProductCount"
            },
            {
                3,
                "http://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/Cart-ProductCount"
            },
            {
                4,
                "http://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/Cart-ProductCount"
            },
            {
                5,
                "http://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/Cart-ProductCount"
            },
            {
                6,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/Cart-ProductCount"
            },
            {
                7,
                "http://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/Cart-ProductCount"
            },
            {
                8,
                "http://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/Cart-ProductCount"
            },
            {
                9,
                "http://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/Cart-ProductCount"
            },
            {
                10,
                "http://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/Cart-ProductCount"
            },
            {
                11,
                "http://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/Cart-ProductCount"
            },
            {
                12,
                "http://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/Cart-ProductCount"
            },
            {
                13,
                "http://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/Cart-ProductCount"
            },
            {
                14,
                "http://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/Cart-ProductCount"
            },
            {
                15,
                "http://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/Cart-ProductCount"
            },
            {
                0x10,
                "http://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/Cart-ProductCount"
            },
            {
                0x11,
                "http://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/Cart-ProductCount"
            },
            {
                0x12,
                "http://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/Cart-ProductCount"
            },
            {
                0x13,
                "http://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/Cart-ProductCount"
            }
        };
        this.dictionary_7 = dictionary8;
        Dictionary<int, string> dictionary9 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/"
            }
        };
        this.dictionary_8 = dictionary9;
        Dictionary<int, string> dictionary10 = new Dictionary<int, string> {
            {
                0,
                "adidas.de"
            },
            {
                1,
                "adidas.nl"
            },
            {
                2,
                "adidas.fr"
            },
            {
                3,
                "adidas.es"
            },
            {
                4,
                "adidas.it"
            },
            {
                5,
                "adidas.co.uk"
            },
            {
                6,
                "adidas.com"
            },
            {
                7,
                "adidas.ca"
            },
            {
                8,
                "adidas.com.au"
            },
            {
                9,
                "adidas.at"
            },
            {
                10,
                "adidas.be"
            },
            {
                11,
                "adidas.se"
            },
            {
                12,
                "adidas.dk"
            },
            {
                13,
                "adidas.no"
            },
            {
                14,
                "adidas.pl"
            },
            {
                15,
                "adidas.cz"
            },
            {
                0x10,
                "adidas.co.nz"
            },
            {
                0x11,
                "adidas.ru"
            },
            {
                0x12,
                "adidas.mx"
            },
            {
                0x13,
                "adidas.com"
            }
        };
        this.dictionary_9 = dictionary10;
        Dictionary<int, string> dictionary11 = new Dictionary<int, string> {
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
                "http://www.adidas.com/yeezy"
            }
        };
        this.dictionary_10 = dictionary11;
        Dictionary<int, string> dictionary12 = new Dictionary<int, string> {
            {
                0,
                "http://www.adidas.de/nmd"
            },
            {
                1,
                "http://www.adidas.nl/nmd"
            },
            {
                2,
                "http://www.adidas.fr/nmd"
            },
            {
                3,
                "http://www.adidas.es/nmd"
            },
            {
                4,
                "http://www.adidas.it/nmd"
            },
            {
                5,
                "http://www.adidas.co.uk/nmd"
            },
            {
                6,
                "http://www.adidas.com/nmd"
            },
            {
                7,
                "http://www.adidas.ca/nmd"
            },
            {
                8,
                "http://www.adidas.com.au/nmd"
            },
            {
                9,
                "http://www.adidas.at/nmd"
            },
            {
                10,
                "http://www.adidas.be/nmd"
            },
            {
                11,
                "http://www.adidas.se/nmd"
            },
            {
                12,
                "http://www.adidas.dk/nmd"
            },
            {
                13,
                "http://www.adidas.no/nmd"
            },
            {
                14,
                "http://www.adidas.pl/nmd"
            },
            {
                15,
                "http://www.adidas.cz/nmd"
            },
            {
                0x10,
                "http://www.adidas.co.nz/nmd"
            },
            {
                0x11,
                "http://www.adidas.ru/nmd"
            },
            {
                0x12,
                "http://www.adidas.mx/nmd"
            },
            {
                0x13,
                "http://www.adidas.com/nmd"
            }
        };
        this.dictionary_11 = dictionary12;
        Dictionary<int, string> dictionary13 = new Dictionary<int, string> {
            {
                0,
                "https://cp.adidas.de/web/eCom/de_DE/loadsignin?target=account"
            },
            {
                1,
                "https://cp.adidas.nl/web/eCom/nl_NL/loadsignin?target=account"
            },
            {
                2,
                "https://cp.adidas.fr/web/eCom/fr_FR/loadsignin?target=account"
            },
            {
                3,
                "https://cp.adidas.es/web/eCom/es_ES/loadsignin?target=account"
            },
            {
                4,
                "https://cp.adidas.it/web/eCom/it_IT/loadsignin?target=account"
            },
            {
                5,
                "https://cp.adidas.co.uk/web/eCom/en_GB/loadsignin?target=account"
            },
            {
                6,
                "https://cp.adidas.com/web/eCom/en_US/loadsignin?target=account"
            },
            {
                7,
                "https://cp.adidas.ca/web/eCom/en_CA/loadsignin?target=account"
            },
            {
                8,
                "https://cp.adidas.com.au/web/eCom/en_AU/loadsignin?target=account"
            },
            {
                9,
                "https://cp.adidas.at/web/eCom/de_AT/loadsignin?target=account"
            },
            {
                10,
                "https://cp.adidas.be/web/eCom/fr_BE/loadsignin?target=account"
            },
            {
                11,
                "https://cp.adidas.se/web/eCom/sv_SE/loadsignin?target=account"
            },
            {
                12,
                "https://cp.adidas.dk/web/eCom/da_DK/loadsignin?target=account"
            },
            {
                13,
                "https://cp.adidas.no/web/eCom/en_NO/loadsignin?target=account"
            },
            {
                14,
                "https://cp.adidas.pl/web/eCom/pl_PL/loadsignin?target=account"
            },
            {
                15,
                "https://cp.adidas.cz/web/eCom/cs_CZ/loadsignin?target=account"
            },
            {
                0x10,
                "https://cp.adidas.co.nz/web/eCom/en_NZ/loadsignin?target=account"
            },
            {
                0x11,
                "https://cp.adidas.ru/web/eCom/ru_RU/loadsignin?target=account"
            },
            {
                0x12,
                "https://cp.adidas.mx/web/eCom/es_MX/loadsignin?target=account"
            },
            {
                0x13,
                "https://cp.adidas.com/web/eCom/en_PT/loadsignin?target=account"
            }
        };
        this.dictionary_12 = dictionary13;
        Dictionary<int, string> dictionary14 = new Dictionary<int, string> {
            {
                0,
                "https://cp.adidas.de/idp/startSSO.ping"
            },
            {
                1,
                "https://cp.adidas.nl/idp/startSSO.ping"
            },
            {
                2,
                "https://cp.adidas.fr/idp/startSSO.ping"
            },
            {
                3,
                "https://cp.adidas.es/idp/startSSO.ping"
            },
            {
                4,
                "https://cp.adidas.it/idp/startSSO.ping"
            },
            {
                5,
                "https://cp.adidas.co.uk/idp/startSSO.ping"
            },
            {
                6,
                "https://cp.adidas.com/idp/startSSO.ping"
            },
            {
                7,
                "https://cp.adidas.ca/idp/startSSO.ping"
            },
            {
                8,
                "https://cp.adidas.com.au/idp/startSSO.ping"
            },
            {
                9,
                "https://cp.adidas.at/idp/startSSO.ping"
            },
            {
                10,
                "https://cp.adidas.be/idp/startSSO.ping"
            },
            {
                11,
                "https://cp.adidas.se/idp/startSSO.ping"
            },
            {
                12,
                "https://cp.adidas.dk/idp/startSSO.ping"
            },
            {
                13,
                "https://cp.adidas.no/idp/startSSO.ping"
            },
            {
                14,
                "https://cp.adidas.pl/idp/startSSO.ping"
            },
            {
                15,
                "https://cp.adidas.cz/idp/startSSO.ping"
            },
            {
                0x10,
                "https://cp.adidas.co.nz/idp/startSSO.ping"
            },
            {
                0x11,
                "https://cp.adidas.ru/idp/startSSO.ping"
            },
            {
                0x12,
                "https://cp.adidas.mx/idp/startSSO.ping"
            },
            {
                0x13,
                "https://cp.adidas.com/idp/startSSO.ping"
            }
        };
        this.dictionary_13 = dictionary14;
        Dictionary<int, string> dictionary15 = new Dictionary<int, string> {
            {
                0,
                "https://cp.adidas.de"
            },
            {
                1,
                "https://cp.adidas.nl"
            },
            {
                2,
                "https://cp.adidas.fr"
            },
            {
                3,
                "https://cp.adidas.es"
            },
            {
                4,
                "https://cp.adidas.it"
            },
            {
                5,
                "https://cp.adidas.co.uk"
            },
            {
                6,
                "https://cp.adidas.com"
            },
            {
                7,
                "https://cp.adidas.ca"
            },
            {
                8,
                "https://cp.adidas.com.au"
            },
            {
                9,
                "https://cp.adidas.at"
            },
            {
                10,
                "https://cp.adidas.be"
            },
            {
                11,
                "https://cp.adidas.se"
            },
            {
                12,
                "https://cp.adidas.dk"
            },
            {
                13,
                "https://cp.adidas.no"
            },
            {
                14,
                "https://cp.adidas.pl"
            },
            {
                15,
                "https://cp.adidas.cz"
            },
            {
                0x10,
                "https://cp.adidas.co.nz"
            },
            {
                0x11,
                "https://cp.adidas.ru"
            },
            {
                0x12,
                "https://cp.adidas.mx"
            },
            {
                0x13,
                "https://cp.adidas.com"
            }
        };
        this.dictionary_14 = dictionary15;
        Dictionary<int, string> dictionary16 = new Dictionary<int, string> {
            {
                0,
                "https://www.adidas.de/on/demandware.store/Sites-adidas-DE-Site/de_DE/MyAccount-Show"
            },
            {
                1,
                "https://www.adidas.nl/on/demandware.store/Sites-adidas-NL-Site/de_NL/MyAccount-Show"
            },
            {
                2,
                "https://www.adidas.fr/on/demandware.store/Sites-adidas-FR-Site/de_FR/MyAccount-Show"
            },
            {
                3,
                "https://www.adidas.es/on/demandware.store/Sites-adidas-ES-Site/de_ES/MyAccount-Show"
            },
            {
                4,
                "https://www.adidas.it/on/demandware.store/Sites-adidas-IT-Site/de_IT/MyAccount-Show"
            },
            {
                5,
                "https://www.adidas.co.uk/on/demandware.store/Sites-adidas-GB-Site/en_GB/MyAccount-Show"
            },
            {
                6,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-US-Site/en_US/MyAccount-Show"
            },
            {
                7,
                "https://www.adidas.ca/on/demandware.store/Sites-adidas-CA-Site/en_CA/MyAccount-Show"
            },
            {
                8,
                "https://www.adidas.com.au/on/demandware.store/Sites-adidas-AU-Site/en_AU/MyAccount-Show"
            },
            {
                9,
                "https://www.adidas.at/on/demandware.store/Sites-adidas-AT-Site/de_AT/MyAccount-Show"
            },
            {
                10,
                "https://www.adidas.be/on/demandware.store/Sites-adidas-BE-Site/fr_BE/MyAccount-Show"
            },
            {
                11,
                "https://www.adidas.se/on/demandware.store/Sites-adidas-SE-Site/sv_SE/MyAccount-Show"
            },
            {
                12,
                "https://www.adidas.dk/on/demandware.store/Sites-adidas-DK-Site/da_DK/MyAccount-Show"
            },
            {
                13,
                "https://www.adidas.no/on/demandware.store/Sites-adidas-NO-Site/en_NO/MyAccount-Show"
            },
            {
                14,
                "https://www.adidas.pl/on/demandware.store/Sites-adidas-PL-Site/pl_PL/MyAccount-Show"
            },
            {
                15,
                "https://www.adidas.cz/on/demandware.store/Sites-adidas-CZ-Site/cs_CZ/MyAccount-Show"
            },
            {
                0x10,
                "https://www.adidas.co.nz/on/demandware.store/Sites-adidas-NZ-Site/en_NZ/MyAccount-Show"
            },
            {
                0x11,
                "https://www.adidas.ru/on/demandware.store/Sites-adidas-RU-Site/ru_RU/MyAccount-Show"
            },
            {
                0x12,
                "https://www.adidas.mx/on/demandware.store/Sites-adidas-MX-Site/es_MX/MyAccount-Show"
            },
            {
                0x13,
                "https://www.adidas.com/on/demandware.store/Sites-adidas-MLT-Site/en_PT/MyAccount-Show"
            }
        };
        this.dictionary_15 = dictionary16;
        this.bool_1 = true;
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.int_0 = 0x3a98;
        this.int_2 = 6;
        this.int_3 = -1;
        this.listViewGroup_0 = new ListViewGroup("Manual Tasks");
        this.listViewGroup_1 = new ListViewGroup("Automatic Tasks");
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.arrayList_3 = new ArrayList();
        this.arrayList_4 = new ArrayList();
        this.arrayList_5 = new ArrayList();
        this.bool_4 = true;
        this.queue_0 = new Queue<Class18>();
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = "6Le4AQgUAAAAAABhHEq7RWQNJwGR_M-6Jni9tgtA";
        this.string_6 = "6Le4AQgUAAAAAABhHEq7RWQNJwGR_M-6Jni9tgtA";
        this.string_7 = "a0342e58-a7a3-47c3-8cff-9bf71fb7e13c";
        this.string_8 = string.Empty;
        this.string_9 = string.Empty;
        this.string_10 = "<RSAKeyValue><Modulus>r2jZx0jGL3WK8iGWYStJ2r81hDWzmdSQbKut09+0lmGCfTb08YzdqQnpyisOomD9xMJy62RKvv1U7LoDEXqvnsGsjdGKyWfSvYChSoBWwpkkVaVEUn0jXVt8qdyoR1Nayd+/3TSA/NI4RpmQJMxSHwNZRK/Dw2bRJXF0K6NSdOUZIEehre48b+qMCu/pdPRAX5PB8LjChvCXCn4DxzLBTFTEgxeo8CLKgh/rvQH4FhGtilTLF0DJErBpp/oyb50rWfNZwtr7yPGeXGrD+84vbsIMK4YbsPoqFUYkzin13hQSeutZpzXbqckS6qgqsZTxt267XRr89lMhcV4ZNY7F3Q==</Modulus><Exponent>AQAB</Exponent><P>/1MrIbZA98CWsgdRd5QhmtOmMSSQ57QPHxXRCR7N8EzaVVrfLIYkQ8Y3mZyn99PeHyYC/TafOpBqkbUn8+xUUh6FZgBxWjv0WJ5yhqaxtFO9MzJ/q16xC1NNsta6y/Etk+XEqhaNr15WXfs73zgHURBt3wCqw3kOJ//PPs8JgO0=</P><Q>r9+WPhl5Awk9REco+nHgTlvvctB9wgzD1IoqTg+EFiBYELX0siIgAl6moLCkf6JpHzxkcLeFNUxrxeXxGRG8coXAmF7KxPYr+5zDQ9N1rcjaU7tlLiWwONY5vm7539t7VzSDEEiZzrgBrj6CxP57LNmh+Zgy7CIJlusLBfA06rE=</Q><DP>5jhCuuoQGJUSDEKnBZCO4IEY6FTVR+dGfzv3uSaKgLN7Zt1CQG5PwsC3H45usfra3PE0XsdiubbAMNPMy5d7zHPyyq95hehrgYCVOa6Sq0uaXNCa55XBQ7oAZFJUKlI0S5gxRUCCzu7cJ2/CY5qslj6fIyYB07GSvyRc5YBfTF0=</DP><DQ>j9QuLoLucAkyTZBUdtyCMBMHc8IF1phR3pNPnZ8aym2RF7l2b+dwff+iDW/oV2kexyjAi13KVpg02xb9YR8cGhxAMVv0P7eCqLa/Ccz5RDIqOqfaSy8POqwXdSGUv/nimKKdPMfi4SeiWDlPAIONgFRLHq/VlT8Q0JdP4H9dB0E=</DQ><InverseQ>GktqmK/DLxfsR/LnzqO+jgjpK9E/EPJAMOSIAvBCMMrNFbbJNk40GTXrHQroe2QbpUzanBcJcAh5FYY+bVH6i4KdgUAQC6yacFgsSX1sL6j5B+QfKuakE76S8Ehc4dcNkohe+C6hpdQqATX9JiEOgN+PGdJoQ9uF9hl0LPkPPuE=</InverseQ><D>m7HKlBvhZeDEavUrIKam0FYmL2rnNuS5KOwdx9Fp3o1AoNn2Aq2RVmhpLryXKcRDm7EpBg0oV2xPRCw7avlmBtlLyzmyIeFY6kHRaGqQF/yMhsTB5yISENySw8cLSvwOut8y0yq2TzJdJzVI/5CoV8TGKLSGY9vQSpbwkYdPOldc/6rKrmvd1Yl4cSYm08ChaQT7IhWyFa/bDEBe6PeYh1RfVrcbRj2ZaZlU4J3PRIYPsfX7WfFCsg0VNn9ll+sSg7ITS1KH5Apy7RSzXsRqvMLnL3QCY8l3U5AalUXeb6WX9yxkxjWSE7wgP0mYx4byaNkPGTZ8gj0sz88V98qMwQ==</D></RSAKeyValue>";
        this.string_11 = "<RSAKeyValue><Modulus>ZiS9zLDIhDWG97PkY3cZl3PPC/DxWBmZv4PG0q9xXpCn/H0ECOtiQV/LlcCq68NK7c2hyjAdDF6vjqyON+LzxwSyyKSHGLxiAP39tSrCMvtUx+qYM/MfxTT2PCzVE7lcuUSmxKO1EnFHG+eiOvhLgq4TUgK76lBMteaIj60cDglGRuyTCUEQ8Qy/6Ug8jY8KQm4MvZTJOa17geL0ld5YR/aGnc7OlmOHxnn2AzlDRQIVXfYHYqKFyXhdxjIlswCJP+6FWb3wjVkrkMPhwIjBbyOPecXMyrgaQZFrR/CAnJbvUgnG48pit+u9dShKYtyh+Abw94eXez83TD8eTEdqfQ==</Modulus><Exponent>AQAB</Exponent><P>yWdAUR82s+sl6ee6hgsNdDVzL+xdYAL9SsJQxHtTRbFaqpFsacmTdLZanUZSP6V1dYMMZDuvYQOOJ2QsZvXOZc/PArySMdQCCBFbsEqx1DY8VAptt7Kj1T6jXEEKtWkll/uIQ6MbQQH3wvVwaOqbiwojuLHj9z+Co7ZZCFut26U=</P><Q>gdUtGZyPBgtNfbQeciadRZnXy5Eyl1BSj9W6YPqniukRHQzWBWPfI3dEzQW+J1JBz+qskcx0huxiMB3z1sHemxy1+6Nz+a8wNP45mT8En2fZjvx6n8O785sk/w0luNUK7dTH7TXcqtgXQEFqJxHPagmjnaEv6BdsfAs0okHq+/k=</Q><DP>QnJ0P89iht2P9qnjWhIPcEWqKSd8bw7NbnrJlulxQc8PsLKl6Aj/Q0RehQEMZb87D3gbAH7Ij+NSZSChnZ5/aAu1qpt4SERAH1VKwNED9pWmNbvzEuY3M0WlM+ypkcyNAKWWAWqwtTPnAEVlvteYVbkUq/zUz1/+w/CHU0CcDZk=</DP><DQ>am4ylng81puVXqK1Aqac7l17BSl164yw4bA3JSDVD46XtNS87ZY9aXlwMRGwG9PWl3atGKgeLizBIOis5zPuJAGZPTt06w2t2wM8fF+ojnQ3aHuYmjd+b+iSn3JLpgUe/HAdpFsvFe4mwUnel0CGY0qbkbB88SmiiN02vHyFASE=</DQ><InverseQ>PiyuWIq6DIOJ6Xvm4+j9cLcFt1kVBgQMycoQ90YqIPAQdoWB65VWwA1x07MROOz9E/wv6TtwAFOHPpAKRD7wwuLaMthxm/PsYsZFNu0C5SaMb/2FeiGWZh5r06uBje5LJzA4AvQ4URszqQ72kemyqGqzI0/TgOdwEXxcYgAmVVE=</InverseQ><D>I9eetnYOVr5FtyPr7686Trf3nnQU7FpHZjnCienAeXN/Tw07Xjnix5fq44ixMXvdDidLL5zEhLOxHPqWCSxdaKfQaLG7KkXoifqWjX0MmkExVdmPQSN+MYBNK3574qj3zZc2gegEQQ1462TTu6enL5sP8oY9FJLK6EWWA/y1zIKmZ9+I7+9o7RTkNH/n1+r9A/n5MqK+WPzf2068Qq9fy9jU/u1uCXAKU3PU9RekfobTArUbIsstbsjZkgdKhRmhy8tK7tO6k75nkPMdvJb9cW8/5Sqq4kb/gdC/B1+L0o5TVY8fBHsn9OBghj5WO16GUa20ASMOKcflCukL8+8UYQ==</D></RSAKeyValue>";
        this.string_12 = string.Empty;
        this.int_4 = 0x2710;
        this.int_5 = 1;
        this.string_13 = string.Empty;
        this.string_14 = string.Empty;
        this.string_15 = string.Empty;
        this.string_16 = string.Empty;
        this.int_7 = 0x2710;
        this.int_8 = 1;
        this.string_17 = string.Empty;
        this.string_18 = string.Empty;
        this.string_19 = string.Empty;
        this.string_20 = string.Empty;
        this.string_21 = new string[100];
        this.string_22 = new string[100];
        this.string_23 = "akav";
        this.string_24 = "gceeqs";
        this.string_25 = string.Empty;
        this.string_26 = string.Empty;
        this.manualResetEvent_0 = new ManualResetEvent(false);
        this.bool_14 = true;
        this.InitializeComponent();
        this.string_20 = string_27;
        this.string_26 = string_28;
        this.string_0 = string_29;
        this.string_1 = string_30;
    }

    private void addAdidasAccountsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddAdidasAccountForm form = new AddAdidasAccountForm {
            StartPosition = FormStartPosition.CenterParent
        };
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            foreach (Class46 class2 in form.arrayList_0)
            {
                this.arrayList_4.Add(class2);
            }
            this.adidasAccountLabel.Text = "Adidas accounts in list: " + this.arrayList_4.Count.ToString();
            this.adidasAccountLabel.Visible = true;
        }
    }

    private void addAndStartButton_Click(object sender, EventArgs e)
    {
        Class41 class2 = new Class41 {
            mainForm_0 = this
        };
        string str = this.pidBox.Text.ToUpper();
        bool flag = this.needsCaptcha.Checked;
        string text = this.sizeComboBox.Text;
        int selectedIndex = this.sizeComboBox.SelectedIndex;
        string str5 = string.Empty;
        bool flag2 = this.autoStart.Checked;
        string str6 = this.timePicker.Text;
        string str2 = string.Empty;
        string str3 = string.Empty;
        if (flag2)
        {
            MessageBox.Show("Instant starting is not available for automatic tasks.");
        }
        else if (str.Length < int.Parse(this.string_2))
        {
            MessageBox.Show("Please enter a valid PID.");
        }
        else if (selectedIndex == -1)
        {
            MessageBox.Show("Please select a size!");
        }
        else
        {
            if (!this.thread_6.IsAlive)
            {
                int.Parse("rip");
            }
            string str4 = string.Empty;
            if ((this.splashRadio.Checked || this.alternativeRadio.Checked) & flag)
            {
                str4 = this.string_3;
            }
            if ((!this.proxyBox.Text.Equals(string.Empty) && !this.proxyUsernameBox.Text.Equals(string.Empty)) && !this.proxyPWBox.Text.Equals(string.Empty))
            {
                str2 = this.proxyUsernameBox.Text;
                str3 = this.proxyPWBox.Text;
            }
            int num3 = this.int_3 + 1;
            this.int_3 = num3;
            int num = num3;
            while (true)
            {
                using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
                {
                    GClass0 class3;
                    while (enumerator.MoveNext())
                    {
                        GClass0 current = (GClass0) enumerator.Current;
                        if (num == current.id)
                        {
                            goto Label_0196;
                        }
                    }
                    this.int_3 = num;
                    if (this.autoCheckoutCheckBox.Checked)
                    {
                        class3 = new GClass0(num, str, selectedIndex, flag, str4, str5, this.proxyBox.Text, str2, str3, flag2, str6, this.bool_4, (GClass4) this.checkoutProfileBox.SelectedItem);
                    }
                    else
                    {
                        class3 = new GClass0(num, str, selectedIndex, flag, str4, str5, this.proxyBox.Text, str2, str3, flag2, str6, this.bool_4, null);
                    }
                    class2.arrayList_0 = new ArrayList();
                    class2.arrayList_0.Add(class3);
                    this.arrayList_0.Add(class3);
                    this.taskOListView.SetObjects(this.arrayList_0);
                    Thread thread = new Thread(new ThreadStart(class2.method_0)) {
                        IsBackground = true
                    };
                    this.arrayList_2.Add(thread);
                    thread.Start();
                    return;
                Label_0196:
                    num++;
                }
            }
        }
    }

    private void addTaskButton_Click(object sender, EventArgs e)
    {
        string str = this.pidBox.Text.ToUpper();
        bool flag2 = this.needsCaptcha.Checked;
        string text = this.sizeComboBox.Text;
        int selectedIndex = this.sizeComboBox.SelectedIndex;
        string str6 = string.Empty;
        bool flag = this.autoStart.Checked;
        string str2 = this.timePicker.Text;
        string str3 = string.Empty;
        string str4 = string.Empty;
        if (str.Length < int.Parse(this.string_2))
        {
            MessageBox.Show(this, "Please enter a valid PID.");
        }
        else if (selectedIndex == -1)
        {
            MessageBox.Show(this, "Please select a size!");
        }
        else
        {
            if (!this.thread_6.IsAlive)
            {
                int.Parse("rip");
            }
            string str5 = string.Empty;
            if ((this.splashRadio.Checked || this.alternativeRadio.Checked) & flag2)
            {
                str5 = this.string_3;
            }
            if ((!this.proxyBox.Text.Equals(string.Empty) && !this.proxyUsernameBox.Text.Equals(string.Empty)) && !this.proxyPWBox.Text.Equals(string.Empty))
            {
                str3 = this.proxyUsernameBox.Text;
                str4 = this.proxyPWBox.Text;
            }
            if (!flag)
            {
                str2 = string.Empty;
            }
            if (flag && (this.thread_0 == null))
            {
                this.thread_0 = new Thread(new ThreadStart(this.method_15));
                this.thread_0.IsBackground = true;
                this.thread_0.Start();
            }
            int num3 = this.int_3 + 1;
            this.int_3 = num3;
            int num = num3;
            while (true)
            {
                using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
                {
                    GClass0 class2;
                    while (enumerator.MoveNext())
                    {
                        GClass0 current = (GClass0) enumerator.Current;
                        if (num == current.id)
                        {
                            goto Label_01BD;
                        }
                    }
                    this.int_3 = num;
                    if (this.autoCheckoutCheckBox.Checked)
                    {
                        class2 = new GClass0(num, str, selectedIndex, flag2, str5, str6, this.proxyBox.Text, str3, str4, flag, str2, this.bool_4, (GClass4) this.checkoutProfileBox.SelectedItem);
                    }
                    else
                    {
                        class2 = new GClass0(num, str, selectedIndex, flag2, str5, str6, this.proxyBox.Text, str3, str4, flag, str2, this.bool_4, null);
                    }
                    class2.isRunning = false;
                    this.arrayList_0.Add(class2);
                    this.taskOListView.SetObjects(this.arrayList_0);
                    SharpSerializer serializer = new SharpSerializer(true);
                    try
                    {
                        serializer.Serialize(this.arrayList_0, "tasks.bin");
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        serializer.Serialize(this.arrayList_3, "ctasks.bin");
                    }
                    catch (Exception)
                    {
                    }
                    return;
                Label_01BD:
                    num++;
                }
            }
        }
    }

    private void adidasAccountLabel_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (MessageBox.Show("Do you want to delete all adidas accounts from the list?", "Delete accounts", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
        {
            this.arrayList_4.Clear();
            this.adidasAccountLabel.Visible = false;
        }
    }

    private void adidasAccountsCheck_CheckedChanged(object sender, EventArgs e)
    {
        if (this.adidasAccountsCheck.Checked && this.autoCheckoutCheckBox.Checked)
        {
            MessageBox.Show("Auto Checkout in combination with adidas account login is not fully supported as of now. The auto checkout might fail!");
        }
        if ((this.adidasAccountsCheck.Checked && (this.int_1 < 2)) && (MessageBox.Show("We recommend to set the global task delay to at least 2 seconds when using adidas accounts. Do you wish to set a 2 seconds delay now?", "Task delay recommended!", MessageBoxButtons.YesNo) == DialogResult.Yes))
        {
            this.int_1 = 2;
            this.taskDelayLabel.Text = "Task Delay: 2 sec.";
            this.taskDelayLabel.Visible = true;
        }
    }

    private void anticaptchaButton_Click(object sender, EventArgs e)
    {
        if ((this.thread_9 != null) && this.thread_9.IsAlive)
        {
            if (this.thread_9.IsAlive)
            {
                this.thread_9.Abort();
                this.anticaptchaButton.Text = "Start Anti-Captcha";
                this.bool_7 = false;
            }
        }
        else if (this.string_13.Equals(string.Empty))
        {
            MessageBox.Show("Please setup your Anti-Captcha API-Key and proxy server before using this feature.");
        }
        else
        {
            this.thread_9 = new Thread(new ThreadStart(this.method_31));
            this.thread_9.Start();
            this.anticaptchaButton.Text = "Stop Anti-Captcha";
            this.bool_7 = true;
        }
    }

    private void antiCaptchaSetupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SetupAntiCaptchaForm form = new SetupAntiCaptchaForm(this.string_13, this.string_14, this.int_6, this.string_15, this.string_16, this.int_7, this.int_8) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            this.string_13 = form.string_0;
            this.string_14 = form.string_1;
            this.int_6 = form.int_0;
            this.string_15 = form.string_2;
            this.string_16 = form.string_3;
            this.int_7 = form.int_1;
            this.int_8 = form.int_2;
        }
        form.Dispose();
    }

    private void autoCheckoutCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (this.autoCheckoutCheckBox.Checked)
        {
            this.checkoutProfileBox.Enabled = true;
            if (this.adidasAccountsCheck.Checked)
            {
                MessageBox.Show("Auto Checkout in combination with adidas account login is not fully supported as of now. The auto checkout might fail!");
            }
        }
        else
        {
            this.checkoutProfileBox.Enabled = false;
        }
    }

    private void automaticKeyBox_CheckedChanged(object sender, EventArgs e)
    {
        if (this.automaticKeyBox.Checked)
        {
            this.manualTextBox.Text = string.Empty;
        }
    }

    private void autoStart_CheckedChanged(object sender, EventArgs e)
    {
        if (this.autoStart.Checked)
        {
            this.timePicker.Enabled = true;
        }
        else
        {
            this.timePicker.Enabled = false;
        }
    }

    private void autoUpdateButton_Click(object sender, EventArgs e)
    {
        if (!this.bool_10)
        {
            if (this.manualTextBox.Text != string.Empty)
            {
                MessageBox.Show("You have to select the 'automatic' mode to use the automatic key retrieval.");
            }
            else
            {
                this.bool_10 = true;
                this.manualTextBox.Enabled = false;
                this.autoUpdateButton.Text = "Disable Auto Update";
                this.autoUpdateButton.ForeColor = Color.Red;
                this.thread_5 = new Thread(new ThreadStart(this.method_3));
                this.thread_5.IsBackground = true;
                this.thread_5.Start();
            }
        }
        else if (this.bool_10)
        {
            this.bool_10 = false;
            this.manualTextBox.Enabled = true;
            this.autoUpdateButton.Text = "Enable Auto Update";
            this.autoUpdateButton.ForeColor = Color.LimeGreen;
            this.thread_5.Abort();
        }
    }

    private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
    {
    }

    private void browserHarvesterButton_Click(object sender, EventArgs e)
    {
        string arguments = "http://127.0.0.1:51924/ycopp/";
        if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
        {
            MessageBox.Show("yCopp needs administrator rights to host the captcha on your computer. Please start yCopp as administrator.");
        }
        else
        {
            if (this.gclass5_0 != null)
            {
                this.gclass5_0.method_1();
            }
            try
            {
                string[] textArray1 = new string[] { "http://127.0.0.1:51924/ycopp/" };
                this.gclass5_0 = new GClass5(new Func<HttpListenerRequest, string>(this, (IntPtr) this.method_45), textArray1);
                this.gclass5_0.method_0();
            }
            catch (Exception)
            {
                try
                {
                    string[] textArray2 = new string[] { "http://127.0.0.1:62974/ycopp/" };
                    this.gclass5_0 = new GClass5(new Func<HttpListenerRequest, string>(this, (IntPtr) this.method_45), textArray2);
                    this.gclass5_0.method_0();
                    arguments = "http://127.0.0.1:62974/ycopp/";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(this, "Please contact info@ycopp.com with this error message: " + exception.Message);
                    return;
                }
            }
            try
            {
                Process.Start("chrome.exe", arguments);
            }
            catch (Exception)
            {
                MessageBox.Show("Please install Google Chrome to use this feature!");
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!this.bool_8)
        {
            if (!this.bool_12)
            {
                this.updateButton.PerformClick();
            }
            this.method_5();
            this.thread_2 = new Thread(new ThreadStart(this.method_1));
            this.thread_2.Start();
            this.thread_4 = new Thread(new ThreadStart(this.method_2));
            this.thread_4.IsBackground = true;
            this.thread_4.Start();
            this.button1.Text = "Stop Harvesting";
        }
        else
        {
            this.thread_2.Abort();
            this.thread_4.Abort();
            this.panel1.Controls.Remove(this.chromiumWebBrowser_0);
            this.button1.Text = "Start Harvesting";
        }
        this.bool_8 = !this.bool_8;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.browserForm_0.Visible = true;
    }

    private void cancelTasksButton_Click(object sender, EventArgs e)
    {
        foreach (Thread thread in this.arrayList_2)
        {
            if (thread.IsAlive)
            {
                thread.Abort();
            }
        }
        foreach (Thread thread2 in this.arrayList_1)
        {
            if (thread2.IsAlive)
            {
                thread2.Abort();
            }
        }
        foreach (GClass0 class1 in this.arrayList_0)
        {
            class1.isScheduled = false;
            class1.isRunning = false;
        }
        this.copyButton.Enabled = true;
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  All running tasks CANCELLED by user!\n");
    }

    private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void checkoutProfileBox_Click(object sender, EventArgs e)
    {
    }

    private void checkoutProfileBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void checkProductStockToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!this.method_26(this.string_8, this.string_9, 3))
        {
            new StockChecker(this).Show();
        }
        string[] strArray = this.method_27(this.string_8, this.string_9, 4);
        if (strArray[0] != null)
        {
            new StockChecker(this, this.int_2, true, Class21.smethod_6(strArray[0], this.string_11), Class21.smethod_6(strArray[1], this.string_11), Class21.smethod_6(strArray[2], this.string_11), Class21.smethod_6(strArray[3], this.string_11), Class21.smethod_6(strArray[4], this.string_11), Class21.smethod_6(strArray[5], this.string_11), Class21.smethod_6(strArray[6], this.string_11), Class21.smethod_6(strArray[7], this.string_11), strArray[8], Class21.smethod_6(strArray[9], this.string_11)) { StartPosition = FormStartPosition.CenterParent }.Show();
        }
        else
        {
            string[] strArray2 = this.method_27(this.string_8, this.string_9, 3);
            if (strArray2[0] != null)
            {
                new StockChecker(this, this.int_2, false, Class21.smethod_6(strArray2[0], this.string_11), Class21.smethod_6(strArray2[1], this.string_11), Class21.smethod_6(strArray2[2], this.string_11), Class21.smethod_6(strArray2[3], this.string_11), Class21.smethod_6(strArray2[4], this.string_11), Class21.smethod_6(strArray2[5], this.string_11), Class21.smethod_6(strArray2[6], this.string_11), Class21.smethod_6(strArray2[7], this.string_11), strArray2[8]) { StartPosition = FormStartPosition.CenterParent }.Show();
            }
        }
    }

    private void completedTaskOListView_CellEditFinishing(object sender, CellEditEventArgs e)
    {
        if ((e.Column.Index != 4) && (e.Column.Index != 5))
        {
            e.Cancel = true;
        }
        if (e.Column.Index == 5)
        {
            ((GClass0) e.RowObject).checkoutProfile = (GClass4) ((ComboBox) e.Control).SelectedItem;
            ((FastObjectListView) sender).RefreshItem(e.ListViewItem);
            e.Cancel = true;
        }
    }

    private void completedTaskOListView_CellEditStarting(object sender, CellEditEventArgs e)
    {
        if (e.Column.DisplayIndex == 5)
        {
            ComboBox box = new ComboBox();
            ArrayList list = (ArrayList) this.arrayList_5.Clone();
            box.DisplayMember = "profileName";
            box.DataSource = list;
            box.SelectedItem = ((GClass0) e.RowObject).checkoutProfile;
            e.Control = box;
            e.Control.Location = e.CellBounds.Location;
        }
    }

    private void completedTaskOListView_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cookie10Interval_Click(object sender, EventArgs e)
    {
        if (this.cookie10Interval.Checked)
        {
            this.thread_10 = new Thread(new ThreadStart(this.method_36));
            this.thread_10.IsBackground = true;
            this.thread_10.Start();
        }
        else if ((this.thread_10 != null) && this.thread_10.IsAlive)
        {
            this.thread_10.Abort();
        }
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
        this.manualResetEvent_0.Reset();
        try
        {
            Clipboard.SetText(this.queue_0.Dequeue().string_0);
        }
        catch (Exception)
        {
        }
        this.manualResetEvent_0.Set();
    }

    private void deleteCompletedBox_CheckedChanged(object sender, EventArgs e)
    {
        if (this.deleteCompletedBox.Checked)
        {
            for (int i = this.arrayList_3.Count - 1; i >= 0; i--)
            {
                if (((GClass0) this.arrayList_3[i]).isCheckout)
                {
                    this.arrayList_3.RemoveAt(i);
                }
            }
            MethodInvoker method = new MethodInvoker(this.method_80);
            base.Invoke(method);
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

    private void enableSmallScreenModeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.metroTabControl1.Size = new Size(0x31d, 180);
        this.groupBox3.Size = new Size(0x166, 200);
        this.groupBox4.Size = new Size(0x166, 0xaf);
        this.groupBox2.Location = new Point(0x2f, 90);
        this.groupBox4.Location = new Point(0x2f, 450);
        this.groupBox3.Location = new Point(0x2f, 250);
        this.label2.Location = new Point(0x490, 0x267);
        base.Size = new Size(0x501, 0x2a3);
    }

    private void expiringLabel_Click(object sender, EventArgs e)
    {
    }

    private void fetchAPIKeyFromProductPageToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FetchApiKey key = new FetchApiKey {
            StartPosition = FormStartPosition.CenterParent
        };
        if (key.ShowDialog(this) == DialogResult.OK)
        {
            this.method_39(key.string_0);
        }
    }

    private void fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FetchApiWishlist wishlist = new FetchApiWishlist(this) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (wishlist.ShowDialog(this) == DialogResult.OK)
        {
            this.method_39(wishlist.string_0);
        }
    }

    private void getNewsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.method_23(false);
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox4_Enter(object sender, EventArgs e)
    {
    }

    private void hideLicenseNameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Text = "yCopp Ultimate Adidas Bot 2.2.1";
    }

    private void hmacBox_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(MainForm));
        this.panel1 = new Panel();
        this.button1 = new Button();
        this.label3 = new Label();
        this.tokenCountLabel = new Label();
        this.label5 = new Label();
        this.expiringLabel = new Label();
        this.copyButton = new Button();
        this.label1 = new Label();
        this.label6 = new Label();
        this.manualTextBox = new TextBox();
        this.updateButton = new Button();
        this.autoUpdateButton = new Button();
        this.label7 = new Label();
        this.label8 = new Label();
        this.label10 = new Label();
        this.pidBox = new TextBox();
        this.captchaDuplicateBox = new TextBox();
        this.needsCaptcha = new CheckBox();
        this.timePicker = new DateTimePicker();
        this.autoStart = new CheckBox();
        this.label12 = new Label();
        this.startSelectedButton = new Button();
        this.startAllButton = new Button();
        this.removeSelectedButton = new Button();
        this.sizeComboBox = new ComboBox();
        this.proxyBox = new TextBox();
        this.label15 = new Label();
        this.statusBox = new TextBox();
        this.cancelTasksButton = new Button();
        this.swapSizeButton = new Button();
        this.locationComboBox = new ComboBox();
        this.label16 = new Label();
        this.saveDefaultButton = new Button();
        this.label13 = new Label();
        this.timeLabel = new Label();
        this.automaticKeyBox = new CheckBox();
        this.updateAllButton = new Button();
        this.proxyUsernameBox = new TextBox();
        this.proxyPWBox = new TextBox();
        this.label22 = new Label();
        this.testProxyButton = new Button();
        this.removeAllButton = new Button();
        this.label21 = new Label();
        this.label23 = new Label();
        this.label24 = new Label();
        this.updateDuplicateManual = new Button();
        this.groupBox1 = new GroupBox();
        this.soundBox = new CheckBox();
        this.adidasAccountsCheck = new CheckBox();
        this.label11 = new Label();
        this.splashRadio = new RadioButton();
        this.normalRadio = new RadioButton();
        this.hmacBox = new CheckBox();
        this.alternative2Radio = new RadioButton();
        this.alternativeRadio = new RadioButton();
        this.label25 = new Label();
        this.updateNotifyLabel = new Label();
        this.label9 = new Label();
        this.twoCaptchaButton = new Button();
        this.menuStrip1 = new MenuStrip();
        this.settingsToolStripMenuItem = new ToolStripMenuItem();
        this.setup2CaptchaToolStripMenuItem = new ToolStripMenuItem();
        this.antiCaptchaSetupToolStripMenuItem = new ToolStripMenuItem();
        this.manageAutoCheckoutProfilesToolStripMenuItem = new ToolStripMenuItem();
        this.addAdidasAccountsToolStripMenuItem = new ToolStripMenuItem();
        this.enableSmallScreenModeToolStripMenuItem = new ToolStripMenuItem();
        this.hideLicenseNameToolStripMenuItem = new ToolStripMenuItem();
        this.toolsToolStripMenuItem = new ToolStripMenuItem();
        this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem = new ToolStripMenuItem();
        this.fetchAPIKeyFromProductPageToolStripMenuItem = new ToolStripMenuItem();
        this.checkProductStockToolStripMenuItem = new ToolStripMenuItem();
        this.splashBruteForcerToolStripMenuItem = new ToolStripMenuItem();
        this.splashPageBruteForcerRequestsToolStripMenuItem = new ToolStripMenuItem();
        this.advancedToolStripMenuItem = new ToolStripMenuItem();
        this.manuallySetToolStripMenuItem = new ToolStripMenuItem();
        this.setCustomUserAgentToolStripMenuItem = new ToolStripMenuItem();
        this.setCustomPreloadLinkToolStripMenuItem = new ToolStripMenuItem();
        this.useDefaultMethod = new ToolStripMenuItem();
        this.sendProductCountRequest = new ToolStripMenuItem();
        this.cookie10Interval = new ToolStripMenuItem();
        this.disableCookiePreloadToolStripMenuItem = new ToolStripMenuItem();
        this.setTaskDelayToolStripMenuItem = new ToolStripMenuItem();
        this.devHideAutoCheckoutToolStripMenuItem = new ToolStripMenuItem();
        this.helpToolStripMenuItem = new ToolStripMenuItem();
        this.getNewsToolStripMenuItem = new ToolStripMenuItem();
        this.checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
        this.resetMachineBindingToolStripMenuItem = new ToolStripMenuItem();
        this.loadSetupForNextReleaseToolStripMenuItem = new ToolStripMenuItem();
        this.automaticUpdater1 = new AutomaticUpdater();
        this.nmdPreloadButton = new Button();
        this.backgroundWorker_0 = new BackgroundWorker();
        this.backgroundWorker_1 = new BackgroundWorker();
        this.hmacLabel = new Label();
        this.hmacExpireLabel = new Label();
        this.removeHmacBtn = new Button();
        this.completedTaskOListView = new FastObjectListView();
        this.olvcolumn_8 = new OLVColumn();
        this.olvcolumn_9 = new OLVColumn();
        this.olvcolumn_10 = new OLVColumn();
        this.olvcolumn_11 = new OLVColumn();
        this.olvcolumn_15 = new OLVColumn();
        this.olvcolumn_19 = new OLVColumn();
        this.olvcolumn_18 = new OLVColumn();
        this.olvcolumn_12 = new OLVColumn();
        this.olvcolumn_13 = new OLVColumn();
        this.olvcolumn_14 = new OLVColumn();
        this.olvcolumn_16 = new OLVColumn();
        this.label17 = new Label();
        this.taskOListView = new FastObjectListView();
        this.olvcolumn_0 = new OLVColumn();
        this.olvcolumn_1 = new OLVColumn();
        this.olvcolumn_2 = new OLVColumn();
        this.olvcolumn_3 = new OLVColumn();
        this.olvcolumn_17 = new OLVColumn();
        this.olvcolumn_6 = new OLVColumn();
        this.olvcolumn_7 = new OLVColumn();
        this.olvcolumn_4 = new OLVColumn();
        this.olvcolumn_5 = new OLVColumn();
        this.label18 = new Label();
        this.taskButtonsPanel = new Panel();
        this.captchaDupPanel = new Panel();
        this.panel2 = new Panel();
        this.metroButton1 = new Button();
        this.addTaskButton = new Button();
        this.label2 = new Label();
        this.pictureBox1 = new PictureBox();
        this.adidasAccountLabel = new Label();
        this.taskDelayLabel = new Label();
        this.addAndStartButton = new Button();
        this.browserHarvesterButton = new Button();
        this.anticaptchaButton = new Button();
        this.metroTabControl1 = new TabControl();
        this.metroTabPage1 = new TabPage();
        this.metroTabPage2 = new TabPage();
        this.groupBox2 = new GroupBox();
        this.deleteCompletedBox = new CheckBox();
        this.groupBox3 = new GroupBox();
        this.groupBox4 = new GroupBox();
        this.retryBox = new CheckBox();
        this.backgroundWorker_2 = new BackgroundWorker();
        this.label4 = new Label();
        this.checkoutProfileBox = new ComboBox();
        this.autoCheckoutCheckBox = new CheckBox();
        this.button2 = new Button();
        this.groupBox1.SuspendLayout();
        this.menuStrip1.SuspendLayout();
        ((ISupportInitialize) this.automaticUpdater1).BeginInit();
        ((ISupportInitialize) this.completedTaskOListView).BeginInit();
        ((ISupportInitialize) this.taskOListView).BeginInit();
        this.taskButtonsPanel.SuspendLayout();
        this.captchaDupPanel.SuspendLayout();
        this.panel2.SuspendLayout();
        ((ISupportInitialize) this.pictureBox1).BeginInit();
        this.metroTabControl1.SuspendLayout();
        this.metroTabPage1.SuspendLayout();
        this.metroTabPage2.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.groupBox4.SuspendLayout();
        base.SuspendLayout();
        this.panel1.Location = new Point(0x15, 13);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(0x34, 0x13);
        this.panel1.TabIndex = 0;
        this.button1.Location = new Point(0x19b, 2);
        this.button1.Name = "button1";
        this.button1.Size = new Size(130, 0x23);
        this.button1.TabIndex = 1;
        this.button1.Text = "Start Harvesting";
        this.button1.Visible = false;
        this.button1.Click += new EventHandler(this.button1_Click);
        this.label3.AutoSize = true;
        this.label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label3.Location = new Point(3, 3);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x84, 13);
        this.label3.TabIndex = 4;
        this.label3.Text = "Valid Tokens in Database:";
        this.tokenCountLabel.AutoSize = true;
        this.tokenCountLabel.Location = new Point(0x9d, 3);
        this.tokenCountLabel.Name = "tokenCountLabel";
        this.tokenCountLabel.Size = new Size(13, 13);
        this.tokenCountLabel.TabIndex = 5;
        this.tokenCountLabel.Text = "0";
        this.label5.AutoSize = true;
        this.label5.Location = new Point(3, 0x16);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0x74, 13);
        this.label5.TabIndex = 6;
        this.label5.Text = "Next Token expiring in:";
        this.expiringLabel.AutoSize = true;
        this.expiringLabel.Location = new Point(0x9d, 0x16);
        this.expiringLabel.Name = "expiringLabel";
        this.expiringLabel.Size = new Size(13, 13);
        this.expiringLabel.TabIndex = 7;
        this.expiringLabel.Text = "0";
        this.expiringLabel.Click += new EventHandler(this.expiringLabel_Click);
        this.copyButton.Location = new Point(200, 12);
        this.copyButton.Name = "copyButton";
        this.copyButton.Size = new Size(0x7e, 0x17);
        this.copyButton.TabIndex = 8;
        this.copyButton.Text = "Copy to Clipboard";
        this.copyButton.Click += new EventHandler(this.copyButton_Click);
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label1.Location = new Point(0x2f, 0x16);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x38, 13);
        this.label1.TabIndex = 12;
        this.label1.Text = "automatic:";
        this.label6.AutoSize = true;
        this.label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label6.Location = new Point(0x2f, 0x33);
        this.label6.Name = "label6";
        this.label6.Size = new Size(0x2c, 13);
        this.label6.TabIndex = 14;
        this.label6.Text = "manual:";
        this.manualTextBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.manualTextBox.Location = new Point(0x6c, 0x33);
        this.manualTextBox.Name = "manualTextBox";
        this.manualTextBox.Size = new Size(0x9d, 20);
        this.manualTextBox.TabIndex = 15;
        this.manualTextBox.TextChanged += new EventHandler(this.manualTextBox_TextChanged);
        this.updateButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.updateButton.Location = new Point(0x2f, 0x5d);
        this.updateButton.Name = "updateButton";
        this.updateButton.Size = new Size(130, 0x23);
        this.updateButton.TabIndex = 0x10;
        this.updateButton.Text = "Update once";
        this.updateButton.Click += new EventHandler(this.updateButton_Click);
        this.autoUpdateButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.autoUpdateButton.Location = new Point(0xba, 0x5d);
        this.autoUpdateButton.Name = "autoUpdateButton";
        this.autoUpdateButton.Size = new Size(130, 0x24);
        this.autoUpdateButton.TabIndex = 20;
        this.autoUpdateButton.Text = "Enable Auto Update";
        this.autoUpdateButton.Click += new EventHandler(this.autoUpdateButton_Click);
        this.label7.AutoSize = true;
        this.label7.Location = new Point(0x1cd, 160);
        this.label7.Name = "label7";
        this.label7.Size = new Size(0x1c, 13);
        this.label7.TabIndex = 0x16;
        this.label7.Text = "PID:";
        this.label8.AutoSize = true;
        this.label8.Location = new Point(0x1cd, 0xc1);
        this.label8.Name = "label8";
        this.label8.Size = new Size(30, 13);
        this.label8.TabIndex = 0x17;
        this.label8.Text = "Size:";
        this.label10.AutoSize = true;
        this.label10.Location = new Point(0x1cd, 0xe0);
        this.label10.Name = "label10";
        this.label10.Size = new Size(0x54, 13);
        this.label10.TabIndex = 0x19;
        this.label10.Text = "Needs Captcha:";
        this.pidBox.Location = new Point(0x25a, 160);
        this.pidBox.Name = "pidBox";
        this.pidBox.Size = new Size(0x79, 20);
        this.pidBox.TabIndex = 0x1a;
        this.captchaDuplicateBox.Location = new Point(0x48, 0x48);
        this.captchaDuplicateBox.Name = "captchaDuplicateBox";
        this.captchaDuplicateBox.Size = new Size(0x73, 20);
        this.captchaDuplicateBox.TabIndex = 0x1c;
        this.needsCaptcha.AutoSize = true;
        this.needsCaptcha.Checked = true;
        this.needsCaptcha.CheckState = CheckState.Checked;
        this.needsCaptcha.Location = new Point(0x25a, 0xe1);
        this.needsCaptcha.Name = "needsCaptcha";
        this.needsCaptcha.Size = new Size(0x1d, 0x11);
        this.needsCaptcha.TabIndex = 0x1d;
        this.needsCaptcha.Text = " ";
        this.needsCaptcha.UseVisualStyleBackColor = true;
        this.needsCaptcha.CheckedChanged += new EventHandler(this.needsCaptcha_CheckedChanged);
        this.timePicker.CustomFormat = "HH:mm:ss";
        this.timePicker.Enabled = false;
        this.timePicker.Format = DateTimePickerFormat.Time;
        this.timePicker.Location = new Point(0x274, 250);
        this.timePicker.MaxDate = new DateTime(0x802, 12, 0x1f, 0, 0, 0, 0);
        this.timePicker.MinDate = new DateTime(0x7e0, 1, 1, 0, 0, 0, 0);
        this.timePicker.Name = "timePicker";
        this.timePicker.ShowUpDown = true;
        this.timePicker.Size = new Size(200, 20);
        this.timePicker.TabIndex = 30;
        this.timePicker.ValueChanged += new EventHandler(this.timePicker_ValueChanged);
        this.autoStart.Location = new Point(0x25a, 0xfb);
        this.autoStart.Name = "autoStart";
        this.autoStart.Size = new Size(0x11, 0x11);
        this.autoStart.TabIndex = 0x1f;
        this.autoStart.Text = " ";
        this.autoStart.CheckedChanged += new EventHandler(this.autoStart_CheckedChanged);
        this.label12.AutoSize = true;
        this.label12.Location = new Point(0x1cd, 250);
        this.label12.Name = "label12";
        this.label12.Size = new Size(0x52, 13);
        this.label12.TabIndex = 0x21;
        this.label12.Text = "Automatic Start:";
        this.startSelectedButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.startSelectedButton.Location = new Point(0x7b, 10);
        this.startSelectedButton.Name = "startSelectedButton";
        this.startSelectedButton.Size = new Size(100, 0x23);
        this.startSelectedButton.TabIndex = 0x24;
        this.startSelectedButton.Text = "Start Selected";
        this.startSelectedButton.Click += new EventHandler(this.startSelectedButton_Click);
        this.startAllButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.startAllButton.Location = new Point(3, 10);
        this.startAllButton.Name = "startAllButton";
        this.startAllButton.Size = new Size(100, 0x23);
        this.startAllButton.TabIndex = 0x25;
        this.startAllButton.Text = "Start all";
        this.startAllButton.Click += new EventHandler(this.startAllButton_Click);
        this.removeSelectedButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.removeSelectedButton.Location = new Point(0x7b, 0x3d);
        this.removeSelectedButton.Name = "removeSelectedButton";
        this.removeSelectedButton.Size = new Size(100, 0x23);
        this.removeSelectedButton.TabIndex = 0x26;
        this.removeSelectedButton.Text = "Remove Selected";
        this.removeSelectedButton.Click += new EventHandler(this.removeSelectedButton_Click);
        this.sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.sizeComboBox.FormattingEnabled = true;
        this.sizeComboBox.ItemHeight = 13;
        object[] items = new object[] {
            "EU 36", "EU 36 2/3", "EU 37 1/3", "EU 38", "EU 38 2/3", "EU 39 1/3", "EU 40", "EU 40 2/3", "EU 41 1/3", "EU 42", "EU 42 2/3", "EU 43 1/3", "EU 44", "EU 44 2/3", "EU 45 1/3", "EU 46",
            "EU 46 2/3", "EU 47 1/3", "EU 48", "EU 48 2/3", "EU 49 1/3", "EU 51 1/3", "XS", "S", "M", "L", "XL", "2XL", "EU 17", "EU 18", "EU 19", "EU 20",
            "EU 21", "EU 22", "EU 23", "EU 23 1/3", "EU 24", "EU 25", "EU 25 1/2", "EU 26", "EU 26 1/2", "EU 27"
        };
        this.sizeComboBox.Items.AddRange(items);
        this.sizeComboBox.Location = new Point(0x25a, 0xbc);
        this.sizeComboBox.Name = "sizeComboBox";
        this.sizeComboBox.Size = new Size(0x79, 0x15);
        this.sizeComboBox.TabIndex = 0x2b;
        this.sizeComboBox.SelectedIndexChanged += new EventHandler(this.sizeComboBox_SelectedIndexChanged);
        this.proxyBox.Location = new Point(0x25a, 0x146);
        this.proxyBox.MaxLength = 100;
        this.proxyBox.Name = "proxyBox";
        this.proxyBox.Size = new Size(0xe2, 20);
        this.proxyBox.TabIndex = 0x2e;
        this.proxyBox.TextChanged += new EventHandler(this.proxyBox_TextChanged);
        this.label15.AutoSize = true;
        this.label15.Location = new Point(0x1cd, 0x146);
        this.label15.Name = "label15";
        this.label15.Size = new Size(0x60, 13);
        this.label15.TabIndex = 0x2f;
        this.label15.Text = "Proxy (HTTP only):";
        this.statusBox.Location = new Point(0x3a6, 0xf6);
        this.statusBox.Multiline = true;
        this.statusBox.Name = "statusBox";
        this.statusBox.ReadOnly = true;
        this.statusBox.ScrollBars = ScrollBars.Vertical;
        this.statusBox.Size = new Size(0x144, 0xab);
        this.statusBox.TabIndex = 0x30;
        this.cancelTasksButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.cancelTasksButton.Location = new Point(0x38, 0x71);
        this.cancelTasksButton.Name = "cancelTasksButton";
        this.cancelTasksButton.Size = new Size(130, 0x23);
        this.cancelTasksButton.TabIndex = 50;
        this.cancelTasksButton.Text = "Cancel all running tasks";
        this.cancelTasksButton.Click += new EventHandler(this.cancelTasksButton_Click);
        this.swapSizeButton.Location = new Point(0x2d9, 0xb7);
        this.swapSizeButton.Name = "swapSizeButton";
        this.swapSizeButton.Size = new Size(0x38, 0x1d);
        this.swapSizeButton.TabIndex = 0x33;
        this.swapSizeButton.Text = "US sizes";
        this.swapSizeButton.Click += new EventHandler(this.swapSizeButton_Click);
        this.locationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.locationComboBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.locationComboBox.FormattingEnabled = true;
        this.locationComboBox.ItemHeight = 13;
        object[] objArray2 = new object[] {
            "Germany", "Netherlands", "France", "Spain", "Italy", "United Kingdom", "United States", "Canada", "Australia", "Austria", "Belgium", "Sweden", "Denmark", "Norway", "Poland", "Czech Republic",
            "New Zealand", "Russia", "Mexico", "Portugal"
        };
        this.locationComboBox.Items.AddRange(objArray2);
        this.locationComboBox.Location = new Point(0x58, 0x15);
        this.locationComboBox.Name = "locationComboBox";
        this.locationComboBox.Size = new Size(0x79, 0x15);
        this.locationComboBox.TabIndex = 0x36;
        this.locationComboBox.SelectedIndexChanged += new EventHandler(this.locationComboBox_SelectedIndexChanged);
        this.label16.AutoSize = true;
        this.label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label16.Location = new Point(6, 0x16);
        this.label16.Name = "label16";
        this.label16.Size = new Size(0x33, 13);
        this.label16.TabIndex = 0x37;
        this.label16.Text = "Location:";
        this.saveDefaultButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.saveDefaultButton.Location = new Point(0xd7, 0x15);
        this.saveDefaultButton.Name = "saveDefaultButton";
        this.saveDefaultButton.Size = new Size(0x65, 0x17);
        this.saveDefaultButton.TabIndex = 0x38;
        this.saveDefaultButton.Text = "Set as default";
        this.saveDefaultButton.Click += new EventHandler(this.saveDefaultButton_Click);
        this.label13.AutoSize = true;
        this.label13.Location = new Point(0x469, 0x18);
        this.label13.Name = "label13";
        this.label13.Size = new Size(0x21, 13);
        this.label13.TabIndex = 0x3d;
        this.label13.Text = "Time:";
        this.timeLabel.AutoSize = true;
        this.timeLabel.Location = new Point(0x48d, 0x19);
        this.timeLabel.Name = "timeLabel";
        this.timeLabel.Size = new Size(0, 13);
        this.timeLabel.TabIndex = 0x3e;
        this.automaticKeyBox.AutoSize = true;
        this.automaticKeyBox.Checked = true;
        this.automaticKeyBox.CheckState = CheckState.Checked;
        this.automaticKeyBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.automaticKeyBox.Location = new Point(0x7b, 0x1a);
        this.automaticKeyBox.Name = "automaticKeyBox";
        this.automaticKeyBox.Size = new Size(0x1d, 0x11);
        this.automaticKeyBox.TabIndex = 0x42;
        this.automaticKeyBox.Text = " ";
        this.automaticKeyBox.CheckedChanged += new EventHandler(this.automaticKeyBox_CheckedChanged);
        this.updateAllButton.Location = new Point(0x48, 0x26);
        this.updateAllButton.Name = "updateAllButton";
        this.updateAllButton.Size = new Size(0x73, 0x17);
        this.updateAllButton.TabIndex = 70;
        this.updateAllButton.Text = "Enable Auto Update";
        this.updateAllButton.Click += new EventHandler(this.updateAllButton_Click);
        this.proxyUsernameBox.Location = new Point(0x25a, 0x160);
        this.proxyUsernameBox.Name = "proxyUsernameBox";
        this.proxyUsernameBox.Size = new Size(0x67, 20);
        this.proxyUsernameBox.TabIndex = 0x49;
        this.proxyPWBox.Location = new Point(0x2d2, 0x160);
        this.proxyPWBox.Name = "proxyPWBox";
        this.proxyPWBox.Size = new Size(0x6a, 20);
        this.proxyPWBox.TabIndex = 0x4a;
        this.label22.AutoSize = true;
        this.label22.Location = new Point(0x1cd, 0x160);
        this.label22.Name = "label22";
        this.label22.Size = new Size(0x41, 13);
        this.label22.TabIndex = 0x4b;
        this.label22.Text = "Proxy Login:";
        this.testProxyButton.Location = new Point(0x34c, 0x160);
        this.testProxyButton.Name = "testProxyButton";
        this.testProxyButton.Size = new Size(0x45, 20);
        this.testProxyButton.TabIndex = 80;
        this.testProxyButton.Text = "Test Proxy";
        this.testProxyButton.Click += new EventHandler(this.testProxyButton_Click);
        this.removeAllButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.removeAllButton.Location = new Point(3, 0x3d);
        this.removeAllButton.Name = "removeAllButton";
        this.removeAllButton.Size = new Size(100, 0x23);
        this.removeAllButton.TabIndex = 0x51;
        this.removeAllButton.Text = "Remove All";
        this.removeAllButton.Click += new EventHandler(this.removeAllButton_Click);
        this.label21.AutoSize = true;
        this.label21.Location = new Point(3, 9);
        this.label21.Name = "label21";
        this.label21.Size = new Size(0x8a, 13);
        this.label21.TabIndex = 0x54;
        this.label21.Text = "Captcha Duplicate retrieval:";
        this.label23.AutoSize = true;
        this.label23.Location = new Point(3, 0x4b);
        this.label23.Name = "label23";
        this.label23.Size = new Size(0x2c, 13);
        this.label23.TabIndex = 0x55;
        this.label23.Text = "manual:";
        this.label24.AutoSize = true;
        this.label24.Location = new Point(3, 0x26);
        this.label24.Name = "label24";
        this.label24.Size = new Size(0x38, 13);
        this.label24.TabIndex = 0x56;
        this.label24.Text = "automatic:";
        this.updateDuplicateManual.Location = new Point(0x48, 0x62);
        this.updateDuplicateManual.Name = "updateDuplicateManual";
        this.updateDuplicateManual.Size = new Size(0x73, 0x17);
        this.updateDuplicateManual.TabIndex = 0x57;
        this.updateDuplicateManual.Text = "Update manually";
        this.updateDuplicateManual.Click += new EventHandler(this.updateDuplicateManual_Click);
        this.groupBox1.Controls.Add(this.soundBox);
        this.groupBox1.Controls.Add(this.adidasAccountsCheck);
        this.groupBox1.Controls.Add(this.label11);
        this.groupBox1.Controls.Add(this.splashRadio);
        this.groupBox1.Controls.Add(this.normalRadio);
        this.groupBox1.Controls.Add(this.label16);
        this.groupBox1.Controls.Add(this.locationComboBox);
        this.groupBox1.Controls.Add(this.saveDefaultButton);
        this.groupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.groupBox1.Location = new Point(0x3a6, 0x4d);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(0x144, 160);
        this.groupBox1.TabIndex = 0x58;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Global Setup:";
        this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
        this.soundBox.AutoSize = true;
        this.soundBox.Checked = true;
        this.soundBox.CheckState = CheckState.Checked;
        this.soundBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.soundBox.Location = new Point(6, 0x7d);
        this.soundBox.Name = "soundBox";
        this.soundBox.Size = new Size(150, 0x11);
        this.soundBox.TabIndex = 0x58;
        this.soundBox.Text = "Enable sound notifications";
        this.soundBox.UseVisualStyleBackColor = true;
        this.soundBox.CheckedChanged += new EventHandler(this.soundBox_CheckedChanged);
        this.adidasAccountsCheck.AutoSize = true;
        this.adidasAccountsCheck.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.adidasAccountsCheck.Location = new Point(6, 0x5d);
        this.adidasAccountsCheck.Name = "adidasAccountsCheck";
        this.adidasAccountsCheck.RightToLeft = RightToLeft.No;
        this.adidasAccountsCheck.Size = new Size(0xcf, 0x11);
        this.adidasAccountsCheck.TabIndex = 0x57;
        this.adidasAccountsCheck.Text = "Log in to adidas accounts (if available)";
        this.adidasAccountsCheck.UseVisualStyleBackColor = true;
        this.adidasAccountsCheck.CheckedChanged += new EventHandler(this.adidasAccountsCheck_CheckedChanged);
        this.label11.AutoSize = true;
        this.label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label11.Location = new Point(6, 0x40);
        this.label11.Name = "label11";
        this.label11.Size = new Size(0x36, 13);
        this.label11.TabIndex = 0x54;
        this.label11.Text = "BD mode:";
        this.splashRadio.AutoSize = true;
        this.splashRadio.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.splashRadio.Location = new Point(0xb0, 0x42);
        this.splashRadio.Name = "splashRadio";
        this.splashRadio.Size = new Size(0x4a, 0x11);
        this.splashRadio.TabIndex = 0x52;
        this.splashRadio.Text = "alternative";
        this.splashRadio.UseVisualStyleBackColor = true;
        this.splashRadio.CheckedChanged += new EventHandler(this.splashRadio_CheckedChanged);
        this.normalRadio.AutoSize = true;
        this.normalRadio.Checked = true;
        this.normalRadio.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.normalRadio.Location = new Point(0x58, 0x42);
        this.normalRadio.Name = "normalRadio";
        this.normalRadio.Size = new Size(0x38, 0x11);
        this.normalRadio.TabIndex = 0x51;
        this.normalRadio.TabStop = true;
        this.normalRadio.Text = "normal";
        this.normalRadio.UseVisualStyleBackColor = true;
        this.hmacBox.AutoSize = true;
        this.hmacBox.Enabled = false;
        this.hmacBox.Location = new Point(420, 10);
        this.hmacBox.Name = "hmacBox";
        this.hmacBox.Size = new Size(0xfb, 0x11);
        this.hmacBox.TabIndex = 0x55;
        this.hmacBox.Text = "̶r̶̶e̶̶t̶̶r̶̶i̶̶e̶̶v̶̶e̶̶ ̶̶h̶̶m̶̶a̶̶c̶̶ ̶(̶r̶̶e̶̶c̶̶o̶̶m̶̶m̶̶e̶̶n̶̶d̶̶e̶̶d̶̶ ̶̶f̶̶o̶̶r̶̶ ̶̶s̶̶p̶̶l̶̶a̶̶s̶̶h̶̶ ̶̶r̶̶e̶̶l̶̶e̶̶a̶̶s̶̶e̶)";
        this.hmacBox.UseVisualStyleBackColor = true;
        this.hmacBox.Visible = false;
        this.hmacBox.CheckedChanged += new EventHandler(this.hmacBox_CheckedChanged);
        this.alternative2Radio.AutoSize = true;
        this.alternative2Radio.Location = new Point(0x299, 0x5f);
        this.alternative2Radio.Name = "alternative2Radio";
        this.alternative2Radio.Size = new Size(0x53, 0x11);
        this.alternative2Radio.TabIndex = 0x56;
        this.alternative2Radio.Text = "alternative 2";
        this.alternative2Radio.UseVisualStyleBackColor = true;
        this.alternative2Radio.Visible = false;
        this.alternativeRadio.AutoSize = true;
        this.alternativeRadio.Location = new Point(0x241, 0x5f);
        this.alternativeRadio.Name = "alternativeRadio";
        this.alternativeRadio.Size = new Size(0x4a, 0x11);
        this.alternativeRadio.TabIndex = 0x53;
        this.alternativeRadio.Text = "alternative";
        this.alternativeRadio.UseVisualStyleBackColor = true;
        this.alternativeRadio.Visible = false;
        this.label25.AutoSize = true;
        this.label25.Location = new Point(0x2c4, 0x163);
        this.label25.Name = "label25";
        this.label25.Size = new Size(10, 13);
        this.label25.TabIndex = 0x59;
        this.label25.Text = ":";
        this.updateNotifyLabel.AutoSize = true;
        this.updateNotifyLabel.ForeColor = Color.Red;
        this.updateNotifyLabel.Location = new Point(0x195, 12);
        this.updateNotifyLabel.Name = "updateNotifyLabel";
        this.updateNotifyLabel.Size = new Size(0, 13);
        this.updateNotifyLabel.TabIndex = 90;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(0x1cd, 0x84);
        this.label9.Name = "label9";
        this.label9.Size = new Size(0x3b, 13);
        this.label9.TabIndex = 0x5b;
        this.label9.Text = "New Task:";
        this.twoCaptchaButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.twoCaptchaButton.Location = new Point(0x2f, 0x23);
        this.twoCaptchaButton.Name = "twoCaptchaButton";
        this.twoCaptchaButton.Size = new Size(130, 0x23);
        this.twoCaptchaButton.TabIndex = 0x5c;
        this.twoCaptchaButton.Text = "Start 2Captcha";
        this.twoCaptchaButton.Click += new EventHandler(this.twoCaptchaButton_Click);
        this.menuStrip1.AutoSize = false;
        this.menuStrip1.BackColor = SystemColors.Control;
        this.menuStrip1.Dock = DockStyle.None;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.settingsToolStripMenuItem, this.toolsToolStripMenuItem, this.advancedToolStripMenuItem, this.helpToolStripMenuItem, this.loadSetupForNextReleaseToolStripMenuItem };
        this.menuStrip1.Items.AddRange(toolStripItems);
        this.menuStrip1.Location = new Point(0, 13);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new Size(0x4c9, 0x18);
        this.menuStrip1.TabIndex = 0x5e;
        this.menuStrip1.Text = "menuStrip1";
        this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.setup2CaptchaToolStripMenuItem, this.antiCaptchaSetupToolStripMenuItem, this.manageAutoCheckoutProfilesToolStripMenuItem, this.addAdidasAccountsToolStripMenuItem, this.enableSmallScreenModeToolStripMenuItem, this.hideLicenseNameToolStripMenuItem };
        this.settingsToolStripMenuItem.DropDownItems.AddRange(itemArray2);
        this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
        this.settingsToolStripMenuItem.Size = new Size(0x3d, 20);
        this.settingsToolStripMenuItem.Text = "Settings";
        this.settingsToolStripMenuItem.Click += new EventHandler(this.settingsToolStripMenuItem_Click);
        this.setup2CaptchaToolStripMenuItem.Name = "setup2CaptchaToolStripMenuItem";
        this.setup2CaptchaToolStripMenuItem.Size = new Size(0xf2, 0x16);
        this.setup2CaptchaToolStripMenuItem.Text = "2Captcha Setup";
        this.setup2CaptchaToolStripMenuItem.Click += new EventHandler(this.setup2CaptchaToolStripMenuItem_Click);
        this.antiCaptchaSetupToolStripMenuItem.Name = "antiCaptchaSetupToolStripMenuItem";
        this.antiCaptchaSetupToolStripMenuItem.Size = new Size(0xf2, 0x16);
        this.antiCaptchaSetupToolStripMenuItem.Text = "Anti-Captcha Setup";
        this.antiCaptchaSetupToolStripMenuItem.Click += new EventHandler(this.antiCaptchaSetupToolStripMenuItem_Click);
        this.manageAutoCheckoutProfilesToolStripMenuItem.Name = "manageAutoCheckoutProfilesToolStripMenuItem";
        this.manageAutoCheckoutProfilesToolStripMenuItem.Size = new Size(0xf2, 0x16);
        this.manageAutoCheckoutProfilesToolStripMenuItem.Text = "Manage Auto Checkout Profiles";
        this.manageAutoCheckoutProfilesToolStripMenuItem.Click += new EventHandler(this.manageAutoCheckoutProfilesToolStripMenuItem_Click);
        this.addAdidasAccountsToolStripMenuItem.Name = "addAdidasAccountsToolStripMenuItem";
        this.addAdidasAccountsToolStripMenuItem.Size = new Size(0xf2, 0x16);
        this.addAdidasAccountsToolStripMenuItem.Text = "Add Adidas Accounts";
        this.addAdidasAccountsToolStripMenuItem.Click += new EventHandler(this.addAdidasAccountsToolStripMenuItem_Click);
        this.enableSmallScreenModeToolStripMenuItem.Name = "enableSmallScreenModeToolStripMenuItem";
        this.enableSmallScreenModeToolStripMenuItem.Size = new Size(0xf2, 0x16);
        this.enableSmallScreenModeToolStripMenuItem.Text = "Enable small screen mode";
        this.enableSmallScreenModeToolStripMenuItem.Click += new EventHandler(this.enableSmallScreenModeToolStripMenuItem_Click);
        this.hideLicenseNameToolStripMenuItem.Name = "hideLicenseNameToolStripMenuItem";
        this.hideLicenseNameToolStripMenuItem.Size = new Size(0xf2, 0x16);
        this.hideLicenseNameToolStripMenuItem.Text = "Hide license name";
        this.hideLicenseNameToolStripMenuItem.Click += new EventHandler(this.hideLicenseNameToolStripMenuItem_Click);
        ToolStripItem[] itemArray3 = new ToolStripItem[] { this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem, this.fetchAPIKeyFromProductPageToolStripMenuItem, this.checkProductStockToolStripMenuItem, this.splashBruteForcerToolStripMenuItem, this.splashPageBruteForcerRequestsToolStripMenuItem };
        this.toolsToolStripMenuItem.DropDownItems.AddRange(itemArray3);
        this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        this.toolsToolStripMenuItem.Size = new Size(0x2f, 20);
        this.toolsToolStripMenuItem.Text = "Tools";
        this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem.Name = "fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem";
        this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem.Size = new Size(0x106, 0x16);
        this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem.Text = "Fetch API-Key from wishlist";
        this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem.Click += new EventHandler(this.fetchAPIKeyFromWishlistworkingForYeezyToolStripMenuItem_Click);
        this.fetchAPIKeyFromProductPageToolStripMenuItem.Name = "fetchAPIKeyFromProductPageToolStripMenuItem";
        this.fetchAPIKeyFromProductPageToolStripMenuItem.Size = new Size(0x106, 0x16);
        this.fetchAPIKeyFromProductPageToolStripMenuItem.Text = "Fetch API-Key from product page";
        this.fetchAPIKeyFromProductPageToolStripMenuItem.Click += new EventHandler(this.fetchAPIKeyFromProductPageToolStripMenuItem_Click);
        this.checkProductStockToolStripMenuItem.Name = "checkProductStockToolStripMenuItem";
        this.checkProductStockToolStripMenuItem.Size = new Size(0x106, 0x16);
        this.checkProductStockToolStripMenuItem.Text = "Check product stock";
        this.checkProductStockToolStripMenuItem.Click += new EventHandler(this.checkProductStockToolStripMenuItem_Click);
        this.splashBruteForcerToolStripMenuItem.Name = "splashBruteForcerToolStripMenuItem";
        this.splashBruteForcerToolStripMenuItem.Size = new Size(0x106, 0x16);
        this.splashBruteForcerToolStripMenuItem.Text = "Splash Page Brute Forcer (Browser)";
        this.splashBruteForcerToolStripMenuItem.Click += new EventHandler(this.splashBruteForcerToolStripMenuItem_Click);
        this.splashPageBruteForcerRequestsToolStripMenuItem.Name = "splashPageBruteForcerRequestsToolStripMenuItem";
        this.splashPageBruteForcerRequestsToolStripMenuItem.Size = new Size(0x106, 0x16);
        this.splashPageBruteForcerRequestsToolStripMenuItem.Text = "Splash Page Brute Forcer (Requests)";
        this.splashPageBruteForcerRequestsToolStripMenuItem.Click += new EventHandler(this.splashPageBruteForcerRequestsToolStripMenuItem_Click);
        ToolStripItem[] itemArray4 = new ToolStripItem[] { this.manuallySetToolStripMenuItem, this.setCustomUserAgentToolStripMenuItem, this.setCustomPreloadLinkToolStripMenuItem, this.useDefaultMethod, this.sendProductCountRequest, this.cookie10Interval, this.disableCookiePreloadToolStripMenuItem, this.setTaskDelayToolStripMenuItem, this.devHideAutoCheckoutToolStripMenuItem };
        this.advancedToolStripMenuItem.DropDownItems.AddRange(itemArray4);
        this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
        this.advancedToolStripMenuItem.Size = new Size(0x48, 20);
        this.advancedToolStripMenuItem.Text = "Advanced";
        this.manuallySetToolStripMenuItem.Name = "manuallySetToolStripMenuItem";
        this.manuallySetToolStripMenuItem.Size = new Size(0x128, 0x16);
        this.manuallySetToolStripMenuItem.Text = "Set a cookie";
        this.manuallySetToolStripMenuItem.Click += new EventHandler(this.manuallySetToolStripMenuItem_Click);
        this.setCustomUserAgentToolStripMenuItem.Name = "setCustomUserAgentToolStripMenuItem";
        this.setCustomUserAgentToolStripMenuItem.Size = new Size(0x128, 0x16);
        this.setCustomUserAgentToolStripMenuItem.Text = "Set custom user agent";
        this.setCustomUserAgentToolStripMenuItem.Click += new EventHandler(this.setCustomUserAgentToolStripMenuItem_Click);
        this.setCustomPreloadLinkToolStripMenuItem.Name = "setCustomPreloadLinkToolStripMenuItem";
        this.setCustomPreloadLinkToolStripMenuItem.Size = new Size(0x128, 0x16);
        this.setCustomPreloadLinkToolStripMenuItem.Text = "Set custom preload link";
        this.setCustomPreloadLinkToolStripMenuItem.Click += new EventHandler(this.setCustomPreloadLinkToolStripMenuItem_Click);
        this.useDefaultMethod.CheckOnClick = true;
        this.useDefaultMethod.Name = "useDefaultMethod";
        this.useDefaultMethod.Size = new Size(0x128, 0x16);
        this.useDefaultMethod.Text = "Use '/default/' BD method (deprecated)";
        this.useDefaultMethod.Click += new EventHandler(this.useDefaultMethod_Click);
        this.sendProductCountRequest.CheckOnClick = true;
        this.sendProductCountRequest.Name = "sendProductCountRequest";
        this.sendProductCountRequest.Size = new Size(0x128, 0x16);
        this.sendProductCountRequest.Text = "Send 'ProductCount' request (deprecated)";
        this.cookie10Interval.CheckOnClick = true;
        this.cookie10Interval.Name = "cookie10Interval";
        this.cookie10Interval.Size = new Size(0x128, 0x16);
        this.cookie10Interval.Text = "Enable 10 minute gceeqs preload interval";
        this.cookie10Interval.Visible = false;
        this.cookie10Interval.Click += new EventHandler(this.cookie10Interval_Click);
        this.disableCookiePreloadToolStripMenuItem.Checked = true;
        this.disableCookiePreloadToolStripMenuItem.CheckOnClick = true;
        this.disableCookiePreloadToolStripMenuItem.CheckState = CheckState.Checked;
        this.disableCookiePreloadToolStripMenuItem.Name = "disableCookiePreloadToolStripMenuItem";
        this.disableCookiePreloadToolStripMenuItem.Size = new Size(0x128, 0x16);
        this.disableCookiePreloadToolStripMenuItem.Text = "Disable cookie preload";
        this.setTaskDelayToolStripMenuItem.Name = "setTaskDelayToolStripMenuItem";
        this.setTaskDelayToolStripMenuItem.Size = new Size(0x128, 0x16);
        this.setTaskDelayToolStripMenuItem.Text = "Set global task delay";
        this.setTaskDelayToolStripMenuItem.Click += new EventHandler(this.setTaskDelayToolStripMenuItem_Click);
        this.devHideAutoCheckoutToolStripMenuItem.Checked = true;
        this.devHideAutoCheckoutToolStripMenuItem.CheckOnClick = true;
        this.devHideAutoCheckoutToolStripMenuItem.CheckState = CheckState.Checked;
        this.devHideAutoCheckoutToolStripMenuItem.Name = "devHideAutoCheckoutToolStripMenuItem";
        this.devHideAutoCheckoutToolStripMenuItem.Size = new Size(0x128, 0x16);
        this.devHideAutoCheckoutToolStripMenuItem.Text = "dev: hide auto checkout";
        this.devHideAutoCheckoutToolStripMenuItem.Visible = false;
        ToolStripItem[] itemArray5 = new ToolStripItem[] { this.getNewsToolStripMenuItem, this.checkForUpdateToolStripMenuItem, this.resetMachineBindingToolStripMenuItem };
        this.helpToolStripMenuItem.DropDownItems.AddRange(itemArray5);
        this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        this.helpToolStripMenuItem.Size = new Size(0x2c, 20);
        this.helpToolStripMenuItem.Text = "Help";
        this.getNewsToolStripMenuItem.Name = "getNewsToolStripMenuItem";
        this.getNewsToolStripMenuItem.Size = new Size(0xc3, 0x16);
        this.getNewsToolStripMenuItem.Text = "Get News";
        this.getNewsToolStripMenuItem.Click += new EventHandler(this.getNewsToolStripMenuItem_Click);
        this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
        this.checkForUpdateToolStripMenuItem.Size = new Size(0xc3, 0x16);
        this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
        this.checkForUpdateToolStripMenuItem.Click += new EventHandler(this.checkForUpdateToolStripMenuItem_Click);
        this.resetMachineBindingToolStripMenuItem.Name = "resetMachineBindingToolStripMenuItem";
        this.resetMachineBindingToolStripMenuItem.Size = new Size(0xc3, 0x16);
        this.resetMachineBindingToolStripMenuItem.Text = "Reset Machine Binding";
        this.resetMachineBindingToolStripMenuItem.Click += new EventHandler(this.resetMachineBindingToolStripMenuItem_Click);
        this.loadSetupForNextReleaseToolStripMenuItem.Name = "loadSetupForNextReleaseToolStripMenuItem";
        this.loadSetupForNextReleaseToolStripMenuItem.Size = new Size(0x9f, 20);
        this.loadSetupForNextReleaseToolStripMenuItem.Text = "Load setup for next release";
        this.loadSetupForNextReleaseToolStripMenuItem.Click += new EventHandler(this.loadSetupForNextReleaseToolStripMenuItem_Click);
        this.automaticUpdater1.ContainerForm = this;
        this.automaticUpdater1.DaysBetweenChecks = 0;
        this.automaticUpdater1.GUID = "e5e9cdeb-27ca-4bd1-8595-d4374cd827d5";
        this.automaticUpdater1.Location = new Point(0x3a6, 15);
        this.automaticUpdater1.Name = "automaticUpdater1";
        this.automaticUpdater1.Size = new Size(0x10, 0x10);
        this.automaticUpdater1.TabIndex = 0x5f;
        this.automaticUpdater1.ToolStripItem = this.checkForUpdateToolStripMenuItem;
        this.automaticUpdater1.WaitBeforeCheckSecs = 5;
        this.automaticUpdater1.wyUpdateCommandline = null;
        this.nmdPreloadButton.Location = new Point(0x1b1, 0x56);
        this.nmdPreloadButton.Name = "nmdPreloadButton";
        this.nmdPreloadButton.Size = new Size(0x37, 0x18);
        this.nmdPreloadButton.TabIndex = 0x57;
        this.nmdPreloadButton.Text = "Only start this if splash is not live 10 minutes before release ";
        this.nmdPreloadButton.Visible = false;
        this.nmdPreloadButton.Click += new EventHandler(this.nmdPreloadButton_Click);
        this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
        this.hmacLabel.AutoSize = true;
        this.hmacLabel.ForeColor = Color.Green;
        this.hmacLabel.Location = new Point(0x319, 0x30);
        this.hmacLabel.Name = "hmacLabel";
        this.hmacLabel.Size = new Size(90, 13);
        this.hmacLabel.TabIndex = 0x60;
        this.hmacLabel.Text = "HMAC cookie set";
        this.hmacLabel.Visible = false;
        this.hmacExpireLabel.AutoSize = true;
        this.hmacExpireLabel.ForeColor = Color.Green;
        this.hmacExpireLabel.Location = new Point(0x319, 70);
        this.hmacExpireLabel.Name = "hmacExpireLabel";
        this.hmacExpireLabel.Size = new Size(0x34, 13);
        this.hmacExpireLabel.TabIndex = 0x61;
        this.hmacExpireLabel.Text = "Expires in";
        this.hmacExpireLabel.Visible = false;
        this.removeHmacBtn.Location = new Point(0x31c, 0x5e);
        this.removeHmacBtn.Name = "removeHmacBtn";
        this.removeHmacBtn.Size = new Size(90, 0x17);
        this.removeHmacBtn.TabIndex = 0x62;
        this.removeHmacBtn.Text = "Remove HMAC";
        this.removeHmacBtn.Visible = false;
        this.removeHmacBtn.Click += new EventHandler(this.removeHmacBtn_Click);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_8);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_9);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_10);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_11);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_15);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_19);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_18);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_12);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_13);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_14);
        this.completedTaskOListView.AllColumns.Add(this.olvcolumn_16);
        this.completedTaskOListView.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.completedTaskOListView.CellEditActivation = ObjectListView.CellEditActivateMode.DoubleClick;
        this.completedTaskOListView.CellEditUseWholeCell = false;
        ColumnHeader[] values = new ColumnHeader[] { this.olvcolumn_8, this.olvcolumn_9, this.olvcolumn_10, this.olvcolumn_11, this.olvcolumn_15, this.olvcolumn_19, this.olvcolumn_18, this.olvcolumn_12, this.olvcolumn_13, this.olvcolumn_14, this.olvcolumn_16 };
        this.completedTaskOListView.Columns.AddRange(values);
        this.completedTaskOListView.Cursor = Cursors.Default;
        this.completedTaskOListView.Location = new Point(0, 0);
        this.completedTaskOListView.MinimumSize = new Size(4, 60);
        this.completedTaskOListView.Name = "completedTaskOListView";
        this.completedTaskOListView.RowHeight = 0x23;
        this.completedTaskOListView.ShowGroups = false;
        this.completedTaskOListView.Size = new Size(0x315, 0x100);
        this.completedTaskOListView.TabIndex = 0x43;
        this.completedTaskOListView.UseCompatibleStateImageBehavior = false;
        this.completedTaskOListView.View = View.Details;
        this.completedTaskOListView.VirtualMode = true;
        this.completedTaskOListView.CellEditFinishing += new CellEditEventHandler(this.completedTaskOListView_CellEditFinishing);
        this.completedTaskOListView.CellEditStarting += new CellEditEventHandler(this.completedTaskOListView_CellEditStarting);
        this.completedTaskOListView.CellRightClick += new EventHandler<CellRightClickEventArgs>(this.method_44);
        this.completedTaskOListView.FormatRow += new EventHandler<FormatRowEventArgs>(this.method_47);
        this.completedTaskOListView.SelectedIndexChanged += new EventHandler(this.completedTaskOListView_SelectedIndexChanged);
        this.olvcolumn_8.AspectName = "id";
        this.olvcolumn_8.Text = "ID";
        this.olvcolumn_8.Width = 0x29;
        this.olvcolumn_9.AspectName = "pid";
        this.olvcolumn_9.Text = "PID";
        this.olvcolumn_9.Width = 0x38;
        this.olvcolumn_10.AspectName = "getSizeString";
        this.olvcolumn_10.Text = "Size";
        this.olvcolumn_10.Width = 0x4e;
        this.olvcolumn_11.AspectName = "getRemainingTime";
        this.olvcolumn_11.Text = "Time remaining";
        this.olvcolumn_11.Width = 0x57;
        this.olvcolumn_15.AspectName = "useProxyCheckout";
        this.olvcolumn_15.Text = "Use Proxy";
        this.olvcolumn_15.Width = 0x41;
        this.olvcolumn_19.AspectName = "getCheckoutProfileName";
        this.olvcolumn_19.Text = "Auto Checkout";
        this.olvcolumn_19.Width = 0x76;
        this.olvcolumn_18.AspectName = "button0";
        this.olvcolumn_18.IsButton = true;
        this.olvcolumn_18.IsEditable = false;
        this.olvcolumn_18.Text = "Action";
        this.olvcolumn_18.Width = 130;
        this.olvcolumn_12.AspectName = "button1";
        this.olvcolumn_12.IsButton = true;
        this.olvcolumn_12.Text = "Action";
        this.olvcolumn_12.Width = 90;
        this.olvcolumn_13.AspectName = "button2";
        this.olvcolumn_13.IsButton = true;
        this.olvcolumn_13.Text = "Action";
        this.olvcolumn_13.Width = 0x5c;
        this.olvcolumn_14.AspectName = "button3";
        this.olvcolumn_14.IsButton = true;
        this.olvcolumn_14.Text = "Action";
        this.olvcolumn_14.Width = 0x4b;
        this.olvcolumn_16.AspectName = "button4";
        this.olvcolumn_16.IsButton = true;
        this.olvcolumn_16.Text = "Action";
        this.olvcolumn_16.Width = 120;
        this.label17.AutoSize = true;
        this.label17.Location = new Point(-13, 0);
        this.label17.Name = "label17";
        this.label17.Size = new Size(110, 13);
        this.label17.TabIndex = 0x3b;
        this.label17.Text = "Waiting for Checkout:";
        this.label17.Visible = false;
        this.taskOListView.AllColumns.Add(this.olvcolumn_0);
        this.taskOListView.AllColumns.Add(this.olvcolumn_1);
        this.taskOListView.AllColumns.Add(this.olvcolumn_2);
        this.taskOListView.AllColumns.Add(this.olvcolumn_3);
        this.taskOListView.AllColumns.Add(this.olvcolumn_17);
        this.taskOListView.AllColumns.Add(this.olvcolumn_6);
        this.taskOListView.AllColumns.Add(this.olvcolumn_7);
        this.taskOListView.AllColumns.Add(this.olvcolumn_4);
        this.taskOListView.AllColumns.Add(this.olvcolumn_5);
        this.taskOListView.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.taskOListView.CellEditActivation = ObjectListView.CellEditActivateMode.DoubleClick;
        this.taskOListView.CellEditUseWholeCell = false;
        ColumnHeader[] headerArray2 = new ColumnHeader[] { this.olvcolumn_0, this.olvcolumn_1, this.olvcolumn_2, this.olvcolumn_3, this.olvcolumn_17, this.olvcolumn_6, this.olvcolumn_7, this.olvcolumn_4, this.olvcolumn_5 };
        this.taskOListView.Columns.AddRange(headerArray2);
        this.taskOListView.Cursor = Cursors.Default;
        this.taskOListView.Location = new Point(0, 0);
        this.taskOListView.MinimumSize = new Size(4, 60);
        this.taskOListView.Name = "taskOListView";
        this.taskOListView.RowHeight = 0x19;
        this.taskOListView.ShowGroups = false;
        this.taskOListView.Size = new Size(0x315, 0x100);
        this.taskOListView.TabIndex = 0x4f;
        this.taskOListView.UseCompatibleStateImageBehavior = false;
        this.taskOListView.View = View.Details;
        this.taskOListView.VirtualMode = true;
        this.taskOListView.CellEditFinishing += new CellEditEventHandler(this.taskOListView_CellEditFinishing);
        this.taskOListView.CellEditStarting += new CellEditEventHandler(this.taskOListView_CellEditStarting);
        this.taskOListView.CellRightClick += new EventHandler<CellRightClickEventArgs>(this.method_48);
        this.taskOListView.FormatRow += new EventHandler<FormatRowEventArgs>(this.method_49);
        this.taskOListView.SelectedIndexChanged += new EventHandler(this.taskOListView_SelectedIndexChanged);
        this.olvcolumn_0.AspectName = "id";
        this.olvcolumn_0.Text = "ID";
        this.olvcolumn_0.Width = 0x3b;
        this.olvcolumn_1.AspectName = "pid";
        this.olvcolumn_1.Text = "PID";
        this.olvcolumn_1.Width = 0x4d;
        this.olvcolumn_2.AspectName = "getSizeString";
        this.olvcolumn_2.Text = "Size";
        this.olvcolumn_2.Width = 90;
        this.olvcolumn_3.AspectName = "needsCaptcha";
        this.olvcolumn_3.Text = "Captcha";
        this.olvcolumn_3.Width = 70;
        this.olvcolumn_17.AspectName = "getCheckoutProfileName";
        this.olvcolumn_17.Text = "Auto Checkout Profile";
        this.olvcolumn_17.Width = 0x7e;
        this.olvcolumn_6.AspectName = "proxy";
        this.olvcolumn_6.Text = "Proxy";
        this.olvcolumn_6.Width = 0xec;
        this.olvcolumn_7.AspectName = "startTime";
        this.olvcolumn_7.Text = "Time";
        this.olvcolumn_7.Width = 0x91;
        this.olvcolumn_4.AspectName = "captchaDuplicate";
        this.olvcolumn_4.Text = "Captcha Dup.";
        this.olvcolumn_4.Width = 0x69;
        this.olvcolumn_5.AspectName = "additionalParams";
        this.olvcolumn_5.Text = "Add. Params";
        this.olvcolumn_5.Width = 120;
        this.label18.AutoSize = true;
        this.label18.Location = new Point(0x1b0, 7);
        this.label18.Name = "label18";
        this.label18.Size = new Size(0x56, 13);
        this.label18.TabIndex = 60;
        this.label18.Text = "Waiting for Start:";
        this.label18.Visible = false;
        this.taskButtonsPanel.Controls.Add(this.startAllButton);
        this.taskButtonsPanel.Controls.Add(this.startSelectedButton);
        this.taskButtonsPanel.Controls.Add(this.removeSelectedButton);
        this.taskButtonsPanel.Controls.Add(this.cancelTasksButton);
        this.taskButtonsPanel.Controls.Add(this.removeAllButton);
        this.taskButtonsPanel.Location = new Point(0x3e, 0x13);
        this.taskButtonsPanel.Name = "taskButtonsPanel";
        this.taskButtonsPanel.Size = new Size(0xea, 0x97);
        this.taskButtonsPanel.TabIndex = 0x63;
        this.captchaDupPanel.Controls.Add(this.label21);
        this.captchaDupPanel.Controls.Add(this.captchaDuplicateBox);
        this.captchaDupPanel.Controls.Add(this.updateAllButton);
        this.captchaDupPanel.Controls.Add(this.label23);
        this.captchaDupPanel.Controls.Add(this.label24);
        this.captchaDupPanel.Controls.Add(this.updateDuplicateManual);
        this.captchaDupPanel.Controls.Add(this.panel1);
        this.captchaDupPanel.Controls.Add(this.label17);
        this.captchaDupPanel.Location = new Point(0x1b0, 2);
        this.captchaDupPanel.Name = "captchaDupPanel";
        this.captchaDupPanel.Size = new Size(30, 0x29);
        this.captchaDupPanel.TabIndex = 0;
        this.captchaDupPanel.Visible = false;
        this.panel2.Controls.Add(this.label3);
        this.panel2.Controls.Add(this.tokenCountLabel);
        this.panel2.Controls.Add(this.label5);
        this.panel2.Controls.Add(this.expiringLabel);
        this.panel2.Controls.Add(this.copyButton);
        this.panel2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.panel2.Location = new Point(6, 0x88);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(0x152, 0x2d);
        this.panel2.TabIndex = 0;
        this.metroButton1.Location = new Point(0, 0);
        this.metroButton1.Name = "metroButton1";
        this.metroButton1.Size = new Size(0x4b, 0x17);
        this.metroButton1.TabIndex = 0;
        this.addTaskButton.Location = new Point(0x245, 380);
        this.addTaskButton.Name = "addTaskButton";
        this.addTaskButton.Size = new Size(0x7c, 0x25);
        this.addTaskButton.TabIndex = 100;
        this.addTaskButton.Text = "Add Task";
        this.addTaskButton.Click += new EventHandler(this.addTaskButton_Click);
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x49f, 0x2c7);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x47, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "\x00a9 ycopp.com";
        this.label2.Click += new EventHandler(this.label2_Click);
        this.label2.MouseDoubleClick += new MouseEventHandler(this.label2_MouseDoubleClick);
        this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
        this.pictureBox1.Location = new Point(0x250, 0x15);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new Size(0xb9, 0x66);
        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 9;
        this.pictureBox1.TabStop = false;
        this.adidasAccountLabel.AutoSize = true;
        this.adidasAccountLabel.Location = new Point(0x469, 0x30);
        this.adidasAccountLabel.Name = "adidasAccountLabel";
        this.adidasAccountLabel.Size = new Size(0x81, 13);
        this.adidasAccountLabel.TabIndex = 0x65;
        this.adidasAccountLabel.Text = "Adidas Accounts in List: 0";
        this.adidasAccountLabel.Visible = false;
        this.adidasAccountLabel.MouseDoubleClick += new MouseEventHandler(this.adidasAccountLabel_MouseDoubleClick);
        this.taskDelayLabel.AutoSize = true;
        this.taskDelayLabel.Location = new Point(930, 0x30);
        this.taskDelayLabel.Name = "taskDelayLabel";
        this.taskDelayLabel.Size = new Size(0x40, 13);
        this.taskDelayLabel.TabIndex = 0x66;
        this.taskDelayLabel.Text = "Task Delay:";
        this.taskDelayLabel.Visible = false;
        this.addAndStartButton.Location = new Point(0x2d3, 380);
        this.addAndStartButton.Name = "addAndStartButton";
        this.addAndStartButton.Size = new Size(0x7c, 0x25);
        this.addAndStartButton.TabIndex = 0x67;
        this.addAndStartButton.Text = "Add + Start Task";
        this.addAndStartButton.Click += new EventHandler(this.addAndStartButton_Click);
        this.browserHarvesterButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.browserHarvesterButton.Location = new Point(0x77, 80);
        this.browserHarvesterButton.Name = "browserHarvesterButton";
        this.browserHarvesterButton.Size = new Size(130, 0x23);
        this.browserHarvesterButton.TabIndex = 0x68;
        this.browserHarvesterButton.Text = "Start Browser Harvester";
        this.browserHarvesterButton.Click += new EventHandler(this.browserHarvesterButton_Click);
        this.anticaptchaButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.anticaptchaButton.Location = new Point(0xba, 0x23);
        this.anticaptchaButton.Name = "anticaptchaButton";
        this.anticaptchaButton.Size = new Size(130, 0x23);
        this.anticaptchaButton.TabIndex = 0x69;
        this.anticaptchaButton.Text = "Start Anti-Captcha";
        this.anticaptchaButton.Click += new EventHandler(this.anticaptchaButton_Click);
        this.metroTabControl1.Controls.Add(this.metroTabPage1);
        this.metroTabControl1.Controls.Add(this.metroTabPage2);
        this.metroTabControl1.Location = new Point(0x1cd, 0x1a7);
        this.metroTabControl1.Name = "metroTabControl1";
        this.metroTabControl1.SelectedIndex = 0;
        this.metroTabControl1.Size = new Size(0x31d, 0x11d);
        this.metroTabControl1.TabIndex = 0x6a;
        this.metroTabPage1.Controls.Add(this.taskOListView);
        this.metroTabPage1.Location = new Point(4, 0x16);
        this.metroTabPage1.Name = "metroTabPage1";
        this.metroTabPage1.Size = new Size(0x315, 0x103);
        this.metroTabPage1.TabIndex = 0;
        this.metroTabPage1.Text = "Tasks";
        this.metroTabPage2.Controls.Add(this.completedTaskOListView);
        this.metroTabPage2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.metroTabPage2.ForeColor = SystemColors.ControlText;
        this.metroTabPage2.Location = new Point(4, 0x16);
        this.metroTabPage2.Name = "metroTabPage2";
        this.metroTabPage2.Size = new Size(0x315, 0x103);
        this.metroTabPage2.TabIndex = 1;
        this.metroTabPage2.Text = "Completed Tasks";
        this.groupBox2.Controls.Add(this.label1);
        this.groupBox2.Controls.Add(this.label6);
        this.groupBox2.Controls.Add(this.manualTextBox);
        this.groupBox2.Controls.Add(this.updateButton);
        this.groupBox2.Controls.Add(this.autoUpdateButton);
        this.groupBox2.Controls.Add(this.automaticKeyBox);
        this.groupBox2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.groupBox2.Location = new Point(0x2f, 0x4d);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new Size(0x166, 160);
        this.groupBox2.TabIndex = 0x6b;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "API-Key retrieval:";
        this.deleteCompletedBox.AutoSize = true;
        this.deleteCompletedBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.deleteCompletedBox.Location = new Point(0x49, 0xb0);
        this.deleteCompletedBox.Name = "deleteCompletedBox";
        this.deleteCompletedBox.Size = new Size(0xd4, 0x11);
        this.deleteCompletedBox.TabIndex = 0x6c;
        this.deleteCompletedBox.Text = "Delete completed tasks upon checkout";
        this.deleteCompletedBox.UseVisualStyleBackColor = true;
        this.deleteCompletedBox.CheckedChanged += new EventHandler(this.deleteCompletedBox_CheckedChanged);
        this.groupBox3.Controls.Add(this.twoCaptchaButton);
        this.groupBox3.Controls.Add(this.panel2);
        this.groupBox3.Controls.Add(this.browserHarvesterButton);
        this.groupBox3.Controls.Add(this.anticaptchaButton);
        this.groupBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.groupBox3.Location = new Point(0x2f, 0xf6);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new Size(0x166, 0xe1);
        this.groupBox3.TabIndex = 0x6d;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Captcha Harvesting:";
        this.groupBox4.Controls.Add(this.retryBox);
        this.groupBox4.Controls.Add(this.deleteCompletedBox);
        this.groupBox4.Controls.Add(this.taskButtonsPanel);
        this.groupBox4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.groupBox4.Location = new Point(0x2f, 0x1de);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new Size(0x166, 0xe1);
        this.groupBox4.TabIndex = 110;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Task Management:";
        this.groupBox4.Enter += new EventHandler(this.groupBox4_Enter);
        this.retryBox.AutoSize = true;
        this.retryBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.retryBox.Location = new Point(0x49, 0xc7);
        this.retryBox.Name = "retryBox";
        this.retryBox.Size = new Size(150, 0x11);
        this.retryBox.TabIndex = 0x6d;
        this.retryBox.Text = "Retry if item is out of stock";
        this.retryBox.UseVisualStyleBackColor = true;
        this.label4.AutoSize = true;
        this.label4.Location = new Point(0x1cd, 0x124);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x71, 13);
        this.label4.TabIndex = 0x6f;
        this.label4.Text = "Auto Checkout Profile:";
        this.checkoutProfileBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.checkoutProfileBox.Enabled = false;
        this.checkoutProfileBox.FormattingEnabled = true;
        this.checkoutProfileBox.Location = new Point(0x274, 0x121);
        this.checkoutProfileBox.Name = "checkoutProfileBox";
        this.checkoutProfileBox.Size = new Size(200, 0x15);
        this.checkoutProfileBox.TabIndex = 0x70;
        this.checkoutProfileBox.SelectedIndexChanged += new EventHandler(this.checkoutProfileBox_SelectedIndexChanged);
        this.checkoutProfileBox.Click += new EventHandler(this.checkoutProfileBox_Click);
        this.autoCheckoutCheckBox.Location = new Point(0x25a, 0x123);
        this.autoCheckoutCheckBox.Name = "autoCheckoutCheckBox";
        this.autoCheckoutCheckBox.Size = new Size(0x11, 0x11);
        this.autoCheckoutCheckBox.TabIndex = 0x71;
        this.autoCheckoutCheckBox.Text = " ";
        this.autoCheckoutCheckBox.CheckedChanged += new EventHandler(this.autoCheckoutCheckBox_CheckedChanged);
        this.button2.Location = new Point(0x328, 0x80);
        this.button2.Name = "button2";
        this.button2.Size = new Size(0x4b, 0x17);
        this.button2.TabIndex = 0x72;
        this.button2.Text = "button2";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Visible = false;
        this.button2.Click += new EventHandler(this.button2_Click);
        base.AutoScaleDimensions = new SizeF(96f, 96f);
        base.AutoScaleMode = AutoScaleMode.Dpi;
        base.ClientSize = new Size(0x504, 730);
        base.Controls.Add(this.button2);
        base.Controls.Add(this.autoCheckoutCheckBox);
        base.Controls.Add(this.checkoutProfileBox);
        base.Controls.Add(this.label4);
        base.Controls.Add(this.groupBox4);
        base.Controls.Add(this.groupBox3);
        base.Controls.Add(this.hmacBox);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.groupBox2);
        base.Controls.Add(this.metroTabControl1);
        base.Controls.Add(this.addAndStartButton);
        base.Controls.Add(this.taskDelayLabel);
        base.Controls.Add(this.adidasAccountLabel);
        base.Controls.Add(this.alternative2Radio);
        base.Controls.Add(this.addTaskButton);
        base.Controls.Add(this.alternativeRadio);
        base.Controls.Add(this.captchaDupPanel);
        base.Controls.Add(this.removeHmacBtn);
        base.Controls.Add(this.hmacExpireLabel);
        base.Controls.Add(this.hmacLabel);
        base.Controls.Add(this.nmdPreloadButton);
        base.Controls.Add(this.automaticUpdater1);
        base.Controls.Add(this.label9);
        base.Controls.Add(this.updateNotifyLabel);
        base.Controls.Add(this.label25);
        base.Controls.Add(this.groupBox1);
        base.Controls.Add(this.label18);
        base.Controls.Add(this.testProxyButton);
        base.Controls.Add(this.label22);
        base.Controls.Add(this.proxyPWBox);
        base.Controls.Add(this.proxyUsernameBox);
        base.Controls.Add(this.timeLabel);
        base.Controls.Add(this.label13);
        base.Controls.Add(this.swapSizeButton);
        base.Controls.Add(this.statusBox);
        base.Controls.Add(this.label15);
        base.Controls.Add(this.proxyBox);
        base.Controls.Add(this.sizeComboBox);
        base.Controls.Add(this.label12);
        base.Controls.Add(this.autoStart);
        base.Controls.Add(this.timePicker);
        base.Controls.Add(this.needsCaptcha);
        base.Controls.Add(this.pidBox);
        base.Controls.Add(this.label10);
        base.Controls.Add(this.label8);
        base.Controls.Add(this.label7);
        base.Controls.Add(this.pictureBox1);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.menuStrip1);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.MainMenuStrip = this.menuStrip1;
        base.MaximizeBox = false;
        this.MaximumSize = new Size(0x514, 0x323);
        this.MinimumSize = new Size(0x249, 0x16f);
        base.Name = "MainForm";
        this.Text = "yCopp Ultimate Adidas Bot 1.0";
        base.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
        base.Load += new EventHandler(this.MainForm_Load);
        base.Shown += new EventHandler(this.MainForm_Shown);
        base.Click += new EventHandler(this.MainForm_Click);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        ((ISupportInitialize) this.automaticUpdater1).EndInit();
        ((ISupportInitialize) this.completedTaskOListView).EndInit();
        ((ISupportInitialize) this.taskOListView).EndInit();
        this.taskButtonsPanel.ResumeLayout(false);
        this.captchaDupPanel.ResumeLayout(false);
        this.captchaDupPanel.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((ISupportInitialize) this.pictureBox1).EndInit();
        this.metroTabControl1.ResumeLayout(false);
        this.metroTabPage1.ResumeLayout(false);
        this.metroTabPage2.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.groupBox4.ResumeLayout(false);
        this.groupBox4.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (!this.bool_13)
        {
            if (MessageBox.Show("Enable 'Coppa-Coppa' sound?", "Coppa-Coppa", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.bool_13 = true;
            }
        }
        else if (MessageBox.Show("Disable 'Coppa-Coppa' sound?", "Coppa-Coppa", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
        {
            this.bool_13 = false;
        }
    }

    private void loadSetupForNextReleaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        byte[] data = new byte[0x200];
        new RNGCryptoServiceProvider().GetBytes(data);
        string str2 = BitConverter.ToString(data);
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/get_settings.php");
        string s = (((("name=" + this.string_8) + "&salt=" + str2) + "&signature=" + this.method_8(this.string_8 + str2)) + "&app=yCoppCaptchaADBDB") + "&region=" + this.int_2.ToString();
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
        catch (Exception)
        {
            MessageBox.Show("Error while connecting to the yCopp server. Please check your connection and try again!");
            if (response != null)
            {
                response.Close();
            }
            return;
        }
        if (!new StreamReader(response.GetResponseStream()).ReadToEnd().Equals("Success"))
        {
            MessageBox.Show("Fatal error while trying to retrieve the bot setup. Please contact info@ycopp.com and report this issue!");
        }
        else
        {
            string str3 = response.Headers.Get("id");
            int num3 = int.Parse(response.Headers.Get("bdMode"));
            bool flag = false;
            if ((response.Headers.Get("hmac") != null) && response.Headers.Get("hmac").Equals("1"))
            {
                flag = true;
            }
            bool flag2 = false;
            if (response.Headers.Get("apiRetrieval").Equals("1"))
            {
                flag2 = true;
            }
            bool flag3 = false;
            if (response.Headers.Get("duplicateRetrieval").Equals("1"))
            {
                flag3 = true;
            }
            if ((response.Headers.Get("cookiePreload") != null) && response.Headers.Get("cookiePreload").Equals("1"))
            {
                this.disableCookiePreloadToolStripMenuItem.Checked = false;
            }
            else
            {
                this.disableCookiePreloadToolStripMenuItem.Checked = true;
            }
            if (response.Headers.Get("captchaDup") != null)
            {
                this.string_3 = response.Headers.Get("captchaDup");
            }
            if (response.Headers.Get("preloadLink").Equals("0"))
            {
                this.string_17 = string.Empty;
            }
            else
            {
                this.string_17 = response.Headers.Get("preloadLink");
            }
            bool flag4 = false;
            if (response.Headers.Get("useDefault").Equals("1"))
            {
                flag4 = true;
            }
            bool flag5 = false;
            if (response.Headers.Get("sendProdCount").Equals("1"))
            {
                flag5 = true;
            }
            if ((response.Headers.Get("hmacCookieName") != null) && !response.Headers.Get("hmacCookieName").Equals(string.Empty))
            {
                this.string_24 = response.Headers.Get("hmacCookieName");
            }
            if ((response.Headers.Get("splashCookieName") != null) && !response.Headers.Get("splashCookieName").Equals(string.Empty))
            {
                this.string_24 = response.Headers.Get("splashCookieName");
            }
            if ((response.Headers.Get("mac") != null) && response.Headers.Get("mac").Equals("1"))
            {
                flag = true;
            }
            int index = int.Parse(response.Headers.Get("customCookies"));
            if (index > 0)
            {
                for (int i = 1; i <= index; i++)
                {
                    string str4 = response.Headers.Get("cookieName" + i.ToString());
                    string str5 = response.Headers.Get("cookieValue" + i.ToString());
                    this.string_21[index] = str4;
                    this.string_22[index] = str5;
                    index++;
                }
            }
            switch (num3)
            {
                case 1:
                    this.normalRadio.Checked = true;
                    break;

                case 2:
                    this.splashRadio.Checked = true;
                    break;

                case 3:
                    this.alternativeRadio.Checked = true;
                    break;

                case 4:
                    this.alternative2Radio.Checked = true;
                    break;
            }
            this.hmacBox.Enabled = flag;
            if (flag2 && !this.bool_10)
            {
                this.autoUpdateButton.PerformClick();
            }
            if (!flag2 && this.bool_10)
            {
                this.autoUpdateButton.PerformClick();
            }
            if (flag3 && !this.bool_11)
            {
                this.updateAllButton.PerformClick();
            }
            if (!flag3 && this.bool_11)
            {
                this.updateAllButton.PerformClick();
            }
            this.useDefaultMethod.Checked = flag4;
            this.sendProductCountRequest.Checked = flag5;
            MessageBox.Show("Successfully loaded bot setup for: " + str3);
        }
    }

    private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.int_2 = this.locationComboBox.SelectedIndex;
        if (this.manualTextBox.Text.Equals(string.Empty))
        {
            this.updateButton.PerformClick();
        }
    }

    private void MainForm_Click(object sender, EventArgs e)
    {
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        SharpSerializer serializer = new SharpSerializer(true);
        try
        {
            serializer.Serialize(this.arrayList_0, "tasks.bin");
        }
        catch (Exception)
        {
        }
        try
        {
            serializer.Serialize(this.arrayList_3, "ctasks.bin");
        }
        catch (Exception)
        {
        }
        try
        {
            serializer.Serialize(this.string_12 + "#" + this.int_4.ToString() + "#" + this.int_5.ToString(), "settings.bin");
        }
        catch (Exception)
        {
        }
        this.bool_3 = true;
        foreach (Thread thread in this.arrayList_2)
        {
            if (thread.IsAlive)
            {
                thread.Abort();
            }
        }
        foreach (Thread thread2 in this.arrayList_1)
        {
            if (thread2.IsAlive)
            {
                thread2.Abort();
            }
        }
        if ((this.thread_3 != null) && this.thread_3.IsAlive)
        {
            this.thread_3.Abort();
        }
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
        if ((this.thread_4 != null) && this.thread_4.IsAlive)
        {
            this.thread_4.Abort();
        }
        if ((this.thread_5 != null) && this.thread_5.IsAlive)
        {
            this.thread_5.Abort();
        }
        if ((this.thread_7 != null) && this.thread_7.IsAlive)
        {
            this.thread_7.Abort();
        }
        if ((this.thread_6 != null) && this.thread_6.IsAlive)
        {
            this.thread_6.Abort();
        }
        if ((this.thread_8 != null) && this.thread_8.IsAlive)
        {
            this.thread_8.Abort();
        }
        if ((this.thread_10 != null) && this.thread_10.IsAlive)
        {
            this.thread_10.Abort();
        }
        if ((this.thread_11 != null) && this.thread_11.IsAlive)
        {
            this.thread_11.Abort();
        }
        Cef.Shutdown();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        DateTime time;
        ServicePointManager.DefaultConnectionLimit = 10;
        ServicePointManager.Expect100Continue = false;
        SharpSerializer serializer = new SharpSerializer(true);
        try
        {
            this.arrayList_0 = (ArrayList) serializer.Deserialize("tasks.bin");
        }
        catch (Exception)
        {
        }
        try
        {
            this.arrayList_3 = (ArrayList) serializer.Deserialize("ctasks.bin");
        }
        catch (Exception)
        {
        }
        try
        {
            this.arrayList_5 = (ArrayList) serializer.Deserialize("acdata.bin");
        }
        catch (Exception)
        {
        }
        this.checkoutProfileBox.DisplayMember = "profileName";
        this.checkoutProfileBox.DataSource = this.arrayList_5;
        try
        {
            char[] separator = new char[] { '#' };
            string[] strArray2 = ((string) serializer.Deserialize("settings.bin")).Split(separator);
            this.string_12 = strArray2[0];
            int result = 0x2710;
            int.TryParse(strArray2[1], out result);
            this.int_4 = result;
            int num5 = 1;
            int.TryParse(strArray2[2], out num5);
            this.int_5 = num5;
        }
        catch (Exception)
        {
        }
        try
        {
            char[] chArray2 = new char[] { '#' };
            string[] strArray = ((string) serializer.Deserialize("settings2.bin")).Split(chArray2);
            this.string_13 = strArray[0];
            this.string_14 = strArray[1];
            this.int_6 = 80;
            int.TryParse(strArray[2], out this.int_6);
            this.string_15 = strArray[3];
            this.string_16 = strArray[4];
            this.int_7 = 0x2710;
            int.TryParse(strArray[5], out this.int_7);
            this.int_8 = 1;
            int.TryParse(strArray[6], out this.int_8);
        }
        catch (Exception)
        {
        }
        for (int i = this.arrayList_3.Count - 1; i >= 0; i--)
        {
            if (((GClass0) this.arrayList_3[i]).autoCheckoutState == 1)
            {
                ((GClass0) this.arrayList_3[i]).autoCheckoutState = 0;
            }
            if (((GClass0) this.arrayList_3[i]).autoCheckoutState == 1)
            {
                ((GClass0) this.arrayList_3[i]).button1 = string.Empty;
                ((GClass0) this.arrayList_3[i]).button2 = string.Empty;
                ((GClass0) this.arrayList_3[i]).button3 = string.Empty;
                ((GClass0) this.arrayList_3[i]).button4 = string.Empty;
            }
        }
        bool flag = false;
        int index = this.arrayList_0.Count - 1;
    Label_028D:
        if (index < 0)
        {
            if (flag && (this.thread_0 == null))
            {
                this.thread_0 = new Thread(new ThreadStart(this.method_15));
                this.thread_0.IsBackground = true;
                this.thread_0.Start();
            }
            Class21.string_5 = Class21.string_5.Replace(Class21.string_4, string.Empty);
            Class21.string_6 = Class21.string_6.Replace(Class21.string_4, string.Empty);
            Class21.string_7 = Class21.string_7.Replace(Class21.string_4, string.Empty);
            Class21.string_8 = Class21.string_8.Replace(Class21.string_4, string.Empty);
            Class21.string_9 = Class21.string_9.Replace(Class21.string_4, string.Empty);
            Class21.string_10 = Class21.string_10.Replace(Class21.string_4, string.Empty);
            Class21.string_11 = Class21.string_11.Replace(Class21.string_4, string.Empty);
            Class21.string_12 = Class21.string_12.Replace(Class21.string_4, string.Empty);
            this.taskOListView.GetColumn(0).GroupKeyGetter = Class23.groupKeyGetterDelegate_0 ?? (Class23.groupKeyGetterDelegate_0 = new GroupKeyGetterDelegate(Class23.class23_0.method_0));
            this.taskOListView.SetObjects(this.arrayList_0);
            this.taskOListView.FullRowSelect = true;
            this.completedTaskOListView.SetObjects(this.arrayList_3);
            this.completedTaskOListView.FullRowSelect = true;
            this.completedTaskOListView.HotTracking = false;
            this.completedTaskOListView.ButtonClick += new EventHandler<CellClickEventArgs>(this.method_59);
            this.thread_1 = new Thread(new ThreadStart(this.method_14));
            this.thread_1.IsBackground = true;
            this.thread_1.Start();
            if (!Cef.IsInitialized)
            {
                CefSettings cefSettings = new CefSettings {
                    UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36"
                };
                Cef.Initialize(cefSettings);
                Cef.EnableHighDPISupport();
            }
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load("data.yclicense");
            }
            catch (FileNotFoundException)
            {
                this.locationComboBox.SelectedIndex = 6;
                return;
            }
            XmlNode node = document.DocumentElement.SelectSingleNode("location");
            int num3 = -1;
            try
            {
                num3 = int.Parse(node.InnerText);
                this.locationComboBox.SelectedIndex = num3;
                this.int_2 = num3;
            }
            catch (Exception)
            {
                this.locationComboBox.SelectedIndex = 6;
            }
            if (!this.bool_0 && WebRequest.GetSystemWebProxy().GetProxy(new Uri("http://www.google.de")).Host.Equals("127.0.0.1"))
            {
                base.Invoke(new MethodInvoker(this.method_60));
            }
            return;
        }
        ((GClass0) this.arrayList_0[index]).isRunning = false;
        if (!((GClass0) this.arrayList_0[index]).automaticStart)
        {
            goto Label_0346;
        }
        try
        {
            time = DateTime.ParseExact(((GClass0) this.arrayList_0[index]).startTime, "HH:mm:ss", CultureInfo.InvariantCulture);
            goto Label_034F;
        }
        catch (Exception)
        {
            try
            {
                time = DateTime.ParseExact(((GClass0) this.arrayList_0[index]).startTime, "h:mm:ss tt", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("A date-format related error occured on startup. Please contact info@ycopp.com with this error message!");
                this.arrayList_0.RemoveAt(index);
                goto Label_0346;
            }
            goto Label_034F;
        }
    Label_0335:
        this.arrayList_0.RemoveAt(index);
    Label_0346:
        index--;
        goto Label_028D;
    Label_034F:
        if (time.Subtract(DateTime.Now).TotalSeconds >= 0.0)
        {
            flag = true;
            goto Label_0346;
        }
        goto Label_0335;
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
        if (this.thread_6 == null)
        {
            this.thread_6 = new Thread(new ThreadStart(this.method_24));
            this.thread_6.IsBackground = false;
            this.thread_6.Start();
        }
        this.thread_3 = new Thread(new ThreadStart(this.method_0));
        this.thread_3.IsBackground = true;
        this.thread_3.Start();
        this.method_23(true);
    }

    private void manageAutoCheckoutProfilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AutoCheckoutProfilesForm form = new AutoCheckoutProfilesForm(this.arrayList_5) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            this.arrayList_5 = form.arrayList_0;
            this.checkoutProfileBox.DataSource = null;
            this.checkoutProfileBox.DisplayMember = "profileName";
            this.checkoutProfileBox.DataSource = this.arrayList_5;
        }
    }

    private void manuallySetToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (this.int_9 > 0x62)
        {
            MessageBox.Show("Can't add more cookies!");
        }
        else
        {
            SetCookie cookie = new SetCookie {
                StartPosition = FormStartPosition.CenterParent
            };
            if (cookie.ShowDialog(this) == DialogResult.OK)
            {
                this.string_21[this.int_9] = cookie.string_0;
                this.string_22[this.int_9] = cookie.string_1;
                this.int_9++;
            }
        }
    }

    private void manualTextBox_TextChanged(object sender, EventArgs e)
    {
        if (this.manualTextBox.Text != string.Empty)
        {
            this.automaticKeyBox.Checked = false;
        }
        else
        {
            this.automaticKeyBox.Checked = true;
        }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    public void method_0()
    {
        bool flag = true;
    Label_0002:
        if (this.bool_3)
        {
            return;
        }
        try
        {
            this.manualResetEvent_0.WaitOne();
            TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
            if ((((long) span.TotalMilliseconds) - this.queue_0.Peek().long_0) > 0x1adb0L)
            {
                this.manualResetEvent_0.WaitOne();
                this.queue_0.Dequeue();
                goto Label_0002;
            }
            flag = false;
            MethodInvoker method = new MethodInvoker(this.method_52);
            base.Invoke(method);
            goto Label_0112;
        }
        catch (InvalidOperationException)
        {
            MethodInvoker invoker2 = new MethodInvoker(this.method_53);
            if (this.expiringLabel.InvokeRequired && !flag)
            {
                base.Invoke(invoker2);
            }
            flag = true;
            goto Label_0112;
        }
        catch (ThreadAbortException)
        {
            return;
        }
        catch (Exception)
        {
            goto Label_0112;
        }
        finally
        {
            if (this.string_19.Length < 3)
            {
                Environment.Exit(0);
            }
        }
    Label_00D2:
        if (WebRequest.GetSystemWebProxy().GetProxy(new Uri("http://www.google.de")).Host.Equals("127.0.0.1"))
        {
            base.Invoke(new MethodInvoker(this.method_54));
        }
        goto Label_0002;
    Label_0112:
        Thread.Sleep(0x3e8);
        if (this.bool_0)
        {
            goto Label_0002;
        }
        goto Label_00D2;
    }

    public void method_1()
    {
        while (!this.bool_3)
        {
            try
            {
                if (this.chromiumWebBrowser_0.IsBrowserInitialized)
                {
                    TimeSpan? timeout = null;
                    Task<JavascriptResponse> task1 = this.chromiumWebBrowser_0.EvaluateScriptAsync("document." + this.string_26.Substring(6, 1) + "etElementById('g-recaptcha-response').value;", timeout);
                    task1.Wait();
                    JavascriptResponse response = task1.get_Result();
                    if ((response.Result != null) && !response.Result.ToString().Equals(string.Empty))
                    {
                        this.manualResetEvent_0.Reset();
                        TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                        this.queue_0.Enqueue(new Class18(response.Result.ToString(), (long) span.TotalMilliseconds));
                        this.manualResetEvent_0.Set();
                        break;
                    }
                }
            }
            catch (ThreadAbortException)
            {
                break;
            }
            Thread.Sleep(500);
        }
    }

    private void method_10(IList ilist_0)
    {
        bool flag = true;
        using (IEnumerator enumerator = ilist_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class36 class3 = new Class36 {
                    mainForm_0 = this,
                    gclass0_0 = (GClass0) enumerator.Current
                };
                Class33 class2 = new Class33 {
                    class36_0 = class3
                };
                if (!flag && (this.int_1 > 0))
                {
                    Thread.Sleep((int) (this.int_1 * 0x3e8));
                }
                class2.string_0 = string.Empty;
                base.Invoke(new MethodInvoker(class2.class36_0.method_0));
                if (class2.class36_0.gclass0_0.needsCaptcha)
                {
                    base.Invoke(new MethodInvoker(this.method_61));
                    int num = 15;
                    while (this.queue_0.Count == 0)
                    {
                        num++;
                        if (num == 0x10)
                        {
                            num = 0;
                            base.Invoke(new MethodInvoker(this.method_62));
                        }
                        Thread.Sleep(500);
                    }
                    this.manualResetEvent_0.Reset();
                    try
                    {
                        class2.string_0 = this.queue_0.Dequeue().string_0;
                    }
                    catch (Exception)
                    {
                        base.Invoke(new MethodInvoker(this.method_63));
                        this.manualResetEvent_0.Set();
                        continue;
                    }
                    this.manualResetEvent_0.Set();
                    base.Invoke(new MethodInvoker(this.method_64));
                }
                Thread thread = new Thread(new ThreadStart(class2.method_0)) {
                    IsBackground = true
                };
                this.arrayList_1.Add(thread);
                class2.class36_0.gclass0_0.method_1(thread);
                thread.Start();
                class2.class36_0.gclass0_0.isScheduled = false;
                flag = false;
            }
        }
    }

    private void method_11(GClass0 gclass0_0, string string_27)
    {
        Class39 class4 = new Class39 {
            mainForm_0 = this,
            gclass0_0 = gclass0_0
        };
        if (!this.bool_0 && WebRequest.GetSystemWebProxy().GetProxy(new Uri("http://www.google.de")).Host.Equals("127.0.0.1"))
        {
            base.Invoke(new MethodInvoker(this.method_65));
        }
        class4.gclass0_0.isRunning = true;
        bool flag2 = true;
    Label_0067:
        if (!flag2 && !this.retryBox.Checked)
        {
            class4.gclass0_0.isRunning = false;
            return;
        }
        Class42 class2 = new Class42 {
            class39_0 = class4
        };
        if (!flag2)
        {
            Thread.Sleep(0x1388);
            if (class2.class39_0.gclass0_0.needsCaptcha)
            {
                int num4 = 15;
                while (this.queue_0.Count == 0)
                {
                    num4++;
                    if (num4 == 0x10)
                    {
                        num4 = 0;
                        base.Invoke(new MethodInvoker(this.method_66));
                    }
                    Thread.Sleep(500);
                }
                this.manualResetEvent_0.Reset();
                try
                {
                    string_27 = this.queue_0.Dequeue().string_0;
                }
                catch (Exception)
                {
                    base.Invoke(new MethodInvoker(this.method_67));
                    this.manualResetEvent_0.Set();
                    class2.class39_0.gclass0_0.isRunning = false;
                    return;
                }
                this.manualResetEvent_0.Set();
            }
        }
        WebProxy proxy = null;
        if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
        {
            try
            {
                proxy = new WebProxy(class2.class39_0.gclass0_0.proxy);
            }
            catch (Exception)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  The entered proxies format is invalid! Continuing without proxy...\n");
            }
        }
        HttpWebRequest request2 = (HttpWebRequest) WebRequest.Create(this.dictionary_6[this.int_2]);
        CookieContainer container2 = new CookieContainer();
        class2.httpWebResponse_0 = null;
        if (this.disableCookiePreloadToolStripMenuItem.Checked)
        {
            goto Label_0A8A;
        }
        if (!this.cookie10Interval.Checked)
        {
            Uri result = null;
            if (!this.string_17.Equals(string.Empty) && ((!Uri.TryCreate(this.string_17, UriKind.Absolute, out result) && !Uri.TryCreate("http://" + this.string_17, UriKind.Absolute, out result)) || !this.string_17.Contains(".")))
            {
                base.Invoke(class2.class39_0.methodInvoker_0 ?? (class2.class39_0.methodInvoker_0 = new MethodInvoker(class2.class39_0.method_0)));
                class2.class39_0.gclass0_0.isRunning = false;
                return;
            }
            if (!this.string_17.Equals(string.Empty))
            {
                request2 = (HttpWebRequest) WebRequest.Create(result);
            }
            Class21.smethod_0(ref request2, true);
            request2.Method = "GET";
            request2.Timeout = this.int_0;
            request2.AllowAutoRedirect = false;
            request2.CookieContainer = new CookieContainer();
            if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
            {
                request2.Proxy = proxy;
                if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                {
                    request2.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                }
            }
            try
            {
                class2.httpWebResponse_0 = (HttpWebResponse) request2.GetResponse();
            }
            catch (WebException)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Fatal error while sending the cookie preload request! Please check your connection and proxy server.\n");
                if (class2.httpWebResponse_0 != null)
                {
                    class2.httpWebResponse_0.Close();
                }
                class2.class39_0.gclass0_0.isRunning = false;
                return;
            }
            try
            {
                foreach (System.Net.Cookie cookie7 in class2.httpWebResponse_0.Cookies)
                {
                    container2.Add(cookie7);
                }
                class2.httpWebResponse_0.Close();
                goto Label_0402;
            }
            catch (Exception)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while parsing the preloaded cookies. Maybe the set location is wrong?\n");
                class2.httpWebResponse_0.Close();
                goto Label_0402;
            }
        }
        container2 = this.cookieContainer_0;
    Label_0402:
        if (this.hmacBox.Checked)
        {
            request2 = (HttpWebRequest) WebRequest.Create(new UriBuilder("www.adidas.com/ca/apps/yeezy/").Uri);
            Class21.smethod_0(ref request2, false);
            request2.Method = "GET";
            request2.Timeout = this.int_0;
            request2.CookieContainer = container2;
            if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
            {
                request2.Proxy = proxy;
                if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                {
                    request2.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                }
            }
            try
            {
                class2.httpWebResponse_0 = (HttpWebResponse) request2.GetResponse();
            }
            catch (WebException)
            {
                base.Invoke(class2.class39_0.methodInvoker_1 ?? (class2.class39_0.methodInvoker_1 = new MethodInvoker(class2.class39_0.method_1)));
                class2.class39_0.gclass0_0.isRunning = false;
                return;
            }
            try
            {
                string text1 = new StreamReader(class2.httpWebResponse_0.GetResponseStream()).ReadToEnd();
                int startIndex = text1.IndexOf("<!-- FOOTER END --><img src=") + 0x1d;
                int index = text1.IndexOf('"', startIndex);
                string str8 = text1.Substring(startIndex, index - startIndex);
                if (str8.Contains("tokenplaceholder"))
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  The hmac cookie preload is not possible in your selected location at this moment. Still trying to add...\n");
                    goto Label_08B3;
                }
                HttpWebRequest request7 = (HttpWebRequest) WebRequest.Create(new UriBuilder(str8.Replace("adidas.ca", this.dictionary_9[this.int_2])).Uri);
                Class21.smethod_0(ref request7, false);
                request7.Method = "GET";
                request7.Timeout = this.int_0;
                request7.CookieContainer = container2;
                if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                {
                    request7.Proxy = proxy;
                    if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                    {
                        request7.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                    }
                }
                try
                {
                    class2.httpWebResponse_0 = (HttpWebResponse) request7.GetResponse();
                }
                catch (WebException)
                {
                    if (class2.httpWebResponse_0 != null)
                    {
                        if (!class2.httpWebResponse_0.StatusCode.ToString().Equals("404") && !class2.httpWebResponse_0.StatusCode.ToString().Equals("OK"))
                        {
                            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Fatal error while preloading the hmac cookie! Still trying to add.\n");
                            class2.httpWebResponse_0.Close();
                            goto Label_08B3;
                        }
                    }
                    else
                    {
                        class2.class39_0.gclass0_0.isRunning = false;
                        return;
                    }
                }
                try
                {
                    foreach (System.Net.Cookie cookie8 in class2.httpWebResponse_0.Cookies)
                    {
                        container2.Add(cookie8);
                    }
                    class2.httpWebResponse_0.Close();
                }
                catch (Exception)
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Fatal error while loading the hmac cookie. You need an IP address matching to the location you've selected!\n");
                    class2.httpWebResponse_0.Close();
                    class2.class39_0.gclass0_0.isRunning = false;
                    return;
                }
            }
            catch (Exception)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Fatal error while parsing the hmac cookie. Maybe the set location is wrong?\n");
                class2.class39_0.gclass0_0.isRunning = false;
                return;
            }
            base.Invoke(class2.class39_0.methodInvoker_2 ?? (class2.class39_0.methodInvoker_2 = new MethodInvoker(class2.class39_0.method_2)));
        }
    Label_08B3:
        if (this.sendProductCountRequest.Checked)
        {
            HttpWebRequest request6 = (HttpWebRequest) WebRequest.Create(this.dictionary_7[this.int_2]);
            Class21.smethod_0(ref request6, true);
            request6.Method = "GET";
            request6.Timeout = this.int_0;
            request6.CookieContainer = container2;
            if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
            {
                request6.Proxy = proxy;
                if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                {
                    request6.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                }
            }
            try
            {
                class2.httpWebResponse_0 = (HttpWebResponse) request6.GetResponse();
            }
            catch (WebException)
            {
                base.Invoke(new MethodInvoker(class2.method_0));
            }
            try
            {
                foreach (System.Net.Cookie cookie9 in class2.httpWebResponse_0.Cookies)
                {
                    container2.Add(cookie9);
                }
                class2.httpWebResponse_0.Close();
            }
            catch (Exception)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while parsing the preloaded cookies. Maybe the set location is wrong?\n");
                class2.httpWebResponse_0.Close();
            }
        }
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Cookies preloaded!\n");
    Label_0A8A:
        if (Class21.string_7.Length < 10)
        {
            return;
        }
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ": Trying to add to cart.\n");
        string str7 = class2.class39_0.gclass0_0.method_3();
        HttpWebRequest request = null;
        string s = string.Empty;
        string requestUriString = this.dictionary_1[this.int_2];
        if (this.useDefaultMethod.Checked)
        {
            requestUriString = this.dictionary_0[this.int_2];
        }
        if (this.alternative2Radio.Checked)
        {
            string str4 = requestUriString + "?request=ajax&responseformat=json&masterPid=" + class2.class39_0.gclass0_0.pid;
            string[] textArray1 = new string[] { str4, "&pid=", class2.class39_0.gclass0_0.pid, "_", str7, "&Quantity=1" };
            str4 = string.Concat(textArray1);
            if (class2.class39_0.gclass0_0.needsCaptcha)
            {
                str4 = str4 + "&g-recaptcha-response=" + string_27;
            }
            if (!class2.class39_0.gclass0_0.captchaDuplicate.Equals(string.Empty))
            {
                string[] textArray2 = new string[] { str4, "&", class2.class39_0.gclass0_0.captchaDuplicate, "=", string_27 };
                str4 = string.Concat(textArray2);
            }
            request = (HttpWebRequest) WebRequest.Create(str4);
            request.Referer = "http://www.adidas.com/yeezy";
        }
        else if (this.splashRadio.Checked)
        {
            request = (HttpWebRequest) WebRequest.Create(requestUriString);
            s = "request=ajax&responseformat=json";
            s = (s + "&pid=" + class2.class39_0.gclass0_0.pid + "_" + str7) + "&Quantity=1";
            if (class2.class39_0.gclass0_0.needsCaptcha)
            {
                s = s + "&g-recaptcha-response=" + string_27;
            }
            if (!this.string_3.Equals(string.Empty))
            {
                string[] textArray4 = new string[] { s, "&", this.string_3, "=", string_27 };
                s = string.Concat(textArray4);
            }
            if (!class2.class39_0.gclass0_0.additionalParams.Equals(string.Empty))
            {
                s = s + class2.class39_0.gclass0_0.additionalParams;
            }
            request.Referer = this.dictionary_5[this.int_2];
        }
        else if (this.alternativeRadio.Checked)
        {
            string str5 = requestUriString + "?request=ajax&responseformat=json";
            string[] textArray5 = new string[] { str5, "&pid=", class2.class39_0.gclass0_0.pid, "_", str7, "&Quantity=1" };
            str5 = string.Concat(textArray5);
            if (class2.class39_0.gclass0_0.needsCaptcha)
            {
                str5 = str5 + "&g-recaptcha-response=" + string_27;
            }
            if (!class2.class39_0.gclass0_0.captchaDuplicate.Equals(string.Empty))
            {
                string[] textArray6 = new string[] { str5, "&", class2.class39_0.gclass0_0.captchaDuplicate, "=", string_27 };
                str5 = string.Concat(textArray6);
            }
            request = (HttpWebRequest) WebRequest.Create(str5);
            request.Referer = "http://www.adidas.com/yeezy";
        }
        else
        {
            request = (HttpWebRequest) WebRequest.Create(requestUriString);
            s = "layer=Add+To+Bag+overlay";
            s = (s + "&pid=" + class2.class39_0.gclass0_0.pid + "_" + str7) + "&Quantity=1";
            if (class2.class39_0.gclass0_0.needsCaptcha)
            {
                s = s + "&g-recaptcha-response=" + string_27;
            }
            if (!this.string_3.Equals(string.Empty))
            {
                string[] textArray8 = new string[] { s, "&", this.string_3, "=", string_27 };
                s = string.Concat(textArray8);
            }
            if (!class2.class39_0.gclass0_0.additionalParams.Equals(string.Empty))
            {
                s = s + class2.class39_0.gclass0_0.additionalParams;
            }
            s = (s + "&masterPid=" + class2.class39_0.gclass0_0.pid) + "&sessionSelectedStoreID=null" + "&ajax=true";
            request.Referer = this.dictionary_5[this.int_2];
            if (!this.string_17.Equals(string.Empty))
            {
                request.Referer = this.string_17;
            }
        }
        request.CookieContainer = container2;
        bool flag3 = false;
        if (!this.string_25.Equals(string.Empty))
        {
            request.CookieContainer.Add(new System.Net.Cookie(this.string_24, this.string_25, "/", this.dictionary_9[this.int_2]));
            flag3 = true;
        }
        if (this.int_9 > 0)
        {
            for (int i = 0; i < this.int_9; i++)
            {
                if (!flag3 || !this.string_21[i].Equals(this.string_24))
                {
                    request.CookieContainer.Add(new System.Net.Cookie(this.string_21[i], this.string_22[i], "/", this.dictionary_9[this.int_2]));
                }
            }
        }
        request.Headers.Add("Origin", this.dictionary_5[this.int_2]);
        if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
        {
            request.Proxy = proxy;
            if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
            {
                request.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
            }
        }
        Class21.smethod_0(ref request, false);
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
        request.Timeout = this.int_0;
        byte[] bytes = Encoding.ASCII.GetBytes(s);
        request.ContentLength = bytes.Length;
        HttpWebResponse response = null;
        string str3 = string.Empty;
        try
        {
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }
            response = (HttpWebResponse) request.GetResponse();
            str3 = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
        catch (WebException exception11)
        {
            if (exception11.Message.ToString().Contains("403"))
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  The ATC request has been blocked by Adidas. Either you are missing the HMAC cookie or your IP/Proxy has been blocked by adidas.\n");
                if (response != null)
                {
                    response.Close();
                }
                class2.class39_0.gclass0_0.isRunning = false;
            }
            else if (response == null)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Fatal error while sending ATC request! Please check your connection and proxy server.\n");
                class2.class39_0.gclass0_0.isRunning = false;
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.Forbidden)
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  The ATC request has been blocked by Adidas. Either you are missing the HMAC cookie or your IP/Proxy has been blocked by adidas.\n");
                }
                else
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Fatal error while sending ATC request! Please check your connection and proxy server.\n");
                }
                response.Close();
                class2.class39_0.gclass0_0.isRunning = false;
            }
            return;
        }
        response.Close();
        bool flag4 = false;
        ArrayList list = new ArrayList();
        foreach (System.Net.Cookie cookie in response.Cookies)
        {
            CefSharp.Cookie cookie2 = new CefSharp.Cookie();
            if (cookie.Name != null)
            {
                string[] textArray9 = new string[] { this.string_26.Substring(11, 10), this.string_26.Substring(5, 1), "asket", this.string_26.Substring(0, 1), "ount" };
                if (cookie.Name.Equals(string.Concat(textArray9)))
                {
                    flag4 = true;
                }
            }
            cookie2.Name = cookie.Name;
            cookie2.Value = WebUtility.UrlEncode(cookie.Value);
            cookie2.Domain = cookie.Domain;
            cookie2.Path = cookie.Path;
            cookie2.Secure = cookie.Secure;
            cookie2.Expires = new DateTime?(cookie.Expires);
            list.Add(cookie2);
        }
        if (flag4)
        {
            SoundPlayer player;
            class2.class39_0.gclass0_0.locationIndex = this.int_2;
            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ": PID: " + class2.class39_0.gclass0_0.pid + ", Size: " + class2.class39_0.gclass0_0.getSizeString() + " added to cart!\n");
            CookieContainer container = new CookieContainer();
            foreach (System.Net.Cookie cookie3 in container2.GetCookies(new Uri(this.dictionary_5[this.int_2])))
            {
                CefSharp.Cookie cookie4 = new CefSharp.Cookie {
                    Name = cookie3.Name,
                    Value = cookie3.Value,
                    Domain = cookie3.Domain,
                    Path = cookie3.Path,
                    Secure = cookie3.Secure,
                    Expires = new DateTime?(cookie3.Expires)
                };
                list.Add(cookie4);
                container.Add(cookie3);
            }
            class2.class39_0.gclass0_0.cookieCont = container;
            if (!this.bool_13)
            {
                player = new SoundPlayer(Class19.smethod_6());
            }
            else
            {
                player = new SoundPlayer(Class19.smethod_7());
            }
            if (this.adidasAccountsCheck.Checked)
            {
                bool flag = false;
                CookieContainer container3 = new CookieContainer();
                if (this.arrayList_4.Count == 0)
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ": 'Log in to adidas accounts' selected, but no accounts are available!\n");
                }
                else
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ": Trying to log in to adidas account.\n");
                    Class46 class5 = (Class46) this.arrayList_4[this.arrayList_4.Count - 1];
                    this.arrayList_4.Remove(class5);
                    base.Invoke(new MethodInvoker(this.method_68));
                    HttpWebRequest request8 = (HttpWebRequest) WebRequest.Create(this.dictionary_12[this.int_2]);
                    Class21.smethod_0(ref request8, false);
                    request8.Method = "GET";
                    request8.Timeout = this.int_0;
                    request8.CookieContainer = container;
                    if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                    {
                        request8.Proxy = proxy;
                        if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                        {
                            request8.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                        }
                    }
                    try
                    {
                        HttpWebResponse response4 = (HttpWebResponse) request8.GetResponse();
                        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                        document.Load(response4.GetResponseStream());
                        string attributeValue = document.DocumentNode.SelectNodes(this.string_1)[int.Parse(this.string_0.Substring(0x1f, 1))].GetAttributeValue("value", string.Empty);
                        string str12 = document.DocumentNode.SelectNodes("//input[@name='IdpAdapterId']")[0].GetAttributeValue("value", string.Empty);
                        string str13 = document.DocumentNode.SelectNodes("//input[@name='SpSessionAuthnAdapterId']")[0].GetAttributeValue("value", string.Empty);
                        string str14 = document.DocumentNode.SelectNodes("//input[@name='PartnerSpId']")[0].GetAttributeValue("value", string.Empty);
                        string str15 = document.DocumentNode.SelectNodes("//input[@name='validator_id']")[0].GetAttributeValue("value", string.Empty);
                        string str16 = Uri.EscapeDataString(document.DocumentNode.SelectNodes("//input[@name='TargetResource']")[0].GetAttributeValue("value", string.Empty));
                        string str17 = document.DocumentNode.SelectNodes("//input[@name='InErrorResource']")[0].GetAttributeValue("value", string.Empty);
                        string str18 = document.DocumentNode.SelectNodes("//input[@name='loginUrl']")[0].GetAttributeValue("value", string.Empty);
                        string str19 = document.DocumentNode.SelectNodes("//input[@name='cd']")[0].GetAttributeValue("value", string.Empty);
                        string str20 = document.DocumentNode.SelectNodes("//input[@name='app']")[0].GetAttributeValue("value", string.Empty);
                        string str21 = document.DocumentNode.SelectNodes("//input[@name='locale']")[0].GetAttributeValue("value", string.Empty);
                        string str22 = document.DocumentNode.SelectNodes("//input[@name='domain']")[0].GetAttributeValue("value", string.Empty);
                        string str23 = document.DocumentNode.SelectNodes("//input[@name='email']")[0].GetAttributeValue("value", string.Empty);
                        string str24 = document.DocumentNode.SelectNodes("//input[@name='pfRedirectBaseURL_test']")[0].GetAttributeValue("value", string.Empty);
                        string str25 = document.DocumentNode.SelectNodes("//input[@name='pfStartSSOURL_test']")[0].GetAttributeValue("value", string.Empty);
                        string str26 = document.DocumentNode.SelectNodes("//input[@name='resumeURL_test']")[0].GetAttributeValue("value", string.Empty);
                        string str27 = document.DocumentNode.SelectNodes("//input[@name='FromFinishRegistraion']")[0].GetAttributeValue("value", string.Empty);
                        string str28 = document.DocumentNode.SelectNodes("//input[@name='CSRFToken']")[0].GetAttributeValue("value", string.Empty);
                        string str = ((((((((((((((((((("username=" + Uri.EscapeDataString(class5.string_0.Trim())) + "&password=" + Uri.EscapeDataString(class5.string_1.Trim())) + "&signinSubmit=" + attributeValue) + "&IdpAdapterId=" + str12) + "&SpSessionAuthnAdapterId=" + str13) + "&PartnerSpId=" + str14) + "&validator_id=" + str15) + "&TargetResource=" + str16) + "&InErrorResource=" + str17) + "&loginUrl=" + str18) + "&cd=" + str19) + "&app=" + str20) + "&locale=" + str21) + "&domain=" + str22) + "&email=" + str23) + "&pfRedirectBaseURL_test=" + str24) + "&pfStartSSOURL_test=" + str25) + "&resumeURL_test=" + str26) + "&FromFinishRegistraion=" + str27) + "&CSRFToken=" + str28;
                        foreach (System.Net.Cookie cookie10 in response4.Cookies)
                        {
                            container.Add(cookie10);
                        }
                        if (response4 != null)
                        {
                            response4.Close();
                        }
                        HttpWebRequest request3 = (HttpWebRequest) WebRequest.Create(this.dictionary_13[this.int_2]);
                        Class21.smethod_0(ref request3, false);
                        request3.Method = "POST";
                        request3.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                        request3.Timeout = this.int_0;
                        request3.CookieContainer = container;
                        if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                        {
                            request3.Proxy = proxy;
                            if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                            {
                                request3.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                            }
                        }
                        byte[] buffer = Encoding.ASCII.GetBytes(str);
                        request3.ContentLength = buffer.Length;
                        HttpWebResponse response2 = null;
                        try
                        {
                            using (Stream stream2 = request3.GetRequestStream())
                            {
                                stream2.Write(buffer, 0, buffer.Length);
                                stream2.Close();
                            }
                            response2 = (HttpWebResponse) request3.GetResponse();
                            str3 = new StreamReader(response2.GetResponseStream()).ReadToEnd();
                            int num3 = str3.IndexOf("resURL = '");
                            if (num3 == -1)
                            {
                                flag = true;
                                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Invalid adidas account data. \n");
                                throw new WebException();
                            }
                            num3 += 10;
                            int num7 = str3.IndexOf("'", num3);
                            string str29 = str3.Substring(num3, num7 - num3);
                            foreach (System.Net.Cookie cookie11 in response2.Cookies)
                            {
                                container.Add(cookie11);
                            }
                            if (response2 != null)
                            {
                                response2.Close();
                            }
                            HttpWebRequest request9 = (HttpWebRequest) WebRequest.Create(str29);
                            Class21.smethod_0(ref request9, false);
                            request9.Method = "GET";
                            request9.Timeout = this.int_0;
                            request9.CookieContainer = container;
                            if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                            {
                                request9.Proxy = proxy;
                                if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                                {
                                    request9.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                                }
                            }
                            try
                            {
                                HttpWebResponse response5 = (HttpWebResponse) request9.GetResponse();
                                document.Load(response5.GetResponseStream());
                                string str30 = document.DocumentNode.SelectNodes("//form")[0].GetAttributeValue("action", string.Empty);
                                string stringToEscape = document.DocumentNode.SelectNodes("//input[@name='SAMLResponse']")[0].GetAttributeValue("value", string.Empty);
                                string str32 = document.DocumentNode.SelectNodes("//input[@name='RelayState']")[0].GetAttributeValue("value", string.Empty);
                                string str9 = ("SAMLResponse=" + Uri.EscapeDataString(stringToEscape)) + "&RelayState=" + Uri.EscapeDataString(str32);
                                foreach (System.Net.Cookie cookie12 in response5.Cookies)
                                {
                                    container.Add(cookie12);
                                }
                                if (response5 != null)
                                {
                                    response5.Close();
                                }
                                HttpWebRequest request4 = (HttpWebRequest) WebRequest.Create(this.dictionary_14[this.int_2] + str30);
                                Class21.smethod_0(ref request4, false);
                                request4.Method = "POST";
                                request4.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                                request4.Timeout = this.int_0;
                                request4.CookieContainer = container;
                                if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                                {
                                    request4.Proxy = proxy;
                                    if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                                    {
                                        request4.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                                    }
                                }
                                byte[] buffer3 = Encoding.ASCII.GetBytes(str9);
                                request4.ContentLength = buffer3.Length;
                                HttpWebResponse response3 = null;
                                try
                                {
                                    using (Stream stream3 = request4.GetRequestStream())
                                    {
                                        stream3.Write(buffer3, 0, buffer3.Length);
                                        stream3.Close();
                                    }
                                    response3 = (HttpWebResponse) request4.GetResponse();
                                    document.Load(response3.GetResponseStream());
                                    string str33 = document.DocumentNode.SelectNodes("//form")[0].GetAttributeValue("action", string.Empty);
                                    string str34 = document.DocumentNode.SelectNodes("//input[@name='TargetResource']")[0].GetAttributeValue("value", string.Empty);
                                    string str35 = document.DocumentNode.SelectNodes("//input[@name='REF']")[0].GetAttributeValue("value", string.Empty);
                                    foreach (System.Net.Cookie cookie13 in response3.Cookies)
                                    {
                                        container.Add(cookie13);
                                    }
                                    if (response3 != null)
                                    {
                                        response3.Close();
                                    }
                                    HttpWebRequest request5 = (HttpWebRequest) WebRequest.Create(str33);
                                    Class21.smethod_0(ref request5, false);
                                    request5.Method = "POST";
                                    request5.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                                    request5.Timeout = this.int_0;
                                    request5.CookieContainer = container;
                                    if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                                    {
                                        request5.Proxy = proxy;
                                        if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                                        {
                                            request5.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                                        }
                                    }
                                    string str10 = ("TargetResource=" + Uri.EscapeDataString(str34)) + "&REF=" + Uri.EscapeDataString(str35);
                                    byte[] buffer4 = Encoding.ASCII.GetBytes(str10);
                                    request5.ContentLength = buffer4.Length;
                                    HttpWebResponse response6 = null;
                                    try
                                    {
                                        using (Stream stream4 = request5.GetRequestStream())
                                        {
                                            stream4.Write(buffer4, 0, buffer4.Length);
                                            stream4.Close();
                                        }
                                        response6 = (HttpWebResponse) request5.GetResponse();
                                        foreach (System.Net.Cookie cookie14 in response6.Cookies)
                                        {
                                            container.Add(cookie14);
                                        }
                                        if (response6 != null)
                                        {
                                            response6.Close();
                                        }
                                        HttpWebRequest request10 = (HttpWebRequest) WebRequest.Create(this.dictionary_15[this.int_2]);
                                        Class21.smethod_0(ref request10, false);
                                        request10.Method = "GET";
                                        request10.Timeout = this.int_0;
                                        request10.CookieContainer = container;
                                        if (!class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                                        {
                                            request10.Proxy = proxy;
                                            if (!class2.class39_0.gclass0_0.proxyUsername.Equals(string.Empty))
                                            {
                                                request10.Proxy.Credentials = new NetworkCredential(class2.class39_0.gclass0_0.proxyUsername, class2.class39_0.gclass0_0.proxyPW);
                                            }
                                        }
                                        try
                                        {
                                            HttpWebResponse response7 = (HttpWebResponse) request10.GetResponse();
                                            document.Load(response7.GetResponseStream());
                                            if (document.DocumentNode.SelectNodes("//div[contains(@class,'accountwelcome')]")[int.Parse(this.string_0.Substring(0x1f, 1))] == null)
                                            {
                                                flag = true;
                                                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Invalid adidas account data. \n");
                                            }
                                            container3 = container;
                                            foreach (System.Net.Cookie cookie15 in response7.Cookies)
                                            {
                                                container3.Add(cookie15);
                                            }
                                            if (response7 != null)
                                            {
                                                response7.Close();
                                            }
                                        }
                                        catch (WebException)
                                        {
                                            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                                            flag = true;
                                        }
                                    }
                                    catch (WebException)
                                    {
                                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while trying to log into adidas account.\n");
                                        flag = true;
                                    }
                                }
                                catch (WebException)
                                {
                                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                                    flag = true;
                                }
                            }
                            catch (WebException)
                            {
                                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                                flag = true;
                            }
                        }
                        catch (WebException)
                        {
                            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                            flag = true;
                        }
                    }
                    catch (WebException)
                    {
                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                        flag = true;
                    }
                    if (!flag)
                    {
                        ArrayList list2 = new ArrayList();
                        foreach (System.Net.Cookie cookie6 in container3.smethod_7())
                        {
                            CefSharp.Cookie cookie5 = new CefSharp.Cookie {
                                Name = cookie6.Name,
                                Value = cookie6.Value,
                                Domain = cookie6.Domain,
                                Path = cookie6.Path,
                                Secure = cookie6.Secure,
                                Expires = new DateTime?(cookie6.Expires)
                            };
                            list2.Add(cookie5);
                        }
                        class2.class39_0.gclass0_0.adiName = class5.string_0;
                        class2.class39_0.gclass0_0.adiPw = class5.string_1;
                        class2.class39_0.gclass0_0.button4 = "Copy account data";
                        class2.class39_0.gclass0_0.timeOfCompletion = DateTime.Now;
                        class2.class39_0.gclass0_0.cookieList = list2;
                        if (class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
                        {
                            class2.class39_0.gclass0_0.useProxyCheckout = false;
                        }
                        this.arrayList_3.Add(class2.class39_0.gclass0_0);
                        this.arrayList_0.Remove(class2.class39_0.gclass0_0);
                        MethodInvoker invoker3 = class2.class39_0.methodInvoker_3 ?? (class2.class39_0.methodInvoker_3 = new MethodInvoker(class2.class39_0.method_3));
                        base.Invoke(invoker3);
                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.class39_0.gclass0_0.id.ToString() + ":  Successfully logged in to adidas account.\n");
                        if (this.soundBox.Checked)
                        {
                            player.Play();
                        }
                        class2.class39_0.gclass0_0.isRunning = false;
                        if (class2.class39_0.gclass0_0.checkoutProfile != null)
                        {
                            this.method_16(class2.class39_0.gclass0_0);
                        }
                        return;
                    }
                }
            }
            if (this.soundBox.Checked)
            {
                player.Play();
            }
            class2.class39_0.gclass0_0.timeOfCompletion = DateTime.Now;
            class2.class39_0.gclass0_0.cookieList = list;
            if (class2.class39_0.gclass0_0.proxy.Equals(string.Empty))
            {
                class2.class39_0.gclass0_0.useProxyCheckout = false;
            }
            this.arrayList_3.Add(class2.class39_0.gclass0_0);
            this.arrayList_0.Remove(class2.class39_0.gclass0_0);
            MethodInvoker method = class2.class39_0.methodInvoker_4 ?? (class2.class39_0.methodInvoker_4 = new MethodInvoker(class2.class39_0.method_4));
            base.Invoke(method);
            class2.class39_0.gclass0_0.isRunning = false;
            if (class2.class39_0.gclass0_0.checkoutProfile != null)
            {
                this.method_16(class2.class39_0.gclass0_0);
            }
        }
        else
        {
            Class24 class3 = new Class24 {
                class42_0 = class2
            };
            if (str3.Contains("Sorry, you have been blocked"))
            {
                string[] textArray11 = new string[] { DateTime.Now.ToString("hh:mm:ss"), ":  Task ", class3.class42_0.class39_0.gclass0_0.id.ToString(), ": PID: ", class3.class42_0.class39_0.gclass0_0.pid, ", Size: ", class3.class42_0.class39_0.gclass0_0.getSizeString(), " FAILED because your IP/Proxy has been blocked by adidas.!\n" };
                class3.string_0 = string.Concat(textArray11);
            }
            else if (str3.Contains("INVALID_CAPTCHA"))
            {
                string[] textArray12 = new string[] { DateTime.Now.ToString("hh:mm:ss"), ":  Task ", class3.class42_0.class39_0.gclass0_0.id.ToString(), ": PID: ", class3.class42_0.class39_0.gclass0_0.pid, ", Size: ", class3.class42_0.class39_0.gclass0_0.getSizeString(), " FAILED because the API-Key is wrong!\n" };
                class3.string_0 = string.Concat(textArray12);
            }
            else
            {
                string[] textArray10 = new string[] { DateTime.Now.ToString("hh:mm:ss"), ":  Task ", class3.class42_0.class39_0.gclass0_0.id.ToString(), ": PID: ", class3.class42_0.class39_0.gclass0_0.pid, ", Size: ", class3.class42_0.class39_0.gclass0_0.getSizeString(), " FAILED because the item is not in stock!\n" };
                class3.string_0 = string.Concat(textArray10);
                flag2 = false;
                this.method_13(class3.string_0);
                goto Label_0067;
            }
            base.Invoke(new MethodInvoker(class3.method_0));
            class3.class42_0.class39_0.gclass0_0.isRunning = false;
        }
    }

    public void method_12(string string_27, int int_10)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/notify_carted.php");
        byte[] data = new byte[0x200];
        new RNGCryptoServiceProvider().GetBytes(data);
        string str2 = BitConverter.ToString(data);
        string str3 = DateTime.Now.ToString();
        string[] textArray1 = new string[] { string_27, int_10.ToString(), this.int_2.ToString(), str3, str2 };
        string s = (((((("pid=" + string_27) + "&size=" + int_10.ToString()) + "&location=" + this.int_2.ToString()) + "&timestamp=" + str3) + "&salt=" + str2) + "&app=yCoppCaptchaADBDB") + "&signature=" + this.method_8(string.Concat(textArray1));
        byte[] bytes = Encoding.ASCII.GetBytes(s);
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = bytes.Length;
        request.Timeout = 0x2710;
        bool flag = false;
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
            flag = true;
        }
        if (flag)
        {
            HttpWebRequest request2 = (HttpWebRequest) WebRequest.Create("http://script.ycopp.com/scripts/notify_carted.php");
            request2.Method = "POST";
            request2.ContentType = "application/x-www-form-urlencoded";
            request2.ContentLength = bytes.Length;
            request2.Timeout = 0x2710;
            try
            {
                using (Stream stream2 = request2.GetRequestStream())
                {
                    stream2.Write(bytes, 0, bytes.Length);
                }
                response = (HttpWebResponse) request2.GetResponse();
            }
            catch (WebException)
            {
            }
        }
        if (response != null)
        {
            response.Close();
        }
    }

    public void method_13(string string_27)
    {
        Class28 class2 = new Class28 {
            mainForm_0 = this,
            string_0 = string_27
        };
        base.Invoke(new MethodInvoker(class2.method_0));
    }

    public void method_14()
    {
        for (int i = 4; !this.bool_3; i++)
        {
            for (int j = this.arrayList_3.Count - 1; j >= 0; j--)
            {
                if (((GClass0) this.arrayList_3[j]).getRemainingTime().Equals("-1"))
                {
                    this.arrayList_3.RemoveAt(j);
                }
            }
            base.Invoke(new MethodInvoker(this.method_69));
            if (i > 3)
            {
                SharpSerializer serializer = new SharpSerializer(true);
                try
                {
                    serializer.Serialize(this.arrayList_0, "tasks.bin");
                }
                catch (Exception)
                {
                }
                try
                {
                    serializer.Serialize(this.arrayList_3, "ctasks.bin");
                }
                catch (Exception)
                {
                }
                i = 0;
            }
            Thread.Sleep(0x3e8);
        }
    }

    public void method_15()
    {
        while (!this.bool_3)
        {
            Class37 class3 = new Class37 {
                mainForm_0 = this,
                arrayList_0 = new ArrayList()
            };
            object syncRoot = this.arrayList_0.SyncRoot;
            lock (syncRoot)
            {
                using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
                {
                    double totalSeconds;
                    DateTime time2;
                Label_0044:
                    if (!enumerator.MoveNext())
                    {
                        goto Label_01DD;
                    }
                    Class31 class2 = new Class31 {
                        class37_0 = class3,
                        gclass0_0 = (GClass0) enumerator.Current
                    };
                    if (!class2.gclass0_0.automaticStart || class2.gclass0_0.isStarted)
                    {
                        goto Label_0044;
                    }
                    DateTime now = DateTime.Now;
                    try
                    {
                        now = DateTime.ParseExact(class2.gclass0_0.startTime, "HH:mm:ss", CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            now = DateTime.ParseExact(class2.gclass0_0.startTime, "h:mm:ss tt", CultureInfo.InvariantCulture);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error in the automatic task feature. Please contact info@ycopp.com");
                            break;
                        }
                    }
                    goto Label_018C;
                Label_00E4:
                    if ((((totalSeconds > 0.0) && (totalSeconds < 100.0)) && ((this.queue_0.Count == 0) && !class2.gclass0_0.automaticNoTokenNotified)) && class2.gclass0_0.needsCaptcha)
                    {
                        base.Invoke(new MethodInvoker(class2.method_0));
                        class2.gclass0_0.automaticNoTokenNotified = true;
                    }
                Label_0142:
                    if ((now.Hour >= time2.Hour) && (totalSeconds <= 0.0))
                    {
                        class2.gclass0_0.isStarted = true;
                        class2.class37_0.arrayList_0.Add(class2.gclass0_0);
                    }
                    goto Label_0044;
                Label_018C:
                    time2 = DateTime.Now;
                    totalSeconds = now.Subtract(time2).TotalSeconds;
                    if (now.Hour < time2.Hour)
                    {
                        goto Label_0142;
                    }
                    goto Label_00E4;
                }
            }
        Label_01DD:
            if (class3.arrayList_0.Count > 0)
            {
                Thread thread = new Thread(new ThreadStart(class3.method_0)) {
                    IsBackground = true
                };
                this.arrayList_2.Add(thread);
                thread.Start();
            }
            Thread.Sleep(0x3e8);
        }
    }

    private void method_16(GClass0 gclass0_0)
    {
        Class34 class2 = new Class34 {
            mainForm_0 = this,
            gclass0_0 = gclass0_0,
            int_0 = this.int_2
        };
        if (class2.gclass0_0.locationIndex != -1)
        {
            class2.int_0 = class2.gclass0_0.locationIndex;
        }
        class2.chromiumWebBrowser_0 = new ChromiumWebBrowser("about:blank");
        class2.requestContext_0 = new CefSharp.RequestContext();
        if (class2.gclass0_0.checkoutProfile.useProxy && (class2.gclass0_0.proxy != string.Empty))
        {
            Cef.UIThreadTaskFactory.StartNew(new Action(class2, (IntPtr) this.method_0));
            if (!class2.gclass0_0.proxyUsername.Equals(string.Empty))
            {
                class2.chromiumWebBrowser_0.RequestHandler = new Class48(class2.gclass0_0.proxyUsername, class2.gclass0_0.proxyPW);
            }
        }
        class2.chromiumWebBrowser_0.RequestContext = class2.requestContext_0;
        foreach (CefSharp.Cookie cookie in class2.gclass0_0.cookieList)
        {
            class2.chromiumWebBrowser_0.RequestContext.GetDefaultCookieManager(new Class47()).SetCookieAsync(this.dictionary_5[class2.int_0], cookie);
        }
        class2.chromiumWebBrowser_0.Dock = DockStyle.Fill;
        class2.browserForm_0 = new BrowserForm(this);
        class2.browserForm_0.string_0 = this.dictionary_2[class2.int_0];
        class2.browserForm_0.string_1 = this.dictionary_3[class2.int_0];
        class2.browserForm_0.string_2 = this.dictionary_4[class2.int_0];
        base.Invoke(new MethodInvoker(class2.method_1));
        class2.gclass0_0.autoCheckoutBrowserForm = class2.browserForm_0;
        class2.gclass0_0.autoCheckoutState = 1;
        class2.gclass0_0.button0 = string.Empty;
        class2.gclass0_0.button1 = string.Empty;
        class2.gclass0_0.button2 = string.Empty;
        class2.gclass0_0.button3 = string.Empty;
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + class2.gclass0_0.id.ToString() + ": Auto Checkout started!\n");
        class2.chromiumWebBrowser_0.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(class2.method_2);
        class2.browserForm_0.method_1(class2.gclass0_0);
        if (this.deleteCompletedBox.Checked)
        {
            this.arrayList_3.Remove(class2.gclass0_0);
            MethodInvoker method = new MethodInvoker(this.method_70);
            base.Invoke(method);
        }
        this.browserForm_0 = class2.browserForm_0;
    }

    private void method_17(GClass0 gclass0_0)
    {
        Class40 class2 = new Class40 {
            mainForm_0 = this,
            gclass0_0 = gclass0_0,
            int_0 = this.int_2
        };
        if (class2.gclass0_0.locationIndex != -1)
        {
            class2.int_0 = class2.gclass0_0.locationIndex;
        }
        class2.chromiumWebBrowser_0 = new ChromiumWebBrowser("about:blank");
        class2.requestContext_0 = new CefSharp.RequestContext();
        if (class2.gclass0_0.useProxyCheckout && (class2.gclass0_0.proxy != string.Empty))
        {
            Cef.UIThreadTaskFactory.StartNew(new Action(class2, (IntPtr) this.method_0));
            if (!class2.gclass0_0.proxyUsername.Equals(string.Empty))
            {
                class2.chromiumWebBrowser_0.RequestHandler = new Class48(class2.gclass0_0.proxyUsername, class2.gclass0_0.proxyPW);
            }
        }
        class2.chromiumWebBrowser_0.RequestContext = class2.requestContext_0;
        foreach (CefSharp.Cookie cookie in class2.gclass0_0.cookieList)
        {
            class2.chromiumWebBrowser_0.RequestContext.GetDefaultCookieManager(new Class47()).SetCookieAsync(this.dictionary_5[class2.int_0], cookie);
        }
        class2.chromiumWebBrowser_0.Dock = DockStyle.Fill;
        class2.browserForm_0 = new BrowserForm();
        class2.browserForm_0.string_0 = this.dictionary_2[class2.int_0];
        class2.browserForm_0.string_1 = this.dictionary_3[class2.int_0];
        class2.browserForm_0.string_2 = this.dictionary_4[class2.int_0];
        base.Invoke(new MethodInvoker(class2.method_1));
        base.Invoke(new MethodInvoker(class2.method_2));
        class2.chromiumWebBrowser_0.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(class2.method_3);
        if (this.deleteCompletedBox.Checked)
        {
            this.arrayList_3.Remove(class2.gclass0_0);
            MethodInvoker method = new MethodInvoker(this.method_71);
            base.Invoke(method);
        }
        this.method_12(class2.gclass0_0.pid, class2.gclass0_0.size);
    }

    private void method_18(GClass0 gclass0_0, string string_27)
    {
        Class43 class2 = new Class43 {
            mainForm_0 = this,
            gclass0_0 = gclass0_0,
            string_0 = string_27,
            chromiumWebBrowser_0 = new ChromiumWebBrowser(this.string_17),
            requestContext_0 = new CefSharp.RequestContext()
        };
        if (class2.gclass0_0.proxy != string.Empty)
        {
            Cef.UIThreadTaskFactory.StartNew(new Action(class2, (IntPtr) this.method_0));
        }
        class2.chromiumWebBrowser_0.RequestContext = class2.requestContext_0;
        class2.chromiumWebBrowser_0.Dock = DockStyle.Fill;
        class2.browserForm_0 = new BrowserForm();
        class2.browserForm_0.string_0 = this.dictionary_2[this.int_2];
        class2.browserForm_0.string_1 = this.dictionary_3[this.int_2];
        class2.browserForm_0.string_2 = this.dictionary_4[this.int_2];
        base.Invoke(new MethodInvoker(class2.method_1));
        class2.bool_0 = false;
        class2.chromiumWebBrowser_0.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(class2.method_2);
    }

    private void method_19(ChromiumWebBrowser chromiumWebBrowser_1, GClass0 gclass0_0, string string_27)
    {
        Class25 class2 = new Class25 {
            mainForm_0 = this,
            gclass0_0 = gclass0_0,
            string_0 = string_27
        };
        Thread.Sleep(0x2710);
        Class56 visitor = new Class56();
        if (chromiumWebBrowser_1.RequestContext.GetDefaultCookieManager(new Class47()).VisitAllCookies(visitor))
        {
            visitor.method_0();
        }
        CookieContainer container = new CookieContainer();
        foreach (CefSharp.Cookie cookie in visitor.method_1())
        {
            if (!cookie.Value.Contains(","))
            {
                System.Net.Cookie cookie2 = new System.Net.Cookie {
                    Name = cookie.Name,
                    Value = cookie.Value,
                    Domain = cookie.Domain,
                    Path = cookie.Path,
                    Secure = cookie.Secure
                };
                if (cookie.Expires.HasValue)
                {
                    cookie2.Expires = cookie.Expires.Value;
                }
                container.Add(cookie2);
            }
        }
        class2.gclass0_0.cookieCont = container;
        Thread thread = new Thread(new ThreadStart(class2.method_0));
        this.arrayList_1.Add(thread);
        thread.Start();
    }

    public void method_2()
    {
        while (!this.bool_3)
        {
            try
            {
                if (!this.thread_2.IsAlive)
                {
                    this.method_6();
                    this.thread_2 = new Thread(new ThreadStart(this.method_1));
                    this.thread_2.IsBackground = true;
                    this.thread_2.Start();
                }
            }
            catch (ThreadAbortException)
            {
                break;
            }
            Thread.Sleep(500);
        }
    }

    private void method_20(object sender, EventArgs e)
    {
    }

    private void method_21(object sender, EventArgs e)
    {
    }

    private void method_22(object sender, EventArgs e)
    {
        this.method_23(false);
    }

    private void method_23(bool bool_15)
    {
        Class32 class1 = new Class32 {
            mainForm_0 = this,
            bool_0 = bool_15
        };
        new Thread(new ThreadStart(class1.method_0)).Start();
    }

    private void method_24()
    {
        while (!this.bool_3)
        {
            if (!this.method_26(this.string_8, this.string_9, int.Parse(this.string_26.Substring(0x21, 1))))
            {
                base.Invoke(new MethodInvoker(this.method_73));
            }
            else
            {
                this.string_2 = "4";
            }
            Thread.Sleep(0x493e0);
        }
    }

    private void method_25(object sender, EventArgs e)
    {
        this.thread_0.Abort();
    }

    public bool method_26(string string_27, string string_28, int int_10)
    {
        string str2;
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/validate_license.php");
        string s = (("name=" + string_27.Trim()) + "&serial=" + string_28.Trim()) + "&hid=" + Class21.smethod_4();
        if (int_10 == 2)
        {
            s = s + "&app=yCoppCaptchaADBDB";
        }
        else if (int_10 == 3)
        {
            s = s + "&app=yCoppElite";
        }
        else if (int_10 == 4)
        {
            s = s + "&app=yCoppEnterprise";
        }
        byte[] bytes = Encoding.ASCII.GetBytes(s);
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = bytes.Length;
        request.Timeout = 0x1388;
        HttpWebResponse response = null;
        bool flag2 = false;
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
            return true;
        }
        if (flag2)
        {
            bool flag;
            try
            {
                request = (HttpWebRequest) WebRequest.Create("http://script.ycopp.com/scripts/validate_license.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;
                request.Timeout = 0x1d4c;
                using (Stream stream2 = request.GetRequestStream())
                {
                    stream2.Write(bytes, 0, bytes.Length);
                }
                response = null;
                response = (HttpWebResponse) request.GetResponse();
                goto Label_017A;
            }
            catch (WebException)
            {
                if (response != null)
                {
                    response.Close();
                }
                flag = true;
            }
            return flag;
        }
    Label_017A:
        str2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
        if (!str2.Contains("ConnectionError") && !str2.Contains("ErrorActivating"))
        {
            if (str2.Contains("InvalidLicense"))
            {
                return false;
            }
            if (str2.Contains("ValidLicense"))
            {
                return (((int_10 == 2) && Class21.smethod_5("ValidLicenseyCoppCaptchaADBDB" + string_27 + string_28, str2.Substring(12))) || (((int_10 == 3) && Class21.smethod_5("ValidLicenseyCoppElite" + string_27 + string_28, str2.Substring(12))) || ((int_10 == 4) && Class21.smethod_5("ValidLicenseyCoppEnterprise" + string_27 + string_28, str2.Substring(12)))));
            }
            if (!str2.Contains("SuccessfullyActivated"))
            {
                HttpStatusCode statusCode = response.StatusCode;
            }
        }
        return false;
    }

    public string[] method_27(string string_27, string string_28, int int_10)
    {
        string str2;
        string[] strArray = new string[10];
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/validate_license.php");
        string s = (("name=" + string_27.Trim()) + "&serial=" + string_28.Trim()) + "&hid=" + Class21.smethod_4();
        if (int_10 == 2)
        {
            s = s + "&app=yCoppCaptchaADBDB";
        }
        else if (int_10 == 3)
        {
            s = s + "&app=yCoppElite";
        }
        else if (int_10 == 4)
        {
            s = s + "&app=yCoppEnterprise";
        }
        byte[] bytes = Encoding.ASCII.GetBytes(s);
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = bytes.Length;
        request.Timeout = 0x1388;
        HttpWebResponse response = null;
        bool flag = false;
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
            return strArray;
        }
        if (flag)
        {
            string[] strArray2;
            try
            {
                request = (HttpWebRequest) WebRequest.Create("http://script.ycopp.com/scripts/validate_license.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;
                request.Timeout = 0x1d4c;
                using (Stream stream2 = request.GetRequestStream())
                {
                    stream2.Write(bytes, 0, bytes.Length);
                }
                response = null;
                response = (HttpWebResponse) request.GetResponse();
                goto Label_0182;
            }
            catch (WebException)
            {
                if (response != null)
                {
                    response.Close();
                }
                strArray2 = strArray;
            }
            return strArray2;
        }
    Label_0182:
        str2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
        if (!str2.Contains("ConnectionError") && !str2.Contains("ErrorActivating"))
        {
            if (str2.Contains("InvalidLicense"))
            {
                return strArray;
            }
            if (str2.Contains("ValidLicense"))
            {
                if ((int_10 != 2) || !Class21.smethod_5("ValidLicenseyCoppCaptchaADBDB" + string_27 + string_28, str2.Substring(12)))
                {
                    if ((int_10 == 3) && Class21.smethod_5("ValidLicenseyCoppElite" + string_27 + string_28, str2.Substring(12)))
                    {
                        strArray[0] = response.Headers.Get("ridkqes");
                        strArray[1] = response.Headers.Get("a");
                        strArray[2] = response.Headers.Get("b");
                        strArray[3] = response.Headers.Get("c");
                        strArray[4] = response.Headers.Get("d");
                        strArray[5] = response.Headers.Get("e");
                        strArray[6] = response.Headers.Get("f");
                        strArray[7] = response.Headers.Get("g");
                        strArray[8] = response.Headers.Get("h");
                        return strArray;
                    }
                    if ((int_10 == 4) && Class21.smethod_5("ValidLicenseyCoppEnterprise" + string_27 + string_28, str2.Substring(12)))
                    {
                        strArray[0] = response.Headers.Get("ridkqes");
                        strArray[1] = response.Headers.Get("a");
                        strArray[2] = response.Headers.Get("b");
                        strArray[3] = response.Headers.Get("c");
                        strArray[4] = response.Headers.Get("d");
                        strArray[5] = response.Headers.Get("e");
                        strArray[6] = response.Headers.Get("f");
                        strArray[7] = response.Headers.Get("g");
                        strArray[8] = response.Headers.Get("h");
                        strArray[9] = response.Headers.Get("j");
                        return strArray;
                    }
                }
                return strArray;
            }
            str2.Contains("SuccessfullyActivated");
        }
        return strArray;
    }

    public void method_28()
    {
        this.twoCaptchaButton.PerformClick();
        Thread.Sleep(50);
        this.twoCaptchaButton.PerformClick();
    }

    private void method_29()
    {
        while (!this.bool_3)
        {
            for (int i = 0; i < this.int_5; i++)
            {
                new Thread(new ThreadStart(this.method_74)).Start();
            }
            if (this.int_4 < 0x3e7)
            {
                this.int_4 = 0x3e8;
            }
            Thread.Sleep(this.int_4);
        }
    }

    public void method_3()
    {
        while (!this.bool_3)
        {
            try
            {
                string str = string.Empty;
                if (this.int_2 <= 5)
                {
                    str = "eu";
                }
                else if (this.int_2 == 6)
                {
                    str = "us";
                }
                else if (this.int_2 == 7)
                {
                    str = "ca";
                }
                else if ((this.int_2 > 8) && (this.int_2 < 0x10))
                {
                    str = "eu";
                }
                else if (this.int_2 == 0x11)
                {
                    str = "eu";
                }
                else if (this.int_2 > 0x11)
                {
                    str = "us";
                }
                else
                {
                    str = "au";
                }
                byte[] data = new byte[0x200];
                new RNGCryptoServiceProvider().GetBytes(data);
                BitConverter.ToString(data);
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/get_api.php");
                string s = ((("name=" + this.string_8) + "&serial=" + this.string_9) + "&hid=" + Class21.smethod_4()) + "&mode=" + str;
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                bool flag = false;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;
                request.Timeout = 0x1388;
                HttpWebResponse response = null;
                bool flag2 = false;
                try
                {
                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(bytes, 0, bytes.Length);
                    }
                    response = (HttpWebResponse) request.GetResponse();
                }
                catch (Exception)
                {
                    flag2 = true;
                }
                if (flag2)
                {
                    try
                    {
                        HttpWebRequest request1 = (HttpWebRequest) WebRequest.Create("http://script.ycopp.com/scripts/get_api.php");
                        request1.Method = "POST";
                        request1.ContentType = "application/x-www-form-urlencoded";
                        request1.ContentLength = bytes.Length;
                        request1.Timeout = 0x1388;
                        using (Stream stream2 = request.GetRequestStream())
                        {
                            stream2.Write(bytes, 0, bytes.Length);
                        }
                        response = (HttpWebResponse) request.GetResponse();
                    }
                    catch (Exception)
                    {
                        flag = true;
                        MessageBox.Show("Error retrieving API-Key. Standard key will be used. Please try again later.");
                        this.bool_12 = true;
                        break;
                    }
                }
                if (!flag)
                {
                    string str3 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    response.Close();
                    if (str3.Equals("EVal"))
                    {
                        Environment.Exit(0);
                    }
                    if (!str3.Equals("InvalidRequest") && !str3.Equals("InvalidToken"))
                    {
                        if (response.Headers.Get("captchaDup") != null)
                        {
                            this.string_3 = response.Headers.Get("captchaDup");
                        }
                        if (this.string_5 != str3)
                        {
                            MessageBox.Show("Successfully retrieved a new API-Key from server.");
                            this.string_5 = str3;
                            this.manualResetEvent_0.Reset();
                            this.queue_0.Clear();
                            this.manualResetEvent_0.Set();
                            MethodInvoker method = new MethodInvoker(this.method_55);
                            base.Invoke(method);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error retrieving API-Key. Standard key will be used. Please contact support@ycopp.com");
                        this.string_5 = this.string_6;
                    }
                    this.bool_12 = true;
                }
                else
                {
                    this.string_5 = this.string_6;
                }
                this.button1.Enabled = true;
            }
            catch (ThreadAbortException)
            {
                break;
            }
            Thread.Sleep(0x4e20);
        }
    }

    private string method_30()
    {
        string[] textArray1 = new string[] { "http://2captcha.com/in.php?key=", this.string_12, "&method=use", this.string_26.Substring(13, 1), "recaptcha&googlekey=", this.string_5, Class21.string_3, "&pageurl=http://www.adidas.com" };
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(string.Concat(textArray1));
        request.Method = "GET";
        request.Timeout = this.int_0;
        HttpWebResponse response = null;
        try
        {
            response = (HttpWebResponse) request.GetResponse();
        }
        catch (WebException)
        {
            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [2Captcha] Fatal error while trying to upload a captcha. \n");
            if (response != null)
            {
                response.Close();
            }
            return "Error";
        }
        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        {
            string str3 = reader.ReadToEnd();
            if (str3.Length >= 3)
            {
                if (str3.Equals("ERROR_WRONG_USER_KEY"))
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [2Captcha] Wrong API-Key. Please check your Account Settings. \n");
                    return "Error";
                }
                if (str3.Substring(0, 3) == "OK|")
                {
                    string str2 = str3.Remove(0, 3);
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Captcha-ID " + str2 + "] New Captcha uploaded. Now waiting for a result... \n");
                    int num = 0;
                    while (true)
                    {
                        if (num >= 0x18)
                        {
                            break;
                        }
                        try
                        {
                            using (WebResponse response2 = WebRequest.Create("http://2captcha.com/res.php?key=" + this.string_12 + "&action=get&id=" + str2).GetResponse())
                            {
                                using (StreamReader reader2 = new StreamReader(response2.GetResponseStream()))
                                {
                                    string str4 = reader2.ReadToEnd();
                                    if (str4.Length < 3)
                                    {
                                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Captcha-ID " + str2 + "] Error retrieving the captcha response. \n");
                                        return "Error";
                                    }
                                    if (str4.Substring(0, 3) == "OK|")
                                    {
                                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Captcha-ID " + str2 + "] Got captcha response. \n");
                                        return str4.Remove(0, 3);
                                    }
                                    if (str4 != ("CA" + this.string_0.Substring(2, 1) + "CHA_NOT_READY"))
                                    {
                                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Captcha-ID " + str2 + "] Error solving the captcha. \n");
                                        return "Error";
                                    }
                                    if (((num % 3) == 0) && (num != 0))
                                    {
                                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Captcha-ID " + str2 + "] Still waiting for a result... \n");
                                    }
                                }
                            }
                        }
                        catch (WebException)
                        {
                            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Error while trying to contact the 2Captcha Servers. \n");
                        }
                        Thread.Sleep(0x1388);
                        num++;
                    }
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Captcha-ID " + str2 + "] Timeout while solving the captcha. \n");
                    return "Timeout";
                }
            }
            return "Error";
        }
    }

    private void method_31()
    {
        while (!this.bool_3)
        {
            for (int i = 0; i < this.int_8; i++)
            {
                new Thread(new ThreadStart(this.method_75)).Start();
            }
            if (this.int_7 < 0x3e7)
            {
                this.int_7 = 0x3e8;
            }
            Thread.Sleep(this.int_7);
        }
    }

    private string method_32()
    {
        GClass7 class2;
        if (this.string_14.Equals(string.Empty))
        {
            class2 = AnticaptchaApiWrapper.CreateNoCaptchaTaskProxyless("api.anti-captcha.com", this.string_13, "http://adidas.com", this.string_5 + Class21.string_3, "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36", string.Empty);
        }
        else
        {
            class2 = AnticaptchaApiWrapper.CreateNoCaptchaTask("api.anti-captcha.com", this.string_13, "http://adidas.com", this.string_5 + Class21.string_3, (AnticaptchaApiWrapper.GEnum1) 0, this.string_14, this.int_6, this.string_15, this.string_16, "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36", string.Empty);
        }
        if ((class2.method_1() != null) && (class2.method_1().Length > 0))
        {
            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [AntiCaptcha] Error from the API: " + class2.method_1() + "\n");
            return "Error";
        }
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [AntiCaptcha] New Captcha uploaded. \n");
        Thread.Sleep(0x2710);
        return this.method_33(class2);
    }

    private string method_33(GClass7 gclass7_0)
    {
        GClass3 class2;
        int num = 0;
    Label_0096:
        class2 = AnticaptchaApiWrapper.GetTaskResult("api.anti-captcha.com", this.string_13, gclass7_0);
        if ((class2 != null) && !class2.method_3().Equals((GClass3.GEnum0) 0))
        {
            if (class2.method_3().Equals((GClass3.GEnum0) 2))
            {
                if (((num % 3) == 0) && (num != 0))
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [Anti-Captcha] Still waiting for a result... \n");
                }
                num++;
                Thread.Sleep(0x1388);
            }
            if (class2.method_3().Equals((GClass3.GEnum0) 2))
            {
                goto Label_0096;
            }
        }
        if ((class2 != null) && (class2.method_4() != null))
        {
            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [AntiCaptcha] Got captcha response. \n");
            return class2.method_4();
        }
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  [AntiCaptcha] Error from the API: " + ((class2 != null) ? class2.method_2() : "/empty/") + "\n");
        return "Error";
    }

    private void method_34(object sender, EventArgs e)
    {
    }

    private void method_35()
    {
        HttpWebRequest request;
        string str = string.Empty;
        string str2 = string.Empty;
        bool flag = true;
    Label_000F:
        request = (HttpWebRequest) WebRequest.Create(this.dictionary_6[this.int_2] + "/S79168.html");
        Class21.smethod_0(ref request, true);
        request.Method = "GET";
        request.Timeout = this.int_0;
        request.CookieContainer = new CookieContainer();
        HttpWebResponse response = null;
        str2 = str;
        try
        {
            response = (HttpWebResponse) request.GetResponse();
        }
        catch (WebException)
        {
            if (response != null)
            {
                response.Close();
            }
            if (flag)
            {
                base.Invoke(new MethodInvoker(this.method_76));
                return;
            }
            goto Label_0106;
        }
        flag = false;
        try
        {
            str = string.Empty;
            foreach (System.Net.Cookie cookie in response.Cookies)
            {
                if (cookie.Name.Equals("gceeqs"))
                {
                    str = cookie.Value;
                }
            }
            response.Close();
            goto Label_0118;
        }
        catch (Exception)
        {
            goto Label_0118;
        }
    Label_0106:
        if (!str.Equals(string.Empty))
        {
            goto Label_000F;
        }
        if (!str2.Equals(string.Empty))
        {
            bool flag2 = false;
            for (int i = 0; i < this.int_9; i++)
            {
                if (this.string_21[this.int_9].Equals("gceeqs"))
                {
                    this.string_22[this.int_9] = str2;
                    flag2 = true;
                }
            }
            if (!flag2)
            {
                int index = this.int_9;
                this.string_21[index] = "gceeqs";
                this.string_22[index] = str2;
                this.int_9++;
            }
        }
        base.Invoke(new MethodInvoker(this.method_77));
        return;
    Label_0118:
        Thread.Sleep(0x2710);
        goto Label_0106;
    }

    private void method_36()
    {
        while (true)
        {
            if (this.bool_3)
            {
                break;
            }
            CookieContainer container = new CookieContainer();
            HttpWebResponse response = null;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://www.adidas.de/S79168.html");
            Class21.smethod_0(ref request, true);
            request.Method = "GET";
            request.Timeout = this.int_0;
            request.AllowAutoRedirect = false;
            request.CookieContainer = new CookieContainer();
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (WebException)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Fatal error while sending the cookie preload request! Please check your connection and proxy server.\n");
                if (response != null)
                {
                    response.Close();
                }
                break;
            }
            try
            {
                foreach (System.Net.Cookie cookie in response.Cookies)
                {
                    container.Add(cookie);
                }
                response.Close();
            }
            catch (Exception)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Error while parsing the preloaded cookies. Maybe the set location is wrong?\n");
                response.Close();
            }
            this.cookieContainer_0 = container;
            Thread.Sleep(0x83d60);
        }
    }

    public void method_38(string string_27, string string_28, string string_29)
    {
        foreach (GClass0 class2 in this.arrayList_0)
        {
            if (!string_27.ToLower().Equals("local"))
            {
                class2.proxy = string_27;
            }
            else
            {
                class2.proxy = string.Empty;
            }
            if (!string_28.Equals(string.Empty))
            {
                class2.proxyUsername = string_28;
                class2.proxyPW = string_29;
            }
        }
        if (!string_27.ToLower().Equals("local"))
        {
            this.proxyBox.Text = string_27;
        }
        else
        {
            this.proxyBox.Text = string.Empty;
            this.proxyUsernameBox.Text = string.Empty;
            this.proxyPWBox.Text = string.Empty;
        }
        this.proxyUsernameBox.Text = string_28;
        this.proxyPWBox.Text = string_29;
        this.taskOListView.SetObjects(this.arrayList_0);
    }

    public void method_39(string string_27)
    {
        bool flag = false;
        bool flag2 = false;
        if (this.bool_8)
        {
            this.button1.PerformClick();
            flag = true;
        }
        if (this.bool_6)
        {
            this.twoCaptchaButton.PerformClick();
            flag2 = true;
        }
        if (this.bool_10)
        {
            this.autoUpdateButton.PerformClick();
        }
        this.manualTextBox.Text = string_27;
        this.updateButton.PerformClick();
        if (flag)
        {
            this.button1.PerformClick();
        }
        if (flag2)
        {
            this.twoCaptchaButton.PerformClick();
        }
    }

    public void method_4()
    {
        while (!this.bool_3)
        {
            MethodInvoker invoker;
            try
            {
                byte[] data = new byte[0x200];
                new RNGCryptoServiceProvider().GetBytes(data);
                string str2 = BitConverter.ToString(data);
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/get_bd.php");
                string s = ((("name=" + this.string_8) + "&salt=" + str2) + "&signature=" + this.method_8(this.string_8 + str2)) + "&mode=ABDB1";
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
                catch (Exception)
                {
                    goto Label_0290;
                }
                string str3 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                response.Close();
                if (!str3.Equals("InvalidRequest") && !str3.Equals("InvalidToken"))
                {
                    if ((response.Headers["captchaDuplicateName"] != null) && (response.Headers["captchaDuplicateName"] != this.string_3))
                    {
                        this.string_3 = response.Headers["captchaDuplicateName"];
                        MessageBox.Show("Retrieved new Captcha Duplicate!");
                    }
                    if ((response.Headers["additionalParams"] != null) && (response.Headers["additionalParams"] != this.string_4))
                    {
                        this.string_4 = response.Headers["additionalParams"];
                        MessageBox.Show("Retrieved new Params!");
                    }
                    if (((response.Headers["clientid"] != null) && (response.Headers["clientid"] != this.string_7)) && (response.Headers["clientid"] != this.string_7))
                    {
                        this.string_7 = response.Headers["clientid"];
                        MessageBox.Show("Retrieved new Client ID!");
                    }
                    if ((response.Headers["captchaDuplicateName"] != null) || (response.Headers["additionalParams"] != null))
                    {
                        goto Label_0279;
                    }
                    MessageBox.Show("There is no data to retrieve right now. Try again later!");
                    break;
                }
                MessageBox.Show("Error retrieving backdoor settings. Please contact info@ycopp.com");
            }
            catch (ThreadAbortException)
            {
                break;
            }
        Label_0279:
            invoker = new MethodInvoker(this.method_56);
            base.Invoke(invoker);
        Label_0290:
            Thread.Sleep(0x4e20);
        }
    }

    public void method_40(string string_27, DateTime dateTime_1)
    {
        this.string_25 = string_27;
        this.dateTime_0 = dateTime_1;
        this.hmacLabel.Visible = true;
        this.hmacExpireLabel.Visible = true;
        this.removeHmacBtn.Visible = true;
        if ((this.thread_11 != null) && this.thread_11.IsAlive)
        {
            this.thread_11.Abort();
        }
        this.thread_11 = new Thread(new ThreadStart(this.method_42));
        this.thread_11.IsBackground = true;
        this.thread_11.Start();
    }

    public void method_41(Dictionary<string, string> dictionary_16)
    {
        for (int i = 0; i < this.int_9; i++)
        {
            this.string_21[i] = string.Empty;
        }
        for (int j = 0; j < this.int_9; j++)
        {
            this.string_22[j] = string.Empty;
        }
        this.int_9 = 0;
        foreach (KeyValuePair<string, string> pair in dictionary_16)
        {
            this.string_21[this.int_9] = pair.Key;
            this.string_22[this.int_9] = pair.Value;
            this.int_9++;
        }
    }

    public void method_42()
    {
        Class38 class2 = new Class38 {
            mainForm_0 = this,
            string_0 = string.Empty
        };
        while (!class2.string_0.Equals("-1"))
        {
            TimeSpan span = this.dateTime_0.Subtract(DateTime.Now);
            TimeSpan ts = new TimeSpan(0, 9, 30);
            TimeSpan span3 = span.Add(ts);
            if (span3.TotalSeconds < 0.0)
            {
                class2.string_0 = "-1";
            }
            else if (span3.Seconds < 10)
            {
                class2.string_0 = Math.Floor(span3.TotalMinutes) + ":0" + span3.Seconds;
            }
            else
            {
                class2.string_0 = Math.Floor(span3.TotalMinutes) + ":" + span3.Seconds;
            }
            base.Invoke(class2.methodInvoker_0 ?? (class2.methodInvoker_0 = new MethodInvoker(class2.method_0)));
            Thread.Sleep(990);
        }
        base.Invoke(new MethodInvoker(this.method_78));
    }

    private void method_43(object sender, EventArgs e)
    {
    }

    private void method_44(object sender, CellRightClickEventArgs e)
    {
        Class35 class2 = new Class35 {
            mainForm_0 = this,
            gclass0_0 = (GClass0) e.Model
        };
        if (class2.gclass0_0 != null)
        {
            e.MenuStrip = new ContextMenuStrip();
            e.MenuStrip.Items.Add("Delete");
            e.MenuStrip.Items[0].Click += new EventHandler(this.method_79);
            e.MenuStrip.Items.Add("Export cart to browser");
            e.MenuStrip.Items[1].Click += new EventHandler(class2.method_0);
            if ((class2.gclass0_0 != null) && !class2.gclass0_0.adiName.Equals(string.Empty))
            {
                e.MenuStrip.Items.Add("Copy account data to clipboard");
                e.MenuStrip.Items[2].Click += new EventHandler(class2.method_1);
            }
        }
    }

    public string method_45(HttpListenerRequest httpListenerRequest_0)
    {
        try
        {
            using (StreamReader reader = new StreamReader(httpListenerRequest_0.InputStream, httpListenerRequest_0.ContentEncoding))
            {
                string str = reader.ReadToEnd().Replace("token=", string.Empty);
                if (!str.Equals(string.Empty))
                {
                    try
                    {
                        this.manualResetEvent_0.Reset();
                        TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                        this.queue_0.Enqueue(new Class18(str, (long) span.TotalMilliseconds));
                        this.manualResetEvent_0.Set();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
        catch (Exception)
        {
        }
        return ("<html>\r\n<head>\r\n<style>\r\nform {\r\n  text-align: center;\r\n}\r\nbody {\r\n  text-align: center;\r\n  background-color:#ECEEE3;\r\n  \r\n}\r\n\r\nh1 {\r\n  text-align: center;\r\n}\r\nh3 {\r\n  text-align: center;\r\n}\r\ndiv-captcha {\r\n      text-align: center;\r\n}\r\n    .g-recaptcha {\r\n        display: inline-block;\r\n    }\r\n</style>\r\n<h1> yCopp Captcha Harvester</h1>\r\n\r\n<br>\r\nAfter you retrieved / set a new API-Key in the bot, please RELOAD this page.</h3>\r\n<br><br>\r\n<meta name=\"referrer\" content=\"never\"> <script type='text/javascript' src='https://www.google.com/recaptcha/api.js'></script> </head> <body oncontextmenu=\"return false\"><div id=\"div-captcha\"><div style=\"opacity: 0.9\" class=\"g-recaptcha\" data-sitekey=\"" + this.string_5 + Class21.string_3 + "\"></div></div> <br>\r\n<script>\r\n\r\nwindow.setInterval(function(){\r\n    var token = document.getElementById('g-recaptcha-response').value;\r\n    document.getElementById('g-recaptcha-response').value = '';\r\n    if(token != '')\r\n    {\r\n    var http = new XMLHttpRequest();\r\n    var params = \"token=\" +token;\r\n    http.open(\"POST\", \"/ycopp\", true);\r\n    http.setRequestHeader(\"Content-type\", \"application/x-www-form-urlencoded\");\r\n    http.setRequestHeader(\"Content-length\", params.length)\r\n    http.send(params);\r\n    location.reload();\r\n}\r\n}, 500);\r\n</script>\r\n</body></html>");
    }

    public string[] method_46() =>
        new string[] { this.proxyBox.Text, this.proxyUsernameBox.Text, this.proxyPWBox.Text };

    private void method_47(object sender, FormatRowEventArgs e)
    {
        GClass0 model = (GClass0) e.Model;
        if (model.isCheckout)
        {
            e.Item.BackColor = Color.Green;
        }
        if (model.autoCheckoutState == 2)
        {
            e.Item.BackColor = Color.Green;
        }
        if (model.autoCheckoutState == -1)
        {
            e.Item.BackColor = Color.Red;
        }
        if (model.autoCheckoutState == 1)
        {
            e.Item.BackColor = Color.Yellow;
        }
    }

    private void method_48(object sender, CellRightClickEventArgs e)
    {
        Class26 class2 = new Class26 {
            mainForm_0 = this,
            cellRightClickEventArgs_0 = e
        };
        class2.cellRightClickEventArgs_0.MenuStrip = new ContextMenuStrip();
        class2.cellRightClickEventArgs_0.MenuStrip.Items.Add("Start");
        class2.cellRightClickEventArgs_0.MenuStrip.Items[0].Click += new EventHandler(this.method_81);
        class2.cellRightClickEventArgs_0.MenuStrip.Items.Add("Delete");
        class2.cellRightClickEventArgs_0.MenuStrip.Items[1].Click += new EventHandler(class2.method_0);
        GClass0 model = (GClass0) class2.cellRightClickEventArgs_0.Model;
        if ((model != null) && model.isRunning)
        {
            class2.cellRightClickEventArgs_0.MenuStrip.Items.Add("Stop");
            class2.cellRightClickEventArgs_0.MenuStrip.Items[2].Click += new EventHandler(this.method_82);
        }
    }

    private void method_49(object sender, FormatRowEventArgs e)
    {
        GClass0 model = (GClass0) e.Model;
        if ((model != null) && model.isRunning)
        {
            e.Item.BackColor = Color.Yellow;
        }
    }

    public void method_5()
    {
        if (!Cef.IsInitialized)
        {
            Cef.Initialize(new CefSettings());
        }
        this.chromiumWebBrowser_0 = new ChromiumWebBrowser("http://google.com");
        this.chromiumWebBrowser_0.LoadHtml("<html><head><meta name=\"referrer\" content=\"never\">\n <script type='text/javascript' src='https://www.google.com/recaptcha/api.js'></script>\n </head>\n <body oncontextmenu=\"return false\">\n\n<div style=\"opacity: 0.9\" class=\"g-recaptcha\" data-sitekey=\"" + this.string_5 + "\"></div>\n\n <br>\n\n<br>\n<br>\n<div id=\"hack\"></div>\n\n</body>\n</html>", "http://adidas.com");
        this.chromiumWebBrowser_0.Dock = DockStyle.Fill;
        this.panel1.Controls.Add(this.chromiumWebBrowser_0);
    }

    public void method_50(GClass0 gclass0_0)
    {
        bool flag = false;
        CookieContainer container2 = new CookieContainer();
        if (this.arrayList_4.Count == 0)
        {
            MessageBox.Show("Please setup an adidas account first!");
        }
        else
        {
            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ": Trying to log in to adidas account.\n");
            Class46 class2 = (Class46) this.arrayList_4[this.arrayList_4.Count - 1];
            this.arrayList_4.Remove(class2);
            base.Invoke(new MethodInvoker(this.method_83));
            HttpWebRequest request4 = (HttpWebRequest) WebRequest.Create(this.dictionary_12[this.int_2]);
            Class21.smethod_0(ref request4, false);
            request4.Method = "GET";
            request4.Timeout = this.int_0;
            CookieContainer cookieCont = gclass0_0.cookieCont;
            request4.CookieContainer = cookieCont;
            if (!gclass0_0.proxy.Equals(string.Empty))
            {
                request4.Proxy = new WebProxy(gclass0_0.proxy);
                if (!gclass0_0.proxyUsername.Equals(string.Empty))
                {
                    request4.Proxy.Credentials = new NetworkCredential(gclass0_0.proxyUsername, gclass0_0.proxyPW);
                }
            }
            try
            {
                HttpWebResponse response3 = (HttpWebResponse) request4.GetResponse();
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.Load(response3.GetResponseStream());
                string attributeValue = document.DocumentNode.SelectNodes(this.string_1)[int.Parse(this.string_0.Substring(0x1f, 1))].GetAttributeValue("value", string.Empty);
                string str5 = document.DocumentNode.SelectNodes("//input[@name='IdpAdapterId']")[0].GetAttributeValue("value", string.Empty);
                string str6 = document.DocumentNode.SelectNodes("//input[@name='SpSessionAuthnAdapterId']")[0].GetAttributeValue("value", string.Empty);
                string str7 = document.DocumentNode.SelectNodes("//input[@name='PartnerSpId']")[0].GetAttributeValue("value", string.Empty);
                string str8 = document.DocumentNode.SelectNodes("//input[@name='validator_id']")[0].GetAttributeValue("value", string.Empty);
                string str9 = Uri.EscapeDataString(document.DocumentNode.SelectNodes("//input[@name='TargetResource']")[0].GetAttributeValue("value", string.Empty));
                string str10 = document.DocumentNode.SelectNodes("//input[@name='InErrorResource']")[0].GetAttributeValue("value", string.Empty);
                string str11 = document.DocumentNode.SelectNodes("//input[@name='loginUrl']")[0].GetAttributeValue("value", string.Empty);
                string str12 = document.DocumentNode.SelectNodes("//input[@name='cd']")[0].GetAttributeValue("value", string.Empty);
                string str13 = document.DocumentNode.SelectNodes("//input[@name='app']")[0].GetAttributeValue("value", string.Empty);
                string str14 = document.DocumentNode.SelectNodes("//input[@name='locale']")[0].GetAttributeValue("value", string.Empty);
                string str15 = document.DocumentNode.SelectNodes("//input[@name='domain']")[0].GetAttributeValue("value", string.Empty);
                string str16 = document.DocumentNode.SelectNodes("//input[@name='email']")[0].GetAttributeValue("value", string.Empty);
                string str17 = document.DocumentNode.SelectNodes("//input[@name='pfRedirectBaseURL_test']")[0].GetAttributeValue("value", string.Empty);
                string str18 = document.DocumentNode.SelectNodes("//input[@name='pfStartSSOURL_test']")[0].GetAttributeValue("value", string.Empty);
                string str19 = document.DocumentNode.SelectNodes("//input[@name='resumeURL_test']")[0].GetAttributeValue("value", string.Empty);
                string str20 = document.DocumentNode.SelectNodes("//input[@name='FromFinishRegistraion']")[0].GetAttributeValue("value", string.Empty);
                string str21 = document.DocumentNode.SelectNodes("//input[@name='CSRFToken']")[0].GetAttributeValue("value", string.Empty);
                string s = ((((((((((((((((((("username=" + Uri.EscapeDataString(class2.string_0.Trim())) + "&password=" + Uri.EscapeDataString(class2.string_1.Trim())) + "&signinSubmit=" + attributeValue) + "&IdpAdapterId=" + str5) + "&SpSessionAuthnAdapterId=" + str6) + "&PartnerSpId=" + str7) + "&validator_id=" + str8) + "&TargetResource=" + str9) + "&InErrorResource=" + str10) + "&loginUrl=" + str11) + "&cd=" + str12) + "&app=" + str13) + "&locale=" + str14) + "&domain=" + str15) + "&email=" + str16) + "&pfRedirectBaseURL_test=" + str17) + "&pfStartSSOURL_test=" + str18) + "&resumeURL_test=" + str19) + "&FromFinishRegistraion=" + str20) + "&CSRFToken=" + str21;
                foreach (System.Net.Cookie cookie3 in response3.Cookies)
                {
                    cookieCont.Add(cookie3);
                }
                if (response3 != null)
                {
                    response3.Close();
                }
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.dictionary_13[this.int_2]);
                Class21.smethod_0(ref request, false);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                request.Timeout = this.int_0;
                request.CookieContainer = cookieCont;
                if (!gclass0_0.proxy.Equals(string.Empty))
                {
                    request.Proxy = new WebProxy(gclass0_0.proxy);
                    if (!gclass0_0.proxyUsername.Equals(string.Empty))
                    {
                        request.Proxy.Credentials = new NetworkCredential(gclass0_0.proxyUsername, gclass0_0.proxyPW);
                    }
                }
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                request.ContentLength = bytes.Length;
                HttpWebResponse response = null;
                try
                {
                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Close();
                    }
                    response = (HttpWebResponse) request.GetResponse();
                    string text1 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    int index = text1.IndexOf("resURL = '");
                    if (index == -1)
                    {
                        flag = true;
                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Invalid adidas account data. \n");
                        throw new WebException();
                    }
                    index += 10;
                    int num3 = text1.IndexOf("'", index);
                    string requestUriString = text1.Substring(index, num3 - index);
                    foreach (System.Net.Cookie cookie4 in response.Cookies)
                    {
                        cookieCont.Add(cookie4);
                    }
                    if (response != null)
                    {
                        response.Close();
                    }
                    HttpWebRequest request5 = (HttpWebRequest) WebRequest.Create(requestUriString);
                    Class21.smethod_0(ref request5, false);
                    request5.Method = "GET";
                    request5.Timeout = this.int_0;
                    request5.CookieContainer = cookieCont;
                    if (!gclass0_0.proxy.Equals(string.Empty))
                    {
                        request5.Proxy = new WebProxy(gclass0_0.proxy);
                        if (!gclass0_0.proxyUsername.Equals(string.Empty))
                        {
                            request5.Proxy.Credentials = new NetworkCredential(gclass0_0.proxyUsername, gclass0_0.proxyPW);
                        }
                    }
                    try
                    {
                        HttpWebResponse response4 = (HttpWebResponse) request5.GetResponse();
                        document.Load(response4.GetResponseStream());
                        string str23 = document.DocumentNode.SelectNodes("//form")[0].GetAttributeValue("action", string.Empty);
                        string stringToEscape = document.DocumentNode.SelectNodes("//input[@name='SAMLResponse']")[0].GetAttributeValue("value", string.Empty);
                        string str25 = document.DocumentNode.SelectNodes("//input[@name='RelayState']")[0].GetAttributeValue("value", string.Empty);
                        string str2 = ("SAMLResponse=" + Uri.EscapeDataString(stringToEscape)) + "&RelayState=" + Uri.EscapeDataString(str25);
                        foreach (System.Net.Cookie cookie5 in response4.Cookies)
                        {
                            cookieCont.Add(cookie5);
                        }
                        if (response4 != null)
                        {
                            response4.Close();
                        }
                        HttpWebRequest request2 = (HttpWebRequest) WebRequest.Create(this.dictionary_14[this.int_2] + str23);
                        Class21.smethod_0(ref request2, false);
                        request2.Method = "POST";
                        request2.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                        request2.Timeout = this.int_0;
                        request2.CookieContainer = cookieCont;
                        if (!gclass0_0.proxy.Equals(string.Empty))
                        {
                            request2.Proxy = new WebProxy(gclass0_0.proxy);
                            if (!gclass0_0.proxyUsername.Equals(string.Empty))
                            {
                                request2.Proxy.Credentials = new NetworkCredential(gclass0_0.proxyUsername, gclass0_0.proxyPW);
                            }
                        }
                        byte[] buffer = Encoding.ASCII.GetBytes(str2);
                        request2.ContentLength = buffer.Length;
                        HttpWebResponse response2 = null;
                        try
                        {
                            using (Stream stream2 = request2.GetRequestStream())
                            {
                                stream2.Write(buffer, 0, buffer.Length);
                                stream2.Close();
                            }
                            response2 = (HttpWebResponse) request2.GetResponse();
                            document.Load(response2.GetResponseStream());
                            string str26 = document.DocumentNode.SelectNodes("//form")[0].GetAttributeValue("action", string.Empty);
                            string str27 = document.DocumentNode.SelectNodes("//input[@name='TargetResource']")[0].GetAttributeValue("value", string.Empty);
                            string str28 = document.DocumentNode.SelectNodes("//input[@name='REF']")[0].GetAttributeValue("value", string.Empty);
                            foreach (System.Net.Cookie cookie6 in response2.Cookies)
                            {
                                cookieCont.Add(cookie6);
                            }
                            if (response2 != null)
                            {
                                response2.Close();
                            }
                            HttpWebRequest request3 = (HttpWebRequest) WebRequest.Create(str26);
                            Class21.smethod_0(ref request3, false);
                            request3.Method = "POST";
                            request3.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                            request3.Timeout = this.int_0;
                            request3.CookieContainer = cookieCont;
                            if (!gclass0_0.proxy.Equals(string.Empty))
                            {
                                request3.Proxy = new WebProxy(gclass0_0.proxy);
                                if (!gclass0_0.proxyUsername.Equals(string.Empty))
                                {
                                    request3.Proxy.Credentials = new NetworkCredential(gclass0_0.proxyUsername, gclass0_0.proxyPW);
                                }
                            }
                            string str3 = ("TargetResource=" + Uri.EscapeDataString(str27)) + "&REF=" + Uri.EscapeDataString(str28);
                            byte[] buffer3 = Encoding.ASCII.GetBytes(str3);
                            request3.ContentLength = buffer3.Length;
                            HttpWebResponse response5 = null;
                            try
                            {
                                using (Stream stream3 = request3.GetRequestStream())
                                {
                                    stream3.Write(buffer3, 0, buffer3.Length);
                                    stream3.Close();
                                }
                                response5 = (HttpWebResponse) request3.GetResponse();
                                foreach (System.Net.Cookie cookie7 in response5.Cookies)
                                {
                                    cookieCont.Add(cookie7);
                                }
                                if (response5 != null)
                                {
                                    response5.Close();
                                }
                                HttpWebRequest request6 = (HttpWebRequest) WebRequest.Create(this.dictionary_15[this.int_2]);
                                Class21.smethod_0(ref request6, false);
                                request6.Method = "GET";
                                request6.Timeout = this.int_0;
                                request6.CookieContainer = cookieCont;
                                if (!gclass0_0.proxy.Equals(string.Empty))
                                {
                                    request6.Proxy = new WebProxy(gclass0_0.proxy);
                                    if (!gclass0_0.proxyUsername.Equals(string.Empty))
                                    {
                                        request6.Proxy.Credentials = new NetworkCredential(gclass0_0.proxyUsername, gclass0_0.proxyPW);
                                    }
                                }
                                try
                                {
                                    HttpWebResponse response6 = (HttpWebResponse) request6.GetResponse();
                                    document.Load(response6.GetResponseStream());
                                    if (document.DocumentNode.SelectNodes("//div[contains(@class,'accountwelcome')]")[int.Parse(this.string_0.Substring(0x1f, 1))] == null)
                                    {
                                        flag = true;
                                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Invalid adidas account data. \n");
                                    }
                                    container2 = cookieCont;
                                    foreach (System.Net.Cookie cookie8 in response6.Cookies)
                                    {
                                        container2.Add(cookie8);
                                    }
                                    if (response6 != null)
                                    {
                                        response6.Close();
                                    }
                                }
                                catch (WebException)
                                {
                                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                                    flag = true;
                                }
                            }
                            catch (WebException)
                            {
                                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Error while trying to log into adidas account.\n");
                                flag = true;
                            }
                        }
                        catch (WebException)
                        {
                            this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                            flag = true;
                        }
                    }
                    catch (WebException)
                    {
                        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                        flag = true;
                    }
                }
                catch (WebException)
                {
                    this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                    flag = true;
                }
            }
            catch (WebException)
            {
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Error while trying to log into adidas account. \n");
                flag = true;
            }
            if (!flag)
            {
                ArrayList list = new ArrayList();
                foreach (System.Net.Cookie cookie2 in container2.smethod_7())
                {
                    CefSharp.Cookie cookie = new CefSharp.Cookie {
                        Name = cookie2.Name,
                        Value = cookie2.Value,
                        Domain = cookie2.Domain,
                        Path = cookie2.Path,
                        Secure = cookie2.Secure,
                        Expires = new DateTime?(cookie2.Expires)
                    };
                    list.Add(cookie);
                }
                gclass0_0.adiName = class2.string_0;
                gclass0_0.adiPw = class2.string_1;
                gclass0_0.button4 = "Copy account data";
                gclass0_0.timeOfCompletion = DateTime.Now;
                gclass0_0.cookieList = list;
                if (gclass0_0.proxy.Equals(string.Empty))
                {
                    gclass0_0.useProxyCheckout = false;
                }
                this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + gclass0_0.id.ToString() + ":  Successfully logged in to adidas account.\n");
            }
        }
    }

    public string method_51()
    {
        this.manualResetEvent_0.Reset();
        try
        {
            this.manualResetEvent_0.Set();
            return this.queue_0.Dequeue().string_0;
        }
        catch (Exception)
        {
            this.manualResetEvent_0.Set();
            return "error";
        }
    }

    private void method_52()
    {
        this.manualResetEvent_0.WaitOne();
        TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
        this.expiringLabel.Text = (110L - ((((long) span.TotalMilliseconds) - this.queue_0.Peek().long_0) / 0x3e8L)).ToString();
        this.tokenCountLabel.Text = this.queue_0.Count.ToString();
    }

    private void method_53()
    {
        this.expiringLabel.Text = "0";
        this.tokenCountLabel.Text = "0";
    }

    private void method_54()
    {
        MessageBox.Show(this, "yCopp detected a local proxy activated on your machine. This can lead to misbehaviour of the bot. Please open your internet options and deactivate your proxy and close any monitoring programs like Fiddler.");
        base.Close();
    }

    private void method_55()
    {
        this.button1.PerformClick();
        Thread.Sleep(50);
        this.button1.PerformClick();
    }

    private void method_56()
    {
        foreach (GClass0 class2 in this.arrayList_0)
        {
            if (class2.needsCaptcha)
            {
                class2.captchaDuplicate = this.string_3;
                class2.additionalParams = this.string_4;
            }
        }
        this.taskOListView.SetObjects(this.arrayList_0);
    }

    private void method_57()
    {
        this.panel1.Controls.Remove(this.chromiumWebBrowser_0);
    }

    private void method_58()
    {
        this.panel1.Controls.Add(this.chromiumWebBrowser_0);
    }

    private void method_59(object sender, CellClickEventArgs e)
    {
        GClass0 model = (GClass0) e.Model;
        if (e.ColumnIndex == 6)
        {
            if (model.autoCheckoutState < 1)
            {
                if (model.checkoutProfile != null)
                {
                    this.method_16(model);
                }
                else
                {
                    MessageBox.Show(this, "Please select a checkout profile first.");
                }
            }
            else if (model.autoCheckoutState == 2)
            {
                if ((model.autoCheckoutBrowserForm != null) && !model.autoCheckoutBrowserForm.IsDisposed)
                {
                    model.autoCheckoutBrowserForm.Visible = true;
                    return;
                }
                MessageBox.Show("This order confirmation is not available anymore. Please check your email inbox to retrieve the order confirmation.");
                return;
            }
        }
        if (e.ColumnIndex == 10)
        {
            if (((GClass0) e.Model).button4.Contains("Copy"))
            {
                Clipboard.SetDataObject(model.adiName + ":" + model.adiPw);
            }
            else if (((GClass0) e.Model).isCheckout)
            {
                MessageBox.Show("Cant log in to an account with this cart anymore. Dont open checkout before logging in!");
            }
            else
            {
                this.method_50((GClass0) e.Model);
            }
        }
        else
        {
            if (e.ColumnIndex == 7)
            {
                model.checkoutType = 1;
            }
            else if (e.ColumnIndex == 8)
            {
                model.checkoutType = 2;
            }
            else if (e.ColumnIndex == 9)
            {
                model.checkoutType = 3;
            }
            if (((e.ColumnIndex == 7) || (e.ColumnIndex == 8)) || (e.ColumnIndex == 9))
            {
                model.isCheckout = true;
                this.method_17((GClass0) e.Model);
            }
        }
    }

    public void method_6()
    {
        if (!Cef.IsInitialized)
        {
            Cef.Initialize(new CefSettings());
        }
        MethodInvoker method = new MethodInvoker(this.method_57);
        base.Invoke(method);
        this.chromiumWebBrowser_0 = new ChromiumWebBrowser("http://google.com");
        this.chromiumWebBrowser_0.LoadHtml("<html><head><meta name=\"referrer\" content=\"never\">\n <script type='text/javascript' src='https://www.google.com/recaptcha/api.js'></script>\n </head>\n <body oncontextmenu=\"return false\">\n\n<div style=\"opacity: 0.9\" class=\"g-recaptcha\" data-sitekey=\"" + this.string_5 + "\"></div>\n\n <br>\n\n<br>\n<br>\n<div id=\"hack\"></div>\n\n</body>\n</html>", "http://adidas.com");
        this.chromiumWebBrowser_0.Dock = DockStyle.Fill;
        MethodInvoker invoker2 = new MethodInvoker(this.method_58);
        base.Invoke(invoker2);
    }

    private void method_60()
    {
        MessageBox.Show(this, "yCopp detected a local proxy activated on your machine. This can lead to misbehaviour of the bot. Please open your internet options and deactivate your proxy and close any monitoring programs like Fiddler.");
        base.Close();
    }

    private void method_61()
    {
        this.copyButton.Enabled = false;
    }

    private void method_62()
    {
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Captcha token missing for the next task! Please harvest tokens!\n");
    }

    private void method_63()
    {
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Fatal error while trying to retrieve captcha token! Current task aborted!\n");
    }

    private void method_64()
    {
        this.copyButton.Enabled = true;
    }

    private void method_65()
    {
        MessageBox.Show(this, "yCopp detected a local proxy activated on your machine. This can lead to misbehaviour of the bot. Please open your internet options and deactivate your proxy and close any monitoring programs like Fiddler.");
        base.Close();
    }

    private void method_66()
    {
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Captcha token missing for looping task! Please harvest tokens!\n");
    }

    private void method_67()
    {
        this.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Fatal error while trying to retrieve captcha token! Current task aborted!\n");
    }

    private void method_68()
    {
        this.adidasAccountLabel.Text = "Adidas accounts in list: " + this.arrayList_4.Count.ToString();
    }

    private void method_69()
    {
        this.timeLabel.Text = DateTime.Now.ToLongTimeString();
        this.completedTaskOListView.SetObjects(this.arrayList_3);
        this.taskOListView.SetObjects(this.arrayList_0);
    }

    private void method_7(object sender, EventArgs e)
    {
    }

    private void method_70()
    {
        this.completedTaskOListView.SetObjects(this.arrayList_3);
    }

    private void method_71()
    {
        this.completedTaskOListView.SetObjects(this.arrayList_3);
    }

    private void method_72()
    {
        this.completedTaskOListView.SetObjects(this.arrayList_3);
    }

    private void method_73()
    {
        MessageBox.Show(this, "There is a problem with your license! Please contact info@ycopp.com");
        base.Close();
    }

    private void method_74()
    {
        Thread.CurrentThread.IsBackground = true;
        string str = this.method_30();
        if (!str.Equals("Error") && !str.Equals("Timeout"))
        {
            try
            {
                this.manualResetEvent_0.Reset();
                TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                this.queue_0.Enqueue(new Class18(str, (long) span.TotalMilliseconds));
                this.manualResetEvent_0.Set();
            }
            catch (Exception)
            {
            }
        }
    }

    private void method_75()
    {
        Thread.CurrentThread.IsBackground = true;
        string str = this.method_32();
        if (!str.Equals("Error"))
        {
            try
            {
                this.manualResetEvent_0.Reset();
                TimeSpan span = (TimeSpan) (DateTime.Now - new DateTime(0x7b2, 1, 1));
                this.queue_0.Enqueue(new Class18(str, (long) span.TotalMilliseconds));
                this.manualResetEvent_0.Set();
            }
            catch (Exception)
            {
            }
        }
    }

    private void method_76()
    {
        MessageBox.Show("Error while requesting the adidas page. Please check your connection, proxy, vpn etc. and close any network monitoring tools. Then try again!");
        this.nmdPreloadButton.Text = "Error while requesting the adidas page, please press to retry.";
        this.nmdPreloadButton.BackColor = Color.Red;
        this.nmdPreloadButton.Enabled = true;
    }

    private void method_77()
    {
        this.nmdPreloadButton.Text = "Splash is live! If it is more than 10 minutes until release, please restart your bot and don't use this function again.";
        this.nmdPreloadButton.BackColor = Color.Green;
        this.nmdPreloadButton.Enabled = true;
        MessageBox.Show("Splash is live! If it is more than 10 minutes until release, please restart your bot and don't use this function again. Try to get manually through splash and copy your user-agent and gceeqs cookie value into the bot.");
    }

    private void method_78()
    {
        this.hmacExpireLabel.ForeColor = Color.Red;
        this.hmacExpireLabel.Text = "Expired!";
    }

    private void method_79(object sender, EventArgs e)
    {
        for (int i = 0; i < this.completedTaskOListView.SelectedObjects.Count; i++)
        {
            this.arrayList_3.Remove(this.completedTaskOListView.SelectedObjects[i]);
        }
        this.completedTaskOListView.SetObjects(this.arrayList_3);
    }

    public string method_8(string string_27)
    {
        string str = "ERROR";
        using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
        {
            byte[] bytes = Encoding.ASCII.GetBytes(string_27);
            try
            {
                provider.FromXmlString(this.string_10);
                str = Convert.ToBase64String(provider.SignData(bytes, new SHA256CryptoServiceProvider()));
            }
            catch (CryptographicException exception1)
            {
                Console.WriteLine(exception1.Message);
            }
            finally
            {
                provider.PersistKeyInCsp = false;
            }
        }
        return str;
    }

    private void method_80()
    {
        this.completedTaskOListView.SetObjects(this.arrayList_3);
    }

    private void method_81(object sender, EventArgs e)
    {
        Class44 class2 = new Class44 {
            mainForm_0 = this,
            arrayList_0 = new ArrayList(this.taskOListView.SelectedObjects)
        };
        if (class2.arrayList_0.Count != 0)
        {
            for (int i = class2.arrayList_0.Count - 1; i >= 0; i--)
            {
                GClass0 class3 = (GClass0) class2.arrayList_0[i];
                if (class3.isScheduled)
                {
                    class2.arrayList_0.Remove(class3);
                }
                else
                {
                    class3.isScheduled = true;
                }
            }
            Thread thread = new Thread(new ThreadStart(class2.method_0)) {
                IsBackground = true
            };
            this.arrayList_2.Add(thread);
            thread.Start();
        }
    }

    private void method_82(object sender, EventArgs e)
    {
        ArrayList list = new ArrayList(this.taskOListView.SelectedObjects);
        if (list.Count > 0)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                GClass0 class2 = (GClass0) list[i];
                if ((class2.isRunning && (class2.method_0() != null)) && class2.method_0().IsAlive)
                {
                    class2.method_0().Abort();
                    class2.isRunning = false;
                    class2.method_1(null);
                }
            }
        }
    }

    private void method_83()
    {
        this.adidasAccountLabel.Text = "Adidas accounts in list: " + this.arrayList_4.Count.ToString();
    }

    public void method_9(ArrayList arrayList_6)
    {
        Class30 class1 = new Class30 {
            mainForm_0 = this,
            arrayList_0 = arrayList_6
        };
        Thread thread = new Thread(new ThreadStart(class1.method_0)) {
            IsBackground = true
        };
        this.arrayList_2.Add(thread);
        thread.Start();
    }

    private void needsCaptcha_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void nmdPreloadButton_Click(object sender, EventArgs e)
    {
        this.nmdPreloadButton.Enabled = false;
        this.nmdPreloadButton.BackColor = Color.Yellow;
        this.nmdPreloadButton.Text = "HMAC preload in progress. This lasts until splash goes live.";
        new Thread(new ThreadStart(this.method_35)) { IsBackground = true }.Start();
    }

    private void proxyBox_TextChanged(object sender, EventArgs e)
    {
    }

    private void removeAllButton_Click(object sender, EventArgs e)
    {
        this.arrayList_0.Clear();
        this.taskOListView.SetObjects(this.arrayList_0);
    }

    private void removeHmacBtn_Click(object sender, EventArgs e)
    {
        if ((this.thread_11 != null) && this.thread_11.IsAlive)
        {
            this.thread_11.Abort();
        }
        this.string_25 = string.Empty;
        this.hmacLabel.Visible = false;
        this.hmacExpireLabel.Visible = false;
        this.removeHmacBtn.Visible = false;
    }

    private void removeSelectedButton_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < this.taskOListView.SelectedObjects.Count; i++)
        {
            this.arrayList_0.Remove(this.taskOListView.SelectedObjects[i]);
        }
        this.taskOListView.SetObjects(this.arrayList_0);
        for (int j = 0; j < this.completedTaskOListView.SelectedObjects.Count; j++)
        {
            this.arrayList_3.Remove(this.completedTaskOListView.SelectedObjects[j]);
        }
        this.completedTaskOListView.SetObjects(this.arrayList_3);
    }

    private void resetMachineBindingToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you really want to reset your license? This will remove the license from this machine.", "Reset Machine Binding", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            byte[] data = new byte[0x200];
            new RNGCryptoServiceProvider().GetBytes(data);
            string str3 = BitConverter.ToString(data);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/reset_lic.php");
            string s = ((("name=" + this.string_8) + "&serial=" + this.string_9) + "&salt=" + str3) + "&signature=" + this.method_8(this.string_8 + this.string_9 + str3);
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
            catch (Exception)
            {
                MessageBox.Show("There was an error resetting your license. Please try again later!");
                if (response != null)
                {
                    response.Close();
                }
                return;
            }
            string str2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            if ((str2.Equals("InvalidRequest") || str2.Equals("InvalidLicense")) || str2.Equals("InvalidSignature"))
            {
                MessageBox.Show("Your license is invalid! Please contact support@ycopp.com");
            }
            else if (str2.Equals("ErrorResetting"))
            {
                MessageBox.Show("There was an error resetting your license. Please contact support@ycopp.com and provide this error key: \"ERRES2\"!");
            }
            else if (str2.Equals("LicenseNotActivated"))
            {
                MessageBox.Show("There was an error resetting your license. Please contact support@ycopp.com and provide this error key: \"ERRES3\"!");
            }
            else if (str2.Equals("SuccessfullyReset"))
            {
                MessageBox.Show("Your license has been successfully reset! You can use it on another machine now.");
                try
                {
                    System.IO.File.Delete("data.yclicense");
                }
                catch (Exception)
                {
                }
                if (this.thread_4 != null)
                {
                    this.thread_4.Abort();
                }
                if (this.thread_2 != null)
                {
                    this.thread_2.Abort();
                }
                if (this.thread_3 != null)
                {
                    this.thread_3.Abort();
                }
                base.Close();
            }
        }
    }

    private void saveDefaultButton_Click(object sender, EventArgs e)
    {
        XmlDocument document = new XmlDocument();
        bool flag = true;
        try
        {
            document.Load("data.yclicense");
        }
        catch (FileNotFoundException)
        {
            flag = false;
        }
        if (flag)
        {
            System.IO.File.Delete("data.yclicense");
        }
        XmlDocument document1 = new XmlDocument();
        XmlElement newChild = document1.CreateElement(string.Empty, "data", string.Empty);
        document1.AppendChild(newChild);
        XmlElement element2 = document1.CreateElement(string.Empty, "name", string.Empty);
        XmlText text = document1.CreateTextNode(this.string_8);
        element2.AppendChild(text);
        XmlElement element3 = document1.CreateElement(string.Empty, "serial", string.Empty);
        XmlText text2 = document1.CreateTextNode(this.string_9);
        element3.AppendChild(text2);
        XmlElement element4 = document1.CreateElement(string.Empty, "location", string.Empty);
        XmlText text3 = document1.CreateTextNode(this.locationComboBox.SelectedIndex.ToString());
        element4.AppendChild(text3);
        newChild.AppendChild(element2);
        newChild.AppendChild(element3);
        newChild.AppendChild(element4);
        document1.Save("data.yclicense");
        MessageBox.Show("Success!");
    }

    private void setCustomPreloadLinkToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PreloadLink link = new PreloadLink(this.string_17) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (link.ShowDialog(this) == DialogResult.OK)
        {
            this.string_17 = link.string_0;
        }
    }

    private void setCustomUserAgentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        UserAgent agent = new UserAgent(this.string_18) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (agent.ShowDialog(this) == DialogResult.OK)
        {
            this.string_18 = agent.string_0;
            Class21.string_1 = agent.string_0;
        }
    }

    private void setTaskDelayToolStripMenuItem_Click(object sender, EventArgs e)
    {
        TaskDelayForm form = new TaskDelayForm(this.int_1) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            if (form.int_0 == 0)
            {
                this.taskDelayLabel.Visible = false;
            }
            else
            {
                this.int_1 = form.int_0;
                this.taskDelayLabel.Text = "Task Delay: " + this.int_1.ToString() + " sec.";
                this.taskDelayLabel.Visible = true;
            }
        }
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void setup2CaptchaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Setup2CaptchaForm form = new Setup2CaptchaForm(this.string_12, this.int_4, this.int_5) {
            StartPosition = FormStartPosition.CenterParent
        };
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            this.string_12 = form.string_0;
            this.int_4 = form.int_1;
            this.int_5 = form.int_2;
        }
        form.Dispose();
    }

    private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void soundBox_CheckedChanged(object sender, EventArgs e)
    {
        this.bool_14 = this.soundBox.Checked;
    }

    private void splashBruteForcerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new SplashForceForm(this, this.string_23, this.string_24, this.string_26) { Text = "Splash Page Brute Forcer (Browser)" }.Show();
    }

    private void splashPageBruteForcerRequestsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new SplashForceForm(this, this.string_23, this.string_24, this.string_26, true) { Text = "Splash Page Brute Forcer (Requests)" }.Show();
    }

    private void splashRadio_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void startAllButton_Click(object sender, EventArgs e)
    {
        Class29 class2 = new Class29 {
            mainForm_0 = this,
            arrayList_0 = new ArrayList()
        };
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            if (!((GClass0) this.arrayList_0[i]).automaticStart)
            {
                class2.arrayList_0.Add((GClass0) this.arrayList_0[i]);
            }
        }
        for (int j = class2.arrayList_0.Count - 1; j >= 0; j--)
        {
            GClass0 class3 = (GClass0) class2.arrayList_0[j];
            if (class3.isScheduled)
            {
                class2.arrayList_0.Remove(class3);
            }
            else
            {
                class3.isScheduled = true;
            }
        }
        Thread thread = new Thread(new ThreadStart(class2.method_0)) {
            IsBackground = true
        };
        this.arrayList_2.Add(thread);
        thread.Start();
    }

    private void startSelectedButton_Click(object sender, EventArgs e) { Class27
    class2 = new Class27 { mainForm_0 = this, arrayList_0 = new
    ArrayList(this.taskOListView.SelectedObjects) }; for (int i =
    class2.arrayList_0.Count - 1; i >= 0; i--) { GClass0 class3 = (GClass0)
    class2.arrayList_0[i]; if (class3.isScheduled) {
    class2.arrayList_0.Remove(class3); } else { class3.isScheduled = true; } }
    if (class2.arrayList_0.Count > 0) { Thread thread = new Thread(new
    ThreadStart(class2.method_0)) { IsBackground = true };
    this.arrayList_2.Add(thread); thread.Start(); } }

    private void swapSizeButton_Click(object sender, EventArgs e) {
    this.sizeComboBox.Items.Clear(); if (this.bool_4) {
    this.sizeComboBox.Items.Add("US 4"); this.sizeComboBox.Items.Add("US 4.5");
    this.sizeComboBox.Items.Add("US 5"); this.sizeComboBox.Items.Add("US 5.5");
    this.sizeComboBox.Items.Add("US 6"); this.sizeComboBox.Items.Add("US 6.5");
    this.sizeComboBox.Items.Add("US 7"); this.sizeComboBox.Items.Add("US 7.5");
    this.sizeComboBox.Items.Add("US 8"); this.sizeComboBox.Items.Add("US 8.5");
    this.sizeComboBox.Items.Add("US 9"); this.sizeComboBox.Items.Add("US 9.5");
    this.sizeComboBox.Items.Add("US 10"); this.sizeComboBox.Items.Add("US
    10.5"); this.sizeComboBox.Items.Add("US 11");
    this.sizeComboBox.Items.Add("US 11.5"); this.sizeComboBox.Items.Add("US
    12"); this.sizeComboBox.Items.Add("US 12.5");
    this.sizeComboBox.Items.Add("US 13"); this.sizeComboBox.Items.Add("US
    13.5"); this.sizeComboBox.Items.Add("US 14");
    this.sizeComboBox.Items.Add("US 15.5"); this.sizeComboBox.Items.Add("XS");
    this.sizeComboBox.Items.Add("S"); this.sizeComboBox.Items.Add("M");
    this.sizeComboBox.Items.Add("L"); this.sizeComboBox.Items.Add("XL");
    this.sizeComboBox.Items.Add("2XL"); this.sizeComboBox.Items.Add("Kids 2");
    this.sizeComboBox.Items.Add("Kids 3"); this.sizeComboBox.Items.Add("Kids
    4"); this.sizeComboBox.Items.Add("Kids 5");
    this.sizeComboBox.Items.Add("Kids 5.5"); this.sizeComboBox.Items.Add("Kids
    6"); this.sizeComboBox.Items.Add("Kids 6.5");
    this.sizeComboBox.Items.Add("Kids 7"); this.sizeComboBox.Items.Add("Kids
    7.5"); this.sizeComboBox.Items.Add("Kids 8");
    this.sizeComboBox.Items.Add("Kids 8.5"); this.sizeComboBox.Items.Add("Kids
    9"); this.sizeComboBox.Items.Add("Kids 9.5");
    this.sizeComboBox.Items.Add("Kids 10"); this.bool_4 = false;
    this.swapSizeButton.Text = "EU sizes"; } else {
    this.sizeComboBox.Items.Add("EU 36"); this.sizeComboBox.Items.Add("EU 36
    2/3"); this.sizeComboBox.Items.Add("EU 37 1/3");
    this.sizeComboBox.Items.Add("EU 38"); this.sizeComboBox.Items.Add("EU 38
    2/3"); this.sizeComboBox.Items.Add("EU 39 1/3");
    this.sizeComboBox.Items.Add("EU 40"); this.sizeComboBox.Items.Add("EU 40
    2/3"); this.sizeComboBox.Items.Add("EU 41 1/3");
    this.sizeComboBox.Items.Add("EU 42"); this.sizeComboBox.Items.Add("EU 42
    2/3"); this.sizeComboBox.Items.Add("EU 43 1/3");
    this.sizeComboBox.Items.Add("EU 44"); this.sizeComboBox.Items.Add("EU 44
    2/3"); this.sizeComboBox.Items.Add("EU 45 1/3");
    this.sizeComboBox.Items.Add("EU 46"); this.sizeComboBox.Items.Add("EU 46
    2/3"); this.sizeComboBox.Items.Add("EU 47 1/3");
    this.sizeComboBox.Items.Add("EU 48"); this.sizeComboBox.Items.Add("EU 48
    2/3"); this.sizeComboBox.Items.Add("EU 49 1/3");
    this.sizeComboBox.Items.Add("EU 51 1/3"); this.sizeComboBox.Items.Add("XS");
    this.sizeComboBox.Items.Add("S"); this.sizeComboBox.Items.Add("M");
    this.sizeComboBox.Items.Add("L"); this.sizeComboBox.Items.Add("XL");
    this.sizeComboBox.Items.Add("2XL"); this.sizeComboBox.Items.Add("EU 17");
    this.sizeComboBox.Items.Add("EU 18"); this.sizeComboBox.Items.Add("EU 19");
    this.sizeComboBox.Items.Add("EU 20"); this.sizeComboBox.Items.Add("EU 21");
    this.sizeComboBox.Items.Add("EU 22"); this.sizeComboBox.Items.Add("EU 23");
    this.sizeComboBox.Items.Add("EU 23 1/2"); this.sizeComboBox.Items.Add("EU
    24"); this.sizeComboBox.Items.Add("EU 25"); this.sizeComboBox.Items.Add("EU
    25 1/2"); this.sizeComboBox.Items.Add("EU 26");
    this.sizeComboBox.Items.Add("EU 26 1/2"); this.sizeComboBox.Items.Add("EU
    27"); this.bool_4 = true; this.swapSizeButton.Text = "US sizes"; } }

    private void taskOListView_CellEditFinishing(object sender, CellEditEventArgs e)
    {
        if ((((e.Column.Index != 1) && (e.Column.Index != 2)) && ((e.Column.Index != 3) && (e.Column.Index != 4))) && ((e.Column.Index != 5) && (e.Column.Index != 7)))
        {
            e.Cancel = true;
        }
        else
        {
            if (e.Column.Index == 2)
            {
                ((GClass0) e.RowObject).size = ((ComboBox) e.Control).SelectedIndex;
                ((FastObjectListView) sender).RefreshItem(e.ListViewItem);
                e.Cancel = true;
            }
            if (e.Column.Index == 3)
            {
                if (!((bool) e.NewValue))
                {
                    ((GClass0) e.RowObject).captchaDuplicate = string.Empty;
                }
                if (((bool) e.NewValue) && (this.splashRadio.Checked || this.alternativeRadio.Checked))
                {
                    ((GClass0) e.RowObject).captchaDuplicate = this.string_3;
                }
                ((GClass0) e.RowObject).needsCaptcha = (bool) e.NewValue;
                e.Cancel = true;
            }
            if (e.Column.Index == 4)
            {
                ((GClass0) e.RowObject).checkoutProfile = (GClass4) ((ComboBox) e.Control).SelectedItem;
                ((FastObjectListView) sender).RefreshItem(e.ListViewItem);
                e.Cancel = true;
            }
        }
    }

    private void taskOListView_CellEditStarting(object sender, CellEditEventArgs e)
    {
        if (e.Column.DisplayIndex == 4)
        {
            ComboBox box = new ComboBox();
            ArrayList list = (ArrayList) this.arrayList_5.Clone();
            box.DisplayMember = "profileName";
            box.DataSource = list;
            box.SelectedItem = ((GClass0) e.RowObject).checkoutProfile;
            e.Control = box;
            e.Control.Location = e.CellBounds.Location;
        }
        if (e.Column.DisplayIndex == 2)
        {
            ComboBox box2 = new ComboBox();
            if (this.bool_4)
            {
                box2.Items.Add("EU 36");
                box2.Items.Add("EU 36 2/3");
                box2.Items.Add("EU 37 1/3");
                box2.Items.Add("EU 38");
                box2.Items.Add("EU 38 2/3");
                box2.Items.Add("EU 39 1/3");
                box2.Items.Add("EU 40");
                box2.Items.Add("EU 40 2/3");
                box2.Items.Add("EU 41 1/3");
                box2.Items.Add("EU 42");
                box2.Items.Add("EU 42 2/3");
                box2.Items.Add("EU 43 1/3");
                box2.Items.Add("EU 44");
                box2.Items.Add("EU 44 2/3");
                box2.Items.Add("EU 45 1/3");
                box2.Items.Add("EU 46");
                box2.Items.Add("EU 46 2/3");
                box2.Items.Add("EU 47 1/3");
                box2.Items.Add("EU 48");
                box2.Items.Add("EU 48 2/3");
                box2.Items.Add("EU 49 1/3");
                box2.Items.Add("EU 51 1/3");
                box2.Items.Add("XS");
                box2.Items.Add("S");
                box2.Items.Add("M");
                box2.Items.Add("L");
                box2.Items.Add("XL");
                box2.Items.Add("2XL");
                box2.Items.Add("EU 17");
                box2.Items.Add("EU 18");
                box2.Items.Add("EU 19");
                box2.Items.Add("EU 20");
                box2.Items.Add("EU 21");
                box2.Items.Add("EU 22");
                box2.Items.Add("EU 23");
                box2.Items.Add("EU 23 1/2");
                box2.Items.Add("EU 24");
                box2.Items.Add("EU 25");
                box2.Items.Add("EU 25 1/2");
                box2.Items.Add("EU 26");
                box2.Items.Add("EU 26 1/2");
                box2.Items.Add("EU 27");
            }
            else
            {
                box2.Items.Add("US 4");
                box2.Items.Add("US 4.5");
                box2.Items.Add("US 5");
                box2.Items.Add("US 5.5");
                box2.Items.Add("US 6");
                box2.Items.Add("US 6.5");
                box2.Items.Add("US 7");
                box2.Items.Add("US 7.5");
                box2.Items.Add("US 8");
                box2.Items.Add("US 8.5");
                box2.Items.Add("US 9");
                box2.Items.Add("US 9.5");
                box2.Items.Add("US 10");
                box2.Items.Add("US 10.5");
                box2.Items.Add("US 11");
                box2.Items.Add("US 11.5");
                box2.Items.Add("US 12");
                box2.Items.Add("US 12.5");
                box2.Items.Add("US 13");
                box2.Items.Add("US 13.5");
                box2.Items.Add("US 14");
                box2.Items.Add("US 15.5");
                box2.Items.Add("XS");
                box2.Items.Add("S");
                box2.Items.Add("M");
                box2.Items.Add("L");
                box2.Items.Add("XL");
                box2.Items.Add("2XL");
                box2.Items.Add("Kids 2");
                box2.Items.Add("Kids 3");
                box2.Items.Add("Kids 4");
                box2.Items.Add("Kids 5");
                box2.Items.Add("Kids 5.5");
                box2.Items.Add("Kids 6");
                box2.Items.Add("Kids 6.5");
                box2.Items.Add("Kids 7");
                box2.Items.Add("Kids 7.5");
                box2.Items.Add("Kids 8");
                box2.Items.Add("Kids 8.5");
                box2.Items.Add("Kids 9");
                box2.Items.Add("Kids 9.5");
                box2.Items.Add("Kids 10");
            }
            box2.SelectedIndex = ((GClass0) e.RowObject).size;
            e.Control = box2;
            e.Control.Location = e.CellBounds.Location;
        }
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
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(new UriBuilder(this.dictionary_6[this.int_2]).Uri);
            Class21.smethod_0(ref request, true);
            request.Method = "GET";
            request.Timeout = 0x1388;
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

    private void timePicker_ValueChanged(object sender, EventArgs e)
    {
    }

    private void twoCaptchaButton_Click(object sender, EventArgs e)
    {
        if ((this.thread_8 != null) && this.thread_8.IsAlive)
        {
            if (this.thread_8.IsAlive)
            {
                this.thread_8.Abort();
                this.twoCaptchaButton.Text = "Start 2Captcha Solving";
                this.bool_6 = false;
            }
        }
        else if (this.string_12.Equals(string.Empty))
        {
            MessageBox.Show("Please setup your 2Captcha API-Key before using this feature.");
        }
        else
        {
            this.thread_8 = new Thread(new ThreadStart(this.method_29));
            this.thread_8.Start();
            this.twoCaptchaButton.Text = "Stop 2Captcha Solving";
            this.bool_6 = true;
        }
    }

    private void updateAllButton_Click(object sender, EventArgs e)
    {
        if (!this.bool_11)
        {
            if ((this.splashRadio.Checked || this.alternativeRadio.Checked) || (MessageBox.Show("Alternative Mode is disabled. Normally you don't need a Captcha Duplicate. Do you really wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No))
            {
                this.bool_11 = true;
                this.updateAllButton.Text = "Disable Auto Update";
                this.updateAllButton.ForeColor = Color.Red;
                this.thread_7 = new Thread(new ThreadStart(this.method_4));
                this.thread_7.IsBackground = true;
                this.thread_7.Start();
            }
        }
        else
        {
            this.bool_11 = false;
            this.updateAllButton.Text = "Enable Auto Update";
            this.updateAllButton.ForeColor = Color.LimeGreen;
            if ((this.thread_7 != null) && this.thread_7.IsAlive)
            {
                this.thread_7.Abort();
            }
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        this.button1.Enabled = false;
        if (this.manualTextBox.Text != string.Empty)
        {
            if ((this.manualTextBox.Text.Length >= 0x23) && (this.manualTextBox.Text.Length <= 0x2d))
            {
                this.manualResetEvent_0.Reset();
                this.queue_0.Clear();
                this.manualResetEvent_0.Set();
                this.string_5 = this.manualTextBox.Text;
                MessageBox.Show("API-Key set to user-entered key.");
                this.bool_12 = true;
                this.button1.Enabled = true;
                if (this.bool_8)
                {
                    this.button1.PerformClick();
                    Thread.Sleep(50);
                    this.button1.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("This API-Key looks malformed. Please try another one.");
                this.button1.Enabled = true;
            }
        }
        else
        {
            string str = string.Empty;
            if (this.int_2 <= 5)
            {
                str = "eu";
            }
            else if (this.int_2 == 6)
            {
                str = "us";
            }
            else if (this.int_2 == 7)
            {
                str = "ca";
            }
            else if ((this.int_2 > 8) && (this.int_2 < 0x10))
            {
                str = "eu";
            }
            else if (this.int_2 == 0x11)
            {
                str = "eu";
            }
            else if (this.int_2 > 0x11)
            {
                str = "us";
            }
            else
            {
                str = "au";
            }
            byte[] data = new byte[0x200];
            new RNGCryptoServiceProvider().GetBytes(data);
            BitConverter.ToString(data);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/get_api.php");
            string s = ((("name=" + this.string_8) + "&serial=" + this.string_9) + "&hid=" + Class21.smethod_4()) + "&mode=" + str;
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            bool flag = false;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;
            request.Timeout = 0x1388;
            HttpWebResponse response = null;
            bool flag2 = false;
            try
            {
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (Exception)
            {
                flag2 = true;
            }
            if (flag2)
            {
                try
                {
                    HttpWebRequest request1 = (HttpWebRequest) WebRequest.Create("http://script.ycopp.com/scripts/get_api.php");
                    request1.Method = "POST";
                    request1.ContentType = "application/x-www-form-urlencoded";
                    request1.ContentLength = bytes.Length;
                    request1.Timeout = 0x1388;
                    using (Stream stream2 = request.GetRequestStream())
                    {
                        stream2.Write(bytes, 0, bytes.Length);
                    }
                    response = (HttpWebResponse) request.GetResponse();
                }
                catch (Exception)
                {
                    flag = true;
                    MessageBox.Show("Error retrieving API-Key. Standard key will be used. Please try again later.");
                    this.bool_12 = true;
                    return;
                }
            }
            if (!flag)
            {
                string str3 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                response.Close();
                if (str3.Equals("EVal"))
                {
                    Environment.Exit(0);
                }
                if (!str3.Equals("InvalidRequest") && !str3.Equals("InvalidToken"))
                {
                    if (response.Headers.Get("captchaDup") != null)
                    {
                        this.string_3 = response.Headers.Get("captchaDup");
                    }
                    if ((this.string_5 != str3) && !this.bool_1)
                    {
                        this.manualResetEvent_0.Reset();
                        this.queue_0.Clear();
                        this.manualResetEvent_0.Set();
                        MessageBox.Show("Successfully retrieved API-Key from server.");
                    }
                    else if (this.bool_12)
                    {
                        MessageBox.Show("There's no new API-Key.");
                        this.button1.Enabled = true;
                        return;
                    }
                    this.string_5 = str3;
                    this.bool_1 = false;
                }
                else
                {
                    MessageBox.Show("Error retrieving API-Key. Standard key will be used. Please contact info@ycopp.com");
                    this.string_5 = this.string_6;
                }
                this.bool_12 = true;
            }
            else
            {
                this.string_5 = this.string_6;
            }
            this.button1.Enabled = true;
            if (this.bool_8)
            {
                this.button1.PerformClick();
                Thread.Sleep(50);
                this.button1.PerformClick();
            }
        }
    }

    private void updateDuplicateManual_Click(object sender, EventArgs e)
    {
        if ((this.splashRadio.Checked || this.alternativeRadio.Checked) || (MessageBox.Show("Alternative Mode is disabled. Normally you don't need a Captcha Duplicate. Do you really wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No))
        {
            this.bool_11 = false;
            this.updateAllButton.Text = "Enable Auto Update";
            this.updateAllButton.ForeColor = Color.LimeGreen;
            if ((this.thread_7 != null) && this.thread_7.IsAlive)
            {
                this.thread_7.Abort();
            }
            foreach (GClass0 class2 in this.arrayList_0)
            {
                if (class2.needsCaptcha)
                {
                    class2.captchaDuplicate = this.captchaDuplicateBox.Text;
                }
            }
            this.taskOListView.SetObjects(this.arrayList_0);
        }
    }

    private void useDefaultMethod_Click(object sender, EventArgs e)
    {
    }

    protected override void WndProc(ref Message m)
    {
        int num = 0x210;
        int num2 = 0x201;
        if ((!this.Focused && (m.Msg == num)) && (m.WParam.ToInt32() == num2))
        {
            base.Activate();
        }
        base.WndProc(ref m);
    }

    [Serializable]
    private sealed class Class23
    {
        public static readonly MainForm.Class23 class23_0 = new MainForm.Class23();
        public static GroupKeyGetterDelegate groupKeyGetterDelegate_0;

        internal object method_0(object object_0)
        {
            if (((GClass0) object_0).automaticStart)
            {
                return "Automatic";
            }
            return "Manual";
        }
    }

    private sealed class Class24
    {
        public MainForm.Class42 class42_0;
        public string string_0;

        internal void method_0()
        {
            this.class42_0.class39_0.mainForm_0.method_13(this.string_0);
            if (this.class42_0.class39_0.gclass0_0.automaticStart)
            {
                this.class42_0.class39_0.mainForm_0.arrayList_0.Remove(this.class42_0.class39_0.gclass0_0);
                this.class42_0.class39_0.mainForm_0.taskOListView.RemoveObject(this.class42_0.class39_0.gclass0_0);
            }
        }
    }

    private sealed class Class25
    {
        public GClass0 gclass0_0;
        public MainForm mainForm_0;
        public string string_0;

        internal void method_0()
        {
            this.mainForm_0.method_11(this.gclass0_0, this.string_0);
        }
    }

    private sealed class Class26
    {
        public CellRightClickEventArgs cellRightClickEventArgs_0;
        public MainForm mainForm_0;

        internal void method_0(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList(this.mainForm_0.taskOListView.SelectedObjects);
            if (list.Count > 0)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    this.mainForm_0.arrayList_0.Remove(list[i]);
                }
            }
            else
            {
                this.mainForm_0.arrayList_0.Remove(this.cellRightClickEventArgs_0.Model);
            }
            this.mainForm_0.taskOListView.SetObjects(this.mainForm_0.arrayList_0);
        }
    }

    private sealed class Class27
    {
        public ArrayList arrayList_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_10(this.arrayList_0);
        }
    }

    private sealed class Class28
    {
        public MainForm mainForm_0;
        public string string_0;

        internal void method_0()
        {
            this.mainForm_0.statusBox.AppendText(this.string_0);
        }
    }

    private sealed class Class29
    {
        public ArrayList arrayList_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_10(this.arrayList_0);
        }
    }

    private sealed class Class30
    {
        public ArrayList arrayList_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_10(this.arrayList_0);
        }
    }

    private sealed class Class31
    {
        public MainForm.Class37 class37_0;
        public GClass0 gclass0_0;

        internal void method_0()
        {
            this.class37_0.mainForm_0.method_13(string.Concat(new object[] { DateTime.Now.ToString("hh:mm:ss"), ": Task ", this.gclass0_0.id, " starts in less than 100 seconds. Please harvest tokens now!\n" }));
        }
    }

    private sealed class Class32
    {
        public bool bool_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            if (this.bool_0)
            {
                Thread.Sleep(500);
            }
            byte[] data = new byte[0x200];
            new RNGCryptoServiceProvider().GetBytes(data);
            string str3 = BitConverter.ToString(data);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://ycopp.com/scripts/retrieve_news.php");
            string s = ((("name=" + this.mainForm_0.string_8) + "&serial=" + this.mainForm_0.string_9) + "&salt=" + str3) + "&signature=" + this.mainForm_0.method_8(this.mainForm_0.string_8 + str3);
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
            catch (Exception)
            {
                return;
            }
            string text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (text.Equals("InvalidLicense"))
            {
                Environment.Exit(0);
            }
            if ((!text.Equals("InvalidRequest") && !text.Equals("InvalidSignature")) && !text.Equals(string.Empty))
            {
                MessageBox.Show(text);
            }
        }
    }

    private sealed class Class33
    {
        public MainForm.Class36 class36_0;
        public string string_0;

        internal void method_0()
        {
            this.class36_0.mainForm_0.method_11(this.class36_0.gclass0_0, this.string_0);
        }
    }

    private sealed class Class34
    {
        public BrowserForm browserForm_0;
        public ChromiumWebBrowser chromiumWebBrowser_0;
        public GClass0 gclass0_0;
        public int int_0;
        public MainForm mainForm_0;
        public CefSharp.RequestContext requestContext_0;

        internal void method_0()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object> {
                ["mode"] = "fixed_servers",
                ["server"] = this.gclass0_0.proxy
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
            if (Class21.string_2.Length < this.gclass0_0.getSizeString().Length)
            {
                this.gclass0_0.pid = "???";
            }
            else
            {
                if (this.gclass0_0.useProxyCheckout && (this.gclass0_0.proxy != string.Empty))
                {
                    string[] textArray1 = new string[] { this.gclass0_0.id.ToString(), ": ", this.gclass0_0.pid, ", ", this.gclass0_0.getSizeString(), ", ", this.gclass0_0.proxy };
                    this.browserForm_0.Text = string.Concat(textArray1);
                }
                else
                {
                    string[] textArray2 = new string[] { this.gclass0_0.id.ToString(), ": ", this.gclass0_0.pid, ", ", this.gclass0_0.getSizeString() };
                    this.browserForm_0.Text = string.Concat(textArray2);
                }
                this.browserForm_0.Show();
                this.browserForm_0.method_0(this.chromiumWebBrowser_0);
                if (this.mainForm_0.devHideAutoCheckoutToolStripMenuItem.Checked)
                {
                    this.browserForm_0.Visible = false;
                }
            }
        }

        internal void method_2(object sender, FrameLoadEndEventArgs e)
        {
            Thread.Sleep(250);
            if (!this.browserForm_0.bool_0)
            {
                if (this.gclass0_0.checkoutProfile.paymentMethod == 0)
                {
                    this.chromiumWebBrowser_0.Load(this.mainForm_0.dictionary_3[this.int_0]);
                }
                if (this.gclass0_0.checkoutProfile.paymentMethod == 1)
                {
                    this.chromiumWebBrowser_0.Load(this.mainForm_0.dictionary_2[this.int_0]);
                }
            }
            this.browserForm_0.bool_0 = true;
        }
    }

    private sealed class Class35
    {
        public GClass0 gclass0_0;
        public MainForm mainForm_0;

        internal void method_0(object sender, EventArgs e)
        {
            using (IEnumerator enumerator = this.gclass0_0.cookieCont.GetCookies(new Uri(this.mainForm_0.dictionary_5[this.mainForm_0.int_2])).GetEnumerator())
            {
                string[] textArray1;
                System.Net.Cookie current;
                while (enumerator.MoveNext())
                {
                    current = (System.Net.Cookie) enumerator.Current;
                    if (current.Name.Contains("dwanonymous"))
                    {
                        goto Label_0061;
                    }
                }
                goto Label_00B9;
            Label_0061:
                textArray1 = new string[] { "document.cookie=\"", current.Name, "=", current.Value, "\"" };
                Clipboard.SetDataObject(string.Concat(textArray1));
                MessageBox.Show("Success! Please load the adidas page in a NEW session of your browser (private browsing, close all other private windows first), open your browsers developer console (chrome: f12 -> console, firefox: CTRL+Shift+K), paste the command using CTRL+V, press enter and reload the page using F5.");
                return;
            }
        Label_00B9:
            MessageBox.Show("Sorry, there was an error exporting the cart.");
        }

        internal void method_1(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.gclass0_0.adiName + ":" + this.gclass0_0.adiPw);
        }
    }

    private sealed class Class36
    {
        public GClass0 gclass0_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + this.gclass0_0.id.ToString() + ": Start" + this.mainForm_0.string_26.Substring(12, 1) + "d.\n");
        }
    }

    private sealed class Class37
    {
        public ArrayList arrayList_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_10(this.arrayList_0);
        }
    }

    private sealed class Class38
    {
        public MainForm mainForm_0;
        public MethodInvoker methodInvoker_0;
        public string string_0;

        internal void method_0()
        {
            this.mainForm_0.hmacExpireLabel.ForeColor = Color.Green;
            this.mainForm_0.hmacExpireLabel.Text = "Expires in " + this.string_0;
        }
    }

    private sealed class Class39
    {
        public GClass0 gclass0_0;
        public MainForm mainForm_0;
        public MethodInvoker methodInvoker_0;
        public MethodInvoker methodInvoker_1;
        public MethodInvoker methodInvoker_2;
        public MethodInvoker methodInvoker_3;
        public MethodInvoker methodInvoker_4;

        internal void method_0()
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Cookie Preload Link malformed! Please correct the link.\n");
            this.mainForm_0.method_13(string.Concat(new object[] { DateTime.Now.ToString("hh:mm:ss"), ":  Task ", this.gclass0_0.id, ": Aborted.\n" }));
        }

        internal void method_1()
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + this.gclass0_0.id.ToString() + ":  Fatal error while sending the hmac cookie request! Please check your connection and proxy server.\n");
        }

        internal void method_2()
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + this.gclass0_0.id.ToString() + ":  HMAC cookie preloaded!\n");
        }

        internal void method_3()
        {
            this.mainForm_0.completedTaskOListView.AddObject(this.gclass0_0);
            this.mainForm_0.taskOListView.RemoveObject(this.gclass0_0);
        }

        internal void method_4()
        {
            this.mainForm_0.completedTaskOListView.AddObject(this.gclass0_0);
            this.mainForm_0.taskOListView.RemoveObject(this.gclass0_0);
        }
    }

    private sealed class Class40
    {
        public BrowserForm browserForm_0;
        public ChromiumWebBrowser chromiumWebBrowser_0;
        public GClass0 gclass0_0;
        public int int_0;
        public MainForm mainForm_0;
        public CefSharp.RequestContext requestContext_0;

        internal void method_0()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object> {
                ["mode"] = "fixed_servers",
                ["server"] = this.gclass0_0.proxy
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
            if (Class21.string_2.Length < this.gclass0_0.getSizeString().Length)
            {
                this.gclass0_0.pid = "???";
            }
            else
            {
                if (this.gclass0_0.useProxyCheckout && (this.gclass0_0.proxy != string.Empty))
                {
                    string[] textArray1 = new string[] { this.gclass0_0.id.ToString(), ": ", this.gclass0_0.pid, ", ", this.gclass0_0.getSizeString(), ", ", this.gclass0_0.proxy };
                    this.browserForm_0.Text = string.Concat(textArray1);
                }
                else
                {
                    string[] textArray2 = new string[] { this.gclass0_0.id.ToString(), ": ", this.gclass0_0.pid, ", ", this.gclass0_0.getSizeString() };
                    this.browserForm_0.Text = string.Concat(textArray2);
                }
                this.browserForm_0.Show();
                this.browserForm_0.method_0(this.chromiumWebBrowser_0);
            }
        }

        internal void method_2()
        {
            this.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + this.gclass0_0.id.ToString() + ": Checkout window opened. Please checkout manually!\n");
        }

        internal void method_3(object sender, FrameLoadEndEventArgs e)
        {
            Thread.Sleep(250);
            if (!this.browserForm_0.bool_0)
            {
                if (this.gclass0_0.checkoutType == 1)
                {
                    this.chromiumWebBrowser_0.Load(this.mainForm_0.dictionary_2[this.int_0]);
                }
                else if (this.gclass0_0.checkoutType == 2)
                {
                    this.chromiumWebBrowser_0.Load(this.mainForm_0.dictionary_3[this.int_0]);
                }
                else
                {
                    this.chromiumWebBrowser_0.Load(this.mainForm_0.dictionary_4[this.int_0]);
                }
            }
            this.browserForm_0.bool_0 = true;
        }
    }

    private sealed class Class41
    {
        public ArrayList arrayList_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_10(this.arrayList_0);
        }
    }

    private sealed class Class42
    {
        public MainForm.Class39 class39_0;
        public HttpWebResponse httpWebResponse_0;

        internal void method_0()
        {
            this.class39_0.mainForm_0.method_13(DateTime.Now.ToString("hh:mm:ss") + ":  Task " + this.class39_0.gclass0_0.id.ToString() + ":  Error while sending a preload request! Please check your connection and proxy server.\n");
            if (this.httpWebResponse_0 != null)
            {
                this.httpWebResponse_0.Close();
            }
        }
    }

    private sealed class Class43
    {
        public bool bool_0;
        public BrowserForm browserForm_0;
        public ChromiumWebBrowser chromiumWebBrowser_0;
        public GClass0 gclass0_0;
        public MainForm mainForm_0;
        public CefSharp.RequestContext requestContext_0;
        public string string_0;
        public ThreadStart threadStart_0;

        internal void method_0()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object> {
                ["mode"] = "fixed_servers",
                ["server"] = this.gclass0_0.proxy
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
            if (this.gclass0_0.proxy != string.Empty)
            {
                object[] objArray1 = new object[] { this.gclass0_0.id.ToString(), ": ", this.gclass0_0.pid, ", ", this.gclass0_0.size, ", ", this.gclass0_0.proxy };
                this.browserForm_0.Text = string.Concat(objArray1);
            }
            else
            {
                object[] objArray2 = new object[] { this.gclass0_0.id.ToString(), ": ", this.gclass0_0.pid, ", ", this.gclass0_0.size };
                this.browserForm_0.Text = string.Concat(objArray2);
            }
            this.browserForm_0.Show();
            this.browserForm_0.method_0(this.chromiumWebBrowser_0);
        }

        internal void method_2(object sender, FrameLoadEndEventArgs e)
        {
            if (!this.bool_0)
            {
                Thread.Sleep(0x2710);
                new Thread(this.threadStart_0 ?? (this.threadStart_0 = new ThreadStart(this.method_3))).Start();
                this.bool_0 = true;
            }
        }

        internal void method_3()
        {
            this.mainForm_0.method_19(this.chromiumWebBrowser_0, this.gclass0_0, this.string_0);
        }
    }

    private sealed class Class44
    {
        public ArrayList arrayList_0;
        public MainForm mainForm_0;

        internal void method_0()
        {
            this.mainForm_0.method_10(this.arrayList_0);
        }
    }
}
