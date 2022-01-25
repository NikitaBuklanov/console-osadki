using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work #1. GIT");
            Console.WriteLine("Variant #3. Osadki");
            Console.WriteLine("Author: Nikita Buklanov");
            Console.WriteLine("");

            string filename = "data.txt";
            int size = FileReader.SizeMas(filename);
            object[,] data_rw = new object[size, 4];

            FileReader.Read(filename, data_rw);

            for (int i = 0; i < size; i++)
            {
                string day = Convert.ToString(data_rw[i, 0]);
                string mounth = Convert.ToString(data_rw[i, 1]);
                string count = Convert.ToString(data_rw[i, 2]);
                string type = Convert.ToString(data_rw[i, 3]);

                Console.WriteLine(day + " " + mounth + " " + count + " " + type);
            }

            Console.ReadKey();
        }
    }
}
