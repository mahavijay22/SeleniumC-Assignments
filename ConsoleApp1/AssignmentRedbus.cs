using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace ConsoleApp1
{
    class AssignmentRedbus
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
     public   static void Redbus()
        {
            String Phone = "87364873456";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.redbus.in/";
            driver.Manage().Window.Maximize();

            IWebElement UserID = driver.FindElement(By.Id("i-icon-profile"));
            ClickElement(UserID);

            IWebElement SignInLink = driver.FindElement(By.Id("signInLink"));
            ClickElement(SignInLink);


            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@class='modalIframe']"));
            driver.SwitchTo().Frame(Frame1);
            Thread.Sleep(5000);

            IWebElement EnterPhNo = driver.FindElement(By.Id("mobileNoInp"));
            SendkeyElement(EnterPhNo, Phone);

            driver.SwitchTo().DefaultContent();
            Console.WriteLine("Script Executed");
            driver.Close();


        }
    }
}
