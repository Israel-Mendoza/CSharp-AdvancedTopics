using System;
using System.Collections.Generic;
using System.Text;

namespace Enums2
{
    class Employee
    {
        public string FullName { get; set; }
        public double Salary { get; set; }
        public double EmployeeBonus { get; private set; }

        public Employee(string fullName, double initialSalary, Bonus empBonus = Bonus.Low)
        {
            this.FullName = fullName;
            this.Salary = initialSalary;
            this.EmployeeBonus = (double)empBonus;
        }

        public void DisplayEmployeeTotalSalary() { Console.WriteLine($"{FullName} has a total salary of {(Salary + EmployeeBonus):c}"); }

        public void RaiseBonus()
        {
            switch (EmployeeBonus)
            {
                case 500:
                    EmployeeBonus = (double)Bonus.Normal;
                    Console.WriteLine("Bonus has been successfully raised!");
                    break;
                case 1000:
                    EmployeeBonus = (double)Bonus.Good;
                    Console.WriteLine("Bonus has been successfully raised!");
                    break;
                case 2000:
                    EmployeeBonus = (double)Bonus.High;
                    Console.WriteLine("Bonus has been successfully raised!");
                    break;
                default:
                    Console.WriteLine("Employee bonus could not be raised because the current bonus is not eligible for raise.");
                    break;
            }
        }

        public void LowerBonus()
        {
            switch (EmployeeBonus)
            {
                case 3000:
                    EmployeeBonus = (double)Bonus.Good;
                    Console.WriteLine("Bonus has been successfully lowered!");
                    break;
                case 2000:
                    EmployeeBonus = (double)Bonus.Normal;
                    Console.WriteLine("Bonus has been successfully lowered!");
                    break;
                case 1000:
                    EmployeeBonus = (double)Bonus.Low;
                    Console.WriteLine("Bonus has been successfully lowered!");
                    break;
                default:
                    Console.WriteLine("Employee bonus could not be lowered because the current bonus is not eligible for a decrement.");
                    break;
            }

        }
    }
}
