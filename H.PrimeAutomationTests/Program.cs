using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using H.PrimeAutomationTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.PrimeAutomationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //string title = "google";//driver.Title.GetType().;
            //Console.WriteLine(title);
            //Console.ReadLine();            
        }

        [SetUp]
        public void Initilize()
        {
            PropertyCollection.driver = new FirefoxDriver();
            //PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            PropertyCollection.driver.Navigate().GoToUrl("http://localhost:51943");
            PropertyCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Open URL and browser miximize window");
        }

        [Test]
        public void CreateDecipline()
        {
            LoginObjectModel pageLogin = new LoginObjectModel();
            pageLogin.Login("tim.alan", "JAMWeb123");
            //PropertyCollection.driver.Navigate().GoToUrl("https://dev10.jamweb.com.au/Discipline/ManageDiscipline.aspx");
            PropertyCollection.driver.Navigate().GoToUrl("http://localhost:51943/Discipline/ManageDiscipline.aspx");
            DisciplineObjectModel discipline = new DisciplineObjectModel();
            discipline.FillDiscipline("Test Adeel");
            Console.WriteLine("Discipline created successfully");

            //pageDiscipline.FillDiscipline("Test Discipline");
            
            //LoginObjectModel login = new LoginObjectModel();
            //login.txt_UserName.SendKeys("tim.alan");
            //login.txt_Password.SendKeys("JAMWeb123");
            //login.btn_login.Click();
            //PropertyCollection.driver.Navigate().GoToUrl("https://dev10.jamweb.com.au/Discipline/ManageDiscipline.aspx");

            //DisciplineObjectModel descipline = new DisciplineObjectModel();
            //descipline.btn_AddNewDecipline.Click();
            //descipline.txt_DisciplineName.SendKeys("Test Discipline");
            //descipline.ddb_AddButton.s
            
            

            //WebDriverWait wait = new WebDriverWait(PropertyCollection.driver, TimeSpan.FromTicks(30000));
            //wait.Until(ExpectedConditions.ElementExists();
            //IWebElement element = new IWebElement();

            //DisciplineObjectModel discipline = new DisciplineObjectModel();

            //discipline.btn_AddButton.Click();
            //discipline.txt_DisciplineName.SendKeys("Test");
            //discipline.ddb_AddButton.



            //SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);
            //SeleniumSetMethods.EnterText("Initial", "JK", PropertyType.Name);
            //SeleniumSetMethods.EnterText("FirstName", "Jawad", PropertyType.Id);
            //SeleniumSetMethods.EnterText("MiddleName", "K.", PropertyType.Name);
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
            //Console.WriteLine("Filled data in form fields");

            //Console.WriteLine("This is Title vlaue" + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            //Console.WriteLine("This is Title vlaue" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));


            //string page_title = driver.Title.ToString();
            //Console.WriteLine("Search content" + page_title);

            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("execute automation");

            //SeleniumGetMethods.GetText(driver, "TitleId", "Id");
            //SeleniumGetMethods.GetText(driver, "TitleId", "Id");



            //if (page_title.Equals("Execute Automation")) {
            //     Console.WriteLine("Great! ... Page title: " + page_title);




            //}


        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertyCollection.driver.Close();
            Console.WriteLine("Close browser");
        }
    }
}
