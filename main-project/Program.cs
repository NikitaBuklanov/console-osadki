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
            Console.WriteLine("Group: 14z");
            Console.WriteLine("");

            string filename = "data.txt";
            int size = FileReader.SizeMas(filename);
            object[,] data_rw = new object[size, 4];

            Console.WriteLine("------ ОСАДКИ ------");
            Console.WriteLine("Дата | Кол-во | Тип");
            Console.WriteLine("");

            FileReader.Read(filename, data_rw);

            for (int i = 0; i < size; i++)
            {
                string day = Convert.ToString(data_rw[i, 0]);
                string mounth = Convert.ToString(data_rw[i, 1]);
                string count = Convert.ToString(data_rw[i, 2]);
                string type = Convert.ToString(data_rw[i, 3]);

                Console.WriteLine(day + "." + mounth + "  |  " + count.PadRight(5, ' ') + " | " + type.PadRight(5, ' '));
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("------ПО ТИПУ------");
            Console.WriteLine("Дата | Кол-во | Тип");
            Console.WriteLine("");

            for (int i = 0; i < size; i++)
            {
                if (Convert.ToString(data_rw[i, 3]) == "дождь")
                {
                    string day = Convert.ToString(data_rw[i, 0]);
                    string mounth = Convert.ToString(data_rw[i, 1]);
                    string count = Convert.ToString(data_rw[i, 2]);
                    string type = Convert.ToString(data_rw[i, 3]);

                    Console.WriteLine(day + "." + mounth + "  |  " + count.PadRight(5, ' ') + " | " + type.PadRight(5, ' '));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("------ПО КОЛ-ВУ-----");
            Console.WriteLine("Дата | Кол-во | Тип");
            Console.WriteLine("");

            for (int i = 0; i < size; i++)
            {
                if (Convert.ToDouble(data_rw[i, 2]) <= 1.5)
                {
                    string day = Convert.ToString(data_rw[i, 0]);
                    string mounth = Convert.ToString(data_rw[i, 1]);
                    string count = Convert.ToString(data_rw[i, 2]);
                    string type = Convert.ToString(data_rw[i, 3]);

                    Console.WriteLine(day + "." + mounth + "  |  " + count.PadRight(5, ' ') + " | " + type.PadRight(5, ' '));
                }
            }

            Console.ReadKey();
        }
    }
}
