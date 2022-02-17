using System;
using System.Diagnostics;
using System.IO;

namespace Parking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = "demo.py";
            
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\SourcesPrograms\\Python\\Python.exe";
            start.Arguments = cmd;//string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            string result = "";
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}
