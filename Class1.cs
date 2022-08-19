

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Demoqa
{
    internal class XPath
    {


        static void main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;






            //Navigate to site
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();






            //Click on elements tab
            System.Threading.Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.XPath("//div[contains(@class,'cards')]/div[1]"));
            element.Click();






            //Click on text box tab
            System.Threading.Thread.Sleep(2000);
            IWebElement textBoxElement = driver.FindElement(By.XPath("//div[contains(@class,'element-list')]/ul/li/span[text()='Text Box']"));
            js.ExecuteScript("window.scrollBy(0,150)", textBoxElement);
            textBoxElement.Click();






            //Fill the form
            driver.FindElement(By.Id("userName")).SendKeys("test");
            driver.FindElement(By.Id("userEmail")).SendKeys("test@gmail.com");
            driver.FindElement(By.Id("currentAddress")).SendKeys("test");
            driver.FindElement(By.Id("permanentAddress")).SendKeys("test");






            //Submit the form
            System.Threading.Thread.Sleep(2000);
            IWebElement submit = driver.FindElement(By.Id("submit"));
            js.ExecuteScript("window.scrollBy(0,150)", submit);
            submit.Click();






            System.Threading.Thread.Sleep(2000);






            //Click on button tab
            IWebElement buttonElement = driver.FindElement(By.XPath("//div[contains(@class,'element-list')]/ul/li/span[text()='Buttons']"));
            js.ExecuteScript("window.scrollBy(0,150)", buttonElement);
            buttonElement.Click();






            System.Threading.Thread.Sleep(2000);






            //Double click on button
            Actions action = new Actions(driver);
            IWebElement doubleClickElement = driver.FindElement(By.Id("doubleClickBtn"));
            action.DoubleClick(doubleClickElement).Build().Perform();






            //Write the results in console
            System.Threading.Thread.Sleep(2000);
            IWebElement successMsg = driver.FindElement(By.Id("doubleClickMessage"));
            Console.WriteLine(successMsg.Text);






            System.Threading.Thread.Sleep(2000);
            driver.Quit();
        }
    }
}