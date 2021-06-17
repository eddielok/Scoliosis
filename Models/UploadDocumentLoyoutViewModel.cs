using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class UploadDocumentLoyoutViewModel
    {
        public long Id { get; set; }

        public string Filename { get; set; }

        public string Description { get; set; }

        public IFormFile file { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        public static explicit operator UploadDocumentViewModel(UploadDocumentLoyoutViewModel uploadDocumentLoyoutViewModel)
        {
            var uploadDocumentViewModel = new UploadDocumentViewModel();

            uploadDocumentViewModel.Id = uploadDocumentLoyoutViewModel.Id;
            uploadDocumentViewModel.Filename = uploadDocumentLoyoutViewModel.Filename;
            uploadDocumentViewModel.Description = uploadDocumentLoyoutViewModel.Description;
            uploadDocumentViewModel.CreatedBy = uploadDocumentLoyoutViewModel.CreatedBy;
            uploadDocumentViewModel.CreatedDate = uploadDocumentLoyoutViewModel.CreatedDate;
            uploadDocumentViewModel.ModifiedBy = uploadDocumentLoyoutViewModel.ModifiedBy;
            uploadDocumentViewModel.ModifiedDate = uploadDocumentLoyoutViewModel.ModifiedDate;

            return uploadDocumentViewModel;

        }
    }
}
