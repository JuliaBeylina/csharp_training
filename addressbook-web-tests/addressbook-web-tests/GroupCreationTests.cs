using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests:TestBase
    {
        

        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            LogIn(new AccountData ("admin","secret"));
            GoToGroupPage();
            InitNewGroupCreation();
            GroupData group = new GroupData("new name");
            group.Header = "new header";
            group.Footer = "new footer";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            LogOut();
        }

        

        

        

        
        

        
    }
}
