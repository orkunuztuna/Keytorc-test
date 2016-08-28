using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            else if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else if (elementtype == "Class")
                return driver.FindElement(By.ClassName(element)).GetAttribute("value");
            else if (elementtype == "Xpath")
                return driver.FindElement(By.XPath(element)).GetAttribute("value");
            else return String.Empty;
        }
        public static string GetTextFromDDL(IWebDriver driver, string element, string elementtype)
        {
            //if (elementtype == "Id")
            //    return driver.FindElement(By.Id(element)).Text;
            //else if (elementtype == "Name")
            //    return driver.FindElement(By.Name(element)).Text;
            //else return String.Empty;

            if (elementtype == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            else if (elementtype == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;

        }
    }
}
