using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace Demoqa
{
    [TestClass]
    public class browser
    {


        [Test,Category("TextBox")]
        public void Textbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            IWebElement fullname = driver.FindElement(By.XPath(".//*[@id='userName']"));
            fullname.SendKeys("Tuba Khan");
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='userEmail']"));
            email.SendKeys("tn.masroor@gmail.com");
            IWebElement address = driver.FindElement(By.XPath(".//*[@id='currentAddress']"));
            address.SendKeys("Hisings Backa");
            IWebElement permanentaddress = driver.FindElement(By.XPath(".//*[@id='permanentAddress']"));
            permanentaddress.SendKeys("Ovralidsgatan");          
            
            Thread.Sleep(3000);

            driver.Quit();
        }

        [Test, Category("CheckBox")]
        public void Checkbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='tree-node']/ol/li/span/label/span[3]"));
            checkbox.Click();
            Thread.Sleep(4000);
            driver.Quit();
        }


        
        [Test, Category("Radiobutton")]

        public void Radiobutton()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            IWebElement radiobutton = driver.FindElement(By.XPath(".//*[@id='app']/div/div/div[2]/div[2]/div[2]/div[2]/label"));
            radiobutton.Click();
            Thread.Sleep(5000);
            driver.Quit();

        }

        [Test, Category("WebTables")]

        public void Webtables()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            IWebElement webtables = driver.FindElement(By.XPath("//*[@id='addNewRecordButton']"));
            webtables.Click();
            IWebElement firstname = driver.FindElement(By.XPath("//*[@id='firstName']"));
            firstname.SendKeys("Tuba");
            IWebElement lastname = driver.FindElement(By.XPath("//*[@id='lastName']"));
            lastname.SendKeys("khan");
            IWebElement eaddress = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            eaddress.SendKeys("tn.masroor@gmail.com");
            IWebElement age = driver.FindElement(By.XPath("//*[@id='age']"));
            age.SendKeys("30");
            IWebElement salary = driver.FindElement(By.XPath("//*[@id='salary']"));
            salary.SendKeys("33000");
            IWebElement dep = driver.FindElement(By.XPath("//*[@id='department']"));
            dep.SendKeys("IT");
            Thread.Sleep(4000);
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='submit']"));
            submit.Click();
            Thread.Sleep(4000);
            driver.Quit();

        }

        [Test, Category("HomePage")]

        public void HomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/links");
            IWebElement links = driver.FindElement(By.XPath("//*[@id='simpleLink']"));
            links.Click();
            Thread.Sleep(5000);
            driver.Quit();

        }

        













    }

}


