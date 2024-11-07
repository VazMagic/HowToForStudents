using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo.Models
{
    public static class CurrentPath
    {
        static string loc = string.Empty;

        public static string GetCurrentPath()
        {
            loc = Directory.GetCurrentDirectory();

            loc = loc.Substring(0, loc.IndexOf("\\bin"));

            return loc;
        }

        public static string GetDbasePath()
        {
            loc = GetCurrentPath() + "\\Dbase";

            return loc;
        }
    }
}
