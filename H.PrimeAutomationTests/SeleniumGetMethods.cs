﻿using H.PrimeAutomationTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.PrimeAutomationTests
{
    class SeleniumGetMethods
    {
        public static string GetText(string element, PropertyType elementtype){

            if (elementtype == PropertyType.Id)
                return PropertyCollection.driver.FindElement(By.Id(element)).GetAttribute("value");

            if (elementtype == PropertyType.Name)
                return PropertyCollection.driver.FindElement(By.Name(element)).GetAttribute("value");

            else return String.Empty;
        
        }

        public static string GetTextFromDDL(string element, PropertyType elementtype)
        {

            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;

            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;

            else return String.Empty;

        }

    }

    
}
