using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DriverSignatureDisabler
{
    class Program
    {
        static void CMDArguments(string exec, string args, string verb)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = exec;
            info.Arguments = args;
            info.UseShellExecute = true; //Set True if you have Console Version of .NET Program, and set false if you have Windows(GUI) Version of .NET Program :D
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.Verb = verb;
            Process.Start(info);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose Options: \n1. Disable Driver Signatures \n2. Enable Driver Signatures");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear(); //Clear Console From This Options :D
                        Console.WriteLine("Disabling Driver Signatures...");
                        Thread.Sleep(4500); //4.5 seconds Sleeping!!! :D
                        CMDArguments("kdu", "-dse 0", "runas"); //This is Very Easy to Execute CMD Arguments...(Or Anyone Program on Windows Root Folder) :D
                        Console.WriteLine("Success!!!"); //Success!!! Verification Driver Signatures is Disabled!!!
                        Thread.Sleep(5000);
                        break; //stopping switching!!! :D
                    } 
                case "2":
                    {
                        Console.Clear(); //Again Clearing Console :D
                        Console.WriteLine("Enabling Driver Signatures...");
                        Thread.Sleep(4500); 
                        CMDArguments("kdu", "-dse 6", "runas"); //Easy Code!!! :D
                        Console.WriteLine("Success!!!"); //saying what Verification Driver Signatures is Enabled Again :D
                        Thread.Sleep(5000);
                        break;
                    }
                default:
                    {
                        //Default!!! :D
                        Environment.Exit(123);
                        break;
                    }
            }
        }
    }
}
