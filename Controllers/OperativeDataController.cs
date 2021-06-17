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
    public class OperativeDataController : Controller
    {
        private readonly IRepository<OperativeDataViewModel, string> _repository;


        public OperativeDataController(IRepository<OperativeDataViewModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {
            var result = new ResultModel();

            var visitsData = _repository.Find(x => x.SCN == scn).OrderByDescending(z => z.RecordID);

            result.IsSuccess = true;
            result.Data = visitsData;

            return result;

        }

        [HttpGet("{scn}/{recordId}")]
        public ResultModel Get(string scn, int recordId)
        {
            var result = new ResultModel();
            var visitsDatas = _repository.Find(x => 1 == 1).AsQueryable<OperativeDataViewModel>().AsNoTracking().Where(y => y.SCN == scn && y.RecordID == recordId).OrderByDescending(z => z.RecordID);
            //var visisLists = new List<string>();

            result.IsSuccess = true;
            //result.Data = visisLists;
            result.Data = visitsDatas;

            return result;
        }

        [HttpPost]
        public ResultModel POST([FromBody]OperativeDataViewModel operativeDataViewModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(operativeDataViewModel);
                result.Data = operativeDataViewModel.SCN;

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
        public ResultModel Put(string SCN, [FromBody]OperativeDataViewModel operativeDataViewModel)
        {

            var result = new ResultModel();
            try
            {
                operativeDataViewModel.SCN = SCN;

                _repository.Update(operativeDataViewModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        [HttpDelete("{scn}/{doc}")]
        public ResultModel Delete(string scn, string doc)
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