using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AssignmentDatatables
    {
        public static void ClickElement(IWebElement Ele)
        {

            Ele.Click();
        }

        public static void SendkeyElement(IWebElement Ele, String s)
        {

            Ele.Click();
            Ele.SendKeys(s);
        }

        static void Main(string[] args)
        {


            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            driver.Manage().Window.Maximize();

            IWebElement EntryLength = driver.FindElement(By.Name("example_length"));

            SelectElement select = new SelectElement(EntryLength);

            select.SelectByValue("50");

            int rowCount = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;

            Console.WriteLine("Rowcount=" + rowCount);

            Console.WriteLine("-----------SalaryDetails--------");
            int Salary1, totalsalary = 0;
            for (int i = 1; i <= rowCount; i++)
            {

                String Salary = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[6]")).Text;
                Console.WriteLine(Salary);
                String SalaryDetails = Salary.Replace("$", "").Replace(",", "");
                Console.WriteLine(SalaryDetails);
                Salary1 = Convert.ToInt32(SalaryDetails);
                totalsalary = totalsalary + Salary1;
                Console.WriteLine("totalsalary---" + totalsalary);
            }
        }
    }
}

