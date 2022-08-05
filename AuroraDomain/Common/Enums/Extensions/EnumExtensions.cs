using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PojetoAurora.Dominio.Common.Enums.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum source)
        {
            string lResult = string.Empty;

            FieldInfo lFieldInfo = source.GetType().GetField(source.ToString());

            DescriptionAttribute lDescriptionAttribute = lFieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute;

            if (lDescriptionAttribute != null)
                lResult = lDescriptionAttribute.Description;

            return lResult;
        }
    }
}
