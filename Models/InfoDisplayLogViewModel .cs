using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoDisplayLogViewModel
    {
        public long id { get; set; }

        public string ModifiedBy { get; set; }

        public string LogDateTime { get; set; }

        public string ActionPage { get; set; }

        public string ActionType { get; set; }

        public string ActionDetail { get; set; }

        public string scn { get; set; }

        public string doc { get; set; }
    }

    
}
