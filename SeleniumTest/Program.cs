using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;




namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(link);
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@class='seg-popup-close']")).Click();
    
            driver.FindElement(By.ClassName("btnSignIn")).Click();
            driver.FindElement(By.Id("email")).SendKeys("hacicelik0710@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("07102016");
            driver.FindElement(By.Id("loginButton")).Click();


            driver.FindElement(By.Id("searchData")).SendKeys("bilgisayar");
            driver.FindElement(By.ClassName("searchBtn")).Click();
            driver.FindElement(By.XPath(".//[@id='contectListing']/div/div/div[2]/div[3]/a[2]")).Click();

            driver.FindElement(By.XPath(".//[@id='p-385821567']/div[1]/a")).Click();

            driver.FindElement(By.ClassName("btnAddBasket")).Click();

            





        }
    }
}
