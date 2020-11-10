using TechTalk.SpecFlow;
using Xunit;
using Zballos.ProjectDemo.BDD.Tests.Config;

namespace Zballos.ProjectDemo.BDD.Tests.Soccer
{
    [Binding]
    [CollectionDefinition(nameof(AutomationWebFixtureCollection))]
    public class FlamengoNewsSteps
    {
        private readonly AutomationWebTestsFixture _testsFixture;

        public FlamengoNewsSteps(AutomationWebTestsFixture testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Given(@"there are search actions")]
        public void GivenThereAreSearchActions()
        {
            // Arrange
            _testsFixture.BrowserHelper.GoToUrl(_testsFixture.Configuration.EspnUrl);
            _testsFixture.BrowserHelper.ClickButtonById("global-search-trigger");
            _testsFixture.BrowserHelper.FillTextBoxByClassName("search-box", "Flamengo");
            // Act
            _testsFixture.BrowserHelper.ClickButtonByClassName("btn-search");

            // Assert
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"it is possible to search")]
        public void GivenItIsPossibleToSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user search for Flamengo")]
        public void WhenUserSearchForFlamengo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will be redirected to news list")]
        public void ThenUserWillBeRedirectedToNewsList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
