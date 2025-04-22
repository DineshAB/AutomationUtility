using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIAndroidUIAutomationUtility.iOSTools
{
    public static class iOSTool
    {
        public static void InstallApp(string deviceId, string appPath)
        {
            try
            {
                if (string.IsNullOrEmpty(deviceId))
                {
                    throw new ArgumentNullException(nameof(deviceId), "Error: Invalid or missing device ID.");
                }

                if (string.IsNullOrEmpty(appPath))
                {
                    throw new ArgumentNullException(nameof(appPath), "Error: Invalid or missing application path.");
                }

                // Execute the command to install the application
                Process.ExecuteCommand($"xcrun simctl install {deviceId} \"{appPath}\"");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error installing application: {ex.Message}", ex);
            }
        }

    }
}
