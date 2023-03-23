using GuruBank.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruBank.Tests
{
    internal class TestScript
    {
      

        [Test]

        public void ValidUserValidPass()
        {
           IWebDriver driver = new FirefoxDriver();
           Util util = new Util(driver);

                util.UserName("mngr485288");
                util.Password("dasahaq");
                util.Login();
                util.ExpectTitle();
                driver.Close();
                driver.Quit();
        }
        

        [Test]

        public void InvalidUserValidPass()
        {
            IWebDriver driver = new FirefoxDriver();
            Util util = new Util(driver);

                util.UserName("test");
                util.Password("dasahaq");
                util.Login();
                util.InvalidExpectTitle();
                driver.Close();
                driver.Quit();
        }
        

        [Test]

        public void ValidUserInvalidPass()
        {
            IWebDriver driver = new FirefoxDriver();
            Util util = new Util(driver);

                util.UserName("mngr485288");
                util.Password("123456");
                util.Login();
                util.InvalidExpectTitle();
                driver.Close();
                driver.Quit();
        }
        

        [Test]

        public void InvalidUserInvalidPass()
        {
           IWebDriver driver = new FirefoxDriver();
           Util util = new Util(driver);

                util.UserName("test");
                util.Password("123456");
                util.Login();
                util.InvalidExpectTitle();
                driver.Close();
                driver.Quit();
        }

    }
        
}
