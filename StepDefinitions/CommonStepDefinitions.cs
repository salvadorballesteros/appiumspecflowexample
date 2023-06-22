using AppiumSpecflowSample.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class CommonStepDefinitions
    {
        private readonly HomePage _homePage;

        public CommonStepDefinitions(HomePage homePage)
        {
            _homePage = homePage;
        }

        [Given(@"the application has been launched")]
        public void GivenTheApplicationHasBeenLaunched()
        {
            _homePage.Title.Displayed.Should().BeTrue();
        }

        [When(@"I click on the Home Button")]
        public void WhenIClickOnTheHomeButton()
        {
            _homePage.buttonHome.Click();
        }

        [When(@"presses the Home Button")]
        public void WhenPressesTheBackButton()
        {
            _homePage.tapBackButton();
        }

        [When(@"the user clicks on the Notification button")]
        public void WhenTheUserClicksOnTheNotificationButton()
        {
            _homePage.buttonNotification.Click();
        }

        [When(@"the user clicks on the Color button")]
        public void WhenTheUserClicksOnTheColorButton()
        {
            _homePage.buttonColor.Click();
        }

        [When(@"the user clicks on the Text button")]
        public void WhenTheUserClicksOnTheTextButton()
        {
            _homePage.buttonText.Click();
        }

        [When(@"the user clicks the Toast button")]
        public void WhenTheUserClicksTheToastButton()
        {
            _homePage.buttonToast.Click();
        }

        [When(@"the user clicks the Speed Test button")]
        public void WhenTheUserClicksTheSpeedTestButton()
        {
            _homePage.buttonSpeedTest.Click();
        }

        [Then(@"I should see the Home Screen")]
        public void ThenIShouldSeeTheHomeScreen()
        {
            _homePage.Title.Displayed.Should().BeTrue();
            _homePage.buttonColor.Displayed.Should().BeTrue();
            _homePage.buttonGeolocation.Displayed.Should().BeTrue();
            _homePage.buttonNotification.Displayed.Should().BeTrue();
            _homePage.buttonText.Displayed.Should().BeTrue();
            _homePage.buttonSpeedTest.Displayed.Should().BeTrue();
            _homePage.buttonToast.Displayed.Should().BeTrue();
        }


    }
}
