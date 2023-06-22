[On using this framework]

1.) Open the emulator of choice
2.) Start Appium Server
3.) Double check that the Appium server setup matches the appsettings files

==================================================================================

[On Scenarios]
COLOR - Since Appium has no way of checking text / font color, I retrieved the hashcode for the text element using the .getHashCode() method and stored in a local element. I included some negative testing scenarios (clicking on Notifications, Text).

NOTIFICATION - While there are two Scenarios inside the feature, these will not pass for 2 reasons:
1.) I noticed that no notifications were displayed on the app while using Appium Inspector and thus the positive scenario will result in a failed test.

2.) Since I'm writing this in Specflow/C#, as per Appium documentation, the driver.openNotifications() is currently not available for C#, which means it's currently impossible for me to check the current notifications (https://appium.readthedocs.io/en/latest/en/commands/device/system/open-notifications/)

However, I've still written the code as if it were available but commented them out.

TEXT - Captured and then stored the initial text in a local variable before the button push, then captured the current text in the THEN statement before comparing the two local variables.

TOAST - Same as the previous scenarios, the two  

SPEEDTEST - The script will wait:
1.) 30 for the page on Speedtest.net to load
2.) Wait 1 minute after clicking the Go button for the test to finish
3.) after clicking on it, then take a screenshot of the results and save it to the Screenshots folder
4.) Return to the Home Screen and verify that the elements expected in the Home Screen are displayed.

==================================================================================

[On further negative scenarios]

I included some sample negative scenarios in each feature which can be of course expanded if time permits.

==================================================================================
[On testing on iOS]

Unfortunately I do not currently have access to a MacOS / iOS device and thus cannot run an emulator to check for element locators, etc. However, the framework should work on either platform with a few updates:

1.) Users should navigate to whichever page class is appropriate (e.g. the HomePage.cs class) and change the line under each element that starts with "MobileBy.IoSNSPredicate(<your element locator here>)"

2.) Make sure that the appsettings_iOS<environment>.json file has the correct values (e.g. Platform = "iOS")

==================================================================================
[On different environments]

In my experience, different environments when building will result in their own .ipa / .apk files instead of piggybacking. 

The way the framework handles it is this:

1.) User adds the qa/SIT/etc environment .ipa/.apk to the Uploads folder in the solution

2.) User creates a new appsettings_<platform><environment>.json file

3.) User loads the appropriate appsettings.json into the ConfigurationProvider.cs file (modify line 24, the AddJsonFile line)