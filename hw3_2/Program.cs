//создать перегрузки: сложение 2х денег, вычитание, умножение на коэффициент
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace hw3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Меню:\n" +
                    "1. Сложение двух денежных сумм;\n" +
                    "2. Вычитание одной денежной суммы из другой;\n" +
                    "3. Умножение денежной суммы на коэффициент;\n" +
                    "4. Выйти из программы.\n\n Какое действие хотите произвести:\n");
                int pos = Convert.ToInt32(ReadLine());

                switch (pos)
                {
                    case 1:
                        {
                            WriteLine("Сложение двух денежных сумм:\n");
                            Write("Введите первую сумму:\nрублей: ");
                            Money m = new Money();
                            m.Rub = Convert.ToInt32(ReadLine());
                            Write("копеек: ");
                            m.Kop = Convert.ToInt32(ReadLine());
                            Write("Введите вторую сумму:\nрублей: ");
                            Money n = new Money();
                            n.Rub = Convert.ToInt32(ReadLine());
                            Write("копеек: ");
                            n.Kop = Convert.ToInt32(ReadLine());
                            WriteLine($"{m} + {n} = {m + n}");
                            WriteLine();
                        }
                        break;

                    case 2:                        
                        {
                            WriteLine("Вычитание одной денежной суммы из другой:\n");
                            Write("Введите первую сумму:\nрублей: ");
                            Money m = new Money();
                            m.Rub = Convert.ToInt32(ReadLine());
                            Write("копеек: ");
                            m.Kop = Convert.ToInt32(ReadLine());
                            Write("Введите вторую сумму:\nрублей: ");
                            Money n = new Money();
                            n.Rub = Convert.ToInt32(ReadLine());
                            Write("копеек: ");
                            n.Kop = Convert.ToInt32(ReadLine());
                            WriteLine($"{m} - {n} = {m - n}");
                            WriteLine();
                        }
                        break;
                    case 3:
                        {
                            WriteLine("Умножение денежной суммы на коэффициент:\n");
                            Write("Введите сумму:\nрублей: ");
                            Money m = new Money();
                            m.Rub = Convert.ToInt32(ReadLine());
                            Write("копеек: ");
                            m.Kop = Convert.ToInt32(ReadLine());
                            Write("Введите коэффициент: ");
                            int n = Convert.ToInt32(ReadLine());
                            WriteLine($"{m} * {n} = {m * n}");
                            WriteLine();
                        }
                        break;
                    case 4:
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;
                }
            }
        }
    }
}


