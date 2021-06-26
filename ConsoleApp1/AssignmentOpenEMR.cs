using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcepts
{
    class Program
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
       public static void OpenEMr()
        {
            String FName = "admin";
            String Passwrd = "pass";
            String Firstname = "Halsey";
            String Middlename = "laura";
            String Lastname = "Sheith";
            String DOB = "1995 - 06 - 01";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://demo.openemr.io/b/openemr/interface/login/login.php?site=default";
            driver.Manage().Window.Maximize();

            IWebElement FirstNme = driver.FindElement(By.Id("authUser"));
            SendkeyElement(FirstNme, FName);

            IWebElement Password = driver.FindElement(By.Id("clearPass"));
             SendkeyElement(Password, Passwrd);

            IWebElement Language = driver.FindElement(By.Name("languageChoice"));
            ClickElement(Language);
            SelectElement select = new SelectElement(Language);
            select.SelectByText("English (Indian)");

            IWebElement Login = driver.FindElement(By.XPath("//button[@type='submit']"));
            ClickElement(Login);

            Actions action = new Actions(driver);
            IWebElement PatientClientdropdown = driver.FindElement(By.XPath("//div[text()='Patient/Client']"));
            action.MoveToElement(PatientClientdropdown).Build().Perform();

            IWebElement Patient = driver.FindElement(By.XPath("//div[text()='Patients']"));
            ClickElement(Patient);

            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@name='fin']"));
            driver.SwitchTo().Frame(Frame1);
            Thread.Sleep(5000);

            IWebElement AddPatient = driver.FindElement(By.Id("create_patient_btn1"));
            ClickElement(AddPatient);
            driver.SwitchTo().DefaultContent();

            IWebElement Frame2 = driver.FindElement(By.XPath("//iframe[@name='pat']"));
            driver.SwitchTo().Frame(Frame2);
            Thread.Sleep(5000);

            IWebElement Nametitle = driver.FindElement(By.Id("form_title"));
            SelectElement Select = new SelectElement(Nametitle);
            Select.SelectByText("Ms.");

            IWebElement FirstName = driver.FindElement(By.Id("form_fname"));
          SendkeyElement(FirstName, Firstname);

            IWebElement MiddleName = driver.FindElement(By.Id("form_mname"));
            
            SendkeyElement(MiddleName, Middlename);

            IWebElement LastName = driver.FindElement(By.Id("form_lname"));
            SendkeyElement(LastName, Lastname);

            IWebElement Dateofbrith = driver.FindElement(By.Id("form_DOB"));
            SendkeyElement(Dateofbrith, DOB);

            IWebElement Gender = driver.FindElement(By.Id("form_sex"));
            SelectElement Select1 = new SelectElement(Gender);
            Select1.SelectByText("Female");

            IWebElement CreatePatientButton = driver.FindElement(By.Id("create"));
            ClickElement(CreatePatientButton);
            driver.SwitchTo().DefaultContent();

            IWebElement Frame3 = driver.FindElement(By.XPath("//iframe[@id='modalframe']"));
            driver.SwitchTo().Frame(Frame3);
            Thread.Sleep(5000);

            IWebElement ConfirmPatientButton = driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']"));
            ClickElement(ConfirmPatientButton);
            Thread.Sleep(5000);
            //  driver.SwitchTo().DefaultContent();


            /*Console.WriteLine("Script Executed");
            driver.Close();
*/
        }
    }
}
