using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using System.Text;

namespace CultureExplorer20
{
	/// <summary>
	/// Summary description for NumberFormat.
	/// </summary>
	public class NumberFormatForm : System.Windows.Forms.Form
	{
    private Label labelDecimalDigits;
    private Label labelGroupSizes;
    private Label labelGroupSeparator;
    private Label labelPositiveSign;
    private Label labelPositiveInfinity;
    private Label labelNegativeSign;
    private Label labelNegativeInfinity;
    private Label labelNegativePattern;
    private Label labelDecimalSeparator;
    private Label labelNAN;
    private Label labelDigitSubstitution;
    private CultureExplorerLabel DecimalDigits;
    private CultureExplorerLabel GroupSizes;
    private CultureExplorerLabel GroupSeparator;
    private CultureExplorerLabel PositiveSign;
    private CultureExplorerLabel PositiveInfinity;
    private CultureExplorerLabel NegativeSign;
    private CultureExplorerLabel NegativeInfinity;
    private CultureExplorerLabel NegativePattern;
    private CultureExplorerLabel DecimalSeparator;
    private CultureExplorerLabel NAN;
    private CultureExplorerLabel DigitSubstitution;
    private GroupBox groupDigits;
    private GroupBox groupSymbols;
    private Button buttonClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NumberFormatForm(CultureInfo ci)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

      UpdateCulture(ci);
    }

    public void UpdateCulture(CultureInfo ci)
    {
      if (null == ci)
      {
        DecimalDigits.Text     = String.Empty;
        DecimalSeparator.Text  = String.Empty;
        GroupSeparator.Text    = String.Empty;
        NegativePattern.Text   = String.Empty;
        PositiveSign.Text      = String.Empty;
        PositiveInfinity.Text  = String.Empty;
        NegativeSign.Text      = String.Empty;
        NegativeInfinity.Text  = String.Empty;
        NAN.Text               = String.Empty;
        GroupSizes.Text        = String.Empty;
        DigitSubstitution.Text = String.Empty;
      }
      else if (ci.IsNeutralCulture)
      {
        // Set values for information labels
        DecimalDigits.Text     = Properties.Resources.NotAvailable;
        DecimalSeparator.Text  = Properties.Resources.NotAvailable;
        GroupSeparator.Text    = Properties.Resources.NotAvailable;
        NegativePattern.Text   = Properties.Resources.NotAvailable;
        PositiveSign.Text      = Properties.Resources.NotAvailable;
        PositiveInfinity.Text  = Properties.Resources.NotAvailable;
        NegativeSign.Text      = Properties.Resources.NotAvailable;
        NegativeInfinity.Text  = Properties.Resources.NotAvailable;
        NAN.Text               = Properties.Resources.NotAvailable;
        GroupSizes.Text        = Properties.Resources.NotAvailable;
        DigitSubstitution.Text = Properties.Resources.NotAvailable;
      }
      else
      {
        DecimalDigits.Text     = ci.NumberFormat.NumberDecimalDigits.ToString(ci);
        DecimalSeparator.Text  = ci.NumberFormat.NumberDecimalSeparator.ToString(ci);
        GroupSeparator.Text    = ci.NumberFormat.NumberGroupSeparator.ToString(ci);
        NegativePattern.Text   = ci.NumberFormat.NumberNegativePattern.ToString(ci);
        PositiveSign.Text      = ci.NumberFormat.PositiveSign;
        PositiveInfinity.Text  = ci.NumberFormat.PositiveInfinitySymbol;
        NegativeSign.Text      = ci.NumberFormat.NegativeSign;
        NegativeInfinity.Text  = ci.NumberFormat.NegativeInfinitySymbol;
        NAN.Text               = ci.NumberFormat.NaNSymbol;

        // get digit substitution information
        switch (ci.NumberFormat.DigitSubstitution)
        {
          case DigitShapes.Context:
            DigitSubstitution.Text = Properties.Resources.DigitShapesContext;
            break;

          case DigitShapes.NativeNational:
            DigitSubstitution.Text = Properties.Resources.DigitShapesNativeNational;
            break;

          case DigitShapes.None:
            DigitSubstitution.Text = Properties.Resources.DigitShapesNone;
            break;
        }

        // parse group sizes
        StringBuilder sb = new StringBuilder();
        int i;
        for(i = 0; i < ci.NumberFormat.NumberGroupSizes.GetLength(0) - 1; i++)
        {
          sb.Append(ci.NumberFormat.NumberGroupSizes[i].ToString(ci));
          sb.Append(ci.TextInfo.ListSeparator);
        }
        sb.Append(ci.NumberFormat.NumberGroupSizes[i].ToString(ci));
        GroupSizes.Text = sb.ToString();
		  }
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberFormatForm));
      this.labelPositiveInfinity = new System.Windows.Forms.Label();
      this.labelGroupSizes = new System.Windows.Forms.Label();
      this.DecimalDigits = new CultureExplorer20.CultureExplorerLabel();
      this.PositiveSign = new CultureExplorer20.CultureExplorerLabel();
      this.DecimalSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.labelNegativePattern = new System.Windows.Forms.Label();
      this.labelPositiveSign = new System.Windows.Forms.Label();
      this.labelNAN = new System.Windows.Forms.Label();
      this.labelGroupSeparator = new System.Windows.Forms.Label();
      this.NAN = new CultureExplorer20.CultureExplorerLabel();
      this.labelDecimalDigits = new System.Windows.Forms.Label();
      this.groupDigits = new System.Windows.Forms.GroupBox();
      this.NegativePattern = new CultureExplorer20.CultureExplorerLabel();
      this.GroupSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.GroupSizes = new CultureExplorer20.CultureExplorerLabel();
      this.labelDecimalSeparator = new System.Windows.Forms.Label();
      this.groupSymbols = new System.Windows.Forms.GroupBox();
      this.NegativeInfinity = new CultureExplorer20.CultureExplorerLabel();
      this.NegativeSign = new CultureExplorer20.CultureExplorerLabel();
      this.PositiveInfinity = new CultureExplorer20.CultureExplorerLabel();
      this.labelNegativeSign = new System.Windows.Forms.Label();
      this.labelNegativeInfinity = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.labelDigitSubstitution = new System.Windows.Forms.Label();
      this.DigitSubstitution = new CultureExplorer20.CultureExplorerLabel();
      this.groupDigits.SuspendLayout();
      this.groupSymbols.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelPositiveInfinity
      // 
      this.labelPositiveInfinity.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelPositiveInfinity, "labelPositiveInfinity");
      this.labelPositiveInfinity.Name = "labelPositiveInfinity";
      // 
      // labelGroupSizes
      // 
      this.labelGroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelGroupSizes, "labelGroupSizes");
      this.labelGroupSizes.Name = "labelGroupSizes";
      // 
      // DecimalDigits
      // 
      this.DecimalDigits.BackColor = System.Drawing.SystemColors.Info;
      this.DecimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DecimalDigits.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.DecimalDigits, "DecimalDigits");
      this.DecimalDigits.Name = "DecimalDigits";
      // 
      // PositiveSign
      // 
      this.PositiveSign.BackColor = System.Drawing.SystemColors.Info;
      this.PositiveSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PositiveSign.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.PositiveSign, "PositiveSign");
      this.PositiveSign.Name = "PositiveSign";
      // 
      // DecimalSeparator
      // 
      this.DecimalSeparator.BackColor = System.Drawing.SystemColors.Info;
      this.DecimalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DecimalSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.DecimalSeparator, "DecimalSeparator");
      this.DecimalSeparator.Name = "DecimalSeparator";
      // 
      // labelNegativePattern
      // 
      this.labelNegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelNegativePattern, "labelNegativePattern");
      this.labelNegativePattern.Name = "labelNegativePattern";
      // 
      // labelPositiveSign
      // 
      this.labelPositiveSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelPositiveSign, "labelPositiveSign");
      this.labelPositiveSign.Name = "labelPositiveSign";
      // 
      // labelNAN
      // 
      this.labelNAN.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelNAN, "labelNAN");
      this.labelNAN.Name = "labelNAN";
      // 
      // labelGroupSeparator
      // 
      this.labelGroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelGroupSeparator, "labelGroupSeparator");
      this.labelGroupSeparator.Name = "labelGroupSeparator";
      // 
      // NAN
      // 
      this.NAN.BackColor = System.Drawing.SystemColors.Info;
      this.NAN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NAN.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.NAN, "NAN");
      this.NAN.Name = "NAN";
      // 
      // labelDecimalDigits
      // 
      this.labelDecimalDigits.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelDecimalDigits, "labelDecimalDigits");
      this.labelDecimalDigits.Name = "labelDecimalDigits";
      // 
      // groupDigits
      // 
      this.groupDigits.Controls.Add(this.DigitSubstitution);
      this.groupDigits.Controls.Add(this.labelDigitSubstitution);
      this.groupDigits.Controls.Add(this.NegativePattern);
      this.groupDigits.Controls.Add(this.labelNegativePattern);
      this.groupDigits.Controls.Add(this.GroupSeparator);
      this.groupDigits.Controls.Add(this.GroupSizes);
      this.groupDigits.Controls.Add(this.labelGroupSizes);
      this.groupDigits.Controls.Add(this.labelGroupSeparator);
      this.groupDigits.Controls.Add(this.DecimalSeparator);
      this.groupDigits.Controls.Add(this.labelDecimalSeparator);
      this.groupDigits.Controls.Add(this.DecimalDigits);
      this.groupDigits.Controls.Add(this.labelDecimalDigits);
      this.groupDigits.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupDigits, "groupDigits");
      this.groupDigits.Name = "groupDigits";
      this.groupDigits.TabStop = false;
      // 
      // NegativePattern
      // 
      this.NegativePattern.BackColor = System.Drawing.SystemColors.Info;
      this.NegativePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NegativePattern.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.NegativePattern, "NegativePattern");
      this.NegativePattern.Name = "NegativePattern";
      // 
      // GroupSeparator
      // 
      this.GroupSeparator.BackColor = System.Drawing.SystemColors.Info;
      this.GroupSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.GroupSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.GroupSeparator, "GroupSeparator");
      this.GroupSeparator.Name = "GroupSeparator";
      // 
      // GroupSizes
      // 
      this.GroupSizes.BackColor = System.Drawing.SystemColors.Info;
      this.GroupSizes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.GroupSizes.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.GroupSizes, "GroupSizes");
      this.GroupSizes.Name = "GroupSizes";
      // 
      // labelDecimalSeparator
      // 
      this.labelDecimalSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelDecimalSeparator, "labelDecimalSeparator");
      this.labelDecimalSeparator.Name = "labelDecimalSeparator";
      // 
      // groupSymbols
      // 
      this.groupSymbols.Controls.Add(this.NAN);
      this.groupSymbols.Controls.Add(this.NegativeInfinity);
      this.groupSymbols.Controls.Add(this.NegativeSign);
      this.groupSymbols.Controls.Add(this.PositiveInfinity);
      this.groupSymbols.Controls.Add(this.PositiveSign);
      this.groupSymbols.Controls.Add(this.labelNAN);
      this.groupSymbols.Controls.Add(this.labelPositiveSign);
      this.groupSymbols.Controls.Add(this.labelPositiveInfinity);
      this.groupSymbols.Controls.Add(this.labelNegativeSign);
      this.groupSymbols.Controls.Add(this.labelNegativeInfinity);
      this.groupSymbols.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupSymbols, "groupSymbols");
      this.groupSymbols.Name = "groupSymbols";
      this.groupSymbols.TabStop = false;
      // 
      // NegativeInfinity
      // 
      this.NegativeInfinity.BackColor = System.Drawing.SystemColors.Info;
      this.NegativeInfinity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NegativeInfinity.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.NegativeInfinity, "NegativeInfinity");
      this.NegativeInfinity.Name = "NegativeInfinity";
      // 
      // NegativeSign
      // 
      this.NegativeSign.BackColor = System.Drawing.SystemColors.Info;
      this.NegativeSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NegativeSign.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.NegativeSign, "NegativeSign");
      this.NegativeSign.Name = "NegativeSign";
      // 
      // PositiveInfinity
      // 
      this.PositiveInfinity.BackColor = System.Drawing.SystemColors.Info;
      this.PositiveInfinity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PositiveInfinity.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.PositiveInfinity, "PositiveInfinity");
      this.PositiveInfinity.Name = "PositiveInfinity";
      // 
      // labelNegativeSign
      // 
      this.labelNegativeSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelNegativeSign, "labelNegativeSign");
      this.labelNegativeSign.Name = "labelNegativeSign";
      // 
      // labelNegativeInfinity
      // 
      this.labelNegativeInfinity.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelNegativeInfinity, "labelNegativeInfinity");
      this.labelNegativeInfinity.Name = "labelNegativeInfinity";
      // 
      // buttonClose
      // 
      resources.ApplyResources(this.buttonClose, "buttonClose");
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // labelDigitSubstitution
      // 
      resources.ApplyResources(this.labelDigitSubstitution, "labelDigitSubstitution");
      this.labelDigitSubstitution.Name = "labelDigitSubstitution";
      // 
      // DigitSubstitution
      // 
      this.DigitSubstitution.BackColor = System.Drawing.SystemColors.Info;
      this.DigitSubstitution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DigitSubstitution.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.DigitSubstitution, "DigitSubstitution");
      this.DigitSubstitution.Name = "DigitSubstitution";
      // 
      // NumberFormatForm
      // 
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.groupSymbols);
      this.Controls.Add(this.groupDigits);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NumberFormatForm";
      this.ShowInTaskbar = false;
      this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
      this.groupDigits.ResumeLayout(false);
      this.groupDigits.PerformLayout();
      this.groupSymbols.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

    public void ClassColor(ProgramSettings.ClassColor cc)
    {
      switch(cc)
      {
        case ProgramSettings.ClassColor.ApplyNumberFormatInfo:
          ColorNFI(ProgramSettings.colorNumberFormatInfo);
          break;

        case ProgramSettings.ClassColor.ClearNumberFormatInfo:
          ColorNFI(ProgramSettings.colorNone);
          break;
      }
    }

    private void ColorNFI(Color color)
    {
      DecimalDigits.BackColor     = color;
      DecimalSeparator.BackColor  = color;
      GroupSeparator.BackColor    = color;
      NegativePattern.BackColor   = color;
      PositiveSign.BackColor      = color;
      PositiveInfinity.BackColor  = color;
      NegativeSign.BackColor      = color;
      NegativeInfinity.BackColor  = color;
      NAN.BackColor               = color;
      GroupSizes.BackColor        = color;
      DigitSubstitution.BackColor = color;
    }

    private void buttonClose_Click(object sender, System.EventArgs e)
    {
      Hide();
    }

    private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }
	}
}
