using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_3__6_
{
    class Gold : Account
    {
        private static double Kurs = 3108270;
        private double kg_gold = 0;

        public Gold(string surname, double kg_gold) : base(surname)
        {
            this.kg_gold = kg_gold;
        }

        public override double Number()
        {
            return kg_gold;
        }

        public override double To_Rub()
        {
            return kg_gold * Kurs;
        }
        public override string Information()
        {
            return string.Format("{0,-20}{2,10:f2}"+ "₽" + "{1,10:f2}"+"кг",
                                 surname, kg_gold, To_Rub());
        }
    }
}
