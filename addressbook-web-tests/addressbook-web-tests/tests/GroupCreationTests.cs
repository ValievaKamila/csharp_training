using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            GroupData group = new GroupData("Group1");
            group.Header = "HeaderGroup1";
            group.Footer = "FooterGroup1";
            app.Groups.InitGroupCreation();
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToGroupPage();
        }
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.CreateContactPage();
            ContactData contact = new ContactData("Kamila4");
            contact.Lastname = "Valieva4";
            app.Contacts.FillContactForm(contact);
            app.Contacts.FinishContactCreation();
            app.Groups.ReturnToGroupPage();
        }
    }
}
