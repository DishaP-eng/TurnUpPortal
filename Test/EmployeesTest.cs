using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.Page;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Test
{
    
    [TestFixture]
    [Parallelizable]
    public class EmployeesTest:CommonDriver
	{
        [SetUp]
		public void EmployeeSetUp()
		{
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);

            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);
        }

		[Test]
		public void CreateEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployee(driver);
        }

        [Test]
		public void EditEmployee_Test()
		{
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.EditEmployee(driver);
        }

		[Test]
		public void DeleteEmployee_Test()
		{
            EmployeesPage employeesPage = new EmployeesPage();
            employeesPage.DeleteEmployee(driver);
        }

		[TearDown]
		public void TestDown()
		{
            driver.Quit();
        }
			
	}
}

