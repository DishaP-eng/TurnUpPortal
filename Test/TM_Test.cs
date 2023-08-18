using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.Page;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Test
{
    [TestFixture]
    public class TM_Test : CommonDriver

    {
        [SetUp]
        public void SetUpTM()
        {
            //Open the Browser
            driver = new ChromeDriver();

            //Implicitewait

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }

        [Test]
        public void EditTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);
        }

        [Test]
        public void DeleteTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}

