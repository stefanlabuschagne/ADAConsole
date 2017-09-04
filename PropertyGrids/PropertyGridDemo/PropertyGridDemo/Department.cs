using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using VS2005Components;


namespace PropertyGridDemo
{
    public class Department
    {
        private string mName;
        private string  mDepartmentID;
        private List<Employee> mEmployees = new List<Employee>();

        public Department()
        {
        }
        [Editor(typeof(CollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public List<Employee> Employees
        {
            get { return mEmployees; }
            set { mEmployees = value; }
        }	

        public string  DepartmentID
        {
            get { return mDepartmentID; }
            set { mDepartmentID = value; }
        }	
        
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
	
    }
}
