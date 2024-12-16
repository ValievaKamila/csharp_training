

namespace WebAddressbookTests
{
	[TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
			ContactData contactNew = new ContactData("NewName");
            contactNew.Lastname = "NewLastname";
			
            app.Contacts.Modify(contactNew);
        }
    }
}
