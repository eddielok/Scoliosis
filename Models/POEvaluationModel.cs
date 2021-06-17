using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class POEvaluationModel
    {
        [Required]
        [Key]
        public string SCN { get; set; }
        public string Name { get; set; }
        public Nullable<DateTime> Born { get; set; }
        public string SSN { get; set; }
        public string Healthfund { get; set; }
        public string Chip { get; set; }
        public Nullable<DateTime> Activated { get; set; }
        public Nullable<DateTime> Periodfrom { get; set; }
        public Nullable<DateTime> Periodto { get; set; }
        public string Internal { get; set; }
        public Nullable<DateTime> LastModify { get; set; }
        public string LastModifyUser { get; set; }
       // public List<PODOCModel> PODOC { get; set; }

        public POEvaluationModel SetDefaultValue(string SCN)
        {
            var poevaluationModel = new POEvaluationModel();
            poevaluationModel.SCN = SCN;
            poevaluationModel.Name = "";
            poevaluationModel.Born = DateTime.Today.Date;
            poevaluationModel.SSN = "";
            poevaluationModel.Healthfund = "";
            poevaluationModel.Chip = "";
            poevaluationModel.Activated = DateTime.Today.Date;
            poevaluationModel.Periodfrom = DateTime.Today.Date;
            poevaluationModel.Periodto = DateTime.Today.Date;
            poevaluationModel.Internal = "";
            poevaluationModel.LastModify = null;
            poevaluationModel.LastModifyUser = "";
          //  poevaluationModel.PODOC = null;
            return poevaluationModel;
        }
    }
}
