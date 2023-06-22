using AppiumSpecflowSample.Drivers;
using AppiumSpecflowSample.Pages;
using NUnit.Framework;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class TextStepDefinitions
    {
        private readonly HomePage _homePage;
        string initialTextValue;
        string currentTextValue;

        public TextStepDefinitions(HomePage homePage)
        {
            _homePage = homePage;
            
        }
        [When(@"the user takes note of the text and clicks on the Text button")]
        public void WhenTheUserTakesNoteOfTheTextAndClicksOnTheTextButton()
        {
            initialTextValue = _homePage.welcomeText.Text;
            _homePage.buttonText.Click();
        }

        [When(@"the user takes note of the text and clicks on the Color button")]
        public void WhenTheUserTakesNoteOfTheTextAndClicksOnTheColorButton()
        {
            initialTextValue = _homePage.welcomeText.Text;
            _homePage.buttonColor.Click();
        }


        [Then(@"the text should should be changed")]
        public void ThenTheTextShouldShouldBeChanged()
        {
            currentTextValue = _homePage.welcomeText.Text;
            Assert.AreNotEqual(initialTextValue, currentTextValue);
        }

        [Then(@"the text should should not be changed")]
        public void ThenTheTextShouldShouldNotBeChanged()
        {
            currentTextValue = _homePage.welcomeText.Text;
            Assert.AreEqual(initialTextValue, currentTextValue);
        }



    }
}