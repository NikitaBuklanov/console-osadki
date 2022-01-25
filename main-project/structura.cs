using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_project
{
    class structura
    {
        public int MAX_FILE_ROWS_COUNT = 100;
        public int MAX_STRING_SIZE = 200;

        public struct Date
        {
            public int day;
            public int month;
        }

        public struct Osadki
        {
            public double wind_count;
            public string wind_type;
        }

    }
}
