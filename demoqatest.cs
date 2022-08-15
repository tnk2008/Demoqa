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
            Thread.Sleep(3000);



            driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='tree-node']/ol/li/span/label/span[3]"));
            checkbox.Click();
            Thread.Sleep(4000);
            driver.Quit();




        }


    }
}


