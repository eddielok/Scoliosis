using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class POImportModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Serial { get; set; }
        public string ReadingNr { get; set; }
        public string Date { get; set; }

        public string Time { get; set; }

        public string Value { get; set; }
        public POImportModel SetDefaultValue()
        {
            var poimportModel = new POImportModel();
            poimportModel.Serial = "";
            poimportModel.ReadingNr = "";
            poimportModel.Date = "";
            poimportModel.Time = "";
            poimportModel.Value = "";
            return poimportModel;
        }
    }
}
