using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnpUtil.INFInstall
{
    public class PnpInstall
    {
        public bool InstallINF(string inf_name)
        {
            if (File.Exists(inf_name))
            {
                ProcessStartInfo inf = new ProcessStartInfo();
                inf.FileName = "cmd.exe";
                inf.Arguments = $"/c pnputil /add-driver {inf_name} -install";
                inf.UseShellExecute = false; // This is Library for HiderGUI :D
                inf.Verb = "runas";
                inf.WindowStyle = ProcessWindowStyle.Normal; //Normal ProcessWindowStyle for Showing Errors or Something Else :D
                Process.Start(inf);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
