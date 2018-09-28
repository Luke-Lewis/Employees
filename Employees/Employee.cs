using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        // Field data
        private string empName;
        private int empId;
        private float currPay;
        private int empAge;
        private string empSSN = "";

        #region Properties
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("error! Name length exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empId; }
            set { empId = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        #endregion

        #region Getters and Setters
        // Accessor (get method)
        public string GetName()
        {
            return Name;
        }

        // Mutator (set method)
        public void SetName(string name)
        {
            // Do a check on incoming value before making assignment.
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                Name = name;
            }
        }
        #endregion

        #region Constructors
        // Constructors
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay) 
        {
            // User properties when setting class data. Always!
            // This reduces the amount of duplicate error checks.
            
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        #endregion

        #region Methods
        // Methods
        public void GiveBonus (float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
        }
        #endregion

    }
}
