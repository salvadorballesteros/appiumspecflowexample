using AppiumSpecflowSample.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Support.Extensions;

namespace AppiumSpecflowSample.Pages
{
    public class SpeedTestPage : BasePage
    {
        public SpeedTestPage(DriverProvider driverProvider, ConfigurationProvider configurationProvider) : base(driverProvider, configurationProvider)
        {

        }

        //buttons
        public IWebElement button_speedtestGo =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("(//android.widget.FrameLayout[@resource-id=\"com.lambdatest.proverbial:id/frameLayout\"]//android.widget.Button)[3]")
            : MobileBy.IosNSPredicate("placeholder"));
    }
}