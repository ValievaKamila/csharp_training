

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("Group1");
            group.Header = "HeaderGroup1";
            group.Footer = "FooterGroup1";
            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("Group2");
            group.Header = "";
            group.Footer = "";
            app.Groups.Create(group);
        }
    }
}
