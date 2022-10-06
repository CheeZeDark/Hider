using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriverHiderLib;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace HiderGUI
{
    public partial class HideProcByID : Form
    {
        public HideProcByID()
        {
            InitializeComponent();
        }

        private void hide_proc_by_id_Click(object sender, EventArgs e)
        {
            FindProcessByID id = new FindProcessByID();
            ProcessHiderByPID pid_proc = new ProcessHiderByPID();
            if(HideProc.Text == String.Empty)
            {
                throw new Exception("Text is Empty!!!");
            }
            else if(HideProc.Text == "notepad")
            {
                DialogResult result = MessageBox.Show("WARNING!!! Are You Sure About That? \n One wrong will be equal to the program not working!!!", "Hider", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    int proc = 0;
                    proc = id.GetProcessByID(HideProc.Text);
                    File.WriteAllText(@"C:\Temp\PID.txt", proc.ToString());
                    Process.Start("notepad", @"C:\Temp\PID.txt");
                    pid_proc.ProcessHider("none", proc);
                }
                else
                {
                    //If you Clicked No... This Will Be Show MessageBox what you clicked no, and refused to hide notepad.exe :D
                    MessageBox.Show("Okay... Process will not Hidden by This Program!!!", "Hider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close(); //Closing Form :D
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Are You Sure, what you write correctly Process Name?", "Hider", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    MessageBox.Show($"Your Process Name: {HideProc.Text}, Please Wait while this is trying to Hide Process by PID", "Hider");
                    Thread.Sleep(15000);
                    int text_box = id.GetProcessByID(HideProc.Text);
                    pid_proc.ProcessHider("once", text_box);
                }
                else
                {
                    MessageBox.Show("You Canceled Hiding Process By PID!!!");
                    this.Close();
                }
            }
        }
    }
}
