﻿using OpenQA.Selenium;


namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager)
        : base(manager)
        {
        }
        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            return this;
        }
		    public GroupHelper Modify(int p, GroupData newData)
        {
			manager.Navigator.GoToGroupsPage();     
			SelectGroup(p);		
			InitGroupModification();
			FillGroupForm(newData);
			SubmitGroupModification();
			ReturnToGroupsPage();
            return this;
        }
		public GroupHelper Remove(int p)
		{
			manager.Navigator.GoToGroupsPage();
            SelectGroup(p);
            RemoveGroup();
            ReturnToGroupsPage();
			return this;
		}
		
            public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[4]")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GroupData group) //string name, string header, string footer)
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
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
		public GroupHelper InitGroupModification()
        {
			driver.FindElement(By.Name("edit")).Click();
            return this;
        }
		public GroupHelper SubmitGroupModification()
        {
			driver.FindElement(By.Name("update")).Click();
            return this;
        }
    }
}
