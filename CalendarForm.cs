using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;

namespace CultureExplorer20
{
	/// <summary>
	/// Summary description for CalendarForm.
	/// </summary>
	public class CalendarForm : System.Windows.Forms.Form
	{
		private CultureExplorerListView listDays;
		private Button buttonClose;
		private ColumnHeader columnDay;
		private ColumnHeader columnDayAbbr;
		private GroupBox groupBoxDays;
		private Label labelFirstDay;
		private CultureExplorerLabel FirstDay;
		private GroupBox groupBoxMonths;
		private CultureExplorerLabel MonthsPerYear;
		private Label labelMonthsPerYear;
		private CultureExplorerListView listMonths;
		private ColumnHeader columnMonth;
		private ColumnHeader columnMonthAbbr;
		private Label labelDays;
		private Label labelMonths;
		private GroupBox groupBoxTime;
		private Label labelAM;
		private CultureExplorerLabel AM;
		private CultureExplorerLabel PM;
		private Label labelPM;
		private Label labelAlgorithm;
		private CultureExplorerLabel Algorithm;
		private GroupBox groupBoxCalendar;
		private ColumnHeader columnDayShortest;
		private CheckBox checkGenitiveMonths;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private CultureExplorerLabel NativeName;
		private Label labelNativeName;
		private CultureExplorerLabel CurrentEra;
		private Label labelEra;

		private CultureInfo culture;

		public CalendarForm (CultureInfo ci)
		{
			InitializeComponent();

			AutoScaleDimensions = new SizeF(96f, 96f);
			AutoScaleMode = AutoScaleMode.Dpi;

			UpdateCulture(ci);
		}

		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
			this.buttonClose = new System.Windows.Forms.Button();
			this.labelFirstDay = new System.Windows.Forms.Label();
			this.groupBoxDays = new System.Windows.Forms.GroupBox();
			this.labelDays = new System.Windows.Forms.Label();
			this.groupBoxMonths = new System.Windows.Forms.GroupBox();
			this.checkGenitiveMonths = new System.Windows.Forms.CheckBox();
			this.labelMonths = new System.Windows.Forms.Label();
			this.labelMonthsPerYear = new System.Windows.Forms.Label();
			this.groupBoxTime = new System.Windows.Forms.GroupBox();
			this.labelPM = new System.Windows.Forms.Label();
			this.labelAM = new System.Windows.Forms.Label();
			this.labelAlgorithm = new System.Windows.Forms.Label();
			this.groupBoxCalendar = new System.Windows.Forms.GroupBox();
			this.labelEra = new System.Windows.Forms.Label();
			this.labelNativeName = new System.Windows.Forms.Label();
			this.CurrentEra = new CultureExplorer20.CultureExplorerLabel();
			this.NativeName = new CultureExplorer20.CultureExplorerLabel();
			this.Algorithm = new CultureExplorer20.CultureExplorerLabel();
			this.PM = new CultureExplorer20.CultureExplorerLabel();
			this.AM = new CultureExplorer20.CultureExplorerLabel();
			this.listMonths = new CultureExplorer20.CultureExplorerListView();
			this.columnMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnMonthAbbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MonthsPerYear = new CultureExplorer20.CultureExplorerLabel();
			this.FirstDay = new CultureExplorer20.CultureExplorerLabel();
			this.listDays = new CultureExplorer20.CultureExplorerListView();
			this.columnDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnDayAbbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnDayShortest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBoxDays.SuspendLayout();
			this.groupBoxMonths.SuspendLayout();
			this.groupBoxTime.SuspendLayout();
			this.groupBoxCalendar.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			resources.ApplyResources(this.buttonClose, "buttonClose");
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// labelFirstDay
			// 
			resources.ApplyResources(this.labelFirstDay, "labelFirstDay");
			this.labelFirstDay.Name = "labelFirstDay";
			// 
			// groupBoxDays
			// 
			this.groupBoxDays.Controls.Add(this.labelDays);
			this.groupBoxDays.Controls.Add(this.FirstDay);
			this.groupBoxDays.Controls.Add(this.listDays);
			this.groupBoxDays.Controls.Add(this.labelFirstDay);
			this.groupBoxDays.FlatStyle = System.Windows.Forms.FlatStyle.System;
			resources.ApplyResources(this.groupBoxDays, "groupBoxDays");
			this.groupBoxDays.Name = "groupBoxDays";
			this.groupBoxDays.TabStop = false;
			// 
			// labelDays
			// 
			resources.ApplyResources(this.labelDays, "labelDays");
			this.labelDays.Name = "labelDays";
			// 
			// groupBoxMonths
			// 
			this.groupBoxMonths.Controls.Add(this.checkGenitiveMonths);
			this.groupBoxMonths.Controls.Add(this.labelMonths);
			this.groupBoxMonths.Controls.Add(this.listMonths);
			this.groupBoxMonths.Controls.Add(this.MonthsPerYear);
			this.groupBoxMonths.Controls.Add(this.labelMonthsPerYear);
			this.groupBoxMonths.FlatStyle = System.Windows.Forms.FlatStyle.System;
			resources.ApplyResources(this.groupBoxMonths, "groupBoxMonths");
			this.groupBoxMonths.Name = "groupBoxMonths";
			this.groupBoxMonths.TabStop = false;
			// 
			// checkGenitiveMonths
			// 
			resources.ApplyResources(this.checkGenitiveMonths, "checkGenitiveMonths");
			this.checkGenitiveMonths.Name = "checkGenitiveMonths";
			this.checkGenitiveMonths.UseVisualStyleBackColor = true;
			this.checkGenitiveMonths.CheckedChanged += new System.EventHandler(this.checkGenitiveMonths_CheckedChanged);
			// 
			// labelMonths
			// 
			resources.ApplyResources(this.labelMonths, "labelMonths");
			this.labelMonths.Name = "labelMonths";
			// 
			// labelMonthsPerYear
			// 
			resources.ApplyResources(this.labelMonthsPerYear, "labelMonthsPerYear");
			this.labelMonthsPerYear.Name = "labelMonthsPerYear";
			// 
			// groupBoxTime
			// 
			resources.ApplyResources(this.groupBoxTime, "groupBoxTime");
			this.groupBoxTime.Controls.Add(this.PM);
			this.groupBoxTime.Controls.Add(this.labelPM);
			this.groupBoxTime.Controls.Add(this.AM);
			this.groupBoxTime.Controls.Add(this.labelAM);
			this.groupBoxTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBoxTime.Name = "groupBoxTime";
			this.groupBoxTime.TabStop = false;
			// 
			// labelPM
			// 
			resources.ApplyResources(this.labelPM, "labelPM");
			this.labelPM.Name = "labelPM";
			// 
			// labelAM
			// 
			resources.ApplyResources(this.labelAM, "labelAM");
			this.labelAM.Name = "labelAM";
			// 
			// labelAlgorithm
			// 
			resources.ApplyResources(this.labelAlgorithm, "labelAlgorithm");
			this.labelAlgorithm.Name = "labelAlgorithm";
			// 
			// groupBoxCalendar
			// 
			resources.ApplyResources(this.groupBoxCalendar, "groupBoxCalendar");
			this.groupBoxCalendar.Controls.Add(this.CurrentEra);
			this.groupBoxCalendar.Controls.Add(this.labelEra);
			this.groupBoxCalendar.Controls.Add(this.NativeName);
			this.groupBoxCalendar.Controls.Add(this.labelNativeName);
			this.groupBoxCalendar.Controls.Add(this.labelAlgorithm);
			this.groupBoxCalendar.Controls.Add(this.Algorithm);
			this.groupBoxCalendar.Name = "groupBoxCalendar";
			this.groupBoxCalendar.TabStop = false;
			// 
			// labelEra
			// 
			resources.ApplyResources(this.labelEra, "labelEra");
			this.labelEra.Name = "labelEra";
			// 
			// labelNativeName
			// 
			resources.ApplyResources(this.labelNativeName, "labelNativeName");
			this.labelNativeName.Name = "labelNativeName";
			// 
			// CurrentEra
			// 
			resources.ApplyResources(this.CurrentEra, "CurrentEra");
			this.CurrentEra.BackColor = System.Drawing.SystemColors.Info;
			this.CurrentEra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CurrentEra.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CurrentEra.Name = "CurrentEra";
			// 
			// NativeName
			// 
			resources.ApplyResources(this.NativeName, "NativeName");
			this.NativeName.BackColor = System.Drawing.SystemColors.Info;
			this.NativeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.NativeName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NativeName.Name = "NativeName";
			// 
			// Algorithm
			// 
			resources.ApplyResources(this.Algorithm, "Algorithm");
			this.Algorithm.BackColor = System.Drawing.SystemColors.Info;
			this.Algorithm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Algorithm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Algorithm.Name = "Algorithm";
			// 
			// PM
			// 
			resources.ApplyResources(this.PM, "PM");
			this.PM.BackColor = System.Drawing.SystemColors.Info;
			this.PM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PM.Name = "PM";
			// 
			// AM
			// 
			resources.ApplyResources(this.AM, "AM");
			this.AM.BackColor = System.Drawing.SystemColors.Info;
			this.AM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.AM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AM.Name = "AM";
			// 
			// listMonths
			// 
			this.listMonths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMonth,
            this.columnMonthAbbr});
			this.listMonths.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.listMonths, "listMonths");
			this.listMonths.FullRowSelect = true;
			this.listMonths.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listMonths.HideSelection = false;
			this.listMonths.Name = "listMonths";
			this.listMonths.UseCompatibleStateImageBehavior = false;
			this.listMonths.View = System.Windows.Forms.View.Details;
			// 
			// columnMonth
			// 
			resources.ApplyResources(this.columnMonth, "columnMonth");
			// 
			// columnMonthAbbr
			// 
			resources.ApplyResources(this.columnMonthAbbr, "columnMonthAbbr");
			// 
			// MonthsPerYear
			// 
			resources.ApplyResources(this.MonthsPerYear, "MonthsPerYear");
			this.MonthsPerYear.BackColor = System.Drawing.SystemColors.Info;
			this.MonthsPerYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MonthsPerYear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MonthsPerYear.Name = "MonthsPerYear";
			// 
			// FirstDay
			// 
			resources.ApplyResources(this.FirstDay, "FirstDay");
			this.FirstDay.BackColor = System.Drawing.SystemColors.Info;
			this.FirstDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FirstDay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FirstDay.Name = "FirstDay";
			// 
			// listDays
			// 
			this.listDays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDay,
            this.columnDayAbbr,
            this.columnDayShortest});
			this.listDays.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.listDays, "listDays");
			this.listDays.FullRowSelect = true;
			this.listDays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listDays.HideSelection = false;
			this.listDays.Name = "listDays";
			this.listDays.UseCompatibleStateImageBehavior = false;
			this.listDays.View = System.Windows.Forms.View.Details;
			// 
			// columnDay
			// 
			resources.ApplyResources(this.columnDay, "columnDay");
			// 
			// columnDayAbbr
			// 
			resources.ApplyResources(this.columnDayAbbr, "columnDayAbbr");
			// 
			// columnDayShortest
			// 
			resources.ApplyResources(this.columnDayShortest, "columnDayShortest");
			// 
			// CalendarForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.groupBoxCalendar);
			this.Controls.Add(this.groupBoxTime);
			this.Controls.Add(this.groupBoxMonths);
			this.Controls.Add(this.groupBoxDays);
			this.Controls.Add(this.buttonClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CalendarForm";
			this.ShowInTaskbar = false;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
			this.groupBoxDays.ResumeLayout(false);
			this.groupBoxDays.PerformLayout();
			this.groupBoxMonths.ResumeLayout(false);
			this.groupBoxMonths.PerformLayout();
			this.groupBoxTime.ResumeLayout(false);
			this.groupBoxTime.PerformLayout();
			this.groupBoxCalendar.ResumeLayout(false);
			this.groupBoxCalendar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		public void UpdateCulture (CultureInfo ci)
		{
			culture = ci;
			if (null == ci)
			{
				FirstDay.Text = String.Empty;
				AM.Text = String.Empty;
				PM.Text = String.Empty;
				Algorithm.Text = String.Empty;
				NativeName.Text = String.Empty;
				CurrentEra.Text = String.Empty;
				checkGenitiveMonths.Enabled = false;
			}
			else if (ci.IsNeutralCulture)
			{
				FirstDay.Text = Properties.Resources.NotAvailable;
				AM.Text = Properties.Resources.NotAvailable;
				PM.Text = Properties.Resources.NotAvailable;
				Algorithm.Text = Properties.Resources.NotAvailable;
				NativeName.Text = Properties.Resources.NotAvailable;
				CurrentEra.Text = Properties.Resources.NotAvailable;
				checkGenitiveMonths.Enabled = false;
			}
			else
			{
				DayOfWeek firstDay = ci.DateTimeFormat.FirstDayOfWeek;

				FirstDay.Text = ci.DateTimeFormat.GetDayName(firstDay);
				AM.Text = ci.DateTimeFormat.AMDesignator;
				PM.Text = ci.DateTimeFormat.PMDesignator;
				NativeName.Text = ci.DateTimeFormat.NativeCalendarName;
				CurrentEra.Text = ci.DateTimeFormat.GetEraName(ci.DateTimeFormat.Calendar.GetEra(DateTime.Now));

				checkGenitiveMonths.Enabled = AreGenitiveMonthsSignificant(ci.DateTimeFormat);

				switch (ci.DateTimeFormat.Calendar.AlgorithmType)
				{
					case CalendarAlgorithmType.LunarCalendar:
						Algorithm.Text = Properties.Resources.LunarCalendarType;
						break;

					case CalendarAlgorithmType.LunisolarCalendar:
						Algorithm.Text = Properties.Resources.LuniSolarCalendarType;
						break;

					case CalendarAlgorithmType.SolarCalendar:
						Algorithm.Text = Properties.Resources.SolarCalendarType;
						break;

					case CalendarAlgorithmType.Unknown:
						Algorithm.Text = Properties.Resources.UnknowCalendarType;
						break;
				}
			}

			UpdateDayInfo(ci);
			UpdateMonthInfo(ci, checkGenitiveMonths.Checked);
		}

		private void UpdateDayInfo (CultureInfo ci)
		{
			listDays.Items.Clear();

			if ((null == ci) || ci.IsNeutralCulture)
			{
				listDays.RightToLeft = RightToLeft.No;
				listDays.RightToLeftLayout = false;
			}

			else
			{
				string[] names = new string[3];
				string[] DayNames = ci.DateTimeFormat.DayNames;
				string[] AbbDayNames = ci.DateTimeFormat.AbbreviatedDayNames;

				listDays.RightToLeft = (ci.TextInfo.IsRightToLeft) ? RightToLeft.Yes : RightToLeft.No;
				listDays.RightToLeftLayout = (ci.TextInfo.IsRightToLeft) ? true : false;

				DayOfWeek firstDay = ci.DateTimeFormat.FirstDayOfWeek;
				DayOfWeek currentDay;

				// in order to fill the days information correctly for the current
				// culture, we need to do a bit of work in order to start showing 
				// the days with the first day of the week for this culture.
				int daysPerWeek = DayNames.Length;
				for (int i = 0; i < daysPerWeek; i++)
				{
					currentDay = (DayOfWeek)(((int)firstDay + i) % daysPerWeek);
					names[0] = ci.DateTimeFormat.GetDayName(currentDay);
					names[1] = ci.DateTimeFormat.GetAbbreviatedDayName(currentDay);
					names[2] = ci.DateTimeFormat.GetShortestDayName(currentDay);
					listDays.Items.Add(new ListViewItem(names));
				}
			}
		}

		private void UpdateMonthInfo (CultureInfo ci, bool useGenitiveMonthNames)
		{
			listMonths.Items.Clear();

			if (null == ci)
			{
				MonthsPerYear.Text = String.Empty;
				listMonths.RightToLeft = RightToLeft.No;
				listMonths.RightToLeftLayout = false;
			}
			else if (ci.IsNeutralCulture)
			{
				MonthsPerYear.Text = Properties.Resources.NotAvailable;
				listMonths.RightToLeft = RightToLeft.No;
				listMonths.RightToLeftLayout = false;
			}
			else
			{
				listMonths.RightToLeft = (ci.TextInfo.IsRightToLeft) ? RightToLeft.Yes : RightToLeft.No;
				listMonths.RightToLeftLayout = (ci.TextInfo.IsRightToLeft) ? true : false;

				string[] MonthNames = useGenitiveMonthNames ? ci.DateTimeFormat.MonthGenitiveNames : ci.DateTimeFormat.MonthNames;
				string[] AbbMonthNames = useGenitiveMonthNames ? ci.DateTimeFormat.AbbreviatedMonthGenitiveNames : ci.DateTimeFormat.AbbreviatedMonthNames;

				int monthsPerYear = MonthNames.Length;
				// we need to check if the last month is actually significant or not
				// as there are calendars where there are potentially more than 12 
				// months for a given year... 
				// the MonthName table actually accomodates for these, which means that 
				// the size of the table may not yield significant results for all calendars
				while (monthsPerYear > 12 && String.Empty == MonthNames[monthsPerYear - 1])
					monthsPerYear--;
				MonthsPerYear.Text = monthsPerYear.ToString();

				string[] names = new string[2];
				for (int i = 0; i < monthsPerYear; i++)
				{
					names[0] = MonthNames[i];
					names[1] = AbbMonthNames[i];
					listMonths.Items.Add(new ListViewItem(names));
				}
			}
		}

		public bool AreGenitiveMonthsSignificant (DateTimeFormatInfo dtfi)
		{
			string[] monthNames = dtfi.MonthNames;
			string[] genitiveMonthNames = dtfi.MonthGenitiveNames;
			bool isSignificant = false;

			for (int i = 0; !isSignificant && i < monthNames.Length; i++)
				if (0 != String.CompareOrdinal(monthNames[i], genitiveMonthNames[i]))
					isSignificant = true;

			return isSignificant;
		}

		public void ClassColor (ProgramSettings.ClassColor cc)
		{
			switch (cc)
			{
				case ProgramSettings.ClassColor.ApplyDateTimeFormatInfo:
					ColorDTFI(ProgramSettings.colorDateTimeFormatInfo);
					break;

				case ProgramSettings.ClassColor.ClearDateTimeFormatInfo:
					ColorDTFI(ProgramSettings.colorNone);
					break;

				case ProgramSettings.ClassColor.ApplyCalendar:
					ColorCalendar(ProgramSettings.colorCalendar);
					break;

				case ProgramSettings.ClassColor.ClearCalendar:
					ColorCalendar(ProgramSettings.colorNone);
					break;
			}
		}

		private void ColorDTFI (Color color)
		{
			FirstDay.BackColor = color;
			MonthsPerYear.BackColor = color;
			AM.BackColor = color;
			PM.BackColor = color;
			NativeName.BackColor = color;
			CurrentEra.BackColor = color;
		}

		private void ColorCalendar (Color color)
		{
			Algorithm.BackColor = color;
		}

		private void buttonClose_Click (object sender, System.EventArgs e)
		{
			Close();
		}

		private void OnClosing (object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

		private void checkGenitiveMonths_CheckedChanged (object sender, EventArgs e)
		{
			UpdateMonthInfo(culture, checkGenitiveMonths.Checked);
		}
	}
}
