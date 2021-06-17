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
    public class PersonalInfoLogController : Controller
    {

        private readonly IRepository<PersonalInfoLogViewModel, int> _repository;

        public PersonalInfoLogController(IRepository<PersonalInfoLogViewModel, int> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ResultModel Post([FromBody]PersonalInfoLogViewModel personalInfoLogViewModel)
        {
            var result = new ResultModel();

            try
            {
                personalInfoLogViewModel.Action = personalInfoLogViewModel.Action;
                personalInfoLogViewModel.CreatedDate = DateTime.Now;
                personalInfoLogViewModel.id = 0;

                _repository.Create(personalInfoLogViewModel);

                result.Data = personalInfoLogViewModel.id;
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
