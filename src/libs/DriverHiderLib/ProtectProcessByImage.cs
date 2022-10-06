using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class ProtectProcessByImage //Protect Process by Image(OpenFileDialog in HiderGUI)
    {
        public void ProtectProcessImage(string inherit_type, string apply_type, string currentfilename) //Inherited: none, always or once, Apply Type: fornew or forall and Path(currentfilename) :D
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "hiddencli";
            start.Arguments = $"/protect image {inherit_type} {apply_type} {currentfilename}";
            start.UseShellExecute = true;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = false;
            start.WindowStyle = ProcessWindowStyle.Normal;
            start.Verb = "runas";
            Process.Start(start);
        }
    }
}
