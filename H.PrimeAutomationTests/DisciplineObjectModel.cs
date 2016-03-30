using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.PrimeAutomationTests
{
    class DisciplineObjectModel
    {
        public DisciplineObjectModel()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        //[FindsBy(How = How.Id, Using = "TitleId")]
        //public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Id, Using = "cphMain_btnAddDiscipline")]
        public IWebElement btn_AddNewDecipline { get; set; }

        [FindsBy(How = How.Id, Using="cphMain_ucAddDiscipline_txtName")]
        public IWebElement txt_DisciplineName { get; set; }

        [FindsBy(How = How.Name, Using = "cphMain_ucAddDiscipline_ddlDiscColor")]
        public IWebElement ddb_AddButton { get; set; }

        [FindsBy(How= How.Name, Using="ctl00$cphMain$btnSaveDiscipline")]
        public IWebElement btn_AddButton { get; set; }

        public void FillDiscipline(string disciplineName) {
            btn_AddNewDecipline.Click();
            txt_DisciplineName.SendKeys(disciplineName);
            btn_AddButton.Click();
        }
    }
}
