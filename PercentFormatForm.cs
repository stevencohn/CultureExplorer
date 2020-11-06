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
	/// Summary description for PercentFormatForm.
	/// </summary>
	public class PercentFormatForm : System.Windows.Forms.Form
	{
    private Button buttonClose;
    private GroupBox groupPercent;
    private Label labelSymbol;
    private Label labelDecimalDigits;
    private Label labelDecimalSeparator;
    private Label labelGroupSizes;
    private Label labelGroupSeparator;
    private Label labelNegativePattern;
    private Label labelPositivePattern;
    private CultureExplorerLabel Symbol;
    private CultureExplorerLabel DecimalDigits;
    private CultureExplorerLabel DecimalSeparator;
    private CultureExplorerLabel GroupSizes;
    private CultureExplorerLabel GroupSeparator;
    private CultureExplorerLabel PositivePattern;
    private CultureExplorerLabel NegativePattern;
    private CultureExplorerLabel labelPerMille;
    private CultureExplorerLabel PerMille;
    private GroupBox groupPerMille;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PercentFormatForm(CultureInfo ci)
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
        Symbol.Text           = String.Empty;
        DecimalDigits.Text    = String.Empty;
        DecimalSeparator.Text = String.Empty;
        GroupSeparator.Text   = String.Empty;
        PositivePattern.Text  = String.Empty;
        NegativePattern.Text  = String.Empty;
        PerMille.Text         = String.Empty;
        GroupSizes.Text       = String.Empty;
      }
      else if (ci.IsNeutralCulture)
      {
        Symbol.Text           = Properties.Resources.NotAvailable;
        DecimalDigits.Text    = Properties.Resources.NotAvailable;
        DecimalSeparator.Text = Properties.Resources.NotAvailable;
        GroupSeparator.Text   = Properties.Resources.NotAvailable;
        PositivePattern.Text  = Properties.Resources.NotAvailable;
        NegativePattern.Text  = Properties.Resources.NotAvailable;
        PerMille.Text         = Properties.Resources.NotAvailable;
        GroupSizes.Text       = Properties.Resources.NotAvailable;
      }
      else
      {
        // Set values for information labels
        Symbol.Text           = ci.NumberFormat.PercentSymbol;
        DecimalDigits.Text    = ci.NumberFormat.PercentDecimalDigits.ToString(ci);
        DecimalSeparator.Text = ci.NumberFormat.PercentDecimalSeparator.ToString(ci);
        GroupSeparator.Text   = ci.NumberFormat.PercentGroupSeparator.ToString(ci);
        PositivePattern.Text  = ci.NumberFormat.PercentPositivePattern.ToString(ci);
        NegativePattern.Text  = ci.NumberFormat.PercentNegativePattern.ToString(ci);
        PerMille.Text         = ci.NumberFormat.PerMilleSymbol;

        // parse group sizes
        StringBuilder sb = new StringBuilder();
        int NumGroupSizes = ci.NumberFormat.PercentGroupSizes.GetLength(0);
        int i;
        for(i = 0; i < NumGroupSizes - 1; i++)
        {
          sb.Append(ci.NumberFormat.PercentGroupSizes[i].ToString(ci));
          sb.Append(ci.TextInfo.ListSeparator);
        }
        sb.Append(ci.NumberFormat.PercentGroupSizes[i].ToString(ci));
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentFormatForm));
      this.labelGroupSeparator = new System.Windows.Forms.Label();
      this.NegativePattern = new CultureExplorer20.CultureExplorerLabel();
      this.groupPerMille = new System.Windows.Forms.GroupBox();
      this.labelPerMille = new CultureExplorer20.CultureExplorerLabel();
      this.PerMille = new CultureExplorer20.CultureExplorerLabel();
      this.labelDecimalSeparator = new System.Windows.Forms.Label();
      this.labelDecimalDigits = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.PositivePattern = new CultureExplorer20.CultureExplorerLabel();
      this.GroupSizes = new CultureExplorer20.CultureExplorerLabel();
      this.labelNegativePattern = new System.Windows.Forms.Label();
      this.DecimalDigits = new CultureExplorer20.CultureExplorerLabel();
      this.GroupSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.Symbol = new CultureExplorer20.CultureExplorerLabel();
      this.DecimalSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.labelSymbol = new System.Windows.Forms.Label();
      this.labelGroupSizes = new System.Windows.Forms.Label();
      this.groupPercent = new System.Windows.Forms.GroupBox();
      this.labelPositivePattern = new System.Windows.Forms.Label();
      this.groupPerMille.SuspendLayout();
      this.groupPercent.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelGroupSeparator
      // 
      this.labelGroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelGroupSeparator, "labelGroupSeparator");
      this.labelGroupSeparator.Name = "labelGroupSeparator";
      // 
      // NegativePattern
      // 
      this.NegativePattern.BackColor = System.Drawing.SystemColors.Info;
      this.NegativePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NegativePattern.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NegativePattern, "NegativePattern");
      this.NegativePattern.Name = "NegativePattern";
      // 
      // groupPerMille
      // 
      this.groupPerMille.BackColor = System.Drawing.SystemColors.Control;
      this.groupPerMille.Controls.Add(this.labelPerMille);
      this.groupPerMille.Controls.Add(this.PerMille);
      this.groupPerMille.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupPerMille, "groupPerMille");
      this.groupPerMille.Name = "groupPerMille";
      this.groupPerMille.TabStop = false;
      // 
      // labelPerMille
      // 
      this.labelPerMille.Cursor = System.Windows.Forms.Cursors.Hand;
      this.labelPerMille.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelPerMille, "labelPerMille");
      this.labelPerMille.Name = "labelPerMille";
      // 
      // PerMille
      // 
      this.PerMille.BackColor = System.Drawing.SystemColors.Info;
      this.PerMille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PerMille.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PerMille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.PerMille, "PerMille");
      this.PerMille.Name = "PerMille";
      // 
      // labelDecimalSeparator
      // 
      this.labelDecimalSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelDecimalSeparator, "labelDecimalSeparator");
      this.labelDecimalSeparator.Name = "labelDecimalSeparator";
      // 
      // labelDecimalDigits
      // 
      this.labelDecimalDigits.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelDecimalDigits, "labelDecimalDigits");
      this.labelDecimalDigits.Name = "labelDecimalDigits";
      // 
      // buttonClose
      // 
      resources.ApplyResources(this.buttonClose, "buttonClose");
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // PositivePattern
      // 
      this.PositivePattern.BackColor = System.Drawing.SystemColors.Info;
      this.PositivePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PositivePattern.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PositivePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.PositivePattern, "PositivePattern");
      this.PositivePattern.Name = "PositivePattern";
      // 
      // GroupSizes
      // 
      this.GroupSizes.BackColor = System.Drawing.SystemColors.Info;
      this.GroupSizes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.GroupSizes.Cursor = System.Windows.Forms.Cursors.Hand;
      this.GroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.GroupSizes, "GroupSizes");
      this.GroupSizes.Name = "GroupSizes";
      // 
      // labelNegativePattern
      // 
      this.labelNegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelNegativePattern, "labelNegativePattern");
      this.labelNegativePattern.Name = "labelNegativePattern";
      // 
      // DecimalDigits
      // 
      this.DecimalDigits.BackColor = System.Drawing.SystemColors.Info;
      this.DecimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DecimalDigits.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DecimalDigits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.DecimalDigits, "DecimalDigits");
      this.DecimalDigits.Name = "DecimalDigits";
      // 
      // GroupSeparator
      // 
      this.GroupSeparator.BackColor = System.Drawing.SystemColors.Info;
      this.GroupSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.GroupSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
      this.GroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.GroupSeparator, "GroupSeparator");
      this.GroupSeparator.Name = "GroupSeparator";
      // 
      // Symbol
      // 
      this.Symbol.BackColor = System.Drawing.SystemColors.Info;
      this.Symbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Symbol.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Symbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.Symbol, "Symbol");
      this.Symbol.Name = "Symbol";
      // 
      // DecimalSeparator
      // 
      this.DecimalSeparator.BackColor = System.Drawing.SystemColors.Info;
      this.DecimalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DecimalSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DecimalSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.DecimalSeparator, "DecimalSeparator");
      this.DecimalSeparator.Name = "DecimalSeparator";
      // 
      // labelSymbol
      // 
      this.labelSymbol.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelSymbol, "labelSymbol");
      this.labelSymbol.Name = "labelSymbol";
      // 
      // labelGroupSizes
      // 
      this.labelGroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelGroupSizes, "labelGroupSizes");
      this.labelGroupSizes.Name = "labelGroupSizes";
      // 
      // groupPercent
      // 
      this.groupPercent.BackColor = System.Drawing.SystemColors.Control;
      this.groupPercent.Controls.Add(this.NegativePattern);
      this.groupPercent.Controls.Add(this.PositivePattern);
      this.groupPercent.Controls.Add(this.GroupSeparator);
      this.groupPercent.Controls.Add(this.GroupSizes);
      this.groupPercent.Controls.Add(this.DecimalSeparator);
      this.groupPercent.Controls.Add(this.DecimalDigits);
      this.groupPercent.Controls.Add(this.Symbol);
      this.groupPercent.Controls.Add(this.labelPositivePattern);
      this.groupPercent.Controls.Add(this.labelNegativePattern);
      this.groupPercent.Controls.Add(this.labelGroupSeparator);
      this.groupPercent.Controls.Add(this.labelGroupSizes);
      this.groupPercent.Controls.Add(this.labelDecimalSeparator);
      this.groupPercent.Controls.Add(this.labelDecimalDigits);
      this.groupPercent.Controls.Add(this.labelSymbol);
      this.groupPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupPercent, "groupPercent");
      this.groupPercent.Name = "groupPercent";
      this.groupPercent.TabStop = false;
      // 
      // labelPositivePattern
      // 
      this.labelPositivePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelPositivePattern, "labelPositivePattern");
      this.labelPositivePattern.Name = "labelPositivePattern";
      // 
      // PercentFormatForm
      // 
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.groupPerMille);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.groupPercent);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PercentFormatForm";
      this.ShowInTaskbar = false;
      this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
      this.groupPerMille.ResumeLayout(false);
      this.groupPercent.ResumeLayout(false);
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
      Symbol.BackColor           = color;
      DecimalDigits.BackColor    = color;
      DecimalSeparator.BackColor = color;
      GroupSeparator.BackColor   = color;
      PositivePattern.BackColor  = color;
      NegativePattern.BackColor  = color;
      PerMille.BackColor         = color;
      GroupSizes.BackColor       = color;
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
