using H.PrimeAutomationTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConsoleApp
{
    class SeleniumSetMethods
    {
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertyCollection.driver.FindElement(By.Id(element)).SendKeys(value);             

            if (elementtype == PropertyType.Name)
                PropertyCollection.driver.FindElement(By.Name(element)).SendKeys(value);         
        }

        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertyCollection.driver.FindElement(By.Id(element)).Click();

            if (elementtype == PropertyType.Name)
                PropertyCollection.driver.FindElement(By.Name(element)).Click();
        }

        public static void SelectDropdown(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementtype == PropertyType.Name)
                new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }

    }
}
