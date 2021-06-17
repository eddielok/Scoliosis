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
    public class ActionLogController : Controller
    {
        //private readonly MyContext _context;
        private readonly IRepository<ActionLogViewModel, int> _repository;

        public ActionLogController(IRepository<ActionLogViewModel, int> repository)
        {
            _repository = repository;
        }


        [HttpPost]
        public ResultModel Post([FromBody]ActionLogViewModel actionLogViewModel)
        {
            var result = new ResultModel();

            try
            {
                actionLogViewModel.CreatedDate = DateTime.Now;
                actionLogViewModel.Id = 0;

                _repository.Create(actionLogViewModel);

                result.Data = actionLogViewModel.Id;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;

            }
            return result;
        }

        [HttpGet("{scn}/{type}")]
        public ResultModel Get(string scn, string type)
        {

            var result = new ResultModel();
            var actionLogViewModel = _repository.Find(x => 1 == 1).AsQueryable<ActionLogViewModel>().AsNoTracking().Where(y => y.scn == scn && y.ActionPage == type);

            result.Data = actionLogViewModel;
            result.IsSuccess = true;

            return result;
        }

        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {

            var result = new ResultModel();
            var actionLogViewModel = _repository.Find(x => 1 == 1).AsQueryable<ActionLogViewModel>().AsNoTracking().Where(y => y.scn == scn);

            result.Data = actionLogViewModel;
            result.IsSuccess = true;

            return result;
        }


        [HttpGet]
        public ResultModel GetAll()
        {

            var result = new ResultModel();
            var actionLogViewModel = _repository.Find(x => 1 == 1).AsQueryable<ActionLogViewModel>().AsNoTracking().OrderByDescending(x=>x.Id);

            result.Data = actionLogViewModel;
            result.IsSuccess = true;

            return result;
        }


        [HttpGet("{scn}/{type}/{doc}")]
        public ResultModel Get(string scn, string type, DateTime doc)
        {

            var result = new ResultModel();
            var actionLogViewModel = _repository.Find(x => 1 == 1).AsQueryable<ActionLogViewModel>().AsNoTracking().Where(y => y.scn == scn && y.doc == doc && y.ActionPage == type);
            
            result.Data = actionLogViewModel;
            result.IsSuccess = true;

            return result;
        }




    }


}