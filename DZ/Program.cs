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
        static void rndArr(int[,,] arr)
        {
            Random rnd = new Random();
            bool exist;
            int rndNew;
            for(int i = 0;  i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2);)
                    {
                        exist = false;
                        rndNew = rnd.Next(10,100);

                        for (int a = 0; a < arr.GetLength(0); a++)
                        {
                            for (int b = 0; b < arr.GetLength(1); b++)
                            {
                                for (int c = 0; c < arr.GetLength(2); c++)
                                {
                                    if (arr[a, b, c] == rndNew)
                                    {
                                        exist = true;
                                        break;
                                    }
                                    if (exist == true)
                                        break;
                                }
                                if (exist == true)
                                    break;
                            }
                            if (exist == true)
                                break;
                        }

                        if (!exist)
                        {
                            arr[i, j, k] = rndNew;
                            k++;
                        }
                    }
                }
            }
        }

        static void showArr(int[,,] arr)
        {
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i,j,k]} ({i},{j},{k}) \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-------------------------------------------");
            }
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Размер трёхмерного массива будет [3,3,3] ");
                      

            int[,,] arr = new int[3,3,3];
            
            rndArr(arr);

            showArr(arr);

            Console.ReadLine();
        }
    }
}
