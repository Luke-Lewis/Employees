using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public partial class Employee
    {
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            // Assume we have other members the represent dental/health benefits, and so on.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }    
}
