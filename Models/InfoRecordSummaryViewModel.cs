using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoRecordSummary
    {
       public string TodayDate { get; set; }

        public string PatientRecords { get; set; }

        public string VisitsRecords { get; set; }

        public string OperativeDataRecords { get; set; }

        public string XRayImages { get; set; }

        public string ClinicalPhotos { get; set; }

        public string ClinicalVideos { get; set; }
    }
}
