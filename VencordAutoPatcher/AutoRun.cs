using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VencordAutoPatcher
{
    internal class AutoRun
    {
        public static void AddToStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Vencord Auto Patcher", Assembly.GetExecutingAssembly().Location.Replace(".dll", ".exe"));
            key.Close();
            ConsoleUtilities.Log("Successfully added VAP to Startup");
        }
    }
}
