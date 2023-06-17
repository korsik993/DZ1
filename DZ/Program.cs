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
                    arr[i,j] = rnd.Next(6);
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

        static void findMin(int[,] arr)
        {
            int[] sum = new int[arr.GetLength(0)];
            int str = 1;

            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    sum[i] += arr[i,j];                    
                }                
            }
            
            int min = sum[0];
            
            for (int i = 0; i < sum.Length - 1; i++)
            {
                if (min > sum[i + 1])
                {
                    min = sum[i + 1];
                    str = i + 2;
                }
            }

            Console.WriteLine("Наименшая сумма элементов находится в " + str + " строке");
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

            findMin(arr);

            




            Console.ReadLine();
        }
    }
}
