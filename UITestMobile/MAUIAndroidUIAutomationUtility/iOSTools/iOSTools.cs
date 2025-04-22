using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public static string ListDevices()
        {
            try
            {
                string resultJson = "xcrun simctl list devices --json";
                CommondExcecute.ExecuteCommand(resultJson);
                // Deserialize JSON data into SimulatorDevices object
                var result = JsonSerializer.Deserialize<SimulatorDevices>(resultJson);

                if (result?.Devices is null || result.Devices.Count == 0)
                {
                    return "No simulator devices available.";
                }

                // Prepare table header
                var devicesTable = new StringBuilder("# Simulator Devices\n\n");
                devicesTable.AppendLine("| Name             | Udid                | Runtime       |");
                devicesTable.AppendLine("|------------------|---------------------|---------------|");

                // Process devices and format table rows
                foreach (var runtime in result.Devices)
                {
                    string runtimeName = runtime.Key.Replace("com.apple.CoreSimulator.SimRuntime.", string.Empty);

                    foreach (var device in runtime.Value)
                    {
                        device.Runtime = runtimeName;
                        devicesTable.AppendLine($"| {device.Name,-16} | {device.Udid,-20} | {runtimeName,-13} |");
                    }
                }

                return devicesTable.ToString();
            }
            catch (JsonException jsonEx)
            {
                return $"Error parsing simulator devices: {jsonEx.Message}";
            }
            catch (Exception ex)
            {
                return $"Error retrieving simulator devices: {ex.Message}";
            }
        }

    }
}

public class SimulatorDevices
{
    [JsonPropertyName("devices")]
    public Dictionary<string, List<SimulatorDevice>> Devices { get; set; }
}

public class SimulatorDevice
{
    [JsonPropertyName("udid")]
    public string Udid { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("deviceTypeIdentifier")]
    public string Runtime { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }
}