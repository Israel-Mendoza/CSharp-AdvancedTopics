using System;

namespace Enums2
{
    
    enum Bonus {Low = 500, Normal = 1000, Good = 2000, High = 3000};
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Israel Mendoza", 17300, Bonus.Normal);

            emp1.DisplayEmployeeTotalSalary();

            emp1.RaiseBonus();

            emp1.DisplayEmployeeTotalSalary();

            emp1.LowerBonus();

            emp1.DisplayEmployeeTotalSalary();

            emp1.LowerBonus();

            emp1.DisplayEmployeeTotalSalary();

            emp1.LowerBonus();

            emp1.DisplayEmployeeTotalSalary();
        }
    }
}
