using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Zballos.ProjectDemo.BDD.Tests.Config
{
    public class SeleniumHelper : IDisposable
    {
        public IWebDriver WebDriver;
        public readonly ConfigurationHelper Configuration;
        public WebDriverWait Wait;

        public SeleniumHelper(Browser browser, ConfigurationHelper configuration, bool headless = false)
        {
            Configuration = configuration;
            WebDriver = WebDriverFactory.CreateWebDriver(browser, Configuration.WebDrivers, headless);
            WebDriver.Manage().Window.Maximize();
            Wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(30));
        }

        public string GetUrl()
        {
            return WebDriver.Url;
        }

        public void GoToUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public bool ValidUrlContent(string conteudo)
        {
            return Wait.Until(ExpectedConditions.UrlContains(conteudo));
        }

        public void ClickLinkByText(string linkText)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(linkText)))
                .Click();
        }

        public void ClickButtonById(string buttonId)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(buttonId)))
                .Click();
        }

        public void ClickButtonByClassName(string className)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className)))
                .Click();
        }

        public void ClickByXPath(string xPath)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)))
                .Click();
        }

        public IWebElement GetElementByClassName(string className)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className)));
        }

        public IWebElement GetElementByXPath(string xPath)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
        }

        public void FillTextBoxById(string fieldId, string fieldValue)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(fieldId)))
                .SendKeys(fieldValue);
        }

        public void FillTextBoxByClassName(string className, string fieldValue)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className)))
                .SendKeys(fieldValue);
        }

        public void FillDropDownById(string fieldId, string fieldValue)
        {
            var campo = Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(fieldId)));
            var selectElement = new SelectElement(campo);
            selectElement.SelectByValue(fieldValue);
        }

        public string GetTextByClassName(string className)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className))).Text;
        }

        public string GetTextById(string id)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(id))).Text;
        }

        public string GetValueTextBoxById(string id)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(id)))
                .GetAttribute("value");
        }

        public IEnumerable<IWebElement> GetListByClassName(string className)
        {
            return Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName(className)));
        }

        public bool ValidarSeElementoExistePorId(string id)
        {
            return ElementExists(By.Id(id));
        }

        private bool ElementExists(By by)
        {
            try
            {
                WebDriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void GoBack(int times = 1)
        {
            for (var i = 0; i < times; i++)
            {
                WebDriver.Navigate().Back();
            }
        }

        public void GetScreenShort(string name)
        {
            SaveScreenShot(WebDriver.TakeScreenshot(), string.Format("{0}_" + name + ".png", DateTime.Now.ToFileTime()));
        }

        private void SaveScreenShot(Screenshot screenshot, string fileName)
        {
            screenshot.SaveAsFile($"{Configuration.FolderPicture}{fileName}", ScreenshotImageFormat.Png);
        }

        public void Dispose()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }
}
