using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;
using Scoliosis.Repositories;

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class TemplateRemarksHeaderController : Controller
    {
        //private readonly MyContext _context;
        private readonly IRepository<TemplateRemarksHeaderViewModel, int> _repository;

        public TemplateRemarksHeaderController(IRepository<TemplateRemarksHeaderViewModel, int> repository)
        {
            _repository = repository;
        }


        public ResultModel Get()
        {
            var result = new ResultModel();
            var TemplateRemarksHeaders = _repository.Find(x => x.Active == true).AsQueryable<TemplateRemarksHeaderViewModel>().AsNoTracking().OrderBy(z => z.Id);
            //var visisLists = new List<string>();

            result.IsSuccess = true;
            //result.Data = visisLists;
            result.Data = TemplateRemarksHeaders;

            return result;
        }

        [HttpGet("{id}")]
        public ResultModel Get(int id)
        {
            var result = new ResultModel();
            var TemplateRemarksHeader = _repository.Find(x => x.Id == id);

            result.IsSuccess = true;
            result.Data = TemplateRemarksHeader;

            return result;
        }

        [HttpPost]
        public ResultModel POST([FromBody]TemplateRemarksHeaderViewModel TemplateRemarksHeaderViewModel)
        {

            var result = new ResultModel();
            try
            {
                TemplateRemarksHeaderViewModel.CreatedDate = DateTime.Now;
                TemplateRemarksHeaderViewModel.ModifiedDate = DateTime.Now;
                _repository.Create(TemplateRemarksHeaderViewModel);
                result.Data = TemplateRemarksHeaderViewModel.Id;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPut]
        public ResultModel Put(int id, [FromBody]TemplateRemarksHeaderViewModel TemplateRemarksHeaderViewModel)
        {

            var result = new ResultModel();
            try
            {
                TemplateRemarksHeaderViewModel.ModifiedDate = DateTime.Now;
                _repository.Update(TemplateRemarksHeaderViewModel);
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