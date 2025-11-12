

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Juniper.WinUI.App.Converters
{
    public class PropertyNamesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is null)
                return "";

            var returned = new StringBuilder();
            Type t = value.GetType();
            foreach (var prop in t.GetProperties())
            {
                var obj = prop.GetValue(value);

                if (obj is string val)
                {
                    returned.AppendLine(string.Join(": ", prop.Name, val));
                }
                else
                {
                    ReadPropertiesRecursive(returned, obj);
                }
            }


            return returned.ToString();
        }

        private void ReadPropertiesRecursive(StringBuilder sb, object parent)
        {
            if (parent is IList objList)
            {
                foreach (var item in objList)
                {
                    ReadPropertiesRecursive(sb, item);
                }
            }
            else
            {
                if (parent == null) return;

                var type = parent.GetType();
                foreach (PropertyInfo property in type.GetProperties())
                {
                    var obj = property.GetValue(parent);
                    if (obj is null)
                        continue;

                    //if (obj is string val)
                    //{
                    //    sb.AppendLine(string.Join(": ",property.DeclaringType?.Name ?? "", property.Name, val));
                    //}
                    //else
                    if ((obj is string) ||
                        (!property.PropertyType.IsClass && obj.ToString() is string))
                    {
                        sb.AppendLine(string.Join(": ", property.DeclaringType?.Name ?? "", property.Name, obj.ToString()));
                    }
                    else if (property.PropertyType.IsClass)
                    {
                        sb.AppendLine(string.Join(": ", property.DeclaringType?.Name ?? "", property.Name));
                        ReadPropertiesRecursive(sb, obj);
                    }
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            //return value;
            //if (value is string val)
            //    return val;
            throw new NotImplementedException();
        }
    }
}