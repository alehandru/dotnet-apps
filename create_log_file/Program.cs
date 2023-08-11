using System;
using System.Diagnostics;
using System.Reflection;

namespace coretestapp
{
    public class Program
    {
        public static void debug_msg(string sMessage)
        {
            string logDir = @"c:\windows\temp\";
            string processId = Process.GetCurrentProcess().Id.ToString();
            string logfile = Path.Combine(logDir, "debug-process-" + processId + ".log");
            using (StreamWriter writer = new StreamWriter(logfile, append: true))  
            {  
                writer.WriteLine("[msg]: " + sMessage);  
            }
        }

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Running application ...");

            debug_msg("test writting log file to directory.");
            debug_msg("another test writting log file to directory.");

            System.Console.WriteLine("Application has stopped.");
        }
    }
}


