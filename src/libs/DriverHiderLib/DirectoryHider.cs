using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class DirectoryHider
    {
        public void DirectoryHide(string directory_current)
        {
            if (Directory.Exists(directory_current))
            {
                ProcessStartInfo str = new ProcessStartInfo();
                str.FileName = "hiddencli";
                str.Arguments = $"/hide dir {directory_current}";
                str.UseShellExecute = true;
                str.RedirectStandardOutput = true;
                str.CreateNoWindow = true;
                str.WindowStyle = ProcessWindowStyle.Normal;
                str.Verb = "runas";
                Process.Start(str);
            }
            else
            {
                throw new DirectoryNotFoundException("[-] Directory not Founded");
            }
        }
    }
}
