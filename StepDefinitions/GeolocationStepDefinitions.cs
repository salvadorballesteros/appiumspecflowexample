using AppiumSpecflowSample.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class GeolocationStepDefinitions
    {
        private readonly HomePage _homePage;

        public GeolocationStepDefinitions(HomePage homePage)
        {
            _homePage = homePage;
        }



    }
}