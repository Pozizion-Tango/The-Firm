using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Employee
    {
        private string name;
        private string surname;
        private string cpr;

        protected internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected internal string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        protected internal string CPR
        {
            get { return cpr; }
            set { cpr = value; }
        }

        public void Info()
        {
          this.Name = "Carl";
            this.Surname = "Carson";
            this.CPR = "1234567-8910";
           
            Console.WriteLine("Employee: " + this.Name + " " + this.Surname + " " + this.CPR);
            Manager manager = new Manager();
            manager.Info();
        }
    }
}
