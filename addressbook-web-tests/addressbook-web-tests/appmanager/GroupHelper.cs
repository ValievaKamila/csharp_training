using OpenQA.Selenium;  


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
            manager.Navigator.GoToGroupsPage();
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
                Type(By.Name("group_name"), group.Name);
                Type(By.Name("group_header"), group.Header);
                Type(By.Name("group_footer"), group.Footer);
                return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            manager.Navigator.GoToGroupsPage();
            groupCache = null;
            return this;
        }
        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + (index+1) + "]/input")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            groupCache = null;
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
            groupCache = null;
            return this;
        }
        public bool IsNotGroupPresent()
        {
            manager.Navigator.GoToGroupsPage();
            return !IsElementPresent(By.Name("selected[]"));
        }

        private List<GroupData> groupCache = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();
                manager.Navigator.GoToGroupsPage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    
                    groupCache.Add(new GroupData(element.Text)
                    {Id = element.FindElement(By.TagName("input")).GetAttribute("value")});
                }
            }
            return new List<GroupData>(groupCache);
        }

        public int GetGroupCount()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }
    }
}
