using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BrovinaYV.Sprint4.Task4.V24.Lib
{
    public class DataService : ISprint4Task4V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int collumn = matrix.Length / rows;
            int x = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumn; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        matrix[i, j] = 1 ;
                }
            }
            return matrix;
        }
    }
}
