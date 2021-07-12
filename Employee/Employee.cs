using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private double basicSalary;
        private double bonus;
        private int employeeId;

        public double BasicSalary { 
            get; 
            set; 
        }

        public double Bonus { 
            get; 
            set; 
        }

        public int EmployeeId { 
            get; 
            set; 
        }

        public virtual double CalculateSalary()
        {
            return 0.0;
        }
        

        public Employee()
        {
            basicSalary = 10000.0D;
        }
    }
}
