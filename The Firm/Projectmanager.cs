using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Projectmanager : Manager
    {
        private string email;
        protected internal string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Info()
        {
            this.Phonenumber = 09876543;
            this.Name = "Peter";
            this.Surname = "Griffen";
            this.CPR = "694201-3674";
            this.email = "PeterGriffenxx02@gmail.com";

            Console.WriteLine("Projectmanager: " + this.Name + " " + this.Surname + " " + this.CPR + " " + this.CPR + " " + email);
        }
    }
}
