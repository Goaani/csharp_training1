// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class LoginandcreateGroupTest : TestBase
    {
        
        [Test]
        public void loginandcreateGroup()
        {
            OpenHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Footer = "ddd";
            group.Header = "hhh";
            SubmitGroupCreation();
            ReturnToGroupsPage();
        }

        
       

        
        

        

       
    }
}
