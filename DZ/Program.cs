using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void rndArr(int[,] arr)
        {
            Random rnd = new Random();
            for(int i = 0;  i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(100);
                }
            }
        }

        static void showArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Sort(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0, a = 0; k < arr.GetLength(1); k++)
                    {
                        if (arr[i,j] > arr[i,k])
                        {
                            a = arr[i,j];
                            arr[i,j] = arr[i,k];
                            arr[i,k] = a;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введите количество элементов в строке: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr = new int[row, col];

            rndArr(arr);
            showArr(arr);

            Sort(arr);

            Console.WriteLine("--------------------------");

            showArr(arr);




            Console.ReadLine();
        }
    }
}
