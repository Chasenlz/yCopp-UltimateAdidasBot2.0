using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public sealed class AddAdidasAccountForm : Form
{
    private Button addAllButton;
    private Button addButton;
    public ArrayList arrayList_0 = new ArrayList();
    private Button cancelButton;
    private IContainer icontainer_0;
    private Label importSuccessLabel;
    private Button metroButton1;
    private Label metroLabel1;
    private Label metroLabel2;
    private Label metroLabel3;
    private TextBox nameBox;
    private TextBox pwBox;

    public AddAdidasAccountForm()
    {
        this.InitializeComponent();
    }

    private void AddAdidasAccountForm_Load(object sender, EventArgs e)
    {
    }

    private void addAllButton_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.OK;
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (!this.nameBox.Text.Equals(string.Empty) && !this.pwBox.Text.Equals(string.Empty))
        {
            this.arrayList_0.Add(new Class46(this.nameBox.Text, this.pwBox.Text));
            this.nameBox.Text = string.Empty;
            this.pwBox.Text = string.Empty;
            this.addAllButton.Enabled = true;
            this.addAllButton.Text = "Add Accounts (" + this.arrayList_0.Count.ToString() + ")";
        }
        else
        {
            MessageBox.Show("Please enter a username and password.");
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.Abort;
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(AddAdidasAccountForm));
        this.metroLabel1 = new Label();
        this.metroLabel2 = new Label();
        this.nameBox = new TextBox();
        this.pwBox = new TextBox();
        this.metroButton1 = new Button();
        this.metroLabel3 = new Label();
        this.addAllButton = new Button();
        this.cancelButton = new Button();
        this.addButton = new Button();
        this.importSuccessLabel = new Label();
        base.SuspendLayout();
        this.metroLabel1.AutoSize = true;
        this.metroLabel1.Location = new Point(0x27, 0x26);
        this.metroLabel1.Name = "metroLabel1";
        this.metroLabel1.Size = new Size(0x26, 13);
        this.metroLabel1.TabIndex = 0;
        this.metroLabel1.Text = "Name:";
        this.metroLabel2.AutoSize = true;
        this.metroLabel2.Location = new Point(0x27, 0x47);
        this.metroLabel2.Name = "metroLabel2";
        this.metroLabel2.Size = new Size(0x38, 13);
        this.metroLabel2.TabIndex = 1;
        this.metroLabel2.Text = "Password:";
        this.nameBox.Location = new Point(120, 0x26);
        this.nameBox.Name = "nameBox";
        this.nameBox.Size = new Size(220, 20);
        this.nameBox.TabIndex = 2;
        this.pwBox.Location = new Point(120, 0x47);
        this.pwBox.Name = "pwBox";
        this.pwBox.Size = new Size(220, 20);
        this.pwBox.TabIndex = 3;
        this.metroButton1.Location = new Point(0x162, 0x70);
        this.metroButton1.Name = "metroButton1";
        this.metroButton1.Size = new Size(0x4b, 0x17);
        this.metroButton1.TabIndex = 4;
        this.metroButton1.Text = "Import";
        this.metroButton1.Click += new EventHandler(this.metroButton1_Click);
        this.metroLabel3.AutoSize = true;
        this.metroLabel3.Location = new Point(0x27, 0x74);
        this.metroLabel3.Name = "metroLabel3";
        this.metroLabel3.Size = new Size(0xed, 13);
        this.metroLabel3.TabIndex = 5;
        this.metroLabel3.Text = "Mass Import from txt-file (name:password per line)";
        this.addAllButton.Enabled = false;
        this.addAllButton.Location = new Point(0x56, 0xb6);
        this.addAllButton.Name = "addAllButton";
        this.addAllButton.Size = new Size(0x7b, 0x17);
        this.addAllButton.TabIndex = 6;
        this.addAllButton.Text = "Add Accounts (0)";
        this.addAllButton.Click += new EventHandler(this.addAllButton_Click);
        this.cancelButton.Location = new Point(0xfe, 0xb6);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(0x7b, 0x17);
        this.cancelButton.TabIndex = 7;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.Click += new EventHandler(this.cancelButton_Click);
        this.addButton.Location = new Point(0x162, 0x35);
        this.addButton.Name = "addButton";
        this.addButton.Size = new Size(0x4b, 0x17);
        this.addButton.TabIndex = 9;
        this.addButton.Text = "Add";
        this.addButton.Click += new EventHandler(this.addButton_Click);
        this.importSuccessLabel.AutoSize = true;
        this.importSuccessLabel.Location = new Point(0x88, 0x91);
        this.importSuccessLabel.Name = "importSuccessLabel";
        this.importSuccessLabel.Size = new Size(10, 13);
        this.importSuccessLabel.TabIndex = 10;
        this.importSuccessLabel.Text = " ";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x1d2, 0xe2);
        base.Controls.Add(this.importSuccessLabel);
        base.Controls.Add(this.addButton);
        base.Controls.Add(this.cancelButton);
        base.Controls.Add(this.addAllButton);
        base.Controls.Add(this.metroLabel3);
        base.Controls.Add(this.metroButton1);
        base.Controls.Add(this.pwBox);
        base.Controls.Add(this.nameBox);
        base.Controls.Add(this.metroLabel2);
        base.Controls.Add(this.metroLabel1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "AddAdidasAccountForm";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Add Adidas Accounts";
        base.Load += new EventHandler(this.AddAdidasAccountForm_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
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
                    int num = 0;
                    using (stream)
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, 0x200))
                        {
                            string str;
                            while ((str = reader.ReadLine()) != null)
                            {
                                char[] separator = new char[] { ':' };
                                string[] strArray = str.Split(separator);
                                if (((strArray.Length == 2) && (strArray[0].Trim().Length > 3)) && (strArray[1].Trim().Length > 3))
                                {
                                    this.arrayList_0.Add(new Class46(strArray[0], strArray[1]));
                                    num++;
                                }
                            }
                        }
                        if (num > 0)
                        {
                            this.addAllButton.Enabled = true;
                            this.addAllButton.Text = "Add Accounts (" + this.arrayList_0.Count.ToString() + ")";
                            char[] chArray2 = new char[] { '\\' };
                            string[] strArray2 = dialog.FileName.Split(chArray2);
                            if (strArray2.Length == 0)
                            {
                                char[] chArray3 = new char[] { '/' };
                                strArray2 = dialog.FileName.Split(chArray3);
                            }
                            string[] textArray1 = new string[] { "(", strArray2[strArray2.Length - 1], "): Found ", num.ToString(), " accounts in this file!" };
                            this.importSuccessLabel.Text = string.Concat(textArray1);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + exception.Message);
            }
        }
    }
}

