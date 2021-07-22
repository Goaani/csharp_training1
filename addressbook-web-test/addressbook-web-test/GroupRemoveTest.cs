using NUnit.Framework;


namespace WebAddressBookTests
{
    class GroupRemoveTests : TestBase
    {
        
        [Test]
        public void GroupRemoveTest()
        {
            OpenHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            SelectGroup();
            RemoveGroup();
            ReturnToGroupsPage();
        }
    }
}
