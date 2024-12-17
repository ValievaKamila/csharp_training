using NUnit.Framework;


namespace WebAddressbookTests
{
	[TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            //prepare - подготовка
            if (app.Contacts.IsNotContactPresent())
            {
                ContactData contact = new ContactData("FirstnameCreatedToModify");
                contact.Lastname = "LastnameCreatedToModify";
                app.Contacts.Create(contact);
            }

            //action - действие
            ContactData contactNew = new ContactData("NewFirstame");
            contactNew.Lastname = "NewLastname";
            app.Contacts.Modify(contactNew);
        }
    }
}
