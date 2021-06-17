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
    public class POEvaluationController : Controller
    {
        private readonly IRepositoryPOEvaluation<POEvaluationModel, string> _repository;


        public POEvaluationController(IRepositoryPOEvaluation<POEvaluationModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{SCN}")]
        public ResultModel Get(string SCN)
        {
            var result = new ResultModel();

            var POEvaluationDatas = _repository.Find(x => 1 == 1).AsQueryable<POEvaluationModel>().AsNoTracking().Where(y => y.SCN == SCN);
            var POEvaluationLists = new List<string>();

            result.IsSuccess = true;
            result.Data = POEvaluationDatas;

            return result;
        }
        [HttpPut("{type}/{filepath}")]
        public ResultModel Put([FromBody] POEvaluationModel poevaluationModel, string type, string filepath)
        {
            var result = new ResultModel();
            var fPath = Path.Combine(
              Directory.GetCurrentDirectory(), "wwwroot",
              filepath);
            _repository.Update(poevaluationModel, type, fPath);

            result.IsSuccess = true;
            result.Data = "";

            return result;
        }

        [HttpPost]
        public ResultModel POST([FromBody] POEvaluationModel poevaluationModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(poevaluationModel);
                result.Data = poevaluationModel.SCN.FirstOrDefault();

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
        public ResultModel Put(string SCN, [FromBody] POEvaluationModel poevaluationModel)
        {

            var result = new ResultModel();
            try
            {
               // poevaluationModel.SCN = SCN;

                _repository.Update(poevaluationModel);
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