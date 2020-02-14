using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPerl10
{
    class LoginPageObjectModel
    {
        
        public IWebElement txtUserName
           => PropertiesCollection.driver.FindElement(By.Id("identifierId"));
        public IWebElement txtPassword
           => PropertiesCollection.driver.FindElement(By.XPath("//input[@type='password']"));
        public IWebElement btnNextUser
           => PropertiesCollection.driver.FindElement(By.Id("identifierNext"));
        public IWebElement btnNextPassword
           => PropertiesCollection.driver.FindElement(By.Id("passwordNext"));
        public IWebElement errorText
           => PropertiesCollection.driver.FindElement(By.XPath("//div[contains(text(),'Es posible que no sean seguros')]"));

        

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            btnNextUser.Click();
            txtPassword.SendKeys(password);
            btnNextPassword.Click();

            Questions.CompareTittle(errorText, "Es posible que no sean seguros este navegador o la app.");


        }






    }

    
}
