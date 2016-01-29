using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HelicopterOfTest.Helicopters.Web.Views.LoginAndSignup
{
    public class SignupPage : View, ISignupView
    {
        private IWebDriver _driver;
        private string _chromeDriverPath = @"C:\selenium2-48-net40\";
        private string _startPageUrl = @"http://www.amazon.com";

        public void Signup(string username, string password)
        {
            using (_driver = new ChromeDriver(_chromeDriverPath))
            {
                goToStartPage();
                Console.WriteLine("Signup for {0} with password {1} ", username, password);
                Console.WriteLine("This is where signup should be implemented with selenium commands. ");
                _driver.FindElement(By.Id("nav-link-yourAccount")).Click();
            }
        
        }

        public void goToStartPage()
        {
            _driver.Navigate().GoToUrl(_startPageUrl);
        }
    }
}
