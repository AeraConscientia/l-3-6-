using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_3__6_
{
    class Rub : Account
    {
        private static double Kurs = 1;
        private double rubs = 0;

        public Rub(string surname, double rubs) : base(surname)
        {
            this.rubs = rubs;
        }
        public override double Number()
        {
            return rubs;
        }

        public override double To_Rub()
        {
            return rubs * Kurs;
        }
        public override string Information()
        {
            return string.Format("{0,-20}{2,10:f2}"+"₽"+"{1,10:f2}" + "₽",
                                 surname, rubs, To_Rub());
        }
    }
}
