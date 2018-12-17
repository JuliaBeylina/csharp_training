using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        

        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            LogIn(new AccountData("admin", "secret"));
            InitNewContactCreation();

            ContactData contact = new ContactData();
            contact.Firstname = "Ivan";
            contact.Aday = "16";
            contact.Address2 = "Lenina street, 13";
            contact.Amonth = "October";
            contact.Ayear = "1977";
            contact.Bday = "25";
            contact.Bmonth = "March";
            contact.Byear = "1970";
            contact.Company = "Dream Work LTD";
            contact.Email = "petrovich1@gmail.com";
            contact.Email2 = "petrovich2@gmail.com";
            contact.Email3= "petrovich3@gmail.com";
            contact.Fax = "4952345678";
            contact.Home = "4991321455";
            contact.Homepage = "www.petrovich.com";
            contact.Lastname = "Sidorov";
            contact.Middlename = "Petrovich";
            contact.Mobile = "9163215544";
            contact.Nickname = "Petro";
            contact.Notes = "Really nice guy";
            contact.Phone2 = "4997675511";
            contact.Photo = "C:\\Users\\Mike\\Desktop\\Jajay.jpg";
            contact.Title = "Sidorov IP";
            contact.Work= "4996564321";
                     
            FillContactForm(contact);
           
            LogOut();
        }

        

        

        

        

        

        

        

        
    }
}
