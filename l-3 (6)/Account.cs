using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_3__6_
{
    abstract class Account
    {
        protected string surname;

        public Account(string surname)
        {
            this.surname = surname;
        }

        abstract public double To_Rub();

        abstract public string Information();

        abstract public double Number();
    }
}
