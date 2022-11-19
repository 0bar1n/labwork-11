using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
namespace labwork
{
    class Program
    {
        static void Main(string[] args)
        {
            double summ = 0; //очищаем значение суммы
            int n = 1; //задаем начальное значение членов ряда
            double xn = 0.1; //задаем значение переменной ряда
            double e = 0.00001; //задаем точность
            do // начать цикл
            {
                xn = (Math.Pow(-1,n)*Math.Pow(2*xn,2*n) / Factorial(2 * n)); //вычисление n-го члена ряда
                summ += xn; //сумма членов ряда
                n++; //инкремент
            } while (Math.Abs(xn) > e); //цикл выполняется, пока верно условие
            Console.WriteLine($"Сумма членов рядa с заданной точностью равна: " +summ.ToString()); //вывод на консоль
            Console.ReadKey(); //ожтдание нажатие клавиши
        }

        private static double Factorial(int n) //вычисление факториала
        {
            if (n <= 1) return 1; //проверка выполнения условия
            else return Factorial(n - 1) * n; //другой исход
        }
    }
}