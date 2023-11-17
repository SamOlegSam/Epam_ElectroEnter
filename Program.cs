using System;

namespace Electro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //Создание и заполнение массивов расхода электроэнергии различными типами пользователей

            int[] array1 = new int[5];
            for (int i = 0; i < array1.Length; i++)
            { array1[i] = rand.Next(0, 200); }

            int[] array2 = new int[5];
            for (int i = 0; i < array2.Length; i++)
            { array2[i] = rand.Next(0, 200); }

            int[] array3 = new int[5];
            for (int i = 0; i < array3.Length; i++)
            { array3[i] = rand.Next(0, 200); }

            int[] array4 = new int[5];
            for (int i = 0; i < array4.Length; i++)
            { array4[i] = rand.Next(0, 200); }

            //Вывод заполненных массивов расхода электроэнергии

            Console.WriteLine("Расход электроэнергии обычных пользователей:");
            for (int i = 0; i < array1.Length; i++)
            { 
                Console.Write(array1[i] + " "); 
            }
            Console.WriteLine();

            Console.WriteLine("Расход электроэнергии пользователей с лимитом:");
            for (int i = 0; i < array2.Length; i++)
            { 
                Console.Write(array2[i] + " "); 
            }
            Console.WriteLine();

            Console.WriteLine("Расход электроэнергии льготных пользователей №1:");
            for (int i = 0; i < array3.Length; i++)
            { 
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Расход электроэнергии льготных пользователей №2:");
            for (int i = 0; i < array3.Length; i++)
            { 
                Console.Write(array3[i] + " "); 
            }
            Console.WriteLine();

            //Объединение масивов расхода электроэнергии
            int[] Rashod = new int[array1.Length + array2.Length+ array3.Length+ array4.Length];
            
        }
    }
}
