using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Finance finance = new Finance();
            SystemsEngineer systemsEngineer = new SystemsEngineer("Java");
            SeniorProjectManager seniorProjectManager = new SeniorProjectManager();
            Manager manager = new Manager();
            Console.WriteLine(finance.GetCalculatedSalary(systemsEngineer));
            Console.WriteLine(finance.GetCalculatedSalary(seniorProjectManager));
            Console.WriteLine(finance.GetCalculatedSalary(manager));
        }   
    }
}
