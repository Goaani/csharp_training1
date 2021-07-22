using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class ContactCreationTests
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void LoginAndCreateContact()
        {
            OpenHomePage();
            Login(new AccountData ("admin", "secret"));
            GoToContactCreation();
            //InitContactCreation();
            ContactData contact = new ContactData("Andrii");
            contact.Lastname = "Trialovich";
            contact.Nickname = "Trio";
            contact.Phone = "067484857";
            contact.Company = "Test Company";
            contact.Email = "dsajkkj@kujsdgf.sdf";
            SubmitContactCreation();
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.CssSelector("input:nth-child(87)")).Click();
        }

        private void FillContactFields(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).SendKeys(contact.Phone);
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).SendKeys(contact.Email);
        }

        private void GoToContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void Login(AccountData account)
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1850, 1017);
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }
    }
}
