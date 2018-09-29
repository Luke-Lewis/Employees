using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson beedle = new SalesPerson();
            beedle.Age = 28;
            beedle.Name = "Beedle";
            beedle.SalesNumber = 38;

            Manager ganondorf = new Manager("Ganondorf", 200, 4, 999999, "320-10-2923", 15000);
            double cost = ganondorf.GetBenefitCost();

            // Define my benefit level.
            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel =
                Employee.BenefitPackage.BenefitPackageLevel.Platinum;

            Console.ReadLine();
        }
    }
}
