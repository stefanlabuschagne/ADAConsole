using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace PropertyGridDemo
{
    public class Employee
    {
        private string mFirstname;
        private string mLastName;

        [DisplayName("First Name")]
        [Description("The employee's first name")]
        public string Firstname
        {
            get { return mFirstname; }
            set { mFirstname = value; }
        }

        [DisplayName("Last Name")]
        [Description("The employee's last name")]
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }	
    }
}
