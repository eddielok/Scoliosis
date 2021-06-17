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
    public class PhysioController : Controller
    {
        private readonly IRepositoryDOC<PhysioModel, string> _repository;


        public PhysioController(IRepositoryDOC<PhysioModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {
            var result = new ResultModel();

            var visitsDatas = _repository.Find(x => 1 == 1).AsQueryable<PhysioModel>().AsNoTracking().Where(y => y.SCN == scn).OrderByDescending(z => z.DOC);
            var visisLists = new List<string>();


            //For hyperlink
            foreach (var visitsData in visitsDatas.ToList())
            {
                if (visitsData.DOC != null)
                {
                    visisLists.Add(visitsData.DOC.Value.ToString("yyyy-MM-dd"));
                }
            }

            result.IsSuccess = true;
            result.Data = visisLists;

            return result;
        }

        [HttpGet("{scn}/{dob}")]
        public ResultModel Get(string scn, string dob)
        {
            var result = new ResultModel();
           // DateTime doc = DateTime.ParseExact(dob, "yyyy-MM-dd", null);
            var povisitData = _repository.Find(x => 1 == 1).AsQueryable<PhysioModel>().AsNoTracking().Where(y => y.SCN == scn && y.DOC.Value.ToString("yyyy-MM-dd") == dob);

            result.IsSuccess = true;
            result.Data = povisitData;

            return result;
        }


        [HttpPost]
        public ResultModel POST([FromBody] PhysioModel physioModel)
        {
            var result = new ResultModel();

            try
            {
                _repository.Create(physioModel);
                result.Data = physioModel.SCN;

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
        public ResultModel Put(string SCN, [FromBody] PhysioModel physioModel)
        {

            var result = new ResultModel();
            try
            {
                physioModel.SCN = SCN;

                _repository.Update(physioModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        [HttpDelete("{scn}/{dob}")]
        public ResultModel Delete(string scn, string dob)
        {
            var result = new ResultModel();
            try
            {
                _repository.Delete(scn, dob);
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