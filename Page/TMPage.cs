using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TurnUpPortal.Page
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click on Create new button
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton.Click();

            //Click on Typecode Dropdown
            IWebElement typecodeDropdown =
                driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodeDropdown.Click();

            //Click on Time Option
            IWebElement timeOption =
                driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            timeOption.Click();

            //Enter value in code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("August01");

            //Enter value in Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("abc1");


            //Enter value in Price per unit
            IWebElement priceTextbox =
                driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("367");

            //Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            // Check if new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode =
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }


        public void EditTimeRecord(IWebDriver driver)
        {
            //Click the Edit button
            IWebElement editButton =
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);

            //Click on Typecode Dropdown
            IWebElement edittypecodeDropdown1 =
                driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            //
            edittypecodeDropdown1.Click();

            //Click on Time Option for edit
            IWebElement edittimeOption =
                driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
            edittimeOption.Click();

            //Edit the value in code
            IWebElement editcodeTextbox = driver.FindElement(By.Id("Code"));
            editcodeTextbox.Clear();
            editcodeTextbox.SendKeys("August2023");


            //Edit the value in Description
            IWebElement editdescriptionTextbox = driver.FindElement(By.Id("Description"));
            editdescriptionTextbox.Clear();
            editdescriptionTextbox.SendKeys("DDD01");

            //Edit value in Price per unit
            IWebElement overlappingTag =
                driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            overlappingTag.Click();
            editPriceTextbox.Clear();
            overlappingTag.Click();
            editPriceTextbox.SendKeys("500");

            //Click on save button
            IWebElement editsaveButton = driver.FindElement(By.Id("SaveButton"));
            editsaveButton.Click();
            Thread.Sleep(2000);

            //Check if the record has been edited successfully
            IWebElement gotolastpagebutton1 =
                driver.FindElement(
                    By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); //*[@id="tmsGrid"]/div[4]/a[4]/span
            gotolastpagebutton1.Click();

            IWebElement Newdesc =
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            if (Newdesc.Text == "August2023")
            {
                Console.WriteLine("New record has been edited successfully");

            }
            else
            {
                Console.WriteLine("New record has not been edited");
            }
        }

        public void DeleteTimeRecord(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //Click on Delet button
            IWebElement deleteButton =
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            Thread.Sleep(1000);
            //switch to the alert dialog
            driver.SwitchTo().Alert().Accept();

            IWebElement newcode1 =
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode1.Text != "August2023")
            {

                Console.WriteLine(" New record has been successfully deleted");

            }
            else
            {
                Console.WriteLine("New record has not been deleted");
            }

        }
    }
}



