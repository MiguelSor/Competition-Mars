using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.Driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//*[@name='serviceType']//following::input[1]")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'k-lg-date-format')]")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//*[@name='Available' and @index='0']")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//*[@name='StartTime' and @index='0']")]
        private IWebElement StartTime { get; set; }

        
        //Click on EndTime 
        [FindsBy(How = How.XPath, Using = "//*[@name='EndTime' and @index='0']")]
        private IWebElement EndTime { get; set; }

        //Click on Skill Trade option Skill exchange
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'skillTrades')])[1]")]
        private IWebElement SkillTradeOptionSkillExchange { get; set; }

        //Click on Skill Trade option Credit
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'skillTrades')])[2]")]
        private IWebElement SkillTradeOptionCredit { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void EnterShareSkill()
        {
           Global.GlobalDefinitions.ExcelLib.PopulateInCollection(AppDomain.CurrentDomain.BaseDirectory.Replace(@"MarsFramework\bin\Debug\", @"MarsFramework\ExcelData\TestDataShareSkill.xlsx"), "ShareSkill");

            //wait for element to appear
            Global.GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.Driver, By.LinkText("Share Skill"), (20));
            //Click on the share skill button
            ShareSkillButton.Click();

            //Click on the title field
            Global.GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.Driver, By.Name("title"), (20));
            Title.Click();
            //Type on the title field
            Title.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1, "Title"));

            //Click on the description
            Global.GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.Driver, By.Name("description"), (20));
            Description.Click();
            //Type on the Description
            Description.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1, "Description"));

            //Click on category dropdown
            CategoryDropDown.Click();
            //Choose an option from category dropdown
            CategoryDropDown.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1, "Category") + Keys.Enter);

            //Click on sub category
            SubCategoryDropDown.Click();
            //Choose an option from subcategory dropdown
            SubCategoryDropDown.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1, "SubCategory") + Keys.Enter);

            //Click on Tags Field
            Tags.Click();
            //Type on the Tags Field then press Enter
            Tags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(1, "Tags") + Keys.Enter);

            //Click and choose an option for Service type
            ServiceTypeOptions.Click();

            //Click and Choose an option for location type
            LocationTypeOption.Click();

            //click on a skill trade option skill exchange
            SkillTradeOptionSkillExchange.Click();

            //Click on skill exchange
            SkillExchange.Click();

            //Type and add a tag
            SkillExchange.SendKeys("Test tag" + Keys.Enter);

            //click on a skill trade option credit
            SkillTradeOptionCredit.Click();

            //Click on credit amount
            CreditAmount.Click();

            //type and add a credit amount
            CreditAmount.SendKeys("2" + Keys.Enter);

            //Click an option on Active
            ActiveOption.Click();

            //Save the skill
            Save.Click();

            Thread.Sleep(2000);

        }
    }
}
