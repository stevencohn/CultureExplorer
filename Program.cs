using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CultureExplorer20
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }

  public class ProgramSettings
  {
    public static Color colorNone               = Color.FromKnownColor(KnownColor.Info);
    public static Color colorCultureInfo        = Color.FromKnownColor(KnownColor.LightSteelBlue);
    public static Color colorRegionInfo         = Color.FromKnownColor(KnownColor.Tomato);
    public static Color colorNumberFormatInfo   = Color.FromKnownColor(KnownColor.Chartreuse);
    public static Color colorDateTimeFormatInfo = Color.FromKnownColor(KnownColor.Khaki);
    public static Color colorTextInfo           = Color.FromKnownColor(KnownColor.Thistle);
    public static Color colorCalendar           = Color.FromKnownColor(KnownColor.Tan);

    public enum ClassColor
    {
      None,
      ApplyCultureInfo,
      ApplyRegionInfo,
      ApplyNumberFormatInfo,
      ApplyDateTimeFormatInfo,
      ApplyTextInfo,
      ApplyCalendar,
      ClearCultureInfo,
      ClearRegionInfo,
      ClearNumberFormatInfo,
      ClearDateTimeFormatInfo,
      ClearTextInfo,
      ClearCalendar
    };
  }

  public enum CultureIcons
  {
    // defined in the same order as icons in the TreeViewIcons.png file
    Framework   = 0,
    Invariant   = 1,
    Neutral     = 2,
    Specific    = 3,
    Custom      = 4, 
    Replacement = 5,
    WinOnly     = 6,
    Installed   = 7,
    All         = 8
  };

  public enum CultureType
  {
    NotACulture,
    Invariant,
    Neutral,
    Specific
  }
}