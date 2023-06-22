using AppiumSpecflowSample.Drivers;
using AppiumSpecflowSample.Pages;
using NUnit.Framework;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class ColorStepDefinitions
    {
        private readonly HomePage _homePage;
        string initialHashCode;
        string currentHashCode;

        public ColorStepDefinitions(HomePage homePage)
        {
            _homePage = homePage;
            
        }


        [When(@"the user takes note of the current text color then clicks on the Color button")]
        public void WhenTheUserTakesNoteOfTheCurrentTextColorThenClicksOnTheColorButton()
        {
            initialHashCode = _homePage.welcomeText.GetHashCode().ToString();
            _homePage.buttonColor.Click();

        }

        [When(@"the user takes note of the current text color then clicks on the Geolocation button")]
        public void WhenTheUserTakesNoteOfTheCurrentTextColorThenClicksOnTheGeolocationButton()
        { 
            initialHashCode = _homePage.welcomeText.GetHashCode().ToString();
            _homePage.buttonGeolocation.Click();
        }

        [When(@"the user takes note of the current text color then clicks on the Notification button")]
        public void WhenTheUserTakesNoteOfTheCurrentTextColorThenClicksOnTheNotificationButton()
        {
            initialHashCode = _homePage.welcomeText.GetHashCode().ToString();
            _homePage.buttonNotification.Click();
        }

        [When(@"the user takes note of the current text color then clicks on the Text button twice")]
        public void WhenTheUserTakesNoteOfTheCurrentTextColorThenClicksOnTheTextButtonTwice()
        {
            initialHashCode = _homePage.welcomeText.GetHashCode().ToString();
            _homePage.buttonText.Click();
            _homePage.buttonText.Click();
        }


        [Then(@"the text color should be changed")]
        public void ThenTheTextColorShouldBeChanged()
        {
            currentHashCode = _homePage.welcomeText.GetHashCode().ToString();
            Assert.AreNotEqual(initialHashCode, currentHashCode);

        }

        [Then(@"the text color should not be changed")]
        public void ThenTheTextColorShouldBeNotChanged()
        {
            currentHashCode = _homePage.welcomeText.GetHashCode().ToString();
            Assert.AreEqual(initialHashCode, currentHashCode);
        }


    }
}