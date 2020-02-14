using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace TestPerl10
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            PropertiesCollection.driver = new FirefoxDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            PropertiesCollection.driver.Manage().Window.Maximize();
        }
    

        [Test]
        public void Test1()
        {

            
            LoginPageObjectModel pageLogin = new LoginPageObjectModel();
            
            pageLogin.Login("mvelezq19", "1424");
        }

        [TearDown]
        public void CLoseNavegator()
        {
            PropertiesCollection.driver.Close();
        }
    }
}