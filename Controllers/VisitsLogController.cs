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
    public class VisitsLogController : Controller
    {

        private readonly IRepository<VisitsLogViewModel, int> _repository;

        public VisitsLogController(IRepository<VisitsLogViewModel, int> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ResultModel Post([FromBody]VisitsLogViewModel visitsLogViewModel)
        {
            var result = new ResultModel();

            try
            {
                visitsLogViewModel.Action = visitsLogViewModel.Action;
                visitsLogViewModel.CreatedDate = DateTime.Now;
                visitsLogViewModel.id = 0;

                _repository.Create(visitsLogViewModel);

                result.Data = visitsLogViewModel.id;
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
