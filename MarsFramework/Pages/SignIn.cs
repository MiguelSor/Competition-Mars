using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.Driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(AppDomain.CurrentDomain.BaseDirectory.Replace(@"MarsFramework\bin\Debug\", @"MarsFramework\ExcelData\TestDataShareSkill.xlsx"), "SignIn");
            //Click on the Sign In Tab
            SignIntab.Click();

            //Click on the email field
            Email.Click();

            //Type the email of the user on the email field
            Email.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1,"Username"));

            //Click on the password field
            Password.Click();

            //Type the password of the user on the password field
            Password.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1,"Password"));

            //Click on the login button
            LoginBtn.Click();


        }
    }
}