

namespace WebAddressbookTests
{
	[TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
			GroupData newData = new GroupData("NewGroup1");
            newData.Header = "NewHeaderGroup1";
            newData.Footer = "NewFooterGroup1";
			
            app.Groups.Modify(1, newData);
        }
    }
}
