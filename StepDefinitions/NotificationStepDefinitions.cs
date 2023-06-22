using AppiumSpecflowSample.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class NotificationStepDefinitions
    {
        private readonly HomePage _homePage;

        public NotificationStepDefinitions(HomePage homePage)
        {
            _homePage = homePage;
        }


        [Then(@"a notification should be recieved")]
        public void ThenANotificationShouldBeRecieved()
        {
            _homePage.displayNotificationBar();
            _homePage.notification.Displayed.Should().BeTrue();
        }

        [Then(@"a notification should not be recieved")]
        public void ThenANotificationShouldNotBeRecieved()
        {
            _homePage.displayNotificationBar();
            _homePage.notification.Displayed.Should().BeFalse();
        }



    }
}
