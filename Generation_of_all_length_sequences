using System;
/*Генерация всех последовательностей длины n из чисел 0,1,...k-1 с минимальными изменениями
Требуется перечислить все последовательности длины n из чисел 0,..k-1 в таком порядке, чтобы каждая следующая отличалась от предыдущей в единственной
цифре, причем не более, чем на 1. */

namespace Generation_of_all_length_sequences
{
    class Program
    {
        public static int n = 4;
        public const int k = 4;
        public static int[] x = new int[n];
        public static int[] d = new int[n];

        static bool No(int i) // если i-ая шашка не может сделать ход, то возвращаем 1, если нет, то 0
        {

            if ((x[i] == k - 1 && d[i] == 1) || (x[i] == 0 && d[i] == -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 0; i < n; i++)
            {
                x[i] = 0;
                d[i] = 1;
            }

            while(true)
            {
                for (i = 0; i < n; i++)
                {
                    Console.Write(x[i] + " ");
                }
                Console.WriteLine();

                for (i = n - 1; i >= 0 && No(i); i--) ; // ищем самую правую шашку
                if (i == -1) break;
                x[i] = x[i] + d[i]; // если нашли, то делаем ход

                for (j = i + 1; j < n; j++) // у шашек, которые стоят правее, меняем направление стрелок
                {
                   d[j] = -d[j];
                }
            }
        }
    }
}
