using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class PODOCModel
    {
        [Required]
        [Key]
        public long Id { get; set; }
        public string SCN { get; set; }
        public string DOC { get; set; }
        public Nullable<DateTime> DOCDate { get; set; }
        public string DOCRemark { get; set; }
        public string LastModifyUser { get; set; }
        public Nullable<DateTime> LastModify { get; set; }
        public PODOCModel SetDefaultValue(string SCN)
        {
            var poDOCModel = new PODOCModel();
            poDOCModel.SCN = SCN;
            poDOCModel.DOC = "";
            poDOCModel.DOCDate = DateTime.Today.Date;
            poDOCModel.DOCRemark = "";
            poDOCModel.LastModifyUser = "";
            poDOCModel.LastModify = DateTime.Today.Date;
            return poDOCModel;
        }
    }
}
