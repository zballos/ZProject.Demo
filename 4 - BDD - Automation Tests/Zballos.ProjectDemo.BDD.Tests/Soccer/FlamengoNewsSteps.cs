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
        private readonly EspnWebsite _espnWebsite;

        public FlamengoNewsSteps(AutomationWebTestsFixture testsFixture)
        {
            _testsFixture = testsFixture;
            _espnWebsite = new EspnWebsite(testsFixture.BrowserHelper);
        }

        [Given(@"acess ESPN website")]
        public void GivenAcessESPNWebsite()
        {
            // Arrange
            _espnWebsite.GoToEspn();

            // Assert
            Assert.True(_espnWebsite.IsInHomePage());
        }
        
        [Given(@"it is possible to search")]
        public void GivenItIsPossibleToSearch()
        {
            // Assert
            Assert.True(_testsFixture.BrowserHelper.ElementExistsById("global-search-trigger"));
        }
        
        [When(@"user search for Flamengo")]
        public void WhenUserSearchForFlamengo()
        {
            // Arrange
            _espnWebsite.OpenSearchTextBox();

            // Act
            _espnWebsite.FillSearchTermInTextBox("Flamengo");
            _espnWebsite.SubmitSearchButton();
            
            // Assert
            
        }
        
        [Then(@"user will be redirected to news list")]
        public void ThenUserWillBeRedirectedToNewsList()
        {
            // Act
            var searchContent = _espnWebsite.GetSearchedTerm();

            // Assert
            Assert.Contains("Flamengo", searchContent);
            Assert.True(_espnWebsite.IsInSearchPage());
        }
    }
}
