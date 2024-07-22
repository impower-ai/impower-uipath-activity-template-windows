# UiPath Custom Activity Template Windows

## Pre-Requisites
1. Visual Studio 
2. UiPath Studio 
3. Must be using Windows compatibility projects. Cannot use Windows-Legacy 

## Required Nuget Feeds
1. https://pkgs.dev.azure.com/uipath/Public.Feeds/_packaging/UiPath-Official/nuget/v3/index.json
2. https://api.nuget.org/v3/index.json

## Useful Resources 
1. [UiPath Documentation](https://docs.uipath.com/sdk/other/latest/developer-guide/creating-activities-with-code)

## Steps to Package project and Import into UiPath Studio
Reminder: Each time you package the project, make sure you open the .csproj for the project in the solution. Then change the "version", going upwards. i.e "<Version>1.0.0</Version>" could become "<Version>1.0.1</Version>".
This version will be how you identify the latest version of your package in UiPath Studio. 
1. Create local folder: C:\LocalNuget 
2. In Visual Studio, right click the "UiPath.Activity.Template.Windows" project in the solution.
3. Click "Pack" 
4. Open UiPath Studio 
5. Click "Settings" 
6. Click "Manage Sources"
7. Create new Source with name "Local Nuget" and Source "C:\LocalNuget" 
8. Open UiPath Project
9. Click Manage Packages, select "Local Nuget" source. Click install on the package shown 

