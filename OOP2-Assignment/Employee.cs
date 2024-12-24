using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2_Assignment
{
    public class Employee
    {
        #region Private Atrributes

        private int id;
        private string name;
        private decimal salary;
        private char gender;

        //  private HiringDate hiringDate;          // (  For Q 6 )
        private string hiringDate;

        //  private SecurityPrivilege securityLevel;  // (  For Q 6 )
        private string securityLevel;

        #endregion


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public char Gender
        {
            get { return gender; }

            set
            {
                if (value == 'F' || value == 'M')

                    gender = value;

            }
        }


        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public string HiringDate
        {
            get { return hiringDate; }
            set { hiringDate = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Employee(int id, string name, decimal salary, string hiringDate, string securityLevel, char gender)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.hiringDate = hiringDate;
            this.securityLevel = securityLevel;
            this.gender = gender;

        }


        public override string ToString()
        {
            string formattedSalary = String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary);
            return $"Emp ID: {id} , Name: {name} , Salary : {formattedSalary} ,  hiringDate: {hiringDate} , Security Level: {securityLevel} , Gender: {gender} ";
        }


    }
}
