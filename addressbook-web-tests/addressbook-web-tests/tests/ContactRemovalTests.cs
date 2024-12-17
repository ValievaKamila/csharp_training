using NUnit.Framework;


namespace WebAddressbookTests

{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            //prepare - подготовка
            if (app.Contacts.IsNotContactPresent())
            {
                ContactData contact = new ContactData("FirstnameCreatedToDelete");
                contact.Lastname = "LastnameCreatedToDelete";
                app.Contacts.Create(contact);
            }

            //action - действие
            app.Contacts.Remove();
        }
    }
}
