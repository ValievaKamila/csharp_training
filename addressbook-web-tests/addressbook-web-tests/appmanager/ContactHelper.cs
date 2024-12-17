using OpenQA.Selenium;


namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager)
        : base(manager)
        {
        }
        public ContactHelper Create(ContactData contact)
        {
            CreateContactPage();
            FillContactForm(contact);
            FinishContactCreation();
            manager.Navigator.GoToHomePage();
            return this;
        }
        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            manager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper Remove()
        {
            manager.Navigator.GoToHomePage();
            SelectContact();
            RemoveContact();
            manager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper CreateContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }
        public ContactHelper FinishContactCreation()
        {
            driver.FindElement(By.XPath("//input[@value='Enter']")).Click();
            return this;
        }

        public ContactHelper SelectContact()
        {
            driver.FindElement(By.XPath("//input[@name='selected[]']")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();
            return this;
        }

        private ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public bool IsNotContactPresent()
        {
            manager.Navigator.GoToHomePage();
            return !IsElementPresent(By.Name("entry"));
        }
    }   
}
