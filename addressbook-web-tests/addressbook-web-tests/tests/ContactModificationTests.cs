using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressbookTests
{
	[TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            if (app.Contacts.IsNotContactPresent())
            {
                ContactData contact = new ContactData("FirstnameCreatedToModify");
                contact.Lastname = "LastnameCreatedToModify";
                app.Contacts.Create(contact);
            }
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            ContactData contactNew = new ContactData("NewFirstname");
            contactNew.Lastname = "NewLastname";
            app.Contacts.Modify(contactNew);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0] = contactNew;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
