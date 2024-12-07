﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(IWebDriver driver)
        : base(driver)
        {
        }
        public void InitGroupCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[4]")).Click();
        }
        public void FillGroupForm(GroupData group) //string name, string header, string footer)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        public void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("group page")).Click();
        }
        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
        }
        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
    }
}
