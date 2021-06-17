using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class POConfigModel
    {
        [Required]
        public string ID { get; set; }
        public string temperature { get; set; }
        public string Hour { get; set; }
        public string MinHour { get; set; }
        public decimal AnkleLowerLimit { get; set; }
        public decimal AnkleUpperLimit { get; set; }
        public decimal OstpBraceLowerLimit { get; set; }
        public decimal OstpBraceUpperLimit { get; set; }
        public decimal OtherLowerLimit { get; set; }
        public decimal OtherUpperLimit { get; set; }
        public decimal SBLowerLimit { get; set; }
        public decimal SBUpperLimit { get; set; }
        public decimal SBCheneauLowerLimit { get; set; }
        public decimal SBCheneauUpperLimit { get; set; }
        public decimal SBBostonLowerLimit { get; set; }
        public decimal SBBostonUpperLimit { get; set; }
        public Nullable<DateTime> LastModify { get; set; }

        public string LastModifyUser { get; set; }
        public POConfigModel SetDefaultValue()
        {
            var poconfigModel = new POConfigModel();
            poconfigModel.ID = "1";
            poconfigModel.Hour = "";
            poconfigModel.MinHour = "";
            poconfigModel.AnkleLowerLimit = 0;
            poconfigModel.AnkleUpperLimit = 0;
            poconfigModel.OstpBraceLowerLimit = 0;
            poconfigModel.OstpBraceUpperLimit = 0;
            poconfigModel.OtherLowerLimit = 0;
            poconfigModel.OtherUpperLimit = 0;
            poconfigModel.SBCheneauLowerLimit = 0;
            poconfigModel.SBCheneauUpperLimit = 0;
            poconfigModel.SBBostonLowerLimit = 0;
            poconfigModel.SBBostonUpperLimit = 0;
            poconfigModel.LastModify = null;
            poconfigModel.LastModifyUser = "";
            return poconfigModel;
        }
    }
}
