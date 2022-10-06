using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class DLLHider
    {
        public void DLLHide(string current_dll_path_withdotdll)
        {
            if (File.Exists(current_dll_path_withdotdll))
            {
                ProcessStartInfo str = new ProcessStartInfo();
                str.FileName = "hiddencli";
                str.Arguments = $"/hide file {current_dll_path_withdotdll}"; //Hide File 
                str.UseShellExecute = true;
                str.RedirectStandardOutput = true;
                str.CreateNoWindow = true;
                str.WindowStyle = ProcessWindowStyle.Normal;
                str.Verb = "runas";
                Process.Start(str);
                Process[] pr = Process.GetProcessesByName(str.ToString()); //Getting HiddenCLI Window as String!!!
                foreach (Process m in pr)
                {
                    StreamReader stream = m.StandardOutput;
                    string sn_stream = String.Empty;
                    sn_stream = stream.ReadToEnd();
                    File.WriteAllText(@"C:\Temp\hidden_ruleid.bin", sn_stream);
                }
            }
        }
    }
}
