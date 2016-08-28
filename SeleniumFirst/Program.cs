using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        // create reference for browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {      
           
        }
       
        
        [SetUp]
        public void Initialize()
        {

            //Mavigate to google page
            driver.Navigate().GoToUrl("http://www.n11.com/");
            Console.WriteLine("Open URL");

        }
        
        [Test]
        public void Login()
        {
            // title
            //SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            
            //Initial
            //SeleniumSetMethods.EnterText(driver, "Initial", "execute", "Name");
            //Console.WriteLine("value from Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));
            //Console.WriteLine("value from initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            // click
            //SeleniumSetMethods.Click(driver, "Save", "Name");
            
            
            Thread.Sleep(1000);
            // login button
            SeleniumSetMethods.Click(driver, "a.btnSignIn", "Css");
            Thread.Sleep(500);
            // enter e-mail and pasword
            SeleniumSetMethods.EnterText(driver, "email", "zyvdoxca@6paq.com", "Id");
            SeleniumSetMethods.EnterText(driver, "password", "asd123", "Id");
            Thread.Sleep(500);
            SeleniumSetMethods.Click(driver, "loginButton", "Id");
            Thread.Sleep(1000);
        
            //search 
            SeleniumSetMethods.EnterText(driver, "searchData", "samsung", "Id");
            Thread.Sleep(500);
            SeleniumSetMethods.Click(driver, "span.icon.iconSearch", "Css");
            Thread.Sleep(500);
            
            // buraya bak tekrar text i alamadın
            //Console.WriteLine("value " + SeleniumGetMethods.GetText(driver, "resultText ", "Class"));
            //Console.WriteLine("Result" + SeleniumGetMethods.GetTextFromDDL(driver, "resultText ", "Class"));
      
     
            //page 2
            SeleniumSetMethods.Click(driver, "//div[@id='contentListing']/div/div/div[2]/div[3]/a[2]", "Xpath");
            Thread.Sleep(500);
            //Console.WriteLine("Açılan sayfa: " + SeleniumGetMethods.GetText(driver, "//div[@id='contentListing']/div/div/div[2]/div[3]/div/input", "Xpath"));
            Thread.Sleep(1000);
      
            //add favorite 
            SeleniumSetMethods.Click(driver, "//div[@id='p-110033279']/div[2]/span[2]", "Xpath");
            Thread.Sleep(1000);
      
            //enter favorilerim 
            SeleniumSetMethods.Click(driver, "//a[contains(text(),'Favorilerim')]", "Xpath");
            Thread.Sleep(1000);
     
            SeleniumSetMethods.Click(driver, "//table[@id='watchList']/tbody/tr/td/a", "Xpath");
            Thread.Sleep(2000);
        }
       
        
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the Browser");
        }



    }
}
