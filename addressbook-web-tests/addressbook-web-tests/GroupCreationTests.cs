using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("Group1");
            group.Header = "HeaderGroup1";
            group.Footer = "FooterGroup1";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
        }
        [Test]
        public void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            CreateContactPage();
            ContactData contact = new ContactData("Kamila3");
            contact.Lastname = "Valieva3";
            FillContactForm(contact);
            FinishContactCreation();
            ReturnToGroupPage();
        }
    }
}
