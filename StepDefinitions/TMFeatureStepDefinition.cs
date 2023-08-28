using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TurnUpPortal.Page;
using TurnUpPortal.Utilities;
    
namespace TurnUpPortal.StepDefinitions;

[Binding]
public class TmFeatureStepDefinition:CommonDriver
{
    LoginPage loginPageObj = new LoginPage();
    HomePage homePageObj = new HomePage();
    TMPage tmPageObj = new TMPage();
    
    [Given(@"I logged in to TurnUp portal successfully")]
    public void GivenILoggedInToTurnUpPortalSuccessfully()
    {
        //ScenarioContext.StepIsPending();
        driver = new ChromeDriver();
        loginPageObj.LoginAction(driver);
    }

    [Given(@"I navigate to Time and Material page")]
    public void GivenINavigateToTimeAndMaterialPage()
    {
        homePageObj.GoToTMPage(driver);
    }

    [When(@"I create a new time record")]
    public void WhenICreateANewTimeRecord()
    {
        tmPageObj.CreateTimeRecord(driver);
    }

    [Then(@"the record should be created successfully")]
    public void ThenTheRecordShouldBeCreatedSuccessfully()
    {
        string codeNew = tmPageObj.GetCode(driver);
        Assert.That(codeNew == "Aug", "Actual code and existing code do not match.");
        tmPageObj.CloseSteps(driver);
    }

    [When(@"I update '(.*)' and '(.*)' an existing record")]
    public void WhenIUpdateAndAnExistingRecord(string p0, string p1)
    {
        tmPageObj.EditTimeRecord(driver,p0,p1);
    }
    
    [Then(@"the record should have an updated '(.*)'and '(.*)'")]
    public void ThenTheRecordShouldHaveAnUpdatedAnd(string p0, string p1)
    {
        string editedCode = tmPageObj.GetEditedCode(driver);
        string editedDescription = tmPageObj.GetEditedDescreption(driver);
        Assert.That(editedCode == p0,"Actual code and existing code do not match");
        Assert.That(editedDescription == p1,"Actual code and existing code do not match");
        tmPageObj.CloseSteps(driver);

    }

    [When(@"I delete an existing record")]
    public void WhenIDeleteAnExistingRecord()
    {
        tmPageObj.DeleteTimeRecord(driver);
    }

    [Then(@"the record should be deleted successfully")]
    public void ThenTheRecordShouldBeDeletedSuccessfully()
    {
        string deletedCode = tmPageObj.GetCode(driver);
        Assert.That(deletedCode != "Aug","Record has not been deleted");
        tmPageObj.CloseSteps(driver);
    }
}