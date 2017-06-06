using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class TaskDelayForm : Form
{
    private Button applyButton;
    private IContainer icontainer_0;
    public int int_0;
    private Label metroLabel1;
    private Label metroLabel2;
    private Label secondLabel;
    private TrackBar secondTrack;

    public TaskDelayForm()
    {
        this.InitializeComponent();
    }

    public TaskDelayForm(int int_1)
    {
        this.InitializeComponent();
        this.int_0 = int_1;
        this.secondTrack.Value = int_1;
        if (this.int_0 == 1)
        {
            this.secondLabel.Text = "1 second";
        }
        else
        {
            this.secondLabel.Text = this.int_0.ToString() + " seconds";
        }
    }

    private void applyButton_Click(object sender, EventArgs e)
    {
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

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(TaskDelayForm));
        this.metroLabel1 = new Label();
        this.metroLabel2 = new Label();
        this.secondLabel = new Label();
        this.secondTrack = new TrackBar();
        this.applyButton = new Button();
        this.secondTrack.BeginInit();
        base.SuspendLayout();
        this.metroLabel1.AutoSize = true;
        this.metroLabel1.Location = new Point(0x3e, 9);
        this.metroLabel1.Name = "metroLabel1";
        this.metroLabel1.Size = new Size(0x139, 13);
        this.metroLabel1.TabIndex = 0;
        this.metroLabel1.Text = "The delay will be applied between tasks started at the same time!";
        this.metroLabel2.AutoSize = true;
        this.metroLabel2.Location = new Point(0x3e, 40);
        this.metroLabel2.Name = "metroLabel2";
        this.metroLabel2.Size = new Size(0x25, 13);
        this.metroLabel2.TabIndex = 1;
        this.metroLabel2.Text = "Delay:";
        this.secondLabel.AutoSize = true;
        this.secondLabel.Location = new Point(0xc2, 0x53);
        this.secondLabel.Name = "secondLabel";
        this.secondLabel.Size = new Size(0x38, 13);
        this.secondLabel.TabIndex = 2;
        this.secondLabel.Text = "0 seconds";
        this.secondTrack.Location = new Point(0x7c, 0x23);
        this.secondTrack.Name = "secondTrack";
        this.secondTrack.Size = new Size(0xd8, 0x2d);
        this.secondTrack.TabIndex = 3;
        this.secondTrack.Text = "metroTrackBar1";
        this.secondTrack.Scroll += new EventHandler(this.secondTrack_Scroll);
        this.applyButton.Location = new Point(0xbc, 0x71);
        this.applyButton.Name = "applyButton";
        this.applyButton.Size = new Size(0x4b, 0x17);
        this.applyButton.TabIndex = 4;
        this.applyButton.Text = "Apply";
        this.applyButton.Click += new EventHandler(this.applyButton_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x1bf, 0x94);
        base.Controls.Add(this.applyButton);
        base.Controls.Add(this.secondTrack);
        base.Controls.Add(this.secondLabel);
        base.Controls.Add(this.metroLabel2);
        base.Controls.Add(this.metroLabel1);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "TaskDelayForm";
        base.SizeGripStyle = SizeGripStyle.Hide;
        this.Text = "Set global task delay";
        base.Load += new EventHandler(this.TaskDelayForm_Load);
        this.secondTrack.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void secondTrack_Scroll(object sender, EventArgs e)
    {
        int num = this.secondTrack.Value;
        this.int_0 = num;
        if (num == 1)
        {
            this.secondLabel.Text = "1 second";
        }
        else
        {
            this.secondLabel.Text = num.ToString() + " seconds";
        }
    }

    private void TaskDelayForm_Load(object sender, EventArgs e)
    {
    }
}

