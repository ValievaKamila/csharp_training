using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        { 
            ContactData contact = new ContactData("Kamila5");
            contact.Lastname = "Valieva5";

            app.Contacts.Create(contact);
        }
    }
}
