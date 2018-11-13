using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310.mvv.Lib
{
    public class elementaryParticle
    {
        public elementaryParticle()
        {
            name = "";
            group = "";
            charge = "0";
            weight = 0;
        }
        public string name { get; set; }
        public string group { get; set; }
        public string charge { get; set; }
        public float weight { get; set; }
    }
}
