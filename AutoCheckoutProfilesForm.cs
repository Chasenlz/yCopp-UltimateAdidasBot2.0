using BrightIdeasSoftware;
using Polenter.Serialization;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class AutoCheckoutProfilesForm : Form
{
    private Button addButton;
    public ArrayList arrayList_0;
    public bool bool_0;
    private Button cancelButton;
    private TextBox cardName;
    private TextBox cardNumber;
    private Panel ccPanel;
    private RadioButton ccRadio;
    private ComboBox countryBox;
    private TextBox cvc;
    private Button deleteButton;
    private Button duplicateButton;
    private Button editButton;
    private TextBox euAddress1;
    private TextBox euAddress2;
    private TextBox euCity;
    private TextBox euEmail;
    private TextBox euLastName;
    private TextBox euName;
    private Panel euPanel;
    private TextBox euPostal;
    private ComboBox exMonth;
    private ComboBox exYear;
    private GClass4 gclass4_0;
    private Label headerLabel;
    private IContainer icontainer_0;
    private Label label1;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private OLVColumn olvcolumn_0;
    private Panel panel1;
    private TextBox phoneBox;
    private TextBox ppName;
    private Panel ppPanel;
    private TextBox ppPw;
    private RadioButton ppRadio;
    private ObjectListView profileListView;
    private TextBox profileName;
    private CheckBox proxyBox;
    private Button saveButton;
    private SharpSerializer sharpSerializer_0;
    private ComboBox stateCombo;
    private Label stateLabel;

    public AutoCheckoutProfilesForm()
    {
        this.arrayList_0 = new ArrayList();
        this.sharpSerializer_0 = new SharpSerializer(true);
        this.InitializeComponent();
    }

    public AutoCheckoutProfilesForm(ArrayList arrayList_1)
    {
        this.arrayList_0 = new ArrayList();
        this.sharpSerializer_0 = new SharpSerializer(true);
        this.arrayList_0 = arrayList_1;
        this.InitializeComponent();
        this.profileListView.SetObjects(arrayList_1);
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (this.profileName.Text.Equals(string.Empty))
        {
            MessageBox.Show("Please enter a profile name.");
            return;
        }
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                if (((GClass4) enumerator.Current).profileName.Equals(this.profileName.Text))
                {
                    goto Label_005E;
                }
            }
            goto Label_007F;
        Label_005E:
            MessageBox.Show("A profile with this name already exists! Please select another name.");
            return;
        }
    Label_007F:
        if (!this.method_1())
        {
            MessageBox.Show("Please fill in all required fields.");
        }
        else
        {
            if (this.ccRadio.Checked)
            {
                GClass4 class2 = new GClass4(this.profileName.Text, this.countryBox.SelectedIndex, 0, this.euName.Text, this.euLastName.Text, this.euAddress1.Text, this.euAddress2.Text, this.euCity.Text, this.euPostal.Text, this.stateCombo.SelectedIndex, this.phoneBox.Text, this.euEmail.Text, this.cardName.Text, this.cardNumber.Text, this.exMonth.SelectedIndex, this.exYear.SelectedIndex, this.cvc.Text, this.proxyBox.Checked);
                this.arrayList_0.Add(class2);
                this.sharpSerializer_0.Serialize(this.arrayList_0, "acdata.bin");
                this.profileListView.SetObjects(this.arrayList_0);
                this.method_0();
            }
            if (this.ppRadio.Checked)
            {
                GClass4 class3 = new GClass4(this.profileName.Text, this.countryBox.SelectedIndex, 1, this.ppName.Text, this.ppPw.Text, this.proxyBox.Checked);
                this.arrayList_0.Add(class3);
                this.sharpSerializer_0.Serialize(this.arrayList_0, "acdata.bin");
                this.profileListView.SetObjects(this.arrayList_0);
                this.method_0();
            }
        }
    }

    private void AutoCheckoutProfilesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        base.DialogResult = DialogResult.OK;
    }

    private void AutoCheckoutProfilesForm_Load(object sender, EventArgs e)
    {
        this.profileListView.ShowGroups = false;
        this.countryBox.SelectedIndex = 0;
        this.stateCombo.Items.Add("AA Military");
        this.stateCombo.Items.Add("AE Military");
        this.stateCombo.Items.Add("AP Military");
        this.stateCombo.Items.Add("Alabama");
        this.stateCombo.Items.Add("Alaska");
        this.stateCombo.Items.Add("Arizona");
        this.stateCombo.Items.Add("Arkansas");
        this.stateCombo.Items.Add("California");
        this.stateCombo.Items.Add("Colorado");
        this.stateCombo.Items.Add("Connecticut");
        this.stateCombo.Items.Add("Delaware");
        this.stateCombo.Items.Add("District of Columbia");
        this.stateCombo.Items.Add("Florida");
        this.stateCombo.Items.Add("Georgia");
        this.stateCombo.Items.Add("Hawaii");
        this.stateCombo.Items.Add("Idaho");
        this.stateCombo.Items.Add("Illinois");
        this.stateCombo.Items.Add("Indiana");
        this.stateCombo.Items.Add("Iowa");
        this.stateCombo.Items.Add("Kansas");
        this.stateCombo.Items.Add("Kentucky");
        this.stateCombo.Items.Add("Louisiana");
        this.stateCombo.Items.Add("Maine");
        this.stateCombo.Items.Add("Maryland");
        this.stateCombo.Items.Add("Massachusetts");
        this.stateCombo.Items.Add("Michigan");
        this.stateCombo.Items.Add("Minnesota");
        this.stateCombo.Items.Add("Mississippi");
        this.stateCombo.Items.Add("Missouri");
        this.stateCombo.Items.Add("Montana");
        this.stateCombo.Items.Add("Nebraska");
        this.stateCombo.Items.Add("Nevada");
        this.stateCombo.Items.Add("New Hampshire");
        this.stateCombo.Items.Add("New Jersey");
        this.stateCombo.Items.Add("New Mexico");
        this.stateCombo.Items.Add("New York");
        this.stateCombo.Items.Add("North Carolina");
        this.stateCombo.Items.Add("North Dakota");
        this.stateCombo.Items.Add("Ohio");
        this.stateCombo.Items.Add("Oklahoma");
        this.stateCombo.Items.Add("Oregon");
        this.stateCombo.Items.Add("Pennyslvania");
        this.stateCombo.Items.Add("Rhode Island");
        this.stateCombo.Items.Add("South Carolina");
        this.stateCombo.Items.Add("South Dakota");
        this.stateCombo.Items.Add("Tennessee");
        this.stateCombo.Items.Add("Texas");
        this.stateCombo.Items.Add("Utah");
        this.stateCombo.Items.Add("Vermont");
        this.stateCombo.Items.Add("Virginia");
        this.stateCombo.Items.Add("Washington");
        this.stateCombo.Items.Add("West Virginia");
        this.stateCombo.Items.Add("Wisconsin");
        this.stateCombo.Items.Add("Wyoming");
        this.stateCombo.SelectedIndex = 0;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.method_0();
        this.bool_0 = false;
        this.headerLabel.Text = "New profile:";
        this.cancelButton.Visible = false;
        this.saveButton.Visible = false;
        this.addButton.Visible = true;
    }

    private void ccRadio_CheckedChanged(object sender, EventArgs e)
    {
        if (this.ccRadio.Checked)
        {
            this.ppPanel.Visible = false;
            this.ccPanel.Visible = true;
            this.euPanel.Visible = true;
        }
    }

    private void countryBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.countryBox.SelectedIndex == 0)
        {
            this.stateCombo.Items.Clear();
            this.stateCombo.Items.Add("AA Military");
            this.stateCombo.Items.Add("AE Military");
            this.stateCombo.Items.Add("AP Military");
            this.stateCombo.Items.Add("Alabama");
            this.stateCombo.Items.Add("Alaska");
            this.stateCombo.Items.Add("Arizona");
            this.stateCombo.Items.Add("Arkansas");
            this.stateCombo.Items.Add("California");
            this.stateCombo.Items.Add("Colorado");
            this.stateCombo.Items.Add("Connecticut");
            this.stateCombo.Items.Add("Delaware");
            this.stateCombo.Items.Add("District of Columbia");
            this.stateCombo.Items.Add("Florida");
            this.stateCombo.Items.Add("Georgia");
            this.stateCombo.Items.Add("Hawaii");
            this.stateCombo.Items.Add("Idaho");
            this.stateCombo.Items.Add("Illinois");
            this.stateCombo.Items.Add("Indiana");
            this.stateCombo.Items.Add("Iowa");
            this.stateCombo.Items.Add("Kansas");
            this.stateCombo.Items.Add("Kentucky");
            this.stateCombo.Items.Add("Louisiana");
            this.stateCombo.Items.Add("Maine");
            this.stateCombo.Items.Add("Maryland");
            this.stateCombo.Items.Add("Massachusetts");
            this.stateCombo.Items.Add("Michigan");
            this.stateCombo.Items.Add("Minnesota");
            this.stateCombo.Items.Add("Mississippi");
            this.stateCombo.Items.Add("Missouri");
            this.stateCombo.Items.Add("Montana");
            this.stateCombo.Items.Add("Nebraska");
            this.stateCombo.Items.Add("Nevada");
            this.stateCombo.Items.Add("New Hampshire");
            this.stateCombo.Items.Add("New Jersey");
            this.stateCombo.Items.Add("New Mexico");
            this.stateCombo.Items.Add("New York");
            this.stateCombo.Items.Add("North Carolina");
            this.stateCombo.Items.Add("North Dakota");
            this.stateCombo.Items.Add("Ohio");
            this.stateCombo.Items.Add("Oklahoma");
            this.stateCombo.Items.Add("Oregon");
            this.stateCombo.Items.Add("Pennyslvania");
            this.stateCombo.Items.Add("Rhode Island");
            this.stateCombo.Items.Add("South Carolina");
            this.stateCombo.Items.Add("South Dakota");
            this.stateCombo.Items.Add("Tennessee");
            this.stateCombo.Items.Add("Texas");
            this.stateCombo.Items.Add("Utah");
            this.stateCombo.Items.Add("Vermont");
            this.stateCombo.Items.Add("Virginia");
            this.stateCombo.Items.Add("Washington");
            this.stateCombo.Items.Add("West Virginia");
            this.stateCombo.Items.Add("Wisconsin");
            this.stateCombo.Items.Add("Wyoming");
        }
        else if (this.countryBox.SelectedIndex == 1)
        {
            this.stateCombo.Items.Clear();
            this.stateCombo.Items.Add("Alberta");
            this.stateCombo.Items.Add("British Columbia");
            this.stateCombo.Items.Add("Manitoba");
            this.stateCombo.Items.Add("New Brunswick");
            this.stateCombo.Items.Add("Newfoundland and Labrador");
            this.stateCombo.Items.Add("Northwest Territories");
            this.stateCombo.Items.Add("Nova Scotia");
            this.stateCombo.Items.Add("Nunavut");
            this.stateCombo.Items.Add("Ontario");
            this.stateCombo.Items.Add("Prince Edward Island");
            this.stateCombo.Items.Add("Quebec");
            this.stateCombo.Items.Add("Saskatchevan");
            this.stateCombo.Items.Add("Yukon");
        }
        else
        {
            this.stateCombo.Items.Clear();
            this.stateCombo.Items.Add("None");
        }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < this.profileListView.SelectedObjects.Count; i++)
        {
            this.arrayList_0.Remove(this.profileListView.SelectedObjects[i]);
        }
        this.profileListView.SetObjects(this.arrayList_0);
        this.sharpSerializer_0.Serialize(this.arrayList_0, "acdata.bin");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void duplicateButton_Click(object sender, EventArgs e)
    {
        if (this.profileListView.SelectedItem == null)
        {
            return;
        }
        GClass4 class2 = ((GClass4) this.profileListView.SelectedItem.RowObject).method_0();
        class2.profileName = class2.profileName + " Copy";
        bool flag = true;
        int num = 2;
    Label_0049:
        if (num >= 50)
        {
            goto Label_0139;
        }
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                if (((GClass4) enumerator.Current).profileName.Equals(class2.profileName))
                {
                    goto Label_008A;
                }
            }
            goto Label_0133;
        Label_008A:
            if (num == 0x31)
            {
                return;
            }
            flag = false;
            goto Label_0133;
        }
    Label_00AF:
        if (num == 2)
        {
            class2.profileName = class2.profileName + " 2";
        }
        else if (num < 11)
        {
            class2.profileName = class2.profileName.Substring(0, class2.profileName.Length - 1) + num.ToString();
        }
        else
        {
            class2.profileName = class2.profileName.Substring(0, class2.profileName.Length - 2) + num.ToString();
        }
        flag = true;
        num++;
        goto Label_0049;
    Label_0133:
        if (!flag)
        {
            goto Label_00AF;
        }
    Label_0139:
        this.arrayList_0.Add(class2);
        this.profileListView.SetObjects(this.arrayList_0);
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        if (this.profileListView.SelectedItem != null)
        {
            GClass4 rowObject = (GClass4) this.profileListView.SelectedItem.RowObject;
            this.gclass4_0 = rowObject;
            this.countryBox.SelectedIndex = rowObject.countryCode;
            this.profileName.Text = rowObject.profileName;
            this.proxyBox.Checked = rowObject.useProxy;
            if (rowObject.paymentMethod == 0)
            {
                this.ccRadio.PerformClick();
                this.euName.Text = rowObject.name;
                this.euLastName.Text = rowObject.lastName;
                this.euAddress1.Text = rowObject.address1;
                this.euAddress2.Text = rowObject.address2;
                this.euCity.Text = rowObject.city;
                this.euPostal.Text = rowObject.postalCode;
                this.stateCombo.SelectedIndex = rowObject.stateCode;
                this.phoneBox.Text = rowObject.phoneNumber;
                this.euEmail.Text = rowObject.email;
                this.cardName.Text = rowObject.cardName;
                this.cardNumber.Text = rowObject.cardNumber;
                this.exMonth.SelectedIndex = rowObject.expireMonth;
                this.exYear.SelectedIndex = rowObject.expireYear;
                this.cvc.Text = rowObject.cvc;
            }
            if (rowObject.paymentMethod == 1)
            {
                this.ppRadio.PerformClick();
                this.ppName.Text = rowObject.ppLogin;
                this.ppPw.Text = rowObject.ppPw;
            }
            this.bool_0 = true;
            this.headerLabel.Text = "Edit profile:";
            this.saveButton.Visible = true;
            this.cancelButton.Visible = true;
            this.addButton.Visible = false;
        }
    }

    private void euLastName_TextChanged(object sender, EventArgs e)
    {
    }

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(AutoCheckoutProfilesForm));
        this.profileListView = new ObjectListView();
        this.olvcolumn_0 = new OLVColumn();
        this.label1 = new Label();
        this.ccRadio = new RadioButton();
        this.panel1 = new Panel();
        this.ppRadio = new RadioButton();
        this.euPanel = new Panel();
        this.phoneBox = new TextBox();
        this.label17 = new Label();
        this.stateCombo = new ComboBox();
        this.stateLabel = new Label();
        this.euEmail = new TextBox();
        this.label9 = new Label();
        this.euPostal = new TextBox();
        this.label8 = new Label();
        this.euCity = new TextBox();
        this.label6 = new Label();
        this.euAddress2 = new TextBox();
        this.label5 = new Label();
        this.euAddress1 = new TextBox();
        this.label4 = new Label();
        this.euLastName = new TextBox();
        this.label3 = new Label();
        this.euName = new TextBox();
        this.label2 = new Label();
        this.label7 = new Label();
        this.countryBox = new ComboBox();
        this.ccPanel = new Panel();
        this.cvc = new TextBox();
        this.label13 = new Label();
        this.exYear = new ComboBox();
        this.exMonth = new ComboBox();
        this.label12 = new Label();
        this.cardNumber = new TextBox();
        this.label11 = new Label();
        this.cardName = new TextBox();
        this.label10 = new Label();
        this.ppPanel = new Panel();
        this.ppPw = new TextBox();
        this.ppName = new TextBox();
        this.label15 = new Label();
        this.label14 = new Label();
        this.addButton = new Button();
        this.profileName = new TextBox();
        this.label16 = new Label();
        this.saveButton = new Button();
        this.deleteButton = new Button();
        this.editButton = new Button();
        this.cancelButton = new Button();
        this.headerLabel = new Label();
        this.duplicateButton = new Button();
        this.proxyBox = new CheckBox();
        ((ISupportInitialize) this.profileListView).BeginInit();
        this.panel1.SuspendLayout();
        this.euPanel.SuspendLayout();
        this.ccPanel.SuspendLayout();
        this.ppPanel.SuspendLayout();
        base.SuspendLayout();
        this.profileListView.AllColumns.Add(this.olvcolumn_0);
        this.profileListView.CellEditUseWholeCell = false;
        ColumnHeader[] values = new ColumnHeader[] { this.olvcolumn_0 };
        this.profileListView.Columns.AddRange(values);
        this.profileListView.Cursor = Cursors.Default;
        this.profileListView.Location = new Point(12, 12);
        this.profileListView.Name = "profileListView";
        this.profileListView.Size = new Size(0x9c, 0x239);
        this.profileListView.TabIndex = 0;
        this.profileListView.UseCompatibleStateImageBehavior = false;
        this.profileListView.View = View.Details;
        this.olvcolumn_0.AspectName = "profileName";
        this.olvcolumn_0.Text = "Profile Name";
        this.olvcolumn_0.Width = 0x98;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0xb9, 0x4f);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x59, 13);
        this.label1.TabIndex = 1;
        this.label1.Text = "Payment method:";
        this.ccRadio.AutoSize = true;
        this.ccRadio.Checked = true;
        this.ccRadio.Location = new Point(3, 0x10);
        this.ccRadio.Name = "ccRadio";
        this.ccRadio.Size = new Size(0x4d, 0x11);
        this.ccRadio.TabIndex = 2;
        this.ccRadio.TabStop = true;
        this.ccRadio.Text = "Credit Card";
        this.ccRadio.UseVisualStyleBackColor = true;
        this.ccRadio.CheckedChanged += new EventHandler(this.ccRadio_CheckedChanged);
        this.panel1.Controls.Add(this.ppRadio);
        this.panel1.Controls.Add(this.ccRadio);
        this.panel1.Location = new Point(0x11f, 0x3e);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(0xbc, 0x2e);
        this.panel1.TabIndex = 3;
        this.ppRadio.AutoSize = true;
        this.ppRadio.Location = new Point(100, 0x10);
        this.ppRadio.Name = "ppRadio";
        this.ppRadio.Size = new Size(0x3a, 0x11);
        this.ppRadio.TabIndex = 3;
        this.ppRadio.Text = "PayPal";
        this.ppRadio.UseVisualStyleBackColor = true;
        this.ppRadio.CheckedChanged += new EventHandler(this.ppRadio_CheckedChanged);
        this.euPanel.Controls.Add(this.phoneBox);
        this.euPanel.Controls.Add(this.label17);
        this.euPanel.Controls.Add(this.stateCombo);
        this.euPanel.Controls.Add(this.stateLabel);
        this.euPanel.Controls.Add(this.euEmail);
        this.euPanel.Controls.Add(this.label9);
        this.euPanel.Controls.Add(this.euPostal);
        this.euPanel.Controls.Add(this.label8);
        this.euPanel.Controls.Add(this.euCity);
        this.euPanel.Controls.Add(this.label6);
        this.euPanel.Controls.Add(this.euAddress2);
        this.euPanel.Controls.Add(this.label5);
        this.euPanel.Controls.Add(this.euAddress1);
        this.euPanel.Controls.Add(this.label4);
        this.euPanel.Controls.Add(this.euLastName);
        this.euPanel.Controls.Add(this.label3);
        this.euPanel.Controls.Add(this.euName);
        this.euPanel.Controls.Add(this.label2);
        this.euPanel.Location = new Point(0xae, 0xa8);
        this.euPanel.Name = "euPanel";
        this.euPanel.Size = new Size(0x1be, 0xe0);
        this.euPanel.TabIndex = 4;
        this.phoneBox.Location = new Point(0x71, 0x9f);
        this.phoneBox.Name = "phoneBox";
        this.phoneBox.Size = new Size(100, 20);
        this.phoneBox.TabIndex = 14;
        this.label17.AutoSize = true;
        this.label17.Location = new Point(8, 0xa2);
        this.label17.Name = "label17";
        this.label17.Size = new Size(0x29, 13);
        this.label17.TabIndex = 0x15;
        this.label17.Text = "Phone:";
        this.stateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        this.stateCombo.FormattingEnabled = true;
        object[] items = new object[] { "default", "default2" };
        this.stateCombo.Items.AddRange(items);
        this.stateCombo.Location = new Point(0x71, 0x84);
        this.stateCombo.Name = "stateCombo";
        this.stateCombo.Size = new Size(100, 0x15);
        this.stateCombo.TabIndex = 13;
        this.stateLabel.AutoSize = true;
        this.stateLabel.Location = new Point(8, 0x84);
        this.stateLabel.Name = "stateLabel";
        this.stateLabel.Size = new Size(0x23, 13);
        this.stateLabel.TabIndex = 0x13;
        this.stateLabel.Text = "State:";
        this.euEmail.Location = new Point(0x71, 0xb8);
        this.euEmail.Name = "euEmail";
        this.euEmail.Size = new Size(100, 20);
        this.euEmail.TabIndex = 15;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(8, 0xbb);
        this.label9.Name = "label9";
        this.label9.Size = new Size(0x27, 13);
        this.label9.TabIndex = 0x11;
        this.label9.Text = "E-Mail:";
        this.euPostal.Location = new Point(0x125, 0x6b);
        this.euPostal.Name = "euPostal";
        this.euPostal.Size = new Size(100, 20);
        this.euPostal.TabIndex = 12;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(220, 110);
        this.label8.Name = "label8";
        this.label8.Size = new Size(0x43, 13);
        this.label8.TabIndex = 15;
        this.label8.Text = "Postal Code:";
        this.euCity.Location = new Point(0x71, 0x6b);
        this.euCity.Name = "euCity";
        this.euCity.Size = new Size(100, 20);
        this.euCity.TabIndex = 11;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(8, 110);
        this.label6.Name = "label6";
        this.label6.Size = new Size(0x41, 13);
        this.label6.TabIndex = 13;
        this.label6.Text = "City / Town:";
        this.euAddress2.Location = new Point(0x71, 0x51);
        this.euAddress2.Name = "euAddress2";
        this.euAddress2.Size = new Size(100, 20);
        this.euAddress2.TabIndex = 10;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(7, 0x54);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0x4c, 13);
        this.label5.TabIndex = 11;
        this.label5.Text = "Address line 2:";
        this.euAddress1.Location = new Point(0x71, 0x37);
        this.euAddress1.Name = "euAddress1";
        this.euAddress1.Size = new Size(100, 20);
        this.euAddress1.TabIndex = 9;
        this.label4.AutoSize = true;
        this.label4.Location = new Point(7, 0x3a);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x4e, 13);
        this.label4.TabIndex = 9;
        this.label4.Text = "Street address:";
        this.euLastName.Location = new Point(0x125, 12);
        this.euLastName.Name = "euLastName";
        this.euLastName.Size = new Size(100, 20);
        this.euLastName.TabIndex = 8;
        this.euLastName.TextChanged += new EventHandler(this.euLastName_TextChanged);
        this.label3.AutoSize = true;
        this.label3.Location = new Point(0xdb, 15);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x3d, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Last Name:";
        this.euName.Location = new Point(0x71, 12);
        this.euName.Name = "euName";
        this.euName.Size = new Size(100, 20);
        this.euName.TabIndex = 7;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(7, 15);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x26, 13);
        this.label2.TabIndex = 5;
        this.label2.Text = "Name:";
        this.label7.AutoSize = true;
        this.label7.Location = new Point(0xb9, 0x26);
        this.label7.Name = "label7";
        this.label7.Size = new Size(0x2e, 13);
        this.label7.TabIndex = 5;
        this.label7.Text = "Country:";
        this.countryBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.countryBox.FormattingEnabled = true;
        object[] objArray2 = new object[] { "United States", "Canada", "United Kingdom", "Germany", "Netherlands", "France", "Spain", "Italy", "Austria", "Belgium", "Sweden", "Denmark", "Norway", "Poland", "Czech Republic" };
        this.countryBox.Items.AddRange(objArray2);
        this.countryBox.Location = new Point(0x11f, 0x23);
        this.countryBox.Name = "countryBox";
        this.countryBox.Size = new Size(0x79, 0x15);
        this.countryBox.TabIndex = 1;
        this.countryBox.SelectedIndexChanged += new EventHandler(this.countryBox_SelectedIndexChanged);
        this.ccPanel.Controls.Add(this.cvc);
        this.ccPanel.Controls.Add(this.label13);
        this.ccPanel.Controls.Add(this.exYear);
        this.ccPanel.Controls.Add(this.exMonth);
        this.ccPanel.Controls.Add(this.label12);
        this.ccPanel.Controls.Add(this.cardNumber);
        this.ccPanel.Controls.Add(this.label11);
        this.ccPanel.Controls.Add(this.cardName);
        this.ccPanel.Controls.Add(this.label10);
        this.ccPanel.Location = new Point(0xae, 0x18e);
        this.ccPanel.Name = "ccPanel";
        this.ccPanel.Size = new Size(0x17e, 0x88);
        this.ccPanel.TabIndex = 7;
        this.cvc.Location = new Point(0x71, 100);
        this.cvc.Name = "cvc";
        this.cvc.Size = new Size(0x3b, 20);
        this.cvc.TabIndex = 20;
        this.label13.AutoSize = true;
        this.label13.Location = new Point(10, 0x67);
        this.label13.Name = "label13";
        this.label13.Size = new Size(0x4c, 13);
        this.label13.TabIndex = 0x18;
        this.label13.Text = "Security Code:";
        this.exYear.FormattingEnabled = true;
        object[] objArray3 = new object[] { 
            "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032",
            "2033", "2034", "2035", "2036", "2037"
        };
        this.exYear.Items.AddRange(objArray3);
        this.exYear.Location = new Point(0xb2, 0x43);
        this.exYear.Name = "exYear";
        this.exYear.Size = new Size(0x58, 0x15);
        this.exYear.TabIndex = 0x13;
        this.exMonth.FormattingEnabled = true;
        object[] objArray4 = new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        this.exMonth.Items.AddRange(objArray4);
        this.exMonth.Location = new Point(0x71, 0x43);
        this.exMonth.Name = "exMonth";
        this.exMonth.Size = new Size(0x3b, 0x15);
        this.exMonth.TabIndex = 0x12;
        this.label12.AutoSize = true;
        this.label12.Location = new Point(10, 70);
        this.label12.Name = "label12";
        this.label12.Size = new Size(0x2c, 13);
        this.label12.TabIndex = 0x17;
        this.label12.Text = "Expires:";
        this.cardNumber.Location = new Point(0x71, 0x27);
        this.cardNumber.Name = "cardNumber";
        this.cardNumber.Size = new Size(100, 20);
        this.cardNumber.TabIndex = 0x11;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(10, 0x2a);
        this.label11.Name = "label11";
        this.label11.Size = new Size(0x48, 13);
        this.label11.TabIndex = 0x15;
        this.label11.Text = "Card Number:";
        this.cardName.Location = new Point(0x71, 10);
        this.cardName.Name = "cardName";
        this.cardName.Size = new Size(100, 20);
        this.cardName.TabIndex = 0x10;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(10, 13);
        this.label10.Name = "label10";
        this.label10.Size = new Size(0x5d, 13);
        this.label10.TabIndex = 0x13;
        this.label10.Text = "Name (if different):";
        this.ppPanel.Controls.Add(this.ppPw);
        this.ppPanel.Controls.Add(this.ppName);
        this.ppPanel.Controls.Add(this.label15);
        this.ppPanel.Controls.Add(this.label14);
        this.ppPanel.Location = new Point(0xae, 0x95);
        this.ppPanel.Name = "ppPanel";
        this.ppPanel.Size = new Size(0x16a, 100);
        this.ppPanel.TabIndex = 8;
        this.ppPanel.Visible = false;
        this.ppPw.Location = new Point(0x71, 0x2e);
        this.ppPw.Name = "ppPw";
        this.ppPw.Size = new Size(0x87, 20);
        this.ppPw.TabIndex = 6;
        this.ppName.Location = new Point(0x71, 0x10);
        this.ppName.Name = "ppName";
        this.ppName.Size = new Size(0x87, 20);
        this.ppName.TabIndex = 5;
        this.label15.AutoSize = true;
        this.label15.Location = new Point(10, 0x31);
        this.label15.Name = "label15";
        this.label15.Size = new Size(0x5c, 13);
        this.label15.TabIndex = 0x1b;
        this.label15.Text = "PayPal Password:";
        this.label14.AutoSize = true;
        this.label14.Location = new Point(10, 0x17);
        this.label14.Name = "label14";
        this.label14.Size = new Size(0x48, 13);
        this.label14.TabIndex = 0x1a;
        this.label14.Text = "PayPal Login:";
        this.addButton.Location = new Point(0x12a, 0x233);
        this.addButton.Name = "addButton";
        this.addButton.Size = new Size(0x4b, 0x17);
        this.addButton.TabIndex = 9;
        this.addButton.Text = "Add Profile";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Click += new EventHandler(this.addButton_Click);
        this.profileName.Location = new Point(0x11f, 0x7b);
        this.profileName.Name = "profileName";
        this.profileName.Size = new Size(100, 20);
        this.profileName.TabIndex = 4;
        this.label16.AutoSize = true;
        this.label16.Location = new Point(0xb9, 0x7e);
        this.label16.Name = "label16";
        this.label16.Size = new Size(70, 13);
        this.label16.TabIndex = 0x15;
        this.label16.Text = "Profile Name:";
        this.saveButton.Location = new Point(290, 0x233);
        this.saveButton.Name = "saveButton";
        this.saveButton.Size = new Size(0x4b, 0x17);
        this.saveButton.TabIndex = 0x15;
        this.saveButton.Text = "Save";
        this.saveButton.UseVisualStyleBackColor = true;
        this.saveButton.Visible = false;
        this.saveButton.Click += new EventHandler(this.saveButton_Click);
        this.deleteButton.Location = new Point(0x34, 0x268);
        this.deleteButton.Name = "deleteButton";
        this.deleteButton.Size = new Size(0x4b, 0x17);
        this.deleteButton.TabIndex = 0x19;
        this.deleteButton.Text = "Delete";
        this.deleteButton.UseVisualStyleBackColor = true;
        this.deleteButton.Click += new EventHandler(this.deleteButton_Click);
        this.editButton.Location = new Point(12, 0x24b);
        this.editButton.Name = "editButton";
        this.editButton.Size = new Size(0x4b, 0x17);
        this.editButton.TabIndex = 0x17;
        this.editButton.Text = "Edit";
        this.editButton.UseVisualStyleBackColor = true;
        this.editButton.Click += new EventHandler(this.editButton_Click);
        this.cancelButton.Location = new Point(0x16f, 0x233);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(0x4b, 0x17);
        this.cancelButton.TabIndex = 0x16;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Visible = false;
        this.cancelButton.Click += new EventHandler(this.cancelButton_Click);
        this.headerLabel.AutoSize = true;
        this.headerLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.headerLabel.Location = new Point(0xb9, 12);
        this.headerLabel.Name = "headerLabel";
        this.headerLabel.Size = new Size(0x4b, 13);
        this.headerLabel.TabIndex = 0x1b;
        this.headerLabel.Text = "New profile:";
        this.duplicateButton.Location = new Point(0x5d, 0x24b);
        this.duplicateButton.Name = "duplicateButton";
        this.duplicateButton.Size = new Size(0x4b, 0x17);
        this.duplicateButton.TabIndex = 0x18;
        this.duplicateButton.Text = "Duplicate";
        this.duplicateButton.UseVisualStyleBackColor = true;
        this.duplicateButton.Click += new EventHandler(this.duplicateButton_Click);
        this.proxyBox.AutoSize = true;
        this.proxyBox.Location = new Point(0xb9, 540);
        this.proxyBox.Name = "proxyBox";
        this.proxyBox.Size = new Size(0xbc, 0x11);
        this.proxyBox.TabIndex = 0x1c;
        this.proxyBox.Text = "Use proxy on checkout (if existing)";
        this.proxyBox.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(96f, 96f);
        base.AutoScaleMode = AutoScaleMode.Dpi;
        base.ClientSize = new Size(0x271, 0x286);
        base.Controls.Add(this.proxyBox);
        base.Controls.Add(this.duplicateButton);
        base.Controls.Add(this.headerLabel);
        base.Controls.Add(this.cancelButton);
        base.Controls.Add(this.editButton);
        base.Controls.Add(this.deleteButton);
        base.Controls.Add(this.saveButton);
        base.Controls.Add(this.profileName);
        base.Controls.Add(this.label16);
        base.Controls.Add(this.addButton);
        base.Controls.Add(this.ppPanel);
        base.Controls.Add(this.ccPanel);
        base.Controls.Add(this.countryBox);
        base.Controls.Add(this.label7);
        base.Controls.Add(this.euPanel);
        base.Controls.Add(this.panel1);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.profileListView);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "AutoCheckoutProfilesForm";
        this.Text = "Auto Checkout Profiles";
        base.FormClosing += new FormClosingEventHandler(this.AutoCheckoutProfilesForm_FormClosing);
        base.Load += new EventHandler(this.AutoCheckoutProfilesForm_Load);
        ((ISupportInitialize) this.profileListView).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.euPanel.ResumeLayout(false);
        this.euPanel.PerformLayout();
        this.ccPanel.ResumeLayout(false);
        this.ccPanel.PerformLayout();
        this.ppPanel.ResumeLayout(false);
        this.ppPanel.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void method_0()
    {
        this.profileName.Text = string.Empty;
        foreach (Control control in this.euPanel.Controls)
        {
            if (control is TextBox)
            {
                ((TextBox) control).Text = string.Empty;
            }
            if (control is ComboBox)
            {
                ((ComboBox) control).SelectedIndex = -1;
            }
        }
        foreach (Control control2 in this.ccPanel.Controls)
        {
            if (control2 is TextBox)
            {
                ((TextBox) control2).Text = string.Empty;
            }
            if (control2 is ComboBox)
            {
                ((ComboBox) control2).SelectedIndex = -1;
            }
        }
        foreach (Control control3 in this.ppPanel.Controls)
        {
            if (control3 is TextBox)
            {
                ((TextBox) control3).Text = string.Empty;
            }
            if (control3 is ComboBox)
            {
                ((ComboBox) control3).SelectedIndex = -1;
            }
        }
        this.proxyBox.Checked = false;
    }

    private bool method_1()
    {
        bool flag = true;
        if (this.profileName.Text.Equals(string.Empty))
        {
            flag = false;
        }
        if (this.ccRadio.Checked)
        {
            if (this.euName.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.euLastName.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.euAddress1.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.euCity.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.euPostal.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (((this.countryBox.SelectedIndex == 0) && (this.phoneBox.Text.Length != 10)) && (this.phoneBox.Text.Length != 12))
            {
                flag = false;
                MessageBox.Show("Phone number must be in format 1234567890 or 123-456-7890 for US.");
            }
            if (this.euEmail.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.cardNumber.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.exMonth.SelectedIndex == -1)
            {
                flag = false;
            }
            if (this.exYear.SelectedIndex == -1)
            {
                flag = false;
            }
            if (this.cvc.Text.Equals(string.Empty))
            {
                flag = false;
            }
        }
        if (this.ppRadio.Checked)
        {
            if (this.ppName.Text.Equals(string.Empty))
            {
                flag = false;
            }
            if (this.ppPw.Text.Equals(string.Empty))
            {
                flag = false;
            }
        }
        return flag;
    }

    private void ppRadio_CheckedChanged(object sender, EventArgs e)
    {
        if (this.ppRadio.Checked)
        {
            this.ccPanel.Visible = false;
            this.euPanel.Visible = false;
            this.ppPanel.Visible = true;
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (this.profileName.Text.Equals(string.Empty))
        {
            MessageBox.Show("Please enter a profile name.");
        }
        else if (!this.method_1())
        {
            MessageBox.Show("Please fill in all required fields.");
        }
        else
        {
            if (this.gclass4_0 != null)
            {
                this.arrayList_0.Remove(this.gclass4_0);
            }
            this.gclass4_0 = null;
            if (this.ccRadio.Checked)
            {
                GClass4 class2 = new GClass4(this.profileName.Text, this.countryBox.SelectedIndex, 0, this.euName.Text, this.euLastName.Text, this.euAddress1.Text, this.euAddress2.Text, this.euCity.Text, this.euPostal.Text, this.stateCombo.SelectedIndex, this.phoneBox.Text, this.euEmail.Text, this.cardName.Text, this.cardNumber.Text, this.exMonth.SelectedIndex, this.exYear.SelectedIndex, this.cvc.Text, this.proxyBox.Checked);
                this.arrayList_0.Add(class2);
                this.sharpSerializer_0.Serialize(this.arrayList_0, "acdata.bin");
                this.profileListView.SetObjects(this.arrayList_0);
                this.method_0();
            }
            if (this.ppRadio.Checked)
            {
                GClass4 class3 = new GClass4(this.profileName.Text, this.countryBox.SelectedIndex, 1, this.ppName.Text, this.ppPw.Text, this.proxyBox.Checked);
                this.arrayList_0.Add(class3);
                this.sharpSerializer_0.Serialize(this.arrayList_0, "acdata.bin");
                this.profileListView.SetObjects(this.arrayList_0);
                this.method_0();
            }
            this.bool_0 = false;
            this.saveButton.Visible = false;
            this.cancelButton.Visible = false;
            this.addButton.Visible = true;
        }
    }
}

