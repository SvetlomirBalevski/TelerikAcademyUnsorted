using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
   static class PrintForResourceClasses
    {
       public static string FormatBeforePrinting(string name, string url, string type)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("    * Resource:");
            result.AppendLine($"     - Name: {name}");
            result.AppendLine($"     - Url: {url}");
            result.AppendLine($"     - Type: {type}");
            return result.ToString();

        }
    }
}
