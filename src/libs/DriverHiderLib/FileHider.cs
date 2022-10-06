using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class FileHider
    {
        public void HideFile(string file_name)
        {
            ProcessStartInfo str = new ProcessStartInfo();
            str.FileName = "hiddencli";
            str.Arguments = $"/hide file {file_name}";
            str.UseShellExecute = false;
            str.RedirectStandardOutput = true;
            str.CreateNoWindow = true;
            str.WindowStyle = ProcessWindowStyle.Normal;
            str.Verb = "runas";
            Process.Start(str);
        }
    }
}
