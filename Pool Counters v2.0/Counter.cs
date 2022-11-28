using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    public class Counter
    {
        public string Champion { get; set; }
        public List<string> GoodAgainst { get; set; }

        public Counter(string Champion)
        {
            this.Champion = Champion;
            this.GoodAgainst = new List<string>();
        }
    }
}
