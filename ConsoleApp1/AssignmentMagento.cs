using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace ConsoleApp1
{
    class AssignmentMagento
    {
        public static void ClickElement(IWebElement Ele)
        {
            Ele.Click();
        }

        public static void SendkeyElement(IWebElement Ele, String s)
        {
            Ele.Click();
            Ele.Clear();
            Ele.SendKeys(s);
        }

      public  static void Magento()
        {

            String Email = "balaji0017@gmail.com";
            String Emailpasswd = "balaji@12345";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://magento.com/";
            driver.Manage().Window.Maximize();

            IWebElement signin = driver.FindElement(By.XPath("//span[text()='Sign in']"));
            ClickElement(signin);

            IWebElement EmailAddress = driver.FindElement(By.Name("login[username]"));
            SendkeyElement(EmailAddress, Email);

            IWebElement password = driver.FindElement(By.Name("login[password]"));
            SendkeyElement(password, Emailpasswd);

            Actions action = new Actions(driver);
            IWebElement Continuebutton = driver.FindElement(By.XPath("//button/span[text()='Continue']"));
            action.Click(Continuebutton).Build().Perform();

            String pagetitle = driver.Title;
            Console.WriteLine("--------------------------");
            Console.WriteLine(pagetitle);

            IWebElement Logoutbutton = driver.FindElement(By.PartialLinkText("Log Out"));
            ClickElement(Logoutbutton);

            Console.WriteLine("Script Executed");
            driver.Close();
        }
    }
}
