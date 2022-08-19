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
using WindowsInput.Native;
namespace Demoqa
{
    [TestClass]
    public class browser
    {




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



        [Test, Category("Textbox")]

        public void Textbox()
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
            driver.FindElement(By.Id("userName")).SendKeys("Tuba Khan");
            driver.FindElement(By.Id("userEmail")).SendKeys("tn.masroor@gmail.com");
            driver.FindElement(By.Id("currentAddress")).SendKeys("Hisings Backa");
            driver.FindElement(By.Id("permanentAddress")).SendKeys("Sweden");






            //Submit the form
            System.Threading.Thread.Sleep(2000);
            IWebElement submit = driver.FindElement(By.Id("submit"));
            js.ExecuteScript("window.scrollBy(0,150)", submit);
            submit.Click();






            System.Threading.Thread.Sleep(2000);



           






            System.Threading.Thread.Sleep(2000);
            driver.Quit();



        }

        [Test, Category("DoubleClick")]

        public void Doubleclick()
        {

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Navigate to site
            driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            driver.Manage().Window.Maximize();

            //Double click on button
            System.Threading.Thread.Sleep(2000);
            Actions action = new Actions(driver);
            IWebElement doubleClickElement = driver.FindElement(By.Id("doubleClickBtn"));
            action.DoubleClick(doubleClickElement).Build().Perform();



            //Write the results in console
            System.Threading.Thread.Sleep(2000);
            IWebElement successMsg = driver.FindElement(By.Id("doubleClickMessage"));
            Console.WriteLine(successMsg.Text);


            //Double click on button

            action.DoubleClick(doubleClickElement).Build().Perform();


            //Write the results in console
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(successMsg.Text);


            driver.Quit();


        }

            [Test, Category("PracticeForm")]

            public void PracticeForm()
            {

                IWebDriver driver = new ChromeDriver();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;












                //Double click on button
                Actions action = new Actions(driver);
   


                driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
                driver.Manage().Window.Maximize();






                System.Threading.Thread.Sleep(2000);
                driver.FindElement(By.Id("firstName")).SendKeys("Tuba");
                driver.FindElement(By.Id("lastName")).SendKeys("Khan");
                driver.FindElement(By.Id("userEmail")).SendKeys("tn.masroor@gmail.com");
                IWebElement gender = driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
                js.ExecuteScript("window.scrollBy(0,150)", gender);
                gender.Click();
                driver.FindElement(By.Id("userNumber")).SendKeys("9999999999");

                driver.FindElement(By.Id("currentAddress")).SendKeys("test");
                driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR" + Keys.Enter);
                driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi" + Keys.Enter);


                System.Threading.Thread.Sleep(2000);
                WindowsInput.InputSimulator simulator = new WindowsInput.InputSimulator();
                simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.SUBTRACT);


                simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.SUBTRACT);


                simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.SUBTRACT);


                simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.SUBTRACT);


                System.Threading.Thread.Sleep(2000);


                js.ExecuteScript("document.getElementById('submit').click();");


                System.Threading.Thread.Sleep(5000);


                //IWebElement submitButton = driver.FindElement(By.Id("submit"));
                //action.MoveToElement(submitButton)
                //.Build()
                //.Perform();


                //submitButton.Click();


                // System.Threading.Thread.Sleep(2000);
                //IWebElement submitButton = driver.FindElement(By.Id("submit"));
                //js.ExecuteScript("window.scrollBy(1078,689)", submitButton);
                // submitButton.Click();


                driver.Quit();










            }





        }






    }
    
        















    
  



