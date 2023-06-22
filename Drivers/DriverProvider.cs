using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowSample.Drivers
{
    public class DriverProvider
    {
        private AppiumDriver<IWebElement> _driver;
        private readonly Settings _settings;

        private static readonly Dictionary<string, Func<Uri, AppiumOptions, AppiumDriver<IWebElement>>> DriverCollection
            = new Dictionary<string, Func<Uri, AppiumOptions, AppiumDriver<IWebElement>>>
            {
                {
                    MobilePlatform.IOS,(remoteAddress,options) =>
                    new IOSDriver<IWebElement>(remoteAddress,options, commandTimeout:TimeSpan.FromSeconds(90))
                },

                {
                    MobilePlatform.Android,(remoteAddress,options) =>
                    new AndroidDriver<IWebElement>(remoteAddress,options, commandTimeout:TimeSpan.FromSeconds(90))
                },
            };

        public DriverProvider(ConfigurationProvider configurationProvider)
        {
            _settings = configurationProvider.GetSettings();
        }

        private AppiumOptions GetOptions()
        {
            var options = new AppiumOptions();

            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, _settings.PlatformName);
            options.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, _settings.PlatformVersion);
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, _settings.DeviceName);
            options.AddAdditionalCapability(MobileCapabilityType.App, _settings.App);
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, _settings.AutomationVersion);

            return options;
        }

        public AppiumDriver<IWebElement> GetDriver()
        {
            if (_driver != null)
            {
                return _driver;
            }

            _driver = DriverCollection[_settings.PlatformName].Invoke(_settings.RemoteServerAddress, GetOptions());
            return _driver;
        }
    }
}
