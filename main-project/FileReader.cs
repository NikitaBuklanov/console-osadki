using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace main_project
{
    class FileReader
    {
        public static int SizeMas(string filename)
        {
            try
            {
                int count = System.IO.File.ReadAllLines(filename).Length;
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public static void Read(string filename, object[,] arr)
        {
            try
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

                using (StreamReader stream = new StreamReader(filename))
                {
                    int i = 0;
                    int count = SizeMas(filename);

                    structura.Osadki[] osadki_s = new structura.Osadki[count];
                    structura.Date[] date_s = new structura.Date[count];


                    while (stream.Peek() >= 0)
                    {
                        string str = stream.ReadLine(); 
                        string[] words = str.Split(' ');

                        date_s[i].day = Convert.ToInt32(words[0]);
                        date_s[i].month = Convert.ToInt32(words[1]);
                        osadki_s[i].wind_count = Convert.ToDouble(words[2]);
                        osadki_s[i].wind_type = words[3];
                        arr[i, 0] = date_s[i].day;
                        arr[i, 1] = date_s[i].month;
                        arr[i, 2] = osadki_s[i].wind_count;
                        arr[i, 3] = osadki_s[i].wind_type;
                        i++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Файл не найден");
            }
        }


    }
}
