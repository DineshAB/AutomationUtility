using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIAndroidUIAutomationUtility.Helper
{
    public static class CommondExcecute
    {
        public static void ExecuteCommand(string command)
        {
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = OperatingSystem.IsWindows() ? "cmd.exe" : "/bin/bash",
                    Arguments = OperatingSystem.IsWindows() ? $"/C {command}" : $"-c \"{command}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine("Error: " + error);
            }
        }
    }
}
