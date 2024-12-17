using NUnit.Framework;


namespace WebAddressbookTests

{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            //prepare - подготовка
            if (app.Groups.IsNotGroupPresent())
            {
                GroupData group = new GroupData("CreatedGroupToDelete");
                group.Header = "HeaderCreatedGroupToDelete";
                group.Footer = "FooterCreatedGroupToDelete";
                app.Groups.Create(group);
            }

            //action - действие
            app.Groups.Remove(1);
        }
    }
}
