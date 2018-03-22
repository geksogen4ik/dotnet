using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW5
{
    class Array
    {
        public int size;
        public int[] mas;
        public int K;
       

        public Array(int size, int[] mas, int K)
        {
            this.size = size;
            this.K = K;
            this.mas = mas;   //i'm trying to edit my code_sertyuiopkjhgfd


        }

       

        public void Calculation(int temp, int result, int result1, int count)
        {
            
            for (int i = 0; i < mas.Length; i++)
            {
                if ( mas[i] > K)
                {
                    temp = temp + mas[i];
                    count++;
                    result = temp / count;
                    mas[0] = result;
                   
                }

                else if (mas[i] < K )
                {
                    result1 = result1 + mas[i];
                    mas[0] = result1;
                    
                }

            }

            Console.WriteLine($"Новое значение первого элемента массива: {mas[0]}");

        }

    }

 }

