using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точность для вычисления суммы ряда (e > 0) ...");
            bool ok = false;
            double e =0;// заданная точность
            // проверка корректности ввода
            while (ok == false)
            {
                //попытка конвертировать с постусловием
                try
                {
                    e = Convert.ToDouble(Console.ReadLine());
                    if (e > 0) ok = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("Некорректный ввод данных. Попробуйте ещё...");
                }
            }
            //счетчик суммы  и первый элемент для сравнения
            double count = 0, temp = Math.Pow(-2, 1) / 1;
            //факториал
            int fkt = 1;
            //количество подчитанных элементов
            int KolElem = 0;
            //реализация алгоритма составления ряда
            for (int i = 1; Math.Abs(temp) >= e; i++)
            {
                fkt *= i;
                count += Math.Pow(-2, i) / fkt;
                temp = Math.Pow(-2, i) / fkt;
                Console.WriteLine(temp);
                KolElem++;
            }
            Console.WriteLine("Сумма " + KolElem + " элементов равна " + count);
            Console.ReadLine();
        }
    }
}
