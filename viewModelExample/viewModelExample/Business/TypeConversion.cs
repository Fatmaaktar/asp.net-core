using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace viewModelExample.Business
{
    public class TypeConversion
    {
        public static TResult Conversion<T, TResult>(T model) where TResult : class, new()
        {
            TResult result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(prop =>
            {
               PropertyInfo property= typeof(TResult).GetProperty(prop.Name);
                property.SetValue(result,property.GetValue(model));
            });

            return result;
        }
    }
}
