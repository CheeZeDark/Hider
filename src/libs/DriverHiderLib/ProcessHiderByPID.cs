using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class ProcessHiderByPID
    {
        public void ProcessHider(string inherit_type, int process_hide_idprocess)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "hiddencli";
            start.Arguments = $"/protect pid {inherit_type} {process_hide_idprocess.ToString()} && timeout /t 15 /nobreak";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = false;
            start.WindowStyle = ProcessWindowStyle.Normal;
            start.Verb = "runas";
            Process.Start(start);
        }
    }
}
