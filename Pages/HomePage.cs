using AppiumSpecflowSample.Drivers;
using Google.Protobuf.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowSample.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(DriverProvider driverProvider,ConfigurationProvider configurationProvider) : base(driverProvider, configurationProvider)
        {
            
        }

        //Elements
        public IWebElement Title =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.TextView")
            : MobileBy.IosNSPredicate("text == placeholder"));

        //buttons
        public IWebElement buttonColor =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Button[@text='COLOR']")
            : MobileBy.IosNSPredicate("text == placeholder"));

        public IWebElement buttonText =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Button[@text='TEXT']")
            : MobileBy.IosNSPredicate("text == placeholder"));

        public IWebElement buttonGeolocation =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Button[@text='GEOLOCATION']")
            : MobileBy.IosNSPredicate("text == placeholder"));
        public IWebElement buttonNotification =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Button[@text='NOTIFICATION']")
            : MobileBy.IosNSPredicate("text == placeholder"));

        public IWebElement buttonHome =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.TextView[@text='Home']")
            : MobileBy.IosNSPredicate("text == placeholder"));
        public IWebElement buttonToast =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Button[@text='TOAST']")
            : MobileBy.IosNSPredicate("text == placeholder"));

        public IWebElement buttonSpeedTest =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Button[@text='TOAST']")
            : MobileBy.IosNSPredicate("text == placeholder"));


        //Text

        public IWebElement welcomeText =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.Id("com.lambdatest.proverbial:id/Textbox")
            : MobileBy.IosNSPredicate("text == Hello! Welcome to lambdatest Sample App called Proverbial"));

        //Misc

        public IWebElement notification =>
           Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
           ? By.XPath("//android.widget.Placeholder") //was unable to retrieve a notification via Appium inspector, so put a placeholder in the meantime
:          MobileBy.IosNSPredicate("text == placeholder"));

        public IWebElement Toast =>
            Driver.FindElement(PlatformName.Equals(MobilePlatform.Android)
            ? By.XPath("//android.widget.Toast") 
:           MobileBy.IosNSPredicate("text == placeholder"));
    }
}
