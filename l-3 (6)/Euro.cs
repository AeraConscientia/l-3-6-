using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_3__6_
{
    class Euro : Account
    {
        private static double Kurs = 71.5;
        private double euros = 0;

        public Euro(string surname, double euros) : base(surname)
        {
            this.euros = euros;
        }
        public override double Number()
        {
            return euros;
        }


        public override double To_Rub()
        {
            return euros * Kurs;
        }
        public override string Information()
        {
            return string.Format("{0,-20}{2,10:f2}"+ "₽" + "{1,10:f2}"+ "€",
                                 surname, euros, To_Rub());
        }
    }
}
