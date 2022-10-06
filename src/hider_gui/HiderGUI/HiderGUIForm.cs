using DriverHiderLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiderGUI
{
    public partial class HiderGUIForm : Form
    {
        public HiderGUIForm()
        {
            InitializeComponent();
        }

        private void installdependencies_Click(object sender, EventArgs e)
        {
            installdependencies.ForeColor = Color.Blue;
            Thread.Sleep(500);
            installdependencies.ForeColor = Color.FromArgb(117, 118, 90);
            var install_dep = new InstallDependencies();
            install_dep.Show();
        }

        private void readme_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Temp"))
            {
                string notepad = "notepad.exe";
                string read_me = "Thanks to using this program" + Environment.NewLine + "I created this program to hide unwanted files or directories from people, and if suddenly you are a cheater or something else, then this will help you quickly hide files from verification." + Environment.NewLine + "Made by CheeZeDark";
                File.WriteAllText(@"C:\Temp\ReadMe_Hider.txt", read_me);
                string hider_readme = @"C:\Temp\ReadMe_Hider.txt";
                Process.Start(notepad, hider_readme);
            }
            else
            {
                throw new DirectoryNotFoundException("Directory Temp is Not Founded... Pls Check this folder and Try Again");
            }
        }

        private void supportme_on_patreon_Click(object sender, EventArgs e)
        {
            string patreon_cheezedark = "https://www.patreon.com/cheezedarkofficial";
            Process.Start("msedge.exe", patreon_cheezedark);
        }

        private void hide_process_by_pid_Click(object sender, EventArgs e)
        {
            var hide_pid = new HideProcByID();
            hide_pid.Show();
        }

        private void hidedll_files_Click(object sender, EventArgs e)
        {
            string hiddencli_execution = "hiddencli.exe";
            if (File.Exists($@"C:\Windows\{hiddencli_execution}"))
            {
                DLLHider hider = new DLLHider();
                OpenFileDialog d = new OpenFileDialog();
                d.Title = "Please Select DLL File";
                d.InitialDirectory = Environment.CurrentDirectory;
                d.Filter = "DLL File | *.dll";
                d.CheckFileExists = true;
                if(d.ShowDialog() == DialogResult.OK)
                {
                    hider.DLLHide(d.FileName);
                }
                else
                {
                    MessageBox.Show("You Canceled Hide DLL File!!!");
                }
            }
            else
            {
                File.WriteAllText(@"C:\Temp\DLLNotFound.txt", "Error!!! DLL Not Found!!! Please Try Again or Relaunch HiderGUI.exe As Admin!!!!! Or You Canceled Hiding DLL File!!!");
                Process.Start("notepad.exe", @"C:\Temp\DLLNotFound.txt");
                Environment.Exit(2230);
            }
        }

        private void hidefiles_Click(object sender, EventArgs e)
        {
            FileHider file = new FileHider();
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Please Select Anyone File";
            d.InitialDirectory = Environment.CurrentDirectory;
            d.Filter = "Anyone File | *.*";
            d.CheckFileExists = true;
            if (d.ShowDialog() == DialogResult.OK)
            {
                file.HideFile(d.FileName);
            }
            else
            {
                throw new Exception("File Not Found or This File Secured by SYSTEM or TRUSTEDINSTALLER!!!");
            }
        }

        private void prot_image_Click(object sender, EventArgs e)
        {
            ProtectProcessByImage image = new ProtectProcessByImage();
            OpenFileDialog o_d = new OpenFileDialog();
            o_d.Title = "Select File";
            o_d.InitialDirectory = Environment.CurrentDirectory;
            o_d.Filter = " Any File | *.*";
            o_d.CheckFileExists = true;
            if(o_d.ShowDialog() == DialogResult.OK)
            {
                image.ProtectProcessImage("always", "forall", o_d.FileName);
            }
            else
            {
                MessageBox.Show("Canceled Protect File by Image!!!");
            }
        }

        private void clicker_dsd_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\DriverSignatureDisabler.exe"))
            {
                Process.Start(Environment.CurrentDirectory + "\\DriverSignatureDisabler.exe");
            }
            else
            {
                throw new Exception("DriverSignatureDisabler Not Found!!!");
            }
        }
    }
}
