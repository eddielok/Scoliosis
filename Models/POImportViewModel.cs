using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class POImportViewModel
    {
        public string datapoints { get; set; }
        // public List<string> labels { get; set; }
        public string labels { get; set; }
        public string avg { get; set; }
        public string upper { get; set; }
        public string lower { get; set; }

        public string count { get; set; }

        public string total { get; set; }

        public string percentage { get; set; }

        public POImportViewModel SetDefaultValue()
        {
            var poimportviewModel = new POImportViewModel();
            poimportviewModel.datapoints = "";
            poimportviewModel.labels = "";
            poimportviewModel.avg = "";
            poimportviewModel.upper = "";
            poimportviewModel.lower = "";
            poimportviewModel.count = "";
            poimportviewModel.total = "";
            poimportviewModel.percentage = "";
            return poimportviewModel;
        }
    }
}
