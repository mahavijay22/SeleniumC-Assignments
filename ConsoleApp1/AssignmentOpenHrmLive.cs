
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;


namespace ConsoleApp1
{
    class AssignmentOpenHrmLive
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
        static void Main(string[] args)

        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Manage().Window.Maximize();

            String username = "Admin";
            String passwd = "admin123";
            String Name = "Brian";
            String Relationship = "Brother";
            String Mobilephone = "8934324652";
            String HomePhone = "021786543";
            String Workphone = "044235643";


            IWebElement userid = driver.FindElement(By.Id("txtUsername"));
            SendkeyElement(userid, username);

            IWebElement password = driver.FindElement(By.Id("txtPassword"));
            SendkeyElement(password, passwd);

            Actions action = new Actions(driver);
            IWebElement submitbutton = driver.FindElement(By.Name("Submit"));
            action.Click(submitbutton).Build().Perform();

            String pageURL = driver.Url;
            Console.WriteLine("--------------------------");
            Console.WriteLine(pageURL);

            IWebElement MyInfo = driver.FindElement(By.PartialLinkText("My Info"));
            ClickElement(MyInfo);

            IWebElement EmergencyContacts = driver.FindElement(By.PartialLinkText("Emergency Contacts"));
            ClickElement(EmergencyContacts);

            IWebElement AddContact = driver.FindElement(By.Id("btnAddContact"));
            ClickElement(AddContact);

            IWebElement AddContactName = driver.FindElement(By.Name("emgcontacts[name]"));
            SendkeyElement(AddContactName, Name);

            IWebElement AddContactRelationship = driver.FindElement(By.Name("emgcontacts[relationship]"));
            SendkeyElement(AddContactRelationship, Relationship);

            IWebElement AddContactHomephone = driver.FindElement(By.Name("emgcontacts[homePhone]"));
            SendkeyElement(AddContactHomephone, HomePhone);

            IWebElement AddContactmobilephone = driver.FindElement(By.Name("emgcontacts[mobilePhone]"));
            SendkeyElement(AddContactmobilephone, Mobilephone);

            IWebElement AddContactworkphone = driver.FindElement(By.Name("emgcontacts[workPhone]"));
            SendkeyElement(AddContactworkphone, Workphone);

            IWebElement AddContactSave = driver.FindElement(By.Name("btnSaveEContact"));
            ClickElement(AddContactSave);

            Console.WriteLine("Script Executed");
            driver.Close();
        }

    }
}
