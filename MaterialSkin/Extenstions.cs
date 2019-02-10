using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkin
{
    public static class Extenstions
    {
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
}
