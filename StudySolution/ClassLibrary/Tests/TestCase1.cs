using ClassLibrary.Libs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    public class TestCase1:PreAndPost
    {
        protected override void CustomizeTest()
        {
            InitBrowser(BrowserType.InternetExplorer);
        }

        [Test]
        public void Test1() 
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            webDriver.Url = "http://google.com";
            
            ;

        }


    }
}
