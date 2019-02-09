using System;
using System.Collections.Generic;
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
    }
}
