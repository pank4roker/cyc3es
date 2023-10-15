using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Вывести на экран в столбик целые числа из интервала от 1 до n
            //(для решения задачи использовать операторы циклов: for, while, do -while).

            /*Write("Введите n: ");
            int n = Convert.ToInt32(ReadLine());
            for(int i = 0; i <= n; i++) 
            {
                WriteLine("i");
            }p0
            
            Write("Введите n: ");
            int n = Convert.ToInt32(ReadLine());
            int i = 0;
            do
            {
                i++;
                WriteLine(i);
            }
            while (i <= n);

            Write("Введите n: ");
            int n = Convert.ToInt32(ReadLine());
            int i = 0;
            while (i <= n)
            {
                WriteLine($"{i}");
                i++;
            }*/

            //task 2
            // Вывести четные двузначные числа и подсчитать их количество.

            /*int a = 0;
            for(int i =10;i<=99;i++)
            {
                if (i%2 ==0)
                { a++;
                    WriteLine(i);
                }
            }
            WriteLine($"Количество четных двузначных числе : {a}");*/

            //task 3
            //Составьте таблицу значений функции y = 2х2+4x-5 на отрезке [-5; 5] с шагом h = 0,2
            //(для решения задачи использовать операторы циклов: for, while, do-while).
            /*
            for(double x=-2;x<=2;x=x+0.2)
            {
                WriteLine($"x={x} \t y={2*Math.Pow(x,2) + 4*x - 5}");
            }
            */
            //task 4
            //Найти сумму чисел, кратных 5, в пределах от 0 до 1000.
            int sum = 0;
            for (int x=0;x<=1000;x++) 
            {
                if (x%5==0)
                {
                    sum += x;
                    
                }
            }
            WriteLine(sum);


            //task 5
            //Определить количество цифр заданного числа.
            /*Write("Введите число: ");
            int n = Convert.ToInt32(ReadLine());
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            WriteLine(count);*/
            ReadKey();
        }
    }
}
