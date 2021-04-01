using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifunctional
{
    class Account
    {
        private string name;
        private string password;
        private double money;
       
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public double Money
        {
            set { money = value; }
            get { return money; }
        }
    }
}
