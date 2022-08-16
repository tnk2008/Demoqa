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

namespace Demoqa
{
    [TestClass]
    public class browser
    {
        private object doubleClickBtn;
        private int button;
        private object jMveg;

        public string Click { get; private set; }

        [TestMethod]
        public void Navigation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            IWebElement fullname = driver.FindElement(By.XPath(".//*[@id='userName']"));
            fullname.SendKeys("Nafees Khan");
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='userEmail']"));
            email.SendKeys("nafeesrazia@yahoo.co.in");
            Thread.Sleep(3000);

            driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            IWebElement radiobutton = driver.FindElement(By.XPath(".//*[@id='app']/div/div/div[2]/div[2]/div[2]/div[2]/label"));
            radiobutton.Click();
            Thread.Sleep(5000);



            driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='tree-node']/ol/li/span/label/span[3]"));
            checkbox.Click();
            Thread.Sleep(4000);

            driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            IWebElement webtables = driver.FindElement(By.XPath("//*[@id='addNewRecordButton']"));
            webtables.Click();
            IWebElement firstname = driver.FindElement(By.XPath("//*[@id='firstName']"));
            firstname.SendKeys("Tuba");
            IWebElement lastname = driver.FindElement(By.XPath("//*[@id='lastName']"));
            lastname.SendKeys("khan");

            Thread.Sleep(4000);

            

            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            IWebElement name = driver.FindElement(By.XPath("//*[@id='firstName']"));
            name.SendKeys("Tuba");
            IWebElement last = driver.FindElement(By.XPath("//*[@id='lastName']"));
            last.SendKeys("khan");
            Thread.Sleep(6000);

            driver.Navigate().GoToUrl("https://demoqa.com/links");
            IWebElement links = driver.FindElement(By.XPath(".//*[@id='simpleLink']"));
            links.Click();
            Thread.Sleep(5000);



            driver.Quit();


        }


        

           
            

    }

}


