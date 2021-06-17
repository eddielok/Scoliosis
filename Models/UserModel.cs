using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Scoliosis.Models
{
    public class UsersModel
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

        //[Required]
        //public String Name { get; set; }

        //public String Email { get; set; }

        //public String PhoneNumber { get; set; }

        //public String Address { get; set; }

        //[Required]
        //public string LinesPerPage { get; set; }


        [Key]
        public string Id { get; set; }

        [Required]
        public string BgColor { get; set; }

        [Required]
        public string TextColor { get; set; }
        [Required]
        public string TableBgColor { get; set; }
        [Required]
        public string TableTitleColor { get; set; }

        [Required]
        public string TableTitleColorSub1 { get; set; }

        [Required]
        public bool ShowRemarks { get; set; }

    }
}
