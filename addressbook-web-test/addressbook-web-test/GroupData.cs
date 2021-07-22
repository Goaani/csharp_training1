using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class GroupData
    {
        private string name;
        private string header="";
        private string footer = "";

        public GroupData(string name)
        {
            this.name = name;
            //this.header = header;
        }

        //public GroupData(string nam, string header,string footer)
        //{
        //    this.name = name;
        //    this.header = header;
        //    this.footer = footer;
        //}

        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }

        public string Name { get { return name; } set { name = value; } }
        public string Footer
        {
            get
            {
                return footer;
            }
            set
            {
                footer = value;
            }
        }
    }
}
