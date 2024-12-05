using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalendarzAdwentowy
{
    class Day
    {
        public int day;
        public string content;
        public string date;
        public Day(int day, string content, string date)
        {
            this.day = day;
            this.content = content;
            this.date = date;
        }
    }
}
