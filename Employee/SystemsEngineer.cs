using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class SystemsEngineer : Employee
    {
        
        public double SpecialistAllowance { 
            get; 
            set; 
        }

        public string Specialization {
            get;
            set;
        }

        public override double CalculateSalary()
        {
            if (Specialization == "C#" || Specialization == "Java" || Specialization == "SQL")
            {
                SpecialistAllowance = 3000.0D;
            }
            else
            {
                SpecialistAllowance = 0.0D;
            }

            double salary = BasicSalary + SpecialistAllowance;
            return salary;
        }

        public SystemsEngineer(string specialization)
        {
            Specialization = specialization;
        }
        public SystemsEngineer() : base()
        {

        }
    }
}
