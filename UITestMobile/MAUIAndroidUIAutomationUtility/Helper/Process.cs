using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIAndroidUIAutomationUtility.Helper
{
    public static class Process
    {
        public static string ExecuteCommand(string command)
        {
            var process = StartProcess(command);

            string output = process.StandardOutput.ReadToEnd();

            process.WaitForExit();

            return output;
        }
        public static System.Diagnostics.Process StartProcess(string command)
        {
            var process = new System.Diagnostics.Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = OperatingSystem.IsWindows() ? "cmd.exe" : "/bin/bash",
                    Arguments = OperatingSystem.IsWindows() ? $"/C {command}" : $"-c \"{command}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            return process;
        }
    }
}
