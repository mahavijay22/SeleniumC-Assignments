using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static void ClickElement(IWebElement Ele)

        {Ele.Click();

        }
public static void SendkeyElement(IWebElement Ele, String s)

        { Ele.Click();
            Ele.Clear();
            Ele.SendKeys(s);

        }

        static void Main(string[] args)

        {

            String fname = "Dennis";
            String lname = "Rich";
            String Year = "1995";
            String email = "Denni9@gmail.com";
            String pswd = "dreincnh@9078";
            String ans = "BTS";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.royalcaribbean.com";
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
            IWebElement Close = driver.FindElement(By.XPath("//*[local-name()='svg']"));
            ClickElement(Close);

            IWebElement sign = driver.FindElement(By.XPath("//a[@id='rciHeaderSignIn']/span"));
            ClickElement(sign);

            IWebElement Createaccount = driver.FindElement(By.LinkText("Create an account"));
            ClickElement(Createaccount);

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']"));
            SendkeyElement(FirstName, fname);

            IWebElement LastName = driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']"));
            SendkeyElement(LastName, lname);

            IWebElement clickMonth = driver.FindElement(By.XPath("//span[text()='Month']"));
            ClickElement(clickMonth);

            IWebElement SelectMonth = driver.FindElement(By.XPath("//span[text()=' April ']"));
            ClickElement(SelectMonth);

            IWebElement clickDay = driver.FindElement(By.XPath("//span[text()='Day']"));
            ClickElement(clickDay);

            IWebElement SelectDay = driver.FindElement(By.XPath("//span[text()=' 4 ']"));
            ClickElement(SelectDay);

            IWebElement sendYear = driver.FindElement(By.XPath("//input[@data-placeholder='Year']"));
            SendkeyElement(sendYear, Year);

            IWebElement clickCountry = driver.FindElement(By.XPath("//span[text()='Country/Region of residence']"));
            ClickElement(clickCountry);

            IWebElement SelectCountry = driver.FindElement(By.XPath("//span[text()=' India ']"));
            ClickElement(SelectCountry);

            IWebElement Emailaddress = driver.FindElement(By.XPath("//input[@data-placeholder='Email address']"));
            SendkeyElement(Emailaddress, email);

            IWebElement Password = driver.FindElement(By.XPath("//input[@data-placeholder='Create new password']"));
            SendkeyElement(Password, pswd);

            IWebElement ClickQuestion = driver.FindElement(By.XPath("//span[text()='Select one security question']"));
            ClickElement(ClickQuestion);

            IWebElement SelectQuestion = driver.FindElement(By.XPath("//span[text()=' What was the first concert you attended? ']"));
            ClickElement(SelectQuestion);

            IWebElement Answer = driver.FindElement(By.XPath("//input[@data-placeholder='Answer']"));
            SendkeyElement(Answer, ans);

            IWebElement Checkbox = driver.FindElement(By.XPath("//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin']"));
            ClickElement(Checkbox);

            IWebElement DoneButton = driver.FindElement(By.XPath("//button[text()=' Done ']"));
            ClickElement(DoneButton);
        }
    }
    }

