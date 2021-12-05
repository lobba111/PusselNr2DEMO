using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PusselNr2
{
    public class Input
    {
        public int Range { get; set; }
        public string Movement { get; set; }
        public Input(int range, string movement)
        {
            Range = range;
            Movement = movement;
        }
        
    }
}
