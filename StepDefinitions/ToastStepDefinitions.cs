using AppiumSpecflowSample.Drivers;
using AppiumSpecflowSample.Pages;
using NUnit.Framework;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class ToastStepDefinitions
    {
        private readonly HomePage _homePage;
        string initialTextValue;
        string currentTextValue;

        public ToastStepDefinitions(HomePage homePage)
        {
            _homePage = homePage;

        }

        [Then(@"the toast should should be displayed")]
        public void ThenTheToastShouldShouldBeDisplayed()
        {
            _homePage.Toast.Displayed.Should().BeTrue();
        }

        [Then(@"the toast should should not be displayed")]
        public void ThenTheToastShouldShouldNotBeDisplayed()
        {
            _homePage.Toast.Displayed.Should().BeFalse();
        }


    }
}