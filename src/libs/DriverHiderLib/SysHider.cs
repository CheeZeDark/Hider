using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class SysHiderFile //Sys Class :D
    {

        public void DriverSysCheck(string filenamesys) //Check if Driver is Existing...
        {
            if (File.Exists(filenamesys))
            {
                Directory.CreateDirectory(@"C:\Temp");
                File.WriteAllText(@"C:\Temp\Hider.txt", "[+] Driver is Founded");
            }
            else
            {
                throw new NotImplementedException("[-] Oops... Driver is not Founded Success");
            }
        }

        public void HideDrvInSystem32(string sys32_filenamesys) //Hiding Driver in Current System32 Folder
        {
            if (File.Exists(sys32_filenamesys))
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "hiddencli";
                start.Arguments = $"/hide file {sys32_filenamesys}";
                start.UseShellExecute = true;
                start.RedirectStandardOutput = true;
                start.CreateNoWindow = false;
                start.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(start);
            }
            else
            {
                throw new Exception("[-] Driver in System32 Folder Not Founded");
            }
        }

        public void HideDrvInWindows(string windows_filehidename) //Hiding Driver In Windows Folder :D
        {
            if (File.Exists(windows_filehidename))
            {
                ProcessStartInfo xn = new ProcessStartInfo();
                xn.FileName = "hiddencli";
                xn.Arguments = $"/hide file {windows_filehidename}";
                xn.UseShellExecute = true;
                xn.RedirectStandardOutput = true;
                xn.CreateNoWindow = false;
                xn.WindowStyle = ProcessWindowStyle.Normal;
                xn.Verb = "runas";
                Process.Start(xn);
            }
            else
            {
                throw new Exception("[-] Driver Not Found");
            }
        }
    }
}
