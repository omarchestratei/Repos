using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReflectorBase
{
   public class Util
    {

       public static string ObtenerTipo(Type tipo)
       {
           switch (Type.GetTypeCode(tipo))
           {
               case TypeCode.Decimal:
                   return "Decimal";

               case TypeCode.Int32:
                   return "Integer";

               case TypeCode.DateTime:
                   return "DateTime";
               default:
                   return "String";
           }
       }


       public static string ObtenerTipoCSharp(Type tipo)
       {
           switch (Type.GetTypeCode(tipo))
           {
               case TypeCode.Decimal:
                   return "decimal";

               case TypeCode.Int32:
                   return "int";

               case TypeCode.DateTime:
                   return "DateTime";

               case TypeCode.Boolean:
                   return "bool";
               default:
                   return "string";
           }
       }


       public static string ObtenerValorDefault(Type tipo)
       {
           switch (Type.GetTypeCode(tipo))
           {
               case TypeCode.Decimal:
                   return "0";

               case TypeCode.Int32:
                   return "0";

               case TypeCode.DateTime:
                   return "DateTime.Now";
               default:
                   return "Nothing";
           }
       }



       public static string PrefijoControl(Type tipo)
       {
           switch (Type.GetTypeCode(tipo))
           {
               case TypeCode.Decimal:
                   return "txt";

               case TypeCode.Int32:
                   return "txt";

               case TypeCode.DateTime:
                   return "dtp";
               case TypeCode.Boolean:
                   return "chk";
               default:
                   return "txt";
           }
       }



       public static bool EsTipoPrimitivo(Type t)
       {
           

           return t.IsPrimitive ||
               t == typeof(Decimal) ||
               t == typeof(String) ||
               t == typeof(DateTime) ||
               t == typeof(Boolean);
       }

    }
}
