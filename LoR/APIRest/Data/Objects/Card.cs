using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoR.APIRest.Data.Objects
{
    public class Card
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int ManaCost { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }
    }
}
