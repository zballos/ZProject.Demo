using Zballos.ProjectDemo.BDD.Tests.Config;

namespace Zballos.ProjectDemo.BDD.Tests.Soccer
{
    public class EspnWebsite : PageObjectModel
    {
        public EspnWebsite(SeleniumHelper helper) : base(helper) { }

        public void GoToEspn()
        {
            Helper.GoToUrl(Helper.Configuration.EspnUrl);
        }

        public string GetUrl()
        {
            return Helper.GetUrl();
        }

        public bool IsInHomePage()
        {
            return Helper.ValidUrlContent(Helper.Configuration.EspnUrl);
        }

        public bool IsInSearchPage()
        {
            return Helper.ValidUrlContent(Helper.Configuration.EspnUrl + "busca/_/q/");
        }

        public string GetSearchedTerm()
        {
            return Helper.GetValueTextBoxByClassName("SearchBar__Input");
        }

        public void OpenSearchTextBox()
        {
            Helper.ClickButtonById("global-search-trigger");
        }

        public void FillSearchTermInTextBox(string searchTerm)
        {
            Helper.FillTextBoxByClassName("search-box", searchTerm);
        }

        public void SubmitSearchButton()
        {
            Helper.ClickButtonByClassName("btn-search");
        }
    }
}
