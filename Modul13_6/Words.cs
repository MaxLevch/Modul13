using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13_6_2
{
    public class Words
    {
        public int Amount { get; set; }
        public string Name { get; set; }

        public Words ( int amount, string name)
        {
            Amount = amount;
            Name = name;
        }
    }
}
