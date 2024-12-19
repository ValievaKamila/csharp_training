using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressbookTests
{
	[TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            if (app.Groups.IsNotGroupPresent())
            {
                GroupData group = new GroupData("CreatedGroupToModify");
                group.Header = "HeaderCreatedGroupToModify";
                group.Footer = "FooterCreatedGroupToModify";
                app.Groups.Create(group);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData newData = new GroupData("NewGroup1");
            newData.Header = "NewHeaderGroup1";
            newData.Footer = "NewFooterGroup1";
            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
