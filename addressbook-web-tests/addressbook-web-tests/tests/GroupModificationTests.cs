using NUnit.Framework;


namespace WebAddressbookTests
{
	[TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            //prepare - подготовка
            if (app.Groups.IsNotGroupPresent())
            {
                GroupData group = new GroupData("CreatedGroupToModify");
                group.Header = "HeaderCreatedGroupToModify";
                group.Footer = "FooterCreatedGroupToModify";
                app.Groups.Create(group);
            }

            //action - действие
            GroupData newData = new GroupData("NewGroup1");
            newData.Header = "NewHeaderGroup1";
            newData.Footer = "NewFooterGroup1";
            app.Groups.Modify(1, newData);
        }
    }
}
