using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverHiderLib
{
    public class FindProcessByID
    {
        public int GetProcessByID(string proc)
        {
            int proc_id = 0;
            Process[] proc_mder = Process.GetProcessesByName(proc);
            foreach(Process any_process in proc_mder)
            {
                proc_id = any_process.Id;
            }
            return proc_id;
        }
    }
}
