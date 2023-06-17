using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
                    arr[i,j] = rnd.Next(1,5);
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

        static int[,] multiArr(int[,] arr1, int[,] arr2, int side)
        {
            int[,] arrMult = new int[side, side];

            for (int i = 0;i < side; i++)
            {
                for(int j = 0;j < side; j++)
                {                                      
                    for (int k = 0;k < side; k++)
                    {
                        arrMult[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            return arrMult;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int side = int.Parse(Console.ReadLine());

            int[,] arr1 = new int[side, side];

            int[,] arr2 = new int[side, side];

            rndArr(arr1);
            rndArr(arr2);

            Console.WriteLine("Матрица № 1");
            showArr(arr1);
            Console.WriteLine("Матрица № 2");
            showArr(arr2);

            int[,] multArr = multiArr(arr1 , arr2, side);

            Console.WriteLine("Произведение 2-х квадратных матриц");
            showArr(multArr);

            Console.ReadLine();
        }
    }
}
