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
            
            // A better bonus system!
            Manager ganondorf = new Manager("Ganondorf", 200, 4, 181000, "320-10-2923", 15000);
            double cost = ganondorf.GetBenefitCost();
            ganondorf.GiveBonus(3000);
            ganondorf.DisplayStats();
            Console.WriteLine();

            SalesPerson impa = new SalesPerson("Impa", 67, 21, 90000, "281-23-2180", 17);
            impa.GiveBonus(1000);
            impa.DisplayStats();

            // Define my benefit level.
            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel =
                Employee.BenefitPackage.BenefitPackageLevel.Platinum;          

            Console.ReadLine();
        }
    }
}
