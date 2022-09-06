using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Manager : Employee
    {
        private int phonenumber;

        protected internal int Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        public void Info()
        {
            this.Phonenumber = 12345678;
            this.Name = "John";
            this.Surname = "Johnson";
            this.CPR = "098765-8008";
            Console.WriteLine("Manager: " + this.Name + " " + this.Surname + " " + this.CPR + " " + this.CPR);
            Projectmanager projectmanager = new Projectmanager();
            projectmanager.Info();
        }
    }
}
