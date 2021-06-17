
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace Scoliosis.Models
{
    public class ErrorLogViewModel
    {
        [Key]
        [Required]
        public Int64 Id { get; set; }

        [Required]
        public string Guid { get; set; }

        public string Page { get; set; }

        public string ExceptionalMessage { get; set; }

        public string InnerExceptionMessage { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
