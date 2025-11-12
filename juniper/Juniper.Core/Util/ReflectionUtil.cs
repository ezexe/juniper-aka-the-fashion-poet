namespace Juniper.Core.Util
{
    public static class ReflectionUtil
    {
        public static bool PropertysAreSame<T>(string propertyName, T self, T to) where T : class
        {
            Type type = typeof(T);
            object? selfValue = type.GetProperty(propertyName)?.GetValue(self);
            object? toValue = type.GetProperty(propertyName)?.GetValue(to);

            if (selfValue != toValue && (selfValue == null || !selfValue.Equals(toValue)))
            {
                return false;
            }
            return true;
        }

        public static bool IsAllClassPropertysSame<T>(T self, T to) where T : class
        {
            if (self != null && to != null)
            {
                Type type = typeof(T);
                foreach (PropertyInfo pi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (!PropertysAreSame(pi.Name, self, to))
                        return false;

                }
                return true;
            }

            return false;
        }

        public static void SetAllClassPropertysSame<T,T2>(T self, T2 from) 
            where T : class
            where T2 : class
        {
            if (self != null && from != null)
            {
                Type type = typeof(T);
                Type type2 = typeof(T2);
                foreach (PropertyInfo pi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    object? fromValue = type2.GetProperty(pi.Name)?.GetValue(from);
                    if (fromValue is not null)
                    {
                        pi.SetValue(self, from);
                    }

                }
            }
        }
    }
}