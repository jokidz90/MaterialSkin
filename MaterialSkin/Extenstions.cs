using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin
{
    public static class Extenstions
    {
        public static Control GetChildControlByName(this Control mainCtrl, string name)
        {
            Control ctrl = null;

            foreach (Control child in mainCtrl.Controls)
            {
                if (child.Name == name)
                {
                    ctrl = child;
                    break;
                }
            }

            return ctrl;
        }
        public static Color GetColor(this Brush brush)
        {
            return new Pen(brush).Color;
        }

        public static string ToUpperFirst(this string source)
        {
            return source.ToLower().Remove(0, 1)
                    .Insert(0, source.Substring(0, 1).ToUpper());
        }

        public static int GetInt32Value(this string txt)
        {
            int val = 0;
            int.TryParse(txt, out val);
            return val;
        }

        public static bool IsEqual(this string val, string comparation)
        {
            bool isSame = false;

            isSame = (val + "").ToLower().Trim().Equals((comparation + "").ToLower().Trim());

            return isSame;
        }

        public static void GetDateRange(string dateRangeType, string cutOffStr, out DateTime startDate, out DateTime endDate)
        {
            startDate = DateTime.MinValue;
            endDate = DateTime.MaxValue;
            int cutOffHour = 0;
            int cutOffMin = 0;
            if (!cutOffStr.Contains(":"))
                cutOffHour = cutOffStr.GetInt32Value();
            else
            {
                cutOffHour = cutOffStr.Split(':')[0].GetInt32Value();
                cutOffMin = cutOffStr.Split(':')[1].GetInt32Value();
            }
            if (cutOffHour >= 24 || cutOffHour < 0)
                cutOffHour = 0;
            if (cutOffMin >= 60 || cutOffMin < 0)
                cutOffMin = 0;

            if (dateRangeType.IsEqual("YESTERDAY"))
            {
                startDate = DateTime.Now.Date.AddDays(-1).Date;
                endDate = DateTime.Now.Date.AddDays(-1).Date;
            }
            else if (dateRangeType.IsEqual("THISWEEK"))
            {
                startDate = DateTime.Now.Date.AddDays(-1 * (int)DateTime.Now.DayOfWeek).Date;
                endDate = startDate.AddDays(6).Date;
            }

            else if (dateRangeType.IsEqual("LASTWEEK"))
            {
                startDate = DateTime.Now.Date.AddDays(-1 * (int)DateTime.Now.DayOfWeek).AddDays(-7).Date;
                endDate = startDate.AddDays(6).Date;
            }
            else if (dateRangeType.IsEqual("THISMONTH"))
            {
                startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date;
                endDate = startDate.AddMonths(1).AddDays(-1).Date;
            }
            else if (dateRangeType.IsEqual("LASTMONTH"))
            {
                endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-1).Date;
                startDate = new DateTime(endDate.Year, endDate.Month, 1);
            }
            else if (dateRangeType.IsEqual("THISYEAR"))
            {
                startDate = new DateTime(DateTime.Now.Year, 1, 1).Date;
                endDate = new DateTime(DateTime.Now.Year, 12, 31).Date;
            }
            else if (dateRangeType.IsEqual("LASTYEAR"))
            {
                startDate = new DateTime(DateTime.Now.Year - 1, 1, 1).Date;
                endDate = new DateTime(DateTime.Now.Year - 1, 12, 31).Date;
            }
            else
            {
                startDate = DateTime.Now.Date;
                endDate = DateTime.Now.Date;
            }

            if (cutOffHour > 0)
            {
                startDate = startDate.AddHours(cutOffHour);
                endDate = endDate.AddHours(cutOffHour);
            }
            if (cutOffMin > 0)
            {
                startDate = startDate.AddMinutes(cutOffMin);
                endDate = endDate.AddMinutes(cutOffMin);
            }

            endDate = endDate.AddDays(1).AddSeconds(-1);
        }

        public static List<object> ConvertToList(this object obj)
        {
            List<object> result = null;

            try
            {
                result = ((IEnumerable<object>)obj).ToList();
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public static object GetProperty(this object obj, string propName)
        {
            object value = new object();

            try
            {
                if (string.IsNullOrEmpty(propName))
                    value = obj;
                else if (obj is ExpandoObject)
                    value = ((IDictionary<string, object>)obj)[propName];
                else
                {
                    PropertyInfo propertyInfo = obj.GetType().GetProperty(propName);
                    value = propertyInfo.GetValue(obj);
                }
            }
            catch (Exception ex)
            {
                value = new object();
            }

            return value;
        }

        public static unsafe Image ReplaceColor(this Image source, Color toReplace, Color replacement)
        {
            var bmp = new Bitmap(source);

            return (Image)bmp.ReplaceColor(toReplace, replacement);
        }
        public static unsafe Bitmap ReplaceColor(this Bitmap source, Color toReplace, Color replacement)
        {
            const int pixelSize = 4; // 32 bits per pixel

            Bitmap target = new Bitmap(
              source.Width,
              source.Height,
              PixelFormat.Format32bppArgb);

            BitmapData sourceData = null, targetData = null;

            try
            {
                sourceData = source.LockBits(
                  new Rectangle(0, 0, source.Width, source.Height),
                  ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                targetData = target.LockBits(
                  new Rectangle(0, 0, target.Width, target.Height),
                  ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                for (int y = 0; y < source.Height; ++y)
                {
                    byte* sourceRow = (byte*)sourceData.Scan0 + (y * sourceData.Stride);
                    byte* targetRow = (byte*)targetData.Scan0 + (y * targetData.Stride);

                    for (int x = 0; x < source.Width; ++x)
                    {
                        byte b = sourceRow[x * pixelSize + 0];
                        byte g = sourceRow[x * pixelSize + 1];
                        byte r = sourceRow[x * pixelSize + 2];
                        byte a = sourceRow[x * pixelSize + 3];

                        if (toReplace.R == r && toReplace.G == g && toReplace.B == b)
                        {
                            r = replacement.R;
                            g = replacement.G;
                            b = replacement.B;
                        }

                        targetRow[x * pixelSize + 0] = b;
                        targetRow[x * pixelSize + 1] = g;
                        targetRow[x * pixelSize + 2] = r;
                        targetRow[x * pixelSize + 3] = a;
                    }
                }
            }
            finally
            {
                if (sourceData != null)
                    source.UnlockBits(sourceData);

                if (targetData != null)
                    target.UnlockBits(targetData);
            }

            return target;
        }
    }

    public enum DateRangeType
    {
        TODAY,
        YESTERDAY,
        THISWEEK,
        LASTWEEK,
        THISMONTH,
        LASTMONTH,
        THISYEAR,
        LASTYEAR,
        CUSTOM
    }
}
