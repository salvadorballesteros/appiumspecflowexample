using AppiumSpecflowSample.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.Extensions;

namespace AppiumSpecflowSample.Pages
{
    public class BasePage
    {
        protected readonly AppiumDriver<IWebElement> Driver;
        protected readonly string PlatformName;
                
        public BasePage(DriverProvider driverProvider,ConfigurationProvider configurationProvider)
        {
            Driver = driverProvider.GetDriver();
            PlatformName = configurationProvider.GetSettings().PlatformName;   
        }


        //common functions
        public void tapBackButton()
        {
            Driver.Navigate().Back();
        }

        public void displayNotificationBar()
        {
          //  Driver.openNotifications();
        }

        public void wait30s()
        {
            Thread.Sleep(30000);
        }

        public void wait59s()
        {
            Thread.Sleep(59000);
        }

        public void takeScreenshot(String screenshot_filepath)
        {
            var screenshot = Driver.GetScreenshot();
            DateTime currentDateTime = DateTime.Now;
            string  ssDateTime= currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string destinationPath = "D:\\Test Automation\\repos\\AppiumSpecflowSample\\Screenshot\\screenshot.png"+ ssDateTime;
            screenshot.SaveAsFile(destinationPath, ScreenshotImageFormat.Png);
        }
    }
}
