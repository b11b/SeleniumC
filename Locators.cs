using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.Debugger;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace UdemyTestLearn
{
    internal class Locators
    {

        IWebDriver driver;
        [SetUp]
        public void StartBrowser()

        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver("D:/Kyrs Python/testing automatization/Chromdriver");
            driver.Manage().Window.Maximize();
            driver.Url = "https://chercher.tech/practice/drag-drop.html";
        }


        [Test]
        public void LocatorsIndetification()
        {

            IWebElement box1 = driver.FindElement(By.Id("box1"));
            IWebElement target = driver.FindElement(By.Id("destination"));

            string box1_classAttr = box1.GetAttribute("class");
            string exp_value = "box navy";

            Assert.That(box1_classAttr, Is.EqualTo(exp_value));

            var act = new Actions(driver);

            act.MoveToElement(box1).ClickAndHold(box1).MoveToElement(target).Release(box1).Build().Perform();

            

            driver.Close();

        }
    }
}
