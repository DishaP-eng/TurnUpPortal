using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Page
{
	public class HomePage
	{
		public void GoToTMPage(IWebDriver driver)
		{
            //check if user has logged in successfully
            IWebElement helloHarri = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (helloHarri.Text == "Hello hari!")
            {
                Console.WriteLine("User is logged in");
            }
            else
            {
                Console.WriteLine("User hasn't been logged in");
            }

            //Click on Administration dropdown
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            //Explicite wait
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);

            //Click on Time and Material Option
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Thread.Sleep(2000);


        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            //Click on Administration dropdown
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            
            Wait.WaitToBeClickable(driver,"xpath","/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a",9);
            
            //Click on Employees Option
            IWebElement empOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            empOption.Click();
            Thread.Sleep(2000);
        }
    }
}

