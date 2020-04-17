using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");

            //Maximize the window
            driver.Manage().Window.Maximize();

            //Find the Search text box using xpath
            IWebElement element = driver.FindElement(By.XPath("//*[@title='Search']"));

            //Enter some text in search text box
            element.SendKeys("learn-automation");

            //Press Search
            IWebElement element1 = driver.FindElement(By.XPath("//*[@class='gNO89b']"));
            element1.Click();

            //Close the browser
            //driver.Close();
        }
    }
}
