using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TurnUpPortal.Page;
using TurnUpPortal.Utilities;
    
namespace TurnUpPortal.StepDefinitions;

[Binding]
public class TmFeatureStepDefinition:CommonDriver
{
    
    [Given(@"I logged in to TurnUp portal successfully")]
    public void GivenILoggedInToTurnUpPortalSuccessfully()
    {
        //ScenarioContext.StepIsPending();
        driver = new ChromeDriver();

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginAction(driver);
    }

    [Given(@"I navigate to Time and Material page")]
    public void GivenINavigateToTimeAndMaterialPage()
    {
        //ScenarioContext.StepIsPending();
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);
    }

    [When(@"I create a new time record")]
    public void WhenICreateANewTimeRecord()
    {
        //ScenarioContext.StepIsPending();
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
    }

    [Then(@"the record should be created successfully")]
    public void ThenTheRecordShouldBeCreatedSuccessfully()
    {
      //  ScenarioContext.StepIsPending();
        TMPage tmPageObj = new TMPage();

        string codeNew = tmPageObj.GetCode(driver);

        Assert.That(codeNew == "August01", "Actual code and existing code do not match.");
    }
}