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
    public class ErrorLogController : Controller
    {
        private readonly IRepository<ErrorLogViewModel, int> _repository;

        public ErrorLogController(IRepository<ErrorLogViewModel, int> repository)
        {
            _repository = repository;
        }

     

        [HttpPost]
        public ResultModel Post([FromBody]ErrorLogViewModel errorLogViewModel)
        {
            var result = new ResultModel();
            _repository.Create(errorLogViewModel);
            result.Data = errorLogViewModel.Guid;
            result.IsSuccess = true;

            return result;
        }
    }
}