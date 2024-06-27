using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioEmpregadosOOCsharp.entities
{
    internal class Department
    {
        public string Name {  get; set; }
        public int PaymentDay { get; set; }
        public Address Address { get; set; }

        public List<Employee> Employees { get; set; }

        public Department(string name, int paymentDay, Address address)
        {
            Name = name;
            PaymentDay = paymentDay;
            Address = address;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public double Payroll()
        {
            double total = 0;
            foreach( var employee in Employees ) 
            {
                total += employee.Salary;
            
            }
            return total;
        
         }
    }
}
