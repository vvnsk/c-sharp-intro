using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            var result = string.Empty;

            if (string.IsNullOrWhiteSpace(source)) return result;
            foreach (var letter in source)
            {
                if (char.IsUpper(letter))
                {
                    // Trim any space already there
                    result = result.Trim();
                    result += " ";
                }

                result += letter;
            }

            result = result.Trim();
            return result;
        }
    }
}
