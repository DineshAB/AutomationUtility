
using MAUIAndroidUIAutomationUtility.Helper;
using MAUIAndroidUIAutomationUtility.AndroidTools;


namespace MAUIAndroidUIAutomationUtility;
    class Program
{
    static void Main()
    {
        string documentFolder = "/Users/aravindkannanarayanarao/Documents";
        // Appium 1
        List<Dictionary<string, string>> projects = new List<Dictionary<string, string>>
        {
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormBasicFeature" }, { "ApplicationID", "com.companyname.mauisfdataformbasicfeature" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormCustomDataEditor" }, { "ApplicationID", "com.companyname.mauisfdataformcustomdataeditor" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormDataValidation" }, { "ApplicationID", "com.companyname.mauisfdataformdatavalidation" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormFloatingLabelLayout" }, { "ApplicationID", "com.companyname.mauisfdataformfloatinglabellayout" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormGroupHeader" }, { "ApplicationID", "com.companyname.mauisfdataformgroupheader" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormLayout" }, { "ApplicationID", "com.companyname.mauisfdataformlayout" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormScroll" }, { "ApplicationID", "com.companyname.mauisfdataformscroll" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-dataform-tests" }, { "SampleName", "MAUISfDataFormSegment" }, { "ApplicationID", "com.companyname.mauisfdataformsegment" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-picker-tests" }, { "SampleName", "MAUISfPicker" }, { "ApplicationID", "com.companyname.mauisfpicker" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "maui-shimmer-test" }, { "SampleName", "MAUIShimmer" }, { "ApplicationID", "com.companyname.mauishimmer" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        };
        List<Dictionary<string, string>> projects1 = new List<Dictionary<string, string>>
        {
        //Appium 3
        new Dictionary<string, string> { { "ProjectName", "maui-chat-tests" }, { "SampleName", "SfChatSample" }, { "ApplicationID", "com.companyname.sfchatsample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        new Dictionary<string, string> { { "ProjectName", "SfNavigationDrawer-MAUI-tests" }, { "SampleName", "SfNavigationDrawerSample" }, { "ApplicationID", "com.companyname.sfnavigationdrawersample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
        };

        //Appium 2
        List<Dictionary<string, string>> projects2 = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { { "ProjectName", "BusyIndicator-MAUI-tests" }, { "SampleName", "SfBusyIndicatorSample" }, { "ApplicationID", "com.companyname.SfBusyIndicatorSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-bottomsheet-tests" }, { "SampleName", "BottomSheet" }, { "ApplicationID", "com.companyname.bottomsheet" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-gauges-tests" }, { "SampleName", "MAUILinearGauge" }, { "ApplicationID", "com.companyname.mauilineargauge" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-gauges-tests" }, { "SampleName", "MAUIRadialGauge" }, { "ApplicationID", "com.companyname.mauiradialgauge" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-gauges-tests" }, { "SampleName", "MAUISfDigitalGauge" }, { "ApplicationID", "com.companyname.mauisfdigitalgauge" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-maps-tests" }, { "SampleName", "MAUISfMapsAllProperties" }, { "ApplicationID", "com.companyname.mauisfmapsallproperties" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-maps-tests" }, { "SampleName", "MAUISfMapsBasicFeatures" }, { "ApplicationID", "com.companyname.mauisfmapsbasicfeatures" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-maps-tests" }, { "SampleName", "MAUISfMapShape" }, { "ApplicationID", "com.companyname.mauisfmapshape" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-maps-tests" }, { "SampleName", "MAUISfMapsNewFeatures" }, { "ApplicationID", "com.companyname.mauisfmapsnewfeatures" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-segmentcontrol-test" }, { "SampleName", "MAUISfSegment" }, { "ApplicationID", "com.companyname.mauisfsegment" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            new Dictionary<string, string> { { "ProjectName", "maui-cards-tests" }, { "SampleName", "MAUISfCards" }, { "ApplicationID", "com.companyname.mauisfcards" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_5_API_33" } },
            };
        List<Dictionary<string, string>> projects3 = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { { "ProjectName", "SfAvatarView-MAUI-tests" }, { "SampleName", "SfAvatarViewSample" }, { "ApplicationID", "com.companyname.SfAvatarViewSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
            new Dictionary<string, string> { { "ProjectName", "SfBadgeView-MAUI-tests" }, { "SampleName", "SfBadgeViewSample" }, { "ApplicationID", "com.companyname.SfBadgeViewSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
            new Dictionary<string, string> { { "ProjectName", "SfCarousel-MAUI-tests" }, { "SampleName", "SfCarouselSample" }, { "ApplicationID", "com.companyname.sfcarouselsample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
            new Dictionary<string, string> { { "ProjectName", "SfChip-MAUI-tests" }, { "SampleName", "SfChipSample" }, { "ApplicationID", "com.companyname.SfChipSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
            new Dictionary<string, string> { { "ProjectName", "SfEffectsView-MAUI-tests" }, { "SampleName", "SfEffectsViewSample" }, { "ApplicationID", "com.companyname.SfEffectsViewSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
            new Dictionary<string, string> { { "ProjectName", "SfRating-MAUI-tests" }, { "SampleName", "SfRatingSample" }, { "ApplicationID", "com.companyname.SfRatingSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
            new Dictionary<string, string> { { "ProjectName", "SfSignaturePad-MAUI-tests" }, { "SampleName", "SfSignaturePadSample" }, { "ApplicationID", "com.companyname.SfSignaturePadSample" }, { "Platform", "UITests.Android" }, { "EmulatorCommand", "$ANDROID_HOME/emulator/emulator -avd Pixel_2xl_API_28" } },
        };


        foreach (var project in projects)
        {
            Console.WriteLine($"Running UI tests for {project["ProjectName"]}...");
            RunAndroidUITests(project, documentFolder);
        }

    }
    static void RunAndroidUITests(Dictionary<string, string> project, string documentFolder)
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
            Process.ExecuteCommand($"cd {appPath} && {publishCommand}");

            Console.WriteLine($"Installing {project["SampleName"]} in to emulator");
            Process.ExecuteCommand(installCommand);

            Console.WriteLine($"UITest started for project : {project["SampleName"]} Sample : {project["SampleName"]} Platform : {project["Platform"]} ");
            Process.ExecuteCommand(TestRun);
            Console.WriteLine($"Closing emulator");
            Process.ExecuteCommand("adb emu kill");
        }

        else if (project["Platform"] == "UITests.iOS")
        {
            string emulator = $"{project["EmulatorCommand"]}";
            string appPath = $"{documentFolder}/Appium/{project["ProjectName"]}/UITest/Appium/{project["SampleName"]}/{project["SampleName"]}";
            string testPath = $"{documentFolder}/Appium/{project["ProjectName"]}/UITest/Appium/{project["SampleName"]}/{project["Platform"]}";
            string TestRun = $"dotnet test {testPath}";
            Console.WriteLine($"Running commands for {project["ProjectName"]}...");

            Console.WriteLine($"Starting emulator : {project["EmulatorCommand"]}...");
            //StartEmulator(emulator);
            //WaitForEmulatorToBoot();

            Console.WriteLine($"Installing {project["SampleName"]} in to Simulator ");
            //InstallApp(deviceId, appPath);

            Console.WriteLine($"UITest started for project : {project["SampleName"]} Sample : {project["SampleName"]} Platform : {project["Platform"]} ");
            Process.ExecuteCommand(TestRun);

            Console.WriteLine($"Closing emulator");
            Process.ExecuteCommand("adb emu kill");
        }
    }
    public void InstallApp(string deviceId, string appPath)
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
