using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BrovinaYV.Sprint4.Task6.V15.Lib
{
    public class DataService : ISprint4Task6V15
    {
        public int Calculate(string[] array)
        {
            int x = 0;
            foreach (string item in array)
            {
                if (item.Length < 7)
                    x++;
            }
            return x;
        }
    }
}
