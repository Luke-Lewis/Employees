using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        #region Constructors
        // As a general rule, all subclasses should explicitly call an appropriate base class constructor.
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us!
            SalesNumber = numbOfSales;
        }

        // Adding default constructor back in 
        public SalesPerson() { }
        #endregion
    }
}
