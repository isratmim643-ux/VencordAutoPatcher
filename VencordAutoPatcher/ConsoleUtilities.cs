using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VencordAutoPatcher
{
    internal class ConsoleUtilities
    {
        public static string Ask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[?] ");
            Console.ForegroundColor = ConsoleColor.Gray;
            return Console.ReadLine()?.Trim().ToLower();
        }

        public static void Log(string v)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("[*] ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(v);
        }
    }
}
