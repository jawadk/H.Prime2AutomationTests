using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.PrimeAutomationTests
{
    class LoginObjectModel
    {
        public LoginObjectModel()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "txtUserName")]
        public IWebElement txt_UserName { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement txt_Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='frmLogin']/fieldset/section[2]/div/div/div/a")]
        public IWebElement click_ForgotPassword { get; set; }

        [FindsBy(How=How.Id, Using="btn_Login")]
        public IWebElement btn_login{ get; set; }

        public DisciplineObjectModel Login(string username, string password) 
        {
            txt_UserName.SendKeys(username);
            txt_Password.SendKeys(password);
            btn_login.Click();
            return new DisciplineObjectModel();
        }
    }
}
