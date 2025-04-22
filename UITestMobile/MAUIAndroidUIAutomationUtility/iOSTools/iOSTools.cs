using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUIAndroidUIAutomationUtility.Helper;

namespace MAUIAndroidUIAutomationUtility.iOSTools
{
    public static class iOSTool
    {
        public static void BootDevice(string deviceId)
        {
            try
            {
                if (string.IsNullOrEmpty(deviceId))
                {
                    throw new ArgumentNullException(nameof(deviceId), "Error: Invalid or missing device ID.");
                }

                // Execute the command to boot the simulator device
                CommondExcecute.ExecuteCommand($"xcrun simctl boot {deviceId}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error booting the simulator device: {ex.Message}", ex);
            }
        }
        public static void ShutdownDevice(string deviceId)
        {
            try
            {
                if (string.IsNullOrEmpty(deviceId))
                {
                    throw new ArgumentNullException(nameof(deviceId), "Error: Invalid or missing device ID.");
                }

                // Execute the command to shut down the simulator device
                CommondExcecute.ExecuteCommand($"xcrun simctl shutdown {deviceId}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error shutting down the simulator device: {ex.Message}", ex);
            }
        }

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
                CommondExcecute.ExecuteCommand($"xcrun simctl install {deviceId} \"{appPath}\"");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error installing application: {ex.Message}", ex);
            }
        }

    }
}
