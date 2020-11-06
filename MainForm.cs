using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace CultureExplorer20
{
	public class MainForm : System.Windows.Forms.Form
	{
		protected CultureInfo ci;

		protected NumberFormatForm NumberForm;
		protected CurrencyFormatForm CurrencyForm;
		protected PercentFormatForm PercentForm;
		protected CalendarForm CalendarForm;
		protected ClassInfoForm ClassForm;

		private TreeView treeCulture;
		private GroupBox groupName;
		private Label labelNameNative;
		private Label labelNameDisplay;
		private Label labelNameEnglish;
		private CultureExplorerLabel NameNative;
		private CultureExplorerLabel NameDisplay;
		private CultureExplorerLabel NameEnglish;

		private GroupBox groupLang;
		private Label labelIso2Lang;
		private Label labelIso3Lang;
		private Label labelWinLang;
		private CultureExplorerLabel IsoLang2;
		private CultureExplorerLabel IsoLang3;
    private CultureExplorerLabel WinLang;
		private GroupBox groupMoreInfo;
		private Label labelLCID;
    private CultureExplorerLabel LCID;
		private GroupBox groupRegion;
		private Label labelIso2Reg;
		private Label labelIso3Reg;
		private Label labelWinReg;
		private Label labelCurrencyISO;
		private Label labelMetricReg;
    private CultureExplorerLabel Iso2Reg;
    private CultureExplorerLabel Iso3Reg;
    private CultureExplorerLabel WinReg;
    private CultureExplorerLabel CurrencyISO;
    private CultureExplorerLabel MetricReg;
    private GroupBox groupDateTime;
		private Label labelCalendar;
		private Label labelDateTimeFormat;
		private ComboBox comboCalendar;
		private ComboBox comboDateTime;
		private LinkLabel DateTimeDetails;
		private GroupBox groupNumber;
		private CultureExplorerLabel NumberPositive;
    private CultureExplorerLabel NumberNegative;
		private Label labelNumberFormat;
		private ComboBox comboNumberFormat;
		private LinkLabel NumberDetails;
		private GroupBox groupCurrency;
    private CultureExplorerLabel CurrencyPositive;
    private CultureExplorerLabel CurrencyNegative;
		private LinkLabel CurrencyDetails;
		private GroupBox groupPercent;
    private CultureExplorerLabel PercentPositive;
    private CultureExplorerLabel PercentNegative;
		private LinkLabel PercentDetails;
		private Button ClassDetails;
		private Button About;
		private Button Exit;
    private ImageList imageList;
    private GroupBox groupText;
    private Label labelBidi;
    private CultureExplorerLabel BIDI;
    private Label labelListSeparator;
    private CultureExplorerLabel ListSeparator;
    private GroupBox groupCultures;
    private CheckBox checkReplacementCultures;
    private CheckBox checkSpecificCultures;
    private CheckBox checkNeutralCultures;
    private CheckBox checkFrameworkCultures;
    private CheckBox checkUserCustomCultures;
    private CheckBox checkWindowsOnlyCultures;
    private CheckBox checkInstalledWin32Cultures;
    private Label labelNeutralCulture;
    private CultureExplorerLabel NeutralCulture;
    private CultureExplorerLabel IETF;
    private Label labelIETF;
    private CheckBox checkAllCultures;
    private CultureExplorerLabel DateTimeText;
    private CultureExplorerLabel RINativeName;
    private CultureExplorerLabel RIName;
    private Label labelNativeName;
    private Label labelName;
    private Label labelCurrencySymbol;
    private CultureExplorerLabel GeoID;
    private Label labelGeoID;
    private CultureExplorerLabel CurrencySymbol;
    private Label labelCurrencyEnglishName;
    private CultureExplorerLabel CurrencyEnglishName;
    private GroupBox groupCurrencyInfo;
    private CultureExplorerLabel CurrencyNativeName;
    private Label labelCurrencyNativeName;
    private CultureExplorerLabel KeyboardLayoutID;
    private Label labelKeyboardLayoutID;
		private System.ComponentModel.IContainer components;

    #region constructor
    public MainForm()
		{
      // Required for Windows Form Designer support
			InitializeComponent();

			// create ancillary forms
      ci             = new CultureInfo("");
			NumberForm     = new NumberFormatForm(ci);
			CurrencyForm   = new CurrencyFormatForm(ci);
			PercentForm    = new PercentFormatForm(ci);
			CalendarForm   = new CalendarForm(ci);
      ClassForm      = new ClassInfoForm();
      ClassForm.SetMainForm(this);

			// load strings from resources for:
			// - invariant culture name
			// - date time format combo box entries
			// - number format combo box entries
			// note: the "d, D Decimal format" and "x, X Hexadecimal format" are 
			// not supported here for number formatting

      comboDateTime.Items.Add(Properties.Resources.DateFormat_D);
			comboDateTime.Items.Add(Properties.Resources.DateFormat_DC);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_F);
			comboDateTime.Items.Add(Properties.Resources.DateFormat_FC);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_G);
			comboDateTime.Items.Add(Properties.Resources.DateFormat_GC);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_M);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_R);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_S);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_T);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_TC);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_U);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_UC);
      comboDateTime.Items.Add(Properties.Resources.DateFormat_Y);
			comboDateTime.SelectedIndex = 3;      // set default to F: long date, long time
      comboNumberFormat.Items.Add(Properties.Resources.NumberFormat_NC);
      comboNumberFormat.Items.Add(Properties.Resources.NumberFormat_FC);
      comboNumberFormat.Items.Add(Properties.Resources.NumberFormat_EC);
      comboNumberFormat.Items.Add(Properties.Resources.NumberFormat_GC);
      comboNumberFormat.Items.Add(Properties.Resources.NumberFormat_RC);
			comboNumberFormat.SelectedIndex = 0;  // set default to n: number format

      // initialize image list used by culture tree (in same order as CultureTypeIcons enum in program.cs)
      imageList.ColorDepth = ColorDepth.Depth32Bit;
      imageList.ImageSize  = new Size(16, 16);
      imageList.Images.AddStrip(Properties.Resources.TreeViewIcons);

      // initialize culture tree indirectly by selecting the checkbox that we want checked
      checkFrameworkCultures.Checked = true;
    }
    #endregion

    protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.groupRegion = new System.Windows.Forms.GroupBox();
      this.GeoID = new CultureExplorer20.CultureExplorerLabel();
      this.labelGeoID = new System.Windows.Forms.Label();
      this.RINativeName = new CultureExplorer20.CultureExplorerLabel();
      this.RIName = new CultureExplorer20.CultureExplorerLabel();
      this.labelNativeName = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.MetricReg = new CultureExplorer20.CultureExplorerLabel();
      this.labelMetricReg = new System.Windows.Forms.Label();
      this.WinReg = new CultureExplorer20.CultureExplorerLabel();
      this.Iso3Reg = new CultureExplorer20.CultureExplorerLabel();
      this.labelIso3Reg = new System.Windows.Forms.Label();
      this.labelIso2Reg = new System.Windows.Forms.Label();
      this.labelWinReg = new System.Windows.Forms.Label();
      this.Iso2Reg = new CultureExplorer20.CultureExplorerLabel();
      this.labelCurrencySymbol = new System.Windows.Forms.Label();
      this.labelCurrencyISO = new System.Windows.Forms.Label();
      this.treeCulture = new System.Windows.Forms.TreeView();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.labelIso2Lang = new System.Windows.Forms.Label();
      this.groupDateTime = new System.Windows.Forms.GroupBox();
      this.DateTimeText = new CultureExplorer20.CultureExplorerLabel();
      this.DateTimeDetails = new System.Windows.Forms.LinkLabel();
      this.comboDateTime = new System.Windows.Forms.ComboBox();
      this.labelDateTimeFormat = new System.Windows.Forms.Label();
      this.labelCalendar = new System.Windows.Forms.Label();
      this.comboCalendar = new System.Windows.Forms.ComboBox();
      this.groupNumber = new System.Windows.Forms.GroupBox();
      this.comboNumberFormat = new System.Windows.Forms.ComboBox();
      this.labelNumberFormat = new System.Windows.Forms.Label();
      this.NumberDetails = new System.Windows.Forms.LinkLabel();
      this.NumberNegative = new CultureExplorer20.CultureExplorerLabel();
      this.NumberPositive = new CultureExplorer20.CultureExplorerLabel();
      this.labelNameEnglish = new System.Windows.Forms.Label();
      this.labelIso3Lang = new System.Windows.Forms.Label();
      this.CurrencyDetails = new System.Windows.Forms.LinkLabel();
      this.labelNameDisplay = new System.Windows.Forms.Label();
      this.labelNameNative = new System.Windows.Forms.Label();
      this.groupPercent = new System.Windows.Forms.GroupBox();
      this.PercentDetails = new System.Windows.Forms.LinkLabel();
      this.PercentNegative = new CultureExplorer20.CultureExplorerLabel();
      this.PercentPositive = new CultureExplorer20.CultureExplorerLabel();
      this.groupLang = new System.Windows.Forms.GroupBox();
      this.IETF = new CultureExplorer20.CultureExplorerLabel();
      this.WinLang = new CultureExplorer20.CultureExplorerLabel();
      this.labelIETF = new System.Windows.Forms.Label();
      this.labelWinLang = new System.Windows.Forms.Label();
      this.IsoLang2 = new CultureExplorer20.CultureExplorerLabel();
      this.IsoLang3 = new CultureExplorer20.CultureExplorerLabel();
      this.groupName = new System.Windows.Forms.GroupBox();
      this.NameEnglish = new CultureExplorer20.CultureExplorerLabel();
      this.NameDisplay = new CultureExplorer20.CultureExplorerLabel();
      this.NameNative = new CultureExplorer20.CultureExplorerLabel();
      this.Exit = new System.Windows.Forms.Button();
      this.groupCurrency = new System.Windows.Forms.GroupBox();
      this.CurrencyNegative = new CultureExplorer20.CultureExplorerLabel();
      this.CurrencyPositive = new CultureExplorer20.CultureExplorerLabel();
      this.groupMoreInfo = new System.Windows.Forms.GroupBox();
      this.KeyboardLayoutID = new CultureExplorer20.CultureExplorerLabel();
      this.labelKeyboardLayoutID = new System.Windows.Forms.Label();
      this.NeutralCulture = new CultureExplorer20.CultureExplorerLabel();
      this.labelLCID = new System.Windows.Forms.Label();
      this.labelNeutralCulture = new System.Windows.Forms.Label();
      this.LCID = new CultureExplorer20.CultureExplorerLabel();
      this.About = new System.Windows.Forms.Button();
      this.ClassDetails = new System.Windows.Forms.Button();
      this.groupText = new System.Windows.Forms.GroupBox();
      this.ListSeparator = new CultureExplorer20.CultureExplorerLabel();
      this.labelListSeparator = new System.Windows.Forms.Label();
      this.labelBidi = new System.Windows.Forms.Label();
      this.BIDI = new CultureExplorer20.CultureExplorerLabel();
      this.groupCultures = new System.Windows.Forms.GroupBox();
      this.checkAllCultures = new System.Windows.Forms.CheckBox();
      this.checkUserCustomCultures = new System.Windows.Forms.CheckBox();
      this.checkWindowsOnlyCultures = new System.Windows.Forms.CheckBox();
      this.checkInstalledWin32Cultures = new System.Windows.Forms.CheckBox();
      this.checkReplacementCultures = new System.Windows.Forms.CheckBox();
      this.checkSpecificCultures = new System.Windows.Forms.CheckBox();
      this.checkNeutralCultures = new System.Windows.Forms.CheckBox();
      this.checkFrameworkCultures = new System.Windows.Forms.CheckBox();
      this.labelCurrencyEnglishName = new System.Windows.Forms.Label();
      this.groupCurrencyInfo = new System.Windows.Forms.GroupBox();
      this.CurrencyNativeName = new CultureExplorer20.CultureExplorerLabel();
      this.labelCurrencyNativeName = new System.Windows.Forms.Label();
      this.CurrencyEnglishName = new CultureExplorer20.CultureExplorerLabel();
      this.CurrencyISO = new CultureExplorer20.CultureExplorerLabel();
      this.CurrencySymbol = new CultureExplorer20.CultureExplorerLabel();
      this.groupRegion.SuspendLayout();
      this.groupDateTime.SuspendLayout();
      this.groupNumber.SuspendLayout();
      this.groupPercent.SuspendLayout();
      this.groupLang.SuspendLayout();
      this.groupName.SuspendLayout();
      this.groupCurrency.SuspendLayout();
      this.groupMoreInfo.SuspendLayout();
      this.groupText.SuspendLayout();
      this.groupCultures.SuspendLayout();
      this.groupCurrencyInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupRegion
      // 
      this.groupRegion.Controls.Add(this.GeoID);
      this.groupRegion.Controls.Add(this.labelGeoID);
      this.groupRegion.Controls.Add(this.RINativeName);
      this.groupRegion.Controls.Add(this.RIName);
      this.groupRegion.Controls.Add(this.labelNativeName);
      this.groupRegion.Controls.Add(this.labelName);
      this.groupRegion.Controls.Add(this.MetricReg);
      this.groupRegion.Controls.Add(this.labelMetricReg);
      this.groupRegion.Controls.Add(this.WinReg);
      this.groupRegion.Controls.Add(this.Iso3Reg);
      this.groupRegion.Controls.Add(this.labelIso3Reg);
      this.groupRegion.Controls.Add(this.labelIso2Reg);
      this.groupRegion.Controls.Add(this.labelWinReg);
      this.groupRegion.Controls.Add(this.Iso2Reg);
      this.groupRegion.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupRegion, "groupRegion");
      this.groupRegion.Name = "groupRegion";
      this.groupRegion.TabStop = false;
      // 
      // GeoID
      // 
      this.GeoID.BackColor = System.Drawing.SystemColors.Info;
      this.GeoID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.GeoID.Cursor = System.Windows.Forms.Cursors.Hand;
      this.GeoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.GeoID, "GeoID");
      this.GeoID.Name = "GeoID";
      // 
      // labelGeoID
      // 
      resources.ApplyResources(this.labelGeoID, "labelGeoID");
      this.labelGeoID.Name = "labelGeoID";
      // 
      // RINativeName
      // 
      this.RINativeName.BackColor = System.Drawing.SystemColors.Info;
      this.RINativeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.RINativeName.Cursor = System.Windows.Forms.Cursors.Hand;
      this.RINativeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.RINativeName, "RINativeName");
      this.RINativeName.Name = "RINativeName";
      // 
      // RIName
      // 
      this.RIName.BackColor = System.Drawing.SystemColors.Info;
      this.RIName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.RIName.Cursor = System.Windows.Forms.Cursors.Hand;
      this.RIName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.RIName, "RIName");
      this.RIName.Name = "RIName";
      // 
      // labelNativeName
      // 
      resources.ApplyResources(this.labelNativeName, "labelNativeName");
      this.labelNativeName.Name = "labelNativeName";
      // 
      // labelName
      // 
      resources.ApplyResources(this.labelName, "labelName");
      this.labelName.Name = "labelName";
      // 
      // MetricReg
      // 
      this.MetricReg.BackColor = System.Drawing.SystemColors.Info;
      this.MetricReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.MetricReg.Cursor = System.Windows.Forms.Cursors.Hand;
      this.MetricReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.MetricReg, "MetricReg");
      this.MetricReg.Name = "MetricReg";
      // 
      // labelMetricReg
      // 
      this.labelMetricReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelMetricReg, "labelMetricReg");
      this.labelMetricReg.Name = "labelMetricReg";
      // 
      // WinReg
      // 
      this.WinReg.BackColor = System.Drawing.SystemColors.Info;
      this.WinReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.WinReg.Cursor = System.Windows.Forms.Cursors.Hand;
      this.WinReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.WinReg, "WinReg");
      this.WinReg.Name = "WinReg";
      // 
      // Iso3Reg
      // 
      this.Iso3Reg.BackColor = System.Drawing.SystemColors.Info;
      this.Iso3Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Iso3Reg.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Iso3Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.Iso3Reg, "Iso3Reg");
      this.Iso3Reg.Name = "Iso3Reg";
      // 
      // labelIso3Reg
      // 
      this.labelIso3Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelIso3Reg, "labelIso3Reg");
      this.labelIso3Reg.Name = "labelIso3Reg";
      // 
      // labelIso2Reg
      // 
      this.labelIso2Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelIso2Reg, "labelIso2Reg");
      this.labelIso2Reg.Name = "labelIso2Reg";
      // 
      // labelWinReg
      // 
      this.labelWinReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelWinReg, "labelWinReg");
      this.labelWinReg.Name = "labelWinReg";
      // 
      // Iso2Reg
      // 
      this.Iso2Reg.BackColor = System.Drawing.SystemColors.Info;
      this.Iso2Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Iso2Reg.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Iso2Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.Iso2Reg, "Iso2Reg");
      this.Iso2Reg.Name = "Iso2Reg";
      // 
      // labelCurrencySymbol
      // 
      this.labelCurrencySymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelCurrencySymbol, "labelCurrencySymbol");
      this.labelCurrencySymbol.Name = "labelCurrencySymbol";
      // 
      // labelCurrencyISO
      // 
      this.labelCurrencyISO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelCurrencyISO, "labelCurrencyISO");
      this.labelCurrencyISO.Name = "labelCurrencyISO";
      // 
      // treeCulture
      // 
      this.treeCulture.HideSelection = false;
      resources.ApplyResources(this.treeCulture, "treeCulture");
      this.treeCulture.ImageList = this.imageList;
      this.treeCulture.ItemHeight = 16;
      this.treeCulture.Name = "treeCulture";
      this.treeCulture.Sorted = true;
      this.treeCulture.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCulture_AfterSelect);
      // 
      // imageList
      // 
      this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
      resources.ApplyResources(this.imageList, "imageList");
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // labelIso2Lang
      // 
      this.labelIso2Lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelIso2Lang, "labelIso2Lang");
      this.labelIso2Lang.Name = "labelIso2Lang";
      // 
      // groupDateTime
      // 
      this.groupDateTime.Controls.Add(this.DateTimeText);
      this.groupDateTime.Controls.Add(this.DateTimeDetails);
      this.groupDateTime.Controls.Add(this.comboDateTime);
      this.groupDateTime.Controls.Add(this.labelDateTimeFormat);
      this.groupDateTime.Controls.Add(this.labelCalendar);
      this.groupDateTime.Controls.Add(this.comboCalendar);
      this.groupDateTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupDateTime, "groupDateTime");
      this.groupDateTime.Name = "groupDateTime";
      this.groupDateTime.TabStop = false;
      // 
      // DateTimeText
      // 
      this.DateTimeText.BackColor = System.Drawing.SystemColors.Info;
      this.DateTimeText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DateTimeText.Cursor = System.Windows.Forms.Cursors.Hand;
      resources.ApplyResources(this.DateTimeText, "DateTimeText");
      this.DateTimeText.Name = "DateTimeText";
      // 
      // DateTimeDetails
      // 
      this.DateTimeDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.DateTimeDetails, "DateTimeDetails");
      this.DateTimeDetails.Name = "DateTimeDetails";
      this.DateTimeDetails.TabStop = true;
      this.DateTimeDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DateTimeDetails_LinkClicked);
      // 
      // comboDateTime
      // 
      this.comboDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboDateTime.DropDownWidth = 253;
      resources.ApplyResources(this.comboDateTime, "comboDateTime");
      this.comboDateTime.FormattingEnabled = true;
      this.comboDateTime.Name = "comboDateTime";
      this.comboDateTime.SelectedIndexChanged += new System.EventHandler(this.comboDateTime_SelectedIndexChanged);
      // 
      // labelDateTimeFormat
      // 
      this.labelDateTimeFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelDateTimeFormat, "labelDateTimeFormat");
      this.labelDateTimeFormat.Name = "labelDateTimeFormat";
      // 
      // labelCalendar
      // 
      this.labelCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelCalendar, "labelCalendar");
      this.labelCalendar.Name = "labelCalendar";
      // 
      // comboCalendar
      // 
      this.comboCalendar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboCalendar.DropDownWidth = 253;
      resources.ApplyResources(this.comboCalendar, "comboCalendar");
      this.comboCalendar.FormattingEnabled = true;
      this.comboCalendar.Name = "comboCalendar";
      this.comboCalendar.SelectedIndexChanged += new System.EventHandler(this.comboCalendar_SelectedIndexChanged);
      // 
      // groupNumber
      // 
      this.groupNumber.Controls.Add(this.comboNumberFormat);
      this.groupNumber.Controls.Add(this.labelNumberFormat);
      this.groupNumber.Controls.Add(this.NumberDetails);
      this.groupNumber.Controls.Add(this.NumberNegative);
      this.groupNumber.Controls.Add(this.NumberPositive);
      this.groupNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupNumber, "groupNumber");
      this.groupNumber.Name = "groupNumber";
      this.groupNumber.TabStop = false;
      // 
      // comboNumberFormat
      // 
      this.comboNumberFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboNumberFormat.DropDownWidth = 119;
      resources.ApplyResources(this.comboNumberFormat, "comboNumberFormat");
      this.comboNumberFormat.FormattingEnabled = true;
      this.comboNumberFormat.Name = "comboNumberFormat";
      this.comboNumberFormat.SelectedIndexChanged += new System.EventHandler(this.comboNumberFormat_SelectedIndexChanged);
      // 
      // labelNumberFormat
      // 
      resources.ApplyResources(this.labelNumberFormat, "labelNumberFormat");
      this.labelNumberFormat.Name = "labelNumberFormat";
      // 
      // NumberDetails
      // 
      this.NumberDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.NumberDetails, "NumberDetails");
      this.NumberDetails.Name = "NumberDetails";
      this.NumberDetails.TabStop = true;
      this.NumberDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NumberDetails_LinkClicked);
      // 
      // NumberNegative
      // 
      this.NumberNegative.BackColor = System.Drawing.SystemColors.Info;
      this.NumberNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NumberNegative.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NumberNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NumberNegative, "NumberNegative");
      this.NumberNegative.Name = "NumberNegative";
      // 
      // NumberPositive
      // 
      this.NumberPositive.BackColor = System.Drawing.SystemColors.Info;
      this.NumberPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NumberPositive.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NumberPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NumberPositive, "NumberPositive");
      this.NumberPositive.Name = "NumberPositive";
      // 
      // labelNameEnglish
      // 
      this.labelNameEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelNameEnglish, "labelNameEnglish");
      this.labelNameEnglish.Name = "labelNameEnglish";
      // 
      // labelIso3Lang
      // 
      this.labelIso3Lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelIso3Lang, "labelIso3Lang");
      this.labelIso3Lang.Name = "labelIso3Lang";
      // 
      // CurrencyDetails
      // 
      this.CurrencyDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.CurrencyDetails, "CurrencyDetails");
      this.CurrencyDetails.Name = "CurrencyDetails";
      this.CurrencyDetails.TabStop = true;
      this.CurrencyDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CurrencyDetails_LinkClicked);
      // 
      // labelNameDisplay
      // 
      this.labelNameDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelNameDisplay, "labelNameDisplay");
      this.labelNameDisplay.Name = "labelNameDisplay";
      // 
      // labelNameNative
      // 
      this.labelNameNative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelNameNative, "labelNameNative");
      this.labelNameNative.Name = "labelNameNative";
      // 
      // groupPercent
      // 
      this.groupPercent.Controls.Add(this.PercentDetails);
      this.groupPercent.Controls.Add(this.PercentNegative);
      this.groupPercent.Controls.Add(this.PercentPositive);
      this.groupPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupPercent, "groupPercent");
      this.groupPercent.Name = "groupPercent";
      this.groupPercent.TabStop = false;
      // 
      // PercentDetails
      // 
      this.PercentDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.PercentDetails, "PercentDetails");
      this.PercentDetails.Name = "PercentDetails";
      this.PercentDetails.TabStop = true;
      this.PercentDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PercentDetails_LinkClicked);
      // 
      // PercentNegative
      // 
      this.PercentNegative.BackColor = System.Drawing.SystemColors.Info;
      this.PercentNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PercentNegative.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PercentNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.PercentNegative, "PercentNegative");
      this.PercentNegative.Name = "PercentNegative";
      // 
      // PercentPositive
      // 
      this.PercentPositive.BackColor = System.Drawing.SystemColors.Info;
      this.PercentPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PercentPositive.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PercentPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.PercentPositive, "PercentPositive");
      this.PercentPositive.Name = "PercentPositive";
      // 
      // groupLang
      // 
      this.groupLang.Controls.Add(this.IETF);
      this.groupLang.Controls.Add(this.WinLang);
      this.groupLang.Controls.Add(this.labelIETF);
      this.groupLang.Controls.Add(this.labelWinLang);
      this.groupLang.Controls.Add(this.labelIso3Lang);
      this.groupLang.Controls.Add(this.labelIso2Lang);
      this.groupLang.Controls.Add(this.IsoLang2);
      this.groupLang.Controls.Add(this.IsoLang3);
      this.groupLang.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupLang, "groupLang");
      this.groupLang.Name = "groupLang";
      this.groupLang.TabStop = false;
      // 
      // IETF
      // 
      this.IETF.BackColor = System.Drawing.SystemColors.Info;
      this.IETF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.IETF.Cursor = System.Windows.Forms.Cursors.Hand;
      this.IETF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.IETF, "IETF");
      this.IETF.Name = "IETF";
      // 
      // WinLang
      // 
      this.WinLang.BackColor = System.Drawing.SystemColors.Info;
      this.WinLang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.WinLang.Cursor = System.Windows.Forms.Cursors.Hand;
      this.WinLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.WinLang, "WinLang");
      this.WinLang.Name = "WinLang";
      // 
      // labelIETF
      // 
      resources.ApplyResources(this.labelIETF, "labelIETF");
      this.labelIETF.Name = "labelIETF";
      // 
      // labelWinLang
      // 
      this.labelWinLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelWinLang, "labelWinLang");
      this.labelWinLang.Name = "labelWinLang";
      // 
      // IsoLang2
      // 
      this.IsoLang2.BackColor = System.Drawing.SystemColors.Info;
      this.IsoLang2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.IsoLang2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.IsoLang2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.IsoLang2, "IsoLang2");
      this.IsoLang2.Name = "IsoLang2";
      // 
      // IsoLang3
      // 
      this.IsoLang3.BackColor = System.Drawing.SystemColors.Info;
      this.IsoLang3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.IsoLang3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.IsoLang3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.IsoLang3, "IsoLang3");
      this.IsoLang3.Name = "IsoLang3";
      // 
      // groupName
      // 
      this.groupName.Controls.Add(this.NameEnglish);
      this.groupName.Controls.Add(this.NameDisplay);
      this.groupName.Controls.Add(this.NameNative);
      this.groupName.Controls.Add(this.labelNameEnglish);
      this.groupName.Controls.Add(this.labelNameDisplay);
      this.groupName.Controls.Add(this.labelNameNative);
      this.groupName.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupName, "groupName");
      this.groupName.Name = "groupName";
      this.groupName.TabStop = false;
      // 
      // NameEnglish
      // 
      this.NameEnglish.BackColor = System.Drawing.SystemColors.Info;
      this.NameEnglish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NameEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NameEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NameEnglish, "NameEnglish");
      this.NameEnglish.Name = "NameEnglish";
      // 
      // NameDisplay
      // 
      this.NameDisplay.BackColor = System.Drawing.SystemColors.Info;
      this.NameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NameDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NameDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NameDisplay, "NameDisplay");
      this.NameDisplay.Name = "NameDisplay";
      // 
      // NameNative
      // 
      this.NameNative.BackColor = System.Drawing.SystemColors.Info;
      this.NameNative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NameNative.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NameNative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NameNative, "NameNative");
      this.NameNative.Name = "NameNative";
      // 
      // Exit
      // 
      resources.ApplyResources(this.Exit, "Exit");
      this.Exit.Name = "Exit";
      this.Exit.Click += new System.EventHandler(this.buttonExit_Click);
      // 
      // groupCurrency
      // 
      this.groupCurrency.Controls.Add(this.CurrencyDetails);
      this.groupCurrency.Controls.Add(this.CurrencyNegative);
      this.groupCurrency.Controls.Add(this.CurrencyPositive);
      this.groupCurrency.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupCurrency, "groupCurrency");
      this.groupCurrency.Name = "groupCurrency";
      this.groupCurrency.TabStop = false;
      // 
      // CurrencyNegative
      // 
      this.CurrencyNegative.BackColor = System.Drawing.SystemColors.Info;
      this.CurrencyNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.CurrencyNegative.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CurrencyNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.CurrencyNegative, "CurrencyNegative");
      this.CurrencyNegative.Name = "CurrencyNegative";
      // 
      // CurrencyPositive
      // 
      this.CurrencyPositive.BackColor = System.Drawing.SystemColors.Info;
      this.CurrencyPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.CurrencyPositive.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CurrencyPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.CurrencyPositive, "CurrencyPositive");
      this.CurrencyPositive.Name = "CurrencyPositive";
      // 
      // groupMoreInfo
      // 
      this.groupMoreInfo.Controls.Add(this.KeyboardLayoutID);
      this.groupMoreInfo.Controls.Add(this.labelKeyboardLayoutID);
      this.groupMoreInfo.Controls.Add(this.NeutralCulture);
      this.groupMoreInfo.Controls.Add(this.labelLCID);
      this.groupMoreInfo.Controls.Add(this.labelNeutralCulture);
      this.groupMoreInfo.Controls.Add(this.LCID);
      this.groupMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupMoreInfo, "groupMoreInfo");
      this.groupMoreInfo.Name = "groupMoreInfo";
      this.groupMoreInfo.TabStop = false;
      // 
      // KeyboardLayoutID
      // 
      this.KeyboardLayoutID.BackColor = System.Drawing.SystemColors.Info;
      this.KeyboardLayoutID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.KeyboardLayoutID.Cursor = System.Windows.Forms.Cursors.Hand;
      this.KeyboardLayoutID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.KeyboardLayoutID, "KeyboardLayoutID");
      this.KeyboardLayoutID.Name = "KeyboardLayoutID";
      // 
      // labelKeyboardLayoutID
      // 
      resources.ApplyResources(this.labelKeyboardLayoutID, "labelKeyboardLayoutID");
      this.labelKeyboardLayoutID.Name = "labelKeyboardLayoutID";
      // 
      // NeutralCulture
      // 
      this.NeutralCulture.BackColor = System.Drawing.SystemColors.Info;
      this.NeutralCulture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.NeutralCulture.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NeutralCulture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.NeutralCulture, "NeutralCulture");
      this.NeutralCulture.Name = "NeutralCulture";
      // 
      // labelLCID
      // 
      resources.ApplyResources(this.labelLCID, "labelLCID");
      this.labelLCID.Name = "labelLCID";
      // 
      // labelNeutralCulture
      // 
      resources.ApplyResources(this.labelNeutralCulture, "labelNeutralCulture");
      this.labelNeutralCulture.Name = "labelNeutralCulture";
      // 
      // LCID
      // 
      this.LCID.BackColor = System.Drawing.SystemColors.Info;
      this.LCID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.LCID.Cursor = System.Windows.Forms.Cursors.Hand;
      this.LCID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.LCID, "LCID");
      this.LCID.Name = "LCID";
      // 
      // About
      // 
      resources.ApplyResources(this.About, "About");
      this.About.Name = "About";
      this.About.Click += new System.EventHandler(this.OnAboutClick);
      // 
      // ClassDetails
      // 
      resources.ApplyResources(this.ClassDetails, "ClassDetails");
      this.ClassDetails.Name = "ClassDetails";
      this.ClassDetails.Click += new System.EventHandler(this.ClassDetails_Click);
      // 
      // groupText
      // 
      this.groupText.Controls.Add(this.ListSeparator);
      this.groupText.Controls.Add(this.labelListSeparator);
      this.groupText.Controls.Add(this.labelBidi);
      this.groupText.Controls.Add(this.BIDI);
      this.groupText.FlatStyle = System.Windows.Forms.FlatStyle.System;
      resources.ApplyResources(this.groupText, "groupText");
      this.groupText.Name = "groupText";
      this.groupText.TabStop = false;
      // 
      // ListSeparator
      // 
      this.ListSeparator.BackColor = System.Drawing.SystemColors.Info;
      this.ListSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ListSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ListSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.ListSeparator, "ListSeparator");
      this.ListSeparator.Name = "ListSeparator";
      // 
      // labelListSeparator
      // 
      this.labelListSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelListSeparator, "labelListSeparator");
      this.labelListSeparator.Name = "labelListSeparator";
      // 
      // labelBidi
      // 
      resources.ApplyResources(this.labelBidi, "labelBidi");
      this.labelBidi.Name = "labelBidi";
      // 
      // BIDI
      // 
      this.BIDI.BackColor = System.Drawing.SystemColors.Info;
      this.BIDI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.BIDI.Cursor = System.Windows.Forms.Cursors.Hand;
      this.BIDI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.BIDI, "BIDI");
      this.BIDI.Name = "BIDI";
      // 
      // groupCultures
      // 
      this.groupCultures.Controls.Add(this.checkAllCultures);
      this.groupCultures.Controls.Add(this.checkUserCustomCultures);
      this.groupCultures.Controls.Add(this.checkWindowsOnlyCultures);
      this.groupCultures.Controls.Add(this.checkInstalledWin32Cultures);
      this.groupCultures.Controls.Add(this.checkReplacementCultures);
      this.groupCultures.Controls.Add(this.checkSpecificCultures);
      this.groupCultures.Controls.Add(this.checkNeutralCultures);
      this.groupCultures.Controls.Add(this.checkFrameworkCultures);
      resources.ApplyResources(this.groupCultures, "groupCultures");
      this.groupCultures.Name = "groupCultures";
      this.groupCultures.TabStop = false;
      // 
      // checkAllCultures
      // 
      resources.ApplyResources(this.checkAllCultures, "checkAllCultures");
      this.checkAllCultures.Name = "checkAllCultures";
      this.checkAllCultures.UseVisualStyleBackColor = true;
      this.checkAllCultures.CheckedChanged += new System.EventHandler(this.checkAllCultures_CheckedChanged);
      // 
      // checkUserCustomCultures
      // 
      resources.ApplyResources(this.checkUserCustomCultures, "checkUserCustomCultures");
      this.checkUserCustomCultures.Name = "checkUserCustomCultures";
      this.checkUserCustomCultures.UseVisualStyleBackColor = true;
      this.checkUserCustomCultures.CheckedChanged += new System.EventHandler(this.checkUserCustomCultures_CheckedChanged);
      // 
      // checkWindowsOnlyCultures
      // 
      resources.ApplyResources(this.checkWindowsOnlyCultures, "checkWindowsOnlyCultures");
      this.checkWindowsOnlyCultures.Name = "checkWindowsOnlyCultures";
      this.checkWindowsOnlyCultures.UseVisualStyleBackColor = true;
      this.checkWindowsOnlyCultures.CheckedChanged += new System.EventHandler(this.checkWindowsOnlyCultures_CheckedChanged);
      // 
      // checkInstalledWin32Cultures
      // 
      resources.ApplyResources(this.checkInstalledWin32Cultures, "checkInstalledWin32Cultures");
      this.checkInstalledWin32Cultures.Name = "checkInstalledWin32Cultures";
      this.checkInstalledWin32Cultures.UseVisualStyleBackColor = true;
      this.checkInstalledWin32Cultures.CheckedChanged += new System.EventHandler(this.checkInstalledWin32Cultures_CheckedChanged);
      // 
      // checkReplacementCultures
      // 
      resources.ApplyResources(this.checkReplacementCultures, "checkReplacementCultures");
      this.checkReplacementCultures.Name = "checkReplacementCultures";
      this.checkReplacementCultures.UseVisualStyleBackColor = true;
      this.checkReplacementCultures.CheckedChanged += new System.EventHandler(this.checkReplacementCultures_CheckedChanged);
      // 
      // checkSpecificCultures
      // 
      resources.ApplyResources(this.checkSpecificCultures, "checkSpecificCultures");
      this.checkSpecificCultures.Name = "checkSpecificCultures";
      this.checkSpecificCultures.UseVisualStyleBackColor = true;
      this.checkSpecificCultures.CheckedChanged += new System.EventHandler(this.checkSpecificCultures_CheckedChanged);
      // 
      // checkNeutralCultures
      // 
      resources.ApplyResources(this.checkNeutralCultures, "checkNeutralCultures");
      this.checkNeutralCultures.Name = "checkNeutralCultures";
      this.checkNeutralCultures.UseVisualStyleBackColor = true;
      this.checkNeutralCultures.CheckedChanged += new System.EventHandler(this.checkNeutralCultures_CheckedChanged);
      // 
      // checkFrameworkCultures
      // 
      resources.ApplyResources(this.checkFrameworkCultures, "checkFrameworkCultures");
      this.checkFrameworkCultures.Name = "checkFrameworkCultures";
      this.checkFrameworkCultures.UseVisualStyleBackColor = true;
      this.checkFrameworkCultures.CheckedChanged += new System.EventHandler(this.checkFrameworkCultures_CheckedChanged);
      // 
      // labelCurrencyEnglishName
      // 
      this.labelCurrencyEnglishName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelCurrencyEnglishName, "labelCurrencyEnglishName");
      this.labelCurrencyEnglishName.Name = "labelCurrencyEnglishName";
      // 
      // groupCurrencyInfo
      // 
      this.groupCurrencyInfo.Controls.Add(this.CurrencyNativeName);
      this.groupCurrencyInfo.Controls.Add(this.labelCurrencyNativeName);
      this.groupCurrencyInfo.Controls.Add(this.CurrencyEnglishName);
      this.groupCurrencyInfo.Controls.Add(this.labelCurrencySymbol);
      this.groupCurrencyInfo.Controls.Add(this.labelCurrencyEnglishName);
      this.groupCurrencyInfo.Controls.Add(this.CurrencyISO);
      this.groupCurrencyInfo.Controls.Add(this.CurrencySymbol);
      this.groupCurrencyInfo.Controls.Add(this.labelCurrencyISO);
      resources.ApplyResources(this.groupCurrencyInfo, "groupCurrencyInfo");
      this.groupCurrencyInfo.Name = "groupCurrencyInfo";
      this.groupCurrencyInfo.TabStop = false;
      // 
      // CurrencyNativeName
      // 
      this.CurrencyNativeName.BackColor = System.Drawing.SystemColors.Info;
      this.CurrencyNativeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.CurrencyNativeName.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CurrencyNativeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.CurrencyNativeName, "CurrencyNativeName");
      this.CurrencyNativeName.Name = "CurrencyNativeName";
      // 
      // labelCurrencyNativeName
      // 
      this.labelCurrencyNativeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.labelCurrencyNativeName, "labelCurrencyNativeName");
      this.labelCurrencyNativeName.Name = "labelCurrencyNativeName";
      // 
      // CurrencyEnglishName
      // 
      this.CurrencyEnglishName.BackColor = System.Drawing.SystemColors.Info;
      this.CurrencyEnglishName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.CurrencyEnglishName.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CurrencyEnglishName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.CurrencyEnglishName, "CurrencyEnglishName");
      this.CurrencyEnglishName.Name = "CurrencyEnglishName";
      // 
      // CurrencyISO
      // 
      this.CurrencyISO.BackColor = System.Drawing.SystemColors.Info;
      this.CurrencyISO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.CurrencyISO.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CurrencyISO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.CurrencyISO, "CurrencyISO");
      this.CurrencyISO.Name = "CurrencyISO";
      // 
      // CurrencySymbol
      // 
      this.CurrencySymbol.BackColor = System.Drawing.SystemColors.Info;
      this.CurrencySymbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.CurrencySymbol.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CurrencySymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      resources.ApplyResources(this.CurrencySymbol, "CurrencySymbol");
      this.CurrencySymbol.Name = "CurrencySymbol";
      // 
      // MainForm
      // 
      this.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.groupCurrencyInfo);
      this.Controls.Add(this.groupCultures);
      this.Controls.Add(this.groupText);
      this.Controls.Add(this.ClassDetails);
      this.Controls.Add(this.About);
      this.Controls.Add(this.Exit);
      this.Controls.Add(this.groupMoreInfo);
      this.Controls.Add(this.groupPercent);
      this.Controls.Add(this.groupCurrency);
      this.Controls.Add(this.groupNumber);
      this.Controls.Add(this.treeCulture);
      this.Controls.Add(this.groupDateTime);
      this.Controls.Add(this.groupRegion);
      this.Controls.Add(this.groupLang);
      this.Controls.Add(this.groupName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.groupRegion.ResumeLayout(false);
      this.groupDateTime.ResumeLayout(false);
      this.groupNumber.ResumeLayout(false);
      this.groupPercent.ResumeLayout(false);
      this.groupLang.ResumeLayout(false);
      this.groupName.ResumeLayout(false);
      this.groupCurrency.ResumeLayout(false);
      this.groupMoreInfo.ResumeLayout(false);
      this.groupText.ResumeLayout(false);
      this.groupCultures.ResumeLayout(false);
      this.groupCultures.PerformLayout();
      this.groupCurrencyInfo.ResumeLayout(false);
      this.ResumeLayout(false);

		}
		#endregion

    #region initialization methods

		private void InitializeCultureTree()
		{
      treeCulture.Nodes.Clear();
      InsertCultures(CultureTypes.FrameworkCultures);
    }

    #endregion

    #region update methods

		public void UpdateCulture(CultureInfo ci)
		{
      if (null != ci)
      {
        // update name and non country-related ISO information
        NameNative.Text         = ci.NativeName;
        NameDisplay.Text        = ci.DisplayName;
        NameEnglish.Text        = ci.EnglishName;
        IsoLang2.Text           = ci.TwoLetterISOLanguageName;
        IsoLang3.Text           = ci.ThreeLetterISOLanguageName;
        WinLang.Text            = ci.ThreeLetterWindowsLanguageName;
        LCID.Text               = ci.LCID.ToString("X08");
        IETF.Text               = ci.IetfLanguageTag;
        NeutralCulture.Text     = ci.IsNeutralCulture.ToString();
        NameNative.RightToLeft  = ci.TextInfo.IsRightToLeft ? RightToLeft.Yes : RightToLeft.No;
        KeyboardLayoutID.Text   = ci.KeyboardLayoutId.ToString("X04");
      }
      else
      {
        // update name and non country-related ISO information
        NameNative.Text         = String.Empty;
        NameDisplay.Text        = String.Empty;
        NameEnglish.Text        = String.Empty;
        IsoLang2.Text           = String.Empty;
        IsoLang3.Text           = String.Empty;
        WinLang.Text            = String.Empty;
        LCID.Text               = String.Empty;
        IETF.Text               = String.Empty;
        NeutralCulture.Text     = String.Empty;
        NameNative.RightToLeft  = RightToLeft.No;
        KeyboardLayoutID.Text   = String.Empty;
      }

			UpdateCalendar(ci);
			UpdateRegionInformation(ci);
			UpdateDateTimeCalendar(ci);
			UpdateNumberInformation(ci);
			UpdateCurrencyPercentage(ci);
      UpdateTextInformation(ci);
		}

    private void UpdateCalendar(CultureInfo ci)
    {
      comboCalendar.Items.Clear();

      if ((null != ci) && !ci.IsNeutralCulture)
      {
        Calendar[] calendarList = ci.OptionalCalendars;
        comboCalendar.SuspendLayout();

        foreach (Calendar cal in calendarList)
          comboCalendar.Items.Add(new CalendarNameWrapper(cal));

        comboCalendar.SelectedIndex = 0;
        comboCalendar.ResumeLayout(true);
      }
    }

		private void UpdateRegionInformation(CultureInfo ci)
		{
      if (null == ci)
      {
        Iso2Reg.Text             = String.Empty;
        Iso3Reg.Text             = String.Empty;
        WinReg.Text              = String.Empty;
        MetricReg.Text           = String.Empty;
        RIName.Text              = String.Empty;
        RINativeName.Text        = String.Empty;
        GeoID.Text               = String.Empty;
        CurrencySymbol.Text      = String.Empty;
        CurrencyISO.Text         = String.Empty;
        CurrencyEnglishName.Text = String.Empty;
        CurrencyNativeName.Text  = String.Empty;
      } 
      
      // neutral cultures and invariant culture do not provide region information
			else if (ci.IsNeutralCulture || "iv" == ci.TwoLetterISOLanguageName)
			{
				// information is not available
				Iso2Reg.Text             = Properties.Resources.NotAvailable;
				Iso3Reg.Text             = Properties.Resources.NotAvailable;
        WinReg.Text              = Properties.Resources.NotAvailable;
        MetricReg.Text           = Properties.Resources.NotAvailable;
        RIName.Text              = Properties.Resources.NotAvailable;
        RINativeName.Text        = Properties.Resources.NotAvailable;
        GeoID.Text               = Properties.Resources.NotAvailable;
        CurrencySymbol.Text      = Properties.Resources.NotAvailable;
        CurrencyISO.Text         = Properties.Resources.NotAvailable;
        CurrencyEnglishName.Text = Properties.Resources.NotAvailable;
        CurrencyNativeName.Text  = Properties.Resources.NotAvailable;
      }
			else
			{
				RegionInfo ri            = new RegionInfo(ci.Name);
				Iso2Reg.Text             = ri.TwoLetterISORegionName;
				Iso3Reg.Text             = ri.ThreeLetterISORegionName;
				WinReg.Text              = ri.ThreeLetterWindowsRegionName;
				MetricReg.Text           = ri.IsMetric ? Properties.Resources.True : Properties.Resources.False;
        RIName.Text              = ri.Name;
        RINativeName.Text        = ri.NativeName;
        GeoID.Text               = ri.GeoId.ToString();
        CurrencySymbol.Text      = ri.CurrencySymbol;
        CurrencyISO.Text         = ri.ISOCurrencySymbol;
        CurrencyEnglishName.Text = ri.CurrencyEnglishName;
        CurrencyNativeName.Text  = ri.CurrencyNativeName;
			}
		}

		private void UpdateDateTimeCalendar(CultureInfo ci)
		{
      if (null == ci)
      {
        DateTimeText.Text     = String.Empty;
        comboDateTime.Enabled = false;
        comboCalendar.Enabled = false;
      }
      
      else if (ci.IsNeutralCulture)
			{
        DateTimeText.Text     = Properties.Resources.NotAvailable;
				comboDateTime.Enabled = false;
				comboCalendar.Enabled = false;
			}
			else
			{
				comboDateTime.Enabled = true;
				comboCalendar.Enabled = true;

				int indexCal = comboCalendar.SelectedIndex;
				int indexDTF = comboDateTime.SelectedIndex;

				if ((-1 < indexCal) && (-1 < indexDTF))
				{
					ci.DateTimeFormat.Calendar = ((CalendarNameWrapper)comboCalendar.Items[indexCal]).Calendar;
					String str = (String)comboDateTime.Items[indexDTF];
					DateTimeText.Text = DateTime.Now.ToString(str.Substring(0, 1), ci);
				}
			}
			CalendarForm.UpdateCulture(ci);
		}

		private void UpdateNumberInformation(CultureInfo ci)
		{
      if (null == ci)
      {
        NumberPositive.Text = String.Empty;
        NumberNegative.Text = String.Empty;
        comboNumberFormat.Enabled = false;
      }      
      else if (ci.IsNeutralCulture)
			{
        NumberPositive.Text = Properties.Resources.NotAvailable;
        NumberNegative.Text = Properties.Resources.NotAvailable;
				comboNumberFormat.Enabled = false;
			}
			else
			{
				comboNumberFormat.Enabled = true;
				int indexNum = comboNumberFormat.SelectedIndex;
				if (-1 < indexNum)
				{
					double PosNum =  9876543.21;
					double NegNum = -1234567.89;
					String str = ((String)comboNumberFormat.Items[indexNum]).Substring(0, 1);
					NumberPositive.Text = PosNum.ToString(str, ci);
					NumberNegative.Text = NegNum.ToString(str, ci);
				}
			}
			NumberForm.UpdateCulture(ci);
		}

		private void UpdateCurrencyPercentage(CultureInfo ci)
		{
      if (null == ci)
      {
        CurrencyPositive.Text = String.Empty;
        CurrencyNegative.Text = String.Empty;
        PercentPositive.Text  = String.Empty;
        PercentNegative.Text  = String.Empty;
      }
      else if (ci.IsNeutralCulture)
			{
        CurrencyPositive.Text = Properties.Resources.NotAvailable;
        CurrencyNegative.Text = Properties.Resources.NotAvailable;
        PercentPositive.Text  = Properties.Resources.NotAvailable;
        PercentNegative.Text  = Properties.Resources.NotAvailable;
			}
			else
			{
				double PosCur =  9876543.21;
				double NegCur = -1234567.89;
				CurrencyPositive.Text = PosCur.ToString("C", ci);
				CurrencyNegative.Text = NegCur.ToString("C", ci);

				double PosPer =  0.9876;
				double NegPer = -0.1234;
				PercentPositive.Text = PosPer.ToString("P", ci);
				PercentNegative.Text = NegPer.ToString("P", ci);
			}
			CurrencyForm.UpdateCulture(ci);
			PercentForm.UpdateCulture(ci);
		}

    private void UpdateTextInformation(CultureInfo ci)
    {
      if (null == ci)
      {
        BIDI.Text = String.Empty;
        ListSeparator.Text = String.Empty;
      }
      else
      {
        BIDI.Text = (ci.TextInfo.IsRightToLeft) ? bool.TrueString : bool.FalseString;
        ListSeparator.Text = ci.TextInfo.ListSeparator;
      }
    }

    private void UpdateCultureTree()
    {
      treeCulture.Nodes.Clear();
      treeCulture.SuspendLayout();

      if (checkFrameworkCultures.Checked)
        InsertCultures(CultureTypes.FrameworkCultures);

      if (checkNeutralCultures.Checked)
        InsertCultures(CultureTypes.NeutralCultures);

      if (checkSpecificCultures.Checked)
        InsertCultures(CultureTypes.SpecificCultures);

      if (checkWindowsOnlyCultures.Checked)
        InsertCultures(CultureTypes.WindowsOnlyCultures);

      if (checkInstalledWin32Cultures.Checked)
        InsertCultures(CultureTypes.InstalledWin32Cultures);

      if (checkUserCustomCultures.Checked)
        InsertCultures(CultureTypes.UserCustomCulture);

      if (checkReplacementCultures.Checked)
        InsertCultures(CultureTypes.ReplacementCultures);

      if (checkAllCultures.Checked)
        InsertCultures(CultureTypes.AllCultures);

      // if tree is empty, clear all
      if (0 == treeCulture.Nodes.Count)
      {
        ci = null;
        UpdateCulture(ci);
      }

      treeCulture.ResumeLayout();
    }

    #endregion

    #region culture tree related methods

    private void InsertCultures(CultureTypes type)
    {
      CultureInfo[] cultures = CultureInfo.GetCultures(type);

      switch (type)
      {
        case CultureTypes.FrameworkCultures:
          CreateFrameworkNode(Properties.Resources.FrameworkCultures, (int)CultureIcons.Framework, cultures);
          break;

        case CultureTypes.InstalledWin32Cultures:
          CreateNode(Properties.Resources.InstalledWin32Cultures, (int)CultureIcons.Installed, cultures);
          break;

        case CultureTypes.NeutralCultures:
          CreateNode(Properties.Resources.NeutralCultures, (int)CultureIcons.Neutral, cultures);
          break;

        case CultureTypes.ReplacementCultures:
          CreateNode(Properties.Resources.ReplacementCultures, (int)CultureIcons.Replacement, cultures);
          break;

        case CultureTypes.SpecificCultures:
          CreateNode(Properties.Resources.SpecificCultures, (int)CultureIcons.Specific, cultures);
          break;

        case CultureTypes.UserCustomCulture:
          CreateNode(Properties.Resources.CustomUserCultures, (int)CultureIcons.Custom, cultures);
          break;

        case CultureTypes.WindowsOnlyCultures:
          CreateNode(Properties.Resources.WindowsOnlyCultures, (int)CultureIcons.WinOnly, cultures);
          break;

        case CultureTypes.AllCultures:
          CreateNode(Properties.Resources.AllCultures, (int)CultureIcons.All, cultures);
          break;
      }

      // try and select first child of first child so we have a culture selected
      try
      {
        treeCulture.SelectedNode = treeCulture.Nodes[0].Nodes[0];
      }
      catch
      {
      }
    }

    private void CreateNode(string title, int index, CultureInfo[] cultures)
    {
      TreeNode rootNode = treeCulture.Nodes.Add(title, title, index, index);
      foreach (CultureInfo culture in cultures)
      {
        int cultureIndex;
        string cultureTitle = (String.Empty == culture.Name) ? Properties.Resources.Invariant : culture.ToString();

        if (String.Empty == culture.Name)
          cultureIndex = (int)CultureIcons.Invariant;
        else
          cultureIndex = culture.IsNeutralCulture ? (int)CultureIcons.Neutral : (int)CultureIcons.Specific;

        rootNode.Nodes.Add(cultureTitle, cultureTitle, cultureIndex, cultureIndex);
      }
    }

    private void CreateFrameworkNode(string title, int index, CultureInfo[] cultures)
    {
      TreeNode rootNode = treeCulture.Nodes.Add(title, title, index, index);

      // create invariant node
      TreeNode invariantNode = rootNode.Nodes.Add(Properties.Resources.Invariant, Properties.Resources.Invariant, (int)CultureIcons.Invariant, (int)CultureIcons.Invariant);

      // add neutral cultures nodes
      foreach (CultureInfo culture in cultures)
      {
        if (culture.IsNeutralCulture)
          invariantNode.Nodes.Add(culture.Name, culture.Name, (int)CultureIcons.Neutral, (int)CultureIcons.Neutral);
      }

      // add specific cultures nodes
      foreach (CultureInfo culture in cultures)
      {
        if (!culture.IsNeutralCulture && (String.Empty != culture.Name))
        {
          TreeNode[] ParentNodes = invariantNode.Nodes.Find(culture.Parent.Name, false);
          if (1 != ParentNodes.Length)
            throw new Exception("Cannot have more than one parent with the same culture name!");
          ParentNodes[0].Nodes.Add(culture.Name, culture.Name, (int)CultureIcons.Specific, (int)CultureIcons.Specific);
        }
      }
    }

    #endregion

    #region event handlers

    private void comboDateTime_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateDateTimeCalendar(ci);
		}

		private void comboCalendar_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateDateTimeCalendar(ci);
		}

		private void comboNumberFormat_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateNumberInformation(ci);
		}

		private void treeCulture_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			String strNode = e.Node.Text;

			// special case for invariant
			if (Properties.Resources.Invariant == strNode)
				strNode = "";

      try
      {
        ci = new CultureInfo(strNode);
      }
      catch
      {
        ci = null;
      }

      UpdateCulture(ci);
    }

		private void NumberDetails_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (NumberForm.Visible)
				NumberForm.Hide();
			else
				NumberForm.Show();
		}

		private void CurrencyDetails_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (CurrencyForm.Visible)
				CurrencyForm.Hide();
			else
				CurrencyForm.Show();
		}

		private void PercentDetails_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (PercentForm.Visible)
				PercentForm.Hide();
			else
				PercentForm.Show();
		}

		private void DateTimeDetails_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (CalendarForm.Visible)
				CalendarForm.Hide();
			else
				CalendarForm.Show();
		}

		private void ClassDetails_Click(object sender, System.EventArgs e)
		{
			if (ClassForm.Visible)
				ClassForm.Hide();
			else
				ClassForm.Show();
		}

		private void OnAboutClick(object sender, System.EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.ShowDialog(this);
		}

		private void buttonExit_Click(object sender, System.EventArgs e)
		{
			Close();
    }

    private void checkFrameworkCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkNeutralCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkSpecificCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkInstalledWin32Cultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkWindowsOnlyCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkUserCustomCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkReplacementCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    private void checkAllCultures_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCultureTree();
    }

    #endregion

    #region class coloring methods

    public void NotifyClassColorChange(ProgramSettings.ClassColor cc)
		{
			this.ClassColor(cc);
			NumberForm.ClassColor(cc);
			CurrencyForm.ClassColor(cc);
			PercentForm.ClassColor(cc);
			CalendarForm.ClassColor(cc);
		}

		public void ClassColor(ProgramSettings.ClassColor cc)
		{
			switch (cc)
			{
				case ProgramSettings.ClassColor.ApplyCultureInfo:
					ColorCI(ProgramSettings.colorCultureInfo);
					break;

        case ProgramSettings.ClassColor.ClearCultureInfo:
					ColorCI(ProgramSettings.colorNone);
					break;

        case ProgramSettings.ClassColor.ApplyRegionInfo:
          ColorRI(ProgramSettings.colorRegionInfo);
					break;

        case ProgramSettings.ClassColor.ClearRegionInfo:
          ColorRI(ProgramSettings.colorNone);
					break;

        case ProgramSettings.ClassColor.ApplyDateTimeFormatInfo:
          DateTimeText.BackColor = ProgramSettings.colorDateTimeFormatInfo;
					break;

        case ProgramSettings.ClassColor.ClearDateTimeFormatInfo:
          DateTimeText.BackColor = ProgramSettings.colorNone;
					break;

        case ProgramSettings.ClassColor.ApplyNumberFormatInfo:
          ColorNFI(ProgramSettings.colorNumberFormatInfo);
					break;

        case ProgramSettings.ClassColor.ClearNumberFormatInfo:
          ColorNFI(ProgramSettings.colorNone);
					break;

        case ProgramSettings.ClassColor.ApplyTextInfo:
          ColorTI(ProgramSettings.colorTextInfo);
          break;

        case ProgramSettings.ClassColor.ClearTextInfo:
          ColorTI(ProgramSettings.colorNone);
          break;

        case ProgramSettings.ClassColor.ApplyCalendar:
          ColorCalendar(ProgramSettings.colorCalendar);
          break;

        case ProgramSettings.ClassColor.ClearCalendar:
          ColorCalendar(ProgramSettings.colorNone);
          break;
			}
		}

		private void ColorCI(Color color)
		{
			NameNative.BackColor       = color;
			NameDisplay.BackColor      = color;
			NameEnglish.BackColor      = color;
			IsoLang2.BackColor         = color;
			IsoLang3.BackColor         = color;
			WinLang.BackColor          = color;
			LCID.BackColor             = color;
      IETF.BackColor             = color;
      NeutralCulture.BackColor   = color;
      KeyboardLayoutID.BackColor = color;
		}

		private void ColorRI(Color color)
		{
			Iso2Reg.BackColor             = color;
			Iso3Reg.BackColor             = color;
			WinReg.BackColor              = color;
			MetricReg.BackColor           = color;
      RIName.BackColor              = color;
      RINativeName.BackColor        = color;
      GeoID.BackColor               = color;
      CurrencySymbol.BackColor      = color;
      CurrencyISO.BackColor         = color;
      CurrencyEnglishName.BackColor = color;
      CurrencyNativeName.BackColor  = color;
		}

		private void ColorNFI(Color color)
		{
			NumberPositive.BackColor    = color;
			NumberNegative.BackColor    = color;
			CurrencyPositive.BackColor  = color;
			CurrencyNegative.BackColor  = color;
			PercentPositive.BackColor   = color;
			PercentNegative.BackColor   = color;
		}

    private void ColorTI(Color color)
    {
      BIDI.BackColor          = color;
      ListSeparator.BackColor = color;
    }

    private void ColorCalendar(Color color)
    {
      // do nothing as no calendar-class based information is displayed within this form
    }

    #endregion 

	}
}
