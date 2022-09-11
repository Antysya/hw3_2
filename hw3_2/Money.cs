using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_2
{
    internal class Money
    {
        public int Rub { get; set; }
        public int Kop { get; set; }
        public override string ToString()
        {
            return $"{Rub} руб. {Kop} коп.";
        }

        public static Money operator +(Money m, Money n)
        {
            Money sum = new Money
            {
                Rub = m.Rub + n.Rub,
                Kop = m.Kop + n.Kop
            };
            if (sum.Kop > 100)
            {
                sum.Rub++;
                sum.Kop -= 100; 
            }
            return sum;
        }
        public static Money operator -(Money m, Money n)
        {

            Money dif = new Money
            {
                Rub = m.Rub - n.Rub,
                Kop = m.Kop - n.Kop
            };
            if (dif.Kop < 0)
            {
                dif.Rub--;
                dif.Kop += 100;
            }
            return dif;

        }

        public static Money operator *(Money m, int x)
        {
            Money rez = new Money
            {
                Kop = m.Kop * x,
                Rub = m.Rub * x
            };
            if (rez.Kop > 100)
            {
                rez.Rub += (rez.Kop - (rez.Kop % 100)) / 100;
                rez.Kop %= 100;
            }
            return rez;
        }

    }
}
