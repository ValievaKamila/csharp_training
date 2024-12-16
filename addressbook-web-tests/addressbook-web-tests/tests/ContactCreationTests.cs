

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
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
