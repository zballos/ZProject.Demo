using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Zballos.ProjectDemo.BDD.Tests.Enums;

namespace Zballos.ProjectDemo.BDD.Tests.Config
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver, bool headless)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Chrome:
                    var optionsChrome = new ChromeOptions();
                    if (headless)
                        optionsChrome.AddArgument("--headless");

                    webDriver = new ChromeDriver(pathDriver, optionsChrome);
                    break;
                case Browser.Edge:
                    var optionsEdge = new EdgeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Normal,
                        UseChromium = true
                    };

                    if (headless)
                        optionsEdge.AddArguments(
                            "--headless", 
                            "--disable-gpu", 
                            "--window-size=1920,1080", 
                            "--disable-extensions",
                            "--proxy-server='direct://'",
                            "--proxy-bypass-list=*",
                            "--start-maximized");

                    webDriver = new EdgeDriver(pathDriver, optionsEdge);
                    break;
                case Browser.Firefox:
                    var optionsFirefox = new FirefoxOptions();
                    if (headless)
                        optionsFirefox.AddArgument("--headless");

                    webDriver = new FirefoxDriver(pathDriver, optionsFirefox);
                    break;
            }

            return webDriver;
        }
    }
}
