using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_3__6_
{
    class Dollar : Account
    {
        private static double Kurs = 64;
        private double dollars = 0;

        public double Dollars
        {
            get
            {
                return dollars;
            }
        }
        public override double Number()
        {
            return dollars;
        }

        public Dollar(string surname, double dollars) : base(surname)
        {
            this.dollars = dollars;
        }

        public override double To_Rub()
        {
            return dollars * Kurs;
        }
        public override string Information()
        {
            return string.Format("{0,-20}{2,10:f2}"+ "₽" + "{1,10:f2}"+"$",
                                 surname, dollars, To_Rub());
        }
    }
}
