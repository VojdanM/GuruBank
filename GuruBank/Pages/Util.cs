using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Browser;
using OpenQA.Selenium.DevTools.V108.Page;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruBank.Pages
{
    internal class Util
    {
        IWebDriver driver;
       

        public Util(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.demo.guru99.com/v4");
        }
       
        
        By username = By.Name("uid");
        By password = By.Name("password");
        By loginbutton = By.Name("btnLogin");
        By expecttitle = By.XPath("//marquee[contains(text(),\"Welcome To Manager's Page of Guru99 Bank\")]");
        By invalid_expect_title = By.XPath("/html/head");
        
        public void UserName(String tekst)
        {
            driver.FindElement(username).Clear();
            driver.FindElement(username).SendKeys(tekst);
            
        }
        

        public void Password(String tekst)
        {
            
            driver.FindElement(password).Clear();
            driver.FindElement(password).SendKeys(tekst);
            
        }

        public void Login()
        {
            driver.FindElement(loginbutton).Click();
        }

        public void ExpectTitle()
        {
            Assert.AreEqual("Welcome To Manager's Page of Guru99 Bank", driver.FindElement(expecttitle).Text);
        }

        public void InvalidExpectTitle()
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Assert.IsTrue(alertText.Contains("User or Password is not valid"));
            alert.Accept();

           // Assert.AreEqual(alert.Text, "User or Password is not valid");
        }

       
    }




}


