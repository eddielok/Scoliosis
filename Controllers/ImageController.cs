using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;
using System.Text.RegularExpressions;
using Scoliosis.Repositories;
using System.Globalization;

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class ImageController : Controller
    {
        private readonly IRepository<ImageModel, string> _repository;


        public ImageController(IRepository<ImageModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {
            var result = new ResultModel();
            var qsdata = scn.Split("|");

            var imageData = _repository.Find(x => 1 == 1).AsQueryable<ImageModel>().Where(y => y.SCN == qsdata[0] && y.DOB == qsdata[1]  && y.imageName == qsdata[3]);
            //var imageData = _repository.Find(x => 1 == 1).AsQueryable<ImageModel>().Where(y => y.SCN == qsdata[0] && y.DOB == qsdata[1] && y.LastModifyBy == qsdata[2] && y.imageName == qsdata[3]);
            //var imageData = _repository.Find(x => x.SCN == scn);

            result.IsSuccess = true;
            result.Data = imageData;

            return result;

        }

        [HttpGet("{scn}/{dob}/{lastmodifyby}/{imageName}")]
        public ResultModel Get(string scn, string dob, string lastmodifyby, string imageName)
        {
            var result = new ResultModel();
            var imageData = _repository.Find(x => 1 == 1).AsQueryable<ImageModel>().AsNoTracking().Where(y => y.SCN == scn && y.DOB == dob && y.LastModifyBy == lastmodifyby && y.imageName == imageName);
            //var visisLists = new List<string>();

            result.IsSuccess = true;
            //result.Data = visisLists;
            result.Data = imageData;

            return result;
        }

        [HttpPost]
        public ResultModel POST([FromBody]ImageModel imageModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(imageModel);
                result.Data = imageModel.SCN;

                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }


        [HttpPut("{SCN}")]
        public ResultModel Put(string SCN, [FromBody]ImageModel imageModel)
        {

            var result = new ResultModel();
            try
            {
                imageModel.SCN = SCN;

                _repository.Update(imageModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        [HttpDelete("{scn}")]
        public ResultModel Delete(string scn)
        {
            var result = new ResultModel();
            try
            {
                _repository.Delete(scn);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

    }
   
}