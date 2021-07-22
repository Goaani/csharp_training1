using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class ContactData
    {
        private string firstname;
        private string lastname;
        private string nickname;
        private string company;
        private string phone;
        private string email;

        public ContactData(string firstname/*, string lastname, string phone, string email, string company, string nickname*/)
        {
            Firstname = firstname;
            //Lastname = lastname;
            //Phone = phone;
            //Email = email;
            //Company = company;
            //Nickname = nickname;
        }

        public string Firstname 
        {
            get
            {
                return firstname;    
            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Phone 
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Email { get { return email; } set { email = value; } }
        public string Company { get { return company; } set { company = value; } }
        public string Nickname { get { return nickname; } set { nickname = value; } }
    }
}
