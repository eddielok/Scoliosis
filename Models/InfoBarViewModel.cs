using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoBarViewModel
    {
        public string SCN { get; set; }

        public string Name { get; set; }

        public string HKID { get; set; }

        public List<string> visits { get; set; }

        public List<string> POvisit { get; set; }

        public List<string> Physio { get; set; }
    }
}
