using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open the Browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch the turnup portal and navigate to login portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify username textbox and enter the valid user name

IWebElement usernameTextbox=driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter the valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify the login button and click on the button
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

Thread.Sleep(1000);

//check if user has logged in successfully
IWebElement helloHarri = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if(helloHarri.Text=="Hello hari!")
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

//Click on Time and Material Option
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();


Thread.Sleep(1000);

//Click on Create new button
IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnewButton.Click();

//Click on Typecode Dropdown
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodeDropdown.Click();

//Click on Time Option
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
timeOption.Click();

//Enter value in code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Dmd");

//Enter value in Description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("abc1");


//Enter value in Price per unit
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("367");

//Click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(1000);
//Check if record added or not

// Check if new Time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();     

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if(newCode.Text == "Dmd")

{
    Console.WriteLine("Time record has been created successfully.");
}
else
{
    Console.WriteLine("Time record hasn't been created.");
}


 