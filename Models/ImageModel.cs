using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class ImageModel
    {
        public string ID { get; set; }
        public string SCN { get; set; }
        public string DOB { get; set; }
        public string imageName { get; set; }
        public string imageData { get; set; }
        public string LastModifyBy { get; set; }
        public string LastModify { get; set; }
        public ImageModel SetDefaultValue()
        {
            var ImageModel = new ImageModel();
            ImageModel.ID = "";
            ImageModel.SCN = "";
            ImageModel.DOB = "";
            ImageModel.imageName = "";
            ImageModel.imageData = "";
            ImageModel.LastModifyBy = "";
            ImageModel.LastModify = "";
            return ImageModel;
        }
    }
}


