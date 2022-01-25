using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_project
{
    public class Process
    {
        public double ObKol(int mounth, double[,] arr)
        {
            int n = arr.GetLength(0);

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i, 0] == mounth)
                {
                    sum += arr[i, 1];
                }
            }
            return sum;
        }
    }
}
