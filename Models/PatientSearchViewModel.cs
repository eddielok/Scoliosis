using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class PatientSearchViewModel
    {
        public string Name { get; set; }
        public string SCN { get; set; }
        public string HKID { get; set; }
        public string SortBy { get; set; }
        public string Orderby { get; set; }
        public string kingOption { get; set; }
        public string Remarks { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string IsAllList { get; set; }
        public string Range { get; set; }
    }
}
