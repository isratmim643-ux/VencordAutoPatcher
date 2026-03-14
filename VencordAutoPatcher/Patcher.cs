using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VencordAutoPatcher
{
    internal class Patcher
    {
        public static void PatchDiscord(string installerPath)
        {
            using (WebClient web = new WebClient())
                web.DownloadFile("https://github.com/Vencord/Installer/releases/latest/download/VencordInstallerCli.exe", installerPath);

            foreach (var process in Process.GetProcessesByName("Discord"))
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                }
                catch { }
            }

            Process patcher = new Process();
            patcher.StartInfo.FileName = installerPath;
            patcher.StartInfo.Arguments = "-install -branch auto";
            patcher.StartInfo.UseShellExecute = false;

            patcher.Start();
            patcher.WaitForExit();

            Program.Notify("Patching has been completed.");
        }
    }
}
