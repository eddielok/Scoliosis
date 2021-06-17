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
    public class POImportController : Controller
    {
        private readonly IRepositoryPOImport<POImportModel, string> _repository;


        public POImportController(IRepositoryPOImport<POImportModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{Chip}")]
        public ResultModel Get(string Chip)
        {
            var result = new ResultModel();
            var POImportDatas = _repository.FindById(Chip);// _repository.Find(x => 1 == 1).AsQueryable<POImportModel>().AsNoTracking().Where(y => y.Serial == Serial  && y.Date.CompareTo(PeriodTo) <= 0);// Convert.ToDateTime(y.Date) >= from && Convert.ToDateTime(y.Date) <= to);
            var POImportLists = new List<string>();

            result.IsSuccess = true;
            result.Data = POImportDatas;

            return result;
        }
        

        [HttpPost]
        public ResultModel POST([FromBody] POImportModel poimportModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(poimportModel);
                result.Data = poimportModel.Serial.FirstOrDefault();

                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }


        [HttpPut("{Serial}")]
        public ResultModel Put(string Serial, [FromBody] POImportModel poimportModel)
        {

            var result = new ResultModel();
            try
            {
                poimportModel.Serial = Serial;

                _repository.Update(poimportModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        [HttpDelete("{Serial}")]
        public ResultModel Delete(string Serial)
        {
            var result = new ResultModel();
            try
            {
                _repository.Delete(Serial);
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