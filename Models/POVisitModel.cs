using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class POVisitModel
    {
        [Required]
        [Key]
        public string SCN { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DOC { get; set; }
        public string User { get; set; }
        public Nullable<DateTime> BraceDate { get; set; }
        public int BraceType { get; set; }
        public string SpcType { get; set; }
        public int BraceCompliance { get; set; }
        public int BraceProblem { get; set; }
        public string SpcProblem { get; set; }
        public int BraceRenewal { get; set; }
        public string SpcRenewal { get; set; }
        public int BraceAdjustment { get; set; }
        public string SpcAdjustment { get; set; }
        public string Remarks { get; set; }
        public string ImgData { get; set; }
        public Nullable<DateTime> LastModify { get; set; }

        public string LastModifyUser { get; set; }

        //public static explicit operator POVisitModel(POVisitModel povisitModel)
        //{
        //    var povisitModel = new POVisitModel();
        //    povisitModel.SCN = 
        //    return povisitModel;
        //}
        public POVisitModel SetDefaultValue(string SCN)
        {
            var povisitModel = new POVisitModel();
            povisitModel.SCN = SCN;
            povisitModel.DOC = DateTime.Now;
            povisitModel.User = null;
            povisitModel.BraceDate = DateTime.Now;
            povisitModel.BraceType = 0;
            povisitModel.SpcType = "";
            povisitModel.BraceCompliance = 0;
            povisitModel.BraceProblem = 0;
            povisitModel.SpcProblem = "";
            povisitModel.BraceRenewal = 0;
            povisitModel.SpcRenewal = "";
            povisitModel.BraceAdjustment = 0;
            povisitModel.SpcAdjustment = "";
            povisitModel.Remarks = null;
            povisitModel.ImgData = "";
            povisitModel.LastModify = null;
            povisitModel.LastModifyUser = "";
            return povisitModel;
        }
    }
}
