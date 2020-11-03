using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Example
{
    class TestCases
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.daraz.pk/#");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Opened Draz.pk");

        }
        [Test]
        public void LoginOpenTest() 
        {
            driver.FindElement(By.LinkText("LOGIN")).Click();
            Console.WriteLine("Successfully opened: "+driver.Url);
        }
        [Test]
        public void SignupOpenTest()
        {
            driver.FindElement(By.LinkText("SIGNUP")).Click();
            Console.WriteLine("Successfully opened: " + driver.Url);
        }
        [Test]
        public void RegisterTest()
        {
            driver.Navigate().GoToUrl("https://member.daraz.pk/user/register?redirect=https%3A%2F%2Fwww.daraz.pk%2F&signupType=email&spm=a2a0e.login_signup.0.0.6f697d68sQEPDi");
            Console.WriteLine("Successfully opened: " + driver.Url);
            driver.FindElement(By.CssSelector(".mod-input-email input")).SendKeys("summarkimail@gmail.com");
            driver.FindElement(By.CssSelector(".mod-input-name input")).SendKeys("Summar Raja");
            driver.FindElement(By.CssSelector(".mod-input-password input")).SendKeys("pass12345");
            driver.FindElement(By.CssSelector(".mod-login-btn input")).Click();
            Console.WriteLine("Registered Successfully");

        }

        [Test]
        public void InvalidLoginTest()
        {
            driver.Navigate().GoToUrl(driver.FindElement(By.LinkText("LOGIN")).GetAttribute("href"));
            Console.WriteLine("Successfully opened: " + driver.Url);
            driver.FindElement(By.CssSelector(".mod-input-loginName > input")).SendKeys("summarraja");
            driver.FindElement(By.CssSelector(".mod-input-password > input")).SendKeys("summarraja123");
            driver.FindElement(By.CssSelector(".mod-login-btn > button")).Click();
            Console.WriteLine("Invalid Credentials");

        }
        [Test]
        public void SearchWithEnterTest()
        {
            driver.FindElement(By.Id("q")).SendKeys("laptop"+Keys.Enter);
            Console.WriteLine("Query Searched!");
        }
        [Test]
        public void SearchWithClickTest()
        {
            driver.FindElement(By.Id("q")).SendKeys("laptop" );
            driver.FindElement(By.CssSelector(".search-box__search--2fC5 button")).Click();
            Console.WriteLine("Query Searched!");
        }
        [Test]
        public void AddToCartTest()
        {
            driver.Navigate().GoToUrl("https://www.daraz.pk/products/hp-probook-440-g5-14-fhd-display-8th-gen-intelcore-i7-8550u-8gb-ram-1tb-rom-2gb-nvidia-geforce-930mx-freedos-i103392626-s1249538294.html?spm=a2a0e.searchlist.list.2.512b1f05hpLZ5o&search=1");
            Console.WriteLine("Successfully opened: " + driver.Url);
            driver.FindElement(By.CssSelector(".add-to-cart-buy-now-btn pdp-button")).Click();
            Console.WriteLine("Added to Cart");

        }
        [Test]
        public void ViewCartTest()
        {
            driver.Navigate().GoToUrl("https://www.daraz.pk/products/hp-probook-440-g5-14-fhd-display-8th-gen-intelcore-i7-8550u-8gb-ram-1tb-rom-2gb-nvidia-geforce-930mx-freedos-i103392626-s1249538294.html?spm=a2a0e.searchlist.list.2.512b1f05hpLZ5o&search=1");
            Console.WriteLine("Successfully opened: " + driver.Url);
            driver.FindElement(By.CssSelector(".cart-icon svg")).Click();
            Console.WriteLine("Cart Opened");

        }

        [Test]
        public void AddQuestionTest()
        {
            driver.Navigate().GoToUrl("https://www.daraz.pk//products/i164734553-s1332368160.html?spm=a2a0e.cart.0.0.72af7d68mpdJcq&urlFlag=true");
            Console.WriteLine("Successfully opened: " + driver.Url);
            driver.FindElement(By.CssSelector("qna-ask-input")).SendKeys("This is my question");
            driver.FindElement(By.CssSelector(".qna-ask-btn")).Click();
            Console.WriteLine("Question Added");

        }
        [Test]
        public void AddQuestionEnterTest()
        {
            driver.Navigate().GoToUrl("https://www.daraz.pk//products/i164734553-s1332368160.html?spm=a2a0e.cart.0.0.72af7d68mpdJcq&urlFlag=true");
            Console.WriteLine("Successfully opened: " + driver.Url);
            driver.FindElement(By.CssSelector("qna-ask-input")).SendKeys("This is my question"+Keys.Enter);
            Console.WriteLine("Question Added");

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed Driver");
        }
    }
}
