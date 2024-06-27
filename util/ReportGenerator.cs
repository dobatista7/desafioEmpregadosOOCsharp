using desafioEmpregadosOOCsharp.entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioEmpregadosOOCsharp.util
{
    internal class ReportGenerator
    {
        public void ShowReport(Department dept)
        {
            Console.WriteLine("\nFOLHA DE PAGAMENTO:");
            Console.WriteLine($"Departamento {dept.Name} = R$ {dept.Payroll().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pagamento realizado no dia {dept.PaymentDay}");
            Console.WriteLine("Funcionários:");
            foreach (var employee in dept.Employees)
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine($"Para dúvidas favor entrar em contato: {dept.Address.Email}");
        }

    }
}
