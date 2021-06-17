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
using System.IO;

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class PODOCController : Controller
    {
        private readonly IRepositoryPODOC<PODOCModel, string> _repository;


        public PODOCController(IRepositoryPODOC<PODOCModel, string> repository)
        {
            _repository = repository;
        }
        public ResultModel Get()
        {
            var result = new ResultModel();

            var uploadDocuments = _repository.Find(x => 1 == 1);

            result.IsSuccess = true;
            result.Data = uploadDocuments;

            return result;
        }

        [HttpGet("{id}")]
        public ResultModel Get(long id)
        {
            var result = new ResultModel();

            var uploadDocument = _repository.Find(x => x.Id == id);

            result.IsSuccess = true;
            result.Data = uploadDocument;

            return result;
        }

        [HttpGet("{Id}/{SCN}")]
        public ResultModel Get(string SCN)
        {
            var result = new ResultModel();

            var PODOCDatas = _repository.Find(x => 1 == 1).AsQueryable<PODOCModel>().AsNoTracking().Where(y => y.SCN == SCN);
            var PODOCLists = new List<string>();

            result.IsSuccess = true;
            result.Data = PODOCDatas;

            return result;
        }

        [HttpGet("{scn}/{dob}")]
        public ResultModel Get(string scn, string dob)
        {
            var result = new ResultModel();
            // DateTime doc = DateTime.ParseExact(dob, "yyyy-MM-dd", null);
            var PODOCData = _repository.Find(x => 1 == 1).AsQueryable<PODOCModel>().AsNoTracking().Where(y => y.SCN == scn && y.DOCDate.Value.ToString("yyyy-MM-dd") == dob);

            result.IsSuccess = true;
            result.Data = PODOCData;

            return result;
        }


        [HttpPost]
        public ResultModel POST([FromBody] PODOCModel PODOCModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(PODOCModel);
                result.Data = PODOCModel.SCN.FirstOrDefault();

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
        public ResultModel Put(string SCN, [FromBody] PODOCModel PODOCModel)
        {

            var result = new ResultModel();
            try
            {
               // PODOCModel.SCN = SCN;

                _repository.Update(PODOCModel);
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