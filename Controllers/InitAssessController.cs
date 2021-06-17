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


namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class InitAssessController : Controller
    {
        //private readonly MyContext _context;
        private readonly IRepository<InitAssessViewModel, string> _repository;

        public InitAssessController(IRepository<InitAssessViewModel, string> repository)
        {
            _repository = repository;
        }


        [HttpPost("{scn}")]
        public ResultModel Post(string scn, [FromBody]InitAssessViewModel initialAssessmentViewModel)
        {
            var result = new ResultModel();

            try
            {
                initialAssessmentViewModel.LastModify = DateTime.Now;

                _repository.Create(initialAssessmentViewModel);

                result.Data = initialAssessmentViewModel;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;

            }
            return result;
        }

        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {
            var result = new ResultModel();
            var actionLogViewModel = _repository.Find(x => 1 == 1).AsQueryable<InitAssessViewModel>().AsNoTracking().Where(y => y.SCN == scn);

            result.Data = actionLogViewModel;
            result.IsSuccess = true;

            return result;
        }

        [HttpPut("{scn}")]
        public ResultModel Put(string scn, [FromBody]InitAssessViewModel initialAssessmentViewModel)
        {

            var result = new ResultModel();

            try
            {
                initialAssessmentViewModel.SCN = scn;

                _repository.Update(initialAssessmentViewModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;

            }
            return result;
        }

    }
}
