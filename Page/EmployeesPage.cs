using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Page
{
	public class EmployeesPage
	{
		public void CreateEmployee(IWebDriver driver)
		{
			//Click on Create Button
			IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
			createButton.Click();

			//Click on Name TextBox
			IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
			nameTextBox.SendKeys("Manoj");
			
			//Click on Username TextBox
			IWebElement usernameTexBox = driver.FindElement(By.Id("Username"));
			usernameTexBox.SendKeys("Manoj j");
			
			//Cick on Contact TextBox
			IWebElement contactTextBox = driver.FindElement(By.Id("ContactDisplay"));
			contactTextBox.SendKeys("ABC");
			
			//Cick on EditContactButton
			IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
			editContactButton.Click();
			
			Thread.Sleep(2000);
			
			driver.SwitchTo().Frame(0);
            
			IWebElement firstNameTextBox = driver.FindElement(By.Id("FirstName"));
			firstNameTextBox.SendKeys("TestFirstname");

			IWebElement lastNameTextBox = driver.FindElement(By.Id("LastName"));
			lastNameTextBox.SendKeys("Testlastname");

			IWebElement phoneTextBox = driver.FindElement(By.Id("Phone"));
			phoneTextBox.SendKeys("1234567890");

			IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
			saveContactButton.Click();

			driver.SwitchTo().DefaultContent();
			
			//Click on Password TextBox

			IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
			passwordTextBox.SendKeys("Test@1234");
			
            //Click on Password TextBox
			IWebElement retypePWTextBox = driver.FindElement(By.Id("RetypePassword"));
			retypePWTextBox.SendKeys("Test@1234");
			Thread.Sleep(2000);

			//Click on Save button

			IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
			saveButton.Click();
            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/div/a", 3);


            //Verify if the Employee record is saved successfully

            IWebElement backToListlink = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a")); 
            backToListlink.Click();
            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 3);
            
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));////*[@id="usersGrid"]/div[4]/a[4]/span
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 3);

            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(name.Text == "Manoj", "Employee record not created");
            
		}

		public void EditEmployee(IWebDriver driver)
        {
        }
        public void DeleteEmployee(IWebDriver driver)
        {
        }

    }
}

