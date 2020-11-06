using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CultureExplorer20
{
  /// <summary>
	/// Summary description for ClassInfoForm.
	/// </summary>
	public class ClassInfoForm : System.Windows.Forms.Form
	{
    private MainForm myMainForm;

    private GroupBox groupBox1;
    private Button buttonSelectAll;
    private Button buttonClearAll;
    private Button buttonClose;
    private CheckBox cbCultureInfo;
    private CheckBox cbRegionInfo;
    private CheckBox cbNumberFormatInfo;
    private Label labelCI;
    private Label labelRI;
    private Label labelNFI;
    private Label labelDTFI;
    private CheckBox cbDateTimeFormatInfo;
    private Label labelTI;
    private CheckBox cbTextInfo;
    private Label labelCalendar;
    private CheckBox cbCalendar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ClassInfoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

      labelCI.BackColor       = ProgramSettings.colorCultureInfo;
      labelRI.BackColor       = ProgramSettings.colorRegionInfo;
      labelNFI.BackColor      = ProgramSettings.colorNumberFormatInfo;
      labelDTFI.BackColor     = ProgramSettings.colorDateTimeFormatInfo;
      labelTI.BackColor       = ProgramSettings.colorTextInfo;
      labelCalendar.BackColor = ProgramSettings.colorCalendar;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassInfoForm));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.labelTI = new System.Windows.Forms.Label();
      this.cbTextInfo = new System.Windows.Forms.CheckBox();
      this.labelDTFI = new System.Windows.Forms.Label();
      this.labelNFI = new System.Windows.Forms.Label();
      this.labelRI = new System.Windows.Forms.Label();
      this.labelCI = new System.Windows.Forms.Label();
      this.cbDateTimeFormatInfo = new System.Windows.Forms.CheckBox();
      this.cbNumberFormatInfo = new System.Windows.Forms.CheckBox();
      this.cbRegionInfo = new System.Windows.Forms.CheckBox();
      this.cbCultureInfo = new System.Windows.Forms.CheckBox();
      this.buttonSelectAll = new System.Windows.Forms.Button();
      this.buttonClearAll = new System.Windows.Forms.Button();
      this.buttonClose = new System.Windows.Forms.Button();
      this.cbCalendar = new System.Windows.Forms.CheckBox();
      this.labelCalendar = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.labelCalendar);
      this.groupBox1.Controls.Add(this.cbCalendar);
      this.groupBox1.Controls.Add(this.labelTI);
      this.groupBox1.Controls.Add(this.cbTextInfo);
      this.groupBox1.Controls.Add(this.labelDTFI);
      this.groupBox1.Controls.Add(this.labelNFI);
      this.groupBox1.Controls.Add(this.labelRI);
      this.groupBox1.Controls.Add(this.labelCI);
      this.groupBox1.Controls.Add(this.cbDateTimeFormatInfo);
      this.groupBox1.Controls.Add(this.cbNumberFormatInfo);
      this.groupBox1.Controls.Add(this.cbRegionInfo);
      this.groupBox1.Controls.Add(this.cbCultureInfo);
      this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // labelTI
      // 
      this.labelTI.BackColor = System.Drawing.Color.Thistle;
      this.labelTI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.labelTI, "labelTI");
      this.labelTI.Name = "labelTI";
      // 
      // cbTextInfo
      // 
      resources.ApplyResources(this.cbTextInfo, "cbTextInfo");
      this.cbTextInfo.Name = "cbTextInfo";
      this.cbTextInfo.CheckedChanged += new System.EventHandler(this.cbTextInfo_CheckedChanged);
      // 
      // labelDTFI
      // 
      this.labelDTFI.BackColor = System.Drawing.Color.Khaki;
      this.labelDTFI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.labelDTFI, "labelDTFI");
      this.labelDTFI.Name = "labelDTFI";
      // 
      // labelNFI
      // 
      this.labelNFI.BackColor = System.Drawing.Color.Chartreuse;
      this.labelNFI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.labelNFI, "labelNFI");
      this.labelNFI.Name = "labelNFI";
      // 
      // labelRI
      // 
      this.labelRI.BackColor = System.Drawing.Color.Tomato;
      this.labelRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.labelRI, "labelRI");
      this.labelRI.Name = "labelRI";
      // 
      // labelCI
      // 
      this.labelCI.BackColor = System.Drawing.Color.LightSteelBlue;
      this.labelCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.labelCI, "labelCI");
      this.labelCI.Name = "labelCI";
      // 
      // cbDateTimeFormatInfo
      // 
      resources.ApplyResources(this.cbDateTimeFormatInfo, "cbDateTimeFormatInfo");
      this.cbDateTimeFormatInfo.Name = "cbDateTimeFormatInfo";
      this.cbDateTimeFormatInfo.CheckedChanged += new System.EventHandler(this.cbDateTimeFormatInfo_CheckedChanged);
      // 
      // cbNumberFormatInfo
      // 
      resources.ApplyResources(this.cbNumberFormatInfo, "cbNumberFormatInfo");
      this.cbNumberFormatInfo.Name = "cbNumberFormatInfo";
      this.cbNumberFormatInfo.CheckedChanged += new System.EventHandler(this.cbNumberFormatInfo_CheckedChanged);
      // 
      // cbRegionInfo
      // 
      resources.ApplyResources(this.cbRegionInfo, "cbRegionInfo");
      this.cbRegionInfo.Name = "cbRegionInfo";
      this.cbRegionInfo.CheckedChanged += new System.EventHandler(this.cbRegionInfo_CheckedChanged);
      // 
      // cbCultureInfo
      // 
      resources.ApplyResources(this.cbCultureInfo, "cbCultureInfo");
      this.cbCultureInfo.Name = "cbCultureInfo";
      this.cbCultureInfo.CheckedChanged += new System.EventHandler(this.cbCultureInfo_CheckedChanged);
      // 
      // buttonSelectAll
      // 
      resources.ApplyResources(this.buttonSelectAll, "buttonSelectAll");
      this.buttonSelectAll.Name = "buttonSelectAll";
      this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
      // 
      // buttonClearAll
      // 
      resources.ApplyResources(this.buttonClearAll, "buttonClearAll");
      this.buttonClearAll.Name = "buttonClearAll";
      this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
      // 
      // buttonClose
      // 
      resources.ApplyResources(this.buttonClose, "buttonClose");
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // cbCalendar
      // 
      resources.ApplyResources(this.cbCalendar, "cbCalendar");
      this.cbCalendar.Name = "cbCalendar";
      this.cbCalendar.CheckedChanged += new System.EventHandler(this.cbCalendar_CheckedChanged);
      // 
      // labelCalendar
      // 
      this.labelCalendar.BackColor = System.Drawing.Color.Tan;
      this.labelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.labelCalendar, "labelCalendar");
      this.labelCalendar.Name = "labelCalendar";
      // 
      // ClassInfoForm
      // 
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.buttonClearAll);
      this.Controls.Add(this.buttonSelectAll);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ClassInfoForm";
      this.ShowInTaskbar = false;
      this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

    public void SetMainForm(MainForm mainForm)
    {
      myMainForm = mainForm;
    }

    private void buttonSelectAll_Click(object sender, System.EventArgs e)
    {
      cbCultureInfo.Checked        = true;
      cbRegionInfo.Checked         = true;
      cbNumberFormatInfo.Checked   = true;
      cbDateTimeFormatInfo.Checked = true;
      cbTextInfo.Checked           = true;
      cbCalendar.Checked           = true;
    }

    private void buttonClearAll_Click(object sender, System.EventArgs e)
    {
      cbCultureInfo.Checked        = false;
      cbRegionInfo.Checked         = false;
      cbNumberFormatInfo.Checked   = false;
      cbDateTimeFormatInfo.Checked = false;
      cbTextInfo.Checked           = false;
      cbCalendar.Checked           = false;
    }

    private void buttonClose_Click(object sender, System.EventArgs e)
    {
      this.Hide();
    }

    private void cbCultureInfo_CheckedChanged(object sender, System.EventArgs e)
    {
      myMainForm.NotifyClassColorChange(cbCultureInfo.Checked ? ProgramSettings.ClassColor.ApplyCultureInfo : ProgramSettings.ClassColor.ClearCultureInfo);
    }

    private void cbRegionInfo_CheckedChanged(object sender, System.EventArgs e)
    {
      myMainForm.NotifyClassColorChange(cbRegionInfo.Checked ? ProgramSettings.ClassColor.ApplyRegionInfo : ProgramSettings.ClassColor.ClearRegionInfo);
    }

    private void cbNumberFormatInfo_CheckedChanged(object sender, System.EventArgs e)
    {
      myMainForm.NotifyClassColorChange(cbNumberFormatInfo.Checked ? ProgramSettings.ClassColor.ApplyNumberFormatInfo : ProgramSettings.ClassColor.ClearNumberFormatInfo);
    }

    private void cbDateTimeFormatInfo_CheckedChanged(object sender, System.EventArgs e)
    {
      myMainForm.NotifyClassColorChange(cbDateTimeFormatInfo.Checked ? ProgramSettings.ClassColor.ApplyDateTimeFormatInfo : ProgramSettings.ClassColor.ClearDateTimeFormatInfo);
    }

    private void cbTextInfo_CheckedChanged(object sender, EventArgs e)
    {
      myMainForm.NotifyClassColorChange(cbTextInfo.Checked ? ProgramSettings.ClassColor.ApplyTextInfo : ProgramSettings.ClassColor.ClearTextInfo);
    }

    private void cbCalendar_CheckedChanged(object sender, EventArgs e)
    {
      myMainForm.NotifyClassColorChange(cbCalendar.Checked ? ProgramSettings.ClassColor.ApplyCalendar : ProgramSettings.ClassColor.ClearCalendar);
    }

    private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }

  }
}
