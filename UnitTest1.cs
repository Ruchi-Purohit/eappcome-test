// Unit Test Example

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Create a new instance of Selenium Webdriver
            IWebDriver driver = new ChromeDriver();
            // Navigate to URL
            driver.Navigate().GoToUrl("https://www.google.com/");
            // Maximize the window
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);
        }
        [Test]
        public void EAPPSOMME()
        {
            // Create a new instance of Selenium Webdriver
            IWebDriver driver = new ChromeDriver();
            // Navigate to URL
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            IWebElement loginlink = driver.FindElement(By.LinkText("Login"));
            loginlink.Click();
           // IWebDriver txtUserName

            
            


        }
    }
}
