using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoR.APIRest.Data.Requests
{
    public class GetCardByIdRequest
    {
        public int ID { get; set; }

        public string Signature { get; set; }
    }
}
