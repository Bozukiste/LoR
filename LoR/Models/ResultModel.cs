using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoR.Models
{
    public class ResultModel : TestModel
    {
        public string FullName 
        { 
            get
            {
                return this.Name + " " + this.SurName;
            }
        }

        public string[] Names { get; set; }

        public int ID { get; set; }
    }
}
