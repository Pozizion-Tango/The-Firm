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

            Projectmanager projectmanager = new Projectmanager();
        }
    }
}
