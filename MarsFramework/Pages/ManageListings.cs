using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.Driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View Edited Listings Link
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Selenium')]")]
        private IWebElement EditListingsLink { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'title')]")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'subcategoryId')]")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click on Next Button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui button otherPage'][contains(.,'>')]")]
        private IWebElement NextButton { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'tagInputField')]")]
        private IWebElement Tags { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        internal void EditShareSkill()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(AppDomain.CurrentDomain.BaseDirectory.Replace(@"MarsFramework\bin\Debug\", @"MarsFramework\ExcelData\TestDataManageListings.xlsx"), "ManageListings");

            //Wait for Manage Listings to appear
            GlobalDefinitions.WaitForElement(GlobalDefinitions.Driver, By.LinkText("Manage Listings"), (20));

            //Click on Manage Listings
            manageListingsLink.Click();

            //Wait for the Title of the listing to appear
            GlobalDefinitions.WaitForElement(GlobalDefinitions.Driver, By.XPath("//*[contains(text(),'Selenium')]"), (20));

            //See if listing is displayed and click on edit icon of that listing
            if (EditListingsLink.Displayed && edit.Displayed)
            {
                if (EditListingsLink.Text == "Selenium" && edit.Equals(GlobalDefinitions.Driver.FindElement(By.XPath("(//i[@class='outline write icon'])"))))
                {
                    edit.Click();

                    //wait for the title to appear
                    GlobalDefinitions.WaitForElement(GlobalDefinitions.Driver, By.XPath("//input[contains(@name,'title')]"), 20);
                    //click on title
                    Title.Click();
                    //clear the title
                    Title.Clear();
                    //update the title 
                    Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(1, "Title"));


                    //click on Description
                    Description.Click();
                    //clear the description
                    Description.Clear();
                    //update the description
                    Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(1, "Description"));


                    //Click on category dropdown
                    CategoryDropDown.Click();
                    //Choose programming and tech from drop down menu
                    GlobalDefinitions.ExcelLib.ReadData(1, "Category" + Keys.Enter);

                    //Click on subcategory dropdown
                    SubCategoryDropDown.Click();
                    GlobalDefinitions.ExcelLib.ReadData(1, "SubCategory" + Keys.Enter);

                    //Click on save button to apply changes
                    Save.Click();

                }
            }
        }

        internal void DeleteShareSkill()
        {
            //Wait for Manage Listings to appear
            GlobalDefinitions.WaitForElement(GlobalDefinitions.Driver, By.LinkText("Manage Listings"), (20));

            //Click on Manage Listings
            manageListingsLink.Click();

            //Wait for the Title of the listing to appear
            GlobalDefinitions.WaitForElement(GlobalDefinitions.Driver, By.XPath("//*[contains(text(),'Title Edited')]"), (20));

            //See if listing is displayed and click on edit icon of that listing
            if (EditListingsLink.Displayed && edit.Displayed)
            {
                if (EditListingsLink.Text == "Title Edited" && edit.Equals(GlobalDefinitions.Driver.FindElement(By.XPath("(//i[@class='outline write icon'])"))))
                {
                    

                    //Click on save button to apply changes
                    Save.Click();

                }
            }
        }
    }
}
