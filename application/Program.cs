using desafioEmpregadosOOCsharp.entities;
using desafioEmpregadosOOCsharp.util;
using System.Globalization;

namespace desafioEmpregadosOOCsharp.application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nome do departamento: ");
            string deptName = Console.ReadLine();

            Console.Write("Dia do pagamento: ");
            int paymentDay = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Telefone: ");
            string phone = Console.ReadLine();

            Address address = new Address(email, phone);
            Department dept = new Department(deptName, paymentDay,address);

            Console.Write("Quantos funcionários tem o departamento? ");
            int numEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numEmployees; i++) 
            {
                Console.WriteLine($"Dados do funcionário {i}: ");

                Console.Write("Nome: ");
                string empName = Console.ReadLine();

                Console.Write("Salário: ");
                double empSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee emp = new Employee(empName, empSalary);
                dept.AddEmployee(emp);
            }

            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.ShowReport(dept);

        }
    }
}
