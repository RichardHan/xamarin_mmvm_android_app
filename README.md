
# Sample Android App by xamarin + mvvm and reference step by step tutorials.


Install Visual Studio 2015 SP2 with Xamarin

- Open Visual Studio > Tools > Android > Android SDK Manage > Install at least one SDK (e.g. v4.2.2)
										
- New Project > find and create "Class Library (Portable for iOS ,Android and Windwos)   - Visual C#" 
	- Solution Name:App, 
	- Project Name: App.Core 

- New Porject under existing solution > find and create "Blank App (Android)   - Visual C#"
	- Porject Name: App.Android
	- Update references > Select "App.Core" project >
	- Remove "Main.axml" (under App.Android > Resrouces -> layout)
	- Remove "MainActivity.cs" (under App.Android)

- Open Mange NuGet Package on App.Core > Search & Install "MvvmCross" (v4.1.4)

- Open Mange NuGet Package on App.Android > Search & Install MvvmCross.StarterPack" (v4.1.4)

- Error message (at 'icon' with value '@mipmap/icon') & Solution

	Full error message :
	(Severity Code Description Project File Line Suppression State Error No resource found that matches the given name (at 'icon' with value '@mipmap/icon').	App.Android	c:\users\....\Projects\App\App.Android\obj\Debug\android\manifest\AndroidManifest.xml)

	Solution:
	Create folder "mipmap" under (App.Android > Resrouces) and Copy Icon.png from (App.Android > Resrouces > drawable ) to (App.Android > Resrouces > mipmap)

- Set App.Android as Startup project

- Debug(F5) again.

- Friendly Reminder
	-If Visual Studio stop on step "Preparing virtual machine..." for a long time , you should close Emulator(if there have any Emulator opened already) and close Visual Studio > re-open Project > Re-Build > Debug(F5) again..
	-If Emulator open but did not into debuging mode > Cancel Build > Debug(F5) again..