using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HelicopterOfTestProject.Alskami.Helicopters.Web.Views.LoginAndSignup
{
    public class SignupPage : View, ISignupView
    {
        private IWebDriver driver;

        public void Signup(string username, string password)
        {
            startDriver();
            Console.WriteLine("Signup for {0} with password {1} ", username, password);
            Console.WriteLine("This is where signup should be implemented with selenium commands. ");
            driver.FindElement(By.Id("nav-link-yourAccount")).Click();
            
            driver.Quit();
        }

        public void startDriver()
        {
            driver = new ChromeDriver(@"C:\selenium2-48-net40\");
            driver.Navigate().GoToUrl("http://www.amazon.com");
        }
    }
}
