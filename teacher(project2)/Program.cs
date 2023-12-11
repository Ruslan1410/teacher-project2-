using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_project2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int j =int.Parse(Console.ReadLine());
            int [] array = new int[j];
            Console.WriteLine(array[array.Length - 1]);  // 0
            Console.Write("Введите ячейки массива: ");
            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(Console.ReadLine());

            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {

                if (max < array[i])
                {
                    max = array[i];
                }
                if (min > array[i])
                {
                    min  = array[i];
                }
            }
            Console.WriteLine("Максимальное число: " + max);
           
            Console.WriteLine("Минимальное число: " +min);

        }
    }
}
