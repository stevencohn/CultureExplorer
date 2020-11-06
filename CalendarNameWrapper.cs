using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CultureExplorer20
{
  public class CalendarNameWrapper
  {
    private Calendar internalCalendar;
    
    public CalendarNameWrapper(Calendar calendar)
    {
      this.internalCalendar = calendar;
    }
    
    public Calendar Calendar
    {
      get { return internalCalendar; }
    }

    public override string ToString()
    {
      string displayName;

      if (internalCalendar is System.Globalization.ChineseLunisolarCalendar)
        return Properties.Resources.ChineseLunisolarCalendar;

      else if (internalCalendar is System.Globalization.EastAsianLunisolarCalendar)
        return Properties.Resources.EastAsianLunisolarCalendar;

      else if (internalCalendar is System.Globalization.GregorianCalendar)
      {
        GregorianCalendar gc = internalCalendar as GregorianCalendar;
        string GregorianTypeName = String.Empty;
        switch (gc.CalendarType)
        {
          case GregorianCalendarTypes.Arabic:
            GregorianTypeName = Properties.Resources.GregorianTypeArabic;
            break;

          case GregorianCalendarTypes.Localized:
            GregorianTypeName = Properties.Resources.GregorianTypeLocalized;
            break;

          case GregorianCalendarTypes.MiddleEastFrench:
            GregorianTypeName = Properties.Resources.GregorianTypeMiddleEastFrench;
            break;

          case GregorianCalendarTypes.TransliteratedEnglish:
            GregorianTypeName = Properties.Resources.GregorianTypeTransliteratedEnglish;
            break;

          case GregorianCalendarTypes.TransliteratedFrench:
            GregorianTypeName = Properties.Resources.GregorianTypeTransliteratedFrench;
            break;

          case GregorianCalendarTypes.USEnglish:
            GregorianTypeName = Properties.Resources.GregorianTypeUSEnglish;
            break;
        }
        return String.Format(Properties.Resources.GregorianNameFormat, Properties.Resources.GregorianCalendar, GregorianTypeName);
      }

      else if (internalCalendar is System.Globalization.HebrewCalendar)
        return Properties.Resources.HebrewCalendar;

      else if (internalCalendar is System.Globalization.HijriCalendar)
        return Properties.Resources.HijriCalendar;

      else if (internalCalendar is System.Globalization.JapaneseCalendar)
        return Properties.Resources.JapaneseCalendar;

      else if (internalCalendar is System.Globalization.JapaneseLunisolarCalendar)
        return Properties.Resources.JapaneseLunisolarCalendar;

      else if (internalCalendar is System.Globalization.JulianCalendar)
        return Properties.Resources.JulianCalendar;

      else if (internalCalendar is System.Globalization.KoreanCalendar)
        return Properties.Resources.KoreanCalendar;

      else if (internalCalendar is System.Globalization.KoreanLunisolarCalendar)
        return Properties.Resources.KoreanLunisolarCalendar;

      else if (internalCalendar is System.Globalization.PersianCalendar)
        return Properties.Resources.PersianCalendar;

      else if (internalCalendar is System.Globalization.TaiwanCalendar)
        return Properties.Resources.TaiwanCalendar;

      else if (internalCalendar is System.Globalization.TaiwanLunisolarCalendar)
        return Properties.Resources.TaiwanLunisolarCalendar;

      else if (internalCalendar is System.Globalization.ThaiBuddhistCalendar)
        return Properties.Resources.ThaiBuddhistCalendar;

      else if (internalCalendar is System.Globalization.UmAlQuraCalendar)
        return Properties.Resources.UmAlQuraCalendar;

      else
        displayName = Calendar.ToString();

      return displayName;
    }
  }
}
