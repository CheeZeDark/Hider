using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PnpUtil.INFInstall;
using System.Windows.Forms;

namespace HiderGUI
{
    public partial class InstallDependencies : Form
    {
        public void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //This is Very Important Code... DON'T CHANGE THIS!!! 

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        public void InstallHiddenDriver()
        {
            PnpInstall pnp_inst = new PnpInstall();
            pnp_inst.InstallINF("C:\\Windows\\Hidden.inf");
        }
        public InstallDependencies()
        {
            InitializeComponent();
            if (Directory.Exists(@"C:\Temp"))
            {
                Extract("HiderGUI", @"C:\Temp", "Resources", "kdu.zip");
                Extract("HiderGUI", @"C:\Temp", "Resources", "hiddendrvpluscli.zip");
                MessageBox.Show("Please wait... This Program Automatic Installed Dependencies for Hiding All U Needed");
                if (File.Exists(@"C:\Temp\kdu.zip"))
                {
                    ZipFile.ExtractToDirectory(@"C:\Temp\kdu.zip", @"C:\Windows", Encoding.Default); //Using Encoding by Default Please :D
                    if (File.Exists(@"C:\Temp\hiddendrvpluscli.zip"))
                    {
                        ZipFile.ExtractToDirectory(@"C:\Temp\hiddendrvpluscli.zip", @"C:\Windows", Encoding.Default);
                        InstallHiddenDriver();
                    }
                    else
                    {
                        throw new FileNotFoundException("KDU Not Found");
                    }
                }
                else
                {
                    throw new FileNotFoundException("KDU Not Found");
                }
                MessageBox.Show("Install Dependencies is Completed Successfully!!!", "Hider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                throw new Exception("Directory Not Found");
            }
        }
    }
}
