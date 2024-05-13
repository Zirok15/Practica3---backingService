using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCreator.Models
{
    public class CodeCreator
    {
        public string CreateCode(string name, string lastName, int ci)
        {
            ArgumentNullException.ThrowIfNull(name);
            ArgumentNullException.ThrowIfNull(lastName);

            string code = string.Empty;
            try
            {
                code += name[0].ToString().ToUpper();
                code += lastName[0].ToString().ToUpper();
                code += "-";
                code += ci;
                return code;
            }
            catch (IndexOutOfRangeException ex)
            {
                Log.Error(ex.Message);
                return string.Empty;
            }
        }
    }
}
