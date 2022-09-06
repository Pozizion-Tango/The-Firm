using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            
            Console.WriteLine("Karen: I am angry, i need to sue you. Give me all your vital info >:(((");
            
            employee.Info();
            Console.ReadKey();
        }
    }
}
