using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUtilities
{
    class Activation
    {
        public static void ActivateWindowsHome()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr //B /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 & slmgr //B /skms kms8.msguides.com & slmgr //B /ato";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void ActivateWindowsHomeN()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr //B /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM & slmgr //B /skms kms8.msguides.com & slmgr //B /ato";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void ActivateWindowsPro()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr //B /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX & slmgr //B /skms kms8.msguides.com & slmgr //B /ato";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void ActivateWindowsProN()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr //B /ipk MH37W-N47XK-V7XM9-C7227-GCQG9 & slmgr //B /skms kms8.msguides.com & slmgr //B /ato";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void ActivateWindowsEnterprise()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr //B /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43 & slmgr //B /skms kms8.msguides.com & slmgr //B /ato";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
