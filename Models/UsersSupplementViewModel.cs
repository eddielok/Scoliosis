using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace Scoliosis.Models
{
    public class UsersSupplementViewModel
    {
        [Required]
        [Key]
        public string UserId { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public string Role { get; set; }

        public Boolean Disabled { get; set; }

        public Boolean IsUserManager { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        

    }
}
