using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] hillHeight = new double[3, 4] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };

            for(int row =0; row <hillHeight.GetLength(0); row++)
            {
                for(int col=0;col<hillHeight.GetLength(1);col++)
                {
                    Console.Write(hillHeight[row,col] + " ");
                }
            }
            Console.WriteLine( );
        }
    }
}
