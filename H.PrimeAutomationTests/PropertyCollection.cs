using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.PrimeAutomationTests
{
    enum PropertyType
    {
        Id,
        Name, 
        CSSName
    }


    class PropertyCollection
    {
        //Auto implemented Property
        public static IWebDriver driver { get; set; }
    }
}
