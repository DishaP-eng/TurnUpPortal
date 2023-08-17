using System.Diagnostics.Metrics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.Page;

public class Program
{
    private static void Main(string[] args)
    {
        //Open the Browser
        IWebDriver driver = new ChromeDriver();

        //Loginpage object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginAction(driver);

        //Homepage object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);


        //TM page object initialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);
    }
}