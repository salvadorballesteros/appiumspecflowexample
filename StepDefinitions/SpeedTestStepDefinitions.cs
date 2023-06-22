using AppiumSpecflowSample.Drivers;
using AppiumSpecflowSample.Pages;
using NUnit.Framework;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class SpeedTestStepDefinitions
    {
        private readonly SpeedTestPage _speedtestPage;
        string initialTextValue;
        string currentTextValue;

        public SpeedTestStepDefinitions(SpeedTestPage speedTestPage)
        {
            _speedtestPage = speedTestPage;
        }

        [When(@"I click on the Go button on the Speed Test screen")]
        public void WhenIClickOnTheGoButtonOnTheSpeedTestScreen()
        {
            _speedtestPage.wait30s();
            _speedtestPage.button_speedtestGo.Click();

        }


        [When(@"I record the results of the Speed Test")]
        public void WhenIRecordTheResultsOfTheSpeedTest()
        {
            _speedtestPage.wait59s();
            _speedtestPage.takeScreenshot("D:\\Test Automation\\repos\\AppiumSpecflowSample\\Screenshots\\");
        }



    }
}