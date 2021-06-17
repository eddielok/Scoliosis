using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Scoliosis.Models
{
    public class UploadDocumentViewModel
    {

        [Required]
        [Key]
        public long Id { get; set; }

        public string Filename { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public static explicit operator UploadDocumentLoyoutViewModel(UploadDocumentViewModel uploadDocumentViewModel)
        {
            var uploadDocumentLoyoutViewModel = new UploadDocumentLoyoutViewModel();

            uploadDocumentLoyoutViewModel.Id = uploadDocumentViewModel.Id;
            uploadDocumentLoyoutViewModel.Filename = uploadDocumentViewModel.Filename;
            uploadDocumentLoyoutViewModel.Description = uploadDocumentViewModel.Description;
            uploadDocumentLoyoutViewModel.CreatedBy = uploadDocumentViewModel.CreatedBy;
            uploadDocumentLoyoutViewModel.CreatedDate = uploadDocumentViewModel.CreatedDate;
            uploadDocumentLoyoutViewModel.ModifiedBy = uploadDocumentViewModel.ModifiedBy;
            uploadDocumentLoyoutViewModel.ModifiedDate = uploadDocumentViewModel.ModifiedDate;

            return uploadDocumentLoyoutViewModel;

        }

    }
}
