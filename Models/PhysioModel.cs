using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class PhysioModel
    {
        [Required]
        [Key]
        public string SCN { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DOC { get; set; }
        public int SRS22 { get; set; }
        public int SRS22Domains { get; set; }
        public int SAQ { get; set; }
        public int SAQDomains { get; set; }
        public decimal ExerciseCompliance { get; set; }
        public decimal BrQ { get; set; }

        public string Remarks { get; set; }
        public Nullable<DateTime> LastModify { get; set; }

        public string LastModifyUser { get; set; }

        public PhysioModel SetDefaultValue(string SCN)
        {
            var physioModel = new PhysioModel();
            physioModel.SCN = SCN;
            physioModel.DOC = DateTime.Now;
            physioModel.SRS22 = 0;
            physioModel.SRS22Domains = 0;
            physioModel.SAQ = 0;
            physioModel.SAQDomains = 0;
            physioModel.ExerciseCompliance = 0;
            physioModel.BrQ = 0;
            physioModel.LastModify = null;
            physioModel.LastModifyUser = "";
            physioModel.Remarks = "";
            return physioModel;
        }
    }
}
