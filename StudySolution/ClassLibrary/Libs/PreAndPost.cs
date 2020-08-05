using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Libs
{
    public class PreAndPost
    {
        [SetUp]
        public void SetUp()
        {
            CustomizeTest();
        }

        [TearDown]
        public void closeBrowser()
        {
            if (webDriver!=null)    
                webDriver.Quit();
                webDriver.Dispose();
        }

        protected virtual void CustomizeTest() { }




        public void InitBrowser(BrowserType browser)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string driverFolder = Path.Combine(basePath, @"..\..\..\Drivers");
            switch (browser)
            {
                case BrowserType.Chrome:
                    _webDriver = new ChromeDriver();
                    break;
                case BrowserType.InternetExplorer:
                    _webDriver = new InternetExplorerDriver(Path.Combine(driverFolder, "Ie"));
                    break;
                case BrowserType.FireFox:
                    _webDriver = new FirefoxDriver();
                    break;
            }
        }

        public IWebDriver webDriver
        {
            get => _webDriver;
        }

        private IWebDriver _webDriver = null;
    }



    public enum BrowserType {
        Chrome,
        InternetExplorer,
        FireFox
    }
}
