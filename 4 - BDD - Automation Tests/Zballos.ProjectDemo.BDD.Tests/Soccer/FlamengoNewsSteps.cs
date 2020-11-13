using OpenQA.Selenium;
using System.Linq;
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

        [Given(@"user is in ESPN webpage")]
        public void GivenUserIsInESPNWebpage()
        {
            // Arrange
            _espnWebsite.GoToEspn();
            _espnWebsite.OpenSearchTextBox();
            var urlExpected = _testsFixture.Configuration.EspnUrl;

            // Act
            _espnWebsite.FillSearchTermInTextBox("Flamengo");
            _espnWebsite.SubmitSearchButton();

            // Assert
            Assert.True(_testsFixture.BrowserHelper.ValidUrlContent(urlExpected));
        }

        [Given(@"already searched for Flamengo")]
        public void GivenAlreadySearchedForFlamengo()
        {
            // Act
            var searchContent = _espnWebsite.GetSearchedTerm();

            // Assert
            Assert.Contains("Flamengo", searchContent);
        }

        [When(@"exists news")]
        public void WhenExistsNews()
        {
            // Act
            var news = _espnWebsite.GetFirstNewsElementByXPath("//*[@id='fittPageContainer']/div[2]/div/div/div[3]/section[2]/div/ul/div/div[1]/li/article/a");
            _espnWebsite.AddFirstNews(news);

            // Assert
            Assert.NotNull(news);
        }

        [Then(@"the user clicks on any news")]
        public void ThenTheUserClicksOnAnyNews()
        {
            // Arrange
            var element = _espnWebsite.GetFirstNewsElement();
            var urlExpected = element.GetAttribute("href");

            // Act
            element.Click();

            // Assert
            Assert.Equal(urlExpected, _espnWebsite.GetUrl());
        }

    }
}
