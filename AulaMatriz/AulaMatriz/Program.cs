using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                int[,] numeros = {
                { 2, 0, 0, 0, 0, 0 },
                { 1, 2, 0, 0, 0, 0 },
                { 1, 1, 2, 0, 0, 0 },
                { 1, 1, 1, 2, 0, 0 },
                { 1, 1, 1, 1, 2, 0 },
                { 1, 1, 1, 1, 1, 2 }
            };

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write(numeros[i, j] + "\t"); 
                }
                Console.WriteLine(); 
            }
        }
            */


            int[,] mat = new int[6, 6];

            for (int i = 0; i < mat.GetLength(0); i++)
                

            {
              
                for (int j = 0; j < mat.GetLength(1); j++)
                    
                {

                    mat[i, j] = 1;
                    mat[j, i] = 0;
                  
                }
                mat[i, i] = 2;

            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]  + " ");
                }
                Console.WriteLine();
            }



        }
    }
}