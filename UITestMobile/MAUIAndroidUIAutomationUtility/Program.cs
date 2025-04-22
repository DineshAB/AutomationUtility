
using MAUIAndroidUIAutomationUtility.Helper;
using MAUIAndroidUIAutomationUtility.AndroidTools;
using MAUIAndroidUIAutomationUtility.iOSTools;


namespace MAUIAndroidUIAutomationUtility;
class Program
{
    static void Main()
    {
        string documentFolder = "/Users/aravindkannanarayanarao/Documents";
        // Appium 1
        List<Dictionary<string, string>> projects = new List<Dictionary<string, string>>
        {
        new Dictionary<string, string> { { "ProjectName", "maui-chat-tests" }, { "SampleName", "SfChatSample" }, { "ApplicationID", "com.companyname.sfchatsample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-chat-tests" }, { "SampleName", "SfChatSample" }, { "ApplicationID", "com.companyname.sfchatsample" }, { "Platform", "UITests.iOS" }, { "EmulatorCommand", "iPhone 13 Pro Max" } },
        };

        foreach (var project in projects)
        {
            Console.WriteLine($"Running UI tests for {project["ProjectName"]}...");
            RunUITests(project, documentFolder);
        }

    }
    static void RunUITests(Dictionary<string, string> project, string documentFolder)
    {
        if (project["Platform"] == "UITests.Android")
        {

            string emulator = $"{project["EmulatorCommand"]}";
            string appPath = $"{documentFolder}/Appium/{project["ProjectName"]}/UITest/Appium/{project["SampleName"]}/{project["SampleName"]}";
            string testPath = $"{documentFolder}/Appium/{project["ProjectName"]}/UITest/Appium/{project["SampleName"]}/{project["Platform"]}";
            string publishCommand = "dotnet publish -f net9.0-android -c Release -p:AndroidKeyStore=true -p:AndroidSigningKeyStore=key.keystore -p:AndroidSigningKeyAlias=MauiAlias -p:AndroidSigningKeyPass=kanna007 -p:AndroidSigningStorePass=kanna007";
            string installCommand = $"adb install {appPath}/bin/Release/net9.0-android/publish/{project["ApplicationID"]}-Signed.apk";
            string TestRun = $"dotnet test {testPath}";
            Console.WriteLine($"Running commands for {project["ProjectName"]}...");

            Console.WriteLine($"Starting emulator : {project["EmulatorCommand"]}...");
            AndroidTool.BootDevice("Pixel_5_API_33");

            Console.WriteLine($"Starting {project["SampleName"]} build and publish");
            CommondExcecute.ExecuteCommand($"cd {appPath} && {publishCommand}");

            Console.WriteLine($"Installing {project["SampleName"]} in to emulator");
            CommondExcecute.ExecuteCommand(installCommand);

            Console.WriteLine($"UITest started for project : {project["SampleName"]} Sample : {project["SampleName"]} Platform : {project["Platform"]} ");
            CommondExcecute.ExecuteCommand(TestRun);
            Console.WriteLine($"Closing emulator");
            CommondExcecute.ExecuteCommand("adb emu kill");
        }

        else if (project["Platform"] == "UITests.iOS")
        {
            var iphone13promax = "815F3742-98E7-4405-9611-EC74A30DB5F2";
            string emulator = $"{project["EmulatorCommand"]}";
            string appPath = $"{documentFolder}/Appium/{project["ProjectName"]}/UITest/Appium/{project["SampleName"]}/{project["SampleName"]}";
            string testPath = $"{documentFolder}/Appium/{project["ProjectName"]}/UITest/Appium/{project["SampleName"]}/{project["Platform"]}";
            string TestRun = $"dotnet test {testPath}";
            Console.WriteLine($"Running commands for {project["ProjectName"]}...");

            Console.WriteLine($"Starting simulator : {project["EmulatorCommand"]}...");
            iOSTool.BootDevice(iphone13promax);

            Console.WriteLine($"Installing {project["SampleName"]} in to Simulator ");
            iOSTool.InstallApp(iphone13promax, appPath);

            Console.WriteLine($"UITest started for project : {project["SampleName"]} Sample : {project["SampleName"]} Platform : {project["Platform"]} ");
            CommondExcecute.ExecuteCommand(TestRun);

            Console.WriteLine($"Closing simulator");
            iOSTool.ShutdownDevice(iphone13promax);
        }
    }
}
