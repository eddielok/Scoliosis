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
    public class POConfigController : Controller
    {
        private readonly IRepository<POConfigModel, string> _repository;


        public POConfigController(IRepository<POConfigModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{ID}")]
        public ResultModel Get(string ID)
        {
            var result = new ResultModel();

            var POConfigDatas = _repository.Find(x => 1 == 1).AsQueryable<POConfigModel>().AsNoTracking().Where(y => y.ID == ID);
            var POConfigLists = new List<string>();

            result.IsSuccess = true;
            result.Data = POConfigDatas;

            return result;
        }


        [HttpPost]
        public ResultModel POST([FromBody] POConfigModel poconfigModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(poconfigModel);
                result.Data = poconfigModel.ID.FirstOrDefault();

                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }


        [HttpPut("{ID}")]
        public ResultModel Put(string ID, [FromBody] POConfigModel poconfigModel)
        {

            var result = new ResultModel();
            try
            {

                // _repository.Update(poconfigModel);
                _repository.Delete(ID);
                _repository.Create(poconfigModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        [HttpDelete("{ID}")]
        public ResultModel Delete(string ID)
        {
            var result = new ResultModel();
            try
            {
                _repository.Delete(ID);
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