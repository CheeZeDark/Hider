using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class DirectoryUnhider
    {
        public void DirUnhide()
        {
            ProcessStartInfo str = new ProcessStartInfo();
            str.FileName = "hiddencli";
            str.Arguments = "/unhide dir all";
            str.UseShellExecute = true;
            str.RedirectStandardOutput = true;
            str.CreateNoWindow = true;
            str.WindowStyle = ProcessWindowStyle.Normal;
            str.Verb = "runas";
            Process.Start(str);
        }
    }
}
