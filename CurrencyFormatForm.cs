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
	/// Summary description for CurrencyFormatForm.
	/// </summary>
	public class CurrencyFormatForm : System.Windows.Forms.Form
	{
    private Button buttonClose;
    private GroupBox groupCurrency;
    private CultureExplorerLabel NegativePattern;
    private CultureExplorerLabel PositivePattern;
    private CultureExplorerLabel GroupSeparator;
    private CultureExplorerLabel GroupSizes;
    private CultureExplorerLabel DecimalSeparator;
    private CultureExplorerLabel DecimalDigits;
    private CultureExplorerLabel Symbol;
    private Label labelPositivePattern;
    private Label labelNegativePattern;
    private Label labelGroupSeparator;
    private Label labelGroupSizes;
    private Label labelDecimalSeparator;
    private Label labelDecimalDigits;
    private Label labelSymbol;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CurrencyFormatForm(CultureInfo ci)
		{
			InitializeComponent();
      UpdateCulture(ci);
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyFormatForm));
      this.buttonClose = new System.Windows.Forms.Button();
      this.groupCurrency = new System.Windows.Forms.GroupBox();
      this.labelPositivePattern = new System.Windows.Forms.Label();
      this.labelNegativePattern = new System.Windows.Forms.Label();
      this.labelGroupSeparator = new System.Windows.Forms.Label();
      this.labelGroupSizes = new System.Windows.Forms.Label();
      this.labelDecimalSeparator = new System.Windows.Forms.Label();
      this.labelDecimalDigits = new System.Windows.Forms.Label();
      this.labelSymbol = new System.Windows.Forms.Label();
      this.NegativePattern = new CultureExplorer20.CultureExplorerLabel();
      this.PositivePattern = new CultureExplorer20.CultureExplorerLabel();
      this.GroupSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.GroupSizes = new CultureExplorer20.CultureExplorerLabel();
      this.DecimalSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.DecimalDigits = new CultureExplorer20.CultureExplorerLabel();
      this.Symbol = new CultureExplorer20.CultureExplorerLabel();
      this.groupCurrency.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonClose
      // 
      resources.ApplyResources(this.buttonClose, "buttonClose");
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // groupCurrency
      // 
      this.groupCurrency.Controls.Add(this.NegativePattern);
      this.groupCurrency.Controls.Add(this.PositivePattern);
      this.groupCurrency.Controls.Add(this.GroupSeparator);
      this.groupCurrency.Controls.Add(this.GroupSizes);
      this.groupCurrency.Controls.Add(this.DecimalSeparator);
      this.groupCurrency.Controls.Add(this.DecimalDigits);
      this.groupCurrency.Controls.Add(this.Symbol);
      this.groupCurrency.Controls.Add(this.labelPositivePattern);
      this.groupCurrency.Controls.Add(this.labelNegativePattern);
      this.groupCurrency.Controls.Add(this.labelGroupSeparator);
      this.groupCurrency.Controls.Add(this.labelGroupSizes);
      this.groupCurrency.Controls.Add(this.labelDecimalSeparator);
      this.groupCurrency.Controls.Add(this.labelDecimalDigits);
      this.groupCurrency.Controls.Add(this.labelSymbol);
      this.groupCurrency.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupCurrency, "groupCurrency");
      this.groupCurrency.Name = "groupCurrency";
      this.groupCurrency.TabStop = false;
      // 
      // labelPositivePattern
      // 
      this.labelPositivePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelPositivePattern, "labelPositivePattern");
      this.labelPositivePattern.Name = "labelPositivePattern";
      // 
      // labelNegativePattern
      // 
      this.labelNegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelNegativePattern, "labelNegativePattern");
      this.labelNegativePattern.Name = "labelNegativePattern";
      // 
      // labelGroupSeparator
      // 
      this.labelGroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelGroupSeparator, "labelGroupSeparator");
      this.labelGroupSeparator.Name = "labelGroupSeparator";
      // 
      // labelGroupSizes
      // 
      this.labelGroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelGroupSizes, "labelGroupSizes");
      this.labelGroupSizes.Name = "labelGroupSizes";
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
      // labelSymbol
      // 
      this.labelSymbol.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.labelSymbol, "labelSymbol");
      this.labelSymbol.Name = "labelSymbol";
      // 
      // NegativePattern
      // 
      this.NegativePattern.BackColor = System.Drawing.SystemColors.Info;
      this.NegativePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NegativePattern.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.NegativePattern, "NegativePattern");
      this.NegativePattern.Name = "NegativePattern";
      // 
      // PositivePattern
      // 
      this.PositivePattern.BackColor = System.Drawing.SystemColors.Info;
      this.PositivePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PositivePattern.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.PositivePattern, "PositivePattern");
      this.PositivePattern.Name = "PositivePattern";
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
      // DecimalSeparator
      // 
      this.DecimalSeparator.BackColor = System.Drawing.SystemColors.Info;
      this.DecimalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DecimalSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.DecimalSeparator, "DecimalSeparator");
      this.DecimalSeparator.Name = "DecimalSeparator";
      // 
      // DecimalDigits
      // 
      this.DecimalDigits.BackColor = System.Drawing.SystemColors.Info;
      this.DecimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DecimalDigits.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.DecimalDigits, "DecimalDigits");
      this.DecimalDigits.Name = "DecimalDigits";
      // 
      // Symbol
      // 
      this.Symbol.BackColor = System.Drawing.SystemColors.Info;
      this.Symbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Symbol.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.Symbol, "Symbol");
      this.Symbol.Name = "Symbol";
      // 
      // CurrencyFormatForm
      // 
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.groupCurrency);
      this.Controls.Add(this.buttonClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "CurrencyFormatForm";
      this.ShowInTaskbar = false;
      this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
      this.groupCurrency.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

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
        GroupSizes.Text       = Properties.Resources.NotAvailable;
      }
      else
      {
        Symbol.Text           = ci.NumberFormat.CurrencySymbol;
        DecimalDigits.Text    = ci.NumberFormat.CurrencyDecimalDigits.ToString(ci);
        DecimalSeparator.Text = ci.NumberFormat.CurrencyDecimalSeparator.ToString(ci);
        GroupSeparator.Text   = ci.NumberFormat.CurrencyGroupSeparator.ToString(ci);
        PositivePattern.Text  = ci.NumberFormat.CurrencyPositivePattern.ToString(ci);
        NegativePattern.Text  = ci.NumberFormat.CurrencyNegativePattern.ToString(ci);

        // parse group sizes
        StringBuilder sb = new StringBuilder();
        int i;
        for(i = 0; i < ci.NumberFormat.CurrencyGroupSizes.GetLength(0) - 1; i++)
        {
          sb.Append(ci.NumberFormat.CurrencyGroupSizes[i].ToString(ci));
          sb.Append(ci.TextInfo.ListSeparator);
        }
        sb.Append(ci.NumberFormat.CurrencyGroupSizes[i].ToString(ci));
        GroupSizes.Text = sb.ToString();
      }
    }

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
      GroupSizes.BackColor       = color;
    }

    private void buttonClose_Click(object sender, System.EventArgs e)
    {
      Close();
    }

    private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }
	}
}
