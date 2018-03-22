using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите размер массива");
            //int.TryParse(Console.ReadLine(), out int size_mas);
            int size_mas = 0;
            try
            {
                size_mas = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Не допустимо вводить буквы или спецсимволы! Введите целое число.");
                size_mas = Convert.ToInt32(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow");
            }

            int[] mas1 = new int[size_mas];
            int K1 = 0;

            Array array = new Array(size_mas, mas1, K1);
            size_mas = array.size;

            Console.WriteLine($"Размер массива {array.size}");

            Console.WriteLine("Заполняем массив");
           
          for (int i = 0; i < array.mas.Length; i++)
            {
                Console.WriteLine($"Введите элемент номер {i}");
                try
                {
                    array.mas[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Не допустимо вводить буквы или спецсимволы! Введите число.");
                    array.mas[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow");
                }
            }

            Console.WriteLine("Ведите значение К");
            //int.TryParse(Console.ReadLine(), out int K);
            try
            {
                K1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Не допустимо вводить буквы или спецсимволы! Введите целое число.");
                K1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            Console.WriteLine($"K = {K1}");


            array.Calculation(0,0,0,0);
            Console.ReadLine();
        }
        
    }
}
