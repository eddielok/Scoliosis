using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;
using Scoliosis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class TemplateRemarksContentController: Controller
    {
        //private readonly MyContext _context;
        private readonly IRepository<TemplateRemarksContentViewModel, int> _repository;

        public TemplateRemarksContentController(IRepository<TemplateRemarksContentViewModel, int> repository)
        {
            _repository = repository;
        }


        public ResultModel Get()
        {
            var result = new ResultModel();
            var TemplateRemarksContents = _repository.Find(x => x.Active == true).AsQueryable<TemplateRemarksContentViewModel>().AsNoTracking().OrderBy(z => z.Id);
            //var visisLists = new List<string>();

            result.IsSuccess = true;
            //result.Data = visisLists;
            result.Data = TemplateRemarksContents;

            return result;
        }



        [HttpGet("{id}")]
        public ResultModel Get(int id)
        {
            var result = new ResultModel();
            var TemplateRemarksContent = _repository.Find(x => x.Id == id);

            result.IsSuccess = true;
            result.Data = TemplateRemarksContent;

            return result;
        }

        [HttpPost]
        public ResultModel POST([FromBody]TemplateRemarksContentViewModel TemplateRemarksContentViewModel)
        {

            var result = new ResultModel();
            try
            {
                TemplateRemarksContentViewModel.CreatedDate = DateTime.Now;
                TemplateRemarksContentViewModel.ModifiedDate = DateTime.Now;
                _repository.Create(TemplateRemarksContentViewModel);
                result.Data = TemplateRemarksContentViewModel.Id;
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
        public ResultModel Put([FromBody]TemplateRemarksContentViewModel TemplateRemarksContentViewModel)
        {

            var result = new ResultModel();
            try
            {
                TemplateRemarksContentViewModel.ModifiedDate = DateTime.Now;
                _repository.Update(TemplateRemarksContentViewModel);
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
