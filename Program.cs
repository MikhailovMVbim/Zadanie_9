using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-= КАЛЬКУЛЯТОР*2000 версия 1.04ж =-");
            int operCode = 0;
            int res = 0;
            try
            {
                Console.Write("Введите целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции:\n" +
                    "\t1 - сложение\n" +
                    "\t2 - вычитание\n" +
                    "\t3 - произведение\n" +
                    "\t4 - частное");
                Console.Write("Ваш выбор: ");
                operCode = Convert.ToInt32(Console.ReadLine());
                switch (operCode)
                {
                    case 1:
                        res = a + b;
                        break;
                    case 2:
                        res = a - b;
                        break;
                    case 3:
                        res = a * b;
                        break;
                    case 4:
                        res = a / b;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException ();
                  }
                Console.WriteLine("Ваш выбор: {0}",operCode);
                Console.WriteLine("Результат: {0}", res);
            
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Неверный формат входных данных.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! Код операции введен неверно.");
            }

            Console.ReadKey();
        }
    }
}
