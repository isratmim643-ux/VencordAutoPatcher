using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace VencordAutoPatcher
{
    internal class AutoRun
    {
        public static void AddToStartup()
        {
            Console.Clear();

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Vencord Auto Patcher", $"{Assembly.GetExecutingAssembly().Location.Replace(".dll", ".exe")} -autorun");
            key.Close();
        }

        public static void RemoveFromStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key.GetValue("Vencord Auto Patcher") != null)
                key.DeleteValue("Vencord Auto Patcher");

            key.Close();
        }
    }
}