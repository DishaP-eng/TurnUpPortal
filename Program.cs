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